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
            this.cobMinimumResolution = new System.Windows.Forms.ComboBox();
            this.cbGetHigherRes = new System.Windows.Forms.CheckBox();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.btnResetColors = new System.Windows.Forms.Button();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.btnColorSelection = new System.Windows.Forms.Button();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.btnInvertSelection = new System.Windows.Forms.Button();
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
            this.scVertical = new System.Windows.Forms.SplitContainer();
            this.lvExisting = new System.Windows.Forms.ListView();
            this.chNameExisting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scVerticalRight = new System.Windows.Forms.SplitContainer();
            this.scHorizontal = new System.Windows.Forms.SplitContainer();
            this.lvWish = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGarbage = new System.Windows.Forms.ListView();
            this.chNameGarbage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scHorizontalRight = new System.Windows.Forms.SplitContainer();
            this.lvImport = new System.Windows.Forms.ListView();
            this.chNameImport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvExport = new System.Windows.Forms.ListView();
            this.chNameExport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cobSearchDownload = new System.Windows.Forms.ComboBox();
            this.cobSearchInfo = new System.Windows.Forms.ComboBox();
            this.pbListsHowTo = new System.Windows.Forms.PictureBox();
            this.pbListsUserManual = new System.Windows.Forms.PictureBox();
            this.cobCollections = new System.Windows.Forms.ComboBox();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.pbLodDonateRight = new System.Windows.Forms.PictureBox();
            this.pbLogDonateLeft = new System.Windows.Forms.PictureBox();
            this.pbLogUserManual = new System.Windows.Forms.PictureBox();
            this.pbLogHowTo = new System.Windows.Forms.PictureBox();
            this.pbLogBanner = new System.Windows.Forms.PictureBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tpMaintenance = new System.Windows.Forms.TabPage();
            this.btnOrphanAddon = new System.Windows.Forms.Button();
            this.BntDeleteUnrelated = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbMaintenanceHowTo = new System.Windows.Forms.PictureBox();
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
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.cobCheckForUpdates = new System.Windows.Forms.ComboBox();
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
            this.tpFTPSucker = new System.Windows.Forms.TabPage();
            this.pbMousePointerMFM = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEraseColorSucker = new System.Windows.Forms.Button();
            this.btnEraseSelcectedSucker = new System.Windows.Forms.Button();
            this.btnBinSelected = new System.Windows.Forms.Button();
            this.btnWishSelected = new System.Windows.Forms.Button();
            this.lblCloudImage = new System.Windows.Forms.Label();
            this.btnBrowseLocalPath = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnColorList = new System.Windows.Forms.Button();
            this.pbFTPSuckerUserManual = new System.Windows.Forms.PictureBox();
            this.pbFTPSuckerHowTo = new System.Windows.Forms.PictureBox();
            this.lblRemotePath = new System.Windows.Forms.Label();
            this.lblRemoteHhost = new System.Windows.Forms.Label();
            this.lblLocalPath = new System.Windows.Forms.Label();
            this.lblPortNumber = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbRemotePath = new System.Windows.Forms.TextBox();
            this.tbLocalPath = new System.Windows.Forms.TextBox();
            this.tbPortNumber = new System.Windows.Forms.TextBox();
            this.tbHostName = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnOpenWinSCP = new System.Windows.Forms.Button();
            this.btnGetRemoteFileNames = new System.Windows.Forms.Button();
            this.scFTPSucker = new System.Windows.Forms.SplitContainer();
            this.lvRemoteFiles = new System.Windows.Forms.ListView();
            this.chRemoteFiles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtbFTPSucker = new System.Windows.Forms.RichTextBox();
            this.btnGetWishedRemoteFiles = new System.Windows.Forms.Button();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.pbGitHubSocialCodingLeft = new System.Windows.Forms.PictureBox();
            this.pbGitHubSocialCoding = new System.Windows.Forms.PictureBox();
            this.pbAboutDonate = new System.Windows.Forms.PictureBox();
            this.pbAboutUserManual = new System.Windows.Forms.PictureBox();
            this.pbAboutHowTo = new System.Windows.Forms.PictureBox();
            this.lblLastChecked = new System.Windows.Forms.Label();
            this.btnCheckNow = new System.Windows.Forms.Button();
            this.pbAboutBanner = new System.Windows.Forms.PictureBox();
            this.lblCopyLeft = new System.Windows.Forms.Label();
            this.rtbCopyright = new System.Windows.Forms.RichTextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ssMFM = new System.Windows.Forms.StatusStrip();
            this.tsslMFM = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbMFM = new System.Windows.Forms.ToolStripProgressBar();
            this.ttMovieFileMerger = new System.Windows.Forms.ToolTip(this.components);
            this.ofdTeraCopy = new System.Windows.Forms.OpenFileDialog();
            this.tcMovieFileMerger.SuspendLayout();
            this.tpSeparateLists.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.scHorizontalRight)).BeginInit();
            this.scHorizontalRight.Panel1.SuspendLayout();
            this.scHorizontalRight.Panel2.SuspendLayout();
            this.scHorizontalRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListsHowTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListsUserManual)).BeginInit();
            this.tpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLodDonateRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogDonateLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogUserManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogHowTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogBanner)).BeginInit();
            this.tpMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaintenanceHowTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaintenanceUserManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMaintenance)).BeginInit();
            this.scMaintenance.Panel1.SuspendLayout();
            this.scMaintenance.Panel2.SuspendLayout();
            this.scMaintenance.SuspendLayout();
            this.tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeetingsHowTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsUserManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsBanner)).BeginInit();
            this.gbSettingsNameUnification.SuspendLayout();
            this.gbSettingsConsideredFiles.SuspendLayout();
            this.tpFTPSucker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMousePointerMFM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFTPSuckerUserManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFTPSuckerHowTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scFTPSucker)).BeginInit();
            this.scFTPSucker.Panel1.SuspendLayout();
            this.scFTPSucker.Panel2.SuspendLayout();
            this.scFTPSucker.SuspendLayout();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHubSocialCodingLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHubSocialCoding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutDonate)).BeginInit();
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
            this.ilMovieFileMerger.Images.SetKeyName(0, "Copy.gif");
            this.ilMovieFileMerger.Images.SetKeyName(1, "Move.gif");
            this.ilMovieFileMerger.Images.SetKeyName(2, "Color.gif");
            this.ilMovieFileMerger.Images.SetKeyName(3, "Erase.gif");
            this.ilMovieFileMerger.Images.SetKeyName(4, "Erase Color.gif");
            this.ilMovieFileMerger.Images.SetKeyName(5, "Folder.gif");
            this.ilMovieFileMerger.Images.SetKeyName(6, "Log.gif");
            this.ilMovieFileMerger.Images.SetKeyName(7, "Save.gif");
            this.ilMovieFileMerger.Images.SetKeyName(8, "Settings.gif");
            this.ilMovieFileMerger.Images.SetKeyName(9, "About.gif");
            this.ilMovieFileMerger.Images.SetKeyName(10, "Help.gif");
            this.ilMovieFileMerger.Images.SetKeyName(11, "MediaInfo.gif");
            this.ilMovieFileMerger.Images.SetKeyName(12, "List.gif");
            this.ilMovieFileMerger.Images.SetKeyName(13, "Play.gif");
            this.ilMovieFileMerger.Images.SetKeyName(14, "Garbage.gif");
            this.ilMovieFileMerger.Images.SetKeyName(15, "Process.gif");
            this.ilMovieFileMerger.Images.SetKeyName(16, "Select.gif");
            this.ilMovieFileMerger.Images.SetKeyName(17, "Wish.png");
            this.ilMovieFileMerger.Images.SetKeyName(18, "Start.gif");
            this.ilMovieFileMerger.Images.SetKeyName(19, "Download.png");
            this.ilMovieFileMerger.Images.SetKeyName(20, "Edit.png");
            this.ilMovieFileMerger.Images.SetKeyName(21, "ftp.png");
            this.ilMovieFileMerger.Images.SetKeyName(22, "DownloadCloud.png");
            this.ilMovieFileMerger.Images.SetKeyName(23, "RemoteNames.png");
            this.ilMovieFileMerger.Images.SetKeyName(24, "WinSCP.png");
            this.ilMovieFileMerger.Images.SetKeyName(25, "InvertSelection.png");
            this.ilMovieFileMerger.Images.SetKeyName(26, "ListFileExchange.png");
            this.ilMovieFileMerger.Images.SetKeyName(27, "Star.png");
            this.ilMovieFileMerger.Images.SetKeyName(28, "Reset.png");
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
            this.tcMovieFileMerger.Controls.Add(this.tpLog);
            this.tcMovieFileMerger.Controls.Add(this.tpMaintenance);
            this.tcMovieFileMerger.Controls.Add(this.tpSettings);
            this.tcMovieFileMerger.Controls.Add(this.tpFTPSucker);
            this.tcMovieFileMerger.Controls.Add(this.tpAbout);
            this.tcMovieFileMerger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMovieFileMerger.ImageList = this.ilMovieFileMerger;
            this.tcMovieFileMerger.Location = new System.Drawing.Point(0, 0);
            this.tcMovieFileMerger.Margin = new System.Windows.Forms.Padding(4);
            this.tcMovieFileMerger.Name = "tcMovieFileMerger";
            this.tcMovieFileMerger.Padding = new System.Drawing.Point(9, 6);
            this.tcMovieFileMerger.SelectedIndex = 0;
            this.tcMovieFileMerger.ShowToolTips = true;
            this.tcMovieFileMerger.Size = new System.Drawing.Size(882, 471);
            this.tcMovieFileMerger.TabIndex = 0;
            this.tcMovieFileMerger.Tag = "Maintenance";
            // 
            // tpSeparateLists
            // 
            this.tpSeparateLists.BackColor = System.Drawing.SystemColors.Control;
            this.tpSeparateLists.Controls.Add(this.cobCollections);
            this.tpSeparateLists.Controls.Add(this.cobMinimumResolution);
            this.tpSeparateLists.Controls.Add(this.cbGetHigherRes);
            this.tpSeparateLists.Controls.Add(this.rbMove);
            this.tpSeparateLists.Controls.Add(this.btnResetColors);
            this.tpSeparateLists.Controls.Add(this.rbCopy);
            this.tpSeparateLists.Controls.Add(this.btnColorSelection);
            this.tpSeparateLists.Controls.Add(this.btnSelectColor);
            this.tpSeparateLists.Controls.Add(this.btnInvertSelection);
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
            this.tpSeparateLists.Controls.Add(this.scVertical);
            this.tpSeparateLists.Controls.Add(this.cobSearchDownload);
            this.tpSeparateLists.Controls.Add(this.cobSearchInfo);
            this.tpSeparateLists.Controls.Add(this.pbListsHowTo);
            this.tpSeparateLists.Controls.Add(this.pbListsUserManual);
            this.tpSeparateLists.ImageKey = "List.gif";
            this.tpSeparateLists.Location = new System.Drawing.Point(4, 31);
            this.tpSeparateLists.Margin = new System.Windows.Forms.Padding(4);
            this.tpSeparateLists.Name = "tpSeparateLists";
            this.tpSeparateLists.Padding = new System.Windows.Forms.Padding(4);
            this.tpSeparateLists.Size = new System.Drawing.Size(874, 436);
            this.tpSeparateLists.TabIndex = 0;
            this.tpSeparateLists.Text = "Lists";
            // 
            // cobMinimumResolution
            // 
            this.cobMinimumResolution.AllowDrop = true;
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
            this.cobMinimumResolution.Location = new System.Drawing.Point(279, 14);
            this.cobMinimumResolution.Margin = new System.Windows.Forms.Padding(4);
            this.cobMinimumResolution.Name = "cobMinimumResolution";
            this.cobMinimumResolution.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cobMinimumResolution.Size = new System.Drawing.Size(184, 24);
            this.cobMinimumResolution.TabIndex = 26;
            this.ttMovieFileMerger.SetToolTip(this.cobMinimumResolution, resources.GetString("cobMinimumResolution.ToolTip"));
            this.cobMinimumResolution.DragDrop += new System.Windows.Forms.DragEventHandler(this.cobMinimumResolution_DragDrop);
            this.cobMinimumResolution.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // cbGetHigherRes
            // 
            this.cbGetHigherRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGetHigherRes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cbGetHigherRes.Checked = true;
            this.cbGetHigherRes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGetHigherRes.ImageKey = "Folder.gif";
            this.cbGetHigherRes.Location = new System.Drawing.Point(511, 15);
            this.cbGetHigherRes.Margin = new System.Windows.Forms.Padding(4);
            this.cbGetHigherRes.Name = "cbGetHigherRes";
            this.cbGetHigherRes.Size = new System.Drawing.Size(152, 22);
            this.cbGetHigherRes.TabIndex = 25;
            this.cbGetHigherRes.Text = "Higher Resolution";
            this.cbGetHigherRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.cbGetHigherRes, "Check to copy higher horizontal resolution files, even if they are existing alrea" +
        "dy.");
            this.cbGetHigherRes.UseVisualStyleBackColor = false;
            this.cbGetHigherRes.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // rbMove
            // 
            this.rbMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMove.BackColor = System.Drawing.Color.Transparent;
            this.rbMove.ImageKey = "Move.gif";
            this.rbMove.ImageList = this.ilMovieFileMerger;
            this.rbMove.Location = new System.Drawing.Point(671, 9);
            this.rbMove.Margin = new System.Windows.Forms.Padding(4);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(98, 32);
            this.rbMove.TabIndex = 23;
            this.rbMove.Text = "Move";
            this.rbMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.rbMove, "If Move is checked and Start Process is clicked, the Wish colored items \r\nin the " +
        "Import list will be moved to the Target folder.");
            this.rbMove.UseVisualStyleBackColor = false;
            // 
            // btnResetColors
            // 
            this.btnResetColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetColors.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnResetColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetColors.ImageKey = "Reset.png";
            this.btnResetColors.ImageList = this.ilMovieFileMerger;
            this.btnResetColors.Location = new System.Drawing.Point(709, 399);
            this.btnResetColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetColors.Name = "btnResetColors";
            this.btnResetColors.Size = new System.Drawing.Size(37, 32);
            this.btnResetColors.TabIndex = 56;
            this.btnResetColors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetColors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnResetColors, "Reset the colors and selection in all lists.");
            this.btnResetColors.UseVisualStyleBackColor = false;
            this.btnResetColors.Click += new System.EventHandler(this.BtnResetColors_Click);
            // 
            // rbCopy
            // 
            this.rbCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCopy.Checked = true;
            this.rbCopy.ImageKey = "Copy.gif";
            this.rbCopy.ImageList = this.ilMovieFileMerger;
            this.rbCopy.Location = new System.Drawing.Point(779, 9);
            this.rbCopy.Margin = new System.Windows.Forms.Padding(4);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(91, 32);
            this.rbCopy.TabIndex = 22;
            this.rbCopy.TabStop = true;
            this.rbCopy.Text = "Copy";
            this.rbCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.rbCopy, "If Copy is selected and you click Start Process, the Wish colored items \r\nin the " +
        "Import list will be copied to the Target folder.");
            this.rbCopy.UseVisualStyleBackColor = true;
            // 
            // btnColorSelection
            // 
            this.btnColorSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColorSelection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnColorSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorSelection.ImageKey = "Star.png";
            this.btnColorSelection.ImageList = this.ilMovieFileMerger;
            this.btnColorSelection.Location = new System.Drawing.Point(223, 398);
            this.btnColorSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColorSelection.Name = "btnColorSelection";
            this.btnColorSelection.Size = new System.Drawing.Size(37, 32);
            this.btnColorSelection.TabIndex = 55;
            this.btnColorSelection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnColorSelection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnColorSelection, "Star items in all lists according to the selection criteria, which is the same as" +
        " make them yellow.  ;-)");
            this.btnColorSelection.UseVisualStyleBackColor = false;
            this.btnColorSelection.Click += new System.EventHandler(this.BtnColorSelection_Click);
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.AllowDrop = true;
            this.btnSelectColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectColor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelectColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectColor.ImageKey = "Color.gif";
            this.btnSelectColor.ImageList = this.ilMovieFileMerger;
            this.btnSelectColor.Location = new System.Drawing.Point(532, 49);
            this.btnSelectColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(53, 53);
            this.btnSelectColor.TabIndex = 54;
            this.btnSelectColor.TabStop = false;
            this.btnSelectColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnSelectColor, "Drop an item with a color here to select all items of the same color from a list." +
        "");
            this.btnSelectColor.UseVisualStyleBackColor = false;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            this.btnSelectColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnSelectColor_DragDrop);
            this.btnSelectColor.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnInvertSelection
            // 
            this.btnInvertSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInvertSelection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnInvertSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvertSelection.ImageKey = "InvertSelection.png";
            this.btnInvertSelection.ImageList = this.ilMovieFileMerger;
            this.btnInvertSelection.Location = new System.Drawing.Point(180, 399);
            this.btnInvertSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInvertSelection.Name = "btnInvertSelection";
            this.btnInvertSelection.Size = new System.Drawing.Size(37, 32);
            this.btnInvertSelection.TabIndex = 53;
            this.btnInvertSelection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvertSelection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnInvertSelection, "Invert the selection.");
            this.btnInvertSelection.UseVisualStyleBackColor = false;
            this.btnInvertSelection.Click += new System.EventHandler(this.BtnInvertSelection_Click);
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
            this.cobDownloadCriteria.Location = new System.Drawing.Point(216, 60);
            this.cobDownloadCriteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDownloadCriteria.Name = "cobDownloadCriteria";
            this.cobDownloadCriteria.Size = new System.Drawing.Size(23, 24);
            this.cobDownloadCriteria.TabIndex = 49;
            this.cobDownloadCriteria.Text = "1080p";
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
            this.btnPlay.Location = new System.Drawing.Point(593, 49);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(53, 53);
            this.btnPlay.TabIndex = 31;
            this.btnPlay.TabStop = false;
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttMovieFileMerger.SetToolTip(this.btnPlay, "Drop an item here to play it with your movie player.");
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(580, 399);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(37, 32);
            this.btnEdit.TabIndex = 46;
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
            this.btnJustScanIt.Location = new System.Drawing.Point(6, 398);
            this.btnJustScanIt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJustScanIt.Name = "btnJustScanIt";
            this.btnJustScanIt.Size = new System.Drawing.Size(125, 32);
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
            this.btnJustRipIt.Location = new System.Drawing.Point(752, 398);
            this.btnJustRipIt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJustRipIt.Name = "btnJustRipIt";
            this.btnJustRipIt.Size = new System.Drawing.Size(108, 32);
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
            "<699 horizontal (less than 480p)",
            ">699 & <1200 horizontal (between 480p and 720p)",
            ">700 horizontal (480p and greater)",
            ">1000 horizontal (720p and greater)",
            ">1900 horizontal (1080p and greater)",
            ">3800 horizontal (2160p and greater)",
            "2 Channels",
            "6 Channels",
            "Series with \"SxxExx\"",
            "Movies with \"(Year)\"",
            "Main file not existing but drive ready"});
            this.cobCriteria.Location = new System.Drawing.Point(266, 403);
            this.cobCriteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobCriteria.MaxDropDownItems = 15;
            this.cobCriteria.Name = "cobCriteria";
            this.cobCriteria.Size = new System.Drawing.Size(308, 24);
            this.cobCriteria.TabIndex = 44;
            this.cobCriteria.Text = "Select the Search Criteria...";
            this.ttMovieFileMerger.SetToolTip(this.cobCriteria, "Select a predefined Tool Tip Regex, for the Select, Bin, or Wish actions.   Click" +
        " on the small arrow to the right to change the search criteria.");
            this.cobCriteria.TextChanged += new System.EventHandler(this.SettingsChanged);
            this.cobCriteria.DragDrop += new System.Windows.Forms.DragEventHandler(this.CobCriteriaDragDrop);
            this.cobCriteria.DragOver += new System.Windows.Forms.DragEventHandler(this.LvMaintenanceDragDrop);
            // 
            // btnAddToWish
            // 
            this.btnAddToWish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToWish.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddToWish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToWish.ImageKey = "Wish.png";
            this.btnAddToWish.ImageList = this.ilMovieFileMerger;
            this.btnAddToWish.Location = new System.Drawing.Point(623, 399);
            this.btnAddToWish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToWish.Name = "btnAddToWish";
            this.btnAddToWish.Size = new System.Drawing.Size(37, 32);
            this.btnAddToWish.TabIndex = 43;
            this.btnAddToWish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToWish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnAddToWish, "Wish all items in the Import list according to the selection criteria.");
            this.btnAddToWish.UseVisualStyleBackColor = false;
            this.btnAddToWish.Click += new System.EventHandler(this.BtnAddToWishClick);
            // 
            // btnBin
            // 
            this.btnBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBin.ImageKey = "Garbage.gif";
            this.btnBin.ImageList = this.ilMovieFileMerger;
            this.btnBin.Location = new System.Drawing.Point(666, 399);
            this.btnBin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(37, 32);
            this.btnBin.TabIndex = 42;
            this.btnBin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnBin, "Put all items in all lists in the Garbage list according to the selection criteri" +
        "a.");
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
            this.btnSelect.Location = new System.Drawing.Point(137, 399);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(37, 32);
            this.btnSelect.TabIndex = 41;
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnSelect, "Select all items in all lists according to the selection criteria.");
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
            this.btnExportList.Location = new System.Drawing.Point(146, 9);
            this.btnExportList.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(125, 32);
            this.btnExportList.TabIndex = 34;
            this.btnExportList.TabStop = false;
            this.btnExportList.Text = "Export List...";
            this.btnExportList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnExportList, "Drop an item of a list here to export the complete list as an XML file.");
            this.btnExportList.UseVisualStyleBackColor = false;
            this.btnExportList.Click += new System.EventHandler(this.BtnExportList_Click);
            this.btnExportList.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnExportListDragDrop);
            this.btnExportList.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnEraseColor
            // 
            this.btnEraseColor.AllowDrop = true;
            this.btnEraseColor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnEraseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraseColor.ImageKey = "Erase Color.gif";
            this.btnEraseColor.ImageList = this.ilMovieFileMerger;
            this.btnEraseColor.Location = new System.Drawing.Point(307, 49);
            this.btnEraseColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEraseColor.Name = "btnEraseColor";
            this.btnEraseColor.Size = new System.Drawing.Size(53, 53);
            this.btnEraseColor.TabIndex = 28;
            this.btnEraseColor.TabStop = false;
            this.btnEraseColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEraseColor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttMovieFileMerger.SetToolTip(this.btnEraseColor, "Drop an item with a color here to erase all items of the same color from a list.");
            this.btnEraseColor.UseVisualStyleBackColor = false;
            this.btnEraseColor.Click += new System.EventHandler(this.BtnEraseColor_Click);
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
            this.btnSearchDownload.Location = new System.Drawing.Point(79, 48);
            this.btnSearchDownload.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDownload.Name = "btnSearchDownload";
            this.btnSearchDownload.Size = new System.Drawing.Size(137, 53);
            this.btnSearchDownload.TabIndex = 33;
            this.btnSearchDownload.TabStop = false;
            this.btnSearchDownload.Text = "Torrent Hound";
            this.btnSearchDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnSearchDownload, "Drop items here to download them from the internet.  Click on the small arrow to " +
        "the left to change the download site.");
            this.btnSearchDownload.UseVisualStyleBackColor = false;
            this.btnSearchDownload.Click += new System.EventHandler(this.BtnSearchDownload_Click);
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
            this.btnEraseSelected.Location = new System.Drawing.Point(246, 49);
            this.btnEraseSelected.Margin = new System.Windows.Forms.Padding(4);
            this.btnEraseSelected.Name = "btnEraseSelected";
            this.btnEraseSelected.Size = new System.Drawing.Size(53, 53);
            this.btnEraseSelected.TabIndex = 27;
            this.btnEraseSelected.TabStop = false;
            this.btnEraseSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEraseSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnEraseSelected, "Drop items here to erase them from a list.");
            this.btnEraseSelected.UseVisualStyleBackColor = false;
            this.btnEraseSelected.Click += new System.EventHandler(this.BtnEraseSelected_Click);
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
            this.btnSearchInfo.Location = new System.Drawing.Point(654, 49);
            this.btnSearchInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchInfo.Name = "btnSearchInfo";
            this.btnSearchInfo.Size = new System.Drawing.Size(137, 53);
            this.btnSearchInfo.TabIndex = 32;
            this.btnSearchInfo.TabStop = false;
            this.btnSearchInfo.Text = "Adult DVD Empire";
            this.btnSearchInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttMovieFileMerger.SetToolTip(this.btnSearchInfo, "Drop items here to search for them on the internet. Click on the small arrow to t" +
        "he right to change the info site.");
            this.btnSearchInfo.UseVisualStyleBackColor = false;
            this.btnSearchInfo.Click += new System.EventHandler(this.BtnSearchInfo_Click);
            this.btnSearchInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnSearchInfoDragDrop);
            this.btnSearchInfo.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // scVertical
            // 
            this.scVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scVertical.BackColor = System.Drawing.SystemColors.Control;
            this.scVertical.Location = new System.Drawing.Point(8, 110);
            this.scVertical.Margin = new System.Windows.Forms.Padding(4);
            this.scVertical.Name = "scVertical";
            // 
            // scVertical.Panel1
            // 
            this.scVertical.Panel1.Controls.Add(this.lvExisting);
            // 
            // scVertical.Panel2
            // 
            this.scVertical.Panel2.Controls.Add(this.scVerticalRight);
            this.scVertical.Size = new System.Drawing.Size(860, 282);
            this.scVertical.SplitterDistance = 273;
            this.scVertical.SplitterWidth = 5;
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
            this.lvExisting.HideSelection = false;
            this.lvExisting.LabelWrap = false;
            this.lvExisting.Location = new System.Drawing.Point(0, 0);
            this.lvExisting.Margin = new System.Windows.Forms.Padding(4);
            this.lvExisting.Name = "lvExisting";
            this.lvExisting.ShowItemToolTips = true;
            this.lvExisting.Size = new System.Drawing.Size(273, 282);
            this.lvExisting.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvExisting.TabIndex = 0;
            this.lvExisting.TabStop = false;
            this.lvExisting.Tag = "Existing";
            this.lvExisting.UseCompatibleStateImageBehavior = false;
            this.lvExisting.View = System.Windows.Forms.View.Details;
            this.lvExisting.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemsDrag);
            this.lvExisting.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
            this.lvExisting.Click += new System.EventHandler(this.LvClick);
            this.lvExisting.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
            this.lvExisting.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
            this.lvExisting.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
            this.lvExisting.DoubleClick += new System.EventHandler(this.LvDoubleClick);
            this.lvExisting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvKeyDown);
            this.lvExisting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lv_MouseClick);
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
            this.scVerticalRight.Margin = new System.Windows.Forms.Padding(4);
            this.scVerticalRight.Name = "scVerticalRight";
            // 
            // scVerticalRight.Panel1
            // 
            this.scVerticalRight.Panel1.Controls.Add(this.scHorizontal);
            // 
            // scVerticalRight.Panel2
            // 
            this.scVerticalRight.Panel2.Controls.Add(this.scHorizontalRight);
            this.scVerticalRight.Size = new System.Drawing.Size(582, 282);
            this.scVerticalRight.SplitterDistance = 286;
            this.scVerticalRight.SplitterWidth = 5;
            this.scVerticalRight.TabIndex = 1;
            this.scVerticalRight.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ScVerticalSplitterMoved);
            // 
            // scHorizontal
            // 
            this.scHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scHorizontal.Location = new System.Drawing.Point(0, 0);
            this.scHorizontal.Margin = new System.Windows.Forms.Padding(4);
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
            this.scHorizontal.Size = new System.Drawing.Size(286, 282);
            this.scHorizontal.SplitterDistance = 117;
            this.scHorizontal.SplitterWidth = 5;
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
            this.lvWish.HideSelection = false;
            this.lvWish.LabelWrap = false;
            this.lvWish.Location = new System.Drawing.Point(0, 0);
            this.lvWish.Margin = new System.Windows.Forms.Padding(4);
            this.lvWish.Name = "lvWish";
            this.lvWish.ShowItemToolTips = true;
            this.lvWish.Size = new System.Drawing.Size(286, 117);
            this.lvWish.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvWish.TabIndex = 1;
            this.lvWish.TabStop = false;
            this.lvWish.Tag = "Wish";
            this.lvWish.UseCompatibleStateImageBehavior = false;
            this.lvWish.View = System.Windows.Forms.View.Details;
            this.lvWish.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemsDrag);
            this.lvWish.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
            this.lvWish.Click += new System.EventHandler(this.LvClick);
            this.lvWish.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
            this.lvWish.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
            this.lvWish.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
            this.lvWish.DoubleClick += new System.EventHandler(this.LvDoubleClick);
            this.lvWish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvKeyDown);
            this.lvWish.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lv_MouseClick);
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
            this.lvGarbage.HideSelection = false;
            this.lvGarbage.LabelWrap = false;
            this.lvGarbage.Location = new System.Drawing.Point(0, 0);
            this.lvGarbage.Margin = new System.Windows.Forms.Padding(4);
            this.lvGarbage.Name = "lvGarbage";
            this.lvGarbage.ShowItemToolTips = true;
            this.lvGarbage.Size = new System.Drawing.Size(286, 160);
            this.lvGarbage.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvGarbage.TabIndex = 1;
            this.lvGarbage.TabStop = false;
            this.lvGarbage.Tag = "Garbage";
            this.lvGarbage.UseCompatibleStateImageBehavior = false;
            this.lvGarbage.View = System.Windows.Forms.View.Details;
            this.lvGarbage.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemsDrag);
            this.lvGarbage.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
            this.lvGarbage.Click += new System.EventHandler(this.LvClick);
            this.lvGarbage.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
            this.lvGarbage.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
            this.lvGarbage.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
            this.lvGarbage.DoubleClick += new System.EventHandler(this.LvDoubleClick);
            this.lvGarbage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvKeyDown);
            this.lvGarbage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lv_MouseClick);
            this.lvGarbage.MouseEnter += new System.EventHandler(this.LvMouseEnter);
            // 
            // chNameGarbage
            // 
            this.chNameGarbage.Text = "Garbage";
            this.chNameGarbage.Width = 250;
            // 
            // scHorizontalRight
            // 
            this.scHorizontalRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scHorizontalRight.Location = new System.Drawing.Point(0, 0);
            this.scHorizontalRight.Name = "scHorizontalRight";
            this.scHorizontalRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scHorizontalRight.Panel1
            // 
            this.scHorizontalRight.Panel1.Controls.Add(this.lvImport);
            // 
            // scHorizontalRight.Panel2
            // 
            this.scHorizontalRight.Panel2.Controls.Add(this.lvExport);
            this.scHorizontalRight.Size = new System.Drawing.Size(291, 282);
            this.scHorizontalRight.SplitterDistance = 117;
            this.scHorizontalRight.TabIndex = 0;
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
            this.lvImport.HideSelection = false;
            this.lvImport.LabelWrap = false;
            this.lvImport.Location = new System.Drawing.Point(0, 0);
            this.lvImport.Margin = new System.Windows.Forms.Padding(4);
            this.lvImport.Name = "lvImport";
            this.lvImport.ShowItemToolTips = true;
            this.lvImport.Size = new System.Drawing.Size(291, 117);
            this.lvImport.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvImport.TabIndex = 0;
            this.lvImport.TabStop = false;
            this.lvImport.Tag = "Import";
            this.lvImport.TileSize = new System.Drawing.Size(1, 1);
            this.lvImport.UseCompatibleStateImageBehavior = false;
            this.lvImport.View = System.Windows.Forms.View.Details;
            this.lvImport.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemsDrag);
            this.lvImport.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
            this.lvImport.Click += new System.EventHandler(this.LvClick);
            this.lvImport.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
            this.lvImport.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
            this.lvImport.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
            this.lvImport.DoubleClick += new System.EventHandler(this.LvDoubleClick);
            this.lvImport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvKeyDown);
            this.lvImport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lv_MouseClick);
            this.lvImport.MouseEnter += new System.EventHandler(this.LvMouseEnter);
            // 
            // chNameImport
            // 
            this.chNameImport.Text = "Import";
            this.chNameImport.Width = 250;
            // 
            // lvExport
            // 
            this.lvExport.AllowDrop = true;
            this.lvExport.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lvExport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvExport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNameExport});
            this.lvExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExport.FullRowSelect = true;
            this.lvExport.GridLines = true;
            this.lvExport.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvExport.HideSelection = false;
            this.lvExport.LabelWrap = false;
            this.lvExport.Location = new System.Drawing.Point(0, 0);
            this.lvExport.Margin = new System.Windows.Forms.Padding(4);
            this.lvExport.Name = "lvExport";
            this.lvExport.ShowItemToolTips = true;
            this.lvExport.Size = new System.Drawing.Size(291, 161);
            this.lvExport.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvExport.TabIndex = 39;
            this.lvExport.Tag = "Export";
            this.lvExport.TileSize = new System.Drawing.Size(1, 1);
            this.lvExport.UseCompatibleStateImageBehavior = false;
            this.lvExport.View = System.Windows.Forms.View.Details;
            this.lvExport.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvExport_ItemDrag);
            this.lvExport.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
            this.lvExport.Click += new System.EventHandler(this.LvClick);
            this.lvExport.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvExport_DragDrop);
            this.lvExport.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
            this.lvExport.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
            this.lvExport.DoubleClick += new System.EventHandler(this.LvDoubleClick);
            this.lvExport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvKeyDown);
            this.lvExport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lv_MouseClick);
            this.lvExport.MouseEnter += new System.EventHandler(this.LvMouseEnter);
            // 
            // chNameExport
            // 
            this.chNameExport.Text = "Export";
            this.chNameExport.Width = 250;
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
            this.cobSearchDownload.Location = new System.Drawing.Point(59, 60);
            this.cobSearchDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobSearchDownload.Name = "cobSearchDownload";
            this.cobSearchDownload.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cobSearchDownload.Size = new System.Drawing.Size(23, 24);
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
            this.cobSearchInfo.Location = new System.Drawing.Point(790, 61);
            this.cobSearchInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobSearchInfo.Name = "cobSearchInfo";
            this.cobSearchInfo.Size = new System.Drawing.Size(23, 24);
            this.cobSearchInfo.TabIndex = 47;
            this.cobSearchInfo.Text = "IMDb";
            this.ttMovieFileMerger.SetToolTip(this.cobSearchInfo, "Select where to search for additional information concerning the item.");
            this.cobSearchInfo.SelectedIndexChanged += new System.EventHandler(this.CobSearchInfoSelectedIndexChanged);
            // 
            // pbListsHowTo
            // 
            this.pbListsHowTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbListsHowTo.ErrorImage = null;
            this.pbListsHowTo.Image = ((System.Drawing.Image)(resources.GetObject("pbListsHowTo.Image")));
            this.pbListsHowTo.InitialImage = null;
            this.pbListsHowTo.Location = new System.Drawing.Point(819, 47);
            this.pbListsHowTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbListsHowTo.Name = "pbListsHowTo";
            this.pbListsHowTo.Size = new System.Drawing.Size(41, 54);
            this.pbListsHowTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbListsHowTo.TabIndex = 51;
            this.pbListsHowTo.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbListsHowTo, "Go to the online How to Organize Videos on Hard Disks Manual to get a brief descr" +
        "iption of how a video collection could be organized in general.");
            this.pbListsHowTo.Click += new System.EventHandler(this.PbHowToClick);
            this.pbListsHowTo.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbListsHowTo.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbListsUserManual
            // 
            this.pbListsUserManual.ErrorImage = null;
            this.pbListsUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbListsUserManual.Image")));
            this.pbListsUserManual.InitialImage = null;
            this.pbListsUserManual.Location = new System.Drawing.Point(6, 49);
            this.pbListsUserManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbListsUserManual.Name = "pbListsUserManual";
            this.pbListsUserManual.Size = new System.Drawing.Size(47, 53);
            this.pbListsUserManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbListsUserManual.TabIndex = 52;
            this.pbListsUserManual.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbListsUserManual, "Go to the online MFM User Manual to read more details about how to use MFM.");
            this.pbListsUserManual.Click += new System.EventHandler(this.PbUserManualClick);
            this.pbListsUserManual.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbListsUserManual.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // cobCollections
            // 
            this.cobCollections.AutoCompleteCustomSource.AddRange(new string[] {
            "Movies",
            "Series",
            "Documentaries",
            "Miscelaneous",
            "Adults",
            "Clips"});
            this.cobCollections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCollections.FormattingEnabled = true;
            this.cobCollections.Items.AddRange(new object[] {
            "Movies",
            "Series",
            "Documentaries",
            "Miscellaneous",
            "Adult",
            "Clips"});
            this.cobCollections.Location = new System.Drawing.Point(9, 14);
            this.cobCollections.Name = "cobCollections";
            this.cobCollections.Size = new System.Drawing.Size(130, 24);
            this.cobCollections.TabIndex = 17;
            this.ttMovieFileMerger.SetToolTip(this.cobCollections, resources.GetString("cobCollections.ToolTip"));
            this.cobCollections.SelectedIndexChanged += new System.EventHandler(this.CobCollections_SelectedIndexChanged);
            // 
            // tpLog
            // 
            this.tpLog.BackColor = System.Drawing.SystemColors.Control;
            this.tpLog.Controls.Add(this.pbLodDonateRight);
            this.tpLog.Controls.Add(this.pbLogDonateLeft);
            this.tpLog.Controls.Add(this.pbLogUserManual);
            this.tpLog.Controls.Add(this.pbLogHowTo);
            this.tpLog.Controls.Add(this.pbLogBanner);
            this.tpLog.Controls.Add(this.rtbLog);
            this.tpLog.ImageKey = "Log.gif";
            this.tpLog.Location = new System.Drawing.Point(4, 31);
            this.tpLog.Margin = new System.Windows.Forms.Padding(4);
            this.tpLog.Name = "tpLog";
            this.tpLog.Padding = new System.Windows.Forms.Padding(4);
            this.tpLog.Size = new System.Drawing.Size(1054, 684);
            this.tpLog.TabIndex = 2;
            this.tpLog.Text = "Log";
            // 
            // pbLodDonateRight
            // 
            this.pbLodDonateRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLodDonateRight.ErrorImage = null;
            this.pbLodDonateRight.Image = global::Movie_File_Merger.Properties.Resources.DonateButtonLong;
            this.pbLodDonateRight.InitialImage = null;
            this.pbLodDonateRight.Location = new System.Drawing.Point(848, 4);
            this.pbLodDonateRight.Margin = new System.Windows.Forms.Padding(4);
            this.pbLodDonateRight.Name = "pbLodDonateRight";
            this.pbLodDonateRight.Padding = new System.Windows.Forms.Padding(15);
            this.pbLodDonateRight.Size = new System.Drawing.Size(200, 86);
            this.pbLodDonateRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLodDonateRight.TabIndex = 52;
            this.pbLodDonateRight.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbLodDonateRight, "Donate a beer or two for Modi.");
            this.pbLodDonateRight.Click += new System.EventHandler(this.pbDonateClick);
            this.pbLodDonateRight.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbLodDonateRight.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbLogDonateLeft
            // 
            this.pbLogDonateLeft.ErrorImage = null;
            this.pbLogDonateLeft.Image = global::Movie_File_Merger.Properties.Resources.DonateButtonLong;
            this.pbLogDonateLeft.InitialImage = null;
            this.pbLogDonateLeft.Location = new System.Drawing.Point(1, 4);
            this.pbLogDonateLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogDonateLeft.Name = "pbLogDonateLeft";
            this.pbLogDonateLeft.Padding = new System.Windows.Forms.Padding(15);
            this.pbLogDonateLeft.Size = new System.Drawing.Size(200, 86);
            this.pbLogDonateLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogDonateLeft.TabIndex = 51;
            this.pbLogDonateLeft.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbLogDonateLeft, "Donate a beer or two for Modi.");
            this.pbLogDonateLeft.Click += new System.EventHandler(this.pbDonateClick);
            this.pbLogDonateLeft.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbLogDonateLeft.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbLogUserManual
            // 
            this.pbLogUserManual.ErrorImage = null;
            this.pbLogUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbLogUserManual.Image")));
            this.pbLogUserManual.InitialImage = null;
            this.pbLogUserManual.Location = new System.Drawing.Point(8, 96);
            this.pbLogUserManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogUserManual.Name = "pbLogUserManual";
            this.pbLogUserManual.Size = new System.Drawing.Size(138, 186);
            this.pbLogUserManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogUserManual.TabIndex = 50;
            this.pbLogUserManual.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbLogUserManual, "Go To the online MFM User Manual to read more details about how to use MFM.");
            this.pbLogUserManual.Click += new System.EventHandler(this.PbUserManualClick);
            this.pbLogUserManual.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbLogUserManual.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbLogHowTo
            // 
            this.pbLogHowTo.ErrorImage = null;
            this.pbLogHowTo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogHowTo.Image")));
            this.pbLogHowTo.InitialImage = null;
            this.pbLogHowTo.Location = new System.Drawing.Point(8, 286);
            this.pbLogHowTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogHowTo.Name = "pbLogHowTo";
            this.pbLogHowTo.Size = new System.Drawing.Size(138, 178);
            this.pbLogHowTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogHowTo.TabIndex = 49;
            this.pbLogHowTo.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbLogHowTo, "Go to the online How to Organize Videos on Hard Disks Manual to get a brief descr" +
        "iption of how a video collection could be organized in general.");
            this.pbLogHowTo.Click += new System.EventHandler(this.PbHowToClick);
            this.pbLogHowTo.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbLogHowTo.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbLogBanner
            // 
            this.pbLogBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogBanner.ErrorImage = null;
            this.pbLogBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbLogBanner.Image")));
            this.pbLogBanner.InitialImage = null;
            this.pbLogBanner.Location = new System.Drawing.Point(7, 6);
            this.pbLogBanner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogBanner.Name = "pbLogBanner";
            this.pbLogBanner.Size = new System.Drawing.Size(1041, 82);
            this.pbLogBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogBanner.TabIndex = 48;
            this.pbLogBanner.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbLogBanner, "Go to the MFM website to get additional information or access the forum.");
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
            this.rtbLog.Location = new System.Drawing.Point(153, 96);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(4);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(901, 593);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            this.rtbLog.WordWrap = false;
            this.rtbLog.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
            // 
            // tpMaintenance
            // 
            this.tpMaintenance.Controls.Add(this.btnOrphanAddon);
            this.tpMaintenance.Controls.Add(this.BntDeleteUnrelated);
            this.tpMaintenance.Controls.Add(this.pictureBox2);
            this.tpMaintenance.Controls.Add(this.pbMaintenanceHowTo);
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
            this.tpMaintenance.Location = new System.Drawing.Point(4, 31);
            this.tpMaintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpMaintenance.Name = "tpMaintenance";
            this.tpMaintenance.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpMaintenance.Size = new System.Drawing.Size(1054, 684);
            this.tpMaintenance.TabIndex = 5;
            this.tpMaintenance.Text = "Maintenance";
            // 
            // btnOrphanAddon
            // 
            this.btnOrphanAddon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnOrphanAddon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrphanAddon.Location = new System.Drawing.Point(8, 231);
            this.btnOrphanAddon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrphanAddon.Name = "btnOrphanAddon";
            this.btnOrphanAddon.Size = new System.Drawing.Size(132, 26);
            this.btnOrphanAddon.TabIndex = 66;
            this.btnOrphanAddon.Text = "Orphan Addon";
            this.ttMovieFileMerger.SetToolTip(this.btnOrphanAddon, "Select all remaining files with bad names.");
            this.btnOrphanAddon.UseVisualStyleBackColor = true;
            this.btnOrphanAddon.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
            // 
            // BntDeleteUnrelated
            // 
            this.BntDeleteUnrelated.AllowDrop = true;
            this.BntDeleteUnrelated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntDeleteUnrelated.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.BntDeleteUnrelated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntDeleteUnrelated.ImageKey = "Garbage.gif";
            this.BntDeleteUnrelated.ImageList = this.ilMovieFileMerger;
            this.BntDeleteUnrelated.Location = new System.Drawing.Point(930, 7);
            this.BntDeleteUnrelated.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BntDeleteUnrelated.Name = "BntDeleteUnrelated";
            this.BntDeleteUnrelated.Size = new System.Drawing.Size(114, 52);
            this.BntDeleteUnrelated.TabIndex = 65;
            this.BntDeleteUnrelated.Text = "Delete Unrelated";
            this.BntDeleteUnrelated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BntDeleteUnrelated.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.BntDeleteUnrelated, "Permanently delete (not in Recycle Bin) all file marked as unrelated.");
            this.BntDeleteUnrelated.UseVisualStyleBackColor = false;
            this.BntDeleteUnrelated.Click += new System.EventHandler(this.BntDeleteUnrelated_Click);
            this.BntDeleteUnrelated.DragDrop += new System.Windows.Forms.DragEventHandler(this.BntDeleteUnrelated_DragDrop);
            this.BntDeleteUnrelated.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(8, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pictureBox2, "Donate a beer or two for Modi.");
            this.pictureBox2.Click += new System.EventHandler(this.pbDonateClick);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbMaintenanceHowTo
            // 
            this.pbMaintenanceHowTo.ErrorImage = null;
            this.pbMaintenanceHowTo.Image = ((System.Drawing.Image)(resources.GetObject("pbMaintenanceHowTo.Image")));
            this.pbMaintenanceHowTo.InitialImage = null;
            this.pbMaintenanceHowTo.Location = new System.Drawing.Point(8, 587);
            this.pbMaintenanceHowTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMaintenanceHowTo.Name = "pbMaintenanceHowTo";
            this.pbMaintenanceHowTo.Size = new System.Drawing.Size(131, 169);
            this.pbMaintenanceHowTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaintenanceHowTo.TabIndex = 63;
            this.pbMaintenanceHowTo.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbMaintenanceHowTo, "Go to the online How to Organize Videos on Hard Disks Manual to get a brief descr" +
        "iption of how a video collection could be organized in general.");
            this.pbMaintenanceHowTo.Click += new System.EventHandler(this.PbHowToClick);
            this.pbMaintenanceHowTo.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbMaintenanceHowTo.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // btnPlayMaintenance
            // 
            this.btnPlayMaintenance.AllowDrop = true;
            this.btnPlayMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayMaintenance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlayMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayMaintenance.ImageKey = "Play.gif";
            this.btnPlayMaintenance.ImageList = this.ilMovieFileMerger;
            this.btnPlayMaintenance.Location = new System.Drawing.Point(630, 7);
            this.btnPlayMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayMaintenance.Name = "btnPlayMaintenance";
            this.btnPlayMaintenance.Size = new System.Drawing.Size(92, 53);
            this.btnPlayMaintenance.TabIndex = 54;
            this.btnPlayMaintenance.TabStop = false;
            this.btnPlayMaintenance.Text = "Play Video";
            this.btnPlayMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlayMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttMovieFileMerger.SetToolTip(this.btnPlayMaintenance, "Drop an item here to play it with your movie player.");
            this.btnPlayMaintenance.UseVisualStyleBackColor = false;
            this.btnPlayMaintenance.Click += new System.EventHandler(this.BtnPlay_Click);
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
            this.btnExportListMaintenance.Location = new System.Drawing.Point(149, 7);
            this.btnExportListMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportListMaintenance.Name = "btnExportListMaintenance";
            this.btnExportListMaintenance.Size = new System.Drawing.Size(92, 53);
            this.btnExportListMaintenance.TabIndex = 57;
            this.btnExportListMaintenance.TabStop = false;
            this.btnExportListMaintenance.Text = "Export List...";
            this.btnExportListMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportListMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnExportListMaintenance, "Drop an item of a list here to export the complete list as an XML file.");
            this.btnExportListMaintenance.UseVisualStyleBackColor = false;
            this.btnExportListMaintenance.Click += new System.EventHandler(this.BtnExportList_Click);
            this.btnExportListMaintenance.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnEraseColorDragDrop);
            this.btnExportListMaintenance.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnSearchDownloadMaintenance
            // 
            this.btnSearchDownloadMaintenance.AllowDrop = true;
            this.btnSearchDownloadMaintenance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchDownloadMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDownloadMaintenance.ImageKey = "Download.png";
            this.btnSearchDownloadMaintenance.ImageList = this.ilMovieFileMerger;
            this.btnSearchDownloadMaintenance.Location = new System.Drawing.Point(273, 7);
            this.btnSearchDownloadMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDownloadMaintenance.Name = "btnSearchDownloadMaintenance";
            this.btnSearchDownloadMaintenance.Size = new System.Drawing.Size(137, 53);
            this.btnSearchDownloadMaintenance.TabIndex = 56;
            this.btnSearchDownloadMaintenance.TabStop = false;
            this.btnSearchDownloadMaintenance.Text = "Torrent Hound";
            this.btnSearchDownloadMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchDownloadMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnSearchDownloadMaintenance, "Drop items here to download them from the internet.  Click on the small arrow to " +
        "the left to change the download site.");
            this.btnSearchDownloadMaintenance.UseVisualStyleBackColor = false;
            this.btnSearchDownloadMaintenance.Click += new System.EventHandler(this.BtnSearchDownload_Click);
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
            this.btnSearchInfoMaintenance.Location = new System.Drawing.Point(730, 6);
            this.btnSearchInfoMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchInfoMaintenance.Name = "btnSearchInfoMaintenance";
            this.btnSearchInfoMaintenance.Size = new System.Drawing.Size(137, 53);
            this.btnSearchInfoMaintenance.TabIndex = 55;
            this.btnSearchInfoMaintenance.TabStop = false;
            this.btnSearchInfoMaintenance.Text = "Adult DVD Empire";
            this.btnSearchInfoMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchInfoMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttMovieFileMerger.SetToolTip(this.btnSearchInfoMaintenance, "Drop items here to search for them on the internet.  Click on the small arrow to " +
        "the right to change the info site.");
            this.btnSearchInfoMaintenance.UseVisualStyleBackColor = false;
            this.btnSearchInfoMaintenance.Click += new System.EventHandler(this.BtnSearchInfo_Click);
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
            this.cobSearchDownloadMaintenance.Location = new System.Drawing.Point(253, 20);
            this.cobSearchDownloadMaintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobSearchDownloadMaintenance.Name = "cobSearchDownloadMaintenance";
            this.cobSearchDownloadMaintenance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cobSearchDownloadMaintenance.Size = new System.Drawing.Size(23, 24);
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
            this.cobSearchInfoMaintenance.Location = new System.Drawing.Point(867, 18);
            this.cobSearchInfoMaintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobSearchInfoMaintenance.Name = "cobSearchInfoMaintenance";
            this.cobSearchInfoMaintenance.Size = new System.Drawing.Size(23, 24);
            this.cobSearchInfoMaintenance.TabIndex = 58;
            this.cobSearchInfoMaintenance.Text = "IMDb";
            this.ttMovieFileMerger.SetToolTip(this.cobSearchInfoMaintenance, "Select where to search for additional information concerning the item.");
            this.cobSearchInfoMaintenance.SelectedIndexChanged += new System.EventHandler(this.CobSearchInfoSelectedIndexChanged);
            // 
            // pbMaintenanceUserManual
            // 
            this.pbMaintenanceUserManual.ErrorImage = null;
            this.pbMaintenanceUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbMaintenanceUserManual.Image")));
            this.pbMaintenanceUserManual.InitialImage = null;
            this.pbMaintenanceUserManual.Location = new System.Drawing.Point(8, 402);
            this.pbMaintenanceUserManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMaintenanceUserManual.Name = "pbMaintenanceUserManual";
            this.pbMaintenanceUserManual.Size = new System.Drawing.Size(131, 171);
            this.pbMaintenanceUserManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaintenanceUserManual.TabIndex = 51;
            this.pbMaintenanceUserManual.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbMaintenanceUserManual, "Go to the online MFM User Manual to read more details about how to use MFM.");
            this.pbMaintenanceUserManual.Click += new System.EventHandler(this.PbUserManualClick);
            this.pbMaintenanceUserManual.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbMaintenanceUserManual.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // btnGoodEpisode
            // 
            this.btnGoodEpisode.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnGoodEpisode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoodEpisode.Location = new System.Drawing.Point(8, 352);
            this.btnGoodEpisode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoodEpisode.Name = "btnGoodEpisode";
            this.btnGoodEpisode.Size = new System.Drawing.Size(132, 26);
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
            this.btnGoodDocu.Location = new System.Drawing.Point(8, 322);
            this.btnGoodDocu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoodDocu.Name = "btnGoodDocu";
            this.btnGoodDocu.Size = new System.Drawing.Size(132, 26);
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
            this.btnGoodMovie.Location = new System.Drawing.Point(8, 291);
            this.btnGoodMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoodMovie.Name = "btnGoodMovie";
            this.btnGoodMovie.Size = new System.Drawing.Size(132, 26);
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
            this.btnUnrelatedFile.Location = new System.Drawing.Point(8, 261);
            this.btnUnrelatedFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnrelatedFile.Name = "btnUnrelatedFile";
            this.btnUnrelatedFile.Size = new System.Drawing.Size(132, 26);
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
            this.btnBadEpisode.Location = new System.Drawing.Point(8, 171);
            this.btnBadEpisode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBadEpisode.Name = "btnBadEpisode";
            this.btnBadEpisode.Size = new System.Drawing.Size(132, 26);
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
            this.btnBadName.Location = new System.Drawing.Point(8, 201);
            this.btnBadName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBadName.Name = "btnBadName";
            this.btnBadName.Size = new System.Drawing.Size(132, 26);
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
            this.btnBadDocu.Location = new System.Drawing.Point(8, 139);
            this.btnBadDocu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBadDocu.Name = "btnBadDocu";
            this.btnBadDocu.Size = new System.Drawing.Size(132, 26);
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
            this.btnBadMovie.Location = new System.Drawing.Point(8, 110);
            this.btnBadMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBadMovie.Name = "btnBadMovie";
            this.btnBadMovie.Size = new System.Drawing.Size(132, 26);
            this.btnBadMovie.TabIndex = 10;
            this.btnBadMovie.Text = "Bad Movie";
            this.ttMovieFileMerger.SetToolTip(this.btnBadMovie, "Select all movies with bad names.");
            this.btnBadMovie.UseVisualStyleBackColor = true;
            this.btnBadMovie.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoEllipsis = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(9, 85);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(129, 18);
            this.lblSelect.TabIndex = 41;
            this.lblSelect.Text = "Select";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scMaintenance
            // 
            this.scMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMaintenance.Location = new System.Drawing.Point(145, 66);
            this.scMaintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.scMaintenance.Size = new System.Drawing.Size(906, 599);
            this.scMaintenance.SplitterDistance = 377;
            this.scMaintenance.SplitterWidth = 5;
            this.scMaintenance.TabIndex = 39;
            // 
            // lvMaintenance
            // 
            this.lvMaintenance.AllowDrop = true;
            this.lvMaintenance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lvMaintenance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNameMaintenance});
            this.lvMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMaintenance.FullRowSelect = true;
            this.lvMaintenance.GridLines = true;
            this.lvMaintenance.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMaintenance.HideSelection = false;
            this.lvMaintenance.LabelWrap = false;
            this.lvMaintenance.Location = new System.Drawing.Point(1, 1);
            this.lvMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.lvMaintenance.Name = "lvMaintenance";
            this.lvMaintenance.ShowItemToolTips = true;
            this.lvMaintenance.Size = new System.Drawing.Size(904, 375);
            this.lvMaintenance.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvMaintenance.TabIndex = 38;
            this.lvMaintenance.Tag = "Maintenance";
            this.lvMaintenance.TileSize = new System.Drawing.Size(1, 1);
            this.lvMaintenance.UseCompatibleStateImageBehavior = false;
            this.lvMaintenance.View = System.Windows.Forms.View.Details;
            this.lvMaintenance.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvFileListDrag);
            this.lvMaintenance.Click += new System.EventHandler(this.LvClick);
            this.lvMaintenance.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvMaintenanceDragDrop);
            this.lvMaintenance.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
            this.lvMaintenance.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
            this.lvMaintenance.DoubleClick += new System.EventHandler(this.LvMaintenanceDoubleClick);
            this.lvMaintenance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvKeyDown);
            this.lvMaintenance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lv_MouseClick);
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
            this.rtbMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMaintenance.Name = "rtbMaintenance";
            this.rtbMaintenance.ReadOnly = true;
            this.rtbMaintenance.Size = new System.Drawing.Size(906, 217);
            this.rtbMaintenance.TabIndex = 20;
            this.rtbMaintenance.Text = "";
            this.rtbMaintenance.WordWrap = false;
            // 
            // tpSettings
            // 
            this.tpSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tpSettings.Controls.Add(this.cobCheckForUpdates);
            this.tpSettings.Controls.Add(this.cobDoubleClickDefault);
            this.tpSettings.Controls.Add(this.pbSeetingsHowTo);
            this.tpSettings.Controls.Add(this.btnResetSettings);
            this.tpSettings.Controls.Add(this.pbSettingsUserManual);
            this.tpSettings.Controls.Add(this.pbSettingsBanner);
            this.tpSettings.Controls.Add(this.rtbSettings);
            this.tpSettings.Controls.Add(this.gbSettingsNameUnification);
            this.tpSettings.Controls.Add(this.gbSettingsConsideredFiles);
            this.tpSettings.ImageKey = "Settings.gif";
            this.tpSettings.Location = new System.Drawing.Point(4, 31);
            this.tpSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(4);
            this.tpSettings.Size = new System.Drawing.Size(1054, 684);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.Leave += new System.EventHandler(this.TpSettingsLeave);
            // 
            // cobCheckForUpdates
            // 
            this.cobCheckForUpdates.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cobCheckForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobCheckForUpdates.FormattingEnabled = true;
            this.cobCheckForUpdates.Items.AddRange(new object[] {
            "Check for updates daily.",
            "Check for updates weekly.",
            "Check for updates monthly.",
            "Check for updates yearly."});
            this.cobCheckForUpdates.Location = new System.Drawing.Point(179, 359);
            this.cobCheckForUpdates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobCheckForUpdates.Name = "cobCheckForUpdates";
            this.cobCheckForUpdates.Size = new System.Drawing.Size(232, 24);
            this.cobCheckForUpdates.TabIndex = 49;
            this.cobCheckForUpdates.Text = "Check for updates daily.";
            this.ttMovieFileMerger.SetToolTip(this.cobCheckForUpdates, "Change the frequency to check for updates.");
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
            "Play & Info",
            "Play & Download",
            "Play & Info & Download",
            "Search Info",
            "Search Download",
            "Search Info & Download"});
            this.cobDoubleClickDefault.Location = new System.Drawing.Point(11, 358);
            this.cobDoubleClickDefault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDoubleClickDefault.MaxDropDownItems = 15;
            this.cobDoubleClickDefault.Name = "cobDoubleClickDefault";
            this.cobDoubleClickDefault.Size = new System.Drawing.Size(161, 24);
            this.cobDoubleClickDefault.TabIndex = 45;
            this.cobDoubleClickDefault.Text = "DoubleClick Default";
            this.ttMovieFileMerger.SetToolTip(this.cobDoubleClickDefault, "Select a predefined Tool Tip Regex,\r\nfor the Select, Bin, or Wish actions.");
            // 
            // pbSeetingsHowTo
            // 
            this.pbSeetingsHowTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSeetingsHowTo.ErrorImage = null;
            this.pbSeetingsHowTo.Image = ((System.Drawing.Image)(resources.GetObject("pbSeetingsHowTo.Image")));
            this.pbSeetingsHowTo.InitialImage = null;
            this.pbSeetingsHowTo.Location = new System.Drawing.Point(976, 6);
            this.pbSeetingsHowTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSeetingsHowTo.Name = "pbSeetingsHowTo";
            this.pbSeetingsHowTo.Size = new System.Drawing.Size(72, 82);
            this.pbSeetingsHowTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeetingsHowTo.TabIndex = 46;
            this.pbSeetingsHowTo.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbSeetingsHowTo, "Go to the online How to Organize Videos on Hard Disks Manual to get a brief descr" +
        "iption of how a video collection could be organized in general.");
            this.pbSeetingsHowTo.Click += new System.EventHandler(this.PbHowToClick);
            this.pbSeetingsHowTo.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbSeetingsHowTo.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetSettings.ImageKey = "Reset.png";
            this.btnResetSettings.ImageList = this.ilMovieFileMerger;
            this.btnResetSettings.Location = new System.Drawing.Point(885, 358);
            this.btnResetSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(163, 26);
            this.btnResetSettings.TabIndex = 39;
            this.btnResetSettings.Text = "Reset All Settings";
            this.btnResetSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnResetSettings, "Resets all settings to the default values.  If you want to keep the old settings " +
        "make a manual backup first.");
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.BtnResetSettingsClick);
            // 
            // pbSettingsUserManual
            // 
            this.pbSettingsUserManual.ErrorImage = null;
            this.pbSettingsUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbSettingsUserManual.Image")));
            this.pbSettingsUserManual.InitialImage = null;
            this.pbSettingsUserManual.Location = new System.Drawing.Point(5, 6);
            this.pbSettingsUserManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSettingsUserManual.Name = "pbSettingsUserManual";
            this.pbSettingsUserManual.Size = new System.Drawing.Size(72, 82);
            this.pbSettingsUserManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettingsUserManual.TabIndex = 48;
            this.pbSettingsUserManual.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbSettingsUserManual, "Go to the online MFM User Manual to read more details about how to use MFM.");
            this.pbSettingsUserManual.Click += new System.EventHandler(this.PbUserManualClick);
            this.pbSettingsUserManual.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbSettingsUserManual.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbSettingsBanner
            // 
            this.pbSettingsBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSettingsBanner.ErrorImage = null;
            this.pbSettingsBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbSettingsBanner.Image")));
            this.pbSettingsBanner.InitialImage = null;
            this.pbSettingsBanner.Location = new System.Drawing.Point(7, 6);
            this.pbSettingsBanner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSettingsBanner.Name = "pbSettingsBanner";
            this.pbSettingsBanner.Size = new System.Drawing.Size(1041, 82);
            this.pbSettingsBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettingsBanner.TabIndex = 47;
            this.pbSettingsBanner.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbSettingsBanner, "Go to the MFM website to get additional information or access the forum.");
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
            this.rtbSettings.Location = new System.Drawing.Point(8, 507);
            this.rtbSettings.Margin = new System.Windows.Forms.Padding(4);
            this.rtbSettings.Name = "rtbSettings";
            this.rtbSettings.ReadOnly = true;
            this.rtbSettings.Size = new System.Drawing.Size(1042, 163);
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
            this.gbSettingsNameUnification.Location = new System.Drawing.Point(7, 158);
            this.gbSettingsNameUnification.Margin = new System.Windows.Forms.Padding(4);
            this.gbSettingsNameUnification.Name = "gbSettingsNameUnification";
            this.gbSettingsNameUnification.Padding = new System.Windows.Forms.Padding(4);
            this.gbSettingsNameUnification.Size = new System.Drawing.Size(1040, 194);
            this.gbSettingsNameUnification.TabIndex = 20;
            this.gbSettingsNameUnification.TabStop = false;
            this.gbSettingsNameUnification.Text = "Name Unification Regular Expressions";
            this.ttMovieFileMerger.SetToolTip(this.gbSettingsNameUnification, "Name Unification Regular Expressions are used to standardize and cleanup the name" +
        "s as much as possible.");
            // 
            // lblBadMovieNameRegex
            // 
            this.lblBadMovieNameRegex.Location = new System.Drawing.Point(428, 166);
            this.lblBadMovieNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBadMovieNameRegex.Name = "lblBadMovieNameRegex";
            this.lblBadMovieNameRegex.Size = new System.Drawing.Size(136, 18);
            this.lblBadMovieNameRegex.TabIndex = 38;
            this.lblBadMovieNameRegex.Text = "Bad Movie Name";
            this.ttMovieFileMerger.SetToolTip(this.lblBadMovieNameRegex, "The Bad Movie Name regular expression tells MFM if a file name is a bad movie nam" +
        "e.");
            // 
            // tbBadMovieNameRegex
            // 
            this.tbBadMovieNameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBadMovieNameRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbBadMovieNameRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBadMovieNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBadMovieNameRegex.Location = new System.Drawing.Point(572, 166);
            this.tbBadMovieNameRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbBadMovieNameRegex.Name = "tbBadMovieNameRegex";
            this.tbBadMovieNameRegex.Size = new System.Drawing.Size(460, 16);
            this.tbBadMovieNameRegex.TabIndex = 30;
            this.tbBadMovieNameRegex.Text = "[12]\\d{3}";
            this.ttMovieFileMerger.SetToolTip(this.tbBadMovieNameRegex, "The Bad Movie Name regular expression tells MFM if a file name is a bad movie nam" +
        "e.");
            // 
            // lblGoodMovieNameRegex
            // 
            this.lblGoodMovieNameRegex.Location = new System.Drawing.Point(11, 166);
            this.lblGoodMovieNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoodMovieNameRegex.Name = "lblGoodMovieNameRegex";
            this.lblGoodMovieNameRegex.Size = new System.Drawing.Size(159, 18);
            this.lblGoodMovieNameRegex.TabIndex = 36;
            this.lblGoodMovieNameRegex.Text = "Good Movie Name";
            this.ttMovieFileMerger.SetToolTip(this.lblGoodMovieNameRegex, "The Good Movie Name regular expression tells MFM if a file name is a good movie n" +
        "ame.");
            // 
            // tbGoodMovieNameRegex
            // 
            this.tbGoodMovieNameRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbGoodMovieNameRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGoodMovieNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGoodMovieNameRegex.Location = new System.Drawing.Point(176, 166);
            this.tbGoodMovieNameRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbGoodMovieNameRegex.Name = "tbGoodMovieNameRegex";
            this.tbGoodMovieNameRegex.Size = new System.Drawing.Size(229, 16);
            this.tbGoodMovieNameRegex.TabIndex = 29;
            this.tbGoodMovieNameRegex.Text = ".* \\([12]\\d{3}\\)$";
            this.ttMovieFileMerger.SetToolTip(this.tbGoodMovieNameRegex, "The Good Movie Name regular expression tells MFM if a file name is a good movie n" +
        "ame.");
            // 
            // lblBadEpisodeNameRegex
            // 
            this.lblBadEpisodeNameRegex.Location = new System.Drawing.Point(428, 138);
            this.lblBadEpisodeNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBadEpisodeNameRegex.Name = "lblBadEpisodeNameRegex";
            this.lblBadEpisodeNameRegex.Size = new System.Drawing.Size(136, 18);
            this.lblBadEpisodeNameRegex.TabIndex = 34;
            this.lblBadEpisodeNameRegex.Text = "Bad Episode Name";
            this.ttMovieFileMerger.SetToolTip(this.lblBadEpisodeNameRegex, "The Bad Episode Name regular expression tells MFM if a file name is a bad episode" +
        " name.");
            // 
            // tbBadEpisodeNameRegex
            // 
            this.tbBadEpisodeNameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBadEpisodeNameRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbBadEpisodeNameRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBadEpisodeNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBadEpisodeNameRegex.Location = new System.Drawing.Point(572, 138);
            this.tbBadEpisodeNameRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbBadEpisodeNameRegex.Name = "tbBadEpisodeNameRegex";
            this.tbBadEpisodeNameRegex.Size = new System.Drawing.Size(460, 16);
            this.tbBadEpisodeNameRegex.TabIndex = 28;
            this.tbBadEpisodeNameRegex.Text = "[Ss]\\d{1,2}[Ee]\\d{1,2}";
            this.ttMovieFileMerger.SetToolTip(this.tbBadEpisodeNameRegex, "The Bad Episode Name regular expression tells MFM if a file name is a bad episode" +
        " name.");
            // 
            // lblGoodEpisodeNameRegex
            // 
            this.lblGoodEpisodeNameRegex.Location = new System.Drawing.Point(11, 138);
            this.lblGoodEpisodeNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoodEpisodeNameRegex.Name = "lblGoodEpisodeNameRegex";
            this.lblGoodEpisodeNameRegex.Size = new System.Drawing.Size(159, 18);
            this.lblGoodEpisodeNameRegex.TabIndex = 32;
            this.lblGoodEpisodeNameRegex.Text = "Good Episode Name";
            this.ttMovieFileMerger.SetToolTip(this.lblGoodEpisodeNameRegex, "The Good Episode Name regular expression tells MFM if a file name is a good episo" +
        "de name.");
            // 
            // tbGoodEpisodeNameRegex
            // 
            this.tbGoodEpisodeNameRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbGoodEpisodeNameRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGoodEpisodeNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGoodEpisodeNameRegex.Location = new System.Drawing.Point(176, 138);
            this.tbGoodEpisodeNameRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbGoodEpisodeNameRegex.Name = "tbGoodEpisodeNameRegex";
            this.tbGoodEpisodeNameRegex.Size = new System.Drawing.Size(229, 16);
            this.tbGoodEpisodeNameRegex.TabIndex = 27;
            this.tbGoodEpisodeNameRegex.Text = ".* S\\d{2}E\\d{2}(-E\\d{2})? .*$";
            this.ttMovieFileMerger.SetToolTip(this.tbGoodEpisodeNameRegex, "The Good Episode Name regular expression tells MFM if a file name is a good episo" +
        "de name.");
            // 
            // lblBadDocuNameRegex
            // 
            this.lblBadDocuNameRegex.Location = new System.Drawing.Point(428, 110);
            this.lblBadDocuNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBadDocuNameRegex.Name = "lblBadDocuNameRegex";
            this.lblBadDocuNameRegex.Size = new System.Drawing.Size(136, 18);
            this.lblBadDocuNameRegex.TabIndex = 30;
            this.lblBadDocuNameRegex.Text = "Bad Docu Name";
            this.ttMovieFileMerger.SetToolTip(this.lblBadDocuNameRegex, "The Bad Docu Name regular expression tells MFM if a file name is a bad documentat" +
        "ion name.");
            // 
            // tbBadDocuNameRegex
            // 
            this.tbBadDocuNameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBadDocuNameRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbBadDocuNameRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBadDocuNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBadDocuNameRegex.Location = new System.Drawing.Point(572, 108);
            this.tbBadDocuNameRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbBadDocuNameRegex.Name = "tbBadDocuNameRegex";
            this.tbBadDocuNameRegex.Size = new System.Drawing.Size(460, 16);
            this.tbBadDocuNameRegex.TabIndex = 26;
            this.tbBadDocuNameRegex.Text = "[Ss][12]\\d{3}[Ee]\\d{1,3}";
            this.ttMovieFileMerger.SetToolTip(this.tbBadDocuNameRegex, "The Bad Docu Name regular expression tells MFM if a file name is a bad documentat" +
        "ion name.");
            // 
            // lblGoodDocuNameRegex
            // 
            this.lblGoodDocuNameRegex.Location = new System.Drawing.Point(11, 110);
            this.lblGoodDocuNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoodDocuNameRegex.Name = "lblGoodDocuNameRegex";
            this.lblGoodDocuNameRegex.Size = new System.Drawing.Size(159, 18);
            this.lblGoodDocuNameRegex.TabIndex = 28;
            this.lblGoodDocuNameRegex.Text = "Good Docu Name";
            this.ttMovieFileMerger.SetToolTip(this.lblGoodDocuNameRegex, "The Good Docu Name regular expression tells MFM if a file name is a good document" +
        "ation name.");
            // 
            // tbGoodDocuNameRegex
            // 
            this.tbGoodDocuNameRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbGoodDocuNameRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGoodDocuNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGoodDocuNameRegex.Location = new System.Drawing.Point(176, 108);
            this.tbGoodDocuNameRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbGoodDocuNameRegex.Name = "tbGoodDocuNameRegex";
            this.tbGoodDocuNameRegex.Size = new System.Drawing.Size(229, 16);
            this.tbGoodDocuNameRegex.TabIndex = 25;
            this.tbGoodDocuNameRegex.Text = ".* S[12]\\d{3}E\\d{1,3} .*$";
            this.ttMovieFileMerger.SetToolTip(this.tbGoodDocuNameRegex, "The Good Docu Name regular expression tells MFM if a file name is a good document" +
        "ation name.");
            // 
            // lblToLowerRegex
            // 
            this.lblToLowerRegex.Location = new System.Drawing.Point(11, 54);
            this.lblToLowerRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToLowerRegex.Name = "lblToLowerRegex";
            this.lblToLowerRegex.Size = new System.Drawing.Size(144, 26);
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
            this.tbToLowerRegex.Location = new System.Drawing.Point(176, 53);
            this.tbToLowerRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbToLowerRegex.Multiline = true;
            this.tbToLowerRegex.Name = "tbToLowerRegex";
            this.tbToLowerRegex.Size = new System.Drawing.Size(856, 16);
            this.tbToLowerRegex.TabIndex = 22;
            this.tbToLowerRegex.Text = " On | A | The | Of | And | Or | To | From | For | In | As | At | With";
            this.ttMovieFileMerger.SetToolTip(this.tbToLowerRegex, resources.GetString("tbToLowerRegex.ToolTip"));
            // 
            // lblOnlyCharacters
            // 
            this.lblOnlyCharacters.Location = new System.Drawing.Point(428, 80);
            this.lblOnlyCharacters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOnlyCharacters.Name = "lblOnlyCharacters";
            this.lblOnlyCharacters.Size = new System.Drawing.Size(136, 26);
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
            this.tbOnlyCharactersRegex.Location = new System.Drawing.Point(572, 80);
            this.tbOnlyCharactersRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbOnlyCharactersRegex.Name = "tbOnlyCharactersRegex";
            this.tbOnlyCharactersRegex.Size = new System.Drawing.Size(460, 16);
            this.tbOnlyCharactersRegex.TabIndex = 24;
            this.tbOnlyCharactersRegex.Text = "[^\\p{L}\\p{N} -\'ก-์]";
            this.ttMovieFileMerger.SetToolTip(this.tbOnlyCharactersRegex, resources.GetString("tbOnlyCharactersRegex.ToolTip"));
            // 
            // lblEpisodesId
            // 
            this.lblEpisodesId.Location = new System.Drawing.Point(11, 80);
            this.lblEpisodesId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpisodesId.Name = "lblEpisodesId";
            this.lblEpisodesId.Size = new System.Drawing.Size(159, 26);
            this.lblEpisodesId.TabIndex = 22;
            this.lblEpisodesId.Text = "Episodes Identification";
            this.ttMovieFileMerger.SetToolTip(this.lblEpisodesId, resources.GetString("lblEpisodesId.ToolTip"));
            // 
            // tbEpisodesIdRegex
            // 
            this.tbEpisodesIdRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbEpisodesIdRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEpisodesIdRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEpisodesIdRegex.Location = new System.Drawing.Point(176, 80);
            this.tbEpisodesIdRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbEpisodesIdRegex.Name = "tbEpisodesIdRegex";
            this.tbEpisodesIdRegex.Size = new System.Drawing.Size(229, 16);
            this.tbEpisodesIdRegex.TabIndex = 23;
            this.tbEpisodesIdRegex.Text = ".s\\d+e\\d+";
            this.ttMovieFileMerger.SetToolTip(this.tbEpisodesIdRegex, resources.GetString("tbEpisodesIdRegex.ToolTip"));
            // 
            // lblCutNameBeforeRegex
            // 
            this.lblCutNameBeforeRegex.Location = new System.Drawing.Point(11, 27);
            this.lblCutNameBeforeRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCutNameBeforeRegex.Name = "lblCutNameBeforeRegex";
            this.lblCutNameBeforeRegex.Size = new System.Drawing.Size(144, 26);
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
            this.tbCutNameBeforeRegex.Location = new System.Drawing.Point(176, 26);
            this.tbCutNameBeforeRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbCutNameBeforeRegex.Name = "tbCutNameBeforeRegex";
            this.tbCutNameBeforeRegex.Size = new System.Drawing.Size(856, 16);
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
            this.gbSettingsConsideredFiles.Location = new System.Drawing.Point(7, 96);
            this.gbSettingsConsideredFiles.Margin = new System.Windows.Forms.Padding(4);
            this.gbSettingsConsideredFiles.Name = "gbSettingsConsideredFiles";
            this.gbSettingsConsideredFiles.Padding = new System.Windows.Forms.Padding(4);
            this.gbSettingsConsideredFiles.Size = new System.Drawing.Size(1040, 54);
            this.gbSettingsConsideredFiles.TabIndex = 10;
            this.gbSettingsConsideredFiles.TabStop = false;
            this.gbSettingsConsideredFiles.Text = "Considered Files Regular Expressions";
            this.ttMovieFileMerger.SetToolTip(this.gbSettingsConsideredFiles, "Only add the file extensions of files which should be considered.");
            // 
            // lblAddonExtensions
            // 
            this.lblAddonExtensions.Location = new System.Drawing.Point(428, 25);
            this.lblAddonExtensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddonExtensions.Name = "lblAddonExtensions";
            this.lblAddonExtensions.Size = new System.Drawing.Size(168, 23);
            this.lblAddonExtensions.TabIndex = 22;
            this.lblAddonExtensions.Text = "Add-on File Extensions";
            this.ttMovieFileMerger.SetToolTip(this.lblAddonExtensions, "The Add-on Files Extension identified add-on files like subtitles or posters. \r\nA" +
        "dd-on files will be only considered if the main video file exists.");
            // 
            // tbAddonExtensionsRegex
            // 
            this.tbAddonExtensionsRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddonExtensionsRegex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbAddonExtensionsRegex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddonExtensionsRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddonExtensionsRegex.Location = new System.Drawing.Point(604, 25);
            this.tbAddonExtensionsRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddonExtensionsRegex.Name = "tbAddonExtensionsRegex";
            this.tbAddonExtensionsRegex.Size = new System.Drawing.Size(428, 16);
            this.tbAddonExtensionsRegex.TabIndex = 12;
            this.tbAddonExtensionsRegex.Text = "srt|sub";
            this.ttMovieFileMerger.SetToolTip(this.tbAddonExtensionsRegex, "The Add-on Files Extension identified add-on files like subtitles or posters. \r\nA" +
        "dd-on files will be only considered if the main video file exists.");
            // 
            // lblMainExtensions
            // 
            this.lblMainExtensions.Location = new System.Drawing.Point(7, 25);
            this.lblMainExtensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainExtensions.Name = "lblMainExtensions";
            this.lblMainExtensions.Size = new System.Drawing.Size(163, 23);
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
            this.tbMainExtensionsRegex.Location = new System.Drawing.Point(176, 25);
            this.tbMainExtensionsRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbMainExtensionsRegex.Name = "tbMainExtensionsRegex";
            this.tbMainExtensionsRegex.Size = new System.Drawing.Size(228, 16);
            this.tbMainExtensionsRegex.TabIndex = 11;
            this.tbMainExtensionsRegex.Text = "avi|mkv|mp4";
            this.ttMovieFileMerger.SetToolTip(this.tbMainExtensionsRegex, "The Main Files Extension regular expression identifies main files. \r\nIf no main f" +
        "ile exists also the add-on files will be ignored.");
            // 
            // tpFTPSucker
            // 
            this.tpFTPSucker.Controls.Add(this.pbMousePointerMFM);
            this.tpFTPSucker.Controls.Add(this.pictureBox1);
            this.tpFTPSucker.Controls.Add(this.btnEraseColorSucker);
            this.tpFTPSucker.Controls.Add(this.btnEraseSelcectedSucker);
            this.tpFTPSucker.Controls.Add(this.btnBinSelected);
            this.tpFTPSucker.Controls.Add(this.btnWishSelected);
            this.tpFTPSucker.Controls.Add(this.lblCloudImage);
            this.tpFTPSucker.Controls.Add(this.btnBrowseLocalPath);
            this.tpFTPSucker.Controls.Add(this.tbPassword);
            this.tpFTPSucker.Controls.Add(this.btnColorList);
            this.tpFTPSucker.Controls.Add(this.pbFTPSuckerUserManual);
            this.tpFTPSucker.Controls.Add(this.pbFTPSuckerHowTo);
            this.tpFTPSucker.Controls.Add(this.lblRemotePath);
            this.tpFTPSucker.Controls.Add(this.lblRemoteHhost);
            this.tpFTPSucker.Controls.Add(this.lblLocalPath);
            this.tpFTPSucker.Controls.Add(this.lblPortNumber);
            this.tpFTPSucker.Controls.Add(this.lblPassword);
            this.tpFTPSucker.Controls.Add(this.lblHostName);
            this.tpFTPSucker.Controls.Add(this.lblUserName);
            this.tpFTPSucker.Controls.Add(this.tbRemotePath);
            this.tpFTPSucker.Controls.Add(this.tbLocalPath);
            this.tpFTPSucker.Controls.Add(this.tbPortNumber);
            this.tpFTPSucker.Controls.Add(this.tbHostName);
            this.tpFTPSucker.Controls.Add(this.tbUserName);
            this.tpFTPSucker.Controls.Add(this.btnOpenWinSCP);
            this.tpFTPSucker.Controls.Add(this.btnGetRemoteFileNames);
            this.tpFTPSucker.Controls.Add(this.scFTPSucker);
            this.tpFTPSucker.Controls.Add(this.btnGetWishedRemoteFiles);
            this.tpFTPSucker.ImageKey = "ftp.png";
            this.tpFTPSucker.Location = new System.Drawing.Point(4, 31);
            this.tpFTPSucker.Margin = new System.Windows.Forms.Padding(4);
            this.tpFTPSucker.Name = "tpFTPSucker";
            this.tpFTPSucker.Padding = new System.Windows.Forms.Padding(4);
            this.tpFTPSucker.Size = new System.Drawing.Size(1054, 684);
            this.tpFTPSucker.TabIndex = 6;
            this.tpFTPSucker.Text = "FTP Sucker";
            this.tpFTPSucker.UseVisualStyleBackColor = true;
            // 
            // pbMousePointerMFM
            // 
            this.pbMousePointerMFM.BackColor = System.Drawing.Color.Transparent;
            this.pbMousePointerMFM.ErrorImage = null;
            this.pbMousePointerMFM.Image = ((System.Drawing.Image)(resources.GetObject("pbMousePointerMFM.Image")));
            this.pbMousePointerMFM.InitialImage = null;
            this.pbMousePointerMFM.Location = new System.Drawing.Point(40, 542);
            this.pbMousePointerMFM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMousePointerMFM.Name = "pbMousePointerMFM";
            this.pbMousePointerMFM.Size = new System.Drawing.Size(96, 96);
            this.pbMousePointerMFM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMousePointerMFM.TabIndex = 73;
            this.pbMousePointerMFM.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbMousePointerMFM, "Make a small donation for Modi.");
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pictureBox1, "Donate a beer or two for Modi.");
            this.pictureBox1.Click += new System.EventHandler(this.pbDonateClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // btnEraseColorSucker
            // 
            this.btnEraseColorSucker.AllowDrop = true;
            this.btnEraseColorSucker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEraseColorSucker.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnEraseColorSucker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraseColorSucker.ImageKey = "Color.gif";
            this.btnEraseColorSucker.ImageList = this.ilMovieFileMerger;
            this.btnEraseColorSucker.Location = new System.Drawing.Point(708, 7);
            this.btnEraseColorSucker.Margin = new System.Windows.Forms.Padding(4);
            this.btnEraseColorSucker.Name = "btnEraseColorSucker";
            this.btnEraseColorSucker.Size = new System.Drawing.Size(107, 53);
            this.btnEraseColorSucker.TabIndex = 71;
            this.btnEraseColorSucker.TabStop = false;
            this.btnEraseColorSucker.Text = "Erase Color";
            this.btnEraseColorSucker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEraseColorSucker.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttMovieFileMerger.SetToolTip(this.btnEraseColorSucker, "Drop an item with a color here to erase all items of the same color from the list" +
        ".");
            this.btnEraseColorSucker.UseVisualStyleBackColor = false;
            this.btnEraseColorSucker.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnEraseColorDragDrop);
            this.btnEraseColorSucker.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnEraseSelcectedSucker
            // 
            this.btnEraseSelcectedSucker.AllowDrop = true;
            this.btnEraseSelcectedSucker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEraseSelcectedSucker.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnEraseSelcectedSucker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraseSelcectedSucker.ImageKey = "Erase.gif";
            this.btnEraseSelcectedSucker.ImageList = this.ilMovieFileMerger;
            this.btnEraseSelcectedSucker.Location = new System.Drawing.Point(593, 7);
            this.btnEraseSelcectedSucker.Margin = new System.Windows.Forms.Padding(4);
            this.btnEraseSelcectedSucker.Name = "btnEraseSelcectedSucker";
            this.btnEraseSelcectedSucker.Size = new System.Drawing.Size(107, 53);
            this.btnEraseSelcectedSucker.TabIndex = 70;
            this.btnEraseSelcectedSucker.TabStop = false;
            this.btnEraseSelcectedSucker.Text = "Erase Selected";
            this.btnEraseSelcectedSucker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEraseSelcectedSucker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnEraseSelcectedSucker, "Drop items here to erase them from the list.");
            this.btnEraseSelcectedSucker.UseVisualStyleBackColor = false;
            this.btnEraseSelcectedSucker.Click += new System.EventHandler(this.BtnEraseSelcectedSucker_Click);
            this.btnEraseSelcectedSucker.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnEraseSelectedDragDrop);
            this.btnEraseSelcectedSucker.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
            // 
            // btnBinSelected
            // 
            this.btnBinSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBinSelected.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnBinSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBinSelected.ImageKey = "Garbage.gif";
            this.btnBinSelected.ImageList = this.ilMovieFileMerger;
            this.btnBinSelected.Location = new System.Drawing.Point(933, 7);
            this.btnBinSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBinSelected.Name = "btnBinSelected";
            this.btnBinSelected.Size = new System.Drawing.Size(107, 53);
            this.btnBinSelected.TabIndex = 69;
            this.btnBinSelected.Text = "Bin Selected";
            this.btnBinSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBinSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttMovieFileMerger.SetToolTip(this.btnBinSelected, "Put all selected Remote File items in the Garbage list, if they are a main or add" +
        "-on item.");
            this.btnBinSelected.UseVisualStyleBackColor = false;
            this.btnBinSelected.Click += new System.EventHandler(this.BtnBinSelected_Click);
            // 
            // btnWishSelected
            // 
            this.btnWishSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWishSelected.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnWishSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWishSelected.ImageKey = "Wish.png";
            this.btnWishSelected.ImageList = this.ilMovieFileMerger;
            this.btnWishSelected.Location = new System.Drawing.Point(821, 7);
            this.btnWishSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWishSelected.Name = "btnWishSelected";
            this.btnWishSelected.Size = new System.Drawing.Size(107, 53);
            this.btnWishSelected.TabIndex = 68;
            this.btnWishSelected.Text = "Wish Selected";
            this.btnWishSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWishSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnWishSelected, "Wish all selected items in the Remote Files list, if they are a main or add-on it" +
        "em.");
            this.btnWishSelected.UseVisualStyleBackColor = false;
            this.btnWishSelected.Click += new System.EventHandler(this.BtnWishSelected_Click);
            // 
            // lblCloudImage
            // 
            this.lblCloudImage.ImageKey = "ftp.png";
            this.lblCloudImage.ImageList = this.ilMovieFileMerger;
            this.lblCloudImage.Location = new System.Drawing.Point(175, 137);
            this.lblCloudImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCloudImage.Name = "lblCloudImage";
            this.lblCloudImage.Size = new System.Drawing.Size(40, 28);
            this.lblCloudImage.TabIndex = 67;
            // 
            // btnBrowseLocalPath
            // 
            this.btnBrowseLocalPath.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowseLocalPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnBrowseLocalPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseLocalPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowseLocalPath.ImageKey = "Folder.gif";
            this.btnBrowseLocalPath.ImageList = this.ilMovieFileMerger;
            this.btnBrowseLocalPath.Location = new System.Drawing.Point(120, 308);
            this.btnBrowseLocalPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseLocalPath.Name = "btnBrowseLocalPath";
            this.btnBrowseLocalPath.Size = new System.Drawing.Size(95, 28);
            this.btnBrowseLocalPath.TabIndex = 66;
            this.btnBrowseLocalPath.TabStop = false;
            this.btnBrowseLocalPath.Text = "Browse";
            this.btnBrowseLocalPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttMovieFileMerger.SetToolTip(this.btnBrowseLocalPath, "Click to change the local file path.");
            this.btnBrowseLocalPath.UseVisualStyleBackColor = false;
            this.btnBrowseLocalPath.Click += new System.EventHandler(this.BtnBrowseLocalPath_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(139, 235);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = 'X';
            this.tbPassword.Size = new System.Drawing.Size(76, 16);
            this.tbPassword.TabIndex = 60;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttMovieFileMerger.SetToolTip(this.tbPassword, "Enter the password used to connect to the remote host.");
            // 
            // btnColorList
            // 
            this.btnColorList.AllowDrop = true;
            this.btnColorList.BackColor = System.Drawing.SystemColors.Control;
            this.btnColorList.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnColorList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorList.ImageKey = "Color.gif";
            this.btnColorList.ImageList = this.ilMovieFileMerger;
            this.btnColorList.Location = new System.Drawing.Point(221, 7);
            this.btnColorList.Margin = new System.Windows.Forms.Padding(4);
            this.btnColorList.Name = "btnColorList";
            this.btnColorList.Size = new System.Drawing.Size(80, 53);
            this.btnColorList.TabIndex = 65;
            this.btnColorList.TabStop = false;
            this.btnColorList.Text = "Color List";
            this.btnColorList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnColorList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnColorList, "Click here to color the FTP Sucker items according to the Lists tab.");
            this.btnColorList.UseVisualStyleBackColor = false;
            this.btnColorList.Click += new System.EventHandler(this.BtnColorList_Click);
            // 
            // pbFTPSuckerUserManual
            // 
            this.pbFTPSuckerUserManual.ErrorImage = null;
            this.pbFTPSuckerUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbFTPSuckerUserManual.Image")));
            this.pbFTPSuckerUserManual.InitialImage = null;
            this.pbFTPSuckerUserManual.Location = new System.Drawing.Point(13, 418);
            this.pbFTPSuckerUserManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFTPSuckerUserManual.Name = "pbFTPSuckerUserManual";
            this.pbFTPSuckerUserManual.Size = new System.Drawing.Size(87, 105);
            this.pbFTPSuckerUserManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFTPSuckerUserManual.TabIndex = 63;
            this.pbFTPSuckerUserManual.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbFTPSuckerUserManual, "Go to the online MFM User Manual to read more details about how to use MFM.");
            this.pbFTPSuckerUserManual.Click += new System.EventHandler(this.PbUserManualClick);
            this.pbFTPSuckerUserManual.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbFTPSuckerUserManual.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbFTPSuckerHowTo
            // 
            this.pbFTPSuckerHowTo.ErrorImage = null;
            this.pbFTPSuckerHowTo.Image = ((System.Drawing.Image)(resources.GetObject("pbFTPSuckerHowTo.Image")));
            this.pbFTPSuckerHowTo.InitialImage = null;
            this.pbFTPSuckerHowTo.Location = new System.Drawing.Point(117, 418);
            this.pbFTPSuckerHowTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFTPSuckerHowTo.Name = "pbFTPSuckerHowTo";
            this.pbFTPSuckerHowTo.Size = new System.Drawing.Size(87, 105);
            this.pbFTPSuckerHowTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFTPSuckerHowTo.TabIndex = 62;
            this.pbFTPSuckerHowTo.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbFTPSuckerHowTo, "Go to the online How to Organize Videos on Hard Disks Manual to get a brief descr" +
        "iption of how a video collection could be organized in general.");
            this.pbFTPSuckerHowTo.Click += new System.EventHandler(this.PbHowToClick);
            this.pbFTPSuckerHowTo.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbFTPSuckerHowTo.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // lblRemotePath
            // 
            this.lblRemotePath.Location = new System.Drawing.Point(7, 212);
            this.lblRemotePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemotePath.Name = "lblRemotePath";
            this.lblRemotePath.Size = new System.Drawing.Size(43, 16);
            this.lblRemotePath.TabIndex = 61;
            this.lblRemotePath.Text = "Path";
            this.ttMovieFileMerger.SetToolTip(this.lblRemotePath, "Enter the path of the remote host, where to seach for videos.");
            // 
            // lblRemoteHhost
            // 
            this.lblRemoteHhost.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblRemoteHhost.ImageKey = "ftp.png";
            this.lblRemoteHhost.ImageList = this.ilMovieFileMerger;
            this.lblRemoteHhost.Location = new System.Drawing.Point(11, 137);
            this.lblRemoteHhost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoteHhost.Name = "lblRemoteHhost";
            this.lblRemoteHhost.Size = new System.Drawing.Size(204, 25);
            this.lblRemoteHhost.TabIndex = 61;
            this.lblRemoteHhost.Text = "Remote Host";
            this.lblRemoteHhost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttMovieFileMerger.SetToolTip(this.lblRemoteHhost, "The login information for the FTP Remote Host.");
            // 
            // lblLocalPath
            // 
            this.lblLocalPath.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblLocalPath.ImageKey = "Folder.gif";
            this.lblLocalPath.ImageList = this.ilMovieFileMerger;
            this.lblLocalPath.Location = new System.Drawing.Point(4, 309);
            this.lblLocalPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalPath.Name = "lblLocalPath";
            this.lblLocalPath.Size = new System.Drawing.Size(107, 25);
            this.lblLocalPath.TabIndex = 61;
            this.lblLocalPath.Text = "Local Path";
            this.lblLocalPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttMovieFileMerger.SetToolTip(this.lblLocalPath, "Enter the path where the downloaded videos should be stored locally.");
            // 
            // lblPortNumber
            // 
            this.lblPortNumber.Location = new System.Drawing.Point(7, 235);
            this.lblPortNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortNumber.Name = "lblPortNumber";
            this.lblPortNumber.Size = new System.Drawing.Size(40, 16);
            this.lblPortNumber.TabIndex = 61;
            this.lblPortNumber.Text = "Port";
            this.ttMovieFileMerger.SetToolTip(this.lblPortNumber, "Enter the port number to connect to the remote host.");
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(89, 235);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 16);
            this.lblPassword.TabIndex = 61;
            this.lblPassword.Text = "Pwd";
            this.ttMovieFileMerger.SetToolTip(this.lblPassword, "Enter the passowrd used to connect to the remote host.");
            // 
            // lblHostName
            // 
            this.lblHostName.Location = new System.Drawing.Point(7, 188);
            this.lblHostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(40, 16);
            this.lblHostName.TabIndex = 61;
            this.lblHostName.Text = "Host";
            this.ttMovieFileMerger.SetToolTip(this.lblHostName, "Enter the name or IP address of the remote host.");
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(7, 165);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(40, 16);
            this.lblUserName.TabIndex = 61;
            this.lblUserName.Text = "User";
            this.ttMovieFileMerger.SetToolTip(this.lblUserName, "Enter the user name for the remote host.");
            // 
            // tbRemotePath
            // 
            this.tbRemotePath.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbRemotePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRemotePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemotePath.Location = new System.Drawing.Point(55, 212);
            this.tbRemotePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbRemotePath.Name = "tbRemotePath";
            this.tbRemotePath.Size = new System.Drawing.Size(160, 16);
            this.tbRemotePath.TabIndex = 60;
            this.tbRemotePath.Text = "/videos";
            this.ttMovieFileMerger.SetToolTip(this.tbRemotePath, "Enter the path of the remote host, where to search for videos.");
            // 
            // tbLocalPath
            // 
            this.tbLocalPath.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbLocalPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLocalPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocalPath.Location = new System.Drawing.Point(8, 343);
            this.tbLocalPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbLocalPath.Name = "tbLocalPath";
            this.tbLocalPath.Size = new System.Drawing.Size(207, 16);
            this.tbLocalPath.TabIndex = 60;
            this.tbLocalPath.Text = "C:\\Downloads";
            this.ttMovieFileMerger.SetToolTip(this.tbLocalPath, "Enter the path where the downloaded videos should be stored locally.");
            // 
            // tbPortNumber
            // 
            this.tbPortNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbPortNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPortNumber.Location = new System.Drawing.Point(55, 235);
            this.tbPortNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPortNumber.Name = "tbPortNumber";
            this.tbPortNumber.Size = new System.Drawing.Size(27, 16);
            this.tbPortNumber.TabIndex = 60;
            this.tbPortNumber.Text = "21";
            this.tbPortNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttMovieFileMerger.SetToolTip(this.tbPortNumber, "Enter the port number to connect to the remote host.");
            // 
            // tbHostName
            // 
            this.tbHostName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbHostName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHostName.Location = new System.Drawing.Point(55, 188);
            this.tbHostName.Margin = new System.Windows.Forms.Padding(4);
            this.tbHostName.Name = "tbHostName";
            this.tbHostName.Size = new System.Drawing.Size(160, 16);
            this.tbHostName.TabIndex = 60;
            this.tbHostName.Text = "ftp.movie-file-merger.org";
            this.tbHostName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttMovieFileMerger.SetToolTip(this.tbHostName, "Enter the name or IP address of the remote host.");
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(55, 165);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(160, 16);
            this.tbUserName.TabIndex = 60;
            this.tbUserName.Text = "movie-file-merger.org";
            this.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttMovieFileMerger.SetToolTip(this.tbUserName, "Enter the user name for the remote host.");
            // 
            // btnOpenWinSCP
            // 
            this.btnOpenWinSCP.AllowDrop = true;
            this.btnOpenWinSCP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenWinSCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenWinSCP.ImageKey = "WinSCP.png";
            this.btnOpenWinSCP.ImageList = this.ilMovieFileMerger;
            this.btnOpenWinSCP.Location = new System.Drawing.Point(11, 98);
            this.btnOpenWinSCP.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenWinSCP.Name = "btnOpenWinSCP";
            this.btnOpenWinSCP.Size = new System.Drawing.Size(204, 30);
            this.btnOpenWinSCP.TabIndex = 58;
            this.btnOpenWinSCP.TabStop = false;
            this.btnOpenWinSCP.Text = "Open WinSCP";
            this.btnOpenWinSCP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenWinSCP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnOpenWinSCP, "Open the WinSCP FTP application.");
            this.btnOpenWinSCP.UseVisualStyleBackColor = false;
            this.btnOpenWinSCP.Click += new System.EventHandler(this.BtnOpenWinSCP_Click);
            // 
            // btnGetRemoteFileNames
            // 
            this.btnGetRemoteFileNames.AllowDrop = true;
            this.btnGetRemoteFileNames.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnGetRemoteFileNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetRemoteFileNames.ImageKey = "RemoteNames.png";
            this.btnGetRemoteFileNames.ImageList = this.ilMovieFileMerger;
            this.btnGetRemoteFileNames.Location = new System.Drawing.Point(11, 257);
            this.btnGetRemoteFileNames.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetRemoteFileNames.Name = "btnGetRemoteFileNames";
            this.btnGetRemoteFileNames.Size = new System.Drawing.Size(204, 30);
            this.btnGetRemoteFileNames.TabIndex = 58;
            this.btnGetRemoteFileNames.TabStop = false;
            this.btnGetRemoteFileNames.Text = "Get Remote File Names";
            this.btnGetRemoteFileNames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetRemoteFileNames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnGetRemoteFileNames, "Click here to get the file names from the Remote Host.");
            this.btnGetRemoteFileNames.UseVisualStyleBackColor = false;
            this.btnGetRemoteFileNames.Click += new System.EventHandler(this.BtnGetRemoteFileNames_Click);
            // 
            // scFTPSucker
            // 
            this.scFTPSucker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scFTPSucker.Location = new System.Drawing.Point(221, 66);
            this.scFTPSucker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scFTPSucker.Name = "scFTPSucker";
            this.scFTPSucker.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scFTPSucker.Panel1
            // 
            this.scFTPSucker.Panel1.Controls.Add(this.lvRemoteFiles);
            this.scFTPSucker.Panel1.Margin = new System.Windows.Forms.Padding(1);
            this.scFTPSucker.Panel1.Padding = new System.Windows.Forms.Padding(1);
            this.scFTPSucker.Panel1MinSize = 100;
            // 
            // scFTPSucker.Panel2
            // 
            this.scFTPSucker.Panel2.Controls.Add(this.rtbFTPSucker);
            this.scFTPSucker.Panel2MinSize = 100;
            this.scFTPSucker.Size = new System.Drawing.Size(821, 598);
            this.scFTPSucker.SplitterDistance = 376;
            this.scFTPSucker.SplitterWidth = 5;
            this.scFTPSucker.TabIndex = 40;
            // 
            // lvRemoteFiles
            // 
            this.lvRemoteFiles.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvRemoteFiles.AllowDrop = true;
            this.lvRemoteFiles.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lvRemoteFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRemoteFiles});
            this.lvRemoteFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRemoteFiles.FullRowSelect = true;
            this.lvRemoteFiles.GridLines = true;
            this.lvRemoteFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRemoteFiles.HideSelection = false;
            this.lvRemoteFiles.LabelWrap = false;
            this.lvRemoteFiles.Location = new System.Drawing.Point(1, 1);
            this.lvRemoteFiles.Margin = new System.Windows.Forms.Padding(4);
            this.lvRemoteFiles.Name = "lvRemoteFiles";
            this.lvRemoteFiles.ShowItemToolTips = true;
            this.lvRemoteFiles.Size = new System.Drawing.Size(819, 374);
            this.lvRemoteFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvRemoteFiles.TabIndex = 38;
            this.lvRemoteFiles.TabStop = false;
            this.lvRemoteFiles.Tag = "FTP Sucker";
            this.lvRemoteFiles.TileSize = new System.Drawing.Size(1, 1);
            this.lvRemoteFiles.UseCompatibleStateImageBehavior = false;
            this.lvRemoteFiles.View = System.Windows.Forms.View.Details;
            this.lvRemoteFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvFileListDrag);
            this.lvRemoteFiles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
            this.lvRemoteFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
            this.lvRemoteFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
            this.lvRemoteFiles.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
            this.lvRemoteFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvKeyDown);
            this.lvRemoteFiles.MouseEnter += new System.EventHandler(this.LvMouseEnter);
            this.lvRemoteFiles.Resize += new System.EventHandler(this.LvFTPSuckerResize);
            // 
            // chRemoteFiles
            // 
            this.chRemoteFiles.Text = "Remote Files";
            this.chRemoteFiles.Width = 700;
            // 
            // rtbFTPSucker
            // 
            this.rtbFTPSucker.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbFTPSucker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFTPSucker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFTPSucker.Location = new System.Drawing.Point(0, 0);
            this.rtbFTPSucker.Margin = new System.Windows.Forms.Padding(4);
            this.rtbFTPSucker.Name = "rtbFTPSucker";
            this.rtbFTPSucker.ReadOnly = true;
            this.rtbFTPSucker.Size = new System.Drawing.Size(821, 217);
            this.rtbFTPSucker.TabIndex = 20;
            this.rtbFTPSucker.Text = "";
            this.rtbFTPSucker.WordWrap = false;
            // 
            // btnGetWishedRemoteFiles
            // 
            this.btnGetWishedRemoteFiles.AllowDrop = true;
            this.btnGetWishedRemoteFiles.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetWishedRemoteFiles.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnGetWishedRemoteFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetWishedRemoteFiles.ImageKey = "DownloadCloud.png";
            this.btnGetWishedRemoteFiles.ImageList = this.ilMovieFileMerger;
            this.btnGetWishedRemoteFiles.Location = new System.Drawing.Point(11, 367);
            this.btnGetWishedRemoteFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetWishedRemoteFiles.Name = "btnGetWishedRemoteFiles";
            this.btnGetWishedRemoteFiles.Size = new System.Drawing.Size(203, 30);
            this.btnGetWishedRemoteFiles.TabIndex = 59;
            this.btnGetWishedRemoteFiles.TabStop = false;
            this.btnGetWishedRemoteFiles.Text = "Get Wish Remote Files";
            this.btnGetWishedRemoteFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetWishedRemoteFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttMovieFileMerger.SetToolTip(this.btnGetWishedRemoteFiles, "Click here to download the Wish files from the Remote Host.");
            this.btnGetWishedRemoteFiles.UseVisualStyleBackColor = false;
            this.btnGetWishedRemoteFiles.Click += new System.EventHandler(this.BtnDownloadWishedRemoteFiles_Click);
            // 
            // tpAbout
            // 
            this.tpAbout.BackColor = System.Drawing.SystemColors.Control;
            this.tpAbout.Controls.Add(this.pbGitHubSocialCodingLeft);
            this.tpAbout.Controls.Add(this.pbGitHubSocialCoding);
            this.tpAbout.Controls.Add(this.pbAboutDonate);
            this.tpAbout.Controls.Add(this.pbAboutUserManual);
            this.tpAbout.Controls.Add(this.pbAboutHowTo);
            this.tpAbout.Controls.Add(this.lblLastChecked);
            this.tpAbout.Controls.Add(this.btnCheckNow);
            this.tpAbout.Controls.Add(this.pbAboutBanner);
            this.tpAbout.Controls.Add(this.lblCopyLeft);
            this.tpAbout.Controls.Add(this.rtbCopyright);
            this.tpAbout.Controls.Add(this.lblVersion);
            this.tpAbout.ImageKey = "About.gif";
            this.tpAbout.Location = new System.Drawing.Point(4, 31);
            this.tpAbout.Margin = new System.Windows.Forms.Padding(4);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(4);
            this.tpAbout.Size = new System.Drawing.Size(1054, 684);
            this.tpAbout.TabIndex = 3;
            this.tpAbout.Text = "About";
            // 
            // pbGitHubSocialCodingLeft
            // 
            this.pbGitHubSocialCodingLeft.ErrorImage = null;
            this.pbGitHubSocialCodingLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbGitHubSocialCodingLeft.Image")));
            this.pbGitHubSocialCodingLeft.InitialImage = null;
            this.pbGitHubSocialCodingLeft.Location = new System.Drawing.Point(12, 96);
            this.pbGitHubSocialCodingLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pbGitHubSocialCodingLeft.Name = "pbGitHubSocialCodingLeft";
            this.pbGitHubSocialCodingLeft.Size = new System.Drawing.Size(253, 84);
            this.pbGitHubSocialCodingLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGitHubSocialCodingLeft.TabIndex = 17;
            this.pbGitHubSocialCodingLeft.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbGitHubSocialCodingLeft, "Contribute to or have a look at the source code on GitHub.");
            this.pbGitHubSocialCodingLeft.Click += new System.EventHandler(this.pbGitHubSocialCoding_Click);
            this.pbGitHubSocialCodingLeft.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbGitHubSocialCodingLeft.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbGitHubSocialCoding
            // 
            this.pbGitHubSocialCoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGitHubSocialCoding.ErrorImage = null;
            this.pbGitHubSocialCoding.Image = ((System.Drawing.Image)(resources.GetObject("pbGitHubSocialCoding.Image")));
            this.pbGitHubSocialCoding.InitialImage = null;
            this.pbGitHubSocialCoding.Location = new System.Drawing.Point(790, 97);
            this.pbGitHubSocialCoding.Margin = new System.Windows.Forms.Padding(4);
            this.pbGitHubSocialCoding.Name = "pbGitHubSocialCoding";
            this.pbGitHubSocialCoding.Size = new System.Drawing.Size(253, 82);
            this.pbGitHubSocialCoding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGitHubSocialCoding.TabIndex = 16;
            this.pbGitHubSocialCoding.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbGitHubSocialCoding, "Contribute to or have a look at the source code on GitHub.");
            this.pbGitHubSocialCoding.Click += new System.EventHandler(this.pbGitHubSocialCoding_Click);
            this.pbGitHubSocialCoding.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbGitHubSocialCoding.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbAboutDonate
            // 
            this.pbAboutDonate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAboutDonate.ErrorImage = null;
            this.pbAboutDonate.Image = global::Movie_File_Merger.Properties.Resources.DonateButtonLong;
            this.pbAboutDonate.InitialImage = null;
            this.pbAboutDonate.Location = new System.Drawing.Point(273, 97);
            this.pbAboutDonate.Margin = new System.Windows.Forms.Padding(4);
            this.pbAboutDonate.Name = "pbAboutDonate";
            this.pbAboutDonate.Size = new System.Drawing.Size(509, 82);
            this.pbAboutDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAboutDonate.TabIndex = 15;
            this.pbAboutDonate.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbAboutDonate, "Donate a beer or two for Modi.");
            this.pbAboutDonate.Click += new System.EventHandler(this.pbDonateClick);
            this.pbAboutDonate.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbAboutDonate.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbAboutUserManual
            // 
            this.pbAboutUserManual.ErrorImage = null;
            this.pbAboutUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbAboutUserManual.Image")));
            this.pbAboutUserManual.InitialImage = null;
            this.pbAboutUserManual.Location = new System.Drawing.Point(5, 6);
            this.pbAboutUserManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAboutUserManual.Name = "pbAboutUserManual";
            this.pbAboutUserManual.Size = new System.Drawing.Size(72, 82);
            this.pbAboutUserManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAboutUserManual.TabIndex = 11;
            this.pbAboutUserManual.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbAboutUserManual, "Go to the online MFM User Manual to read more details about how to use MFM.");
            this.pbAboutUserManual.Click += new System.EventHandler(this.PbUserManualClick);
            this.pbAboutUserManual.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbAboutUserManual.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // pbAboutHowTo
            // 
            this.pbAboutHowTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAboutHowTo.ErrorImage = null;
            this.pbAboutHowTo.Image = ((System.Drawing.Image)(resources.GetObject("pbAboutHowTo.Image")));
            this.pbAboutHowTo.InitialImage = null;
            this.pbAboutHowTo.Location = new System.Drawing.Point(976, 6);
            this.pbAboutHowTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAboutHowTo.Name = "pbAboutHowTo";
            this.pbAboutHowTo.Size = new System.Drawing.Size(72, 82);
            this.pbAboutHowTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAboutHowTo.TabIndex = 10;
            this.pbAboutHowTo.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbAboutHowTo, "Go to the online How to Organize Videos on Hard Disks Manual to get a brief descr" +
        "iption of how a video collection could be organized in general.");
            this.pbAboutHowTo.Click += new System.EventHandler(this.PbHowToClick);
            this.pbAboutHowTo.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbAboutHowTo.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // lblLastChecked
            // 
            this.lblLastChecked.Location = new System.Drawing.Point(4, 183);
            this.lblLastChecked.Name = "lblLastChecked";
            this.lblLastChecked.Size = new System.Drawing.Size(220, 32);
            this.lblLastChecked.TabIndex = 9;
            this.lblLastChecked.Text = "Last Checked: Never";
            this.lblLastChecked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttMovieFileMerger.SetToolTip(this.lblLastChecked, "If the version is up to date has been last checked...");
            // 
            // btnCheckNow
            // 
            this.btnCheckNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckNow.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnCheckNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckNow.Location = new System.Drawing.Point(849, 186);
            this.btnCheckNow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckNow.Name = "btnCheckNow";
            this.btnCheckNow.Size = new System.Drawing.Size(193, 31);
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
            this.pbAboutBanner.ErrorImage = null;
            this.pbAboutBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbAboutBanner.Image")));
            this.pbAboutBanner.InitialImage = null;
            this.pbAboutBanner.Location = new System.Drawing.Point(5, 6);
            this.pbAboutBanner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAboutBanner.Name = "pbAboutBanner";
            this.pbAboutBanner.Size = new System.Drawing.Size(1041, 82);
            this.pbAboutBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAboutBanner.TabIndex = 6;
            this.pbAboutBanner.TabStop = false;
            this.ttMovieFileMerger.SetToolTip(this.pbAboutBanner, "Go to the MFM website to get additional information or access the forum.");
            this.pbAboutBanner.Click += new System.EventHandler(this.PbBannerClick);
            this.pbAboutBanner.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
            this.pbAboutBanner.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
            // 
            // lblCopyLeft
            // 
            this.lblCopyLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyLeft.Location = new System.Drawing.Point(660, 190);
            this.lblCopyLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyLeft.Name = "lblCopyLeft";
            this.lblCopyLeft.Size = new System.Drawing.Size(123, 21);
            this.lblCopyLeft.TabIndex = 2;
            this.lblCopyLeft.Text = "© 2018 Modi";
            this.lblCopyLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttMovieFileMerger.SetToolTip(this.lblCopyLeft, "MFM is copyrighted by Modi (Reinhold Lauer).");
            // 
            // rtbCopyright
            // 
            this.rtbCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCopyright.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCopyright.Location = new System.Drawing.Point(8, 219);
            this.rtbCopyright.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbCopyright.Name = "rtbCopyright";
            this.rtbCopyright.ReadOnly = true;
            this.rtbCopyright.Size = new System.Drawing.Size(1050, 459);
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
            this.lblVersion.Location = new System.Drawing.Point(269, 190);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(88, 18);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "x.x.x";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttMovieFileMerger.SetToolTip(this.lblVersion, "The installed MFM version.");
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
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(882, 471);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(882, 526);
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
            this.ssMFM.Size = new System.Drawing.Size(882, 30);
            this.ssMFM.TabIndex = 0;
            // 
            // tsslMFM
            // 
            this.tsslMFM.Name = "tsslMFM";
            this.tsslMFM.Size = new System.Drawing.Size(725, 25);
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
            this.ttMovieFileMerger.AutoPopDelay = 90000;
            this.ttMovieFileMerger.InitialDelay = 1000;
            this.ttMovieFileMerger.IsBalloon = true;
            this.ttMovieFileMerger.ReshowDelay = 80;
            this.ttMovieFileMerger.ShowAlways = true;
            this.ttMovieFileMerger.ToolTipTitle = "Movie File Merger Help";
            // 
            // ofdTeraCopy
            // 
            this.ofdTeraCopy.FileName = "C:\\Program Files\\TeraCopy\\TeraCopy.exe";
            // 
            // MFMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(882, 526);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MFMForm";
            this.Text = "Movie File Merger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MfFormClosing);
            this.Shown += new System.EventHandler(this.MfShown);
            this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
            this.tcMovieFileMerger.ResumeLayout(false);
            this.tpSeparateLists.ResumeLayout(false);
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
            this.scHorizontalRight.Panel1.ResumeLayout(false);
            this.scHorizontalRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scHorizontalRight)).EndInit();
            this.scHorizontalRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbListsHowTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListsUserManual)).EndInit();
            this.tpLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLodDonateRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogDonateLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogUserManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogHowTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogBanner)).EndInit();
            this.tpMaintenance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaintenanceHowTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaintenanceUserManual)).EndInit();
            this.scMaintenance.Panel1.ResumeLayout(false);
            this.scMaintenance.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMaintenance)).EndInit();
            this.scMaintenance.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSeetingsHowTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsUserManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsBanner)).EndInit();
            this.gbSettingsNameUnification.ResumeLayout(false);
            this.gbSettingsNameUnification.PerformLayout();
            this.gbSettingsConsideredFiles.ResumeLayout(false);
            this.gbSettingsConsideredFiles.PerformLayout();
            this.tpFTPSucker.ResumeLayout(false);
            this.tpFTPSucker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMousePointerMFM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFTPSuckerUserManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFTPSuckerHowTo)).EndInit();
            this.scFTPSucker.Panel1.ResumeLayout(false);
            this.scFTPSucker.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scFTPSucker)).EndInit();
            this.scFTPSucker.ResumeLayout(false);
            this.tpAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHubSocialCodingLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHubSocialCoding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutDonate)).EndInit();
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
		private System.Windows.Forms.GroupBox gbSettingsNameUnification;
		private System.Windows.Forms.TextBox tbToLowerRegex;
		private System.Windows.Forms.Label lblToLowerRegex;
		private System.Windows.Forms.Label lblOnlyCharacters;
		private System.Windows.Forms.TextBox tbOnlyCharactersRegex;
		private System.Windows.Forms.RichTextBox rtbSettings;
		private System.Windows.Forms.ImageList ilMovieFileMerger;
		private System.Windows.Forms.ColumnHeader chNameExisting;
		private System.Windows.Forms.ColumnHeader chNameImport;
		private System.Windows.Forms.ColumnHeader chNameGarbage;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblCopyLeft;
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
		private System.Windows.Forms.PictureBox pbAboutBanner;
		private System.Windows.Forms.CheckBox cbGetHigherRes;
		private System.Windows.Forms.StatusStrip ssMFM;
		private System.Windows.Forms.ToolStripStatusLabel tsslMFM;
		private System.Windows.Forms.ToolStripProgressBar tspbMFM;
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
        private System.Windows.Forms.Button btnPlayMaintenance;
        private System.Windows.Forms.Button btnExportListMaintenance;
        private System.Windows.Forms.Button btnSearchDownloadMaintenance;
        private System.Windows.Forms.Button btnSearchInfoMaintenance;
        private System.Windows.Forms.ComboBox cobSearchDownloadMaintenance;
        private System.Windows.Forms.ComboBox cobSearchInfoMaintenance;
        private System.Windows.Forms.ComboBox cobMinimumResolution;
        private System.Windows.Forms.ComboBox cobDownloadCriteria;
        private System.Windows.Forms.TabPage tpFTPSucker;
        private System.Windows.Forms.PictureBox pbFTPSuckerUserManual;
        private System.Windows.Forms.PictureBox pbFTPSuckerHowTo;
        private System.Windows.Forms.Label lblRemotePath;
        private System.Windows.Forms.Label lblLocalPath;
        private System.Windows.Forms.Label lblPortNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbRemotePath;
        private System.Windows.Forms.TextBox tbLocalPath;
        private System.Windows.Forms.TextBox tbPortNumber;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbHostName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnGetRemoteFileNames;
        private System.Windows.Forms.SplitContainer scFTPSucker;
        private System.Windows.Forms.ListView lvRemoteFiles;
        private System.Windows.Forms.ColumnHeader chRemoteFiles;
        private System.Windows.Forms.RichTextBox rtbFTPSucker;
        private System.Windows.Forms.Button btnGetWishedRemoteFiles;
        private System.Windows.Forms.Label lblAddonExtensions;
        private System.Windows.Forms.TextBox tbAddonExtensionsRegex;
        private System.Windows.Forms.Button btnColorList;
        private System.Windows.Forms.Label lblRemoteHhost;
        private System.Windows.Forms.Button btnOpenWinSCP;
        private System.Windows.Forms.Label lblCloudImage;
        private System.Windows.Forms.Button btnBrowseLocalPath;
        private System.Windows.Forms.Button btnWishSelected;
        private System.Windows.Forms.Button btnBinSelected;
        private System.Windows.Forms.Button btnEraseColorSucker;
        private System.Windows.Forms.Button btnEraseSelcectedSucker;
        private System.Windows.Forms.PictureBox pbAboutDonate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cobCheckForUpdates;
        private System.Windows.Forms.PictureBox pbGitHubSocialCoding;
        private System.Windows.Forms.PictureBox pbGitHubSocialCodingLeft;
        private System.Windows.Forms.PictureBox pbMaintenanceHowTo;
        private System.Windows.Forms.PictureBox pbMousePointerMFM;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbListsUserManual;
        private System.Windows.Forms.PictureBox pbListsHowTo;
        private System.Windows.Forms.Button BntDeleteUnrelated;
        private System.Windows.Forms.Button btnInvertSelection;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.SplitContainer scHorizontalRight;
        private System.Windows.Forms.ListView lvExport;
        private System.Windows.Forms.ColumnHeader chNameExport;
        private System.Windows.Forms.Button btnColorSelection;
        private System.Windows.Forms.PictureBox pbLodDonateRight;
        private System.Windows.Forms.PictureBox pbLogDonateLeft;
        private System.Windows.Forms.Button btnResetColors;
        private System.Windows.Forms.Button btnOrphanAddon;
        private System.Windows.Forms.ComboBox cobCollections;
    }
}
