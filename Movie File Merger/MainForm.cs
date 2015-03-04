/*
 * Created by SharpDevelop.
 * User: Reinhold Lauer
 * Date: 2012-04-09
 */
 
// Copyright 2012-2015 Reinhold Lauer
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
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using MediaInfoLib;

namespace Movie_File_Merger
{
	/// <summary>
	/// Application to selectively combine collections on hard disks.
	/// </summary>
	public partial class MainForm : Form
	{
		ListView lvDragSource = null;  // the list view from which has been dragged
		Color DragColor = Color.Red;  // the color of the item which has been dragged
		string strCollectionType = "Miscellaneous";  // the active collection type
		const string strIMDbSearchType = "&s=tt";  // to search on IDMb for the title only
		MediaInfo miThis = new MediaInfo( );  // detailed information about the video file from MediaInfo

		// item colors		
		Color GarbageColor = Color.Red;
		Color ExistingColor = Color.YellowGreen;
		Color WishColor = Color.LawnGreen;
		Color NeutralColor = Color.White;
		
		// list change indicators when exiting a collection type
		bool bExistingChanged = false;
		bool bGarbageChanged = false;
		bool bWishChanged = false;

		// paths to standard files and folders
		string strPrivatePath = Path.Combine( Path.GetDirectoryName(Application.StartupPath), @"MFM Private\" );
		string strCollectionsPath = Path.Combine( Path.GetDirectoryName(Application.StartupPath), @"MFM Collections\" );
		string strTeraCopyListsPath = "";
		string strXmlFilePath = "";

		// regular expressions to filter the messed up file names
		Regex rgxVideoExtensions;  // to find the main files
		Regex rgxAddonExtensions;  // to find wanted addon files, like subtitles
		Regex rgxEpisodesId;  // to find the episode identifier
		Regex rgxTrimBefore;  // the names will be cut of before, like 720p
		Regex rgxAphanumeric;  // only accept clean charaecters in the name
		Regex rgxToLower;  // words in the name that should be lower case, like the, to, for, of
		Regex rgxMultiSpace = new Regex( @"[ ]{2,}" );  // two spaces in a row
		Regex rgxNumber = new Regex( @"\d+" );  // any integer number
		
		/// <summary>
		/// MFM main form to selectivley combine video collections
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			
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
			strXmlFilePath = Path.Combine( strPrivatePath, "MFM Settings.xml" );
			if ( !File.Exists( strXmlFilePath ) ) {
				using (XmlWriter writer = XmlWriter.Create( strXmlFilePath )) // create a dummy
				{
				    writer.WriteStartDocument();
				    writer.WriteStartElement("MFMSettings");  // root exlement
				    writer.WriteEndElement();  // close the root element
				    writer.WriteEndDocument();
				}
			}
			
			LoadXmlSettings( );
			this.Text = tbNickName.Text + " - Movie File Merger";

			// load the instruction and copyright files
			try { 
				rtbHelp.LoadFile( Path.Combine( Application.StartupPath, "Movie File Merger Instructions.rtf" ), 
				                  RichTextBoxStreamType.RichText );
			} catch ( IOException e ) { 
				ShowInfo( e.Message ); 
			}
			
			try {
				rtbSettings.LoadFile( Path.Combine(Application.StartupPath, "Movie File Merger Settings.rtf"), 
				                      RichTextBoxStreamType.RichText);
			} catch ( IOException e ) { 
				ShowInfo( e.Message );
			}
			try {
				rtbCopyright.LoadFile( Path.Combine(Application.StartupPath, "Movie File Merger Copyright.rtf"), 
				                       RichTextBoxStreamType.RichText);
			} catch ( IOException e ) { 
				ShowInfo( e.Message ); 
			}
			
			SetColumnWidth( );
			CheckLatestVersion( );
		}
		
		/************************/
		/* Supporting Functions */
		/************************/
		/// <summary>
		/// Adds a mesage, with the date, type, and a certain color, to the rich text box on the log tab. 
		/// </summary>
		/// <param name="strType">The type name of the message.</param>
		/// <param name="cColor">The color of the message.</param>
		/// <param name="strMessage">The message itself.</param>
		void LogMessage( string strType, Color cColor, string strMessage )
		{
			rtbLog.SelectionColor = cColor;
			rtbLog.AppendText( DateTime.Now + ": " + strType + " - " + strMessage + "\n" );
		}
		
		/// <summary>
		/// Logs a status message, in black color, and activates the wait cursor.
		/// </summary>
		/// <param name="strMessage">The message itself.</param>
		void SetStatus( string strMessage )
		{
			tsslMFM.Text = strMessage;
			ssMFM.Update();
			LogMessage( "Status", Color.Black, strMessage );
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
			return MessageBox.Show( strMessage, "Movie File Merger - Question", 
			                        MessageBoxButtons.YesNo, MessageBoxIcon.Question );
		}

		/// <summary>
		/// Readjusts the column width if the Window is resized. 
		/// </summary>
		void SetColumnWidth( )
		{
			if ( this.WindowState == FormWindowState.Minimized ) {	// Not if minimized
				return;
			}
			int iColumnWidth = ( this.Size.Width - 37 ) / 3;
			scVertical.SplitterDistance = iColumnWidth;
			scVerticalRight.Width = iColumnWidth * 2;
			scVerticalRight.SplitterDistance = iColumnWidth + 3;
			scVerticalRight.SplitterWidth = 3;
			lvExisting.Columns[0].Width = lvExisting.Width - 35;
			lvGarbage.Columns[0].Width = lvGarbage.Width - 35;
			lvImport.Columns[0].Width = lvImport.Width - 35;
			lvWish.Columns[0].Width = lvWish.Width - 35;
		}

		/// <summary>
		/// The form size has been changed.
		/// Move the spliters.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void MainFormSizeChanged( object sender, EventArgs e )
		{
			if ( this.WindowState == FormWindowState.Minimized ) {	// Not if minimized
				return;
			}
			scFolders.SplitterDistance = scFolders.Size.Width / 2;
			scHorizontal.SplitterDistance = scHorizontal.Size.Height / 2;
		}
		
		/// <summary>
		/// Assign all the regular expressions from the settings tab.
		/// </summary>
		void AssignRegexes( )
		{
			rgxVideoExtensions = new Regex( tbVideoExtensionsRegex.Text.ToLower() );
			rgxAddonExtensions = new Regex( tbAddonExtensionsRegex.Text.ToLower() );
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
		string readXmlSetting ( XmlDocument doc, string sSettingName, string sDefault ) {
			string sText = "";
			XmlNode node = doc.DocumentElement.SelectSingleNode ( sSettingName );
			if ( node == null )  sText = sDefault;
			else {
				sText = node.InnerText;
				if ( sText == null ) sText = sDefault;
			}
			return sText;
		}

		/// <summary>
		/// Loads the XML settings.
		/// </summary>
		void CheckLatestVersion ()
		{
			string sLatestRelease = "";
			string sReleaseNotes = "";
			string sCurrentRelease = Application.ProductVersion.Remove( Application.ProductVersion.Length-2 );
			lblVersion.Text = sCurrentRelease;
			var dtLastChecked = new DateTime ( );
			string sLastCheckedDate = lblLastChecked.Text.Substring( "Last Checked: ".Length );
			if ( sLastCheckedDate == "Never" ) sLastCheckedDate = "1900-01-01";
			dtLastChecked = Convert.ToDateTime( sLastCheckedDate );
			var tsWaitForDays = new TimeSpan (  1, 0, 0, 0 ); // Check for updates daily...
			
			switch ( cobCheckForUpdates.Text ) {
				case "Check for updates weekly." :
					tsWaitForDays = new TimeSpan ( 7, 0, 0, 0 );
					break;
				case "Check for updates monthly." :
					tsWaitForDays = new TimeSpan ( 30, 0, 0, 0 );
					break;
			}
			
			dtLastChecked += tsWaitForDays;
			
			if ( dtLastChecked < DateTime.Now ) {
				var xmlLatestVersion = new XmlDocument ( );
				try {
					xmlLatestVersion.Load ( @"http://www.movie-file-merger.org/MFMVersion.xml" );
					sLatestRelease = readXmlSetting ( xmlLatestVersion, "/MFMVersions/LatestRelease", "0.0.0");
					sReleaseNotes = readXmlSetting ( xmlLatestVersion, "/MFMVersions/ReleaseNotes", "Sorry, did not find any release notes...");
					if ( sCurrentRelease != sLatestRelease ) {
						if ( ShowYesNoQuestion ( "A different version of MFM (" + sCurrentRelease + " -> " + sLatestRelease + ") " +
						                         "is available with following changes...\n" +  sReleaseNotes + "\n\n" +
						                         "Go to the Download page now?" ) == DialogResult.Yes) {
							System.Diagnostics.Process.Start ( "http://www.movie-file-merger.org/downloads.html" );
						}
						else {
							ShowInfo ( "You can change the frequency of update checks in the About tab." );
						}
						lblLastChecked.Text = "Last Checked: " + StandardizeDate ( DateTime.Now );
					}
				}
				catch ( Exception e ) { 
					ShowInfo( "Tried to check for updates but had a problem...\n" + e.Message ); 
				}
			}
		}
		
		/// <summary>
		/// Loads the XML settings. 
		/// </summary>
		void LoadXmlSettings ()
		{
			var xmlSettings = new XmlDocument ( );
			xmlSettings.Load ( strXmlFilePath );

			// General settings			
			tbNickName.Text = readXmlSetting ( xmlSettings, "/MFMSettings/General/NickName", "Anonymous");
			tbToolTipRegex.Text = readXmlSetting ( xmlSettings, "/MFMSettings/General/ToolTipRegex", "Enter a regular expression...");
			cbGetHigherRes.Checked = readXmlSetting ( xmlSettings, "/MFMSettings/General/GetHigherRes", "True") == "True";
			cbKeepFolders.Checked = readXmlSetting ( xmlSettings, "/MFMSettings/General/KeepFolders", "False") == "True";
			cbMediaInfo.Checked = readXmlSetting ( xmlSettings, "/MFMSettings/General/MediaInfo", "True") == "True";
			lblLastChecked.Text = readXmlSetting ( xmlSettings, "/MFMSettings/General/LastChecked", "Last Checked: Never");
			cobCheckForUpdates.Text = readXmlSetting ( xmlSettings, "/MFMSettings/General/CheckForUpdates", "Last Checked: Never");
			
			// Considered Files settings 
			tbVideoExtensionsRegex.Text = readXmlSetting ( xmlSettings, "/MFMSettings/ConsideredFiles/VideoExtensionsRegex", @"avi|mkv|mp4" );
			tbAddonExtensionsRegex.Text = readXmlSetting ( xmlSettings, "/MFMSettings/ConsideredFiles/AddonExtensionsRegex", @"srt|sub" );

			// Name Unification settings 
			tbCutNameBeforeRegex.Text = readXmlSetting ( xmlSettings, "/MFMSettings/NameUnification/CutNameBeforeRegex", @"(.[12][09]\d\d)|(cd[1234])|x264|aac|720p|1080p|divx|xvid|dvd" );
			tbOnlyCharactersRegex.Text = readXmlSetting ( xmlSettings, "/MFMSettings/NameUnification/OnlyCharactersRegex", @"[^a-zA-Z0-9 -'üöä]" );
			tbToLowerRegex.Text = readXmlSetting ( xmlSettings, "/MFMSettings/NameUnification/ToLowerRegex", @" On | A | The | Of | And | Or | To | From | For | In | As | At | With " );
			tbEpisodesIdRegex.Text = readXmlSetting ( xmlSettings, "/MFMSettings/NameUnification/EpisodesIdRegex", @".s\d+[e ]\d+" );

			// Supporting Programms settings 
			tbTeraCopyPath.Text = readXmlSetting ( xmlSettings, "/MFMSettings/SupportingProgramms/TeraCopyPath", @"C:\Program Files\TeraCopy\TeraCopy.exe" );
			tbMediaInfoPath.Text = readXmlSetting ( xmlSettings, "/MFMSettings/SupportingProgramms/MediaInfoPath", @"C:\Program Files\MediaInfo\MediaInfo.exe" );

			if ( tbNickName.Text == "Anonym" ) {
				ShowInfo( "Please enter your nick name in the Settings..." );
			}
			AssignRegexes( );
		}
		
		/// <summary>
		/// Save the XML settings.
		/// </summary>
		void SaveXmlSettings( )
		{
			using (XmlWriter writer = XmlWriter.Create( strXmlFilePath ))
			{
			    writer.WriteStartDocument();

			    writer.WriteStartElement("MFMSettings");  // root exlement

			    writer.WriteStartElement("General");  // General settings group
				writer.WriteElementString("NickName", tbNickName.Text );
				writer.WriteElementString("ToolTipRegex", tbToolTipRegex.Text );
				writer.WriteElementString("GetHigherRes", cbGetHigherRes.Checked.ToString() );
				writer.WriteElementString("KeepFolders", cbKeepFolders.Checked.ToString() );
				writer.WriteElementString("MediaInfo", cbMediaInfo.Checked.ToString() );
				writer.WriteElementString("LastChecked", lblLastChecked.Text );
				writer.WriteElementString("CheckForUpdates", cobCheckForUpdates.Text );
			    writer.WriteEndElement();
			   
			    writer.WriteStartElement("ConsideredFiles");  // Considered Files settings group
				writer.WriteElementString("VideoExtensionsRegex", tbVideoExtensionsRegex.Text );
				writer.WriteElementString("AddonExtensionsRegex", tbAddonExtensionsRegex.Text );
			    writer.WriteEndElement();

			    writer.WriteStartElement("NameUnification");  // Name Unification settings group
				writer.WriteElementString("CutNameBeforeRegex", tbCutNameBeforeRegex.Text );
				writer.WriteElementString("OnlyCharactersRegex", tbOnlyCharactersRegex.Text );
				writer.WriteElementString("ToLowerRegex", tbToLowerRegex.Text );
				writer.WriteElementString("EpisodesIdRegex", tbEpisodesIdRegex.Text );
			    writer.WriteEndElement();
			    
			    writer.WriteStartElement("SupportingProgramms");  // Supporting Programms settings group
				writer.WriteElementString("TeraCopyPath", tbTeraCopyPath.Text );
				writer.WriteElementString("MediaInfoPath", tbMediaInfoPath.Text );
			    writer.WriteEndElement();
			   
			    writer.WriteEndElement();  // close the root element

			    writer.WriteEndDocument();
			}
			AssignRegexes( );
		}
		
		/// <summary>
		/// Sets a tag in a list view to remember when to save the view.
		/// </summary>
		/// <param name="lvThis">The listview to be tagged.</param>
		/// <param name="bChanged">true when the list view has changed, otherwise flase.</param>
		void SetListViewChanged( ListView lvThis, bool bChanged )
		{
			if ( (string)lvThis.Tag == "Existing" ) {
				bExistingChanged = bChanged;
			}
			if ( (string)lvThis.Tag == "Garbage" ) {
				bGarbageChanged = bChanged;
			}
			if ( (string)lvThis.Tag == "Wish" ) {
				bWishChanged = bChanged;
			}
		}
		
		/// <summary>
		/// Converts a datetime to the standard date format yyyy-mm-dd.
		/// </summary>
		/// <param name="dtToSStandardize">The date time to standardize.</param>
		/// <returns>The standzadized date string.</returns>
		string StandardizeDate( DateTime dtToSStandardize )
		{
			return 	dtToSStandardize.Year.ToString( "D4" ) + "-" +
			        dtToSStandardize.Month.ToString( "D2" ) + "-" +
			        dtToSStandardize.Day.ToString( "D2" );
		}
		
		/// <summary>
		/// Converts a datetime to the standard time format hh:mm:ss.
		/// </summary>
		/// <param name="dtToSStandardize">The date time to standardize.</param>
		/// <returns>The standzadized time string.</returns>
		string StandardizeTime( DateTime dtToSStandardize )
		{
			return 	dtToSStandardize.Hour.ToString( "D2" ) + "-" +
			        dtToSStandardize.Minute.ToString( "D2" ) + "-" +
			        dtToSStandardize.Second.ToString( "D2" );
		}
		
		/*******************
		 * Major Functions *
		 *******************/
		
		/// <summary>
		/// Initialize a list view from a text file in MFM format.
		/// </summary>
		/// <param name="lvListView"></param>
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
		/// Cleans up and tries to standardize the name of movies or series, so that they 
		/// can be comparted better.
		/// </summary>
		/// <param name="strMessyName">The messy name, for example when downloaded.</param>
		/// <returns>The cleaned up name.</returns>
		string CleanName( string strMessyName )
		{
			string strCleanName = strMessyName.ToLower( );
			
			if ( rbSeries.Checked ) { // handle series with SxxExx identifier
				Match matchEpisodeId = rgxEpisodesId.Match( strCleanName );
				if ( matchEpisodeId.Success ) {
					MatchCollection mcNumbers = rgxNumber.Matches( matchEpisodeId.Value );
					string strUnifiedEpisodeId = " s" + mcNumbers[0].Value.PadLeft( 2, '0' ) +
					                              "e" + mcNumbers[1].Value.PadLeft( 2, '0' );
					strCleanName = strCleanName.Substring( 0, matchEpisodeId.Index ) + strUnifiedEpisodeId;
				}
			}
			else  // handle movies and other stuff
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

			return strCleanName;
		}
		
		/// <summary>
		/// Adds an item to a list view by name, if it does not exist already.
		/// </summary>
		/// <param name="lvThis">The list view to add the item.</param>
		/// <param name="strCleanName">The cleaned up name of the item to add.</param>
		/// <returns>The reference of the added item.</returns>
		ListViewItem AddItemToListView( ListView lvThis, string strCleanName )
		{
			ListViewItem lviThis = FindItem( lvThis, strCleanName );
			
			if ( lviThis == null ) {
				lviThis = new ListViewItem( strCleanName );
				lvThis.Items.Add( lviThis );
				ColorAll( strCleanName );
				SetListViewChanged( lvThis, true );
			}
			return lviThis;
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
				lvThis.Items.Add ( lviThis );
				ColorAll( lviToAdd.Text );
				SetListViewChanged( lvThis, true );
			}
			
			return lviThis;
		}
		
		/// <summary>
		/// Adds items to a list view from a CSV file.
		/// </summary>
		/// <param name="lvThis">The list view to add the items.</param>
		/// <param name="strFileName">The name of the file to b added.</param>
		void AddCsvToListView( ListView lvThis, string strFileName )
		{
			string line;
			var srMovies = new StreamReader( strFileName );
			lvThis.BeginUpdate( );
			lvThis.Sorting = SortOrder.None;
			SetStatus( "Loading " + Path.GetFileNameWithoutExtension( strFileName ) + 
			           " to " + lvThis.Tag + " " + strCollectionType + "..." );
			
			while ( ( line = srMovies.ReadLine( ) ) != null ) {
				string[] saParts = line.Split( '\t' );
				var lviThis = new ListViewItem( CleanName( saParts[0] ) );
				lviThis = AddItemToListView( lvThis, lviThis );
				if ( saParts.Length > 1 ) lviThis.ToolTipText = saParts[1].Replace( '*', '\n' );
			}
			
			if ( rbSeries.Checked ) {
				if ( (string)lvThis.Tag == "Garbage" ) ColorExistingAndUp( );
				if ( (string)lvThis.Tag == "Wish" ) ColorWishAndUp( );
			}
			
			lvThis.Sorting = SortOrder.Ascending;
			lvThis.EndUpdate( );
			srMovies.Close( );
			ClearStatus( );
		}
		
		/// <summary>
		/// Adds items to a list view from the tabulator separated file.
		/// </summary>
		/// <param name="lvThis">The list view to add the items.</param>
		/// <param name="strFileName">The name of the file to b added.</param>
		void AddTxtToListView( ListView lvThis, string strFileName )
		{
			string line;
			var srMovies = new StreamReader( strFileName );
			lvThis.BeginUpdate( );
			lvThis.Sorting = SortOrder.None;
			SetStatus( "Loading " + Path.GetFileNameWithoutExtension( strFileName ) + " to " + lvThis.Tag + " " + strCollectionType + "..." );

			var saTitles = new string[20];
			var saParts = new string[20];
			
			line = srMovies.ReadLine( );
			if ( line.StartsWith( "Title\t", StringComparison.Ordinal ) ) {
				saTitles = line.Split( '\t' );
				for ( int i = 1; i < saTitles.Length; i++ ) {
					if ( saTitles[i].Length > 1 ) {
						saTitles[i] += ":  ";
					}
				}
				line = srMovies.ReadLine( );
			}
			
			while ( line != null ) {
				saParts = line.Split( '\t' );
				var lviThis = new ListViewItem( CleanName( saParts[0].Trim('"') ) );
				lviThis.ToolTipText = saParts[0] + "\n";
				lviThis = AddItemToListView( lvThis, lviThis );
				for ( int i = 1; i < saParts.Length; i++ ) {
					lviThis.ToolTipText += saTitles[i] + saParts[i] + "\n";
				}
				line = srMovies.ReadLine( );
			} 

			if ( rbSeries.Checked ) {
				if ( (string)lvThis.Tag == "Garbage" ) {
					ColorExistingAndUp( );
				}
				if ( (string)lvThis.Tag == "Wish" ) {
					ColorWishAndUp( );
				}
			}
			
			lvThis.Sorting = SortOrder.Ascending;
			lvThis.EndUpdate( );
			srMovies.Close( );
			ClearStatus( );
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

			lvThis.BeginUpdate( );
			lvThis.Sorting = SortOrder.None;
			tspbMFM.Maximum = 1;
			tspbMFM.Value = 0;
			foreach( FileInfo fiFile in diFolder.GetFiles( "*", soMovieFileMerger ) ) {
				if( rgxVideoExtensions.IsMatch( fiFile.Extension.ToLower() ) ) {
					tspbMFM.Maximum++;
				}
			}
			foreach( FileInfo fiFile in diFolder.GetFiles( "*", soMovieFileMerger ) ) {
				if( !rgxVideoExtensions.IsMatch( fiFile.Extension.ToLower() ) ) {
					continue;
				}
				string strJustName = fiFile.Name;
				if ( strJustName.LastIndexOf( '.' ) != -1 ) {
					strJustName = strJustName.Substring( 0, strJustName.LastIndexOf( '.' ) );
				}
				var lviThis = new ListViewItem ( CleanName( strJustName ) );
				lviThis = AddItemToListView( lvThis, lviThis );
				MakeToolTip( fiFile, lvThis, lviThis );
				if ( cbGetHigherRes.Checked ) ColorAll( lviThis.Text );  // color again to get info from tooltip

				tspbMFM.Value++;
				// SetStatus( "Adding " + fiFile.Name );
			}
			if ( rbSeries.Checked ) {
				if ( (string)lvThis.Tag == "Garbage" ) {
					ColorExistingAndUp( );
				}
				if ( (string)lvThis.Tag == "Wish" ) {
					ColorWishAndUp( );
				}
			}
			lvThis.Sorting = SortOrder.Ascending;
			lvThis.EndUpdate ();
			tspbMFM.Value = 0;
			SetStatus( "Added all files!" );
			ClearStatus( );
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
				if ( lviExisting != null ) {
					if ( cbGetHigherRes.Checked ) {
						Match mtExistingResolution = Regex.Match( lviExisting.ToolTipText, "Video:  \\d+" );
						if ( mtExistingResolution.Success ) {
							Match mtImportResolution = Regex.Match( lviImport.ToolTipText, "Video:  \\d+" );
							if ( mtImportResolution.Success ) {
								string sExistingResolution = Regex.Match( mtExistingResolution.Value, @"\d+" ).Value;
								int iExistingResolution = Int32.Parse( sExistingResolution );
								string sImportResolution = Regex.Match( mtExistingResolution.Value, @"\d+" ).Value;
								int iImportResolution = Int32.Parse(sImportResolution );
								lviImport.BackColor = ( iExistingResolution < iImportResolution ) ? WishColor :
																									ExistingColor;
							}
							else lviImport.BackColor = ExistingColor;
						}
						else lviImport.BackColor = ExistingColor;
					}
					else lviImport.BackColor = ExistingColor;
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
					if ( cbGetHigherRes.Checked ) {
						Match mtExistingResolution = Regex.Match( lviExisting.ToolTipText, @"Video:  \d+" );
						if ( mtExistingResolution.Success ) {
							Match mtImportResolution = Regex.Match( lviImport.ToolTipText, @"Video:  \d+" );
							if ( mtImportResolution.Success ) {
								string sExistingResolution = Regex.Match( mtExistingResolution.Value, @"\d+" ).Value;
								int iExistingResolution = Int32.Parse( sExistingResolution );
								string sImportResolution = Regex.Match( mtImportResolution.Value, @"\d+" ).Value;
								int iImportResolution = Int32.Parse( sImportResolution );
								lviImport.BackColor = ( iExistingResolution < iImportResolution ) ? WishColor :
																									ExistingColor;
							}
							else lviImport.BackColor = ExistingColor;
						}
						else lviImport.BackColor = ExistingColor;
					}
					else lviImport.BackColor = ExistingColor;
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
				}
			}
			else if ( lviImport != null ) {
				lviImport.BackColor = NeutralColor;
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
		
		/// <summary>
		/// Make the target path, including file name, for file to be copied or moved.
		/// </summary>
		/// <param name="fiImportFile">The file to be copied or moved.</param>
		/// <returns>The path of the new file.</returns>
		string MakeTargetPath( FileInfo fiImportFile )
		{
			string strTargetPath = "";

			if ( !cbKeepFolders.Checked ) { // move all relevant file into the same folder
				strTargetPath = tbTargetFolder.Text;
			}
			else { // keep the folder structure as it is in the source folder
				string sSubPath = fiImportFile.DirectoryName.Substring( fiImportFile.DirectoryName.IndexOf( '\\' )+1 );
				strTargetPath = Path.Combine( tbTargetFolder.Text, sSubPath );
			}

			if( !Directory.Exists( strTargetPath ) ) {
				Directory.CreateDirectory( strTargetPath );
			}

			return strTargetPath;
		}
		
		/// <summary>
		/// Generates the lists to be handed over to TeraCopy and updated the colocrs of the lists.
		/// </summary>
		void ProcessImport()
		{
			if(!Directory.Exists(tbImportFolder.Text)) {
				ShowInfo("Select a folder with the " + strCollectionType + " to import...");
				return;
			}
			if(!Directory.Exists(tbTargetFolder.Text)) {
				ShowInfo("Select a target folder...");
				return;
			}
			
			SetStatus("Start processing...");
			string sSourceListFileName = "";
			StreamWriter swSourceListFile = null;
			string sOldTargetPath = "";
			string sTargetPath = "";
			string sSourceFile;
			bool bSourceListOpen = false;
			
			// tag the items to be copied or moved
			foreach ( ListViewItem lviThis in lvImport.Items ) {
				lviThis.Tag = lviThis.BackColor == WishColor;
			}

			var diImportFolder = new DirectoryInfo( tbImportFolder.Text );
			SearchOption soMovieFileMerger = SearchOption.AllDirectories;

			foreach( FileInfo fiImportFile in diImportFolder.GetFiles( "*", soMovieFileMerger ) ) {
				string strImportName = fiImportFile.Name;
				// ignore not relevant files
				if ( !rgxVideoExtensions.IsMatch( fiImportFile.Extension.ToLower() ) &&
				    !rgxAddonExtensions.IsMatch( fiImportFile.Extension.ToLower() ) ) {
					continue;
				}
				
				// cut the file extension, to reduce list entries to only one per item
				if ( strImportName.LastIndexOf( '.' ) != -1 ) {
					strImportName = strImportName.Substring( 0, strImportName.LastIndexOf( '.' ) );
				}
				
				strImportName = CleanName( RemoveEpisodeInfo( strImportName ) );
				ListViewItem lviImport = FindItem( lvImport, strImportName );
				if ( lviImport != null ) {
					if( (bool)lviImport.Tag == true ) {
						sTargetPath = MakeTargetPath( fiImportFile );
						sSourceFile = fiImportFile.FullName; //" \"" +  + "\" ";
						
						if ( sOldTargetPath != sTargetPath ) {
							if( bSourceListOpen ) {
								swSourceListFile.Close( );
								bSourceListOpen = false;
								DoTeraCopy( sSourceListFileName, sOldTargetPath );
							}
							sOldTargetPath = sTargetPath;
						}
						if ( !bSourceListOpen ) {
							sSourceListFileName = "TeraCopy List - " + tbNickName.Text + " " +
							                      StandardizeDate(DateTime.Now) +  " " +
							                      StandardizeTime(DateTime.Now) + " " +
							                      sTargetPath.Replace( "\\", " - " ).Replace( ':', ' ' ) +
							                      ".tcl";
							sSourceListFileName = Path.Combine( strTeraCopyListsPath, sSourceListFileName );
							swSourceListFile = new StreamWriter( sSourceListFileName );
							bSourceListOpen = true;
							sOldTargetPath = sTargetPath;
						}

						if ( rbCopy.Checked ) {
							LogMessage( "Add to Source List", Color.Blue, "Copy " + 
							            sSourceFile + " -> " + sTargetPath );
						}
						else {
							LogMessage( "Add to Source List", Color.Blue,  "Move " + 
							            sSourceFile + " -> " + sTargetPath );
						}
						
						swSourceListFile.WriteLine( sSourceFile );
						AddItemToListView( lvExisting, lviImport );
					}
				}
			}
			if ( bSourceListOpen ) {
				swSourceListFile.Close( );
				DoTeraCopy( sSourceListFileName, sOldTargetPath );
			}
			ShowInfo( "Finished processing..." );
			ClearStatus( );
		}

		/// <summary>
		/// Does the final handover to TeraCopy.
		/// </summary>
		/// <param name="sSourceListFile">The file containing the sources files to be copied or moved.</param>
		/// <param name="sTargetPath">The path to where the source files should be copied or moved. </param>
		void DoTeraCopy( string sSourceListFile, string sTargetPath )
		{
			string sTeraCopy = tbTeraCopyPath.Text;
			const string sOptions = " /SkipAll /Close ";
			
			try {
				if (rbCopy.Checked) {
					System.Diagnostics.Process.Start( sTeraCopy, "Copy *\"" + 
					                                  sSourceListFile + "\" \"" + sTargetPath + "\" " + sOptions );
					LogMessage( "Add Source List", Color.Purple,  "TeraCopy " + 
					            sSourceListFile + " -> " + sTargetPath + sOptions );
				}
				else {
					System.Diagnostics.Process.Start( sTeraCopy, "Move *\"" + 
					                                  sSourceListFile + "\" \"" + sTargetPath + "\" "  + sOptions );
					LogMessage( "Add Source List", Color.Purple,  "TeraMove " + 
					            sSourceListFile + " -> " + sTargetPath + sOptions );
				}
				System.Threading.Thread.Sleep( 1000 );
			} catch ( IOException e ) {
				ShowInfo( e.Message );
			}
		}

		/// <summary>
		/// Searches a list view for an item with a specific text.  
		/// </summary>
		/// <param name="lvListView">The list view to be searched.</param>
		/// <param name="strText">The text to search for.</param>
		/// <returns>The found list item, otherwise null if there are no items in the view</returns>
		ListViewItem FindItem( ListView lvListView, string strText )
		{
			return ( lvListView.Items.Count < 1 ) ? null : 
				                                    lvListView.FindItemWithText( strText, false, 0, false );
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
		/// Plays the video of the item dropped on the Play droparea with the default system player.
		/// The file to be played has to be located in the Import folder.
		/// </summary>
		void Play( )
		{
			if( !Directory.Exists( tbImportFolder.Text ) ) {
				ShowInfo( "Select a folder with the " + strCollectionType + " to import..." );
				return;
			}

			var diImportFolder = new DirectoryInfo( tbImportFolder.Text );
			SearchOption soMovieFileMerger = SearchOption.AllDirectories;

			foreach( FileInfo fiImportFile in diImportFolder.GetFiles( "*", soMovieFileMerger ) ) {
				if ( !rgxVideoExtensions.IsMatch( fiImportFile.Extension.ToLower() ) ) {
					continue;
				}
				
				string strImportName = fiImportFile.Name;
				if ( fiImportFile.Name.LastIndexOf( '.' ) != -1 ) {
					strImportName = strImportName.Substring( 0, fiImportFile.Name.LastIndexOf( '.' ) );
				}
				strImportName = CleanName( strImportName );
				ListViewItem lviImport = FindItem( lvImport, strImportName );
				if ( lviImport != null ) {
					if( lviImport.Selected ) {
						SetStatus( "Playing " + fiImportFile.Name + "..." );
						try {
							System.Diagnostics.Process.Start( fiImportFile.FullName );
						}
						catch ( Exception e ) { 
							ShowInfo( e.Message ); 
						}
					}
				}
				ClearStatus( );
			}
		}
		
		/// <summary>
		/// Gets the media information of the item dropped on the MediaInfo droparea with MediaInfo.
		/// The file to be analysed has to be located in the Import folder.
		/// </summary>
		void GetMediaInfo( )
		{
			if( !Directory.Exists( tbImportFolder.Text ) ) {
				ShowInfo( "Select a folder with the " + strCollectionType + " to import..." );
				return;
			}

			var diImportFolder = new DirectoryInfo( tbImportFolder.Text );
			SearchOption soMovieFileMerger = SearchOption.AllDirectories;

			foreach( FileInfo fiImportFile in diImportFolder.GetFiles( "*", soMovieFileMerger ) ) {
				if ( !rgxVideoExtensions.IsMatch( fiImportFile.Extension.ToLower() ) ) continue;
				
				string strImportName = fiImportFile.Name;
				if ( fiImportFile.Name.LastIndexOf( '.' ) != -1 ) {
					strImportName = strImportName.Substring( 0, fiImportFile.Name.LastIndexOf( '.' ) );
				}
				strImportName = CleanName( strImportName );
				ListViewItem lviImport = FindItem( lvImport, strImportName );

				if ( lviImport != null ) {
					if( lviImport.Selected ) {
						SetStatus( "Getting MediaInfo for " + fiImportFile.Name + "..." );
						try {
							System.Diagnostics.Process.Start( tbMediaInfoPath.Text, " \"" + 
							                                  fiImportFile.FullName + "\"" );
						}
						catch ( Exception e ) { 
							ShowInfo( e.Message ); 
						}
					}
				}
				ClearStatus( );
			}
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
				ColorAll( lviItem.Text );
			}
			if ( rbSeries.Checked ) {
				if ( (string)lvThis.Tag == "Garbage" ) {
					ColorExistingAndUp( );
				}
				if ( (string)lvThis.Tag == "Existing" ) {
					ColorWishAndUp( );
				}
				if ( (string)lvThis.Tag == "Wish" ) {
					ColorImport( );
				}
			}
		}
		
		/// <summary>
		/// Aks the user if changed lists should be save and if so save them.
		/// </summary>
		/// <param name="lvListView">The list view to save if it has changed.</param>
		void SaveChangedListView( ListView lvListView )
		{
			string strName = lvListView.Tag + " " +  strCollectionType;
			
			if ( ( lvListView.Tag.ToString() == "Existing" && bExistingChanged ) ||
			     ( lvListView.Tag.ToString() == "Wish" && bWishChanged ) ||
			     ( lvListView.Tag.ToString() == "Garbage" && bGarbageChanged )) {
				if ( ShowYesNoQuestion( "Save " + strName + "?" ) == DialogResult.Yes ) {
					SerializeListView( lvListView, Path.Combine( strPrivatePath, strName + ".slv" ) );
				}
			}
		}

		/// <summary>
		/// The collection type has been changed.  
		/// Save changed list and load the new ones.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void RbProjectTypeClick( object sender, EventArgs e )
		{
			var rbRadioButton = (RadioButton)sender;

			if ( rbRadioButton.Checked ) {
				strCollectionType = rbRadioButton.Tag.ToString( );
				lvImport.Items.Clear( );
				InitListViewFromFile( lvGarbage );
				InitListViewFromFile( lvExisting );
				InitListViewFromFile( lvWish );
			} else {
				SaveChangedListView( lvGarbage );
				SaveChangedListView( lvExisting );
				SaveChangedListView( lvWish );
			}
		}
		
		/// <summary>
		/// The form is closing. 
		/// Save changed lists and the settings.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void MfFormClosing( object sender, FormClosingEventArgs e )
		{
			SaveChangedListView( lvExisting );
			SaveChangedListView( lvGarbage );
			SaveChangedListView( lvWish );
			SaveXmlSettings( );
		}
		
		/// <summary>
		/// The mose entered a list view.  
		/// Make the list view acitve, so that the scrolling works.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void LvMouseEnter( object sender, EventArgs e )
		{
			( (ListView)sender ).Select( );
		}
		
		/// <summary>
		/// The mouse entered a rich text box.  
		/// Put it in focus, so that the scrolling works.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void RtbMouseEnter( object sender, System.EventArgs e )
		{
			( (RichTextBox)sender ).Focus( );
		}
		
		/// <summary>
		/// A link in a richtext box has been clicked.  Start the link with the default browser.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void LinkClicked( object sender, LinkClickedEventArgs e )
		{
			System.Diagnostics.Process.Start( e.LinkText );
		}
		
		/// <summary>
		/// Removes the episode info to get the series name.
		/// </summary>
		/// <param name="strCleanName">The episode name.</param>
		/// <returns>The series name.</returns>
		string RemoveEpisodeInfo( string strCleanName )
		{
			return ( rbSeries.Checked ) ? Regex.Replace( strCleanName, @" S\d+e\d+$", "" ) : 
			                              strCleanName;
		}

		/// <summary>
		/// Searches on IMDb for the selected items of the list view, 
		/// which has been droped on the Search IMDb droparea.
		/// </summary>
		/// <param name="lvListView">The list view with the selected items.</param>
		void SearchIMDb( ListView lvListView )
		{
			foreach ( ListViewItem lviItem in lvListView.SelectedItems ) {
				string strCleanName = RemoveEpisodeInfo( lviItem.Text );
				System.Diagnostics.Process.Start( "http://www.imdb.com/find?q=" + 
				                                  strCleanName.Replace( ' ', '+' ) + strIMDbSearchType );
				LogMessage( "Info", Color.Blue, "Searching IMDb for " + strCleanName );
			}
		}

		/// <summary>
		/// Searches on Torrentz.eu for the selected items of the list view, 
		/// which has been droped on the Search Torrentz droparea.
		/// </summary>
		/// <param name="lvListView">The list view with the selected items.</param>
		void SearchTorrenz( ListView lvListView )
		{
			foreach ( ListViewItem lviItem in lvListView.SelectedItems ) {
				string strCleanName = RemoveEpisodeInfo( lviItem.Text );
				System.Diagnostics.Process.Start( "http://torrentz.eu/search?f=" + 
				                                  strCleanName.Replace( ' ', '+' ) );
				LogMessage( "Info", Color.Blue, "Searching Torrenz for " + strCleanName );
			}
		}

		/// <summary>
		/// A list view item has been double clicked.  Seach IMDb.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void LvDoubleClick( object sender, EventArgs e )
		{
			SearchIMDb( (ListView)sender );
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
				ListViewItem lviClosest = lvListView.Items[lvListView.Items.Count-1];
				int iLength = 1;
				
				while ( (iLength < strItemName.Length) && 
				        (lviItem = lvListView.FindItemWithText( strItemName.Substring( 0, iLength ) ) ) != null ) {
					lviClosest = lviItem;
					iLength++;
				}
				lviClosest.EnsureVisible( );
				lviClosest.Focused = true;
			}
		}
		
		/// <summary>
		/// Checks if one item only is selected in the focused list view.
		/// </summary>
		/// <returns>True, if only one item is the focused list is selected, otherwise false.</returns>
		bool OneItemSelected( )
		{
			if( lvGarbage.Focused ) {
				return lvGarbage.SelectedItems.Count<2;
			}
			if( lvExisting.Focused ) {
				return lvExisting.SelectedItems.Count<2;
			}
			if( lvWish.Focused ) {
				return lvWish.SelectedItems.Count<2;
			}
			if( lvImport.Focused ) {
				return lvImport.SelectedItems.Count<2;
			}
			return false;
		}
		
		/// <summary>
		/// Scolls all lists to the closed match of the last selected item.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		/// Saves a list view to a file, which can bge read by MFM.
		/// </summary>
		/// <param name="lvListView">The list view to be saved.</param>
		/// <param name="strFileName">The name of the target file.</param>
		void SerializeListView( ListView lvListView, string strFileName )
		{
			SetStatus( "Serializing " + lvListView.Tag + " " + strCollectionType + "..." );
			var fsListView = new FileStream( strFileName, FileMode.Create );
			var bf = new BinaryFormatter( );
			var strcolItems = new StringCollection( );
			
			foreach ( ListViewItem lviItem in lvListView.Items ) {
				strcolItems.Add( lviItem.Text + "\t" + lviItem.ToolTipText );
			}
			try {
				bf.Serialize( fsListView, strcolItems );
			} catch( System.Runtime.Serialization.SerializationException e ) {
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
			var strcolStr = new StringCollection( );
			SetStatus( "Adding " + lvListView.Tag + " " + strCollectionType + "..." );
			try {
				var fsItems = new FileStream( strFileName, FileMode.Open );
				var bf = new BinaryFormatter( );
				strcolStr = (StringCollection)bf.Deserialize( fsItems );
				fsItems.Close( );
			} catch ( IOException e ) { 
				ShowInfo( e.Message ); 
			}
			
			lvListView.BeginUpdate( );
			lvListView.Items.Clear( );
			lvListView.Sorting = SortOrder.None;
			foreach( string strListViewItemName in strcolStr ) {
				string[] saParts = strListViewItemName.Split( '\t' );
				var lviThis = new ListViewItem( saParts[0] );
				
				if ( saParts.Length > 1 ) {
					lviThis.ToolTipText = saParts[1];
				}
				lvListView.Items.Add( lviThis );
				ColorAll( saParts[0] );
			}
			lvListView.Sorting = SortOrder.Ascending;
			SetStatus( "Added " + lvListView.Items.Count + " items." );
			lvListView.EndUpdate( );
			ClearStatus( );
		}

		/// <summary>
		/// Extracts full information of a file with MediaInfo, but returns only selected infomration. 
		/// </summary>
		/// <param name="fiFile">The file to analyse.</param>
		/// <param name="lvThis">The list view in question.</param>
		/// <param name="lviThis">the list view item in question.</param>
		/// <returns>Selected media information.</returns>
		void MakeToolTip( FileInfo fiFile, ListView lvThis, ListViewItem lviThis )
		{
			bool bItemMissing = FindItem( lvThis, lviThis.Text ) == null;
			bool bHasMediaInfo = lviThis.ToolTipText.Contains ( "Video: " );
			string sBasicItemInfo = fiFile.Name + "\n" +
			                    "[" + tbNickName.Text + " " + StandardizeDate( DateTime.Today ) + "]  " ;
			                    
			
			string sFileInfo = fiFile.DirectoryName + "\n" + 
				               fiFile.Length/1024/1024 + " MiB,  " +
				               fiFile.Extension.ToUpper( ).Substring( 1 ) +
							   ", Last Written " + StandardizeDate( fiFile.LastWriteTime );
			bool bDifferentFile = !lviThis.ToolTipText.Contains( sFileInfo );
			bool bFullDetails = ( bItemMissing || !bHasMediaInfo || bDifferentFile) && cbMediaInfo.Checked;

			string sMediaInfo = "";
			if ( bFullDetails ) {
				SetStatus ( "Getting MediaInfo for " + fiFile.Name );
				miThis.Open( fiFile.FullName );
				miThis.Option( "Inform", "General;%Duration/String%,  %Format%" ); // file size
				sMediaInfo += "\n" + miThis.Inform( );
				miThis.Option( "Inform", "Video;Video:  %Width% x%Height% (%DisplayAspectRatio/String%) at %FrameRate/String%,  %BitRate/String%" );
				sMediaInfo += "\n\n" + miThis.Inform( );
				miThis.Option( "Inform", "Audio;Audio:  %Channel(s)/String%  %Language/String%,  %SamplingRate/String%  %Format%\n" );
				sMediaInfo += "\n" + miThis.Inform( ).Replace( "Audio: ", "\nAudio: " ).Replace( "Audio:  ,", "Audio:" );
				miThis.Close( );
			}
			
			if ( bFullDetails || bItemMissing || !bHasMediaInfo ) lviThis.ToolTipText = sBasicItemInfo + sFileInfo + sMediaInfo;
			else if ( bDifferentFile ) { 
				if ( !bHasMediaInfo || sMediaInfo != "" ) lviThis.ToolTipText = sBasicItemInfo + sFileInfo + sMediaInfo;
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
					ColorAll( lviThis.Text );
					SetListViewChanged( lvThis, true );
				}
			}
			lvThis.EndUpdate( );
		}
		
		/******************
		 * User Interface *
		 ******************/
		
		/// <summary>
		/// The MFM windos has ben shown.  
		/// Initialize all list views.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void MfShown( object sender, EventArgs e )
		{
			InitListViewFromFile( lvGarbage );
			InitListViewFromFile( lvExisting );
			InitListViewFromFile( lvWish );
		}

		/// <summary>
		/// An item has been draged from a list view.  
		/// Set the drag source and effects.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void LvItemDrag( object sender, ItemDragEventArgs e )
		{
			lvDragSource = (ListView)sender;
			lvDragSource.DoDragDrop( lvDragSource.SelectedItems, DragDropEffects.Copy );
		}
		
		/// <summary>
		/// Somehting has been draged over a list view.  
		/// Check it and set the cursor accordingly.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void LvDragDrop( object sender, DragEventArgs e )
		{
			var lvThis = (ListView)sender;
			
			if( e.AllowedEffect == DragDropEffects.None) {
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			
			// from another list view
			if( e.Data.GetDataPresent( typeof( ListView.SelectedListViewItemCollection ) ) ) {
				foreach ( ListViewItem lviThis in (ListView.SelectedListViewItemCollection)e.Data.GetData( typeof( ListView.SelectedListViewItemCollection ) ) ) {
					if ( rbSeries.Checked &&
					     ( (string)lvThis.Tag == "Garbage" ||
					       (string)lvThis.Tag == "Wish" ) ) {
						var lviToAdd = new ListViewItem( RemoveEpisodeInfo( lviThis.Text ) );
						AddItemToListView( lvThis, lviToAdd );
					} else {
						AddItemToListView( lvThis, lviThis );
					}
				}
				if ( rbSeries.Checked ) {
					if ( (string)lvThis.Tag == "Garbage" ) {
						ColorExistingAndUp( );
					}
					if ( (string)lvThis.Tag == "Wish" ) {
						ColorWishAndUp( );
					}
				}
			}
			// from folders or files
			if ( e.Data.GetDataPresent( DataFormats.FileDrop ) ) {
				int iFolderCount = 0;
				foreach ( string strPath in (string[])e.Data.GetData( DataFormats.FileDrop ) ) {
					FileAttributes attr = File.GetAttributes( strPath );
					bool isFolder = ( attr & FileAttributes.Directory ) == FileAttributes.Directory;
					// from folder
					if ( isFolder ) {
						if ( (string)lvThis.Tag == "Import" ) {
							iFolderCount++;
							tbImportFolder.Text = ( iFolderCount == 1 ) ? strPath : 
							                                              Path.GetDirectoryName( strPath );
						}
						AddFolderToListView( lvThis, strPath );
					}
					// from video file
					else if ( rgxVideoExtensions.IsMatch (Path.GetExtension( strPath ).ToLower() ) ) {
						string strJustName = Path.GetFileNameWithoutExtension( strPath );
						if ( (string)lvThis.Tag == "Import" ) {
							tbImportFolder.Text = Path.GetDirectoryName( strPath );
						}
						var fiFile = new FileInfo( strPath );
						var lviThis = new ListViewItem(CleanName(strJustName));
						lviThis = AddItemToListView( lvThis, lviThis );
						MakeToolTip( fiFile, lvThis, lviThis );
						if ( cbGetHigherRes.Checked ) ColorAll( lviThis.Text );  // color again to get info from tooltip
					}
					// from txt file
					else if ( Path.GetExtension( strPath ).ToLower() == ".txt" ) {
						AddTxtToListView( lvThis, strPath );
					}
					// from csv file
					else if ( Path.GetExtension( strPath ).ToLower() == ".csv" ) {
						AddCsvToListView( lvThis, strPath);
					}
					// from listview stream
					else if ( Path.GetExtension( strPath ).ToLower() == ".slv" ) {
						DeserializeListView( lvThis, strPath );
					}
				}
			}
			Cursor.Current = Cursors.Default;
		}

		/// <summary>
		/// The progress bar has been clicked and the processing should start.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void PbProcessClick( object sender, EventArgs e )
		{
		}

		/// <summary>
		/// Update the Garbvage, Existing, Wish and Import counters from time to time.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void TmrUpdateCountersTick( object sender, EventArgs e )
		{
			lvExisting.Columns[0].Text = lvExisting.Items.Count + " Existing " + strCollectionType;
			lvGarbage.Columns[0].Text = lvGarbage.Items.Count + " Garbage " + strCollectionType;
			lvImport.Columns[0].Text = lvImport.Items.Count + " Import " + strCollectionType;
			lvWish.Columns[0].Text = lvWish.Items.Count + " Wish " + strCollectionType;
		}

		/// <summary>
		/// Resize the columns if the spliter has been moved.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ScVerticalSplitterMoved( object sender, SplitterEventArgs e )
		{
			SetColumnWidth( );
		}

		/// <summary>
		/// The settings tab has been left.  
		/// Save the settings.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void TpSettingsLeave( object sender, EventArgs e )
		{
			SaveXmlSettings( );
		}
		
		/// <summary>
		/// Something has been draged over a droparea.  
		/// Change the cursor accordingly.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnDragOver(object sender, DragEventArgs e)
		{
			if ( e.Data.GetDataPresent( typeof( ListView.SelectedListViewItemCollection ) ) ) {
				e.Effect = e.AllowedEffect;
			}
		}
		
		/// <summary>
		/// Items have been dropped on the Erase Selected drop area. 
		/// Erase the selected items from the list view.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnEraseSelectedDragDrop( object sender, DragEventArgs e )
		{
			EraseSelected( lvDragSource );
		}
		
		/// <summary>
		/// An item has been droped on the Erase Color drop area.  
		/// Erase all items with the same color from the list view.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnPlayDragDrop( object sender, DragEventArgs e )
		{
			Play( );
		}
		
		/// <summary>
		/// Items have been droped on the Seach IMDb drop area.
		/// Open the IMDb searches for them in the default browser.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnSearchIMDbDragDrop( object sender, DragEventArgs e )
		{
			SearchIMDb( lvDragSource );
		}
		
		/// <summary>
		/// Items have been dropped on the Seach Torrentz droparea.
		/// Open the To4rentz.eu searches for them in the default browser. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnSearchTorrentzDragDrop( object sender, DragEventArgs e) 
		{
			SearchTorrenz( lvDragSource );
		}
		
		/// <summary>
		/// A list view has been drop on the Export Lists droparea.
		/// Save the list view to a CSV file.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnExportListDragDrop( object sender, DragEventArgs e )
		{
			sfdMovieFileMerger.FileName =
				tbNickName.Text + " " +
				(string)lvDragSource.Tag + " " +
				strCollectionType + " " +
				StandardizeDate( DateTime.Today ) +
				".csv";
			if ( sfdMovieFileMerger.ShowDialog( ) == DialogResult.OK ) {
				sfdMovieFileMerger.InitialDirectory = "";  // take the same folder next time
				SaveListViewToCsvFile( lvDragSource, sfdMovieFileMerger.FileName );
			}
		}
		
		/// <summary>
		/// A folder has been dropped on the Target Folder droparea.
		/// Brows the folder and add the files to the Existing list view.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void TbTargetFolderDragDrop( object sender, DragEventArgs e )
		{
			if ( e.AllowedEffect == DragDropEffects.None ) {
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			if ( e.Data.GetDataPresent( DataFormats.FileDrop ) ) {
				string strPath = ( (string[])e.Data.GetData( DataFormats.FileDrop ) )[0];
				FileAttributes attr = File.GetAttributes( strPath );
				bool isFolder = ( attr & FileAttributes.Directory ) == FileAttributes.Directory;

				if ( isFolder ) {
					tbTargetFolder.Text = strPath;
					AddFolderToListView( lvExisting, tbTargetFolder.Text );
				}
			}
			Cursor.Current = Cursors.Default;
		}
		
		/// <summary>
		/// A folder has been dropped on the Import Folder droparea.
		/// Brows the folder and add the files to the Import list view.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void TbImportFolderDragDrop( object sender, DragEventArgs e )
		{
			if ( e.AllowedEffect == DragDropEffects.None ) {
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			if ( e.Data.GetDataPresent( DataFormats.FileDrop) ) {
				string strPath = ( (string[])e.Data.GetData( DataFormats.FileDrop ) )[0];
				FileAttributes attr = File.GetAttributes( strPath );
				bool isFolder = ( attr & FileAttributes.Directory ) == FileAttributes.Directory;

				if ( isFolder ) {
					lvImport.Items.Clear( );
					tbImportFolder.Text = strPath;
					AddFolderToListView( lvImport, tbImportFolder.Text );
				}
			}
			Cursor.Current = Cursors.Default;
		}
		
		/// <summary>
		/// Something has been draged over a text box.
		/// Check what it is and set the allowed effect accordingly.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void TbDragOver( object sender, DragEventArgs e )
		{
			if ( e.Data.GetDataPresent( DataFormats.FileDrop ) ) {
				e.Effect = e.AllowedEffect;
			}
		}
		
		/// <summary>
		/// A key has been pressed on a list view.
		/// Check which key and take the according actions.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void lvKeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Delete ) {
				EraseSelected( (ListView)sender );
			}
		}

		/// <summary>
		/// An item has been dropped on the Media Info drop area.
		/// Get the detailed madia info for it.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnMediaInfoDragDrop( object sender, DragEventArgs e )
		{
			GetMediaInfo( );
		}
		
		/// <summary>
		/// A list view has been dragged over the Tool Tip Regex text box.
		/// Chec it and set the drop effects accordingly.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void TbToolTipRegexDragOver(object sender, DragEventArgs e)
		{
			if ( e.Data.GetDataPresent( typeof( ListView.SelectedListViewItemCollection ) ) ) {
				e.Effect = e.AllowedEffect;
			}
		}
		
		/// <summary>
		/// A list view has been dropped on the Tool Tip Regex text box.
		/// Select items in the list view according to the regular expression.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void TbToolTipRegexDragDrop( object sender, DragEventArgs e )
		{
			var rgxToolTip = new Regex( tbToolTipRegex.Text );
			
			if ( e.AllowedEffect == DragDropEffects.None )  {
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			// from a list view
			if ( e.Data.GetDataPresent( typeof( ListView.SelectedListViewItemCollection ) ) ) {
				foreach ( ListViewItem lviThis in lvDragSource.Items ) {
					lviThis.Selected = rgxToolTip.IsMatch( lviThis.ToolTipText );
				}
			}
			Cursor.Current = Cursors.Default;
		}
		void LlMovieFileMergerOrgClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start( "www.Movie-File-Merger.org" );
		}

		void CobToolTipRegexSelectedIndexChanged(object sender, EventArgs e)
		{
			switch ( cobToolTipRegex.Text ) {
				case "Square Format": tbToolTipRegex.Text = @"\(((4:3)|(5:4)|(3:2)|(1\.[0-5]\d+))\)"; break;
				case "Wide Screen": tbToolTipRegex.Text = @"\((16:9)|(1\.85:1)|(1\.[6-9]\d+)|(2\.[0-2]\d+))\)"; break;
				case "Cinema Scope": tbToolTipRegex.Text = @"\(([23]\.*\d*:1)|(2\.[3-9]\d+)|(3\.\d+))\)"; break;
				case "Low Resolution": tbToolTipRegex.Text = @"Video:  [1-6]\d{2} x"; break;
				case "Medium Resolution": tbToolTipRegex.Text = @"Video:  [7-9]\d{2} x"; break;
				case "High Resolution": tbToolTipRegex.Text = @"Video:  1\d{3} x"; break;
				case "Folder Name": tbToolTipRegex.Text = @"\\YourFolderName\\"; break;
				case "After 2009": tbToolTipRegex.Text = @"201[0-9]"; break;
				default: tbToolTipRegex.Text = @""; break;
			}
		}
		
		void CobToolTipRegexDisplayMemberChanged(object sender, EventArgs e)
		{
			SetStatus( cobToolTipRegex.SelectedText );
		}
		
		void StatusStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
	
		}
		
		void BtnStartClick(object sender, EventArgs e)
		{
			SetStatus ("Started doing shit...");
			ProcessImport();
		}
		void BtnCheckNowClick(object sender, EventArgs e)
		{
			CheckLatestVersion();
		}
	}
}
