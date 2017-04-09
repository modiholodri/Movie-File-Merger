/*
 * Created by Modi
 * Date: 2012-04-09
 */
 
// Copyright 2012-2017 Reinhold Lauer
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using MediaInfoLib;
using WinSCP;


namespace Movie_File_Merger
{
    /// <summary>
    /// Application to selectively combine collections on hard disks.
    /// </summary>
    public partial class MFMForm : Form {
        ListView lvDragSource = null;  // the list view from which has been dragged
        Color DragColor = Color.Red;  // the color of the item which has been dragged
        string[] saCollections = { "Miscellaneous", "Adults", "Movies", "Documentaries", "Series", "Clips" }; // all collections
        string strCollectionType = "Miscellaneous";  // the active collection type
        MediaInfo miThis = new MediaInfo( );  // detailed information about the video file from MediaInfo
        int iAddedCount = 1;

        // item colors		
        Color GarbageColor = Color.SaddleBrown;
        Color ExistingColor = Color.ForestGreen;
        Color WishColor = Color.LimeGreen;
        Color NeutralColor = Color.Silver;

        Color LowResColor = Color.IndianRed;
        Color HigherResColor = Color.MediumSpringGreen;

        Color GoodMovieColor = Color.SeaGreen;
        Color GoodDocuColor = Color.LawnGreen;
        Color GoodEpisodeColor = Color.PaleGreen;
        Color BadMovieColor = Color.MediumVioletRed;
        Color BadDocuColor = Color.HotPink;
        Color BadEpisodeColor = Color.PaleVioletRed;
        Color BadNameColor = Color.Pink;

        // list change indicators when exiting a collection type
        bool bExistingChanged = false;
        bool bGarbageChanged = false;
        bool bWishChanged = false;

        // paths to standard files and folders
        string strPrivatePath = Path.Combine( Path.GetDirectoryName( Application.StartupPath ), @"MFM Private\" );
        string strCollectionsPath = Path.Combine( Path.GetDirectoryName( Application.StartupPath ), @"MFM Collections\" );
        string strTeraCopyPath = "";
        string strTeraCopyListsPath = "";
        string strXmlSettingsFilePath = "";
        string strNickName = "";

        string strImportFolder = "";
        string strTargetFolder = "";

        // regular expressions to filter the messed up file names
        Regex rgxMainExtensions;  // to find the main files
        Regex rgxAddonExtensions;  // to find wanted addon files, like subtitles
        Regex rgxEpisodesId;  // to find the episode identifier
        Regex rgxTrimBefore;  // the names will be cut of before, like 720p
        Regex rgxAphanumeric;  // only accept clean charaecters in the name
        Regex rgxToLower;  // words in the name that should be lower case, like the, to, for, of
        Regex rgxMultiSpace = new Regex( @"[ ]{2,}" );  // two spaces in a row
        Regex rgxNumber = new Regex( @"\d+" );  // any integer number

        // Thread Stuff
        private delegate void UpdateListViewDelegate( string strName, FileInfo fiFile, ListView lvThis );
        private delegate void UpdateStatusDelegate( string strMessage );
        ListView lvToAdd = null;
        string strGlobalFolderName;


        /// <summary>
        /// MFM main form to selectivley combine video collections
        /// </summary>
        public MFMForm( )
        {
            InitializeComponent( );
            LogInfo( "Initializing Movie File Merger..." );

            // make sure that all needed directroies and files are there
            if ( !Directory.Exists( strPrivatePath ) ) {
                Directory.CreateDirectory( strPrivatePath );
            }
            if ( !Directory.Exists( strCollectionsPath ) ) {
                Directory.CreateDirectory( strCollectionsPath );
            }
            strTeraCopyListsPath = Path.Combine( strPrivatePath, @"TeraCopy Lists\" );
            if ( !Directory.Exists( strTeraCopyListsPath ) ) {
                Directory.CreateDirectory( strTeraCopyListsPath );
            }
            sfdMovieFileMerger.InitialDirectory = strCollectionsPath;

            LoadSettings( false );

            Text = strNickName + " - Movie File Merger";

            // load the instruction and copyright files
            string strMFMInstructionsPath = Path.Combine( Application.StartupPath, "Movie File Merger Instructions.rtf" );
            try {
                rtbHelp.LoadFile( strMFMInstructionsPath, RichTextBoxStreamType.RichText );
            } catch ( IOException e ) {
                ShowInfo( e.Message );
                rtbHelp.Text = "Error: Had problems loading the help file " + strMFMInstructionsPath + ".";
            }

            string strMFMSettingsPath = Path.Combine( Application.StartupPath, "Movie File Merger Settings.rtf" );
            try {
                rtbSettings.LoadFile( strMFMSettingsPath, RichTextBoxStreamType.RichText );
            } catch ( IOException e ) {
                ShowInfo( e.Message );
                rtbSettings.Text = "Error: Had problems loading the settings instructions file " + strMFMSettingsPath + ".";
            }

            string strMFMCopyrightPath = Path.Combine( Application.StartupPath, "Movie File Merger Copyright.rtf" );
            try {
                rtbCopyright.LoadFile( strMFMCopyrightPath, RichTextBoxStreamType.RichText );
            } catch ( IOException e ) {
                ShowInfo( e.Message );
                rtbCopyright.Text = "Error: Had problems loading the copyright file " + strMFMSettingsPath + ".";
            }

            SetListTabColumnWidth( );
            // set the button colors in the list tab
            lvGarbage.BackColor = GarbageColor;
            lvExisting.BackColor = ExistingColor;
            lvWish.BackColor = WishColor;
            lvImport.BackColor = NeutralColor;

            cobMinimumResolution.BackColor = LowResColor;
            cbGetHigherRes.BackColor = HigherResColor;

            // set the button and lable colors in the maintenance tab
            btnBadDocu.BackColor = BadDocuColor;
            lblBadDocuNameRegex.BackColor = BadDocuColor;
            btnBadEpisode.BackColor = BadEpisodeColor;
            lblBadEpisodeNameRegex.BackColor = BadEpisodeColor;
            btnBadMovie.BackColor = BadMovieColor;
            lblBadMovieNameRegex.BackColor = BadMovieColor;

            btnBadName.BackColor = BadNameColor;
            btnUnrelatedFile.BackColor = NeutralColor;

            btnGoodDocu.BackColor = GoodDocuColor;
            lblGoodDocuNameRegex.BackColor = GoodDocuColor;
            btnGoodEpisode.BackColor = GoodEpisodeColor;
            lblGoodEpisodeNameRegex.BackColor = GoodEpisodeColor;
            btnGoodMovie.BackColor = GoodMovieColor;
            lblGoodMovieNameRegex.BackColor = GoodMovieColor;

            lvDragSource = lvExisting; // to avoid null exception
            CheckLatestVersion( "Startup" );
        }

        /************************************************************************************************/
        /*                                    Supporting Functions                                      */
        /************************************************************************************************/

        #region General Form or Element Handling

        /// <summary>
        /// Converts a datetime to the standard date format yyyy-mm-dd.
        /// </summary>
        /// <param name="dtToStandardize">The date time to standardize.</param>
        /// <returns>The standzadized date string.</returns>
        public string StandardizeDate( DateTime dtToStandardize )
        {
            return dtToStandardize.Year.ToString( "D4" ) + "-" +
                    dtToStandardize.Month.ToString( "D2" ) + "-" +
                    dtToStandardize.Day.ToString( "D2" );
        }

        /// <summary>
        /// Converts a datetime to the standard time format hh:mm:ss.
        /// </summary>
        /// <param name="dtToStandardize">The date time to standardize.</param>
        /// <returns>The standzadized time string.</returns>
        string StandardizeTime( DateTime dtToStandardize )
        {
            return dtToStandardize.Hour.ToString( "D2" ) + "-" +
                    dtToStandardize.Minute.ToString( "D2" ) + "-" +
                    dtToStandardize.Second.ToString( "D2" );
        }

        /// <summary>
        /// Readjusts the column width of the lists in the Lists tab if the Window is resized. 
        /// </summary>
        void SetListTabColumnWidth( )
        {
            if ( this.WindowState == FormWindowState.Minimized ) {  // Not if minimized
                return;
            }
            int iColumnWidth = (this.Size.Width - 37) / 3;
            scVertical.SplitterDistance = iColumnWidth;
            scVerticalRight.Width = iColumnWidth * 2;
            scVerticalRight.SplitterDistance = iColumnWidth + 3;
            scVerticalRight.SplitterWidth = 3;
            lvExisting.Columns[ 0 ].Width = lvExisting.Width - 35;
            lvGarbage.Columns[ 0 ].Width = lvGarbage.Width - 35;
            lvImport.Columns[ 0 ].Width = lvImport.Width - 35;
            lvWish.Columns[ 0 ].Width = lvWish.Width - 35;
        }

        /// <summary>
        /// Readjusts the column width of the horizoltal splitter in the Lists tab if the Window is resized. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MainFormSizeChanged( object sender, EventArgs e )
        {
            if ( this.WindowState == FormWindowState.Minimized ) {  // Not if minimized
                return;
            }
            scHorizontal.SplitterDistance = scHorizontal.Size.Height / 2;
        }

        /// <summary>
        /// Resize the columns if the spliter has been moved.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void ScVerticalSplitterMoved( object sender, SplitterEventArgs e )
        {
            SetListTabColumnWidth( );
        }

        /// <summary>
        /// The MFM windos has been shown.  
        /// Initialize all list views.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void MfShown( object sender, EventArgs e )
        {
            InitListViewFromFile( lvGarbage );
            InitListViewFromFile( lvExisting );
            InitListViewFromFile( lvWish );
        }

        /// <summary>
        /// The form is closing. 
        /// Save changed lists and the settings.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void MfFormClosing( object sender, FormClosingEventArgs e )
        {
            SaveChangedListView( lvExisting );
            SaveChangedListView( lvGarbage );
            SaveChangedListView( lvWish );
            SaveSettings( );
        }

        /// <summary>
        /// The mouse entered a rich text box.  
        /// Put it in focus, so that the scrolling works.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void RtbMouseEnter( object sender, System.EventArgs e )
        {
            ((RichTextBox)sender).Focus( );
        }

        /// <summary>
        /// A link in a richtext box has been clicked.  Start the link with the default browser.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void LinkClicked( object sender, LinkClickedEventArgs e )
        {
            ExecuteThis( e.LinkText );
        }

        /// <summary>
        /// Execute the command in the system.
        /// </summary>
        /// <param name="sCommand">The command to execute.</param>
        void ExecuteThis( string sCommand )
        {
            System.Diagnostics.Process.Start( sCommand );
        }

        /// <summary>
        /// Go to How to Organize Videos on Hard Disks to read about how a video collection could be organized.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void PbHowToClick( object sender, EventArgs e )
        {
            ExecuteThis( "http://modi777.gitbooks.io/how-to-oraganize-videos-on-your-hard-disks" );
        }

        /// <summary>
        /// Go to the MFM web site to get additional information or access the forum.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void PbBannerClick( object sender, EventArgs e )
        {
            ExecuteThis( "https://movie-file-merger.org" );
        }

        /// <summary>
        /// Go to the MFM User Manual to read more details about how to use MFM.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void PbUserManualClick( object sender, EventArgs e )
        {
            ExecuteThis( "http://modi777.gitbooks.io/movie-file-merger-user-manual" );
        }

        /// <summary>
        /// Show the Hand mouse pointer when the mouse enters a link picture box.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void PbPictureLinkMouseEnter( object sender, EventArgs e )
        {
            ((PictureBox)sender).Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Show the Default mouse pointer when the mouse leaves a link picture box.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void PbPictureLinkMouseLeave( object sender, EventArgs e )
        {
            ((PictureBox)sender).Cursor = Cursors.Default;
        }

        #endregion General Form or Element Handling

        /************************************************************************************************/
        /*                                              Lists Tab                                       */
        /************************************************************************************************/

        #region Collections Processing

        /// <summary>
        /// Make the target path, including file name, for file to be copied or moved.
        /// </summary>
        /// <param name="fiImportFile">The file to be copied or moved.</param>
        /// <returns>The path of the new file.</returns>
        string MakeTargetPath( FileInfo fiImportFile )
        {
            string strTargetPath = "";

            // TODO: fix later, just a placeholder for now
            // if ( true ) { // move all relevant file into the same folder
            strTargetPath = strTargetFolder;
            // }
            // else { // keep the folder structure as it is in the source folder
            //	string sSubPath = fiImportFile.DirectoryName.Substring( fiImportFile.DirectoryName.IndexOf( '\\' )+1 );
            //	strTargetPath = Path.Combine( strTargetFolder, sSubPath );
            //}

            if ( !Directory.Exists( strTargetPath ) ) {
                Directory.CreateDirectory( strTargetPath );
            }

            return strTargetPath;
        }

        /// <summary>
        /// Generates the lists to be handed over to TeraCopy and updates the colocrs of the lists.
        /// </summary>
        void ProcessImport( )
        {
            if ( !Directory.Exists( strImportFolder ) ) {
                ShowInfo( "Select a folder with the " + strCollectionType + " to import...\n" +
                         "Just drop the folder in the Import list." );
                return;
            }
            if ( !Directory.Exists( strTargetFolder ) ) {
                ShowInfo( "Select a target folder...\n" +
                         "Just drop the folder in the Existing list." );
                return;
            }

            SetStatus( "Start processing..." );
            string sSourceListFileName = "";
            StreamWriter swSourceListFile = null;
            string sOldTargetPath = "";
            string sTargetPath = "";
            string sSourceFile;
            bool bSourceListOpen = false;
            bool bCopiedOrMovedSomething = false;

            if ( !File.Exists( strTeraCopyPath ) ) {
                ShowInfo( "Could not find TeraCopy. You can download it from\n    www.movie-file-merger.org/downloads.html\nOr set the path in the next dialog..." );
                ofdTeraCopy.InitialDirectory = @"C:\Program Files";
                ofdTeraCopy.ShowDialog( );
                strTeraCopyPath = ofdTeraCopy.FileName;
                return;
            }

            // tag the items to be copied or moved
            foreach ( ListViewItem lviThis in lvImport.Items ) {
                lviThis.Tag = (lviThis.BackColor == WishColor) || (lviThis.BackColor == HigherResColor);
            }

            var diImportFolder = new DirectoryInfo( strImportFolder );
            SearchOption soMovieFileMerger = SearchOption.AllDirectories;

            foreach ( FileInfo fiImportFile in diImportFolder.GetFiles( "*", soMovieFileMerger ) ) {
                string strImportName = fiImportFile.Name;
                // ignore not relevant files
                if ( !rgxMainExtensions.IsMatch( fiImportFile.Extension.ToLower( ) ) &&
                    !rgxAddonExtensions.IsMatch( fiImportFile.Extension.ToLower( ) ) ) {
                    continue;
                }

                // cut the file extension, to reduce list entries to only one per item
                if ( strImportName.LastIndexOf( '.' ) != -1 ) {
                    strImportName = strImportName.Substring( 0, strImportName.LastIndexOf( '.' ) );
                }

                strImportName = CleanName( RemoveEpisodeInfo( strImportName ) );
                ListViewItem lviImport = FindItem( lvImport, strImportName );
                if ( lviImport != null ) {
                    if ( (bool)lviImport.Tag == true ) {
                        sTargetPath = MakeTargetPath( fiImportFile );
                        sSourceFile = fiImportFile.FullName; //" \"" +  + "\" ";

                        if ( sOldTargetPath != sTargetPath ) {
                            if ( bSourceListOpen ) {
                                swSourceListFile.Close( );
                                bSourceListOpen = false;
                                DoTeraCopy( sSourceListFileName, sOldTargetPath );
                            }
                            sOldTargetPath = sTargetPath;
                        }
                        if ( !bSourceListOpen ) {
                            sSourceListFileName = "TeraCopy List - " + strNickName + " " +
                                                  StandardizeDate( DateTime.Now ) + " " +
                                                  StandardizeTime( DateTime.Now ) + " " +
                                                  sTargetPath.Replace( "\\", " - " ).Replace( ':', ' ' ) +
                                                  ".tcl";
                            sSourceListFileName = Path.Combine( strTeraCopyListsPath, sSourceListFileName );
                            swSourceListFile = new StreamWriter( sSourceListFileName, false, Encoding.Unicode );
                            bSourceListOpen = true;
                            sOldTargetPath = sTargetPath;
                        }
                        /*
						if ( rbCopy.Checked ) {
							LogMessage( "Add to Source List", Color.Blue, "Copy " + 
							            sSourceFile + " -> " + sTargetPath );
						}
						else {
							LogMessage( "Add to Source List", Color.Blue,  "Move " + 
							            sSourceFile + " -> " + sTargetPath );
						}
						*/
                        swSourceListFile.WriteLine( sSourceFile );
                        ListViewItem lviExisting;
                        lviExisting = AddItemToListView( lvExisting, lviImport );
                        if ( HorizontalResolutionIsHigher( lviExisting, lviImport ) ) {
                            lviExisting.ToolTipText = lviImport.ToolTipText;
                            ColorAll( lviExisting.Text );
                            SetListViewChanged( lvExisting, true );
                        }
                        bCopiedOrMovedSomething = true;
                    }
                }
            }
            if ( bSourceListOpen ) {
                swSourceListFile.Close( );
                DoTeraCopy( sSourceListFileName, sOldTargetPath );
            }
            if ( bCopiedOrMovedSomething ) {
                if ( File.Exists( strTeraCopyPath ) ) {
                    ShowInfo( "Finished processing..." );
                }
            }
            else {
                ShowInfo( "Did not find anything to copy or move...\nDid you put something in the Wish list?" );
            }
            ClearStatus( );
        }

        /// <summary>
        /// Does the final handover to TeraCopy.
        /// </summary>
        /// <param name="sSourceListFile">The file containing the sources files to be copied or moved.</param>
        /// <param name="sTargetPath">The path to where the source files should be copied or moved. </param>
        void DoTeraCopy( string sSourceListFile, string sTargetPath )
        {
            const string sOptions = " /SkipAll /Close ";

            if ( rbCopy.Checked ) {
                System.Diagnostics.Process.Start( strTeraCopyPath, "Copy *\"" +
                                                    sSourceListFile + "\" \"" + sTargetPath + "\" " + sOptions );
                LogMessage( "Starting Process", Color.Purple, "TeraCopy " +
                            sSourceListFile + " -> " + sTargetPath + sOptions );
            }
            else {
                System.Diagnostics.Process.Start( strTeraCopyPath, "Move *\"" +
                                              sSourceListFile + "\" \"" + sTargetPath + "\" " + sOptions );
                LogMessage( "Starting Process", Color.Purple, "TeraMove " +
                            sSourceListFile + " -> " + sTargetPath + sOptions );
            }
            System.Threading.Thread.Sleep( 1000 );
        }

        /// <summary>
        /// The collection type has been changed.  
        /// Save changed list and load the new ones.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void RbCollectionsClick( object sender, EventArgs e )
        {
            var rbRadioButton = (RadioButton)sender;

            if ( rbRadioButton.Checked ) {
                strCollectionType = rbRadioButton.Tag.ToString( );
                LogInfo( "Switching to " + strCollectionType );
                lvImport.Items.Clear( );
                InitListViewFromFile( lvGarbage );
                InitListViewFromFile( lvExisting );
                InitListViewFromFile( lvWish );
            }
            else {
                SaveChangedListView( lvGarbage );
                SaveChangedListView( lvExisting );
                SaveChangedListView( lvWish );
            }
        }

        /// <summary>
        /// Converts the selected minimum vertical pixels into the horizontal pixels.
        /// </summary>
        /// <returns>The minimum horizontal resolution.</returns>
        int GetMinimumResolution( )
        {
            int iMinimumResolution = 0;
            switch ( cobMinimumResolution.Text ) {
                case " <~0p (FLD)": iMinimumResolution = 0; break;
                case " <~360p (nHD)": iMinimumResolution = 640; break;
                case " <~540p (qHD)": iMinimumResolution = 960; break;
                case " <~720p (HD)": iMinimumResolution = 1280; break;
                case " <~900p (HD+)": iMinimumResolution = 1600; break;
                case " <~1080p (Full HD)": iMinimumResolution = 1920; break;
                case " <~1440p (WQHD)": iMinimumResolution = 2560; break;
                case " <~2160p (4K UHD)": iMinimumResolution = 3840; break;
                case " <~2880p (UHD+)": iMinimumResolution = 5120; break;
                case " <~4320p (8K FUHD)": iMinimumResolution = 7680; break;
                case " <~8640p (16k QUHD)": iMinimumResolution = 15360; break;
                default: iMinimumResolution = 0; break;
            }
            return iMinimumResolution * 97 / 100;  // cut off 3 percent to make it more tolerant
        }

        /// <summary>
        /// Sart the processing of the files in the import folder.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnStartProcessClick( object sender, EventArgs e )
        {
            ProcessImport( );
        }

        #endregion Collections Processing

        #region Drop Area Handling

        /// <summary>
        /// Plays the video of the item dropped on the Play droparea with the default system player.
        /// The file to be played has to be located in the Import folder.
        /// </summary>
        void Play( )
        {
            bool bPlayedSomething = false;
            if ( !Directory.Exists( strImportFolder ) ) {
                ShowInfo( "Select a folder with " + strCollectionType + " to play..." );
                return;
            }

            var diImportFolder = new DirectoryInfo( strImportFolder );
            SearchOption soMovieFileMerger = SearchOption.AllDirectories;

            foreach ( FileInfo fiImportFile in diImportFolder.GetFiles( "*", soMovieFileMerger ) ) {
                if ( !rgxMainExtensions.IsMatch( fiImportFile.Extension.ToLower( ) ) ) {
                    continue;
                }

                string strImportName = fiImportFile.Name;
                if ( fiImportFile.Name.LastIndexOf( '.' ) != -1 ) {
                    strImportName = strImportName.Substring( 0, fiImportFile.Name.LastIndexOf( '.' ) );
                }
                strImportName = CleanName( strImportName );
                ListViewItem lviImport = FindItem( lvImport, strImportName );
                if ( lviImport != null ) {
                    if ( lviImport.Selected ) {
                        SetStatus( "Playing " + fiImportFile.Name + "..." );
                        try {
                            ExecuteThis( fiImportFile.FullName );
                            bPlayedSomething = true;
                        }
                        catch ( Exception e ) {
                            ShowInfo( e.Message );
                        }
                    }
                }
                ClearStatus( );
            }
            if ( !bPlayedSomething ) {
                ShowInfo( "Did not find an according file under the Import path." );
            }
        }

        /// <summary>
        /// Something has been draged over a droparea.  
        /// Change the cursor accordingly.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnDragOver( object sender, DragEventArgs e )
        {
            if ( e.Data.GetDataPresent( typeof( ListView.SelectedListViewItemCollection ) ) ) {
                e.Effect = e.AllowedEffect;
            }
            if ( e.Data.GetDataPresent( DataFormats.FileDrop ) ) {
                e.Effect = e.AllowedEffect;
            }
        }

        /// <summary>
        /// A list view has been drop on the Export Lists droparea.
        /// Save the list view to a CSV file.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnExportListDragDrop( object sender, DragEventArgs e )
        {
            if ( (string)lvDragSource.Tag == "Maintenance" ) {
                LvMaintenanceDragDrop( sender, e );
            }
            sfdMovieFileMerger.FileName =
                strNickName + " " +
                (string)lvDragSource.Tag + " " +
                strCollectionType + " " +
                StandardizeDate( DateTime.Today );
            if ( sfdMovieFileMerger.ShowDialog( ) == DialogResult.OK ) {
                sfdMovieFileMerger.InitialDirectory = "";  // take the same folder next time
                if ( sfdMovieFileMerger.FileName.EndsWith( ".xml" ) ) {
                    SaveListViewToXmlFile( lvDragSource, sfdMovieFileMerger.FileName );
                }
                if ( sfdMovieFileMerger.FileName.EndsWith( ".csv" ) ) {
                    SaveListViewToCsvFile( lvDragSource, sfdMovieFileMerger.FileName );
                }
                if ( sfdMovieFileMerger.FileName.EndsWith( ".tsv" ) ) {
                    SaveListViewToTsvFile( lvDragSource, sfdMovieFileMerger.FileName );
                }
                if ( (string)lvDragSource.Tag == "Maintenance" ) {
                    lvDragSource = lvExisting;
                }
            }
        }

        /// <summary>
        /// Items have been dropped on the Erase Selected drop area. 
        /// Erase the selected items from the list view.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnEraseSelectedDragDrop( object sender, DragEventArgs e )
        {
            EraseSelected( lvDragSource );
        }

        /// <summary>
        /// An item has been droped on the Erase Color drop area.  
        /// Erase all items with the same color from the list view.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnEraseColorDragDrop( object sender, DragEventArgs e )
        {
            foreach ( ListViewItem lviThis in lvDragSource.SelectedItems ) {
                DragColor = lviThis.BackColor;
                break;
            }
            EraseColorFromListView( lvDragSource, DragColor );
        }

        /// <summary>
        /// An item has been dropped on the Play Video droparea.
        /// Play it with the default player.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnPlayDragDrop( object sender, DragEventArgs e )
        {
            if ( (string)lvDragSource.Tag == "Maintenance" ) {
                foreach ( string strPath in (string[])e.Data.GetData( DataFormats.FileDrop ) ) {
                    if ( rgxMainExtensions.IsMatch( strPath ) ) {
                        ExecuteThis( strPath );
                    }
                }
                LvMaintenanceDragDrop( sender, e );
                lvDragSource = lvExisting;
            }
            else if ( (string)lvDragSource.Tag == "Import" ) {
                Play( );
            }
            else {
                ShowInfo( "Playing is only supported from the Import or Maintenance list." );
            }
        }

        /// <summary>
        /// Searches on the internet for the selected items of the list view, 
        /// which has been droped on the Search Info droparea.
        /// </summary>
        /// <param name="strName">The name for which to search. Can be also the file path.</param>
        void SearchInfo( string strName )
        {
            string strSearchWhat = "+Movie";
            string strCleanName = Path.GetFileNameWithoutExtension( strName );  // get only the name
            LogMessage( "Info", Color.Blue, "Searching info for " + strCleanName );

            if ( rgxEpisodesId.IsMatch( strName ) || ( rbSeries.Checked && tpSeparateLists.ContainsFocus ) ) {
                strSearchWhat = "+TV+Series";
            }
            strCleanName = CleanName( strCleanName );
            strCleanName = RemoveEpisodeInfo( strCleanName );
            strCleanName = strCleanName.Replace( ' ', '+' );

            switch ( cobSearchInfo.Text ) {
                case "Best Below":
                    // All Movie
                    ExecuteThis( "http://www.allmovie.com/search/all/" + strCleanName );
                    // IMDb
                    ExecuteThis( "http://www.imdb.com/find?q=" + strCleanName + "&s=tt" );
                    // The Movie Dd
                    ExecuteThis( "https://www.themoviedb.org/search?query=" + strCleanName );
                    // ExecuteThis( "http://www.movieposterdb.com/search/?query=" + strCleanName );
                    ExecuteThis( "http://thetvdb.com/?string=" + strCleanName + "&searchseriesid=&tab=listseries&function=Search" );
                    // TrailerAddict http://www.traileraddict.com/search/Abraham+Lincoln+Vampire+Hunter
                    ExecuteThis( "http://www.traileraddict.com/search/" + strCleanName );
                    // Open Movie Database http://www.omdbapi.com/?t=Kill+Bill&y=&&type=movie&plot=full&r=xml
                    // ExecuteThis( "http://www.omdbapi.com/?t=/" + strCleanName + "&y=&&type=movie&plot=full&r=xml" );
                    // Google https://www.google.com/search?q=kill+bill+movie
                    ExecuteThis( "https://www.google.com/search?q=" + strCleanName + strSearchWhat );
                    // Yahoo https://search.yahoo.com/search?p=kill+bill+movie
                    ExecuteThis( "https://search.yahoo.com/search?p=" + strCleanName + strSearchWhat );
                    // Rotten Tomatoes https://www.rottentomatoes.com/search/?search=kill%20bill
                    ExecuteThis( "https://www.rottentomatoes.com/search/?search=" + strCleanName );
                    // FMovies https://fmovies.se/search?keyword=kill%20bill
                    ExecuteThis( "https://fmovies.se/search?keyword=" + strCleanName );
                    // DuckDuckGo https://duckduckgo.com/?q=kill+bill+movie
                    ExecuteThis( "https://duckduckgo.com/?q=" + strCleanName + strSearchWhat );
                    // Movie Web http://movieweb.com/search/q=kill+bill
                    // ExecuteThis( "http://movieweb.com/search/q=" + strCleanName );
                    // YouTube https://www.youtube.com/results?search_query=kill+bill+movie
                    ExecuteThis( "https://www.youtube.com/results?search_query=" + strCleanName + strSearchWhat );
                    // Fandom http://wikia.com/wiki/Special:Search?query=kill+bill+movie
                    // ExecuteThis( "http://wikia.com/wiki/Special:Search?query=" + strCleanName + "+movie" );
                    // TV Guide http://www.tvguide.com/movies/database/moviesearch.asp?SearchType=0&name=kill+bill
                    // ExecuteThis( "http://www.tvguide.com/movies/database/moviesearch.asp?SearchType=0&name=" + strCleanName );
                    // MRQE http://www.mrqe.com/search?q=kill+bill
                    ExecuteThis( "http://www.mrqe.com/search?q=" + strCleanName );
                    // Hollywood.com http://www.hollywood.com/search/?s=kill%20bill
                    ExecuteThis( "http://www.hollywood.com/search/?s=" + strCleanName );
                    // CineMaterial https://www.cinematerial.com/search?q=kill+bill
                    ExecuteThis( "https://www.cinematerial.com/search?q=" + strCleanName );
                    break;
                case "All Movie":
                    ExecuteThis( "http://www.allmovie.com/search/all/" + strCleanName );
                    break;
                case "IMDb":
                    ExecuteThis( "http://www.imdb.com/find?q=" + strCleanName + "&s=tt" );
                    break;
                case "The Movie DB":
                    ExecuteThis( "https://www.themoviedb.org/search?query=" + strCleanName );
                    break;
                case "The Movie Poster DB":
                    ExecuteThis( "http://www.movieposterdb.com/search/?query=" + strCleanName );
                    break;
                case "The TVDB":
                    ExecuteThis( "http://thetvdb.com/?string=" + strCleanName + "&searchseriesid=&tab=listseries&function=Search" );
                    break;
                case "Trailer Addict":
                    ExecuteThis( "http://www.traileraddict.com/search/" + strCleanName );
                    break;
                case "Adult DVD Empire":
                    ExecuteThis( "http://www.adultdvdempire.com/allsearch/search?q=" + strCleanName );
                    break;
                case "Open Movie Database":
                    ExecuteThis( "http://www.omdbapi.com/?t=/" + strCleanName + "&y=&&type=movie&plot=full&r=xml" );
                    break;
                case "Google":
                    ExecuteThis( "https://www.google.com/search?q=" + strCleanName + strSearchWhat );
                    break;
                case "Yahoo":
                    ExecuteThis( "https://search.yahoo.com/search?p=" + strCleanName + strSearchWhat );
                    break;
                case "Rotten Tomatoes":
                    ExecuteThis( "https://www.rottentomatoes.com/search/?search=" + strCleanName );
                    break;
                case "FMovies":
                    ExecuteThis( "https://fmovies.se/search?keyword=" + strCleanName );
                    break;
                case "DuckDuckGo":
                    ExecuteThis( "https://duckduckgo.com/?q=" + strCleanName + strSearchWhat );
                    break;
                case "Movie Web":
                    ExecuteThis( "http://movieweb.com/search/q=" + strCleanName );
                    break;
                case "YouTube":
                    ExecuteThis( "https://www.youtube.com/results?search_query=" + strCleanName + strSearchWhat );
                    break;
                case "Fandom":
                    ExecuteThis( "http://wikia.com/wiki/Special:Search?query=" + strCleanName + strSearchWhat );
                    break;
                case "TV Guide":
                    ExecuteThis( "http://www.tvguide.com/movies/database/moviesearch.asp?SearchType=0&name=" + strCleanName );
                    break;
                case "MRQE":
                    ExecuteThis( "http://www.mrqe.com/search?q=" + strCleanName );
                    break;
                case "Hollywood.com":
                    ExecuteThis( "http://www.hollywood.com/search/?s=" + strCleanName );
                    break;
                case "CineMaterial":
                    ExecuteThis( "https://www.cinematerial.com/search?q=" + strCleanName );
                    break;
                default:
                    ExecuteThis( "http://www.imdb.com/find?q=" + strCleanName + "&s=tt" );
                    LogMessage( "Warning", Color.Orange, "Could not find " + cobSearchDownload.Text + " -> Searching IMDb instead." );
                    break;
            }
        }

        /// <summary>
        /// Searches the internet for a clean name.
        /// </summary>
        /// <param name="strCleanName">The clean name of the item to serach for.</param>
        void SearchDownload( string strCleanName )
        {
            LogMessage( "Info", Color.Blue, "Searching " + cobSearchDownload.Text + " for " + strCleanName );
            if ( cobDownloadCriteria.Text != "Don't Care" ) {
                strCleanName += "+" + cobDownloadCriteria.Text;
            }
            switch ( cobSearchDownload.Text ) {
                case "Best Below":
                    ExecuteThis( "https://1337x.to/search/" + strCleanName + "/1/" );
                    ExecuteThis( "https://rarbg.to/torrents.php?search=" + strCleanName );
                    ExecuteThis( "http://bitsnoop.com/search/all/" + strCleanName );
                    ExecuteThis( "http://www.demonoid.pw/files/?category=1&subcategory=0&language=0&quality=0&seeded=2&external=2&query=" + strCleanName );
                    ExecuteThis( "http://extratorrent.cc/search/?search=" + strCleanName );
                    // ExecuteThis( "https://eztv.ag/search/" + strCleanName );
                    ExecuteThis( "https://isohunt.to/torrents/?ihq=" + strCleanName );
                    // ExecuteThis( "https://kat.am/usearch/" + strCleanName + "  category:movies/" );
                    ExecuteThis( "https://www.limetorrents.cc/search/all/" + strCleanName );
                    ExecuteThis( "https://thepiratebay.org/search/" + strCleanName );
                    // ExecuteThis( "https://worldwidetorrents.eu/torrents-search.php?search=" + strCleanName );
                    ExecuteThis( "https://zooqle.com/search?q=" + strCleanName );
                    // ExecuteThis( "https://yts.ag/movie/" + strCleanName );
                    break;
                case "Rarbg":
                    ExecuteThis( "https://rarbg.to/torrents.php?search=" + strCleanName );
                    break;
                case "1337X":
                    ExecuteThis( "https://1337x.to/search/" + strCleanName + "/1/" );
                    break;
                case "Bit Snoop":
                    ExecuteThis( "http://bitsnoop.com/search/all/" + strCleanName );
                    break;
                case "Demonoid":
                    ExecuteThis( "http://www.demonoid.pw/files/?category=1&subcategory=0&language=0&quality=0&seeded=2&external=2&query=" + strCleanName );
                    break;
                case "Extra Torrent":
                    ExecuteThis( "http://extratorrent.cc/search/?search=" + strCleanName );
                    break;
                case "Eztv":
                    ExecuteThis( "https://eztv.ag/search/" + strCleanName );
                    break;
                case "ISO Hunt":
                    ExecuteThis( "https://isohunt.to/torrents/?ihq=" + strCleanName );
                    break;
                case "Kickass":
                    ExecuteThis( "https://kat.am/usearch/" + strCleanName + "  category:movies/" );
                    break;
                case "Lime Torrents":
                    ExecuteThis( "https://www.limetorrents.cc/search/all/" + strCleanName );
                    break;
                case "The Piratebay":
                    ExecuteThis( "https://thepiratebay.org/search/" + strCleanName );
                    break;
                case "World Wide Torrents":
                    ExecuteThis( "https://worldwidetorrents.eu/torrents-search.php?search=" + strCleanName );
                    break;
                case "Yifi":
                    ExecuteThis( "https://yts.ag/movie/" + strCleanName );
                    break;
                case "Zoogle":
                    ExecuteThis( "https://zooqle.com/search?q=" + strCleanName );
                    break;
                default:
                    ExecuteThis( "https://rarbg.to/torrents.php?search=" + strCleanName );
                    LogMessage( "Warning", Color.Orange, "Could not find " + cobSearchDownload.Text + " -> Searching Rarbg instead." );
                    break;
            }
        }

        /// <summary>
        /// Searches the internet for the selected items of the list view, 
        /// which has been droped on the Search Download droparea.
        /// </summary>
        /// <param name="lvListView">The list view with the selected items.</param>
        void SearchDownload( ListView lvListView )
        {
            string strCleanName = "";
            foreach ( ListViewItem lviItem in lvListView.SelectedItems ) {
                strCleanName = Path.GetFileNameWithoutExtension( lviItem.Text ).Replace( ' ', '+' );
                SearchDownload( strCleanName );
            }
        }

        /// <summary>
        /// Searches the internet for the selected items of the string array, 
        /// which has been droped on the Search Download droparea.
        /// </summary>
        /// <param name="strcolToSearch">The list view with the selected items.</param>
        void SearchDownload( string[] strcolToSearch )
        {
            foreach ( string strPath in strcolToSearch ) {
                string strCleanName = Path.GetFileNameWithoutExtension( strPath ).Replace( ' ', '+' );
                LogMessage( "Info", Color.Blue, "Searching " + cobSearchDownloadMaintenance.Text + " for " + strCleanName );
                SearchDownload( strCleanName );
            }
        }

        /// <summary>
        /// Searches the internet for the selected items of the list view, 
        /// which has been droped on the Search Download droparea.
        /// </summary>
        /// <param name="lvListView">The list view with the selected items.</param>
        void SearchInfo( ListView lvListView )
        {
            foreach ( ListViewItem lviItem in lvListView.SelectedItems ) {
                SearchInfo( lviItem.Text );
            }
        }

        /// <summary>
        /// Searches the internet for the selected items of the string array, 
        /// which has been droped on the Search Download droparea.
        /// </summary>
        /// <param name="strcolToSearch">The list view with the selected items.</param>
        void SearchInfo( string[] strcolToSearch )
        {
            foreach ( string strPath in strcolToSearch ) {
                SearchInfo( strPath );
            }
        }

        /// <summary>
        /// Items have been droped on the Seach Info drop area.
        /// Open the info searches for tem in the default browser.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnSearchInfoDragDrop( object sender, DragEventArgs e )
        {
            if ( (string)lvDragSource.Tag == "Maintenance" ) {
                SearchInfo( (string[])e.Data.GetData( DataFormats.FileDrop ) );
                LvMaintenanceDragDrop( sender, e );
                lvDragSource = lvExisting;
            }
            else {
                SearchInfo( lvDragSource );
            }
        }

        /// <summary>
        /// Items have been dropped on the Seach Download droparea.
        /// Open the download searches for them in the default browser. 
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnSearchDownloadDragDrop( object sender, DragEventArgs e )
        {
            if ( (string)lvDragSource.Tag == "Maintenance" ) {
                SearchDownload( (string[])e.Data.GetData( DataFormats.FileDrop ) );
                LvMaintenanceDragDrop( sender, e );
                lvDragSource = lvExisting;
            }
            else {
                SearchDownload( lvDragSource );
            }
        }

        /// <summary>
        /// Update the Search Info button text after the selection hsa been changed.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void CobSearchInfoSelectedIndexChanged( object sender, EventArgs e )
        {
            if ( sender == cobSearchInfoMaintenance ) {
                cobSearchInfo.Text = cobSearchInfoMaintenance.Text;
            }
            else {
                cobSearchInfoMaintenance.Text = cobSearchInfo.Text;
            }
            btnSearchInfo.Text = cobSearchInfo.Text;
            btnSearchInfoMaintenance.Text = cobSearchInfo.Text;
            SaveSettings( );
        }

        /// <summary>
        /// Update the Download button text after the selection has been changed.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void CobSearchDownloadSelectedIndexChanged( object sender, EventArgs e )
        {
            if ( sender == cobSearchDownloadMaintenance ) {
                cobSearchDownload.Text = cobSearchDownloadMaintenance.Text;
            }
            else {
                cobSearchDownloadMaintenance.Text = cobSearchDownload.Text;
            }
            btnSearchDownload.Text = cobSearchDownload.Text;
            btnSearchDownloadMaintenance.Text = cobSearchDownload.Text;
            SaveSettings( );
        }

        #endregion Drop Area Handling

        #region ListView File Import & Export

        /// <summary>
        /// Initialize a list view from a text file in MFM format.
        /// </summary>
        /// <param name="lvListView">The list view to be intialized.</param>
        void InitListViewFromFile( ListView lvListView )
        {
            string strSerializationFileName = Path.Combine( strPrivatePath, lvListView.Tag + " " +
                                                            strCollectionType + ".slv" );
            lvListView.Items.Clear( );

            if ( File.Exists( strSerializationFileName ) ) {
                DeserializeListView( lvListView, strSerializationFileName );
            }
            SetListViewChanged( lvListView, false );
        }

        /// <summary>
        /// Adds items to a list view from a CSV file.
        /// </summary>
        /// <param name="lvThis">The list view to add the items.</param>
        /// <param name="strPath">The name of the file to b added.</param>
        void AddCsvToListView( ListView lvThis, string strPath )
        {
            string line;
            var srMovies = new StreamReader( strPath );
            LogInfo( "Loading " + Path.GetFileNameWithoutExtension( strPath ) +
                       " to " + lvThis.Tag + " " + strCollectionType + "..." );

            while ( (line = srMovies.ReadLine( )) != null ) {
                string[] saParts = line.Split( '\t' );
                var lviThis = new ListViewItem( CleanName( saParts[ 0 ] ) );
                lviThis = AddItemToListView( lvThis, lviThis );
                if ( saParts.Length > 1 ) lviThis.ToolTipText = saParts[ 1 ].Replace( '*', '\n' );
            }
            srMovies.Close( );
            LogInfo( "Added " + Path.GetFileNameWithoutExtension( strPath ) +
                       " to " + lvThis.Tag + " " + strCollectionType + "..." );
        }

        string CleanXml ( string strMess )
        {
            return strMess.Replace( "&amp;", "&" ).Replace( "&lt;", "<" ).Replace( "&gt;", ">" ).Replace( "&quot;", "\"" ).Replace( "&apos;", "'" );
        }

        /// <summary>
        /// Adds items to a list view from a XML file.
        /// </summary>
        /// <param name="lvThis">The list view to add the items.</param>
        /// <param name="strPath">The name of the file to b added.</param>
        void AddXmlToListView( ListView lvThis, string strPath )
        {
            var xmlFile = new XmlDocument( );
            xmlFile.Load( strPath );
            LogInfo( "Loading " + Path.GetFileNameWithoutExtension( strPath ) +
                       " to " + lvThis.Tag + " " + strCollectionType + "..." );


            foreach ( XmlNode node in xmlFile.DocumentElement.ChildNodes ) {
                string strToolTip = "";
                string strListEntryName = "";
                string strNodeName = "";
                foreach ( XmlNode xmlaThis in node.ChildNodes ) {
                    strNodeName = xmlaThis.Name;
                    if ( strNodeName == "Name" ) {
                        strListEntryName = CleanXml ( node.FirstChild.InnerXml );
                        continue;
                    }
                    else if ( strNodeName == "General" ) strToolTip += "\n";
                    else if ( strNodeName == "Line" ) {
                        strToolTip += CleanXml( xmlaThis.InnerXml ) + "\n";
                    }
                    else {
                        strToolTip += strNodeName.Replace( '_', ' ' ) + ":  " + CleanXml( xmlaThis.InnerXml ) + "\n";
                    }
                }
                var lviThis = new ListViewItem( strListEntryName );
                lviThis.ToolTipText = strToolTip;
                lviThis = AddItemToListView( lvThis, lviThis );
            }

            if ( rbSeries.Checked ) {
                if ( (string)lvThis.Tag == "Garbage" ) ColorExistingAndUp( );
                if ( (string)lvThis.Tag == "Existing" ) ColorWishAndUp( );
                if ( (string)lvThis.Tag == "Wish" ) ColorWishAndUp( );
            }

            LogInfo( "Added " + Path.GetFileNameWithoutExtension( strPath ) +
                       " to " + lvThis.Tag + " " + strCollectionType + "..." );
        }

        /// <summary>
        /// Adds items to a list view from the tabulator separated file.
        /// </summary>
        /// <param name="lvThis">The list view to add the items.</param>
        /// <param name="strPath">The name of the file to b added.</param>
        void AddTxtToListView( ListView lvThis, string strPath )
        {
            string line;
            var srMovies = new StreamReader( strPath );
            LogInfo( "Loading " + Path.GetFileNameWithoutExtension( strPath ) + " to " + lvThis.Tag + " " + strCollectionType + "..." );

            var saTitles = new string[ 20 ];
            var saParts = new string[ 20 ];

            line = srMovies.ReadLine( );
            if ( line.StartsWith( "Title\t", StringComparison.Ordinal ) ) {
                saTitles = line.Split( '\t' );
                for ( int i = 1; i < saTitles.Length; i++ ) {
                    if ( saTitles[ i ].Length > 1 ) {
                        saTitles[ i ] += ":  ";
                    }
                }
                line = srMovies.ReadLine( );
            }

            while ( line != null ) {
                saParts = line.Split( '\t' );
                var lviThis = new ListViewItem( CleanName( saParts[ 0 ].Trim( '"' ) ) );
                lviThis.ToolTipText = saParts[ 0 ] + "\n";
                lviThis = AddItemToListView( lvThis, lviThis );
                for ( int i = 1; i < saParts.Length; i++ ) {
                    lviThis.ToolTipText += saTitles[ i ] + saParts[ i ] + "\n";
                }
                line = srMovies.ReadLine( );
            }
            if ( rbSeries.Checked ) {
                if ( (string)lvThis.Tag == "Garbage" ) ColorExistingAndUp( );
                if ( (string)lvThis.Tag == "Wish" ) ColorWishAndUp( );
            }
            srMovies.Close( );
            LogInfo( "Added " + Path.GetFileNameWithoutExtension( strPath ) + " to " + lvThis.Tag + " " + strCollectionType + "..." );
        }

        /// <summary>
        /// Adds a file to a list view in a thread.
        /// </summary>
        /// <param name="strName">The list view item name.</param>
        /// <param name="fiFile">The file info of the item to add.</param>
        /// <param name="lvThis">The list view where the item should be added.</param>
        private void DoAddFileToListView( string strName, FileInfo fiFile, ListView lvThis )
        {
            if ( this.InvokeRequired ) {
                // we were called on a worker thread marshal the call to the user interface thread
                this.Invoke( new UpdateListViewDelegate( DoAddFileToListView ), new object[] { strName, fiFile, lvThis } );
                return;
            }

            // this code can only be reached by the user interface thread
            var lviThis = new ListViewItem( strName );
            lviThis = AddItemToListView( lvThis, lviThis );
            lviThis.EnsureVisible( );
            lvGarbage.Update( );
            lvExisting.Update( );
            lvWish.Update( );
            lvImport.Update( );
            MakeToolTip( fiFile, lvThis, lviThis );
            ColorAll( lviThis.Text );  // color again to get info from tooltip
            tspbMFM.Value++;
        }

        /// <summary>
        /// Add files to a list view ina thread
        /// </summary>
        void lvAddFilesInThread( )
        {
            var diFolder = new DirectoryInfo( strGlobalFolderName );
            SearchOption soMovieFileMerger = SearchOption.AllDirectories;

            foreach ( FileInfo fiFile in diFolder.GetFiles( "*", soMovieFileMerger ) ) {
                if ( !rgxMainExtensions.IsMatch( fiFile.Extension.ToLower( ) ) ) {
                    continue;
                }
                string strJustName = fiFile.Name;
                if ( strJustName.LastIndexOf( '.' ) != -1 ) {
                    strJustName = strJustName.Substring( 0, strJustName.LastIndexOf( '.' ) );
                }
                DoAddFileToListView( CleanName( strJustName ), fiFile, lvToAdd );
            }
            MessageBox.Show( " Finished adding files...", "Movie File Merger - Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
            Cursor.Current = Cursors.Default;
            // ClearStatus();
            // tspbMFM.Value = 0;
        }

        /// <summary>
        /// Adds items contained in a folder to a list view.
        /// </summary>
        /// <param name="lvThis">The list view to add the items.</param>
        /// <param name="strFolderName">The name of the folder containing the items to be added.</param>
        void AddFolderToListView( ListView lvThis, string strFolderName )
        {
            var diFolder = new DirectoryInfo( strFolderName );
            SearchOption soMovieFileMerger = SearchOption.AllDirectories;

            SetStatus( "Adding folder " + strFolderName + " to " + lvThis.Tag + "..." );

            tspbMFM.Maximum = 0;
            tspbMFM.Value = 0;
            foreach ( FileInfo fiFile in diFolder.GetFiles( "*", soMovieFileMerger ) ) {
                if ( rgxMainExtensions.IsMatch( fiFile.Extension.ToLower( ) ) ) {
                    tspbMFM.Maximum++;
                }
            }

            // Add the files in a tread, so that not every freezes all the time
            lvToAdd = lvThis;
            strGlobalFolderName = strFolderName;
            var thrdAddFilesToListView = new Thread( lvAddFilesInThread );
            thrdAddFilesToListView.Start( );
        }

        /// <summary>
        /// Saves all items contained in a list view to a XML file, so that it can be later reloaded by MFM.
        /// </summary>
        /// <param name="lvListView">The list view containing the items.</param>
        /// <param name="strFileName">The name of the file to where to save the list view items.</param>
        void SaveListViewToXmlFile( ListView lvListView, string strFileName )
        {
            Regex rgxXmlStuff = new Regex( @"_x[0-9a-fA-F]{4}" );
            var settings = new XmlWriterSettings( );
            settings.Indent = true;

            using ( XmlWriter writer = XmlWriter.Create( strFileName, settings ) ) {
                writer.WriteStartDocument( );
                writer.WriteStartElement( rgxXmlStuff.Replace( XmlConvert.EncodeName( strFileName.Substring( strFileName.LastIndexOf( "\\" ) + 1 ) ), "" ) );  // root exlement
                foreach ( ListViewItem lviItem in lvListView.Items ) {
                    string strGoodName = lviItem.Text;
                    if ( strGoodName == "" ) continue;
                    if ( char.IsDigit( strGoodName[ 0 ] ) ) strGoodName = "_" + strGoodName;
                    strGoodName = rgxXmlStuff.Replace( XmlConvert.EncodeName( strGoodName ), "" );
                    strGoodName = strGoodName.Replace( ':', '_' );
                    writer.WriteStartElement( strGoodName );  // list entry
                    writer.WriteElementString( "Name", lviItem.Text );
                    foreach ( string strLine in lviItem.ToolTipText.Split( '\n' ) ) {
                        if ( strLine == "" ) continue;
                        if ( strLine.Contains( ":  " ) ) {
                            var strElementName = rgxXmlStuff.Replace( XmlConvert.EncodeName( strLine.Substring( 0, strLine.IndexOf( ":  " ) ) ), "" );
                            writer.WriteElementString( strElementName, strLine.Substring( strLine.IndexOf( ":  " ) + 3 ) );
                        }
                        else {
                            writer.WriteElementString( "Line", strLine );
                        }
                    }
                    writer.WriteEndElement( );
                }

                writer.WriteEndElement( );  // close the root element
                writer.WriteEndDocument( );
            }
        }

        /// <summary>
        /// Saves all items contained in a list view to a file, so that it can be later reloaded by MFM.
        /// </summary>
        /// <param name="lvListView">The list view containing the items.</param>
        /// <param name="strFileName">The name of the file to where to save the list view items.</param>
        void SaveListViewToCsvFile( ListView lvListView, string strFileName )
        {
            var swFile = new StreamWriter( strFileName );

            foreach ( ListViewItem lviItem in lvListView.Items ) {
                swFile.WriteLine( lviItem.Text + "\t" + lviItem.ToolTipText.Replace( '\n', '*' ) );
            }
            swFile.Close( );
        }

        /// <summary>
        /// Saves all items contained in a list view to a file, so that it can be opened later with a spread sheet app.
        /// </summary>
        /// <param name="lvListView">The list view containing the items.</param>
        /// <param name="strFileName">The name of the file to where to save the list view items.</param>
        void SaveListViewToTsvFile( ListView lvListView, string strFileName )
        {
            var swFile = new StreamWriter( strFileName );

            foreach ( ListViewItem lviItem in lvListView.Items ) {
                swFile.WriteLine( lviItem.Text + "\t" + lviItem.ToolTipText.Replace( '\n', '\t' ) );
            }
            swFile.Close( );
        }

        /// <summary>
        /// Aks the user if changed lists should be save and if so save them.
        /// </summary>
        /// <param name="lvListView">The list view to save if it has changed.</param>
        void SaveChangedListView( ListView lvListView )
        {
            string strName = lvListView.Tag + " " + strCollectionType;

            if ( (lvListView.Tag.ToString( ) == "Existing" && bExistingChanged) ||
                 (lvListView.Tag.ToString( ) == "Wish" && bWishChanged) ||
                 (lvListView.Tag.ToString( ) == "Garbage" && bGarbageChanged) ) {
                if ( ShowYesNoQuestion( "Save " + strName + "?" ) == DialogResult.Yes ) {
                    SerializeListView( lvListView, Path.Combine( strPrivatePath, strName + ".slv" ) );
                }
            }
        }

        /// <summary>
        /// Saves a list view to a file, which can bge read by MFM.
        /// </summary>
        /// <param name="lvListView">The list view to be saved.</param>
        /// <param name="strFileName">The name of the target file.</param>
        void SerializeListView( ListView lvListView, string strFileName )
        {
            SetStatus( "Serializing " + lvListView.Tag + " " + strCollectionType + "..." );
            var fsListView = new FileStream( strFileName, FileMode.Create );
            var bf = new BinaryFormatter( );
            var strcolItems = new System.Collections.Specialized.StringCollection( );

            foreach ( ListViewItem lviItem in lvListView.Items ) {
                strcolItems.Add( lviItem.Text + "\t" + lviItem.ToolTipText );
            }
            try {
                bf.Serialize( fsListView, strcolItems );
            }
            catch ( System.Runtime.Serialization.SerializationException e ) {
                ShowInfo( e.Message );
            }
            fsListView.Close( );
            ClearStatus( );
            SetListViewChanged( lvListView, false );
        }

        /// <summary>
        /// Reads the the items from a file and puts them into a list view. 
        /// </summary>
        /// <param name="lvListView">The list view to put the items.</param>
        /// <param name="strFileName">The source file name.</param>
        void DeserializeListView( ListView lvListView, string strFileName )
        {
            var strcolStr = new System.Collections.Specialized.StringCollection( );
            try {
                var fsItems = new FileStream( strFileName, FileMode.Open );
                var bf = new BinaryFormatter( );
                strcolStr = (System.Collections.Specialized.StringCollection)bf.Deserialize( fsItems );
                fsItems.Close( );
            }
            catch ( IOException e ) {
                ShowInfo( e.Message );
            }

            lvListView.Items.Clear( );
            lvListView.Sorting = SortOrder.None;
            foreach ( string strListViewItemName in strcolStr ) {
                string[] saParts = strListViewItemName.Split( '\t' );
                var lviThis = new ListViewItem( saParts[ 0 ] );

                if ( saParts.Length > 1 ) {
                    lviThis.ToolTipText = saParts[ 1 ];
                }
                ListViewItem lviJustAdded = lvListView.Items.Add( lviThis );
                if ( iAddedCount++ % 20 == 0 ) {
                    lviJustAdded.EnsureVisible( );
                    //lvListView.Update( );
                    lvGarbage.Update( );
                    lvExisting.Update( );
                    lvWish.Update( );
                    lvImport.Update( );
                }
                ColorAll( saParts[ 0 ] );
            }
            lvListView.Sorting = SortOrder.Ascending;
            if ( lvListView.Items.Count > 0 ) {
                SetStatus( "Added " + lvListView.Items.Count + " items to " + lvListView.Tag + " " + strCollectionType + "." );
            }
            ClearStatus( );
        }

        #endregion ListView File Import & Export

        #region ListViewItem Name & Tooltip Handling

        /// <summary>
        /// Cleans up and tries to standardize the name of movies or series, so that they 
        /// can be compared better.
        /// </summary>
        /// <param name="strMessyName">The messy name, for example when downloaded.</param>
        /// <returns>The cleaned up name.</returns>
        string CleanName( string strMessyName )
        {
            string strCleanName = strMessyName.ToLower( );

            if ( Regex.IsMatch( strCleanName, tbBadDocuNameRegex.Text ) ) { // handle documentaries
                Match matchTrimBefore = Regex.Match( strCleanName, @"720p|1080p|x264|aac|divx|xvid|dvd" );
                if ( matchTrimBefore.Success ) {
                    strCleanName = strCleanName.Substring( 0, matchTrimBefore.Index );
                }
            }
            else if ( Regex.IsMatch( strCleanName, tbBadEpisodeNameRegex.Text ) ) { // handle episodes 
                Match matchEpisodeId = Regex.Match( strCleanName, tbBadEpisodeNameRegex.Text );
                if ( matchEpisodeId.Success ) {
                    MatchCollection mcNumbers = rgxNumber.Matches( matchEpisodeId.Value );
                    string strUnifiedEpisodeId = " s" + mcNumbers[ 0 ].Value.PadLeft( 2, '0' ) +
                                                  "e" + mcNumbers[ 1 ].Value.PadLeft( 2, '0' );
                    strCleanName = strCleanName.Substring( 0, matchEpisodeId.Index ) + strUnifiedEpisodeId;
                }
            }
            else if ( Regex.IsMatch( strCleanName, tbBadMovieNameRegex.Text ) ) { // handle movies
                Match matchTrimBefore = Regex.Match( strCleanName, tbBadMovieNameRegex.Text );
                if ( matchTrimBefore.Success ) {
                    strCleanName = strCleanName.Substring( 0, matchTrimBefore.Index );
                }
            }
            else  // handle other stuff
            {
                Match matchTrimBefore = rgxTrimBefore.Match( strCleanName );
                if ( matchTrimBefore.Success ) {
                    strCleanName = strCleanName.Substring( 0, matchTrimBefore.Index );
                }
            }

            strCleanName = rgxAphanumeric.Replace( strCleanName, @" " );  // get rid of unwanted stuff
            strCleanName = rgxMultiSpace.Replace( strCleanName, @" " );  // get rid of multiple spaces
            strCleanName = strCleanName.Trim( ' ' );

            // fix the cases according to movie titles
            strCleanName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase( strCleanName );
            MatchCollection mcToLower = rgxToLower.Matches( strCleanName );
            foreach ( Match mToLower in mcToLower ) {
                strCleanName = strCleanName.Replace( mToLower.Value, mToLower.Value.ToLower( ) );
            }
            mcToLower = rgxToLower.Matches( strCleanName ); // has to be done 2 times because of overlaps
            foreach ( Match mToLower in mcToLower ) {
                strCleanName = strCleanName.Replace( mToLower.Value, mToLower.Value.ToLower( ) );
            }

            return strCleanName;
        }

        /// <summary>
        /// Removes the episode info to get the series name.
        /// </summary>
        /// <param name="strCleanName">The episode name.</param>
        /// <returns>The series name.</returns>
        string RemoveEpisodeInfo( string strCleanName )
        {
            return Regex.Replace( strCleanName, @" [Ss]\d+[Ee]\d+$", "" );
        }

        /// <summary>
        /// Extracts the file name from the tool tip.
        /// </summary>
        /// <param name="strToolTip">The tool tip from where to extract the file name.</param>
        /// <returns>The file name.</returns>
        string ExtractFileNameFromToolTip( string strToolTip )
        {
            return strToolTip.Substring( 0, strToolTip.IndexOf( "\n", StringComparison.CurrentCulture ) );
        }

        /// <summary>
        /// Extracts the full file path from the tool tip.
        /// </summary>
        /// <param name="strToolTip">The tool tip from where to extract the full file path.</param>
        /// <returns>The full file path.</returns>
        string ExtractFullPathFromToolTip( string strToolTip )
        {
            string strFileName = ExtractFileNameFromToolTip( strToolTip );
            int iFirstEOL = strToolTip.IndexOf( "\n", StringComparison.CurrentCulture );
            string strFilePath = strToolTip.Substring( iFirstEOL, strToolTip.IndexOf( "\n", iFirstEOL + 2, StringComparison.CurrentCulture ) - iFirstEOL );
            return strFilePath.Substring( strFilePath.IndexOf( "] ", StringComparison.CurrentCulture ) + 3 ) + "\\" + strFileName;
        }

        /// <summary>
        /// Checks if the horizoltal resolution in the tool tip of the new list view item is higher.
        /// </summary>
        /// <param name="lviExisting">Existing ListViewItem</param>
        /// <param name="lviImport">Import ListViewItem</param>
        /// <returns>True: if New Item Resolution is higher.</returns>
        bool HorizontalResolutionIsHigher( ListViewItem lviExisting, ListViewItem lviImport )
        {
            bool bResolutionIsHigher = false;

            if ( cbGetHigherRes.Checked ) {
                Match mtExistingResolution = Regex.Match( lviExisting.ToolTipText, "Video:  \\d+" );
                if ( mtExistingResolution.Success ) {
                    Match mtImportResolution = Regex.Match( lviImport.ToolTipText, "Video:  \\d+" );
                    if ( mtImportResolution.Success ) {
                        string sExistingResolution = Regex.Match( mtExistingResolution.Value, @"\d+" ).Value;
                        int iExistingResolution = Int32.Parse( sExistingResolution );
                        string sImportResolution = Regex.Match( mtImportResolution.Value, @"\d+" ).Value;
                        int iImportResolution = Int32.Parse( sImportResolution );
                        bResolutionIsHigher = iExistingResolution < iImportResolution;
                    }
                }
            }
            return bResolutionIsHigher;
        }

        int GetFileSize( string strItemToolTip )
        {
            Match mtFileSize = Regex.Match( strItemToolTip, @"\d+ MiB" );
            if ( mtFileSize.Success ) {
                string strFileSize = Regex.Match( mtFileSize.Value, @"\d+" ).Value;
                return Int32.Parse( Regex.Match( strFileSize, @"\d+" ).Value );
            }
            return 0;
        }

        /// <summary>
        /// Checks if the horizoltal resolution in the tool tip of the list item too low.
        /// </summary>
        /// <param name="lviThis">Old ListViewItem</param>
        /// <returns>True: if This Item Resolution is lower then the minimum resolution in the settings.</returns>
        bool HorizontalResolutionTooLow( ListViewItem lviThis )
        {
            bool bResolutionIsLower = false;
            if ( cobMinimumResolution.Text != " <~0p (FLD)" ) {
                Match mtResolution = Regex.Match( lviThis.ToolTipText, @"Video:  \d+" );
                if ( mtResolution.Success ) {
                    string sResolution = Regex.Match( mtResolution.Value, @"\d+" ).Value;
                    int iExistingResolution = Int32.Parse( sResolution );
                    bResolutionIsLower = iExistingResolution < GetMinimumResolution( );
                }
            }
            return bResolutionIsLower;
        }

        string GetExistingMediaInfo( string strItemName, long iMiB )
        {
            ListViewItem lviExisting = FindItem( lvExisting, strItemName );

            if ( lviExisting != null &&
                    GetFileSize( lviExisting.ToolTipText ) == iMiB ) {
                if ( lviExisting.ToolTipText.Contains( "\n\nGeneral: " ) ) {
                    return lviExisting.ToolTipText.Substring( lviExisting.ToolTipText.IndexOf( "\n\nGeneral: " ) );
                }
            }
            return "";
        }

        /// <summary>
        /// Extracts full information of a file with MediaInfo, but returns only selected information. 
        /// </summary>
        /// <param name="fiFile">The file to analyse.</param>
        /// <param name="lvThis">The list view in question.</param>
        /// <param name="lviThis">The list view item in question.</param>
        /// <returns>Selected media information.</returns>
        void MakeToolTip( FileInfo fiFile, ListView lvThis, ListViewItem lviThis )
        {
            string strListType = (string)lvThis.Tag;
            bool bItemMissing = FindItem( lvThis, lviThis.Text ) == null;
            bool bHasMediaInfo = lviThis.ToolTipText.Contains( "Video: " );
            bool bHasNewMediaInfo = lviThis.ToolTipText.Contains( "General: " );

            string sMediaInfo = "";
            bool bGetFullDetails = false;

            long lMiB = 0;
            if (File.Exists(fiFile.FullName))
            {
                lMiB = fiFile.Length / 1024 / 1024;
            }
            string sInfo = lMiB + " MiB,  " + fiFile.Extension.ToUpper().Substring(1);

            string sFileInfo = "File:  " + fiFile.Name + "\n" +
                               "Path:  " + fiFile.DirectoryName + "\n" +
                               "Info:  " + sInfo +
                               ", Last Written " + StandardizeDate( fiFile.LastWriteTime );
            bool bDifferentFileInfo = !lviThis.ToolTipText.Contains( sFileInfo );

            switch ( strListType ) {
                case "Import":
                    bool bIsGarbage = FindItem( lvGarbage, lviThis.Text ) != null;

                    sMediaInfo = GetExistingMediaInfo( lviThis.Text, lMiB );
                    if ( sMediaInfo == "" && !bHasMediaInfo && cbGetHigherRes.Checked && !bIsGarbage ) {
                        bGetFullDetails = true;
                    }
                    break;
                case "Existing":
                    if ( !bHasNewMediaInfo ) {
                        bGetFullDetails = true;
                    }
                    break;
                case "Garbage":
                    // don't get details
                    break;
                case "Wish":
                    // don't get details
                    break;
                case "Maintenance":
                    // don't get details
                    break;
            }

            if (bGetFullDetails) {
                if (File.Exists(fiFile.FullName))
                { 
                    SetStatus("Getting MediaInfo for " + fiFile.Name);
                    miThis.Open(fiFile.FullName);
                    miThis.Option("Inform", "General;General:  %Duration/String% in %Format% container %Video_Format_List% codec"); // file size
                    sMediaInfo += "\n\n" + miThis.Inform();
                    miThis.Option("Inform", "Video;Video:  %Width% x%Height% (%DisplayAspectRatio/String%) at %FrameRate/String% with %BitRate/String%");
                    sMediaInfo += "\n" + miThis.Inform();
                    miThis.Option("Inform", "Audio;Audio:  %Channel(s)/String% at %SamplingRate/String% %Format% %Language/String%");
                    sMediaInfo += miThis.Inform().Replace("Audio: ", "\nAudio: ").Replace("Audio:  ,", "Audio:");
                    miThis.Close();
                }
                // Make new tool tip 
                lviThis.ToolTipText = sFileInfo + sMediaInfo;
                SetListViewChanged( lvThis, true );
            }
            else if ( bDifferentFileInfo ) {
                SetStatus( "Different File Info for " + fiFile.Name );
                lviThis.ToolTipText = sFileInfo + sMediaInfo;
                SetListViewChanged( lvThis, true );
            }
        }

        #endregion ListViewItem Name & Tooltip Handling

        #region ListViewItem Coloring

        /// <summary>
        /// Colors all items contained in the Existing, the Wish and the Import list views.
        /// </summary>
        void ColorExistingAndUp( )
		{
			ColorExisting( );
			ColorWish( );
			ColorImport( );
		}
		
		/// <summary>
		/// Colors a single items in the Existing list view.
		/// </summary>
		/// <param name="lviExisting">The item to be colored.</param>
		void ColorExistingItem( ListViewItem lviExisting )
		{
			if ( lviExisting == null ) {
				return;
			}
			lviExisting.Selected = false;
			ListViewItem lviGarbage = FindItem( lvGarbage, RemoveEpisodeInfo( lviExisting.Text ) );
			lviExisting.BackColor = ( lviGarbage != null ) ? GarbageColor : 
			                                                 ExistingColor;
		}
		
		/// <summary>
		/// Colcors all items in the Existing list view.
		/// </summary>
		void ColorExisting( )
		{
			SetStatus( "Coloring " + strCollectionType + " in Existing list..." );
			foreach ( ListViewItem lviExisting in lvExisting.Items ) {
				ColorExistingItem( lviExisting );
			}
			ClearStatus( );
		}
		
		/// <summary>
		/// Colors all items contained in the Wish and the Import list views.
		/// </summary>
		void ColorWishAndUp( )
		{
			ColorWish( );
			ColorImport( );
		}
		
		/// <summary>
		/// Colors a single item in the Wish list view.
		/// </summary>
		/// <param name="lviWish">The item to be colored.</param>
		void ColorWishItem( ListViewItem lviWish )
		{
			if ( lviWish == null ) {
				return;
			}
			lviWish.Selected = false;
			ListViewItem lviGarbage = FindItem( lvGarbage, RemoveEpisodeInfo( lviWish.Text ) );
			if ( lviGarbage != null ) {
				lviWish.BackColor = GarbageColor;
			}
			else {
				ListViewItem lviExisting;
				lviExisting = ( rbSeries.Checked ) ? FindItemStart( lvExisting, lviWish.Text ) : 
				                                     FindItem( lvExisting, lviWish.Text );
				lviWish.BackColor = ( lviExisting != null ) ? ExistingColor : 
					                                          WishColor;
			}
		}

		/// <summary>
		/// Colors all items in the Wish list.
		/// </summary>
		void ColorWish( )
		{
			SetStatus( "Coloring " + strCollectionType + " in Wish list..." );
			foreach ( ListViewItem lviWish in lvWish.Items ) {
				ColorWishItem( lviWish );
			}
			ClearStatus( );
		}
		
		/// <summary>
		/// Colors a single item in the Import list view.
		/// </summary>
		/// <param name="lviImport">The item to be colored.</param>
		void ColorImportItem( ListViewItem lviImport )
		{
			if ( lviImport == null ) {
				return;
			}
			lviImport.Selected = false;
			ListViewItem lviGarbage = FindItem( lvGarbage, RemoveEpisodeInfo(lviImport.Text ) );
			if ( lviGarbage != null ) {
				lviImport.BackColor = GarbageColor;
			}
			else {
				ListViewItem lviExisting = FindItem( lvExisting, lviImport.Text );
				if ( HorizontalResolutionTooLow ( lviImport ) ) {
					lviImport.BackColor = LowResColor;
				}
				else if ( lviExisting != null ) {
 					lviImport.BackColor = HorizontalResolutionIsHigher ( lviExisting, lviImport ) ? HigherResColor :
																								ExistingColor;
				}
				else {
					ListViewItem lviWish = FindItem( lvWish, RemoveEpisodeInfo( lviImport.Text ) );
					lviImport.BackColor = ( lviWish != null ) ? WishColor : 
					                                            NeutralColor;
				}
			}
		}

		/// <summary>
		/// Colcor all items with the according name in all lists. 
		/// </summary>
		/// <param name="strItemName">The name of the item to be colored.</param>
		void ColorAll( string strItemName )
		{
			ListViewItem lviGarbage = FindItem( lvGarbage, RemoveEpisodeInfo( strItemName ) );
			ListViewItem lviExisting;
			lviExisting = ( rbSeries.Checked ) ? FindItemStart( lvExisting, strItemName ) : 
			                                     FindItem( lvExisting, strItemName );
			ListViewItem lviWish = FindItem( lvWish, RemoveEpisodeInfo( strItemName ) );
			ListViewItem lviImport = FindItem( lvImport, strItemName );
			
			if ( lviGarbage != null ) {
				lviGarbage.BackColor = GarbageColor;
				if ( lviExisting != null ) {
					lviExisting.BackColor = GarbageColor;
				}
				if ( lviWish != null ) {
					lviWish.BackColor = GarbageColor;
				}
				if ( lviImport != null ) {
					lviImport.BackColor = GarbageColor;
				}
			}
			else if ( lviExisting != null ) {
				lviExisting.BackColor = ExistingColor;
				if ( lviWish != null ) {
					lviWish.BackColor = ExistingColor;
				}
				if ( lviImport != null ) {
 					lviImport.BackColor = HorizontalResolutionIsHigher ( lviExisting, lviImport ) ? HigherResColor :
																								ExistingColor;
					if ( HorizontalResolutionTooLow ( lviImport ) ) {
						lviImport.BackColor = LowResColor;
					}
				}
			}
			else if ( lviWish != null ) {
				if ( rbSeries.Checked ) {
					lviExisting = FindItemStart( lvExisting, RemoveEpisodeInfo( strItemName ) );
				}
				lviExisting = FindItem( lvExisting, strItemName );
				if ( lviExisting == null ) {
					lviWish.BackColor = WishColor;
				}
				if ( lviImport != null ) {
					lviImport.BackColor = WishColor;
					if ( HorizontalResolutionTooLow ( lviImport ) ) {
						lviImport.BackColor = LowResColor;
					}
				}
			}
			else if ( lviImport != null ) {
				lviImport.BackColor = NeutralColor;
				if ( HorizontalResolutionTooLow ( lviImport ) ) {
					lviImport.BackColor = LowResColor;
				}
			}
		}

		/// <summary>
		/// Colors all items in the Import list.
		/// </summary>
		void ColorImport( )
		{
			SetStatus( "Coloring " + strCollectionType + " in Import list..." );
			foreach ( ListViewItem lviImport in lvImport.Items ) {
				ColorImportItem( lviImport );
			}
			ClearStatus( );
		}

        #endregion ListViewItem Coloring

        #region ListView Handling


        /// <summary>
        /// Sets a tag in a list view to remember when to save the view.
        /// </summary>
        /// <param name="lvThis">The listview to be tagged.</param>
        /// <param name="bChanged">true when the list view has changed, otherwise flase.</param>
        void SetListViewChanged( ListView lvThis, bool bChanged )
        {
            switch ( (string)lvThis.Tag ) {
                case "Existing": bExistingChanged = bChanged; break;
                case "Garbage": bGarbageChanged = bChanged; break;
                case "Wish": bWishChanged = bChanged; break;
            }
        }

        /// <summary>
        /// Checks if one item only is selected in the focused list view.
        /// </summary>
        /// <returns>True, if only one item is the focused list is selected, otherwise false.</returns>
        bool OneItemSelected( )
        {
            if ( lvGarbage.Focused ) {
                return lvGarbage.SelectedItems.Count < 2;
            }
            if ( lvExisting.Focused ) {
                return lvExisting.SelectedItems.Count < 2;
            }
            if ( lvWish.Focused ) {
                return lvWish.SelectedItems.Count < 2;
            }
            if ( lvImport.Focused ) {
                return lvImport.SelectedItems.Count < 2;
            }
            return false;
        }

        /// <summary>
        /// Scrolls to the closest similar item in other list views.
        /// </summary>
        /// <param name="lvListView">The list view to scroll.</param>
        /// <param name="strItemName">The item name which should be matched a good as possible.</param>
        void ShowClosestItem( ListView lvListView, string strItemName )
        {
            if ( lvListView.Items.Count > 0 && !lvListView.Focused ) {
                ListViewItem lviItem;
                ListViewItem lviClosest = lvListView.Items[ lvListView.Items.Count - 1 ];
                int iLength = 1;

                while ( (iLength < strItemName.Length) &&
                        (lviItem = lvListView.FindItemWithText( strItemName.Substring( 0, iLength ) )) != null ) {
                    lviClosest = lviItem;
                    iLength++;
                }
                lviClosest.EnsureVisible( );
                lviClosest.Focused = true;
            }
        }

        /// <summary>
        /// Scolls all lists to the closed match of the last selected item.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void LvItemSelectionChanged( object sender, ListViewItemSelectionChangedEventArgs e )
        {
            if ( e.Item.Selected && OneItemSelected( ) ) {
                ShowClosestItem( lvExisting, e.Item.Text );
                ShowClosestItem( lvGarbage, e.Item.Text );
                ShowClosestItem( lvWish, e.Item.Text );
                ShowClosestItem( lvImport, e.Item.Text );
            }
        }

        /// <summary>
        /// Adds an item to a list view, if it does not exist already.
        /// </summary>
        /// <param name="lvThis">The list view to add the item.</param>
        /// <param name="lviToAdd">The item to add.</param>
        /// <returns>The reference of the added item.</returns>
        ListViewItem AddItemToListView( ListView lvThis, ListViewItem lviToAdd )
        {
            ListViewItem lviThis = FindItem( lvThis, lviToAdd.Text );

            if ( lviThis == null ) {
                lviThis = new ListViewItem( lviToAdd.Text );
                lviThis.ToolTipText = lviToAdd.ToolTipText;
                lvThis.Items.Add( lviThis );
                ColorAll( lviToAdd.Text );
                SetListViewChanged( lvThis, true );
            }

            if ( iAddedCount++ % 20 == 0 ) {
                lviThis.EnsureVisible( );
                lvThis.Update( );
            }
            lviThis.Selected = true;
            return lviThis;
        }

        /// <summary>
        /// Update the Garbvage, Existing, Wish and Import counters from time to time.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void TmrUpdateCountersTick( object sender, EventArgs e )
        {
            if ( strTargetFolder != "" && lvExisting.Columns[ 0 ].Text != strTargetFolder ) {
                lvExisting.Columns[ 0 ].Text = strTargetFolder;
            }
            else {
                lvExisting.Columns[ 0 ].Text = lvExisting.Items.Count + " Existing " + strCollectionType;
            }
            lvGarbage.Columns[ 0 ].Text = lvGarbage.Items.Count + " Garbage " + strCollectionType;
            if ( strImportFolder != "" && lvImport.Columns[ 0 ].Text != strImportFolder ) {
                lvImport.Columns[ 0 ].Text = strImportFolder;
            }
            else {
                lvImport.Columns[ 0 ].Text = lvImport.Items.Count + " Import " + strCollectionType;
            }
            lvWish.Columns[ 0 ].Text = lvWish.Items.Count + " Wish " + strCollectionType;
            lvMaintenance.Columns[ 0 ].Text = lvMaintenance.Items.Count + " Maintenance Items";
        }

        /// <summary>
        /// A key has been pressed on a list view.
        /// Check which key and take the according actions.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void lvKeyDown( object sender, KeyEventArgs e )
        {
            var lvThis = (ListView)sender;

            if ( e.KeyCode == Keys.Delete ) {
                EraseSelected( lvThis );
            }
            if ( e.Control && e.KeyCode == Keys.A ) {  // Ctrl-A: Select all 
                foreach ( ListViewItem lviThis in lvThis.Items ) {
                    lviThis.Selected = true;
                }
            }
            if ( e.Control && e.KeyCode == Keys.X ) {  // Ctrl-X: Cut
                var strcolThis = new System.Collections.Specialized.StringCollection( );
                foreach ( ListViewItem lviThis in lvThis.SelectedItems ) {
                    strcolThis.Add( lviThis.Text );
                    lvThis.Items.Remove( lviThis );
                }
                Clipboard.SetFileDropList( strcolThis );
            }
            if ( e.Control && e.KeyCode == Keys.C ) {  // Ctrl-C: Copy
                if ( lvThis.SelectedItems.Count > 0 ) {
                    var strcolThis = new System.Collections.Specialized.StringCollection( );
                    foreach ( ListViewItem lviThis in lvThis.SelectedItems ) {
                        strcolThis.Add( lviThis.Text );
                    }
                    Clipboard.SetFileDropList( strcolThis );
                }
            }
            if ( e.Control && e.KeyCode == Keys.V ) {  // Ctrl-V: Paste
                if ( Clipboard.ContainsFileDropList( ) ) {
                    System.Collections.Specialized.StringCollection scFileNames = Clipboard.GetFileDropList( );
                    var saFileNames = new string[ scFileNames.Count ];
                    int iIndex = 0;
                    foreach ( string sFileName in scFileNames ) {
                        saFileNames[ iIndex ] += sFileName;
                        iIndex++;
                    }
                    lvMaintenanceAddFiles( saFileNames );
                }
                ColorMaintenance( );
            }
        }

        /// <summary>
        /// A list view item has been double clicked.  Seach IMDb.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void LvDoubleClick( object sender, EventArgs e )
        {
            switch ( cobDoubleClickDefault.Text ) {
                case "DoubleClick Default":
                    Play( );
                    break;
                case "Play":
                    Play( );
                    break;
                case "Search Info":
                    SearchInfo( (ListView)sender );
                    break;
                case "Search Download":
                    SearchDownload( (ListView)sender );
                    break;
                default:
                    Play( );
                    break;
            }
        }

        /// <summary>
        /// The mouse entered a list view.  
        /// Make the list view acitve, so that the scrolling works.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void LvMouseEnter( object sender, EventArgs e )
        {
            if ( !cobCriteria.ContainsFocus ) { // don't take away the focus from the Criteria entry field
                ((ListView)sender).Select( );
            }
        }

        /// <summary>
        /// An item has been draged from a list view.  
        /// Set the drag source and effects.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void LvItemsDrag( object sender, ItemDragEventArgs e )
        {
            lvDragSource = (ListView)sender;
            lvDragSource.DoDragDrop( lvDragSource.SelectedItems, DragDropEffects.Copy );
        }

        /// <summary>
        /// Somehting has been draged over a list view.  
        /// Check it and set the cursor accordingly.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void LvDragOver( object sender, DragEventArgs e )
        {
            if ( e.Data.GetDataPresent( typeof( ListView.SelectedListViewItemCollection ) ) ) {
                e.Effect = e.AllowedEffect;
            }
            if ( e.Data.GetDataPresent( DataFormats.FileDrop ) ) {
                e.Effect = e.AllowedEffect;
            }
        }

        /// <summary>
        /// Something has been droped on a list view.  
        /// Check it and act accordingly.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void LvDragDrop( object sender, DragEventArgs e )
        {
            var lvThis = (ListView)sender;
            // TODO: Make Separate function function

            if ( e.AllowedEffect == DragDropEffects.None ) {
                return;
            }
            Cursor.Current = Cursors.WaitCursor;

            // from another list view
            if ( e.Data.GetDataPresent( typeof( ListView.SelectedListViewItemCollection ) ) ) {
                foreach ( ListViewItem lviThis in (ListView.SelectedListViewItemCollection)e.Data.GetData( typeof( ListView.SelectedListViewItemCollection ) ) ) {
                    if ( rbSeries.Checked &&
                         ((string)lvThis.Tag == "Garbage" ||
                           (string)lvThis.Tag == "Wish") ) {
                        var lviToAdd = new ListViewItem( RemoveEpisodeInfo( lviThis.Text ) );
                        AddItemToListView( lvThis, lviToAdd );
                    }
                    else {
                        AddItemToListView( lvThis, lviThis );
                    }
                }
                if ( rbSeries.Checked ) {
                    if ( (string)lvThis.Tag == "Garbage" ) ColorExistingAndUp( );
                    if ( (string)lvThis.Tag == "Wish" ) ColorWishAndUp( );
                }
            }
            // from folders or files
            if ( e.Data.GetDataPresent( DataFormats.FileDrop ) ) {
                int iFolderCount = 0;
                string strConsideredFolder = "";
                foreach ( string strPath in (string[])e.Data.GetData( DataFormats.FileDrop ) ) {
                    FileAttributes attr = File.GetAttributes( strPath );
                    bool isFolder = (attr & FileAttributes.Directory) == FileAttributes.Directory;
                    // from folder
                    if ( isFolder ) {
                        iFolderCount++;
                        if ( (string)lvThis.Tag == "Existing" ) {
                            strTargetFolder = (iFolderCount == 1) ? strPath : Path.GetDirectoryName( strPath );
                        }
                        if ( (string)lvThis.Tag == "Import" ) {
                            strImportFolder = (iFolderCount == 1) ? strPath : Path.GetDirectoryName( strPath );
                        }
                        if ( iFolderCount == 1 ) {
                            AddFolderToListView( lvThis, strPath );
                            strConsideredFolder = strPath;
                        }
                        else if ( iFolderCount == 2 ) {
                            ShowInfo( "You have dropped more than one single folders.\n" +
                                       "Only " + strConsideredFolder + " has been added to the list!" );
                        }
                    }
                    // from video file
                    else if ( rgxMainExtensions.IsMatch( Path.GetExtension( strPath ).ToLower( ) ) ) {
                        string strJustName = Path.GetFileNameWithoutExtension( strPath );
                        if ( (string)lvThis.Tag == "Existing" ) {
                            strTargetFolder = Path.GetDirectoryName( strPath );
                        }
                        if ( (string)lvThis.Tag == "Import" ) {
                            strImportFolder = Path.GetDirectoryName( strPath );
                        }
                        var fiFile = new FileInfo( strPath );
                        var lviThis = new ListViewItem( CleanName( strJustName ) );
                        lviThis = AddItemToListView( lvThis, lviThis );
                        MakeToolTip( fiFile, lvThis, lviThis );
                        if ( cbGetHigherRes.Checked ) ColorAll( lviThis.Text );  // color again to get info from tooltip
                    }
                    // from txt file
                    else if ( Path.GetExtension( strPath ).ToLower( ) == ".txt" ) {
                        AddTxtToListView( lvThis, strPath );
                    }
                    // from csv file
                    else if ( Path.GetExtension( strPath ).ToLower( ) == ".csv" ) {
                        AddCsvToListView( lvThis, strPath );
                    }
                    // from xml file
                    else if ( Path.GetExtension( strPath ).ToLower( ) == ".xml" ) {
                        AddXmlToListView( lvThis, strPath );
                    }
                    // from listview stream
                    else if ( Path.GetExtension( strPath ).ToLower( ) == ".slv" ) {
                        DeserializeListView( lvThis, strPath );
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }


        /// <summary>
        /// Searches a list view for an item with a specific text.  
        /// </summary>
        /// <param name="lvListView">The list view to be searched.</param>
        /// <param name="strText">The text to search for.</param>
        /// <returns>The found list item, otherwise null if there are no items in the view</returns>
        ListViewItem FindItem( ListView lvListView, string strText )
		{
			return ( lvListView.Items.Count < 1 ) ? null : lvListView.FindItemWithText( strText, false, 0, false );
		}

		/// <summary>
		/// Searches a list view for an items starting with a specific text. 
		/// </summary>
		/// <param name="lvListView">The list view to be searched.</param>
		/// <param name="strText">The text with whish the item should start.</param>
		/// <returns>The item if found, otherwise null.</returns>
		ListViewItem FindItemStart( ListView lvListView, string strText )
		{
			if ( lvListView.Items.Count < 1 ) {
				return null;
			}
			ListViewItem lviThis = lvListView.FindItemWithText( strText );
			if ( lviThis != null ) {
				if ( lviThis.Text.Length >= strText.Length ) {
					if ( lviThis.Text.Substring(0,strText.Length) == strText ) {
						return lviThis;
					}
				}
			}
			return null;
		}

		/// <summary>
		/// Removed the selected items from the list view.
		/// </summary>
		/// <param name="lvThis">The list view from where the items should e removed.</param>
		void EraseSelected( ListView lvThis )
		{
			SetListViewChanged( lvThis, true );
			foreach ( ListViewItem lviItem in lvThis.SelectedItems ) {
				lvThis.Items.Remove( lviItem );
                if ( !rbSeries.Checked && (string)lvThis.Tag != "Import" ) {
                    ColorAll( lviItem.Text );
                }
			}
			if ( rbSeries.Checked ) {
				if ( (string)lvThis.Tag == "Garbage" ) ColorExistingAndUp( );
				if ( (string)lvThis.Tag == "Existing" ) ColorWishAndUp( );
				if ( (string)lvThis.Tag == "Wish" ) ColorImport( );
			}
		}
		
		/// <summary>
		/// Erases a color completely from a list view.
		/// </summary>
		/// <param name="lvThis">The list view where the color should be earsed.</param>
		/// <param name="clrToErase">The color which should be erased fromt he list view.</param>
		void EraseColorFromListView( ListView lvThis, Color clrToErase )
		{
			lvThis.BeginUpdate( );
			foreach ( ListViewItem lviThis in lvThis.Items ) {
				if ( lviThis.BackColor == clrToErase ) {
					lvThis.Items.Remove( lviThis );
                    if ( (string)lvThis.Tag != "Import" ) {
                        ColorAll( lviThis.Text );
                        SetListViewChanged( lvThis, true );
                    }
                }
			}
			lvThis.EndUpdate( );
		}

		/// <summary>
		/// Copy the selected item from one list view to another.
		/// </summary>
		/// <param name="lvSource">The list view from where to copy the selected items.</param>
		/// <param name="lvTarget">The list view to where to copy the selected items.</param>
		void CopySelected ( ListView lvSource, ListView lvTarget )
		{
			foreach ( ListViewItem lviThis in lvSource.SelectedItems ) {
				if ( rbSeries.Checked &&
				     ( (string)lvTarget.Tag == "Garbage" ||
				       (string)lvTarget.Tag == "Wish" ) ) {
					var lviToAdd = new ListViewItem( RemoveEpisodeInfo( lviThis.Text ) );
					AddItemToListView( lvTarget, lviToAdd );
				} else {
					AddItemToListView( lvTarget, lviThis );
				}
			}
			if ( rbSeries.Checked ) {
				if ( (string)lvTarget.Tag == "Garbage" ) ColorExistingAndUp( );
				if ( (string)lvTarget.Tag == "Wish" ) ColorWishAndUp( );
			}
		}

		/// <summary>
		/// Select items in a list according to a regular expression.
		/// </summary>
		/// <param name="lvThis">The list to select from.</param>
		/// <param name="sRegex">The regular expression according to which to select.</param>
		int SelectInList( ListView lvThis, string sRegex )
		{
			int iSelected = 0;
			var rgxToolTip = new Regex( sRegex );
			
			Cursor.Current = Cursors.WaitCursor;
			foreach ( ListViewItem lviThis in lvThis.Items ) {
				if( rgxToolTip.IsMatch( lviThis.ToolTipText ) ) {
					lviThis.Selected = true;
					iSelected++;
				}
				else {
					lviThis.Selected = false;
				}
			}
			Cursor.Current = Cursors.Default;
			if( iSelected > 0 ) {
				ShowInfo( "Selected " + iSelected + " items in " + lvThis.Tag  + " " + strCollectionType + ".");
			}
			return iSelected;
		}

        #endregion ListView Handling

        #region Action Bar Interface

        /// <summary>
        /// A list view has been dragged over the Tool Tip Regex text box.
        /// Chec it and set the drop effects accordingly.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void CobCriteriaDragOver( object sender, DragEventArgs e )
        {
            if ( e.Data.GetDataPresent( typeof( ListView.SelectedListViewItemCollection ) ) ) {
                e.Effect = e.AllowedEffect;
            }
        }

        /// <summary>
        /// A list view has been dropped on the Tool Tip Regex text box.
        /// Select items in the list view according to the regular expression.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void CobCriteriaDragDrop( object sender, DragEventArgs e )
        {
            if ( e.AllowedEffect == DragDropEffects.None ) {
                return;
            }
            if ( e.Data.GetDataPresent( typeof( ListView.SelectedListViewItemCollection ) ) ) {
                if ( SelectInList( lvDragSource, GetCriteriaRegEx( cobCriteria.Text ) ) == 0 ) {
                    ShowInfo( "Selected no items." );
                }
            }
        }

        /// <summary>
        /// Get the according selected regular expression for the Criteria. 
        /// </summary>
        /// <returns>The regular expression to fill the Tool Tip Regex.</returns>
        string GetCriteriaRegEx( string sSelection )
        {
            string sResult = "";
            switch ( sSelection ) {
                case "Square Format": sResult = @"\(((4:3)|(5:4)|(3:2)|(1\.[0-5]\d+))\)"; break;
                case "Wide Screen": sResult = @"\(((16:9)|(1\.85:1)|(1\.[6-9]\d+)|(2\.[0-2]\d+))\)"; break;
                case "Cinema Scope": sResult = @"\((([23]\.*\d*:1)|(2\.[3-9]\d+)|(3\.\d+))\)"; break;
                case "<699 horizontal": sResult = @"Video:  [1-6]\d{2} *x"; break;
                case ">699 & <1000 horizontal": sResult = @"Video:  [7-9]\d{2} *x"; break;
                case ">700 horizontal": sResult = @"(Video:  [7-9]\d{2} x)|(Video:  [1-9]\d{3} *x)"; break;
                case ">1000 horizontal": sResult = @"Video:  [1-9]\d{3} *x"; break;
                case "2 Channels": sResult = @"2 channels"; break;
                case "6 Channels": sResult = @"6 channels"; break;
                case "Series with \"SxxExx\"": sResult = @".[Ss]\d+[Ee]\d+"; break;
                case "Movies with \"(Year)\"": sResult = @"\([1-2][0-9]{3}\)"; break;
                default: sResult = cobCriteria.Text; break;
            }
            return sResult;
        }

        /// <summary>
        /// Select all items in all lists according to the selection criteria.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnSelectClick( object sender, EventArgs e )
        {
            int iTotalSelected = 0;
            iTotalSelected += SelectInList( lvGarbage, GetCriteriaRegEx( cobCriteria.Text ) );
            iTotalSelected += SelectInList( lvExisting, GetCriteriaRegEx( cobCriteria.Text ) );
            iTotalSelected += SelectInList( lvWish, GetCriteriaRegEx( cobCriteria.Text ) );
            iTotalSelected += SelectInList( lvImport, GetCriteriaRegEx( cobCriteria.Text ) );
            if ( iTotalSelected == 0 ) {
                ShowInfo( "Selected no items." );
            }
        }

        /// <summary>
        /// Put all items in all lists in the Garbage list according to the selection ctriteria.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnBinClick( object sender, EventArgs e )
        {
            int iTotalSelected = 0;
            iTotalSelected += SelectInList( lvExisting, GetCriteriaRegEx( cobCriteria.Text ) );
            CopySelected( lvExisting, lvGarbage );
            iTotalSelected += SelectInList( lvWish, GetCriteriaRegEx( cobCriteria.Text ) );
            CopySelected( lvWish, lvGarbage );
            iTotalSelected += SelectInList( lvImport, GetCriteriaRegEx( cobCriteria.Text ) );
            CopySelected( lvImport, lvGarbage );
            ShowInfo( "Copied " + iTotalSelected + " items, including duplicates, into the Garbage list." );
        }

        /// <summary>
        /// Wish all items in the Import list according to the selection criteria.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnAddToWishClick( object sender, EventArgs e )
        {
            int iTotalSelected = 0;
            iTotalSelected += SelectInList( lvImport, GetCriteriaRegEx( cobCriteria.Text ) );
            CopySelected( lvImport, lvWish );
            ShowInfo( "Copied " + iTotalSelected + " items, including duplicates, into the Wish list." );
        }

        /// <summary>
        /// Just rip everything from the Import list. 
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnJustRipItClick( object sender, EventArgs e )
        {
            foreach ( ListViewItem lviThis in lvImport.Items ) {
                lviThis.Selected = lviThis.BackColor == NeutralColor;
            }
            CopySelected( lvImport, lvWish );
            ProcessImport( );
        }

        void ExistingJustScanItInThread( )
        {
            SearchOption soMovieFileMerger = SearchOption.AllDirectories;
            foreach ( var drive in DriveInfo.GetDrives( ) ) {
                foreach ( var strPath in Directory.GetDirectories( drive.Name ) ) {
                    if ( strPath.Contains( strCollectionType ) ) {
                        strTargetFolder = strPath;
                        LogInfo( "Scanning folder " + strPath );
                        var diFolder = new DirectoryInfo( strPath );
                        foreach ( FileInfo fiFile in diFolder.GetFiles( "*", soMovieFileMerger ) ) {
                            if ( !rgxMainExtensions.IsMatch( fiFile.Extension.ToLower( ) ) ) {
                                continue;
                            }
                            string strJustName = fiFile.Name;
                            if ( strJustName.LastIndexOf( '.' ) != -1 ) {
                                strJustName = strJustName.Substring( 0, strJustName.LastIndexOf( '.' ) );
                            }
                            DoAddFileToListView( CleanName( strJustName ), fiFile, lvExisting );
                        }
                    }
                }
            }
            LogInfo( "Just Scan It is finished..." );
            MessageBox.Show( "Finished sanning all concerned folders.\n" +
                                "Check the log tab for detailed information...", "Movie File Merger - Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Just scan everything and put it in the Existing lists. 
        /// </summary>
        void JustScanIt( )
        {
            SaveChangedListView( lvExisting );  // Ask to safe, if something has changed
            SaveChangedListView( lvGarbage );
            SaveChangedListView( lvWish );

            LogMessage( "Info", Color.Turquoise, "\nScanning folders contaning " + strCollectionType + " in the name on all connected hard disks..." );

            SearchOption soMovieFileMerger = SearchOption.AllDirectories;
            tspbMFM.Maximum = 0;
            tspbMFM.Value = 0;
            foreach ( var drive in DriveInfo.GetDrives( ) ) {
                foreach ( var strPath in Directory.GetDirectories( drive.Name ) ) {
                    if ( strPath.Contains( strCollectionType ) ) {
                        var diFolder = new DirectoryInfo( strPath );
                        foreach ( FileInfo fiFile in diFolder.GetFiles( "*", soMovieFileMerger ) ) {
                            if ( rgxMainExtensions.IsMatch( fiFile.Extension.ToLower( ) ) ) {
                                tspbMFM.Maximum++;
                            }
                        }
                    }
                }
            }
            SetStatus( "Calculated " + tspbMFM.Maximum + " items to check..." );
            // Add the files in a tread, so that not every freezes all the time
            var thrdExistingJustScanIt = new Thread( ExistingJustScanItInThread );
            thrdExistingJustScanIt.Start( );
        }

        /// <summary>
        /// Just everything and put it in the Existing list. 
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnJustScanItClick( object sender, EventArgs e )
        {
            JustScanIt( );
        }

        /// <summary>
        /// Edit the Criteria regex.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnEditClick( object sender, EventArgs e )
        {
            cobCriteria.Text = GetCriteriaRegEx( cobCriteria.Text );
        }

        #endregion Action Bar Interface

        /************************************************************************************************/
        /*                                          Other Tabs                                          */
        /************************************************************************************************/

        #region Maintenance Tab Handling



        /// <summary>
        /// Drag files from a list view, to drop and on FileBot, the Windows Explorer, ... 
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void LvFileListDrag( object sender, ItemDragEventArgs e )
        {
            lvDragSource = (ListView)sender;
            var strcolFileList = new System.Collections.Specialized.StringCollection( );
            foreach ( ListViewItem lviThis in lvDragSource.SelectedItems ) {
                strcolFileList.Add( lviThis.Text );
                lvDragSource.Items.Remove( lviThis );
            }

            var doFileList = new DataObject( );
            doFileList.SetFileDropList( strcolFileList );
            lvDragSource.DoDragDrop( doFileList, DragDropEffects.Move );
        }

        /// <summary>
        /// Adds an item to the maintenance list view, if it does not exist already.
        /// </summary>
        /// <param name="lviToAdd">The item to add.</param>
        /// <returns>The reference of the added item.</returns>

        ListViewItem AddItemToMaintenanceListView( ListViewItem lviToAdd )
        {
            ListViewItem lviThis = FindItem( lvMaintenance, lviToAdd.Text );

            if ( lviThis == null ) {
                lviThis = new ListViewItem( lviToAdd.Text );
                lviThis.ToolTipText = lviToAdd.ToolTipText;
                lvMaintenance.Items.Add( lviThis );
            }
            return lviThis;
        }

        /// <summary>
        /// Color the maintenance list
        /// </summary>
        void ColorMaintenance( )
        {
            foreach ( ListViewItem lviThis in lvMaintenance.Items ) {
                string sFileName = Path.GetFileNameWithoutExtension( lviThis.Text );
                string sExtension = Path.GetExtension( lviThis.Text ).ToLower( );

                if ( rgxMainExtensions.IsMatch( sExtension ) || rgxAddonExtensions.IsMatch( sExtension ) ) {
                    // the file is or beloongs to a video
                    if ( Regex.IsMatch( sFileName, tbGoodDocuNameRegex.Text ) ) {
                        lviThis.BackColor = GoodDocuColor;  // found good documentary
                        LogMaintenance( "Good documentary: ", GoodDocuColor, sFileName );
                    }
                    else if ( Regex.IsMatch( sFileName, tbGoodEpisodeNameRegex.Text ) ) {
                        lviThis.BackColor = GoodEpisodeColor;  // found good episode
                        LogMaintenance( "Good episode: ", GoodEpisodeColor, sFileName );
                    }
                    else if ( Regex.IsMatch( sFileName, tbGoodMovieNameRegex.Text ) ) {
                        lviThis.BackColor = GoodMovieColor;  // found good movie
                        LogMaintenance( "Good movie: ", GoodMovieColor, sFileName );
                    }
                    else if ( Regex.IsMatch( sFileName, tbBadDocuNameRegex.Text ) ) {
                        lviThis.BackColor = BadDocuColor;  // found bad documentary
                        LogMaintenance( "Bad documentary: ", BadDocuColor, sFileName );
                    }
                    else if ( Regex.IsMatch( sFileName, tbBadEpisodeNameRegex.Text ) ) {
                        lviThis.BackColor = BadEpisodeColor;  // found bad episode
                        LogMaintenance( "Bad episode: ", BadEpisodeColor, sFileName );
                    }
                    else if ( Regex.IsMatch( sFileName, tbBadMovieNameRegex.Text ) ) {
                        lviThis.BackColor = BadMovieColor;  // found bad movie
                        LogMaintenance( "Bad movie: ", BadMovieColor, sFileName );
                    }
                    else {
                        lviThis.BackColor = BadNameColor;  // found bad name, not sure of what
                        LogMaintenance( "Invalid item: ", BadNameColor, sFileName );
                    }
                }
                else {  // the file doesn't belong to a video
                    lviThis.BackColor = NeutralColor;
                    LogMaintenance( "Invalid item: ", NeutralColor, sFileName );
                }
            }
        }

        /// <summary>
        /// Adds items contained in a folder to a list view.
        /// </summary>
        /// <param name="strFolderName">The name of the folder containing the items to be added.</param>
        void AddFolderToMaintenanceListView( string strFolderName )
        {
            var diFolder = new DirectoryInfo( strFolderName );
            SearchOption soMovieFileMerger = SearchOption.AllDirectories;

            SetStatus( "Adding folder " + strFolderName + " to " + lvMaintenance.Tag + "..." );

            lvMaintenance.BeginUpdate( );
            lvMaintenance.Sorting = SortOrder.None;
            tspbMFM.Maximum = 1;
            tspbMFM.Value = 0;
            foreach ( FileInfo fiFile in diFolder.GetFiles( "*", soMovieFileMerger ) ) {
                tspbMFM.Maximum++;
            }
            foreach ( FileInfo fiFile in diFolder.GetFiles( "*", soMovieFileMerger ) ) {
                var lviThis = new ListViewItem( fiFile.FullName );
                lviThis = AddItemToMaintenanceListView( lviThis );
                MakeToolTip( fiFile, lvMaintenance, lviThis );
                tspbMFM.Value++;
            }
            lvMaintenance.Sorting = SortOrder.Ascending;
            lvMaintenance.EndUpdate( );
            tspbMFM.Value = 0;
            SetStatus( "Added all files!" );
            ClearStatus( );
        }

        /// <summary>
        /// Add dropped file to the Maintenance list.
        /// </summary>
        /// <param name="saFileList">The string array with the file names.</param>
        void lvMaintenanceAddFiles( string[] saFileList )
        {
            foreach ( string strPath in saFileList ) {
                FileAttributes attr = File.GetAttributes( strPath );
                bool isFolder = (attr & FileAttributes.Directory) == FileAttributes.Directory;

                if ( isFolder ) { // from folder
                    AddFolderToMaintenanceListView( strPath );
                }
                else if ( File.Exists( strPath ) ) { // from video file
                    var fiFile = new FileInfo( strPath );
                    var lviThis = new ListViewItem( strPath );
                    lviThis = AddItemToMaintenanceListView( lviThis );
                    MakeToolTip( fiFile, lvMaintenance, lviThis );
                }
            }
        }


        /// <summary>
        /// Something has been droped on the maintenance list view.  
        /// Check it and act accordingly.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void LvMaintenanceDragDrop( object sender, DragEventArgs e )
        {
            if ( e.AllowedEffect == DragDropEffects.None ) return;

            // from folders or files
            if ( e.Data.GetDataPresent( DataFormats.FileDrop ) ) {
                Cursor.Current = Cursors.WaitCursor;
                if ( (string)lvDragSource.Tag != "Maintenance" ) {
                    lvMaintenance.Items.Clear( );
                }
                lvMaintenanceAddFiles( (string[])e.Data.GetData( DataFormats.FileDrop ) );
                ColorMaintenance( );
                rtbMaintenance.ScrollToCaret( );
                Cursor.Current = Cursors.Default;
            }
        }

        void SelectColorInList( ListView lvThis, Color ThisColor )
        {
            foreach ( ListViewItem lviThis in lvThis.Items ) {
                if ( lviThis.BackColor == ThisColor ) {
                    lviThis.Selected = true;
                }
            }
            if ( lvThis.SelectedItems.Count > 0 ) lvThis.SelectedItems[ 0 ].EnsureVisible( );
            lvThis.Select( );
        }

        /// <summary>
        /// Select of items of a certain color in the maintenance list.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnSelectMaintenanceClick( object sender, EventArgs e )
        {
            SelectColorInList( lvMaintenance, ((Button)sender).BackColor );
        }

        /// <summary>
        /// Give drag feedback, make the MFM icon cursor.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void LvGiveFeedback( object sender, GiveFeedbackEventArgs e )
        {
            e.UseDefaultCursors = false;
            var bmp = new Bitmap( pbMFM.Image );
            var cur = new Cursor( bmp.GetHicon( ) );
            Cursor.Current = cur;
        }

        /// <summary>
        /// Change the column 0 width so that the row can all the time be selected with the mouse.  
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void LvMaintenanceResize( object sender, EventArgs e )
        {
            lvMaintenance.Columns[ 0 ].Width = lvMaintenance.Width - 35;
        }

        #endregion Maintenance Tab Handling

        #region Messages and Log Tab Handling
        // Functions realated to Status or Info Messages and Log tab.

        /// <summary>
        /// Adds a mesage, with the date, type, and a certain color, to the rich text box on the log tab. 
        /// </summary>
        /// <param name="strType">The type name of the message.</param>
        /// <param name="cColor">The color of the message.</param>
        /// <param name="strMessage">The message itself.</param>
        void LogMessage( string strType, Color cColor, string strMessage )
        {
            rtbLog.SelectionColor = cColor;
            if ( strMessage[0] == '\n') {
                rtbLog.AppendText( "\n" );
                strMessage = strMessage.Substring( 1 );
            }
            rtbLog.SelectionColor = cColor;
            rtbLog.AppendText( DateTime.Now + ": " + strType + " - " + strMessage + "\n" );
        }

        /// <summary>
        /// Adds a mesage to the maintenance log, with the date, type, and a certain color, to the rich text box on the log tab. 
        /// </summary>
        /// <param name="strType">The type name of the message.</param>
        /// <param name="cColor">The color of the message.</param>
        /// <param name="strMessage">The message itself.</param>
        void LogMaintenance( string strType, Color cColor, string strMessage )
        {
            rtbMaintenance.SelectionColor = cColor;
            rtbMaintenance.AppendText( DateTime.Now + ": " + strType + " - " + strMessage + "\n" );
        }

        /// <summary>
        /// Logs a status message, in black color, and activates the wait cursor.
        /// </summary>
        /// <param name="strMessage">The message itself.</param>
        void SetStatus( string strMessage )
        {
            LogMessage( "Status", Color.Black, strMessage );
            tsslMFM.Text = strMessage;
            ssMFM.Update( );
            Cursor.Current = Cursors.WaitCursor;
        }

        /// <summary>
        /// Deactivates the wait cursor.
        /// </summary>
        void ClearStatus( )
        {
            Cursor.Current = Cursors.Default;
            tsslMFM.Text = "";
        }

        /// <summary>
        /// Logs an informal message and asks the user for a decission.
        /// </summary>
        /// <param name="strMessage">The informal message.</param>
        /// <returns>The user feedback.</returns>
        DialogResult ShowInfo( string strMessage )
        {
            LogMessage( "Info", Color.Blue, strMessage );
            return MessageBox.Show( strMessage, "Movie File Merger - Info",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
        }

        /// <summary>
        /// Logs an informal message and asks the user for a decission.
        /// </summary>
        /// <param name="strMessage">The informal message.</param>
        private void LogInfo( string strMessage )
        {
            if ( this.InvokeRequired ) {
                // we were called on a worker thread marshal the call to the user interface thread
                this.Invoke( new UpdateStatusDelegate( LogInfo ), new object[] { strMessage } );
                return;
            }
            LogMessage( "Info", Color.Blue, strMessage );
        }

        /// <summary>
        /// Logs an error message and asks the user for a decission.
        /// </summary>
        /// <param name="strMessage">The error message.</param>
        /// <returns>The user feedback.</returns>
        DialogResult ShowError( string strMessage )
        {
            LogMessage( "Error", Color.Red, strMessage );
            return MessageBox.Show( strMessage, "Movie File Merger - Error",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Error );
        }

        /// <summary>
        /// Asks the user for a decission.
        /// </summary>
        /// <param name="strMessage">The question.</param>
        /// <returns>The user feedback.</returns>
        DialogResult ShowYesNoQuestion( string strMessage )
        {
            LogMessage( "Question", Color.BlueViolet, "\n" + strMessage );
            DialogResult drAnswer = MessageBox.Show( strMessage, "Movie File Merger - Question",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            LogMessage( "Answer", Color.BlueViolet, drAnswer.ToString( ) + "\n" );
            return drAnswer;
        }

        #endregion Mesasges and Log Tab Handling

        #region Settings Tab Handling
        // Functions related to the Settings tab and the settings itself.

        /// <summary>
        /// Assign all the regular expressions from the settings tab.
        /// </summary>
        void AssignRegexes( )
        {
            rgxMainExtensions = new Regex( tbMainExtensionsRegex.Text.ToLower( ) );
            rgxAddonExtensions = new Regex( tbAddonExtensionsRegex.Text.ToLower( ) );
            rgxEpisodesId = new Regex( tbEpisodesIdRegex.Text );
            rgxTrimBefore = new Regex( tbCutNameBeforeRegex.Text );
            rgxAphanumeric = new Regex( tbOnlyCharactersRegex.Text );
            rgxToLower = new Regex( tbToLowerRegex.Text );
        }

        /// <summary>
        /// Read the setting of one XML element
        /// </summary>
        /// <param name="doc">The XML Document to read from.</param>
        /// <param name="sSettingName">The XML element name.</param>
        /// <param name="sDefault">The default value if the setting is not found.</param>
        /// <returns>The setting as string, if found, otherwise the default value.</returns>
        string readXmlSetting( XmlDocument doc, string sSettingName, string sDefault )
        {
            string sText = "";
            XmlNode node = doc.DocumentElement.SelectSingleNode( sSettingName );
            if ( node == null ) sText = sDefault;
            else {
                sText = node.InnerText;
                if ( sText == null ) sText = sDefault;
            }
            return sText;
        }

        /// <summary>
        /// Loads the XML settings. 
        /// </summary>
        void LoadSettings( bool bReset )
        {
            strXmlSettingsFilePath = Path.Combine( strPrivatePath, "MFM Settings.xml" );
            if ( !File.Exists( strXmlSettingsFilePath ) || bReset ) {
                using ( XmlWriter writer = XmlWriter.Create( strXmlSettingsFilePath ) ) // create a dummy
                {
                    writer.WriteStartDocument( );
                    writer.WriteStartElement( "MFMSettings" );  // root exlement
                    writer.WriteEndElement( );  // close the root element
                    writer.WriteEndDocument( );
                }
            }

            var xmlSettings = new XmlDocument( );
            xmlSettings.Load( strXmlSettingsFilePath );

            // General settings			
            strNickName = readXmlSetting( xmlSettings, "/MFMSettings/General/NickName", "Anonymous" );
            cobSearchInfo.Text = readXmlSetting( xmlSettings, "/MFMSettings/General/SeachInfo", "Google" );
            cobSearchDownload.Text = readXmlSetting( xmlSettings, "/MFMSettings/General/SeachDownload", "Rarbg" );
            cobDownloadCriteria.Text = readXmlSetting( xmlSettings, "/MFMSettings/General/DownloadCriteria", "720p" );
            cobDoubleClickDefault.Text = readXmlSetting( xmlSettings, "/MFMSettings/General/DoubleClickDefault", "Play" );
            cbGetHigherRes.Checked = readXmlSetting( xmlSettings, "/MFMSettings/General/GetHigherRes", "True" ) == "True";
            lblLastChecked.Text = readXmlSetting( xmlSettings, "/MFMSettings/General/LastChecked", "Last Checked: Never" );
            cobCheckForUpdates.Text = readXmlSetting( xmlSettings, "/MFMSettings/General/CheckForUpdates", "Check for updates daily." );
            cobMinimumResolution.Text = readXmlSetting( xmlSettings, "/MFMSettings/General/MinimumResolution", " <~720p (HD)" );

            // Considered Files settings 
            tbMainExtensionsRegex.Text = readXmlSetting( xmlSettings, "/MFMSettings/ConsideredFiles/MainExtensionsRegex", @"avi|mkv|mp4" );
            tbAddonExtensionsRegex.Text = readXmlSetting( xmlSettings, "/MFMSettings/ConsideredFiles/AddonExtensionsRegex", @"srt|sub" );

            // Name Unification settings 
            tbCutNameBeforeRegex.Text = readXmlSetting( xmlSettings, "/MFMSettings/NameUnification/CutNameBeforeRegex", @"720p|1080p|(cd[1234])|x264|aac|divx|xvid|dvd" );
            tbOnlyCharactersRegex.Text = readXmlSetting( xmlSettings, "/MFMSettings/NameUnification/OnlyCharactersRegex", @"[^\p{L}\p{N} -'ก-์]" );
            tbToLowerRegex.Text = readXmlSetting( xmlSettings, "/MFMSettings/NameUnification/ToLowerRegex", @" On | A | The | Of | And | Or | To | From | For | In | As | At | With " );
            tbEpisodesIdRegex.Text = readXmlSetting( xmlSettings, "/MFMSettings/NameUnification/EpisodesIdRegex", @".s\d+[e ]\d+" );
            tbGoodDocuNameRegex.Text = readXmlSetting( xmlSettings, "/MFMSettings/NameUnification/GoodDocuRegex", @".* S[12]\d{3}E\d{1,3} .*$" );
            tbGoodEpisodeNameRegex.Text = readXmlSetting( xmlSettings, "/MFMSettings/NameUnification/GoodEpisodeRegex", @".* S\d{2}E\d{2}(-E\d{2})? .*$" );
            tbGoodMovieNameRegex.Text = readXmlSetting( xmlSettings, "/MFMSettings/NameUnification/GoodMovieRegex", @".* \([12]\d{3}\)$" );
            tbBadDocuNameRegex.Text = readXmlSetting( xmlSettings, "/MFMSettings/NameUnification/BadDocuRegex", @".[Ss][12]\d{3}[Ee]\d{1,3}" );
            tbBadEpisodeNameRegex.Text = readXmlSetting( xmlSettings, "/MFMSettings/NameUnification/BadEpisodeRegex", @".[Ss]\d{1,2}[Ee]\d{1,2}" );
            tbBadMovieNameRegex.Text = readXmlSetting( xmlSettings, "/MFMSettings/NameUnification/BadMovieRegex", @".[12]\d{3}" );

            // Supporting Programms settings 
            strTeraCopyPath = readXmlSetting( xmlSettings, "/MFMSettings/SupportingProgramms/TeraCopyPath", @"C:\Program Files\TeraCopy\TeraCopy.exe" );

            if ( strNickName == "Anonymous" ) {
                ShowInputDialog( "Please enter your nickname.", ref strNickName );
                Text = strNickName + " - Movie File Merger";
            }
            AssignRegexes( );
            btnSearchDownload.Text = cobSearchDownload.Text;
            cobSearchDownloadMaintenance.Text = cobSearchDownload.Text;
            btnSearchDownloadMaintenance.Text = cobSearchDownload.Text;
            btnSearchInfo.Text = cobSearchInfo.Text;
            cobSearchInfoMaintenance.Text = cobSearchInfo.Text;
            btnSearchInfoMaintenance.Text = cobSearchInfo.Text;
        }

        /// <summary>
        /// Show a simple dialog with the possibility to imput text.
        /// </summary>
        /// <param name="strTitle">The dialog title.</param>
        /// <param name="strInput">The string which will contain the inputed text.</param>
        /// <returns>The Dialog Result.</returns>
        private static DialogResult ShowInputDialog( string strTitle, ref string strInput )
        {
            var size = new Size( 300, 70 );
            var inputBox = new Form( );

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = strTitle;

            var textBox = new TextBox( );
            textBox.Size = new Size( size.Width - 10, 23 );
            textBox.Location = new Point( 5, 5 );
            textBox.Text = strInput;
            inputBox.Controls.Add( textBox );

            var okButton = new Button( );
            okButton.DialogResult = DialogResult.OK;
            //okButton.Name = "btnOk";
            okButton.Size = new Size( 100, 23 );
            okButton.Text = "&OK";
            okButton.Location = new Point( 100, 39 );
            inputBox.Controls.Add( okButton );

            inputBox.AcceptButton = okButton;

            DialogResult result = inputBox.ShowDialog( );
            strInput = textBox.Text;
            return result;
        }

        /// <summary>
        /// Save the XML settings.
        /// </summary>
        void SaveSettings( )
        {
            using ( XmlWriter writer = XmlWriter.Create( strXmlSettingsFilePath ) ) {
                writer.WriteStartDocument( );
                writer.WriteStartElement( "MFMSettings" );  // root exlement

                writer.WriteStartElement( "General" );  // General settings group
                writer.WriteElementString( "NickName", strNickName );
                writer.WriteElementString( "SeachInfo", cobSearchInfo.Text );
                writer.WriteElementString( "SeachDownload", cobSearchDownload.Text );
                writer.WriteElementString( "DownloadCriteria", cobDownloadCriteria.Text );
                writer.WriteElementString( "DoubleClickDefault", cobDoubleClickDefault.Text );
                writer.WriteElementString( "GetHigherRes", cbGetHigherRes.Checked.ToString( ) );
                writer.WriteElementString( "LastChecked", lblLastChecked.Text );
                writer.WriteElementString( "CheckForUpdates", cobCheckForUpdates.Text );
                writer.WriteElementString( "MinimumResolution", cobMinimumResolution.Text );
                writer.WriteEndElement( );

                writer.WriteStartElement( "ConsideredFiles" );  // Considered Files settings group
                writer.WriteElementString( "MainExtensionsRegex", tbMainExtensionsRegex.Text );
                writer.WriteElementString( "AddonExtensionsRegex", tbAddonExtensionsRegex.Text );
                writer.WriteEndElement( );

                writer.WriteStartElement( "NameUnification" );  // Name Unification settings group
                writer.WriteElementString( "CutNameBeforeRegex", tbCutNameBeforeRegex.Text );
                writer.WriteElementString( "OnlyCharactersRegex", tbOnlyCharactersRegex.Text );
                writer.WriteElementString( "ToLowerRegex", tbToLowerRegex.Text );
                writer.WriteElementString( "EpisodesIdRegex", tbEpisodesIdRegex.Text );
                writer.WriteElementString( "GoodDocuNmaeRegex", tbGoodDocuNameRegex.Text );
                writer.WriteElementString( "GoodEpisodeNameRegex", tbGoodEpisodeNameRegex.Text );
                writer.WriteElementString( "GoodMovieNameRegex", tbGoodMovieNameRegex.Text );
                writer.WriteElementString( "BadDocuNameRegex", tbBadDocuNameRegex.Text );
                writer.WriteElementString( "BadEpisodeNameRegex", tbBadEpisodeNameRegex.Text );
                writer.WriteElementString( "BadMovieNameRegex", tbBadMovieNameRegex.Text );
                writer.WriteEndElement( );

                writer.WriteStartElement( "SupportingProgramms" );  // Supporting Programms settings group
                writer.WriteElementString( "TeraCopyPath", strTeraCopyPath );
                writer.WriteEndElement( );

                writer.WriteEndElement( );  // close the root element
                writer.WriteEndDocument( );
            }
            AssignRegexes( );
        }

        /// <summary>
        /// The settings tab has been left.  
        /// Save the settings.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void TpSettingsLeave( object sender, EventArgs e )
        {
            SaveSettings( );
        }

        /// <summary>
        /// Some settings have been changed, save them...
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void SettingsChanged( object sender, EventArgs e )
        {
            SaveSettings( );
        }

        /// <summary>
        /// Reset all settings to their default values.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnResetSettingsClick( object sender, EventArgs e )
        {
            LoadSettings( true );
        }

        #endregion Settings Tab Handling

        #region Instructions Tab Handling
        // Functions releated to the Instructions tab.
        // So far there are no special functions and it's just a placeholder.
        #endregion Instructions Tab Handling

        #region About Tab Handling
        // Functions related to the About tab.

        /// <summary>
        /// Check if the latest version of Movie File Merger is installed.
        /// </summary>
        void CheckLatestVersion( string sWhen )
        {
            string sLatestRelease = "";
            string sReleaseNotes = "";
            string sCurrentRelease = Application.ProductVersion.Remove( Application.ProductVersion.Length - 2 );
            lblVersion.Text = sCurrentRelease;
            var dtLastChecked = new DateTime( );
            string sLastCheckedDate = lblLastChecked.Text.Substring( "Last Checked: ".Length );
            if ( sLastCheckedDate == "Never" ) sLastCheckedDate = "1900-01-01";
            dtLastChecked = Convert.ToDateTime( sLastCheckedDate );
            var tsWaitForDays = new TimeSpan( 1, 0, 0, 0 ); // Check for updates daily...

            switch ( cobCheckForUpdates.Text ) {
                case "Check for updates weekly.":
                    tsWaitForDays = new TimeSpan( 7, 0, 0, 0 );
                    break;
                case "Check for updates monthly.":
                    tsWaitForDays = new TimeSpan( 30, 0, 0, 0 );
                    break;
            }

            dtLastChecked += tsWaitForDays;

            if ( dtLastChecked < DateTime.Now || sWhen.Contains( "Now" ) ) {
                var xmlLatestVersion = new XmlDocument( );
                try {
                    xmlLatestVersion.Load( @"https://movie-file-merger.org/MFMVersion.xml" );
                    sLatestRelease = readXmlSetting( xmlLatestVersion, "/MFMVersions/LatestRelease", "0.0.0" );
                    sReleaseNotes = readXmlSetting( xmlLatestVersion, "/MFMVersions/ReleaseNotes", "Sorry, did not find any release notes..." );
                    if ( sCurrentRelease != sLatestRelease ) {
                        if ( ShowYesNoQuestion( "A different version (" + sLatestRelease + ") of MFM (currently " + sCurrentRelease + ") " +
                                                 "is available.\n" + sReleaseNotes + "\n" +
                                                 "Go to the Download page now?" ) == DialogResult.Yes ) {
                            ExecuteThis( "https://movie-file-merger.org/downloads.html" );
                            Application.Exit( );
                        }
                    }
                    else if ( sWhen.Contains( "Now" ) ) {
                        ShowInfo( sCurrentRelease + " is the latest version." );
                    }
                    lblLastChecked.Text = "Last Checked: " + StandardizeDate( DateTime.Now );
                }
                catch ( Exception e ) {
                    ShowInfo( "Tried to check for updates but had a problem...\n" + e.Message );
                }
            }
        }

        /// <summary>
        /// Check if the latest version is installed.
        /// </summary>
        /// <param name="sender">The object that invoked the event that fired the event handler.</param>
        /// <param name="e">The arguments that the implementor of this event may find useful.</param>
        void BtnCheckNowClick(object sender, EventArgs e)
		{
			CheckLatestVersion( "Now" );
		}

        /// <summary>
        /// Launch the MFM website if the link label has been clicked.
        /// </summary>
		/// <param name="sender">The object that invoked the event that fired the event handler.</param>
		/// <param name="e">The arguments that the implementor of this event may find useful.</param>
        private void llMovieFileMergerOrg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExecuteThis("https://movie-file-merger.org/");
        }

        /// <summary>
        /// Launch the MFM Forum if the link label has been clicked.
        /// </summary>
		/// <param name="sender">The object that invoked the event that fired the event handler.</param>
		/// <param name="e">The arguments that the implementor of this event may find useful.</param>
        private void llUserFeedbackForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExecuteThis("https://movie-file-merger.org/forum/index.php");
        }

        /// <summary>
        /// Launch the MFM Donation page if the link label has been clicked.
        /// </summary>
		/// <param name="sender">The object that invoked the event that fired the event handler.</param>
		/// <param name="e">The arguments that the implementor of this event may find useful.</param>
        private void llDonateABeerOrTwo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExecuteThis( "https://movie-file-merger.org/donations.html#Donations" );
        }

        /// <summary>
        /// Launch the MFM GitHub site if the link label has been clicked.
        /// </summary>
		/// <param name="sender">The object that invoked the event that fired the event handler.</param>
		/// <param name="e">The arguments that the implementor of this event may find useful.</param>
        private void llGitHubSourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExecuteThis("https://github.com/Modi777/Movie-File-Merger");
        }

        #endregion About Tab Handling

        #region FTP Sucker

        void LogFTPSuckerMessage(string strType, Color cColor, string strMessage)
        {
            rtbFTPSucker.SelectionColor = cColor;
            rtbFTPSucker.AppendText(DateTime.Now + ": " + strType + " - " + strMessage + "\n");
            rtbFTPSucker.ScrollToCaret();
        }

        void LogFTPSuckerMajorAction(string strMessage)
        {
            LogFTPSuckerMessage("Info", Color.Purple, strMessage);
        }

        void LogFTPSuckerAction(string strMessage)
        {
            LogFTPSuckerMessage("Info", Color.Blue, strMessage);
        }

        void LogFTPSuckerInfo(string strMessage)
        {
            LogFTPSuckerMessage("Info", Color.Gray, strMessage);
        }

        void LogFTPSuckerError(string strMessage)
        {
            LogFTPSuckerMessage("Error", Color.Red, strMessage);
        }

        private void btnGetRemoteFileNames_Click(object sender, EventArgs e)
        {

            LogFTPSuckerMajorAction("Trying to get Remote File Names...");
            try
            {
                // Set up session options
                SessionOptions sessionOptions = new SessionOptions
                {
                    Protocol = Protocol.Ftp,
                    HostName = tbHostName.Text,
                    PortNumber = Convert.ToInt32(tbPortNumber.Text),
                    UserName = tbUserName.Text,
                    Password = tbPassword.Text,
                };

                string localPath = tbLocalPath.Text;
                string remotePath = tbRemotePath.Text;

                using (Session session = new Session())
                {
                    // Connect
                    LogFTPSuckerAction("Opening Session to " + sessionOptions.HostName);
                    session.Open(sessionOptions);

                    // Enumerate files and directories
                    LogFTPSuckerAction("Getting file Infos...");
                    IEnumerable<RemoteFileInfo> fileInfos =
                        session.EnumerateRemoteFiles(remotePath, null, EnumerationOptions.EnumerateDirectories | EnumerationOptions.AllDirectories);

                    foreach (RemoteFileInfo fileInfo in fileInfos)
                    {
                        if (fileInfo.IsDirectory)
                        {
                            LogFTPSuckerInfo("Found directory: " + fileInfo.FullName);
                        }
                        else
                        {
                            LogFTPSuckerInfo("Found file: " + fileInfo.FullName);
                            ListViewItem lviRemoteFile = new ListViewItem(fileInfo.FullName);
                            AddItemToListView(lvRemoteFiles, lviRemoteFile);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                LogFTPSuckerError(exception.Message);
            }
            LogFTPSuckerMajorAction("Finshed getting Remote File Names...");
        }

        private void btnDownloadWishedRemoteFiles_Click(object sender, EventArgs e)
        {

            LogFTPSuckerMajorAction("Trying to download Wished Remote Files...");
            try
            {
                // Set up session options
                SessionOptions sessionOptions = new SessionOptions
                {
                    Protocol = Protocol.Ftp,
                    HostName = tbHostName.Text,
                    PortNumber = Convert.ToInt32(tbPortNumber.Text),
                    UserName = tbUserName.Text,
                    Password = tbPassword.Text,
                };

                string localPath = tbLocalPath.Text;
                string remotePath = tbRemotePath.Text;

                using (Session session = new Session())
                {
                    // Connect
                    LogFTPSuckerAction("Opening Session to " + sessionOptions.HostName);
                    session.Open(sessionOptions);

                    // Enumerate files and directories
                    LogFTPSuckerAction("Getting file Infos...");
                    IEnumerable<RemoteFileInfo> fileInfos =
                        session.EnumerateRemoteFiles(remotePath, null, EnumerationOptions.EnumerateDirectories | EnumerationOptions.AllDirectories);

                    foreach (RemoteFileInfo fileInfo in fileInfos)
                    {

                        if (!fileInfo.IsDirectory)
                        {
                            LogFTPSuckerInfo("Found file: " + fileInfo.FullName);

                            ListViewItem lviRemote = FindItem(lvRemoteFiles, fileInfo.FullName);
                            if (lviRemote != null)
                            {
                                if (lviRemote.BackColor == WishColor)
                                {
                                    string localFilePath = session.TranslateRemotePathToLocal(fileInfo.FullName, remotePath, localPath);
                                    // Create local subdirectory, if it does not exist yet
                                    if (!Directory.Exists(localFilePath))
                                    {
                                        LogFTPSuckerAction("Creating directory: " + localFilePath);
                                        Directory.CreateDirectory(localFilePath);
                                    }

                                    SetStatus("Downloading " + lviRemote.Text);
                                    LogFTPSuckerAction("Downloading " + lviRemote.Text);
                                    // Download file
                                    TransferOperationResult transferResult = session.GetFiles(session.EscapeFileMask(fileInfo.FullName), localFilePath);

                                    // Did the download succeeded?
                                    if (transferResult.IsSuccess)
                                    {
                                        LogFTPSuckerAction ("Success downloading file " + fileInfo.FullName );
                                    }
                                    else
                                    { 
                                        LogFTPSuckerError("Error downloading file " + fileInfo.FullName + " because " + transferResult.Failures[0].Message);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                LogFTPSuckerError(exception.Message);
            }
            SetStatus("Finshed downloading Wished Remote Files...");
            LogFTPSuckerMajorAction("Finshed downloading Wished Remote Files...");
        }

        private void lvFTPSuckerResize(object sender, EventArgs e)
        {
            lvRemoteFiles.Columns[0].Width = lvRemoteFiles.Width - 35;
        }

        private void btnColorList_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lviRemoteFile in lvRemoteFiles.Items)
            {
                FileInfo fiRemoteFile = new FileInfo(lviRemoteFile.Text);

                string strJustName = fiRemoteFile.Name;
                if (strJustName.LastIndexOf('.') != -1)
                {
                    strJustName = strJustName.Substring(0, strJustName.LastIndexOf('.'));
                }
                string strCleanName = CleanName(strJustName);
                string strExtension = fiRemoteFile.Extension.ToLower();

                if (rgxMainExtensions.IsMatch(strExtension))
                {
                    tspbMFM.Value = 0;
                    DoAddFileToListView(strCleanName, fiRemoteFile, lvImport);
                }

                if (rgxMainExtensions.IsMatch(strExtension) || rgxAddonExtensions.IsMatch(strExtension))
                {
                    ListViewItem lviImport = FindItem(lvImport, strCleanName);
                    if (lviImport != null)
                    {
                        lviRemoteFile.BackColor = lviImport.BackColor;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnOpenWinSCP_Click(object sender, EventArgs e)
        {
            // ExecuteThis(Path.GetDirectoryName(Application.ExecutablePath) + "\\WinSCP.exe /command open ftp://" + tbUserName.Text + ":" + tbPassword.Text + "@" + tbHostName.Text);
            ExecuteThis(Path.GetDirectoryName(Application.ExecutablePath) + "\\WinSCP.exe");
        }
    }
#endregion FTP Sucker
}
