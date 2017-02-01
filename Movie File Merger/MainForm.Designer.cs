/*
 * Created by Modi
 * Date: 2012-04-09
 * Time: 3:28 PM
 */
namespace Movie_File_Merger
{
	partial class MFMForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MFMForm));
            this.fbdMovieFileMerger = new System.Windows.Forms.FolderBrowserDialog();
            this.ilMovieFileMerger = new System.Windows.Forms.ImageList(this.components);
            this.tmrUpdateCounters = new System.Windows.Forms.Timer(this.components);
            this.sfdMovieFileMerger = new System.Windows.Forms.SaveFileDialog();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tcMovieFileMerger = new System.Windows.Forms.TabControl();
            this.tpSeparateLists = new System.Windows.Forms.TabPage();
            this.cobDownloadCriteria = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnJustScanIt = new System.Windows.Forms.Button();
            this.btnJustRipIt = new System.Windows.Forms.Button();
            this.cobCriteria = new System.Windows.Forms.ComboBox();
            this.btnAddToWish = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnExportList = new System.Windows.Forms.Button();
            this.btnEraseColor = new System.Windows.Forms.Button();
            this.btnSearchDownload = new System.Windows.Forms.Button();
            this.btnEraseSelected = new System.Windows.Forms.Button();
            this.btnSearchInfo = new System.Windows.Forms.Button();
            this.gbTypeSelection = new System.Windows.Forms.GroupBox();
            this.rbMiscellaneous = new System.Windows.Forms.RadioButton();
            this.rbAdults = new System.Windows.Forms.RadioButton();
            this.rbClips = new System.Windows.Forms.RadioButton();
            this.rbSeries = new System.Windows.Forms.RadioButton();
            this.rbDocumentaries = new System.Windows.Forms.RadioButton();
            this.rbMovies = new System.Windows.Forms.RadioButton();
            this.gbProcessImport = new System.Windows.Forms.GroupBox();
            this.cobMinimumResolution = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbGetHigherRes = new System.Windows.Forms.CheckBox();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.scVertical = new System.Windows.Forms.SplitContainer();
            this.lvExisting = new System.Windows.Forms.ListView();
            this.chNameExisting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scVerticalRight = new System.Windows.Forms.SplitContainer();
            this.scHorizontal = new System.Windows.Forms.SplitContainer();
            this.lvWish = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGarbage = new System.Windows.Forms.ListView();
            this.chNameGarbage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvImport = new System.Windows.Forms.ListView();
            this.chNameImport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cobSearchDownload = new System.Windows.Forms.ComboBox();
            this.cobSearchInfo = new System.Windows.Forms.ComboBox();
            this.tpMaintenance = new System.Windows.Forms.TabPage();
            this.pbMFM = new System.Windows.Forms.PictureBox();
            this.btnPlayMaintenance = new System.Windows.Forms.Button();
            this.btnExportListMaintenance = new System.Windows.Forms.Button();
            this.btnSearchDownloadMaintenance = new System.Windows.Forms.Button();
            this.btnSearchInfoMaintenance = new System.Windows.Forms.Button();
            this.cobSearchDownloadMaintenance = new System.Windows.Forms.ComboBox();
            this.cobSearchInfoMaintenance = new System.Windows.Forms.ComboBox();
            this.pbMaintenanceUserManual = new System.Windows.Forms.PictureBox();
            this.btnGoodEpisode = new System.Windows.Forms.Button();
            this.btnGoodDocu = new System.Windows.Forms.Button();
            this.btnGoodMovie = new System.Windows.Forms.Button();
            this.btnUnrelatedFile = new System.Windows.Forms.Button();
            this.btnBadEpisode = new System.Windows.Forms.Button();
            this.btnBadName = new System.Windows.Forms.Button();
            this.btnBadDocu = new System.Windows.Forms.Button();
            this.btnBadMovie = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.scMaintenance = new System.Windows.Forms.SplitContainer();
            this.lvMaintenance = new System.Windows.Forms.ListView();
            this.chNameMaintenance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtbMaintenance = new System.Windows.Forms.RichTextBox();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.pbLogUserManual = new System.Windows.Forms.PictureBox();
            this.pbLogHowTo = new System.Windows.Forms.PictureBox();
            this.pbLogBanner = new System.Windows.Forms.PictureBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.cobDoubleClickDefault = new System.Windows.Forms.ComboBox();
            this.pbSeetingsHowTo = new System.Windows.Forms.PictureBox();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.pbSettingsUserManual = new System.Windows.Forms.PictureBox();
            this.pbSettingsBanner = new System.Windows.Forms.PictureBox();
            this.rtbSettings = new System.Windows.Forms.RichTextBox();
            this.gbSettingsNameUnification = new System.Windows.Forms.GroupBox();
            this.lblBadMovieNameRegex = new System.Windows.Forms.Label();
            this.tbBadMovieNameRegex = new System.Windows.Forms.TextBox();
            this.lblGoodMovieNameRegex = new System.Windows.Forms.Label();
            this.tbGoodMovieNameRegex = new System.Windows.Forms.TextBox();
            this.lblBadEpisodeNameRegex = new System.Windows.Forms.Label();
            this.tbBadEpisodeNameRegex = new System.Windows.Forms.TextBox();
            this.lblGoodEpisodeNameRegex = new System.Windows.Forms.Label();
            this.tbGoodEpisodeNameRegex = new System.Windows.Forms.TextBox();
            this.lblBadDocuNameRegex = new System.Windows.Forms.Label();
            this.tbBadDocuNameRegex = new System.Windows.Forms.TextBox();
            this.lblGoodDocuNameRegex = new System.Windows.Forms.Label();
            this.tbGoodDocuNameRegex = new System.Windows.Forms.TextBox();
            this.lblToLowerRegex = new System.Windows.Forms.Label();
            this.tbToLowerRegex = new System.Windows.Forms.TextBox();
            this.lblOnlyCharacters = new System.Windows.Forms.Label();
            this.tbOnlyCharactersRegex = new System.Windows.Forms.TextBox();
            this.lblEpisodesId = new System.Windows.Forms.Label();
            this.tbEpisodesIdRegex = new System.Windows.Forms.TextBox();
            this.lblCutNameBeforeRegex = new System.Windows.Forms.Label();
            this.tbCutNameBeforeRegex = new System.Windows.Forms.TextBox();
            this.gbSettingsConsideredFiles = new System.Windows.Forms.GroupBox();
            this.lblAddonExtensions = new System.Windows.Forms.Label();
            this.tbAddonExtensionsRegex = new System.Windows.Forms.TextBox();
            this.lblMainExtensions = new System.Windows.Forms.Label();
            this.tbMainExtensionsRegex = new System.Windows.Forms.TextBox();
            this.tpHelp = new System.Windows.Forms.TabPage();
            this.pbInstructionsUserManual = new System.Windows.Forms.PictureBox();
            this.pbInstructionsHowTo = new System.Windows.Forms.PictureBox();
            this.pbInstructionsBanner = new System.Windows.Forms.PictureBox();
            this.rtbHelp = new System.Windows.Forms.RichTextBox();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.llDonateABeerOrTwo = new System.Windows.Forms.LinkLabel();
            this.llUserFeedbackForum = new System.Windows.Forms.LinkLabel();
            this.llGitHubSourceCode = new System.Windows.Forms.LinkLabel();
            this.pbAboutUserManual = new System.Windows.Forms.PictureBox();
            this.pbAboutHowTo = new System.Windows.Forms.PictureBox();
            this.lblLastChecked = new System.Windows.Forms.Label();
            this.cobCheckForUpdates = new System.Windows.Forms.ComboBox();
            this.btnCheckNow = new System.Windows.Forms.Button();
            this.pbAboutBanner = new System.Windows.Forms.PictureBox();
            this.lblCopyLeft = new System.Windows.Forms.Label();
            this.rtbCopyright = new System.Windows.Forms.RichTextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.llMovieFileMergerOrg = new System.Windows.Forms.LinkLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ssMFM = new System.Windows.Forms.StatusStrip();
            this.tsslMFM = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbMFM = new System.Windows.Forms.ToolStripProgressBar();
            this.ttMovieFileMerger = new System.Windows.Forms.ToolTip(this.components);
            this.ofdTeraCopy = new System.Windows.Forms.OpenFileDialog();
            this.tcMovieFileMerger.SuspendLayout();
            this.tpSeparateLists.SuspendLayout();
            this.gbTypeSelection.SuspendLayout();
            this.gbProcessImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scVertical)).BeginInit();
            this.scVertical.Panel1.SuspendLayout();
            this.scVertical.Panel2.SuspendLayout();
            this.scVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scVerticalRight)).BeginInit();
            this.scVerticalRight.Panel1.SuspendLayout();
            this.scVerticalRight.Panel2.SuspendLayout();
            this.scVerticalRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scHorizontal)).BeginInit();
            this.scHorizontal.Panel1.SuspendLayout();
            this.scHorizontal.Panel2.SuspendLayout();
            this.scHorizontal.SuspendLayout();
            this.tpMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMFM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaintenanceUserManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMaintenance)).BeginInit();
            this.scMaintenance.Panel1.SuspendLayout();
            this.scMaintenance.Panel2.SuspendLayout();
            this.scMaintenance.SuspendLayout();
            this.tpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogUserManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogHowTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogBanner)).BeginInit();
            this.tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeetingsHowTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsUserManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsBanner)).BeginInit();
            this.gbSettingsNameUnification.SuspendLayout();
            this.gbSettingsConsideredFiles.SuspendLayout();
            this.tpHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructionsUserManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructionsHowTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructionsBanner)).BeginInit();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutUserManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutHowTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutBanner)).BeginInit();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.ssMFM.SuspendLayout();
            this.SuspendLayout();
            // 
            // fbdMovieFileMerger
            // 
            this.fbdMovieFileMerger.ShowNewFolderButton = false;
            // 
            // ilMovieFileMerger
            // 
            this.ilMovieFileMerger.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMovieFileMerger.ImageStream")));
            this.ilMovieFileMerger.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMovieFileMerger.Images.SetKeyName(0, "Color.gif");
            this.ilMovieFileMerger.Images.SetKeyName(1, "Copy.gif");
            this.ilMovieFileMerger.Images.SetKeyName(2, "Erase.gif");
            this.ilMovieFileMerger.Images.SetKeyName(3, "Folder.gif");
            this.ilMovieFileMerger.Images.SetKeyName(4, "Log.gif");
            this.ilMovieFileMerger.Images.SetKeyName(5, "Move.gif");
            this.ilMovieFileMerger.Images.SetKeyName(6, "Save.gif");
            this.ilMovieFileMerger.Images.SetKeyName(7, "Settings.gif");
            this.ilMovieFileMerger.Images.SetKeyName(8, "About.gif");
            this.ilMovieFileMerger.Images.SetKeyName(9, "Documentaries.gif");
            this.ilMovieFileMerger.Images.SetKeyName(10, "Help.gif");
            this.ilMovieFileMerger.Images.SetKeyName(11, "Series.gif");
            this.ilMovieFileMerger.Images.SetKeyName(12, "Clips.gif");
            this.ilMovieFileMerger.Images.SetKeyName(13, "MediaInfo.gif");
            this.ilMovieFileMerger.Images.SetKeyName(14, "List.gif");
            this.ilMovieFileMerger.Images.SetKeyName(15, "Adult.gif");
            this.ilMovieFileMerger.Images.SetKeyName(16, "Miscellaneaous.gif");
            this.ilMovieFileMerger.Images.SetKeyName(17, "Movie.gif");
            this.ilMovieFileMerger.Images.SetKeyName(18, "Play.gif");
            this.ilMovieFileMerger.Images.SetKeyName(19, "Garbage.gif");
            this.ilMovieFileMerger.Images.SetKeyName(20, "Process.gif");
            this.ilMovieFileMerger.Images.SetKeyName(21, "Select.gif");
            this.ilMovieFileMerger.Images.SetKeyName(22, "Wish.png");
            this.ilMovieFileMerger.Images.SetKeyName(23, "Start.gif");
            this.ilMovieFileMerger.Images.SetKeyName(24, "Download.png");
            this.ilMovieFileMerger.Images.SetKeyName(25, "Edit.gif");
            this.ilMovieFileMerger.Images.SetKeyName(26, "Edit.png");
            // 
            // tmrUpdateCounters
            // 
            this.tmrUpdateCounters.Enabled = true;
            this.tmrUpdateCounters.Interval = 3000;
            this.tmrUpdateCounters.Tick += new System.EventHandler(this.TmrUpdateCountersTick);
            // 
            // sfdMovieFileMerger
            // 
            this.sfdMovieFileMerger.DefaultExt = "xml";
            this.sfdMovieFileMerger.Filter = "Extensible Markup Language files|*.xml|Tab Searated Value files|*.tsv|Comma Seara" +
    "ted Value files|*.csv";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(997, 587);
            // 
            // tcMovieFileMerger
            // 
            this.tcMovieFileMerger.Controls.Add(this.tpSeparateLists);
            this.tcMovieFileMerger.Controls.Add(this.tpMaintenance);
            this.tcMovieFileMerger.Controls.Add(this.tpLog);
            this.tcMovieFileMerger.Controls.Add(this.tpSettings);
            this.tcMovieFileMerger.Controls.Add(this.tpHelp);
            this.tcMovieFileMerger.Controls.Add(this.tpAbout);
            this.tcMovieFileMerger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMovieFileMerger.ImageList = this.ilMovieFileMerger;
            this.tcMovieFileMerger.Location = new System.Drawing.Point(0, 0);
            this.tcMovieFileMerger.Name = "tcMovieFileMerger";
            this.tcMovieFileMerger.Padding = new System.Drawing.Point(9, 6);
            this.tcMovieFileMerger.SelectedIndex = 0;
            this.tcMovieFileMerger.Size = new System.Drawing.Size(651, 375);
            this.tcMovieFileMerger.TabIndex = 0;
            this.tcMovieFileMerger.Tag = "Maintenance";
            // 
            // tpSeparateLists
            // 
            this.tpSeparateLists.BackColor = System.Drawing.SystemColors.Control;
            this.tpSeparateLists.Controls.Add(this.cobDownloadCriteria);
            this.tpSeparateLists.Controls.Add(this.btnPlay);
            this.tpSeparateLists.Controls.Add(this.btnEdit);
            this.tpSeparateLists.Controls.Add(this.btnJustScanIt);
            this.tpSeparateLists.Controls.Add(this.btnJustRipIt);
            this.tpSeparateLists.Controls.Add(this.cobCriteria);
            this.tpSeparateLists.Controls.Add(this.btnAddToWish);
            this.tpSeparateLists.Controls.Add(this.btnBin);
            this.tpSeparateLists.Controls.Add(this.btnSelect);
            this.tpSeparateLists.Controls.Add(this.btnExportList);
            this.tpSeparateLists.Controls.Add(this.btnEraseColor);
            this.tpSeparateLists.Controls.Add(this.btnSearchDownload);
            this.tpSeparateLists.Controls.Add(this.btnEraseSelected);
            this.tpSeparateLists.Controls.Add(this.btnSearchInfo);
            this.tpSeparateLists.Controls.Add(this.gbTypeSelection);
            this.tpSeparateLists.Controls.Add(this.gbProcessImport);
            this.tpSeparateLists.Controls.Add(this.scVertical);
            this.tpSeparateLists.Controls.Add(this.cobSearchDownload);
            this.tpSeparateLists.Controls.Add(this.cobSearchInfo);
            this.tpSeparateLists.ImageKey = "List.gif";
            this.tpSeparateLists.Location = new System.Drawing.Point(4, 29);
            this.tpSeparateLists.Name = "tpSeparateLists";
            this.tpSeparateLists.Padding = new System.Windows.Forms.Padding(3);
            this.tpSeparateLists.Size = new System.Drawing.Size(643, 342);
            this.tpSeparateLists.TabIndex = 0;
            this.tpSeparateLists.Text = "Lists";
            // 
            // cobDownloadCriteria
            // 
            this.cobDownloadCriteria.BackColor = System.Drawing.SystemColors.Control;
            this.cobDownloadCriteria.DropDownWidth = 130;
            this.cobDownloadCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobDownloadCriteria.FormattingEnabled = true;
            this.cobDownloadCriteria.Items.AddRange(new object[] {
            "4k",
            "2160p",
            "HDTV",
            "1080p",
            "720p",
            "x264",
            "Don\'t Care"});
            this.cobDownloadCriteria.Location = new System.Drawing.Point(202, 86);
            this.cobDownloadCriteria.Margin = new System.Windows.Forms.Padding(2);
            this.cobDownloadCriteria.Name = "cobDownloadCriteria";
            this.cobDownloadCriteria.Size = new System.Drawing.Size(18, 21);
            this.cobDownloadCriteria.TabIndex = 49;
            this.cobDownloadCriteria.Text = "IMDb";
            this.ttMovieFileMerger.SetToolTip(this.cobDownloadCriteria, "Select additional download criteria or simply Don\'t Care.");
            // 
            // btnPlay
            // 
            this.btnPlay.AllowDrop = true;
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ImageKey = "Play.gif";
            this.btnPlay.ImageList = this.ilMovieFileMerger;
            this.btnPlay.Location = new System.Drawing.Point(572, 76);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(69, 43);
            this.btnPlay.TabIndex = 31;
            this.btnPlay.TabStop = false;
            this.btnPlay.Text = "Play Video";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttMovieFileMerger.SetToolTip(this.btnPlay, "Drop an item here to play it with your movie player.");
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnPlayDragDrop);
            this.btnPlay.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ImageKey = "Edit.png";
            this.btnEdit.ImageList = this.ilMovieFileMerger;
            this.btnEdit.Location = new System.Drawing.Point(494, 311);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 26);
            this.btnEdit.TabIndex = 46;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnEdit, "Edit the regular expression for the selection criteria.");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
            // 
            // btnJustScanIt
            // 
            this.btnJustScanIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnJustScanIt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnJustScanIt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJustScanIt.ImageKey = "Process.gif";
            this.btnJustScanIt.ImageList = this.ilMovieFileMerger;
            this.btnJustScanIt.Location = new System.Drawing.Point(8, 311);
            this.btnJustScanIt.Margin = new System.Windows.Forms.Padding(2);
            this.btnJustScanIt.Name = "btnJustScanIt";
            this.btnJustScanIt.Size = new System.Drawing.Size(94, 26);
            this.btnJustScanIt.TabIndex = 40;
            this.btnJustScanIt.Text = "Just Scan It";
            this.btnJustScanIt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJustScanIt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnJustScanIt, "Just scan the existing stuff and update the Existing list.");
            this.btnJustScanIt.UseVisualStyleBackColor = false;
            this.btnJustScanIt.Click += new System.EventHandler(this.BtnJustScanItClick);
            // 
            // btnJustRipIt
            // 
            this.btnJustRipIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJustRipIt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnJustRipIt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJustRipIt.ImageKey = "Process.gif";
            this.btnJustRipIt.ImageList = this.ilMovieFileMerger;
            this.btnJustRipIt.Location = new System.Drawing.Point(557, 311);
            this.btnJustRipIt.Margin = new System.Windows.Forms.Padding(2);
            this.btnJustRipIt.Name = "btnJustRipIt";
            this.btnJustRipIt.Size = new System.Drawing.Size(81, 26);
            this.btnJustRipIt.TabIndex = 45;
            this.btnJustRipIt.Text = "Just Rip It";
            this.btnJustRipIt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJustRipIt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnJustRipIt, "Just rip the stuff you don\'t have from the Import folder and put it in the Target" +
        " folder.");
            this.btnJustRipIt.UseVisualStyleBackColor = false;
            this.btnJustRipIt.Click += new System.EventHandler(this.BtnJustRipItClick);
            // 
            // cobCriteria
            // 
            this.cobCriteria.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.cobCriteria.AllowDrop = true;
            this.cobCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cobCriteria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cobCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobCriteria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cobCriteria.FormattingEnabled = true;
            this.cobCriteria.Items.AddRange(new object[] {
            "Square Format",
            "Wide Screen",
            "Cinema Scope",
            "<699 horizontal",
            ">699 & <1000 horizontal",
            ">700 horizontal",
            ">1000 horizontal",
            "2 Channels",
            "6 Channels",
            "Series with \"SxxExx\"",
            "Movies with \"(Year)\""});
            this.cobCriteria.Location = new System.Drawing.Point(299, 312);
            this.cobCriteria.Margin = new System.Windows.Forms.Padding(2);
            this.cobCriteria.MaxDropDownItems = 15;
            this.cobCriteria.Name = "cobCriteria";
            this.cobCriteria.Size = new System.Drawing.Size(192, 21);
            this.cobCriteria.TabIndex = 44;
            this.cobCriteria.Text = "Select the Search Criteria...";
            this.ttMovieFileMerger.SetToolTip(this.cobCriteria, "Select a predefined Tool Tip Regex, for the Select, Bin, or Wish actions.   Click" +
        " on the small arrow to the right to change the search criteria.");
            this.cobCriteria.TextChanged += new System.EventHandler(this.SettingsChanged);
            this.cobCriteria.DragDrop += new System.Windows.Forms.DragEventHandler(this.CobCriteriaDragDrop);
            this.cobCriteria.DragOver += new System.Windows.Forms.DragEventHandler(this.CobCriteriaDragOver);
            // 
            // btnAddToWish
            // 
            this.btnAddToWish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddToWish.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddToWish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToWish.ImageKey = "Wish.png";
            this.btnAddToWish.ImageList = this.ilMovieFileMerger;
            this.btnAddToWish.Location = new System.Drawing.Point(236, 311);
            this.btnAddToWish.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToWish.Name = "btnAddToWish";
            this.btnAddToWish.Size = new System.Drawing.Size(60, 26);
            this.btnAddToWish.TabIndex = 43;
            this.btnAddToWish.Text = "Wish";
            this.btnAddToWish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToWish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnAddToWish, "Wish all items in the Import list according to the selection criteria.");
            this.btnAddToWish.UseVisualStyleBackColor = false;
            this.btnAddToWish.Click += new System.EventHandler(this.BtnAddToWishClick);
            // 
            // btnBin
            // 
            this.btnBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBin.ImageKey = "Garbage.gif";
            this.btnBin.ImageList = this.ilMovieFileMerger;
            this.btnBin.Location = new System.Drawing.Point(173, 311);
            this.btnBin.Margin = new System.Windows.Forms.Padding(2);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(60, 26);
            this.btnBin.TabIndex = 42;
            this.btnBin.Text = "Bin";
            this.btnBin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnBin, "Put all items in all lists in the Garbage list according to the selection ctriter" +
        "ia.");
            this.btnBin.UseVisualStyleBackColor = false;
            this.btnBin.Click += new System.EventHandler(this.BtnBinClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ImageKey = "Select.gif";
            this.btnSelect.ImageList = this.ilMovieFileMerger;
            this.btnSelect.Location = new System.Drawing.Point(105, 311);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(65, 26);
            this.btnSelect.TabIndex = 41;
            this.btnSelect.Text = "Select";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnSelect, "Select all items in all lists according to the selection criteria.\r\nYou have to h" +
        "oover with the mouse of the list to see the selected items.");
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelectClick);
            // 
            // btnExportList
            // 
            this.btnExportList.AllowDrop = true;
            this.btnExportList.BackColor = System.Drawing.SystemColors.Control;
            this.btnExportList.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnExportList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportList.ImageKey = "Save.gif";
            this.btnExportList.ImageList = this.ilMovieFileMerger;
            this.btnExportList.Location = new System.Drawing.Point(6, 76);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(69, 43);
            this.btnExportList.TabIndex = 34;
            this.btnExportList.TabStop = false;
            this.btnExportList.Text = "Export List...";
            this.btnExportList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnExportList, "Drop an item of a list here to export the complete list as .CSV file.");
            this.btnExportList.UseVisualStyleBackColor = false;
            this.btnExportList.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnExportListDragDrop);
            this.btnExportList.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnEraseColor
            // 
            this.btnEraseColor.AllowDrop = true;
            this.btnEraseColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEraseColor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnEraseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraseColor.ImageKey = "Color.gif";
            this.btnEraseColor.ImageList = this.ilMovieFileMerger;
            this.btnEraseColor.Location = new System.Drawing.Point(347, 76);
            this.btnEraseColor.Name = "btnEraseColor";
            this.btnEraseColor.Size = new System.Drawing.Size(80, 43);
            this.btnEraseColor.TabIndex = 28;
            this.btnEraseColor.TabStop = false;
            this.btnEraseColor.Text = "Erase Color";
            this.btnEraseColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEraseColor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttMovieFileMerger.SetToolTip(this.btnEraseColor, "Drop an item with a color here to erase all items of the same color from a list.");
            this.btnEraseColor.UseVisualStyleBackColor = false;
            this.btnEraseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnEraseColorDragDrop);
            this.btnEraseColor.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnSearchDownload
            // 
            this.btnSearchDownload.AllowDrop = true;
            this.btnSearchDownload.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDownload.ImageKey = "Download.png";
            this.btnSearchDownload.ImageList = this.ilMovieFileMerger;
            this.btnSearchDownload.Location = new System.Drawing.Point(99, 76);
            this.btnSearchDownload.Name = "btnSearchDownload";
            this.btnSearchDownload.Size = new System.Drawing.Size(103, 43);
            this.btnSearchDownload.TabIndex = 33;
            this.btnSearchDownload.TabStop = false;
            this.btnSearchDownload.Text = "Torrent Hound";
            this.btnSearchDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnSearchDownload, "Drop items here to download them from the internet.  Click on the small arrow to " +
        "the left to change the download site.");
            this.btnSearchDownload.UseVisualStyleBackColor = false;
            this.btnSearchDownload.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnSearchDownloadDragDrop);
            this.btnSearchDownload.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnEraseSelected
            // 
            this.btnEraseSelected.AllowDrop = true;
            this.btnEraseSelected.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnEraseSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraseSelected.ImageKey = "Erase.gif";
            this.btnEraseSelected.ImageList = this.ilMovieFileMerger;
            this.btnEraseSelected.Location = new System.Drawing.Point(229, 76);
            this.btnEraseSelected.Name = "btnEraseSelected";
            this.btnEraseSelected.Size = new System.Drawing.Size(80, 43);
            this.btnEraseSelected.TabIndex = 27;
            this.btnEraseSelected.TabStop = false;
            this.btnEraseSelected.Text = "Erase Selected";
            this.btnEraseSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEraseSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnEraseSelected, "Drop items here to erase them from a list.");
            this.btnEraseSelected.UseVisualStyleBackColor = false;
            this.btnEraseSelected.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnEraseSelectedDragDrop);
            this.btnEraseSelected.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnSearchInfo
            // 
            this.btnSearchInfo.AllowDrop = true;
            this.btnSearchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInfo.ImageKey = "About.gif";
            this.btnSearchInfo.ImageList = this.ilMovieFileMerger;
            this.btnSearchInfo.Location = new System.Drawing.Point(443, 76);
            this.btnSearchInfo.Name = "btnSearchInfo";
            this.btnSearchInfo.Size = new System.Drawing.Size(103, 43);
            this.btnSearchInfo.TabIndex = 32;
            this.btnSearchInfo.TabStop = false;
            this.btnSearchInfo.Text = "Adult DVD Empire";
            this.btnSearchInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttMovieFileMerger.SetToolTip(this.btnSearchInfo, "Drop items here to search for them on the internet. Click on the small arrow to t" +
        "he right to change the info site.");
            this.btnSearchInfo.UseVisualStyleBackColor = false;
            this.btnSearchInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnSearchInfoDragDrop);
            this.btnSearchInfo.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // gbTypeSelection
            // 
            this.gbTypeSelection.Controls.Add(this.rbMiscellaneous);
            this.gbTypeSelection.Controls.Add(this.rbAdults);
            this.gbTypeSelection.Controls.Add(this.rbClips);
            this.gbTypeSelection.Controls.Add(this.rbSeries);
            this.gbTypeSelection.Controls.Add(this.rbDocumentaries);
            this.gbTypeSelection.Controls.Add(this.rbMovies);
            this.gbTypeSelection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbTypeSelection.Location = new System.Drawing.Point(6, 6);
            this.gbTypeSelection.Name = "gbTypeSelection";
            this.gbTypeSelection.Size = new System.Drawing.Size(298, 65);
            this.gbTypeSelection.TabIndex = 10;
            this.gbTypeSelection.TabStop = false;
            this.gbTypeSelection.Text = "Collections";
            this.ttMovieFileMerger.SetToolTip(this.gbTypeSelection, resources.GetString("gbTypeSelection.ToolTip"));
            // 
            // rbMiscellaneous
            // 
            this.rbMiscellaneous.Checked = true;
            this.rbMiscellaneous.ImageKey = "Miscellaneaous.gif";
            this.rbMiscellaneous.ImageList = this.ilMovieFileMerger;
            this.rbMiscellaneous.Location = new System.Drawing.Point(98, 38);
            this.rbMiscellaneous.Name = "rbMiscellaneous";
            this.rbMiscellaneous.Size = new System.Drawing.Size(116, 24);
            this.rbMiscellaneous.TabIndex = 15;
            this.rbMiscellaneous.TabStop = true;
            this.rbMiscellaneous.Tag = "Miscellaneous";
            this.rbMiscellaneous.Text = "Miscellaneous";
            this.rbMiscellaneous.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.rbMiscellaneous, "Use this collection for any video of any kind as temporarily collection \r\nto clea" +
        "n up your collections.");
            this.rbMiscellaneous.UseVisualStyleBackColor = true;
            this.rbMiscellaneous.CheckedChanged += new System.EventHandler(this.RbCollectionsClick);
            // 
            // rbAdults
            // 
            this.rbAdults.ImageKey = "Adult.gif";
            this.rbAdults.ImageList = this.ilMovieFileMerger;
            this.rbAdults.Location = new System.Drawing.Point(12, 38);
            this.rbAdults.Name = "rbAdults";
            this.rbAdults.Size = new System.Drawing.Size(80, 24);
            this.rbAdults.TabIndex = 14;
            this.rbAdults.Tag = "Adults";
            this.rbAdults.Text = "Adults";
            this.rbAdults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.rbAdults, "An Adult video is telling a fictive story by the use of special actors, \r\nwhich s" +
        "hould not be watched by persons under 18 years.");
            this.rbAdults.UseVisualStyleBackColor = true;
            this.rbAdults.CheckedChanged += new System.EventHandler(this.RbCollectionsClick);
            // 
            // rbClips
            // 
            this.rbClips.ImageKey = "Clips.gif";
            this.rbClips.ImageList = this.ilMovieFileMerger;
            this.rbClips.Location = new System.Drawing.Point(219, 38);
            this.rbClips.Name = "rbClips";
            this.rbClips.Size = new System.Drawing.Size(66, 24);
            this.rbClips.TabIndex = 16;
            this.rbClips.Tag = "Clips";
            this.rbClips.Text = "Clips";
            this.rbClips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.rbClips, "A clip is a short video telling the story of a song by using dancers.");
            this.rbClips.UseVisualStyleBackColor = true;
            this.rbClips.CheckedChanged += new System.EventHandler(this.RbCollectionsClick);
            // 
            // rbSeries
            // 
            this.rbSeries.ImageKey = "Series.gif";
            this.rbSeries.ImageList = this.ilMovieFileMerger;
            this.rbSeries.Location = new System.Drawing.Point(219, 15);
            this.rbSeries.Name = "rbSeries";
            this.rbSeries.Size = new System.Drawing.Size(75, 24);
            this.rbSeries.TabIndex = 13;
            this.rbSeries.Tag = "Series";
            this.rbSeries.Text = "Series";
            this.rbSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.rbSeries, "Series are a video collection telling a fictive story in multiple parts or \r\nepis" +
        "odes by the use of actors.");
            this.rbSeries.UseVisualStyleBackColor = true;
            this.rbSeries.CheckedChanged += new System.EventHandler(this.RbCollectionsClick);
            // 
            // rbDocumentaries
            // 
            this.rbDocumentaries.ImageKey = "Documentaries.gif";
            this.rbDocumentaries.ImageList = this.ilMovieFileMerger;
            this.rbDocumentaries.Location = new System.Drawing.Point(98, 15);
            this.rbDocumentaries.Name = "rbDocumentaries";
            this.rbDocumentaries.Size = new System.Drawing.Size(116, 24);
            this.rbDocumentaries.TabIndex = 12;
            this.rbDocumentaries.Tag = "Documentaries";
            this.rbDocumentaries.Text = "Documentaries";
            this.rbDocumentaries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.rbDocumentaries, "A documentary is video that is telling a more real story by the use of presenters" +
        " or \r\na movie or a television program that provides a factual record or report.");
            this.rbDocumentaries.UseVisualStyleBackColor = true;
            this.rbDocumentaries.CheckedChanged += new System.EventHandler(this.RbCollectionsClick);
            // 
            // rbMovies
            // 
            this.rbMovies.ImageKey = "Movie.gif";
            this.rbMovies.ImageList = this.ilMovieFileMerger;
            this.rbMovies.Location = new System.Drawing.Point(12, 15);
            this.rbMovies.Name = "rbMovies";
            this.rbMovies.Size = new System.Drawing.Size(80, 24);
            this.rbMovies.TabIndex = 11;
            this.rbMovies.Tag = "Movies";
            this.rbMovies.Text = "Movies";
            this.rbMovies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.rbMovies, "A movie is a video telling a fictive story by the use of actors or \r\na story or e" +
        "vent recorded by a camera as a set of moving images and \r\nshown in a theatre or " +
        "on television; a motion picture.");
            this.rbMovies.UseVisualStyleBackColor = true;
            this.rbMovies.CheckedChanged += new System.EventHandler(this.RbCollectionsClick);
            // 
            // gbProcessImport
            // 
            this.gbProcessImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProcessImport.Controls.Add(this.cobMinimumResolution);
            this.gbProcessImport.Controls.Add(this.btnStart);
            this.gbProcessImport.Controls.Add(this.cbGetHigherRes);
            this.gbProcessImport.Controls.Add(this.rbMove);
            this.gbProcessImport.Controls.Add(this.rbCopy);
            this.gbProcessImport.Location = new System.Drawing.Point(311, 6);
            this.gbProcessImport.Name = "gbProcessImport";
            this.gbProcessImport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbProcessImport.Size = new System.Drawing.Size(324, 65);
            this.gbProcessImport.TabIndex = 20;
            this.gbProcessImport.TabStop = false;
            this.gbProcessImport.Text = "Process Import";
            this.ttMovieFileMerger.SetToolTip(this.gbProcessImport, "The process Import section allows you to copy or move the actual video and subtit" +
        "le files. You have to install TeraCopy to\r\ndo the actual processing.");
            // 
            // cobMinimumResolution
            // 
            this.cobMinimumResolution.BackColor = System.Drawing.Color.IndianRed;
            this.cobMinimumResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobMinimumResolution.FormattingEnabled = true;
            this.cobMinimumResolution.Items.AddRange(new object[] {
            " <~8640p (16k QUHD)",
            " <~4320p (8K FUHD)",
            " <~2880p (UHD+)",
            " <~2160p (4K UHD)",
            " <~1440p (WQHD)",
            " <~1080p (Full HD)",
            " <~900p (HD+)",
            " <~720p (HD)",
            " <~540p (qHD)",
            " <~360p (nHD)",
            " <~0p (FLD)"});
            this.cobMinimumResolution.Location = new System.Drawing.Point(177, 14);
            this.cobMinimumResolution.Name = "cobMinimumResolution";
            this.cobMinimumResolution.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cobMinimumResolution.Size = new System.Drawing.Size(139, 21);
            this.cobMinimumResolution.TabIndex = 26;
            this.ttMovieFileMerger.SetToolTip(this.cobMinimumResolution, resources.GetString("cobMinimumResolution.ToolTip"));
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ImageKey = "Start.gif";
            this.btnStart.ImageList = this.ilMovieFileMerger;
            this.btnStart.Location = new System.Drawing.Point(5, 13);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(79, 46);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Start Process";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnStart, "Click to start the copying or moving of the files, which are marked as Wish in th" +
        "e Import list.");
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStartProcessClick);
            // 
            // cbGetHigherRes
            // 
            this.cbGetHigherRes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cbGetHigherRes.Checked = true;
            this.cbGetHigherRes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGetHigherRes.ImageKey = "Folder.gif";
            this.cbGetHigherRes.Location = new System.Drawing.Point(177, 41);
            this.cbGetHigherRes.Name = "cbGetHigherRes";
            this.cbGetHigherRes.Size = new System.Drawing.Size(139, 18);
            this.cbGetHigherRes.TabIndex = 25;
            this.cbGetHigherRes.Text = "Get Higher Resolution";
            this.cbGetHigherRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.cbGetHigherRes, "Check to copy higer horizontal resolution files, even if they are existing alread" +
        "y.");
            this.cbGetHigherRes.UseVisualStyleBackColor = false;
            this.cbGetHigherRes.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // rbMove
            // 
            this.rbMove.ImageKey = "Move.gif";
            this.rbMove.ImageList = this.ilMovieFileMerger;
            this.rbMove.Location = new System.Drawing.Point(88, 38);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(80, 24);
            this.rbMove.TabIndex = 23;
            this.rbMove.Text = "Move";
            this.rbMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.rbMove, "If Move is checked and Start Process is clicked, the Wish colored items \r\nin the " +
        "Import list will be moved to the Target folder.");
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // rbCopy
            // 
            this.rbCopy.Checked = true;
            this.rbCopy.ImageKey = "Copy.gif";
            this.rbCopy.ImageList = this.ilMovieFileMerger;
            this.rbCopy.Location = new System.Drawing.Point(88, 15);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(80, 24);
            this.rbCopy.TabIndex = 22;
            this.rbCopy.TabStop = true;
            this.rbCopy.Text = "Copy";
            this.rbCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.rbCopy, "If Copy is selected and you click Start Process, the Wish colored items \r\nin the " +
        "Import list will be copied to the Target folder.");
            this.rbCopy.UseVisualStyleBackColor = true;
            // 
            // scVertical
            // 
            this.scVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scVertical.BackColor = System.Drawing.SystemColors.Control;
            this.scVertical.Location = new System.Drawing.Point(6, 125);
            this.scVertical.Name = "scVertical";
            // 
            // scVertical.Panel1
            // 
            this.scVertical.Panel1.Controls.Add(this.lvExisting);
            // 
            // scVertical.Panel2
            // 
            this.scVertical.Panel2.Controls.Add(this.scVerticalRight);
            this.scVertical.Size = new System.Drawing.Size(634, 181);
            this.scVertical.SplitterDistance = 203;
            this.scVertical.TabIndex = 7;
            this.scVertical.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ScVerticalSplitterMoved);
            // 
            // lvExisting
            // 
            this.lvExisting.AllowDrop = true;
            this.lvExisting.BackColor = System.Drawing.Color.ForestGreen;
            this.lvExisting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvExisting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNameExisting});
            this.lvExisting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExisting.FullRowSelect = true;
            this.lvExisting.GridLines = true;
            this.lvExisting.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvExisting.LabelWrap = false;
            this.lvExisting.Location = new System.Drawing.Point(0, 0);
            this.lvExisting.Name = "lvExisting";
            this.lvExisting.ShowItemToolTips = true;
            this.lvExisting.Size = new System.Drawing.Size(203, 181);
            this.lvExisting.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvExisting.TabIndex = 0;
            this.lvExisting.TabStop = false;
            this.lvExisting.Tag = "Existing";
            this.lvExisting.UseCompatibleStateImageBehavior = false;
            this.lvExisting.View = System.Windows.Forms.View.Details;
            this.lvExisting.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemsDrag);
            this.lvExisting.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
            this.lvExisting.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
            this.lvExisting.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
            this.lvExisting.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
            this.lvExisting.DoubleClick += new System.EventHandler(this.LvDoubleClick);
            this.lvExisting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKeyDown);
            this.lvExisting.MouseEnter += new System.EventHandler(this.LvMouseEnter);
            // 
            // chNameExisting
            // 
            this.chNameExisting.Text = "Existing";
            this.chNameExisting.Width = 250;
            // 
            // scVerticalRight
            // 
            this.scVerticalRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scVerticalRight.Location = new System.Drawing.Point(0, 0);
            this.scVerticalRight.Name = "scVerticalRight";
            // 
            // scVerticalRight.Panel1
            // 
            this.scVerticalRight.Panel1.Controls.Add(this.scHorizontal);
            // 
            // scVerticalRight.Panel2
            // 
            this.scVerticalRight.Panel2.Controls.Add(this.lvImport);
            this.scVerticalRight.Size = new System.Drawing.Size(427, 181);
            this.scVerticalRight.SplitterDistance = 212;
            this.scVerticalRight.TabIndex = 1;
            this.scVerticalRight.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ScVerticalSplitterMoved);
            // 
            // scHorizontal
            // 
            this.scHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scHorizontal.Location = new System.Drawing.Point(0, 0);
            this.scHorizontal.Name = "scHorizontal";
            this.scHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scHorizontal.Panel1
            // 
            this.scHorizontal.Panel1.Controls.Add(this.lvWish);
            // 
            // scHorizontal.Panel2
            // 
            this.scHorizontal.Panel2.Controls.Add(this.lvGarbage);
            this.scHorizontal.Size = new System.Drawing.Size(212, 181);
            this.scHorizontal.SplitterDistance = 82;
            this.scHorizontal.TabIndex = 0;
            // 
            // lvWish
            // 
            this.lvWish.AllowDrop = true;
            this.lvWish.BackColor = System.Drawing.Color.LimeGreen;
            this.lvWish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvWish.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvWish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWish.FullRowSelect = true;
            this.lvWish.GridLines = true;
            this.lvWish.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvWish.LabelWrap = false;
            this.lvWish.Location = new System.Drawing.Point(0, 0);
            this.lvWish.Name = "lvWish";
            this.lvWish.ShowItemToolTips = true;
            this.lvWish.Size = new System.Drawing.Size(212, 82);
            this.lvWish.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvWish.TabIndex = 1;
            this.lvWish.TabStop = false;
            this.lvWish.Tag = "Wish";
            this.lvWish.UseCompatibleStateImageBehavior = false;
            this.lvWish.View = System.Windows.Forms.View.Details;
            this.lvWish.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemsDrag);
            this.lvWish.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
            this.lvWish.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
            this.lvWish.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
            this.lvWish.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
            this.lvWish.DoubleClick += new System.EventHandler(this.LvDoubleClick);
            this.lvWish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKeyDown);
            this.lvWish.MouseEnter += new System.EventHandler(this.LvMouseEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Wish";
            this.columnHeader1.Width = 250;
            // 
            // lvGarbage
            // 
            this.lvGarbage.AllowDrop = true;
            this.lvGarbage.BackColor = System.Drawing.Color.SaddleBrown;
            this.lvGarbage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvGarbage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNameGarbage});
            this.lvGarbage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGarbage.FullRowSelect = true;
            this.lvGarbage.GridLines = true;
            this.lvGarbage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvGarbage.LabelWrap = false;
            this.lvGarbage.Location = new System.Drawing.Point(0, 0);
            this.lvGarbage.Name = "lvGarbage";
            this.lvGarbage.ShowItemToolTips = true;
            this.lvGarbage.Size = new System.Drawing.Size(212, 95);
            this.lvGarbage.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvGarbage.TabIndex = 1;
            this.lvGarbage.TabStop = false;
            this.lvGarbage.Tag = "Garbage";
            this.lvGarbage.UseCompatibleStateImageBehavior = false;
            this.lvGarbage.View = System.Windows.Forms.View.Details;
            this.lvGarbage.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemsDrag);
            this.lvGarbage.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
            this.lvGarbage.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
            this.lvGarbage.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
            this.lvGarbage.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
            this.lvGarbage.DoubleClick += new System.EventHandler(this.LvDoubleClick);
            this.lvGarbage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKeyDown);
            this.lvGarbage.MouseEnter += new System.EventHandler(this.LvMouseEnter);
            // 
            // chNameGarbage
            // 
            this.chNameGarbage.Text = "Garbage";
            this.chNameGarbage.Width = 250;
            // 
            // lvImport
            // 
            this.lvImport.AllowDrop = true;
            this.lvImport.BackColor = System.Drawing.Color.Silver;
            this.lvImport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvImport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNameImport});
            this.lvImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvImport.FullRowSelect = true;
            this.lvImport.GridLines = true;
            this.lvImport.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvImport.LabelWrap = false;
            this.lvImport.Location = new System.Drawing.Point(0, 0);
            this.lvImport.Name = "lvImport";
            this.lvImport.ShowItemToolTips = true;
            this.lvImport.Size = new System.Drawing.Size(211, 181);
            this.lvImport.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvImport.TabIndex = 0;
            this.lvImport.TabStop = false;
            this.lvImport.Tag = "Import";
            this.lvImport.TileSize = new System.Drawing.Size(1, 1);
            this.lvImport.UseCompatibleStateImageBehavior = false;
            this.lvImport.View = System.Windows.Forms.View.Details;
            this.lvImport.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemsDrag);
            this.lvImport.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
            this.lvImport.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
            this.lvImport.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
            this.lvImport.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
            this.lvImport.DoubleClick += new System.EventHandler(this.LvDoubleClick);
            this.lvImport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKeyDown);
            this.lvImport.MouseEnter += new System.EventHandler(this.LvMouseEnter);
            // 
            // chNameImport
            // 
            this.chNameImport.Text = "Import";
            this.chNameImport.Width = 250;
            // 
            // cobSearchDownload
            // 
            this.cobSearchDownload.BackColor = System.Drawing.SystemColors.Control;
            this.cobSearchDownload.DropDownWidth = 130;
            this.cobSearchDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobSearchDownload.FormattingEnabled = true;
            this.cobSearchDownload.Items.AddRange(new object[] {
            "Best Below",
            "1337X",
            "Rarbg",
            "Bit Snoop",
            "Demonoid",
            "Extra Torrent",
            "Eztv",
            "Kickass",
            "ISO Hunt",
            "Lime Torrents",
            "World Wide Torrents",
            "Yifi",
            "Zoogle"});
            this.cobSearchDownload.Location = new System.Drawing.Point(84, 86);
            this.cobSearchDownload.Margin = new System.Windows.Forms.Padding(2);
            this.cobSearchDownload.Name = "cobSearchDownload";
            this.cobSearchDownload.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cobSearchDownload.Size = new System.Drawing.Size(18, 21);
            this.cobSearchDownload.TabIndex = 48;
            this.cobSearchDownload.Text = "Torrentz";
            this.ttMovieFileMerger.SetToolTip(this.cobSearchDownload, "Select where to search for torrents to download the item.");
            this.cobSearchDownload.SelectedIndexChanged += new System.EventHandler(this.CobSearchDownloadSelectedIndexChanged);
            // 
            // cobSearchInfo
            // 
            this.cobSearchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cobSearchInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cobSearchInfo.DropDownWidth = 130;
            this.cobSearchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobSearchInfo.FormattingEnabled = true;
            this.cobSearchInfo.Items.AddRange(new object[] {
            "Best Below",
            "All Movie",
            "IMDb",
            "The Movie DB",
            "The Movie Poster DB",
            "The TVDB",
            "Trailer Addict",
            "Adult DVD Empire",
            "Open Movie Database",
            "Google",
            "Yahoo",
            "Rotten Tomatoes",
            "FMovies",
            "DuckDuckGo",
            "Movie Web",
            "YouTube",
            "Fandom",
            "TV Guide",
            "MRQE",
            "Hollywood.com",
            "CineMaterial"});
            this.cobSearchInfo.Location = new System.Drawing.Point(545, 86);
            this.cobSearchInfo.Margin = new System.Windows.Forms.Padding(2);
            this.cobSearchInfo.Name = "cobSearchInfo";
            this.cobSearchInfo.Size = new System.Drawing.Size(18, 21);
            this.cobSearchInfo.TabIndex = 47;
            this.cobSearchInfo.Text = "IMDb";
            this.ttMovieFileMerger.SetToolTip(this.cobSearchInfo, "Select where to search for additional information concerning the item.");
            this.cobSearchInfo.SelectedIndexChanged += new System.EventHandler(this.CobSearchInfoSelectedIndexChanged);
            // 
            // tpMaintenance
            // 
            this.tpMaintenance.Controls.Add(this.pbMFM);
            this.tpMaintenance.Controls.Add(this.btnPlayMaintenance);
            this.tpMaintenance.Controls.Add(this.btnExportListMaintenance);
            this.tpMaintenance.Controls.Add(this.btnSearchDownloadMaintenance);
            this.tpMaintenance.Controls.Add(this.btnSearchInfoMaintenance);
            this.tpMaintenance.Controls.Add(this.cobSearchDownloadMaintenance);
            this.tpMaintenance.Controls.Add(this.cobSearchInfoMaintenance);
            this.tpMaintenance.Controls.Add(this.pbMaintenanceUserManual);
            this.tpMaintenance.Controls.Add(this.btnGoodEpisode);
            this.tpMaintenance.Controls.Add(this.btnGoodDocu);
            this.tpMaintenance.Controls.Add(this.btnGoodMovie);
            this.tpMaintenance.Controls.Add(this.btnUnrelatedFile);
            this.tpMaintenance.Controls.Add(this.btnBadEpisode);
            this.tpMaintenance.Controls.Add(this.btnBadName);
            this.tpMaintenance.Controls.Add(this.btnBadDocu);
            this.tpMaintenance.Controls.Add(this.btnBadMovie);
            this.tpMaintenance.Controls.Add(this.lblSelect);
            this.tpMaintenance.Controls.Add(this.scMaintenance);
            this.tpMaintenance.ImageKey = "Process.gif";
            this.tpMaintenance.Location = new System.Drawing.Point(4, 29);
            this.tpMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.tpMaintenance.Name = "tpMaintenance";
            this.tpMaintenance.Padding = new System.Windows.Forms.Padding(2);
            this.tpMaintenance.Size = new System.Drawing.Size(643, 342);
            this.tpMaintenance.TabIndex = 5;
            this.tpMaintenance.Text = "Maintenance";
            // 
            // pbMFM
            // 
            this.pbMFM.Image = ((System.Drawing.Image)(resources.GetObject("pbMFM.Image")));
            this.pbMFM.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMFM.InitialImage")));
            this.pbMFM.Location = new System.Drawing.Point(8, 6);
            this.pbMFM.Margin = new System.Windows.Forms.Padding(2);
            this.pbMFM.Name = "pbMFM";
            this.pbMFM.Size = new System.Drawing.Size(82, 42);
            this.pbMFM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMFM.TabIndex = 60;
            this.pbMFM.TabStop = false;
            // 
            // btnPlayMaintenance
            // 
            this.btnPlayMaintenance.AllowDrop = true;
            this.btnPlayMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayMaintenance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlayMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayMaintenance.ImageKey = "Play.gif";
            this.btnPlayMaintenance.ImageList = this.ilMovieFileMerger;
            this.btnPlayMaintenance.Location = new System.Drawing.Point(571, 5);
            this.btnPlayMaintenance.Name = "btnPlayMaintenance";
            this.btnPlayMaintenance.Size = new System.Drawing.Size(69, 43);
            this.btnPlayMaintenance.TabIndex = 54;
            this.btnPlayMaintenance.TabStop = false;
            this.btnPlayMaintenance.Text = "Play Video";
            this.btnPlayMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlayMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttMovieFileMerger.SetToolTip(this.btnPlayMaintenance, "Drop an item here to play it with your movie player.");
            this.btnPlayMaintenance.UseVisualStyleBackColor = false;
            this.btnPlayMaintenance.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnPlayDragDrop);
            this.btnPlayMaintenance.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnExportListMaintenance
            // 
            this.btnExportListMaintenance.AllowDrop = true;
            this.btnExportListMaintenance.BackColor = System.Drawing.SystemColors.Control;
            this.btnExportListMaintenance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnExportListMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportListMaintenance.ImageKey = "Save.gif";
            this.btnExportListMaintenance.ImageList = this.ilMovieFileMerger;
            this.btnExportListMaintenance.Location = new System.Drawing.Point(96, 5);
            this.btnExportListMaintenance.Name = "btnExportListMaintenance";
            this.btnExportListMaintenance.Size = new System.Drawing.Size(69, 43);
            this.btnExportListMaintenance.TabIndex = 57;
            this.btnExportListMaintenance.TabStop = false;
            this.btnExportListMaintenance.Text = "Export List...";
            this.btnExportListMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportListMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnExportListMaintenance, "Drop an item of a list here to export the complete list as .CSV file.");
            this.btnExportListMaintenance.UseVisualStyleBackColor = false;
            this.btnExportListMaintenance.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnExportListDragDrop);
            this.btnExportListMaintenance.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnSearchDownloadMaintenance
            // 
            this.btnSearchDownloadMaintenance.AllowDrop = true;
            this.btnSearchDownloadMaintenance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchDownloadMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDownloadMaintenance.ImageKey = "Download.png";
            this.btnSearchDownloadMaintenance.ImageList = this.ilMovieFileMerger;
            this.btnSearchDownloadMaintenance.Location = new System.Drawing.Point(189, 5);
            this.btnSearchDownloadMaintenance.Name = "btnSearchDownloadMaintenance";
            this.btnSearchDownloadMaintenance.Size = new System.Drawing.Size(103, 43);
            this.btnSearchDownloadMaintenance.TabIndex = 56;
            this.btnSearchDownloadMaintenance.TabStop = false;
            this.btnSearchDownloadMaintenance.Text = "Torrent Hound";
            this.btnSearchDownloadMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchDownloadMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnSearchDownloadMaintenance, "Drop items here to download them from the internet.  Click on the small arrow to " +
        "the left to change the download site.");
            this.btnSearchDownloadMaintenance.UseVisualStyleBackColor = false;
            this.btnSearchDownloadMaintenance.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnSearchDownloadDragDrop);
            this.btnSearchDownloadMaintenance.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnSearchInfoMaintenance
            // 
            this.btnSearchInfoMaintenance.AllowDrop = true;
            this.btnSearchInfoMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchInfoMaintenance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchInfoMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInfoMaintenance.ImageKey = "About.gif";
            this.btnSearchInfoMaintenance.ImageList = this.ilMovieFileMerger;
            this.btnSearchInfoMaintenance.Location = new System.Drawing.Point(442, 5);
            this.btnSearchInfoMaintenance.Name = "btnSearchInfoMaintenance";
            this.btnSearchInfoMaintenance.Size = new System.Drawing.Size(103, 43);
            this.btnSearchInfoMaintenance.TabIndex = 55;
            this.btnSearchInfoMaintenance.TabStop = false;
            this.btnSearchInfoMaintenance.Text = "Adult DVD Empire";
            this.btnSearchInfoMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchInfoMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttMovieFileMerger.SetToolTip(this.btnSearchInfoMaintenance, "Drop items here to search for them on the internet.  Click on the small arrow to " +
        "the right to change the info site.");
            this.btnSearchInfoMaintenance.UseVisualStyleBackColor = false;
            this.btnSearchInfoMaintenance.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnSearchInfoDragDrop);
            this.btnSearchInfoMaintenance.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // cobSearchDownloadMaintenance
            // 
            this.cobSearchDownloadMaintenance.BackColor = System.Drawing.SystemColors.Control;
            this.cobSearchDownloadMaintenance.DropDownWidth = 130;
            this.cobSearchDownloadMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobSearchDownloadMaintenance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cobSearchDownloadMaintenance.FormattingEnabled = true;
            this.cobSearchDownloadMaintenance.Items.AddRange(new object[] {
            "Best Below",
            "1337X",
            "Rarbg",
            "Bit Snoop",
            "Demonoid",
            "Extra Torrent",
            "Eztv",
            "Kickass",
            "ISO Hunt",
            "Lime Torrents",
            "World Wide Torrents",
            "Yifi",
            "Zoogle"});
            this.cobSearchDownloadMaintenance.Location = new System.Drawing.Point(174, 15);
            this.cobSearchDownloadMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.cobSearchDownloadMaintenance.Name = "cobSearchDownloadMaintenance";
            this.cobSearchDownloadMaintenance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cobSearchDownloadMaintenance.Size = new System.Drawing.Size(18, 21);
            this.cobSearchDownloadMaintenance.TabIndex = 59;
            this.cobSearchDownloadMaintenance.Text = "Torrentz";
            this.ttMovieFileMerger.SetToolTip(this.cobSearchDownloadMaintenance, "Select where to search for torrents to download the item.");
            this.cobSearchDownloadMaintenance.SelectedIndexChanged += new System.EventHandler(this.CobSearchDownloadSelectedIndexChanged);
            // 
            // cobSearchInfoMaintenance
            // 
            this.cobSearchInfoMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cobSearchInfoMaintenance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cobSearchInfoMaintenance.DropDownWidth = 130;
            this.cobSearchInfoMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobSearchInfoMaintenance.FormattingEnabled = true;
            this.cobSearchInfoMaintenance.Items.AddRange(new object[] {
            "Best Below",
            "All Movie",
            "IMDb",
            "The Movie DB",
            "The Movie Poster DB",
            "The TVDB",
            "Trailer Addict",
            "Adult DVD Empire",
            "Open Movie Database",
            "Google",
            "Yahoo",
            "Rotten Tomatoes",
            "FMovies",
            "DuckDuckGo",
            "Movie Web",
            "YouTube",
            "Fandom",
            "TV Guide",
            "MRQE",
            "Hollywood.com",
            "CineMaterial"});
            this.cobSearchInfoMaintenance.Location = new System.Drawing.Point(545, 15);
            this.cobSearchInfoMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.cobSearchInfoMaintenance.Name = "cobSearchInfoMaintenance";
            this.cobSearchInfoMaintenance.Size = new System.Drawing.Size(18, 21);
            this.cobSearchInfoMaintenance.TabIndex = 58;
            this.cobSearchInfoMaintenance.Text = "IMDb";
            this.ttMovieFileMerger.SetToolTip(this.cobSearchInfoMaintenance, "Select where to search for additional information concerning the item.");
            this.cobSearchInfoMaintenance.SelectedIndexChanged += new System.EventHandler(this.CobSearchInfoSelectedIndexChanged);
            // 
            // pbMaintenanceUserManual
            // 
            this.pbMaintenanceUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbMaintenanceUserManual.Image")));
            this.pbMaintenanceUserManual.Location = new System.Drawing.Point(4, 284);
            this.pbMaintenanceUserManual.Margin = new System.Windows.Forms.Padding(2);
            this.pbMaintenanceUserManual.Name = "pbMaintenanceUserManual";
            this.pbMaintenanceUserManual.Size = new System.Drawing.Size(86, 89);
            this.pbMaintenanceUserManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaintenanceUserManual.TabIndex = 51;
            this.pbMaintenanceUserManual.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbMaintenanceUserManual, "Go To the MFM User Manual to read more details about how to use MFM.");
            this.pbMaintenanceUserManual.Click += new System.EventHandler(this.PbUserManualClick);
            this.pbMaintenanceUserManual.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbMaintenanceUserManual.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // btnGoodEpisode
            // 
            this.btnGoodEpisode.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnGoodEpisode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoodEpisode.Location = new System.Drawing.Point(6, 247);
            this.btnGoodEpisode.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoodEpisode.Name = "btnGoodEpisode";
            this.btnGoodEpisode.Size = new System.Drawing.Size(86, 21);
            this.btnGoodEpisode.TabIndex = 18;
            this.btnGoodEpisode.Text = "Good Episode";
            this.ttMovieFileMerger.SetToolTip(this.btnGoodEpisode, "Select all episodes with bad names.");
            this.btnGoodEpisode.UseVisualStyleBackColor = true;
            this.btnGoodEpisode.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
            // 
            // btnGoodDocu
            // 
            this.btnGoodDocu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnGoodDocu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoodDocu.Location = new System.Drawing.Point(6, 222);
            this.btnGoodDocu.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoodDocu.Name = "btnGoodDocu";
            this.btnGoodDocu.Size = new System.Drawing.Size(86, 21);
            this.btnGoodDocu.TabIndex = 16;
            this.btnGoodDocu.Text = "Good Docu";
            this.ttMovieFileMerger.SetToolTip(this.btnGoodDocu, "Select all documentaries with good names.");
            this.btnGoodDocu.UseVisualStyleBackColor = true;
            this.btnGoodDocu.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
            // 
            // btnGoodMovie
            // 
            this.btnGoodMovie.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnGoodMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoodMovie.Location = new System.Drawing.Point(6, 197);
            this.btnGoodMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoodMovie.Name = "btnGoodMovie";
            this.btnGoodMovie.Size = new System.Drawing.Size(86, 21);
            this.btnGoodMovie.TabIndex = 15;
            this.btnGoodMovie.Text = "Good Movie";
            this.ttMovieFileMerger.SetToolTip(this.btnGoodMovie, "Select all movies with good names.");
            this.btnGoodMovie.UseVisualStyleBackColor = true;
            this.btnGoodMovie.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
            // 
            // btnUnrelatedFile
            // 
            this.btnUnrelatedFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnUnrelatedFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnrelatedFile.Location = new System.Drawing.Point(6, 173);
            this.btnUnrelatedFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnrelatedFile.Name = "btnUnrelatedFile";
            this.btnUnrelatedFile.Size = new System.Drawing.Size(86, 21);
            this.btnUnrelatedFile.TabIndex = 14;
            this.btnUnrelatedFile.Text = "Unrelated File";
            this.ttMovieFileMerger.SetToolTip(this.btnUnrelatedFile, "Select all unrelated files, which are not main or add-on files.");
            this.btnUnrelatedFile.UseVisualStyleBackColor = true;
            this.btnUnrelatedFile.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
            // 
            // btnBadEpisode
            // 
            this.btnBadEpisode.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnBadEpisode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBadEpisode.Location = new System.Drawing.Point(6, 124);
            this.btnBadEpisode.Margin = new System.Windows.Forms.Padding(2);
            this.btnBadEpisode.Name = "btnBadEpisode";
            this.btnBadEpisode.Size = new System.Drawing.Size(86, 21);
            this.btnBadEpisode.TabIndex = 12;
            this.btnBadEpisode.Text = "Bad Episode";
            this.ttMovieFileMerger.SetToolTip(this.btnBadEpisode, "Select all episodes with bad names.");
            this.btnBadEpisode.UseVisualStyleBackColor = true;
            this.btnBadEpisode.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
            // 
            // btnBadName
            // 
            this.btnBadName.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnBadName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBadName.Location = new System.Drawing.Point(6, 148);
            this.btnBadName.Margin = new System.Windows.Forms.Padding(2);
            this.btnBadName.Name = "btnBadName";
            this.btnBadName.Size = new System.Drawing.Size(86, 21);
            this.btnBadName.TabIndex = 13;
            this.btnBadName.Text = "Bad Name";
            this.ttMovieFileMerger.SetToolTip(this.btnBadName, "Select all remaining files with bad names.");
            this.btnBadName.UseVisualStyleBackColor = true;
            this.btnBadName.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
            // 
            // btnBadDocu
            // 
            this.btnBadDocu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnBadDocu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBadDocu.Location = new System.Drawing.Point(6, 98);
            this.btnBadDocu.Margin = new System.Windows.Forms.Padding(2);
            this.btnBadDocu.Name = "btnBadDocu";
            this.btnBadDocu.Size = new System.Drawing.Size(86, 21);
            this.btnBadDocu.TabIndex = 11;
            this.btnBadDocu.Text = "Bad Docu";
            this.ttMovieFileMerger.SetToolTip(this.btnBadDocu, "Select all documentaries with bad names.");
            this.btnBadDocu.UseVisualStyleBackColor = true;
            this.btnBadDocu.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
            // 
            // btnBadMovie
            // 
            this.btnBadMovie.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnBadMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBadMovie.Location = new System.Drawing.Point(6, 74);
            this.btnBadMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnBadMovie.Name = "btnBadMovie";
            this.btnBadMovie.Size = new System.Drawing.Size(86, 21);
            this.btnBadMovie.TabIndex = 10;
            this.btnBadMovie.Text = "Bad Movie";
            this.ttMovieFileMerger.SetToolTip(this.btnBadMovie, "Select all movies with with bad names.");
            this.btnBadMovie.UseVisualStyleBackColor = true;
            this.btnBadMovie.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoEllipsis = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(7, 54);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(84, 15);
            this.lblSelect.TabIndex = 41;
            this.lblSelect.Text = "Select";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scMaintenance
            // 
            this.scMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMaintenance.Location = new System.Drawing.Point(95, 53);
            this.scMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.scMaintenance.Name = "scMaintenance";
            this.scMaintenance.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMaintenance.Panel1
            // 
            this.scMaintenance.Panel1.Controls.Add(this.lvMaintenance);
            this.scMaintenance.Panel1.Margin = new System.Windows.Forms.Padding(1);
            this.scMaintenance.Panel1.Padding = new System.Windows.Forms.Padding(1);
            this.scMaintenance.Panel1MinSize = 100;
            // 
            // scMaintenance.Panel2
            // 
            this.scMaintenance.Panel2.Controls.Add(this.rtbMaintenance);
            this.scMaintenance.Panel2MinSize = 100;
            this.scMaintenance.Size = new System.Drawing.Size(545, 297);
            this.scMaintenance.SplitterDistance = 193;
            this.scMaintenance.TabIndex = 39;
            // 
            // lvMaintenance
            // 
            this.lvMaintenance.AllowDrop = true;
            this.lvMaintenance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lvMaintenance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNameMaintenance});
            this.lvMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMaintenance.FullRowSelect = true;
            this.lvMaintenance.GridLines = true;
            this.lvMaintenance.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMaintenance.LabelWrap = false;
            this.lvMaintenance.Location = new System.Drawing.Point(1, 1);
            this.lvMaintenance.Name = "lvMaintenance";
            this.lvMaintenance.ShowItemToolTips = true;
            this.lvMaintenance.Size = new System.Drawing.Size(543, 191);
            this.lvMaintenance.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvMaintenance.TabIndex = 38;
            this.lvMaintenance.Tag = "Maintenance";
            this.lvMaintenance.TileSize = new System.Drawing.Size(1, 1);
            this.lvMaintenance.UseCompatibleStateImageBehavior = false;
            this.lvMaintenance.View = System.Windows.Forms.View.Details;
            this.lvMaintenance.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvFileListDrag);
            this.lvMaintenance.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvMaintenanceDragDrop);
            this.lvMaintenance.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
            this.lvMaintenance.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
            this.lvMaintenance.DoubleClick += new System.EventHandler(this.LvDoubleClick);
            this.lvMaintenance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKeyDown);
            this.lvMaintenance.MouseEnter += new System.EventHandler(this.LvMouseEnter);
            this.lvMaintenance.Resize += new System.EventHandler(this.LvMaintenanceResize);
            // 
            // chNameMaintenance
            // 
            this.chNameMaintenance.Text = "Maintenance";
            this.chNameMaintenance.Width = 700;
            // 
            // rtbMaintenance
            // 
            this.rtbMaintenance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMaintenance.Location = new System.Drawing.Point(0, 0);
            this.rtbMaintenance.Name = "rtbMaintenance";
            this.rtbMaintenance.ReadOnly = true;
            this.rtbMaintenance.Size = new System.Drawing.Size(545, 100);
            this.rtbMaintenance.TabIndex = 20;
            this.rtbMaintenance.Text = "";
            this.rtbMaintenance.WordWrap = false;
            // 
            // tpLog
            // 
            this.tpLog.BackColor = System.Drawing.SystemColors.Control;
            this.tpLog.Controls.Add(this.pbLogUserManual);
            this.tpLog.Controls.Add(this.pbLogHowTo);
            this.tpLog.Controls.Add(this.pbLogBanner);
            this.tpLog.Controls.Add(this.rtbLog);
            this.tpLog.ImageKey = "Log.gif";
            this.tpLog.Location = new System.Drawing.Point(4, 29);
            this.tpLog.Name = "tpLog";
            this.tpLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpLog.Size = new System.Drawing.Size(643, 342);
            this.tpLog.TabIndex = 2;
            this.tpLog.Text = "Log";
            // 
            // pbLogUserManual
            // 
            this.pbLogUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbLogUserManual.Image")));
            this.pbLogUserManual.Location = new System.Drawing.Point(5, 5);
            this.pbLogUserManual.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogUserManual.Name = "pbLogUserManual";
            this.pbLogUserManual.Size = new System.Drawing.Size(54, 67);
            this.pbLogUserManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogUserManual.TabIndex = 50;
            this.pbLogUserManual.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbLogUserManual, "Go To the MFM User Manual to read more details about how to use MFM.");
            this.pbLogUserManual.Click += new System.EventHandler(this.PbUserManualClick);
            this.pbLogUserManual.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbLogUserManual.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbLogHowTo
            // 
            this.pbLogHowTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogHowTo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogHowTo.Image")));
            this.pbLogHowTo.Location = new System.Drawing.Point(586, 5);
            this.pbLogHowTo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogHowTo.Name = "pbLogHowTo";
            this.pbLogHowTo.Size = new System.Drawing.Size(54, 67);
            this.pbLogHowTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogHowTo.TabIndex = 49;
            this.pbLogHowTo.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbLogHowTo, "Go to the How to Organize Videos on Hard Disks Manual to get a brief description " +
        "about how a video collection could be organized in general.");
            this.pbLogHowTo.Click += new System.EventHandler(this.PbHowToClick);
            this.pbLogHowTo.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbLogHowTo.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbLogBanner
            // 
            this.pbLogBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbLogBanner.Image")));
            this.pbLogBanner.Location = new System.Drawing.Point(5, 5);
            this.pbLogBanner.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogBanner.Name = "pbLogBanner";
            this.pbLogBanner.Size = new System.Drawing.Size(635, 67);
            this.pbLogBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogBanner.TabIndex = 48;
            this.pbLogBanner.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbLogBanner, "Go to the MFM web site to get additional information or access the forum.");
            this.pbLogBanner.Click += new System.EventHandler(this.PbBannerClick);
            this.pbLogBanner.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbLogBanner.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Location = new System.Drawing.Point(3, 78);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(642, 279);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            this.rtbLog.WordWrap = false;
            this.rtbLog.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
            // 
            // tpSettings
            // 
            this.tpSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tpSettings.Controls.Add(this.cobDoubleClickDefault);
            this.tpSettings.Controls.Add(this.pbSeetingsHowTo);
            this.tpSettings.Controls.Add(this.btnResetSettings);
            this.tpSettings.Controls.Add(this.pbSettingsUserManual);
            this.tpSettings.Controls.Add(this.pbSettingsBanner);
            this.tpSettings.Controls.Add(this.rtbSettings);
            this.tpSettings.Controls.Add(this.gbSettingsNameUnification);
            this.tpSettings.Controls.Add(this.gbSettingsConsideredFiles);
            this.tpSettings.ImageKey = "Settings.gif";
            this.tpSettings.Location = new System.Drawing.Point(4, 29);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(643, 342);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.Leave += new System.EventHandler(this.TpSettingsLeave);
            // 
            // cobDoubleClickDefault
            // 
            this.cobDoubleClickDefault.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.cobDoubleClickDefault.AllowDrop = true;
            this.cobDoubleClickDefault.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cobDoubleClickDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobDoubleClickDefault.FormattingEnabled = true;
            this.cobDoubleClickDefault.Items.AddRange(new object[] {
            "DoubleClick Default",
            "Play",
            "Search Info",
            "Search Download"});
            this.cobDoubleClickDefault.Location = new System.Drawing.Point(8, 291);
            this.cobDoubleClickDefault.Margin = new System.Windows.Forms.Padding(2);
            this.cobDoubleClickDefault.MaxDropDownItems = 15;
            this.cobDoubleClickDefault.Name = "cobDoubleClickDefault";
            this.cobDoubleClickDefault.Size = new System.Drawing.Size(122, 21);
            this.cobDoubleClickDefault.TabIndex = 45;
            this.cobDoubleClickDefault.Text = "DoubleClick Default";
            this.ttMovieFileMerger.SetToolTip(this.cobDoubleClickDefault, "Select a predefined Tool Tip Regex,\r\nfor the Select, Bin, or Wish actions.");
            // 
            // pbSeetingsHowTo
            // 
            this.pbSeetingsHowTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSeetingsHowTo.Image = ((System.Drawing.Image)(resources.GetObject("pbSeetingsHowTo.Image")));
            this.pbSeetingsHowTo.Location = new System.Drawing.Point(586, 5);
            this.pbSeetingsHowTo.Margin = new System.Windows.Forms.Padding(2);
            this.pbSeetingsHowTo.Name = "pbSeetingsHowTo";
            this.pbSeetingsHowTo.Size = new System.Drawing.Size(54, 67);
            this.pbSeetingsHowTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeetingsHowTo.TabIndex = 46;
            this.pbSeetingsHowTo.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbSeetingsHowTo, "Go to the How to Organize Videos on Hard Disks Manual to get a brief description " +
        "about how a video collection could be organized in general.");
            this.pbSeetingsHowTo.Click += new System.EventHandler(this.PbHowToClick);
            this.pbSeetingsHowTo.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbSeetingsHowTo.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSettings.Location = new System.Drawing.Point(518, 291);
            this.btnResetSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(122, 21);
            this.btnResetSettings.TabIndex = 39;
            this.btnResetSettings.Text = "Reset All Settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.BtnResetSettingsClick);
            // 
            // pbSettingsUserManual
            // 
            this.pbSettingsUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbSettingsUserManual.Image")));
            this.pbSettingsUserManual.Location = new System.Drawing.Point(4, 5);
            this.pbSettingsUserManual.Margin = new System.Windows.Forms.Padding(2);
            this.pbSettingsUserManual.Name = "pbSettingsUserManual";
            this.pbSettingsUserManual.Size = new System.Drawing.Size(54, 67);
            this.pbSettingsUserManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettingsUserManual.TabIndex = 48;
            this.pbSettingsUserManual.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbSettingsUserManual, "Go To the MFM User Manual to read more details about how to use MFM.");
            this.pbSettingsUserManual.Click += new System.EventHandler(this.PbUserManualClick);
            this.pbSettingsUserManual.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbSettingsUserManual.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbSettingsBanner
            // 
            this.pbSettingsBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSettingsBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbSettingsBanner.Image")));
            this.pbSettingsBanner.Location = new System.Drawing.Point(5, 5);
            this.pbSettingsBanner.Margin = new System.Windows.Forms.Padding(2);
            this.pbSettingsBanner.Name = "pbSettingsBanner";
            this.pbSettingsBanner.Size = new System.Drawing.Size(635, 67);
            this.pbSettingsBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettingsBanner.TabIndex = 47;
            this.pbSettingsBanner.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbSettingsBanner, "Go to the MFM web site to get additional information or access the forum.");
            this.pbSettingsBanner.Click += new System.EventHandler(this.PbBannerClick);
            this.pbSettingsBanner.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbSettingsBanner.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // rtbSettings
            // 
            this.rtbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSettings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSettings.Location = new System.Drawing.Point(6, 317);
            this.rtbSettings.Name = "rtbSettings";
            this.rtbSettings.ReadOnly = true;
            this.rtbSettings.Size = new System.Drawing.Size(636, 25);
            this.rtbSettings.TabIndex = 3;
            this.rtbSettings.TabStop = false;
            this.rtbSettings.Text = "";
            this.rtbSettings.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LinkClicked);
            this.rtbSettings.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
            // 
            // gbSettingsNameUnification
            // 
            this.gbSettingsNameUnification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettingsNameUnification.Controls.Add(this.lblBadMovieNameRegex);
            this.gbSettingsNameUnification.Controls.Add(this.tbBadMovieNameRegex);
            this.gbSettingsNameUnification.Controls.Add(this.lblGoodMovieNameRegex);
            this.gbSettingsNameUnification.Controls.Add(this.tbGoodMovieNameRegex);
            this.gbSettingsNameUnification.Controls.Add(this.lblBadEpisodeNameRegex);
            this.gbSettingsNameUnification.Controls.Add(this.tbBadEpisodeNameRegex);
            this.gbSettingsNameUnification.Controls.Add(this.lblGoodEpisodeNameRegex);
            this.gbSettingsNameUnification.Controls.Add(this.tbGoodEpisodeNameRegex);
            this.gbSettingsNameUnification.Controls.Add(this.lblBadDocuNameRegex);
            this.gbSettingsNameUnification.Controls.Add(this.tbBadDocuNameRegex);
            this.gbSettingsNameUnification.Controls.Add(this.lblGoodDocuNameRegex);
            this.gbSettingsNameUnification.Controls.Add(this.tbGoodDocuNameRegex);
            this.gbSettingsNameUnification.Controls.Add(this.lblToLowerRegex);
            this.gbSettingsNameUnification.Controls.Add(this.tbToLowerRegex);
            this.gbSettingsNameUnification.Controls.Add(this.lblOnlyCharacters);
            this.gbSettingsNameUnification.Controls.Add(this.tbOnlyCharactersRegex);
            this.gbSettingsNameUnification.Controls.Add(this.lblEpisodesId);
            this.gbSettingsNameUnification.Controls.Add(this.tbEpisodesIdRegex);
            this.gbSettingsNameUnification.Controls.Add(this.lblCutNameBeforeRegex);
            this.gbSettingsNameUnification.Controls.Add(this.tbCutNameBeforeRegex);
            this.gbSettingsNameUnification.Location = new System.Drawing.Point(5, 128);
            this.gbSettingsNameUnification.Name = "gbSettingsNameUnification";
            this.gbSettingsNameUnification.Size = new System.Drawing.Size(634, 158);
            this.gbSettingsNameUnification.TabIndex = 20;
            this.gbSettingsNameUnification.TabStop = false;
            this.gbSettingsNameUnification.Text = "Name Unification Regular Expressions";
            this.ttMovieFileMerger.SetToolTip(this.gbSettingsNameUnification, "Name Unification Regular Expressions are used to standardize and cleanup the name" +
        "s as much as possible.");
            // 
            // lblBadMovieNameRegex
            // 
            this.lblBadMovieNameRegex.Location = new System.Drawing.Point(321, 135);
            this.lblBadMovieNameRegex.Name = "lblBadMovieNameRegex";
            this.lblBadMovieNameRegex.Size = new System.Drawing.Size(102, 15);
            this.lblBadMovieNameRegex.TabIndex = 38;
            this.lblBadMovieNameRegex.Text = "Bad Movie Name";
            this.ttMovieFileMerger.SetToolTip(this.lblBadMovieNameRegex, resources.GetString("lblBadMovieNameRegex.ToolTip"));
            // 
            // tbBadMovieNameRegex
            // 
            this.tbBadMovieNameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBadMovieNameRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbBadMovieNameRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBadMovieNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBadMovieNameRegex.Location = new System.Drawing.Point(429, 135);
            this.tbBadMovieNameRegex.Name = "tbBadMovieNameRegex";
            this.tbBadMovieNameRegex.Size = new System.Drawing.Size(199, 13);
            this.tbBadMovieNameRegex.TabIndex = 30;
            this.tbBadMovieNameRegex.Text = "[12]\\d{3}";
            this.ttMovieFileMerger.SetToolTip(this.tbBadMovieNameRegex, resources.GetString("tbBadMovieNameRegex.ToolTip"));
            // 
            // lblGoodMovieNameRegex
            // 
            this.lblGoodMovieNameRegex.Location = new System.Drawing.Point(8, 135);
            this.lblGoodMovieNameRegex.Name = "lblGoodMovieNameRegex";
            this.lblGoodMovieNameRegex.Size = new System.Drawing.Size(119, 15);
            this.lblGoodMovieNameRegex.TabIndex = 36;
            this.lblGoodMovieNameRegex.Text = "Good Movie Name";
            this.ttMovieFileMerger.SetToolTip(this.lblGoodMovieNameRegex, resources.GetString("lblGoodMovieNameRegex.ToolTip"));
            // 
            // tbGoodMovieNameRegex
            // 
            this.tbGoodMovieNameRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbGoodMovieNameRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGoodMovieNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGoodMovieNameRegex.Location = new System.Drawing.Point(132, 135);
            this.tbGoodMovieNameRegex.Name = "tbGoodMovieNameRegex";
            this.tbGoodMovieNameRegex.Size = new System.Drawing.Size(172, 13);
            this.tbGoodMovieNameRegex.TabIndex = 29;
            this.tbGoodMovieNameRegex.Text = ".* \\([12]\\d{3}\\)$";
            this.ttMovieFileMerger.SetToolTip(this.tbGoodMovieNameRegex, resources.GetString("tbGoodMovieNameRegex.ToolTip"));
            // 
            // lblBadEpisodeNameRegex
            // 
            this.lblBadEpisodeNameRegex.Location = new System.Drawing.Point(321, 112);
            this.lblBadEpisodeNameRegex.Name = "lblBadEpisodeNameRegex";
            this.lblBadEpisodeNameRegex.Size = new System.Drawing.Size(102, 15);
            this.lblBadEpisodeNameRegex.TabIndex = 34;
            this.lblBadEpisodeNameRegex.Text = "Bad Episode Name";
            this.ttMovieFileMerger.SetToolTip(this.lblBadEpisodeNameRegex, resources.GetString("lblBadEpisodeNameRegex.ToolTip"));
            // 
            // tbBadEpisodeNameRegex
            // 
            this.tbBadEpisodeNameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBadEpisodeNameRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbBadEpisodeNameRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBadEpisodeNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBadEpisodeNameRegex.Location = new System.Drawing.Point(429, 112);
            this.tbBadEpisodeNameRegex.Name = "tbBadEpisodeNameRegex";
            this.tbBadEpisodeNameRegex.Size = new System.Drawing.Size(199, 13);
            this.tbBadEpisodeNameRegex.TabIndex = 28;
            this.tbBadEpisodeNameRegex.Text = "[Ss]\\d{1,2}[Ee]\\d{1,2}";
            this.ttMovieFileMerger.SetToolTip(this.tbBadEpisodeNameRegex, resources.GetString("tbBadEpisodeNameRegex.ToolTip"));
            // 
            // lblGoodEpisodeNameRegex
            // 
            this.lblGoodEpisodeNameRegex.Location = new System.Drawing.Point(8, 112);
            this.lblGoodEpisodeNameRegex.Name = "lblGoodEpisodeNameRegex";
            this.lblGoodEpisodeNameRegex.Size = new System.Drawing.Size(119, 15);
            this.lblGoodEpisodeNameRegex.TabIndex = 32;
            this.lblGoodEpisodeNameRegex.Text = "Good Episode Name";
            this.ttMovieFileMerger.SetToolTip(this.lblGoodEpisodeNameRegex, resources.GetString("lblGoodEpisodeNameRegex.ToolTip"));
            // 
            // tbGoodEpisodeNameRegex
            // 
            this.tbGoodEpisodeNameRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbGoodEpisodeNameRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGoodEpisodeNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGoodEpisodeNameRegex.Location = new System.Drawing.Point(132, 112);
            this.tbGoodEpisodeNameRegex.Name = "tbGoodEpisodeNameRegex";
            this.tbGoodEpisodeNameRegex.Size = new System.Drawing.Size(172, 13);
            this.tbGoodEpisodeNameRegex.TabIndex = 27;
            this.tbGoodEpisodeNameRegex.Text = ".* S\\d{2}E\\d{2}(-E\\d{2})? .*$";
            this.ttMovieFileMerger.SetToolTip(this.tbGoodEpisodeNameRegex, resources.GetString("tbGoodEpisodeNameRegex.ToolTip"));
            // 
            // lblBadDocuNameRegex
            // 
            this.lblBadDocuNameRegex.Location = new System.Drawing.Point(321, 89);
            this.lblBadDocuNameRegex.Name = "lblBadDocuNameRegex";
            this.lblBadDocuNameRegex.Size = new System.Drawing.Size(102, 15);
            this.lblBadDocuNameRegex.TabIndex = 30;
            this.lblBadDocuNameRegex.Text = "Bad Docu Name";
            this.ttMovieFileMerger.SetToolTip(this.lblBadDocuNameRegex, resources.GetString("lblBadDocuNameRegex.ToolTip"));
            // 
            // tbBadDocuNameRegex
            // 
            this.tbBadDocuNameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBadDocuNameRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbBadDocuNameRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBadDocuNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBadDocuNameRegex.Location = new System.Drawing.Point(429, 88);
            this.tbBadDocuNameRegex.Name = "tbBadDocuNameRegex";
            this.tbBadDocuNameRegex.Size = new System.Drawing.Size(199, 13);
            this.tbBadDocuNameRegex.TabIndex = 26;
            this.tbBadDocuNameRegex.Text = "[Ss][12]\\d{3}[Ee]\\d{1,3}";
            this.ttMovieFileMerger.SetToolTip(this.tbBadDocuNameRegex, resources.GetString("tbBadDocuNameRegex.ToolTip"));
            // 
            // lblGoodDocuNameRegex
            // 
            this.lblGoodDocuNameRegex.Location = new System.Drawing.Point(8, 89);
            this.lblGoodDocuNameRegex.Name = "lblGoodDocuNameRegex";
            this.lblGoodDocuNameRegex.Size = new System.Drawing.Size(119, 15);
            this.lblGoodDocuNameRegex.TabIndex = 28;
            this.lblGoodDocuNameRegex.Text = "Good Docu Name";
            this.ttMovieFileMerger.SetToolTip(this.lblGoodDocuNameRegex, resources.GetString("lblGoodDocuNameRegex.ToolTip"));
            // 
            // tbGoodDocuNameRegex
            // 
            this.tbGoodDocuNameRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbGoodDocuNameRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGoodDocuNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGoodDocuNameRegex.Location = new System.Drawing.Point(132, 88);
            this.tbGoodDocuNameRegex.Name = "tbGoodDocuNameRegex";
            this.tbGoodDocuNameRegex.Size = new System.Drawing.Size(172, 13);
            this.tbGoodDocuNameRegex.TabIndex = 25;
            this.tbGoodDocuNameRegex.Text = ".* S[12]\\d{3}E\\d{1,3} .*$";
            this.ttMovieFileMerger.SetToolTip(this.tbGoodDocuNameRegex, resources.GetString("tbGoodDocuNameRegex.ToolTip"));
            // 
            // lblToLowerRegex
            // 
            this.lblToLowerRegex.Location = new System.Drawing.Point(8, 44);
            this.lblToLowerRegex.Name = "lblToLowerRegex";
            this.lblToLowerRegex.Size = new System.Drawing.Size(108, 21);
            this.lblToLowerRegex.TabIndex = 26;
            this.lblToLowerRegex.Text = "Convert to Lower";
            this.ttMovieFileMerger.SetToolTip(this.lblToLowerRegex, resources.GetString("lblToLowerRegex.ToolTip"));
            // 
            // tbToLowerRegex
            // 
            this.tbToLowerRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbToLowerRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbToLowerRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbToLowerRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToLowerRegex.Location = new System.Drawing.Point(132, 43);
            this.tbToLowerRegex.Multiline = true;
            this.tbToLowerRegex.Name = "tbToLowerRegex";
            this.tbToLowerRegex.Size = new System.Drawing.Size(496, 13);
            this.tbToLowerRegex.TabIndex = 22;
            this.tbToLowerRegex.Text = " On | A | The | Of | And | Or | To | From | For | In | As | At | With";
            this.ttMovieFileMerger.SetToolTip(this.tbToLowerRegex, resources.GetString("tbToLowerRegex.ToolTip"));
            // 
            // lblOnlyCharacters
            // 
            this.lblOnlyCharacters.Location = new System.Drawing.Point(321, 65);
            this.lblOnlyCharacters.Name = "lblOnlyCharacters";
            this.lblOnlyCharacters.Size = new System.Drawing.Size(102, 21);
            this.lblOnlyCharacters.TabIndex = 24;
            this.lblOnlyCharacters.Text = "Only Characters";
            this.ttMovieFileMerger.SetToolTip(this.lblOnlyCharacters, resources.GetString("lblOnlyCharacters.ToolTip"));
            // 
            // tbOnlyCharactersRegex
            // 
            this.tbOnlyCharactersRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOnlyCharactersRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbOnlyCharactersRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOnlyCharactersRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOnlyCharactersRegex.Location = new System.Drawing.Point(429, 65);
            this.tbOnlyCharactersRegex.Name = "tbOnlyCharactersRegex";
            this.tbOnlyCharactersRegex.Size = new System.Drawing.Size(199, 13);
            this.tbOnlyCharactersRegex.TabIndex = 24;
            this.tbOnlyCharactersRegex.Text = "[^\\p{L}\\p{N} -\'ก-์]";
            this.ttMovieFileMerger.SetToolTip(this.tbOnlyCharactersRegex, resources.GetString("tbOnlyCharactersRegex.ToolTip"));
            // 
            // lblEpisodesId
            // 
            this.lblEpisodesId.Location = new System.Drawing.Point(8, 65);
            this.lblEpisodesId.Name = "lblEpisodesId";
            this.lblEpisodesId.Size = new System.Drawing.Size(119, 21);
            this.lblEpisodesId.TabIndex = 22;
            this.lblEpisodesId.Text = "Episodes Identification";
            this.ttMovieFileMerger.SetToolTip(this.lblEpisodesId, resources.GetString("lblEpisodesId.ToolTip"));
            // 
            // tbEpisodesIdRegex
            // 
            this.tbEpisodesIdRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbEpisodesIdRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEpisodesIdRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEpisodesIdRegex.Location = new System.Drawing.Point(132, 65);
            this.tbEpisodesIdRegex.Name = "tbEpisodesIdRegex";
            this.tbEpisodesIdRegex.Size = new System.Drawing.Size(172, 13);
            this.tbEpisodesIdRegex.TabIndex = 23;
            this.tbEpisodesIdRegex.Text = ".s\\d+e\\d+";
            this.ttMovieFileMerger.SetToolTip(this.tbEpisodesIdRegex, resources.GetString("tbEpisodesIdRegex.ToolTip"));
            // 
            // lblCutNameBeforeRegex
            // 
            this.lblCutNameBeforeRegex.Location = new System.Drawing.Point(8, 22);
            this.lblCutNameBeforeRegex.Name = "lblCutNameBeforeRegex";
            this.lblCutNameBeforeRegex.Size = new System.Drawing.Size(108, 21);
            this.lblCutNameBeforeRegex.TabIndex = 16;
            this.lblCutNameBeforeRegex.Text = "Cut Name Before";
            this.ttMovieFileMerger.SetToolTip(this.lblCutNameBeforeRegex, "The Cut Name Before regular expression tells MFM what not to include in the name." +
        " \r\nEverything after, including the match itself, will be removed from the item n" +
        "ame.");
            // 
            // tbCutNameBeforeRegex
            // 
            this.tbCutNameBeforeRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCutNameBeforeRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbCutNameBeforeRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCutNameBeforeRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCutNameBeforeRegex.Location = new System.Drawing.Point(132, 21);
            this.tbCutNameBeforeRegex.Name = "tbCutNameBeforeRegex";
            this.tbCutNameBeforeRegex.Size = new System.Drawing.Size(496, 13);
            this.tbCutNameBeforeRegex.TabIndex = 21;
            this.tbCutNameBeforeRegex.Text = "720p|1080p|(cd[12])|x264|aac|divx|xvid";
            this.ttMovieFileMerger.SetToolTip(this.tbCutNameBeforeRegex, "The Cut Name Before regular expression tells MFM what not to include in the name." +
        " \r\nEverything after, including the match itself, will be removed from the item n" +
        "ame.");
            // 
            // gbSettingsConsideredFiles
            // 
            this.gbSettingsConsideredFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettingsConsideredFiles.Controls.Add(this.lblAddonExtensions);
            this.gbSettingsConsideredFiles.Controls.Add(this.tbAddonExtensionsRegex);
            this.gbSettingsConsideredFiles.Controls.Add(this.lblMainExtensions);
            this.gbSettingsConsideredFiles.Controls.Add(this.tbMainExtensionsRegex);
            this.gbSettingsConsideredFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSettingsConsideredFiles.Location = new System.Drawing.Point(5, 78);
            this.gbSettingsConsideredFiles.Name = "gbSettingsConsideredFiles";
            this.gbSettingsConsideredFiles.Size = new System.Drawing.Size(634, 44);
            this.gbSettingsConsideredFiles.TabIndex = 10;
            this.gbSettingsConsideredFiles.TabStop = false;
            this.gbSettingsConsideredFiles.Text = "Considered Files Regular Expressions";
            this.ttMovieFileMerger.SetToolTip(this.gbSettingsConsideredFiles, "Only add the file extensions of files which should be considered.");
            // 
            // lblAddonExtensions
            // 
            this.lblAddonExtensions.Location = new System.Drawing.Point(321, 20);
            this.lblAddonExtensions.Name = "lblAddonExtensions";
            this.lblAddonExtensions.Size = new System.Drawing.Size(126, 19);
            this.lblAddonExtensions.TabIndex = 22;
            this.lblAddonExtensions.Text = "Add-on File Extensions";
            this.ttMovieFileMerger.SetToolTip(this.lblAddonExtensions, "The Add-on Files Extension identified add-on files like subtitles or posters. \r\nA" +
        "dd-on files will be only considered if a main video file exists.");
            // 
            // tbAddonExtensionsRegex
            // 
            this.tbAddonExtensionsRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddonExtensionsRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbAddonExtensionsRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddonExtensionsRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddonExtensionsRegex.Location = new System.Drawing.Point(453, 20);
            this.tbAddonExtensionsRegex.Name = "tbAddonExtensionsRegex";
            this.tbAddonExtensionsRegex.Size = new System.Drawing.Size(175, 13);
            this.tbAddonExtensionsRegex.TabIndex = 12;
            this.tbAddonExtensionsRegex.Text = "srt|sub";
            this.ttMovieFileMerger.SetToolTip(this.tbAddonExtensionsRegex, "The Add-on Files Extension identified add-on files like subtitles or posters. \r\nA" +
        "dd-on files will be only considered if a main video file exists.");
            // 
            // lblMainExtensions
            // 
            this.lblMainExtensions.Location = new System.Drawing.Point(5, 20);
            this.lblMainExtensions.Name = "lblMainExtensions";
            this.lblMainExtensions.Size = new System.Drawing.Size(122, 19);
            this.lblMainExtensions.TabIndex = 20;
            this.lblMainExtensions.Text = "Main File Extensions";
            this.ttMovieFileMerger.SetToolTip(this.lblMainExtensions, "The Main Files Extension regular expression identifies main files. \r\nIf no main f" +
        "ile exists also the add-on files will be ignored.");
            // 
            // tbMainExtensionsRegex
            // 
            this.tbMainExtensionsRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbMainExtensionsRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMainExtensionsRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMainExtensionsRegex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbMainExtensionsRegex.Location = new System.Drawing.Point(132, 20);
            this.tbMainExtensionsRegex.Name = "tbMainExtensionsRegex";
            this.tbMainExtensionsRegex.Size = new System.Drawing.Size(171, 13);
            this.tbMainExtensionsRegex.TabIndex = 11;
            this.tbMainExtensionsRegex.Text = "avi|mkv|mp4";
            this.ttMovieFileMerger.SetToolTip(this.tbMainExtensionsRegex, "The Main Files Extension regular expression identifies main files. \r\nIf no main f" +
        "ile exists also the add-on files will be ignored.");
            // 
            // tpHelp
            // 
            this.tpHelp.BackColor = System.Drawing.SystemColors.Control;
            this.tpHelp.Controls.Add(this.pbInstructionsUserManual);
            this.tpHelp.Controls.Add(this.pbInstructionsHowTo);
            this.tpHelp.Controls.Add(this.pbInstructionsBanner);
            this.tpHelp.Controls.Add(this.rtbHelp);
            this.tpHelp.ImageKey = "Help.gif";
            this.tpHelp.Location = new System.Drawing.Point(4, 29);
            this.tpHelp.Name = "tpHelp";
            this.tpHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tpHelp.Size = new System.Drawing.Size(643, 342);
            this.tpHelp.TabIndex = 4;
            this.tpHelp.Text = "Instructions";
            // 
            // pbInstructionsUserManual
            // 
            this.pbInstructionsUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbInstructionsUserManual.Image")));
            this.pbInstructionsUserManual.Location = new System.Drawing.Point(5, 5);
            this.pbInstructionsUserManual.Margin = new System.Windows.Forms.Padding(2);
            this.pbInstructionsUserManual.Name = "pbInstructionsUserManual";
            this.pbInstructionsUserManual.Size = new System.Drawing.Size(54, 67);
            this.pbInstructionsUserManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInstructionsUserManual.TabIndex = 12;
            this.pbInstructionsUserManual.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbInstructionsUserManual, "Go To the MFM User Manual to read more details about how to use MFM.");
            this.pbInstructionsUserManual.Click += new System.EventHandler(this.PbUserManualClick);
            this.pbInstructionsUserManual.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbInstructionsUserManual.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbInstructionsHowTo
            // 
            this.pbInstructionsHowTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbInstructionsHowTo.Image = ((System.Drawing.Image)(resources.GetObject("pbInstructionsHowTo.Image")));
            this.pbInstructionsHowTo.Location = new System.Drawing.Point(586, 5);
            this.pbInstructionsHowTo.Margin = new System.Windows.Forms.Padding(2);
            this.pbInstructionsHowTo.Name = "pbInstructionsHowTo";
            this.pbInstructionsHowTo.Size = new System.Drawing.Size(54, 67);
            this.pbInstructionsHowTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInstructionsHowTo.TabIndex = 11;
            this.pbInstructionsHowTo.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbInstructionsHowTo, "Go to the How to Organize Videos on Hard Disks Manual to get a brief description " +
        "about how a video collection could be organized in general.");
            this.pbInstructionsHowTo.Click += new System.EventHandler(this.PbHowToClick);
            this.pbInstructionsHowTo.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbInstructionsHowTo.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbInstructionsBanner
            // 
            this.pbInstructionsBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbInstructionsBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbInstructionsBanner.Image")));
            this.pbInstructionsBanner.Location = new System.Drawing.Point(5, 5);
            this.pbInstructionsBanner.Margin = new System.Windows.Forms.Padding(2);
            this.pbInstructionsBanner.Name = "pbInstructionsBanner";
            this.pbInstructionsBanner.Size = new System.Drawing.Size(635, 67);
            this.pbInstructionsBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInstructionsBanner.TabIndex = 7;
            this.pbInstructionsBanner.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbInstructionsBanner, "Go to the MFM web site to get additional information or access the forum.");
            this.pbInstructionsBanner.Click += new System.EventHandler(this.PbBannerClick);
            this.pbInstructionsBanner.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbInstructionsBanner.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // rtbHelp
            // 
            this.rtbHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbHelp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHelp.Location = new System.Drawing.Point(3, 78);
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.ReadOnly = true;
            this.rtbHelp.Size = new System.Drawing.Size(642, 283);
            this.rtbHelp.TabIndex = 0;
            this.rtbHelp.Text = "";
            this.rtbHelp.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LinkClicked);
            this.rtbHelp.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
            // 
            // tpAbout
            // 
            this.tpAbout.BackColor = System.Drawing.SystemColors.Control;
            this.tpAbout.Controls.Add(this.llDonateABeerOrTwo);
            this.tpAbout.Controls.Add(this.llUserFeedbackForum);
            this.tpAbout.Controls.Add(this.llGitHubSourceCode);
            this.tpAbout.Controls.Add(this.pbAboutUserManual);
            this.tpAbout.Controls.Add(this.pbAboutHowTo);
            this.tpAbout.Controls.Add(this.lblLastChecked);
            this.tpAbout.Controls.Add(this.cobCheckForUpdates);
            this.tpAbout.Controls.Add(this.btnCheckNow);
            this.tpAbout.Controls.Add(this.pbAboutBanner);
            this.tpAbout.Controls.Add(this.lblCopyLeft);
            this.tpAbout.Controls.Add(this.rtbCopyright);
            this.tpAbout.Controls.Add(this.lblVersion);
            this.tpAbout.Controls.Add(this.llMovieFileMergerOrg);
            this.tpAbout.ImageKey = "About.gif";
            this.tpAbout.Location = new System.Drawing.Point(4, 29);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(643, 342);
            this.tpAbout.TabIndex = 3;
            this.tpAbout.Text = "About";
            // 
            // llDonateABeerOrTwo
            // 
            this.llDonateABeerOrTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llDonateABeerOrTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDonateABeerOrTwo.Location = new System.Drawing.Point(170, 128);
            this.llDonateABeerOrTwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llDonateABeerOrTwo.Name = "llDonateABeerOrTwo";
            this.llDonateABeerOrTwo.Size = new System.Drawing.Size(304, 26);
            this.llDonateABeerOrTwo.TabIndex = 14;
            this.llDonateABeerOrTwo.TabStop = true;
            this.llDonateABeerOrTwo.Text = "Donate a Beer or Two";
            this.llDonateABeerOrTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttMovieFileMerger.SetToolTip(this.llDonateABeerOrTwo, "Brings you to the MFM Donation page, where you can donate a beer or two for me.");
            this.llDonateABeerOrTwo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDonateABeerOrTwo_LinkClicked);
            // 
            // llUserFeedbackForum
            // 
            this.llUserFeedbackForum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llUserFeedbackForum.Location = new System.Drawing.Point(5, 130);
            this.llUserFeedbackForum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llUserFeedbackForum.Name = "llUserFeedbackForum";
            this.llUserFeedbackForum.Size = new System.Drawing.Size(164, 24);
            this.llUserFeedbackForum.TabIndex = 13;
            this.llUserFeedbackForum.TabStop = true;
            this.llUserFeedbackForum.Text = "User Feedback Forum";
            this.llUserFeedbackForum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttMovieFileMerger.SetToolTip(this.llUserFeedbackForum, "Brings you to the MFM Forum, where you can find Useful tips, give feedback, repor" +
        "t bugs, and so on...");
            this.llUserFeedbackForum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUserFeedbackForum_LinkClicked);
            // 
            // llGitHubSourceCode
            // 
            this.llGitHubSourceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llGitHubSourceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llGitHubSourceCode.Location = new System.Drawing.Point(478, 128);
            this.llGitHubSourceCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llGitHubSourceCode.Name = "llGitHubSourceCode";
            this.llGitHubSourceCode.Size = new System.Drawing.Size(162, 26);
            this.llGitHubSourceCode.TabIndex = 12;
            this.llGitHubSourceCode.TabStop = true;
            this.llGitHubSourceCode.Text = "GitHub Source Code";
            this.llGitHubSourceCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttMovieFileMerger.SetToolTip(this.llGitHubSourceCode, "Brings you to the MFM  GitHub page, where you can Download the source code, give " +
        "feed back about bugs, or just read more about MFM.");
            this.llGitHubSourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGitHubSourceCode_LinkClicked);
            // 
            // pbAboutUserManual
            // 
            this.pbAboutUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbAboutUserManual.Image")));
            this.pbAboutUserManual.Location = new System.Drawing.Point(4, 5);
            this.pbAboutUserManual.Margin = new System.Windows.Forms.Padding(2);
            this.pbAboutUserManual.Name = "pbAboutUserManual";
            this.pbAboutUserManual.Size = new System.Drawing.Size(54, 67);
            this.pbAboutUserManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAboutUserManual.TabIndex = 11;
            this.pbAboutUserManual.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbAboutUserManual, "Go To the MFM User Manual to read more details about how to use MFM.");
            this.pbAboutUserManual.Click += new System.EventHandler(this.PbUserManualClick);
            this.pbAboutUserManual.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbAboutUserManual.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbAboutHowTo
            // 
            this.pbAboutHowTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAboutHowTo.Image = ((System.Drawing.Image)(resources.GetObject("pbAboutHowTo.Image")));
            this.pbAboutHowTo.Location = new System.Drawing.Point(586, 5);
            this.pbAboutHowTo.Margin = new System.Windows.Forms.Padding(2);
            this.pbAboutHowTo.Name = "pbAboutHowTo";
            this.pbAboutHowTo.Size = new System.Drawing.Size(54, 67);
            this.pbAboutHowTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAboutHowTo.TabIndex = 10;
            this.pbAboutHowTo.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbAboutHowTo, "Go to the How to Organize Videos on Hard Disks Manual to get a brief description " +
        "about how a video collection could be organized in general.");
            this.pbAboutHowTo.Click += new System.EventHandler(this.PbHowToClick);
            this.pbAboutHowTo.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbAboutHowTo.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // lblLastChecked
            // 
            this.lblLastChecked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastChecked.Location = new System.Drawing.Point(172, 102);
            this.lblLastChecked.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastChecked.Name = "lblLastChecked";
            this.lblLastChecked.Size = new System.Drawing.Size(302, 26);
            this.lblLastChecked.TabIndex = 9;
            this.lblLastChecked.Text = "Last Checked: Never";
            this.lblLastChecked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttMovieFileMerger.SetToolTip(this.lblLastChecked, "If the version is up to date has been last checked...");
            // 
            // cobCheckForUpdates
            // 
            this.cobCheckForUpdates.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cobCheckForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobCheckForUpdates.FormattingEnabled = true;
            this.cobCheckForUpdates.Items.AddRange(new object[] {
            "Check for updates daily.",
            "Check for updates weekly.",
            "Check for updates monthly."});
            this.cobCheckForUpdates.Location = new System.Drawing.Point(6, 106);
            this.cobCheckForUpdates.Margin = new System.Windows.Forms.Padding(2);
            this.cobCheckForUpdates.Name = "cobCheckForUpdates";
            this.cobCheckForUpdates.Size = new System.Drawing.Size(163, 21);
            this.cobCheckForUpdates.TabIndex = 2;
            this.cobCheckForUpdates.Text = "Check for updates daily.";
            this.ttMovieFileMerger.SetToolTip(this.cobCheckForUpdates, "Change the frequency to check for updates.");
            // 
            // btnCheckNow
            // 
            this.btnCheckNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckNow.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnCheckNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckNow.Location = new System.Drawing.Point(478, 103);
            this.btnCheckNow.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckNow.Name = "btnCheckNow";
            this.btnCheckNow.Size = new System.Drawing.Size(162, 25);
            this.btnCheckNow.TabIndex = 3;
            this.btnCheckNow.Text = "Check for updates now!";
            this.ttMovieFileMerger.SetToolTip(this.btnCheckNow, "Enforces to check for updates immediately.");
            this.btnCheckNow.UseVisualStyleBackColor = true;
            this.btnCheckNow.Click += new System.EventHandler(this.BtnCheckNowClick);
            // 
            // pbAboutBanner
            // 
            this.pbAboutBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAboutBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbAboutBanner.Image")));
            this.pbAboutBanner.Location = new System.Drawing.Point(4, 5);
            this.pbAboutBanner.Margin = new System.Windows.Forms.Padding(2);
            this.pbAboutBanner.Name = "pbAboutBanner";
            this.pbAboutBanner.Size = new System.Drawing.Size(635, 67);
            this.pbAboutBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAboutBanner.TabIndex = 6;
            this.pbAboutBanner.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbAboutBanner, "Go to the MFM web site to get additional information or access the forum.");
            this.pbAboutBanner.Click += new System.EventHandler(this.PbBannerClick);
            this.pbAboutBanner.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbAboutBanner.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // lblCopyLeft
            // 
            this.lblCopyLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyLeft.Location = new System.Drawing.Point(508, 83);
            this.lblCopyLeft.Name = "lblCopyLeft";
            this.lblCopyLeft.Size = new System.Drawing.Size(134, 15);
            this.lblCopyLeft.TabIndex = 2;
            this.lblCopyLeft.Text = "© 2017 Modi";
            this.lblCopyLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbCopyright
            // 
            this.rtbCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCopyright.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCopyright.Location = new System.Drawing.Point(6, 156);
            this.rtbCopyright.Margin = new System.Windows.Forms.Padding(2);
            this.rtbCopyright.Name = "rtbCopyright";
            this.rtbCopyright.ReadOnly = true;
            this.rtbCopyright.Size = new System.Drawing.Size(642, 224);
            this.rtbCopyright.TabIndex = 4;
            this.rtbCopyright.TabStop = false;
            this.rtbCopyright.Text = "";
            this.rtbCopyright.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LinkClicked);
            this.rtbCopyright.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(6, 83);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(66, 15);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "x.x.x";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llMovieFileMergerOrg
            // 
            this.llMovieFileMergerOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llMovieFileMergerOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llMovieFileMergerOrg.Location = new System.Drawing.Point(5, 73);
            this.llMovieFileMergerOrg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llMovieFileMergerOrg.Name = "llMovieFileMergerOrg";
            this.llMovieFileMergerOrg.Size = new System.Drawing.Size(635, 28);
            this.llMovieFileMergerOrg.TabIndex = 1;
            this.llMovieFileMergerOrg.TabStop = true;
            this.llMovieFileMergerOrg.Text = "www.Movie-File-Merger.org";
            this.llMovieFileMergerOrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttMovieFileMerger.SetToolTip(this.llMovieFileMergerOrg, "Brings you to the MFM homepage, where you can find additional infomration about M" +
        "ovie File Merger.");
            this.llMovieFileMergerOrg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMovieFileMergerOrg_LinkClicked);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.ssMFM);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tcMovieFileMerger);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(651, 375);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(651, 430);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // ssMFM
            // 
            this.ssMFM.Dock = System.Windows.Forms.DockStyle.None;
            this.ssMFM.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssMFM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMFM,
            this.tspbMFM});
            this.ssMFM.Location = new System.Drawing.Point(0, 0);
            this.ssMFM.Name = "ssMFM";
            this.ssMFM.Size = new System.Drawing.Size(651, 30);
            this.ssMFM.TabIndex = 0;
            // 
            // tsslMFM
            // 
            this.tsslMFM.Name = "tsslMFM";
            this.tsslMFM.Size = new System.Drawing.Size(494, 25);
            this.tsslMFM.Spring = true;
            this.tsslMFM.Text = "Welcome to MFM";
            this.tsslMFM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tspbMFM
            // 
            this.tspbMFM.Name = "tspbMFM";
            this.tspbMFM.Size = new System.Drawing.Size(140, 24);
            // 
            // ttMovieFileMerger
            // 
            this.ttMovieFileMerger.AutomaticDelay = 400;
            this.ttMovieFileMerger.AutoPopDelay = 60000;
            this.ttMovieFileMerger.InitialDelay = 400;
            this.ttMovieFileMerger.IsBalloon = true;
            this.ttMovieFileMerger.ReshowDelay = 80;
            this.ttMovieFileMerger.ShowAlways = true;
            // 
            // ofdTeraCopy
            // 
            this.ofdTeraCopy.FileName = "C:\\Program Files\\TeraCopy\\TeraCopy.exe";
            // 
            // MFMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(651, 430);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(638, 469);
            this.Name = "MFMForm";
            this.Text = "Movie File Merger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MfFormClosing);
            this.Shown += new System.EventHandler(this.MfShown);
            this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
            this.tcMovieFileMerger.ResumeLayout(false);
            this.tpSeparateLists.ResumeLayout(false);
            this.gbTypeSelection.ResumeLayout(false);
            this.gbProcessImport.ResumeLayout(false);
            this.scVertical.Panel1.ResumeLayout(false);
            this.scVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scVertical)).EndInit();
            this.scVertical.ResumeLayout(false);
            this.scVerticalRight.Panel1.ResumeLayout(false);
            this.scVerticalRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scVerticalRight)).EndInit();
            this.scVerticalRight.ResumeLayout(false);
            this.scHorizontal.Panel1.ResumeLayout(false);
            this.scHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scHorizontal)).EndInit();
            this.scHorizontal.ResumeLayout(false);
            this.tpMaintenance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMFM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaintenanceUserManual)).EndInit();
            this.scMaintenance.Panel1.ResumeLayout(false);
            this.scMaintenance.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMaintenance)).EndInit();
            this.scMaintenance.ResumeLayout(false);
            this.tpLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogUserManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogHowTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogBanner)).EndInit();
            this.tpSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSeetingsHowTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsUserManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsBanner)).EndInit();
            this.gbSettingsNameUnification.ResumeLayout(false);
            this.gbSettingsNameUnification.PerformLayout();
            this.gbSettingsConsideredFiles.ResumeLayout(false);
            this.gbSettingsConsideredFiles.PerformLayout();
            this.tpHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructionsUserManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructionsHowTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructionsBanner)).EndInit();
            this.tpAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutUserManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutHowTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutBanner)).EndInit();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ssMFM.ResumeLayout(false);
            this.ssMFM.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.ToolTip ttMovieFileMerger;
		private System.Windows.Forms.RichTextBox rtbCopyright;
		//private System.Diagnostics.PerformanceCounter performanceCounter1;
		private System.Windows.Forms.Button btnExportList;
		private System.Windows.Forms.Button btnSearchInfo;
		private System.Windows.Forms.Button btnSearchDownload;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnEraseSelected;
		private System.Windows.Forms.Button btnEraseColor;
		private System.Windows.Forms.TabPage tpSeparateLists;
		private System.Windows.Forms.SplitContainer scVerticalRight;
		private System.Windows.Forms.ListView lvWish;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TabControl tcMovieFileMerger;
		private System.Windows.Forms.TextBox tbAddonExtensionsRegex;
		private System.Windows.Forms.Label lblAddonExtensions;
		private System.Windows.Forms.RadioButton rbAdults;
		private System.Windows.Forms.RadioButton rbMiscellaneous;
		private System.Windows.Forms.GroupBox gbTypeSelection;
		private System.Windows.Forms.GroupBox gbSettingsNameUnification;
		private System.Windows.Forms.TextBox tbToLowerRegex;
		private System.Windows.Forms.Label lblToLowerRegex;
		private System.Windows.Forms.Label lblOnlyCharacters;
		private System.Windows.Forms.TextBox tbOnlyCharactersRegex;
		private System.Windows.Forms.RichTextBox rtbSettings;
		private System.Windows.Forms.ImageList ilMovieFileMerger;
		private System.Windows.Forms.RadioButton rbClips;
		private System.Windows.Forms.RadioButton rbSeries;
		private System.Windows.Forms.RadioButton rbDocumentaries;
		private System.Windows.Forms.RadioButton rbMovies;
		private System.Windows.Forms.ColumnHeader chNameExisting;
		private System.Windows.Forms.ColumnHeader chNameImport;
		private System.Windows.Forms.ColumnHeader chNameGarbage;
		private System.Windows.Forms.GroupBox gbProcessImport;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblCopyLeft;
		private System.Windows.Forms.RichTextBox rtbHelp;
		private System.Windows.Forms.TabPage tpHelp;
		private System.Windows.Forms.TabPage tpAbout;
		private System.Windows.Forms.RichTextBox rtbLog;
		private System.Windows.Forms.TabPage tpLog;
		private System.Windows.Forms.TextBox tbEpisodesIdRegex;
		private System.Windows.Forms.Label lblEpisodesId;
		private System.Windows.Forms.GroupBox gbSettingsConsideredFiles;
		private System.Windows.Forms.TabPage tpSettings;
		private System.Windows.Forms.RadioButton rbCopy;
		private System.Windows.Forms.RadioButton rbMove;
		private System.Windows.Forms.Label lblMainExtensions;
		private System.Windows.Forms.TextBox tbMainExtensionsRegex;
		private System.Windows.Forms.SaveFileDialog sfdMovieFileMerger;
		private System.Windows.Forms.Timer tmrUpdateCounters;
		private System.Windows.Forms.ListView lvGarbage;
		private System.Windows.Forms.Label lblCutNameBeforeRegex;
		private System.Windows.Forms.TextBox tbCutNameBeforeRegex;
		private System.Windows.Forms.FolderBrowserDialog fbdMovieFileMerger;
		private System.Windows.Forms.SplitContainer scVertical;
		private System.Windows.Forms.SplitContainer scHorizontal;
		private System.Windows.Forms.ListView lvExisting;
		private System.Windows.Forms.ListView lvImport;
		private System.Windows.Forms.LinkLabel llMovieFileMergerOrg;
		private System.Windows.Forms.PictureBox pbAboutBanner;
		private System.Windows.Forms.CheckBox cbGetHigherRes;
		private System.Windows.Forms.StatusStrip ssMFM;
		private System.Windows.Forms.ToolStripStatusLabel tsslMFM;
		private System.Windows.Forms.ToolStripProgressBar tspbMFM;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ComboBox cobCheckForUpdates;
		private System.Windows.Forms.Button btnCheckNow;
		private System.Windows.Forms.Label lblLastChecked;
		private System.Windows.Forms.ComboBox cobCriteria;
		private System.Windows.Forms.Button btnAddToWish;
		private System.Windows.Forms.Button btnBin;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnJustRipIt;
		private System.Windows.Forms.Button btnJustScanIt;
		private System.Windows.Forms.TabPage tpMaintenance;
		private System.Windows.Forms.RichTextBox rtbMaintenance;
		private System.Windows.Forms.ListView lvMaintenance;
		private System.Windows.Forms.ColumnHeader chNameMaintenance;
		private System.Windows.Forms.SplitContainer scMaintenance;
		private System.Windows.Forms.Label lblSelect;
		private System.Windows.Forms.Button btnGoodEpisode;
		private System.Windows.Forms.Button btnGoodDocu;
		private System.Windows.Forms.Button btnGoodMovie;
		private System.Windows.Forms.Button btnUnrelatedFile;
		private System.Windows.Forms.Button btnBadEpisode;
		private System.Windows.Forms.Button btnBadName;
		private System.Windows.Forms.Button btnBadDocu;
		private System.Windows.Forms.Button btnBadMovie;
		private System.Windows.Forms.Label lblBadMovieNameRegex;
		private System.Windows.Forms.TextBox tbBadMovieNameRegex;
		private System.Windows.Forms.Label lblGoodMovieNameRegex;
		private System.Windows.Forms.TextBox tbGoodMovieNameRegex;
		private System.Windows.Forms.Label lblBadEpisodeNameRegex;
		private System.Windows.Forms.TextBox tbBadEpisodeNameRegex;
		private System.Windows.Forms.Label lblGoodEpisodeNameRegex;
		private System.Windows.Forms.TextBox tbGoodEpisodeNameRegex;
		private System.Windows.Forms.Label lblBadDocuNameRegex;
		private System.Windows.Forms.TextBox tbBadDocuNameRegex;
		private System.Windows.Forms.Label lblGoodDocuNameRegex;
		private System.Windows.Forms.TextBox tbGoodDocuNameRegex;
		private System.Windows.Forms.PictureBox pbAboutUserManual;
		private System.Windows.Forms.PictureBox pbAboutHowTo;
		private System.Windows.Forms.PictureBox pbInstructionsUserManual;
		private System.Windows.Forms.PictureBox pbInstructionsHowTo;
		private System.Windows.Forms.PictureBox pbInstructionsBanner;
		private System.Windows.Forms.PictureBox pbMaintenanceUserManual;
		private System.Windows.Forms.PictureBox pbLogUserManual;
		private System.Windows.Forms.PictureBox pbLogHowTo;
		private System.Windows.Forms.PictureBox pbLogBanner;
		private System.Windows.Forms.PictureBox pbSeetingsHowTo;
		private System.Windows.Forms.PictureBox pbSettingsUserManual;
		private System.Windows.Forms.PictureBox pbSettingsBanner;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.ComboBox cobSearchDownload;
		private System.Windows.Forms.ComboBox cobSearchInfo;
		private System.Windows.Forms.OpenFileDialog ofdTeraCopy;
		private System.Windows.Forms.Button btnResetSettings;
		private System.Windows.Forms.ComboBox cobDoubleClickDefault;
        private System.Windows.Forms.LinkLabel llDonateABeerOrTwo;
        private System.Windows.Forms.LinkLabel llUserFeedbackForum;
        private System.Windows.Forms.LinkLabel llGitHubSourceCode;
        private System.Windows.Forms.Button btnPlayMaintenance;
        private System.Windows.Forms.Button btnExportListMaintenance;
        private System.Windows.Forms.Button btnSearchDownloadMaintenance;
        private System.Windows.Forms.Button btnSearchInfoMaintenance;
        private System.Windows.Forms.ComboBox cobSearchDownloadMaintenance;
        private System.Windows.Forms.ComboBox cobSearchInfoMaintenance;
        private System.Windows.Forms.PictureBox pbMFM;
        private System.Windows.Forms.ComboBox cobMinimumResolution;
        private System.Windows.Forms.ComboBox cobDownloadCriteria;
    }
}
