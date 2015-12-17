/*
 * Created by SharpDevelop.
 * User: rlauer
 * Date: 2012-04-09
 * Time: 3:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Movie_File_Merger
{
	partial class MainForm
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
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.dudMinimumResolution = new System.Windows.Forms.DomainUpDown();
			this.btnStart = new System.Windows.Forms.Button();
			this.cbGetHigherRes = new System.Windows.Forms.CheckBox();
			this.rbMove = new System.Windows.Forms.RadioButton();
			this.rbCopy = new System.Windows.Forms.RadioButton();
			this.scVertical = new System.Windows.Forms.SplitContainer();
			this.lvExisting = new System.Windows.Forms.ListView();
			this.chNameExisting = new System.Windows.Forms.ColumnHeader("(none)");
			this.scVerticalRight = new System.Windows.Forms.SplitContainer();
			this.scHorizontal = new System.Windows.Forms.SplitContainer();
			this.lvWish = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader("(none)");
			this.lvGarbage = new System.Windows.Forms.ListView();
			this.chNameGarbage = new System.Windows.Forms.ColumnHeader("(none)");
			this.lvImport = new System.Windows.Forms.ListView();
			this.chNameImport = new System.Windows.Forms.ColumnHeader("(none)");
			this.cobSearchDownload = new System.Windows.Forms.ComboBox();
			this.cobSearchInfo = new System.Windows.Forms.ComboBox();
			this.tpMaintenance = new System.Windows.Forms.TabPage();
			this.pbMaintenanceUserManual = new System.Windows.Forms.PictureBox();
			this.btnGoodEpisode = new System.Windows.Forms.Button();
			this.btnGoodDocu = new System.Windows.Forms.Button();
			this.btnGoodMovie = new System.Windows.Forms.Button();
			this.btnUnrelatedFile = new System.Windows.Forms.Button();
			this.btnBadEpisode = new System.Windows.Forms.Button();
			this.btnBadName = new System.Windows.Forms.Button();
			this.btnBadDocu = new System.Windows.Forms.Button();
			this.btnBadMovie = new System.Windows.Forms.Button();
			this.pbMFM = new System.Windows.Forms.PictureBox();
			this.lblSelect = new System.Windows.Forms.Label();
			this.scMaintenance = new System.Windows.Forms.SplitContainer();
			this.lvMaintenance = new System.Windows.Forms.ListView();
			this.chNameMaintenance = new System.Windows.Forms.ColumnHeader("(none)");
			this.rtbMaintenance = new System.Windows.Forms.RichTextBox();
			this.tpLog = new System.Windows.Forms.TabPage();
			this.pbLogUserManual = new System.Windows.Forms.PictureBox();
			this.pbLogHowTo = new System.Windows.Forms.PictureBox();
			this.pbLogBanner = new System.Windows.Forms.PictureBox();
			this.rtbLog = new System.Windows.Forms.RichTextBox();
			this.tpSettings = new System.Windows.Forms.TabPage();
			this.pbSeetingsHowTo = new System.Windows.Forms.PictureBox();
			this.pbSettingsUserManual = new System.Windows.Forms.PictureBox();
			this.pbSettingsBanner = new System.Windows.Forms.PictureBox();
			this.rtbSettings = new System.Windows.Forms.RichTextBox();
			this.gbSettingsNameUnification = new System.Windows.Forms.GroupBox();
			this.cobDoubleClickDefault = new System.Windows.Forms.ComboBox();
			this.btnResetSettings = new System.Windows.Forms.Button();
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
			((System.ComponentModel.ISupportInitialize)(this.pbMaintenanceUserManual)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMFM)).BeginInit();
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
			this.sfdMovieFileMerger.DefaultExt = "csv";
			this.sfdMovieFileMerger.Filter = "Comma Searated Value files|*.csv";
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
			this.tcMovieFileMerger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tcMovieFileMerger.Name = "tcMovieFileMerger";
			this.tcMovieFileMerger.Padding = new System.Drawing.Point(9, 6);
			this.tcMovieFileMerger.SelectedIndex = 0;
			this.tcMovieFileMerger.Size = new System.Drawing.Size(928, 589);
			this.tcMovieFileMerger.TabIndex = 0;
			// 
			// tpSeparateLists
			// 
			this.tpSeparateLists.BackColor = System.Drawing.SystemColors.Control;
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
			this.tpSeparateLists.Location = new System.Drawing.Point(4, 35);
			this.tpSeparateLists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSeparateLists.Name = "tpSeparateLists";
			this.tpSeparateLists.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSeparateLists.Size = new System.Drawing.Size(920, 550);
			this.tpSeparateLists.TabIndex = 0;
			this.tpSeparateLists.Text = "Lists";
			// 
			// btnPlay
			// 
			this.btnPlay.AllowDrop = true;
			this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPlay.ImageKey = "Play.gif";
			this.btnPlay.ImageList = this.ilMovieFileMerger;
			this.btnPlay.Location = new System.Drawing.Point(809, 116);
			this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(103, 66);
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
			this.btnEdit.ImageKey = "Edit.png";
			this.btnEdit.ImageList = this.ilMovieFileMerger;
			this.btnEdit.Location = new System.Drawing.Point(694, 502);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(90, 40);
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
			this.btnJustScanIt.ImageKey = "Process.gif";
			this.btnJustScanIt.ImageList = this.ilMovieFileMerger;
			this.btnJustScanIt.Location = new System.Drawing.Point(9, 502);
			this.btnJustScanIt.Name = "btnJustScanIt";
			this.btnJustScanIt.Size = new System.Drawing.Size(142, 40);
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
			this.btnJustRipIt.ImageKey = "Process.gif";
			this.btnJustRipIt.ImageList = this.ilMovieFileMerger;
			this.btnJustRipIt.Location = new System.Drawing.Point(790, 502);
			this.btnJustRipIt.Name = "btnJustRipIt";
			this.btnJustRipIt.Size = new System.Drawing.Size(122, 40);
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
			this.cobCriteria.BackColor = System.Drawing.SystemColors.Control;
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
			this.cobCriteria.Location = new System.Drawing.Point(451, 503);
			this.cobCriteria.MaxDropDownItems = 15;
			this.cobCriteria.Name = "cobCriteria";
			this.cobCriteria.Size = new System.Drawing.Size(237, 28);
			this.cobCriteria.TabIndex = 44;
			this.cobCriteria.Text = "Select the Criteria...";
			this.ttMovieFileMerger.SetToolTip(this.cobCriteria, "Select a predefined Tool Tip Regex,\r\nfor the Select, Bin, or Wish actions.");
			this.cobCriteria.TextChanged += new System.EventHandler(this.SettingsChanged);
			this.cobCriteria.DragDrop += new System.Windows.Forms.DragEventHandler(this.CobCriteriaDragDrop);
			this.cobCriteria.DragOver += new System.Windows.Forms.DragEventHandler(this.CobCriteriaDragOver);
			// 
			// btnAddToWish
			// 
			this.btnAddToWish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddToWish.ImageKey = "Wish.png";
			this.btnAddToWish.ImageList = this.ilMovieFileMerger;
			this.btnAddToWish.Location = new System.Drawing.Point(355, 502);
			this.btnAddToWish.Name = "btnAddToWish";
			this.btnAddToWish.Size = new System.Drawing.Size(90, 40);
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
			this.btnBin.ImageKey = "Garbage.gif";
			this.btnBin.ImageList = this.ilMovieFileMerger;
			this.btnBin.Location = new System.Drawing.Point(259, 502);
			this.btnBin.Name = "btnBin";
			this.btnBin.Size = new System.Drawing.Size(90, 40);
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
			this.btnSelect.ImageKey = "Select.gif";
			this.btnSelect.ImageList = this.ilMovieFileMerger;
			this.btnSelect.Location = new System.Drawing.Point(155, 502);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(98, 40);
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
			this.btnExportList.ImageKey = "Save.gif";
			this.btnExportList.ImageList = this.ilMovieFileMerger;
			this.btnExportList.Location = new System.Drawing.Point(9, 116);
			this.btnExportList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExportList.Name = "btnExportList";
			this.btnExportList.Size = new System.Drawing.Size(103, 66);
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
			this.btnEraseColor.ImageKey = "Color.gif";
			this.btnEraseColor.ImageList = this.ilMovieFileMerger;
			this.btnEraseColor.Location = new System.Drawing.Point(472, 116);
			this.btnEraseColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEraseColor.Name = "btnEraseColor";
			this.btnEraseColor.Size = new System.Drawing.Size(120, 66);
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
			this.btnSearchDownload.ImageKey = "Download.png";
			this.btnSearchDownload.ImageList = this.ilMovieFileMerger;
			this.btnSearchDownload.Location = new System.Drawing.Point(149, 116);
			this.btnSearchDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearchDownload.Name = "btnSearchDownload";
			this.btnSearchDownload.Size = new System.Drawing.Size(154, 66);
			this.btnSearchDownload.TabIndex = 33;
			this.btnSearchDownload.TabStop = false;
			this.btnSearchDownload.Text = "Torrent Hound";
			this.btnSearchDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearchDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnSearchDownload, "Drop items here to download them from the internet.");
			this.btnSearchDownload.UseVisualStyleBackColor = false;
			this.btnSearchDownload.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnSearchDownloadDragDrop);
			this.btnSearchDownload.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// btnEraseSelected
			// 
			this.btnEraseSelected.AllowDrop = true;
			this.btnEraseSelected.ImageKey = "Erase.gif";
			this.btnEraseSelected.ImageList = this.ilMovieFileMerger;
			this.btnEraseSelected.Location = new System.Drawing.Point(327, 116);
			this.btnEraseSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEraseSelected.Name = "btnEraseSelected";
			this.btnEraseSelected.Size = new System.Drawing.Size(120, 66);
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
			this.btnSearchInfo.ImageKey = "About.gif";
			this.btnSearchInfo.ImageList = this.ilMovieFileMerger;
			this.btnSearchInfo.Location = new System.Drawing.Point(617, 116);
			this.btnSearchInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearchInfo.Name = "btnSearchInfo";
			this.btnSearchInfo.Size = new System.Drawing.Size(154, 66);
			this.btnSearchInfo.TabIndex = 32;
			this.btnSearchInfo.TabStop = false;
			this.btnSearchInfo.Text = "Adult DVD Empire";
			this.btnSearchInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearchInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.ttMovieFileMerger.SetToolTip(this.btnSearchInfo, "Drop items here to search for them on the internet.");
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
			this.gbTypeSelection.Location = new System.Drawing.Point(9, 10);
			this.gbTypeSelection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbTypeSelection.Name = "gbTypeSelection";
			this.gbTypeSelection.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbTypeSelection.Size = new System.Drawing.Size(447, 100);
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
			this.rbMiscellaneous.Location = new System.Drawing.Point(146, 59);
			this.rbMiscellaneous.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbMiscellaneous.Name = "rbMiscellaneous";
			this.rbMiscellaneous.Size = new System.Drawing.Size(174, 37);
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
			this.rbAdults.Location = new System.Drawing.Point(18, 59);
			this.rbAdults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbAdults.Name = "rbAdults";
			this.rbAdults.Size = new System.Drawing.Size(120, 37);
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
			this.rbClips.Location = new System.Drawing.Point(328, 59);
			this.rbClips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbClips.Name = "rbClips";
			this.rbClips.Size = new System.Drawing.Size(99, 37);
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
			this.rbSeries.Location = new System.Drawing.Point(328, 23);
			this.rbSeries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbSeries.Name = "rbSeries";
			this.rbSeries.Size = new System.Drawing.Size(113, 37);
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
			this.rbDocumentaries.Location = new System.Drawing.Point(146, 23);
			this.rbDocumentaries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbDocumentaries.Name = "rbDocumentaries";
			this.rbDocumentaries.Size = new System.Drawing.Size(174, 37);
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
			this.rbMovies.Location = new System.Drawing.Point(18, 23);
			this.rbMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbMovies.Name = "rbMovies";
			this.rbMovies.Size = new System.Drawing.Size(120, 37);
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
			this.gbProcessImport.Controls.Add(this.dudMinimumResolution);
			this.gbProcessImport.Controls.Add(this.btnStart);
			this.gbProcessImport.Controls.Add(this.cbGetHigherRes);
			this.gbProcessImport.Controls.Add(this.rbMove);
			this.gbProcessImport.Controls.Add(this.rbCopy);
			this.gbProcessImport.Location = new System.Drawing.Point(471, 10);
			this.gbProcessImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbProcessImport.Name = "gbProcessImport";
			this.gbProcessImport.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbProcessImport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gbProcessImport.Size = new System.Drawing.Size(433, 100);
			this.gbProcessImport.TabIndex = 20;
			this.gbProcessImport.TabStop = false;
			this.gbProcessImport.Text = "Process Import";
			this.ttMovieFileMerger.SetToolTip(this.gbProcessImport, "The process Import section allows you to copy or move the actual video and subtit" +
		"le files. You have to install TeraCopy to\r\ndo the actual processing.");
			// 
			// dudMinimumResolution
			// 
			this.dudMinimumResolution.BackColor = System.Drawing.Color.IndianRed;
			this.dudMinimumResolution.Items.Add(" > 8640p (16k QUHD)");
			this.dudMinimumResolution.Items.Add(" > 4320p (8K FUHD)");
			this.dudMinimumResolution.Items.Add(" > 2880p (UHD+)");
			this.dudMinimumResolution.Items.Add(" > 2160p (4K UHD)");
			this.dudMinimumResolution.Items.Add(" > 1440p (WQHD)");
			this.dudMinimumResolution.Items.Add(" > 1080p (Full HD)");
			this.dudMinimumResolution.Items.Add(" > 900p (HD+)");
			this.dudMinimumResolution.Items.Add(" > 720p (HD)");
			this.dudMinimumResolution.Items.Add(" > 540p (qHD)");
			this.dudMinimumResolution.Items.Add(" > 360p (nHD)");
			this.dudMinimumResolution.Items.Add(" > 0p (LD)");
			this.dudMinimumResolution.Location = new System.Drawing.Point(265, 27);
			this.dudMinimumResolution.Name = "dudMinimumResolution";
			this.dudMinimumResolution.ReadOnly = true;
			this.dudMinimumResolution.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dudMinimumResolution.Size = new System.Drawing.Size(157, 26);
			this.dudMinimumResolution.TabIndex = 1;
			this.dudMinimumResolution.Text = " > 720p (HD)";
			this.dudMinimumResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ttMovieFileMerger.SetToolTip(this.dudMinimumResolution, "Select the minimum horizontal resolution for import items, so that they are consi" +
		"dered to be processed at all.");
			this.dudMinimumResolution.TextChanged += new System.EventHandler(this.SettingsChanged);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.SystemColors.Control;
			this.btnStart.ImageKey = "Start.gif";
			this.btnStart.ImageList = this.ilMovieFileMerger;
			this.btnStart.Location = new System.Drawing.Point(12, 22);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(118, 71);
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
			this.cbGetHigherRes.Location = new System.Drawing.Point(265, 64);
			this.cbGetHigherRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbGetHigherRes.Name = "cbGetHigherRes";
			this.cbGetHigherRes.Size = new System.Drawing.Size(157, 25);
			this.cbGetHigherRes.TabIndex = 25;
			this.cbGetHigherRes.Text = "Get Higher Res";
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
			this.rbMove.Location = new System.Drawing.Point(133, 59);
			this.rbMove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbMove.Name = "rbMove";
			this.rbMove.Size = new System.Drawing.Size(120, 37);
			this.rbMove.TabIndex = 23;
			this.rbMove.Text = "Move";
			this.rbMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.rbMove, "If Move is checked and the Progress Bar clicked, the Wish colored items \r\nin the " +
		"Import list will be moved to the Target folder.");
			this.rbMove.UseVisualStyleBackColor = true;
			// 
			// rbCopy
			// 
			this.rbCopy.Checked = true;
			this.rbCopy.ImageKey = "Copy.gif";
			this.rbCopy.ImageList = this.ilMovieFileMerger;
			this.rbCopy.Location = new System.Drawing.Point(133, 23);
			this.rbCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbCopy.Name = "rbCopy";
			this.rbCopy.Size = new System.Drawing.Size(120, 37);
			this.rbCopy.TabIndex = 22;
			this.rbCopy.TabStop = true;
			this.rbCopy.Text = "Copy";
			this.rbCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.rbCopy, "If Copy is selected and you click the Progress Bar, the Wish colored items \r\nin t" +
		"he Import list will be copied to the Target folder.");
			this.rbCopy.UseVisualStyleBackColor = true;
			// 
			// scVertical
			// 
			this.scVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.scVertical.BackColor = System.Drawing.SystemColors.Control;
			this.scVertical.Location = new System.Drawing.Point(9, 192);
			this.scVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.scVertical.Name = "scVertical";
			// 
			// scVertical.Panel1
			// 
			this.scVertical.Panel1.Controls.Add(this.lvExisting);
			// 
			// scVertical.Panel2
			// 
			this.scVertical.Panel2.Controls.Add(this.scVerticalRight);
			this.scVertical.Size = new System.Drawing.Size(903, 301);
			this.scVertical.SplitterDistance = 293;
			this.scVertical.SplitterWidth = 6;
			this.scVertical.TabIndex = 7;
			this.scVertical.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ScVerticalSplitterMoved);
			// 
			// lvExisting
			// 
			this.lvExisting.AllowDrop = true;
			this.lvExisting.BackColor = System.Drawing.SystemColors.Window;
			this.lvExisting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvExisting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.chNameExisting});
			this.lvExisting.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvExisting.FullRowSelect = true;
			this.lvExisting.GridLines = true;
			this.lvExisting.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvExisting.LabelWrap = false;
			this.lvExisting.Location = new System.Drawing.Point(0, 0);
			this.lvExisting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lvExisting.Name = "lvExisting";
			this.lvExisting.ShowItemToolTips = true;
			this.lvExisting.Size = new System.Drawing.Size(293, 301);
			this.lvExisting.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvExisting.TabIndex = 0;
			this.lvExisting.TabStop = false;
			this.lvExisting.Tag = "Existing";
			this.lvExisting.UseCompatibleStateImageBehavior = false;
			this.lvExisting.View = System.Windows.Forms.View.Details;
			this.lvExisting.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemDrag);
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
			this.scVerticalRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.scVerticalRight.Name = "scVerticalRight";
			// 
			// scVerticalRight.Panel1
			// 
			this.scVerticalRight.Panel1.Controls.Add(this.scHorizontal);
			// 
			// scVerticalRight.Panel2
			// 
			this.scVerticalRight.Panel2.Controls.Add(this.lvImport);
			this.scVerticalRight.Size = new System.Drawing.Size(604, 301);
			this.scVerticalRight.SplitterDistance = 304;
			this.scVerticalRight.SplitterWidth = 6;
			this.scVerticalRight.TabIndex = 1;
			this.scVerticalRight.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ScVerticalSplitterMoved);
			// 
			// scHorizontal
			// 
			this.scHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scHorizontal.Location = new System.Drawing.Point(0, 0);
			this.scHorizontal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
			this.scHorizontal.Size = new System.Drawing.Size(304, 301);
			this.scHorizontal.SplitterDistance = 147;
			this.scHorizontal.SplitterWidth = 6;
			this.scHorizontal.TabIndex = 0;
			// 
			// lvWish
			// 
			this.lvWish.AllowDrop = true;
			this.lvWish.BackColor = System.Drawing.SystemColors.Window;
			this.lvWish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvWish.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1});
			this.lvWish.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvWish.FullRowSelect = true;
			this.lvWish.GridLines = true;
			this.lvWish.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvWish.LabelWrap = false;
			this.lvWish.Location = new System.Drawing.Point(0, 0);
			this.lvWish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lvWish.Name = "lvWish";
			this.lvWish.ShowItemToolTips = true;
			this.lvWish.Size = new System.Drawing.Size(304, 147);
			this.lvWish.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvWish.TabIndex = 1;
			this.lvWish.TabStop = false;
			this.lvWish.Tag = "Wish";
			this.lvWish.UseCompatibleStateImageBehavior = false;
			this.lvWish.View = System.Windows.Forms.View.Details;
			this.lvWish.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemDrag);
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
			this.lvGarbage.BackColor = System.Drawing.SystemColors.Window;
			this.lvGarbage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvGarbage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.chNameGarbage});
			this.lvGarbage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvGarbage.FullRowSelect = true;
			this.lvGarbage.GridLines = true;
			this.lvGarbage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvGarbage.LabelWrap = false;
			this.lvGarbage.Location = new System.Drawing.Point(0, 0);
			this.lvGarbage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lvGarbage.Name = "lvGarbage";
			this.lvGarbage.ShowItemToolTips = true;
			this.lvGarbage.Size = new System.Drawing.Size(304, 148);
			this.lvGarbage.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvGarbage.TabIndex = 1;
			this.lvGarbage.TabStop = false;
			this.lvGarbage.Tag = "Garbage";
			this.lvGarbage.UseCompatibleStateImageBehavior = false;
			this.lvGarbage.View = System.Windows.Forms.View.Details;
			this.lvGarbage.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemDrag);
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
			this.lvImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvImport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.chNameImport});
			this.lvImport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvImport.FullRowSelect = true;
			this.lvImport.GridLines = true;
			this.lvImport.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvImport.LabelWrap = false;
			this.lvImport.Location = new System.Drawing.Point(0, 0);
			this.lvImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lvImport.Name = "lvImport";
			this.lvImport.ShowItemToolTips = true;
			this.lvImport.Size = new System.Drawing.Size(294, 301);
			this.lvImport.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvImport.TabIndex = 0;
			this.lvImport.TabStop = false;
			this.lvImport.Tag = "Import";
			this.lvImport.TileSize = new System.Drawing.Size(1, 1);
			this.lvImport.UseCompatibleStateImageBehavior = false;
			this.lvImport.View = System.Windows.Forms.View.Details;
			this.lvImport.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemDrag);
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
			this.cobSearchDownload.FormattingEnabled = true;
			this.cobSearchDownload.Items.AddRange(new object[] {
			"All Below",
			"1337X",
			"Bit Snoop",
			"Demonoid",
			"Extra Torrent",
			"Eztv",
			"Kickass",
			"Magnet Seed",
			"Rarbg",
			"ISO Hunt",
			"Lime Torrents",
			"The Piratebay",
			"Torrentz",
			"Torrent Hound",
			"Torlock",
			"Yifi Torrents"});
			this.cobSearchDownload.Location = new System.Drawing.Point(126, 133);
			this.cobSearchDownload.Name = "cobSearchDownload";
			this.cobSearchDownload.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cobSearchDownload.Size = new System.Drawing.Size(24, 28);
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
			this.cobSearchInfo.FormattingEnabled = true;
			this.cobSearchInfo.Items.AddRange(new object[] {
			"Nearly All Below",
			"All Movie",
			"IMDb",
			"The Movie DB",
			"The Movie Poster DB",
			"The TVDB",
			"Trailer Addict",
			"Adult DVD Empire"});
			this.cobSearchInfo.Location = new System.Drawing.Point(770, 133);
			this.cobSearchInfo.Name = "cobSearchInfo";
			this.cobSearchInfo.Size = new System.Drawing.Size(24, 28);
			this.cobSearchInfo.TabIndex = 47;
			this.cobSearchInfo.Text = "IMDb";
			this.ttMovieFileMerger.SetToolTip(this.cobSearchInfo, "Select where to search for additional information concerning the item.");
			this.cobSearchInfo.SelectedIndexChanged += new System.EventHandler(this.CobSearchInfoSelectedIndexChanged);
			// 
			// tpMaintenance
			// 
			this.tpMaintenance.Controls.Add(this.pbMaintenanceUserManual);
			this.tpMaintenance.Controls.Add(this.btnGoodEpisode);
			this.tpMaintenance.Controls.Add(this.btnGoodDocu);
			this.tpMaintenance.Controls.Add(this.btnGoodMovie);
			this.tpMaintenance.Controls.Add(this.btnUnrelatedFile);
			this.tpMaintenance.Controls.Add(this.btnBadEpisode);
			this.tpMaintenance.Controls.Add(this.btnBadName);
			this.tpMaintenance.Controls.Add(this.btnBadDocu);
			this.tpMaintenance.Controls.Add(this.btnBadMovie);
			this.tpMaintenance.Controls.Add(this.pbMFM);
			this.tpMaintenance.Controls.Add(this.lblSelect);
			this.tpMaintenance.Controls.Add(this.scMaintenance);
			this.tpMaintenance.ImageKey = "Process.gif";
			this.tpMaintenance.Location = new System.Drawing.Point(4, 35);
			this.tpMaintenance.Name = "tpMaintenance";
			this.tpMaintenance.Padding = new System.Windows.Forms.Padding(3);
			this.tpMaintenance.Size = new System.Drawing.Size(920, 550);
			this.tpMaintenance.TabIndex = 5;
			this.tpMaintenance.Text = "Maintenance";
			// 
			// pbMaintenanceUserManual
			// 
			this.pbMaintenanceUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbMaintenanceUserManual.Image")));
			this.pbMaintenanceUserManual.Location = new System.Drawing.Point(6, 468);
			this.pbMaintenanceUserManual.Name = "pbMaintenanceUserManual";
			this.pbMaintenanceUserManual.Size = new System.Drawing.Size(129, 137);
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
			this.btnGoodEpisode.Location = new System.Drawing.Point(8, 411);
			this.btnGoodEpisode.Name = "btnGoodEpisode";
			this.btnGoodEpisode.Size = new System.Drawing.Size(128, 32);
			this.btnGoodEpisode.TabIndex = 18;
			this.btnGoodEpisode.Text = "Good Episode";
			this.ttMovieFileMerger.SetToolTip(this.btnGoodEpisode, "Select all episodes with bad names.");
			this.btnGoodEpisode.UseVisualStyleBackColor = true;
			this.btnGoodEpisode.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnGoodDocu
			// 
			this.btnGoodDocu.Location = new System.Drawing.Point(8, 373);
			this.btnGoodDocu.Name = "btnGoodDocu";
			this.btnGoodDocu.Size = new System.Drawing.Size(128, 32);
			this.btnGoodDocu.TabIndex = 16;
			this.btnGoodDocu.Text = "Good Docu";
			this.ttMovieFileMerger.SetToolTip(this.btnGoodDocu, "Select all documentaries with good names.");
			this.btnGoodDocu.UseVisualStyleBackColor = true;
			this.btnGoodDocu.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnGoodMovie
			// 
			this.btnGoodMovie.Location = new System.Drawing.Point(8, 335);
			this.btnGoodMovie.Name = "btnGoodMovie";
			this.btnGoodMovie.Size = new System.Drawing.Size(128, 32);
			this.btnGoodMovie.TabIndex = 15;
			this.btnGoodMovie.Text = "Good Movie";
			this.ttMovieFileMerger.SetToolTip(this.btnGoodMovie, "Select all movies with good names.");
			this.btnGoodMovie.UseVisualStyleBackColor = true;
			this.btnGoodMovie.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnUnrelatedFile
			// 
			this.btnUnrelatedFile.Location = new System.Drawing.Point(8, 297);
			this.btnUnrelatedFile.Name = "btnUnrelatedFile";
			this.btnUnrelatedFile.Size = new System.Drawing.Size(128, 32);
			this.btnUnrelatedFile.TabIndex = 14;
			this.btnUnrelatedFile.Text = "Unrelated File";
			this.ttMovieFileMerger.SetToolTip(this.btnUnrelatedFile, "Select all unrelated files, which are not main or add-on files.");
			this.btnUnrelatedFile.UseVisualStyleBackColor = true;
			this.btnUnrelatedFile.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnBadEpisode
			// 
			this.btnBadEpisode.Location = new System.Drawing.Point(8, 221);
			this.btnBadEpisode.Name = "btnBadEpisode";
			this.btnBadEpisode.Size = new System.Drawing.Size(128, 32);
			this.btnBadEpisode.TabIndex = 12;
			this.btnBadEpisode.Text = "Bad Episode";
			this.ttMovieFileMerger.SetToolTip(this.btnBadEpisode, "Select all episodes with bad names.");
			this.btnBadEpisode.UseVisualStyleBackColor = true;
			this.btnBadEpisode.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnBadName
			// 
			this.btnBadName.Location = new System.Drawing.Point(8, 259);
			this.btnBadName.Name = "btnBadName";
			this.btnBadName.Size = new System.Drawing.Size(128, 32);
			this.btnBadName.TabIndex = 13;
			this.btnBadName.Text = "Bad Name";
			this.ttMovieFileMerger.SetToolTip(this.btnBadName, "Select all remaining files with bad names.");
			this.btnBadName.UseVisualStyleBackColor = true;
			this.btnBadName.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnBadDocu
			// 
			this.btnBadDocu.Location = new System.Drawing.Point(8, 183);
			this.btnBadDocu.Name = "btnBadDocu";
			this.btnBadDocu.Size = new System.Drawing.Size(128, 32);
			this.btnBadDocu.TabIndex = 11;
			this.btnBadDocu.Text = "Bad Docu";
			this.ttMovieFileMerger.SetToolTip(this.btnBadDocu, "Select all documentaries with bad names.");
			this.btnBadDocu.UseVisualStyleBackColor = true;
			this.btnBadDocu.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnBadMovie
			// 
			this.btnBadMovie.Location = new System.Drawing.Point(8, 145);
			this.btnBadMovie.Name = "btnBadMovie";
			this.btnBadMovie.Size = new System.Drawing.Size(128, 32);
			this.btnBadMovie.TabIndex = 10;
			this.btnBadMovie.Text = "Bad Movie";
			this.ttMovieFileMerger.SetToolTip(this.btnBadMovie, "Select all movies with with bad names.");
			this.btnBadMovie.UseVisualStyleBackColor = true;
			this.btnBadMovie.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// pbMFM
			// 
			this.pbMFM.Image = ((System.Drawing.Image)(resources.GetObject("pbMFM.Image")));
			this.pbMFM.InitialImage = null;
			this.pbMFM.Location = new System.Drawing.Point(22, 7);
			this.pbMFM.Name = "pbMFM";
			this.pbMFM.Size = new System.Drawing.Size(96, 103);
			this.pbMFM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbMFM.TabIndex = 44;
			this.pbMFM.TabStop = false;
			this.ttMovieFileMerger.SetToolTip(this.pbMFM, "Go to the MFM web site to get additional information or access the forum.");
			this.pbMFM.Click += new System.EventHandler(this.PbBannerClick);
			this.pbMFM.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
			this.pbMFM.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
			// 
			// lblSelect
			// 
			this.lblSelect.AutoEllipsis = true;
			this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSelect.Location = new System.Drawing.Point(9, 119);
			this.lblSelect.Name = "lblSelect";
			this.lblSelect.Size = new System.Drawing.Size(126, 23);
			this.lblSelect.TabIndex = 41;
			this.lblSelect.Text = "Select";
			this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// scMaintenance
			// 
			this.scMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.scMaintenance.Location = new System.Drawing.Point(143, 6);
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
			this.scMaintenance.Size = new System.Drawing.Size(769, 538);
			this.scMaintenance.SplitterDistance = 321;
			this.scMaintenance.SplitterWidth = 6;
			this.scMaintenance.TabIndex = 39;
			// 
			// lvMaintenance
			// 
			this.lvMaintenance.AllowDrop = true;
			this.lvMaintenance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.chNameMaintenance});
			this.lvMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvMaintenance.FullRowSelect = true;
			this.lvMaintenance.GridLines = true;
			this.lvMaintenance.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvMaintenance.LabelWrap = false;
			this.lvMaintenance.Location = new System.Drawing.Point(1, 1);
			this.lvMaintenance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lvMaintenance.Name = "lvMaintenance";
			this.lvMaintenance.ShowItemToolTips = true;
			this.lvMaintenance.Size = new System.Drawing.Size(767, 319);
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
			this.rtbMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbMaintenance.Location = new System.Drawing.Point(0, 0);
			this.rtbMaintenance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbMaintenance.Name = "rtbMaintenance";
			this.rtbMaintenance.ReadOnly = true;
			this.rtbMaintenance.Size = new System.Drawing.Size(769, 211);
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
			this.tpLog.Location = new System.Drawing.Point(4, 35);
			this.tpLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpLog.Name = "tpLog";
			this.tpLog.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpLog.Size = new System.Drawing.Size(920, 550);
			this.tpLog.TabIndex = 2;
			this.tpLog.Text = "Log";
			// 
			// pbLogUserManual
			// 
			this.pbLogUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbLogUserManual.Image")));
			this.pbLogUserManual.Location = new System.Drawing.Point(8, 8);
			this.pbLogUserManual.Name = "pbLogUserManual";
			this.pbLogUserManual.Size = new System.Drawing.Size(81, 104);
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
			this.pbLogHowTo.Location = new System.Drawing.Point(831, 8);
			this.pbLogHowTo.Name = "pbLogHowTo";
			this.pbLogHowTo.Size = new System.Drawing.Size(81, 104);
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
			this.pbLogBanner.Location = new System.Drawing.Point(8, 8);
			this.pbLogBanner.Name = "pbLogBanner";
			this.pbLogBanner.Size = new System.Drawing.Size(904, 104);
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
			this.rtbLog.Location = new System.Drawing.Point(4, 120);
			this.rtbLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbLog.Name = "rtbLog";
			this.rtbLog.ReadOnly = true;
			this.rtbLog.Size = new System.Drawing.Size(912, 420);
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
			this.tpSettings.Location = new System.Drawing.Point(4, 35);
			this.tpSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSettings.Name = "tpSettings";
			this.tpSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSettings.Size = new System.Drawing.Size(920, 550);
			this.tpSettings.TabIndex = 1;
			this.tpSettings.Text = "Settings";
			this.tpSettings.Leave += new System.EventHandler(this.TpSettingsLeave);
			// 
			// pbSeetingsHowTo
			// 
			this.pbSeetingsHowTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbSeetingsHowTo.Image = ((System.Drawing.Image)(resources.GetObject("pbSeetingsHowTo.Image")));
			this.pbSeetingsHowTo.Location = new System.Drawing.Point(831, 8);
			this.pbSeetingsHowTo.Name = "pbSeetingsHowTo";
			this.pbSeetingsHowTo.Size = new System.Drawing.Size(81, 104);
			this.pbSeetingsHowTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbSeetingsHowTo.TabIndex = 46;
			this.pbSeetingsHowTo.TabStop = false;
			this.ttMovieFileMerger.SetToolTip(this.pbSeetingsHowTo, "Go to the How to Organize Videos on Hard Disks Manual to get a brief description " +
		"about how a video collection could be organized in general.");
			this.pbSeetingsHowTo.Click += new System.EventHandler(this.PbHowToClick);
			this.pbSeetingsHowTo.MouseEnter += new System.EventHandler(this.PbPictureLinkMouseEnter);
			this.pbSeetingsHowTo.MouseLeave += new System.EventHandler(this.PbPictureLinkMouseLeave);
			// 
			// pbSettingsUserManual
			// 
			this.pbSettingsUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbSettingsUserManual.Image")));
			this.pbSettingsUserManual.Location = new System.Drawing.Point(7, 8);
			this.pbSettingsUserManual.Name = "pbSettingsUserManual";
			this.pbSettingsUserManual.Size = new System.Drawing.Size(81, 104);
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
			this.pbSettingsBanner.Location = new System.Drawing.Point(8, 8);
			this.pbSettingsBanner.Name = "pbSettingsBanner";
			this.pbSettingsBanner.Size = new System.Drawing.Size(904, 104);
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
			this.rtbSettings.Location = new System.Drawing.Point(9, 483);
			this.rtbSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbSettings.Name = "rtbSettings";
			this.rtbSettings.ReadOnly = true;
			this.rtbSettings.Size = new System.Drawing.Size(903, 67);
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
			this.gbSettingsNameUnification.Location = new System.Drawing.Point(8, 197);
			this.gbSettingsNameUnification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbSettingsNameUnification.Name = "gbSettingsNameUnification";
			this.gbSettingsNameUnification.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbSettingsNameUnification.Size = new System.Drawing.Size(903, 242);
			this.gbSettingsNameUnification.TabIndex = 20;
			this.gbSettingsNameUnification.TabStop = false;
			this.gbSettingsNameUnification.Text = "Name Unification Regular Expressions";
			this.ttMovieFileMerger.SetToolTip(this.gbSettingsNameUnification, "Name Unification Regular Expressions are used to standardize and cleanup the name" +
		"s as much as possible.");
			// 
			// cobDoubleClickDefault
			// 
			this.cobDoubleClickDefault.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.cobDoubleClickDefault.AllowDrop = true;
			this.cobDoubleClickDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cobDoubleClickDefault.BackColor = System.Drawing.SystemColors.Control;
			this.cobDoubleClickDefault.FormattingEnabled = true;
			this.cobDoubleClickDefault.Items.AddRange(new object[] {
			"DoubleClick Default",
			"Play",
			"Search Info",
			"Search Download"});
			this.cobDoubleClickDefault.Location = new System.Drawing.Point(7, 447);
			this.cobDoubleClickDefault.MaxDropDownItems = 15;
			this.cobDoubleClickDefault.Name = "cobDoubleClickDefault";
			this.cobDoubleClickDefault.Size = new System.Drawing.Size(182, 28);
			this.cobDoubleClickDefault.TabIndex = 45;
			this.cobDoubleClickDefault.Text = "DoubleClick Default";
			this.ttMovieFileMerger.SetToolTip(this.cobDoubleClickDefault, "Select a predefined Tool Tip Regex,\r\nfor the Select, Bin, or Wish actions.");
			// 
			// btnResetSettings
			// 
			this.btnResetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetSettings.Location = new System.Drawing.Point(729, 447);
			this.btnResetSettings.Name = "btnResetSettings";
			this.btnResetSettings.Size = new System.Drawing.Size(182, 28);
			this.btnResetSettings.TabIndex = 39;
			this.btnResetSettings.Text = "Reset All Settings";
			this.btnResetSettings.UseVisualStyleBackColor = true;
			this.btnResetSettings.Click += new System.EventHandler(this.BtnResetSettingsClick);
			// 
			// lblBadMovieNameRegex
			// 
			this.lblBadMovieNameRegex.Location = new System.Drawing.Point(482, 208);
			this.lblBadMovieNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBadMovieNameRegex.Name = "lblBadMovieNameRegex";
			this.lblBadMovieNameRegex.Size = new System.Drawing.Size(153, 24);
			this.lblBadMovieNameRegex.TabIndex = 38;
			this.lblBadMovieNameRegex.Text = "Bad Movie Name";
			this.ttMovieFileMerger.SetToolTip(this.lblBadMovieNameRegex, resources.GetString("lblBadMovieNameRegex.ToolTip"));
			// 
			// tbBadMovieNameRegex
			// 
			this.tbBadMovieNameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbBadMovieNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBadMovieNameRegex.Location = new System.Drawing.Point(643, 205);
			this.tbBadMovieNameRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbBadMovieNameRegex.Name = "tbBadMovieNameRegex";
			this.tbBadMovieNameRegex.Size = new System.Drawing.Size(248, 26);
			this.tbBadMovieNameRegex.TabIndex = 30;
			this.tbBadMovieNameRegex.Text = "[12]\\d{3}";
			this.ttMovieFileMerger.SetToolTip(this.tbBadMovieNameRegex, resources.GetString("tbBadMovieNameRegex.ToolTip"));
			// 
			// lblGoodMovieNameRegex
			// 
			this.lblGoodMovieNameRegex.Location = new System.Drawing.Point(12, 208);
			this.lblGoodMovieNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGoodMovieNameRegex.Name = "lblGoodMovieNameRegex";
			this.lblGoodMovieNameRegex.Size = new System.Drawing.Size(198, 24);
			this.lblGoodMovieNameRegex.TabIndex = 36;
			this.lblGoodMovieNameRegex.Text = "Good Movie Name";
			this.ttMovieFileMerger.SetToolTip(this.lblGoodMovieNameRegex, resources.GetString("lblGoodMovieNameRegex.ToolTip"));
			// 
			// tbGoodMovieNameRegex
			// 
			this.tbGoodMovieNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbGoodMovieNameRegex.Location = new System.Drawing.Point(218, 205);
			this.tbGoodMovieNameRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbGoodMovieNameRegex.Name = "tbGoodMovieNameRegex";
			this.tbGoodMovieNameRegex.Size = new System.Drawing.Size(235, 26);
			this.tbGoodMovieNameRegex.TabIndex = 29;
			this.tbGoodMovieNameRegex.Text = ".* \\([12]\\d{3}\\)$";
			this.ttMovieFileMerger.SetToolTip(this.tbGoodMovieNameRegex, resources.GetString("tbGoodMovieNameRegex.ToolTip"));
			// 
			// lblBadEpisodeNameRegex
			// 
			this.lblBadEpisodeNameRegex.Location = new System.Drawing.Point(482, 172);
			this.lblBadEpisodeNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBadEpisodeNameRegex.Name = "lblBadEpisodeNameRegex";
			this.lblBadEpisodeNameRegex.Size = new System.Drawing.Size(153, 24);
			this.lblBadEpisodeNameRegex.TabIndex = 34;
			this.lblBadEpisodeNameRegex.Text = "Bad Episode Name";
			this.ttMovieFileMerger.SetToolTip(this.lblBadEpisodeNameRegex, resources.GetString("lblBadEpisodeNameRegex.ToolTip"));
			// 
			// tbBadEpisodeNameRegex
			// 
			this.tbBadEpisodeNameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbBadEpisodeNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBadEpisodeNameRegex.Location = new System.Drawing.Point(643, 169);
			this.tbBadEpisodeNameRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbBadEpisodeNameRegex.Name = "tbBadEpisodeNameRegex";
			this.tbBadEpisodeNameRegex.Size = new System.Drawing.Size(248, 26);
			this.tbBadEpisodeNameRegex.TabIndex = 28;
			this.tbBadEpisodeNameRegex.Text = "[Ss]\\d{1,2}[Ee]\\d{1,2}";
			this.ttMovieFileMerger.SetToolTip(this.tbBadEpisodeNameRegex, resources.GetString("tbBadEpisodeNameRegex.ToolTip"));
			// 
			// lblGoodEpisodeNameRegex
			// 
			this.lblGoodEpisodeNameRegex.Location = new System.Drawing.Point(12, 172);
			this.lblGoodEpisodeNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGoodEpisodeNameRegex.Name = "lblGoodEpisodeNameRegex";
			this.lblGoodEpisodeNameRegex.Size = new System.Drawing.Size(198, 24);
			this.lblGoodEpisodeNameRegex.TabIndex = 32;
			this.lblGoodEpisodeNameRegex.Text = "Good Episode Name";
			this.ttMovieFileMerger.SetToolTip(this.lblGoodEpisodeNameRegex, resources.GetString("lblGoodEpisodeNameRegex.ToolTip"));
			// 
			// tbGoodEpisodeNameRegex
			// 
			this.tbGoodEpisodeNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbGoodEpisodeNameRegex.Location = new System.Drawing.Point(218, 169);
			this.tbGoodEpisodeNameRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbGoodEpisodeNameRegex.Name = "tbGoodEpisodeNameRegex";
			this.tbGoodEpisodeNameRegex.Size = new System.Drawing.Size(235, 26);
			this.tbGoodEpisodeNameRegex.TabIndex = 27;
			this.tbGoodEpisodeNameRegex.Text = ".* S\\d{2}E\\d{2}(-E\\d{2})? .*$";
			this.ttMovieFileMerger.SetToolTip(this.tbGoodEpisodeNameRegex, resources.GetString("tbGoodEpisodeNameRegex.ToolTip"));
			// 
			// lblBadDocuNameRegex
			// 
			this.lblBadDocuNameRegex.Location = new System.Drawing.Point(482, 136);
			this.lblBadDocuNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBadDocuNameRegex.Name = "lblBadDocuNameRegex";
			this.lblBadDocuNameRegex.Size = new System.Drawing.Size(153, 24);
			this.lblBadDocuNameRegex.TabIndex = 30;
			this.lblBadDocuNameRegex.Text = "Bad Docu Name";
			this.ttMovieFileMerger.SetToolTip(this.lblBadDocuNameRegex, resources.GetString("lblBadDocuNameRegex.ToolTip"));
			// 
			// tbBadDocuNameRegex
			// 
			this.tbBadDocuNameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbBadDocuNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBadDocuNameRegex.Location = new System.Drawing.Point(643, 133);
			this.tbBadDocuNameRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbBadDocuNameRegex.Name = "tbBadDocuNameRegex";
			this.tbBadDocuNameRegex.Size = new System.Drawing.Size(248, 26);
			this.tbBadDocuNameRegex.TabIndex = 26;
			this.tbBadDocuNameRegex.Text = "[Ss][12]\\d{3}[Ee]\\d{1,3}";
			this.ttMovieFileMerger.SetToolTip(this.tbBadDocuNameRegex, resources.GetString("tbBadDocuNameRegex.ToolTip"));
			// 
			// lblGoodDocuNameRegex
			// 
			this.lblGoodDocuNameRegex.Location = new System.Drawing.Point(12, 136);
			this.lblGoodDocuNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGoodDocuNameRegex.Name = "lblGoodDocuNameRegex";
			this.lblGoodDocuNameRegex.Size = new System.Drawing.Size(198, 24);
			this.lblGoodDocuNameRegex.TabIndex = 28;
			this.lblGoodDocuNameRegex.Text = "Good Docu Name";
			this.ttMovieFileMerger.SetToolTip(this.lblGoodDocuNameRegex, resources.GetString("lblGoodDocuNameRegex.ToolTip"));
			// 
			// tbGoodDocuNameRegex
			// 
			this.tbGoodDocuNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbGoodDocuNameRegex.Location = new System.Drawing.Point(218, 133);
			this.tbGoodDocuNameRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbGoodDocuNameRegex.Name = "tbGoodDocuNameRegex";
			this.tbGoodDocuNameRegex.Size = new System.Drawing.Size(235, 26);
			this.tbGoodDocuNameRegex.TabIndex = 25;
			this.tbGoodDocuNameRegex.Text = ".* S[12]\\d{3}E\\d{1,3} .*$";
			this.ttMovieFileMerger.SetToolTip(this.tbGoodDocuNameRegex, resources.GetString("tbGoodDocuNameRegex.ToolTip"));
			// 
			// lblToLowerRegex
			// 
			this.lblToLowerRegex.Location = new System.Drawing.Point(12, 68);
			this.lblToLowerRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblToLowerRegex.Name = "lblToLowerRegex";
			this.lblToLowerRegex.Size = new System.Drawing.Size(162, 32);
			this.lblToLowerRegex.TabIndex = 26;
			this.lblToLowerRegex.Text = "Convert to Lower";
			this.ttMovieFileMerger.SetToolTip(this.lblToLowerRegex, resources.GetString("lblToLowerRegex.ToolTip"));
			// 
			// tbToLowerRegex
			// 
			this.tbToLowerRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbToLowerRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbToLowerRegex.Location = new System.Drawing.Point(198, 65);
			this.tbToLowerRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbToLowerRegex.Multiline = true;
			this.tbToLowerRegex.Name = "tbToLowerRegex";
			this.tbToLowerRegex.Size = new System.Drawing.Size(504, 26);
			this.tbToLowerRegex.TabIndex = 22;
			this.tbToLowerRegex.Text = " On | A | The | Of | And | Or | To | From | For | In | As | At | With";
			this.ttMovieFileMerger.SetToolTip(this.tbToLowerRegex, resources.GetString("tbToLowerRegex.ToolTip"));
			// 
			// lblOnlyCharacters
			// 
			this.lblOnlyCharacters.Location = new System.Drawing.Point(482, 100);
			this.lblOnlyCharacters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOnlyCharacters.Name = "lblOnlyCharacters";
			this.lblOnlyCharacters.Size = new System.Drawing.Size(153, 32);
			this.lblOnlyCharacters.TabIndex = 24;
			this.lblOnlyCharacters.Text = "Only Characters";
			this.ttMovieFileMerger.SetToolTip(this.lblOnlyCharacters, resources.GetString("lblOnlyCharacters.ToolTip"));
			// 
			// tbOnlyCharactersRegex
			// 
			this.tbOnlyCharactersRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbOnlyCharactersRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbOnlyCharactersRegex.Location = new System.Drawing.Point(643, 97);
			this.tbOnlyCharactersRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbOnlyCharactersRegex.Name = "tbOnlyCharactersRegex";
			this.tbOnlyCharactersRegex.Size = new System.Drawing.Size(248, 26);
			this.tbOnlyCharactersRegex.TabIndex = 24;
			this.tbOnlyCharactersRegex.Text = "[^\\p{L}\\p{N} -\'ก-์]";
			this.ttMovieFileMerger.SetToolTip(this.tbOnlyCharactersRegex, resources.GetString("tbOnlyCharactersRegex.ToolTip"));
			// 
			// lblEpisodesId
			// 
			this.lblEpisodesId.Location = new System.Drawing.Point(12, 100);
			this.lblEpisodesId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEpisodesId.Name = "lblEpisodesId";
			this.lblEpisodesId.Size = new System.Drawing.Size(198, 32);
			this.lblEpisodesId.TabIndex = 22;
			this.lblEpisodesId.Text = "Episodes Identification";
			this.ttMovieFileMerger.SetToolTip(this.lblEpisodesId, resources.GetString("lblEpisodesId.ToolTip"));
			// 
			// tbEpisodesIdRegex
			// 
			this.tbEpisodesIdRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEpisodesIdRegex.Location = new System.Drawing.Point(218, 97);
			this.tbEpisodesIdRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbEpisodesIdRegex.Name = "tbEpisodesIdRegex";
			this.tbEpisodesIdRegex.Size = new System.Drawing.Size(235, 26);
			this.tbEpisodesIdRegex.TabIndex = 23;
			this.tbEpisodesIdRegex.Text = ".s\\d+e\\d+";
			this.ttMovieFileMerger.SetToolTip(this.tbEpisodesIdRegex, resources.GetString("tbEpisodesIdRegex.ToolTip"));
			// 
			// lblCutNameBeforeRegex
			// 
			this.lblCutNameBeforeRegex.Location = new System.Drawing.Point(12, 34);
			this.lblCutNameBeforeRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCutNameBeforeRegex.Name = "lblCutNameBeforeRegex";
			this.lblCutNameBeforeRegex.Size = new System.Drawing.Size(162, 32);
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
			this.tbCutNameBeforeRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCutNameBeforeRegex.Location = new System.Drawing.Point(198, 29);
			this.tbCutNameBeforeRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbCutNameBeforeRegex.Name = "tbCutNameBeforeRegex";
			this.tbCutNameBeforeRegex.Size = new System.Drawing.Size(504, 26);
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
			this.gbSettingsConsideredFiles.Location = new System.Drawing.Point(8, 120);
			this.gbSettingsConsideredFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbSettingsConsideredFiles.Name = "gbSettingsConsideredFiles";
			this.gbSettingsConsideredFiles.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbSettingsConsideredFiles.Size = new System.Drawing.Size(903, 67);
			this.gbSettingsConsideredFiles.TabIndex = 10;
			this.gbSettingsConsideredFiles.TabStop = false;
			this.gbSettingsConsideredFiles.Text = "Considered Files Regular Expressions";
			this.ttMovieFileMerger.SetToolTip(this.gbSettingsConsideredFiles, "Only add the file extensions of files which should be considered.");
			// 
			// lblAddonExtensions
			// 
			this.lblAddonExtensions.Location = new System.Drawing.Point(482, 30);
			this.lblAddonExtensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAddonExtensions.Name = "lblAddonExtensions";
			this.lblAddonExtensions.Size = new System.Drawing.Size(189, 29);
			this.lblAddonExtensions.TabIndex = 22;
			this.lblAddonExtensions.Text = "Add-on File Extensions";
			this.ttMovieFileMerger.SetToolTip(this.lblAddonExtensions, "The Add-on Files Extension identified add-on files like subtitles or posters. \r\nA" +
		"dd-on files will be only considered if a main video file exists.");
			// 
			// tbAddonExtensionsRegex
			// 
			this.tbAddonExtensionsRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbAddonExtensionsRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAddonExtensionsRegex.Location = new System.Drawing.Point(679, 27);
			this.tbAddonExtensionsRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbAddonExtensionsRegex.Name = "tbAddonExtensionsRegex";
			this.tbAddonExtensionsRegex.Size = new System.Drawing.Size(212, 26);
			this.tbAddonExtensionsRegex.TabIndex = 12;
			this.tbAddonExtensionsRegex.Text = "srt|sub";
			this.ttMovieFileMerger.SetToolTip(this.tbAddonExtensionsRegex, "The Add-on Files Extension identified add-on files like subtitles or posters. \r\nA" +
		"dd-on files will be only considered if a main video file exists.");
			// 
			// lblMainExtensions
			// 
			this.lblMainExtensions.Location = new System.Drawing.Point(8, 30);
			this.lblMainExtensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMainExtensions.Name = "lblMainExtensions";
			this.lblMainExtensions.Size = new System.Drawing.Size(182, 29);
			this.lblMainExtensions.TabIndex = 20;
			this.lblMainExtensions.Text = "Main File Extensions";
			this.ttMovieFileMerger.SetToolTip(this.lblMainExtensions, "The Main Files Extension regular expression identifies main files. \r\nIf no main f" +
		"ile exists also the add-on files will be ignored.");
			// 
			// tbMainExtensionsRegex
			// 
			this.tbMainExtensionsRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMainExtensionsRegex.Location = new System.Drawing.Point(198, 27);
			this.tbMainExtensionsRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbMainExtensionsRegex.Name = "tbMainExtensionsRegex";
			this.tbMainExtensionsRegex.Size = new System.Drawing.Size(255, 26);
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
			this.tpHelp.Location = new System.Drawing.Point(4, 35);
			this.tpHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpHelp.Name = "tpHelp";
			this.tpHelp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpHelp.Size = new System.Drawing.Size(920, 550);
			this.tpHelp.TabIndex = 4;
			this.tpHelp.Text = "Instructions";
			// 
			// pbInstructionsUserManual
			// 
			this.pbInstructionsUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbInstructionsUserManual.Image")));
			this.pbInstructionsUserManual.Location = new System.Drawing.Point(8, 8);
			this.pbInstructionsUserManual.Name = "pbInstructionsUserManual";
			this.pbInstructionsUserManual.Size = new System.Drawing.Size(81, 104);
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
			this.pbInstructionsHowTo.Location = new System.Drawing.Point(831, 8);
			this.pbInstructionsHowTo.Name = "pbInstructionsHowTo";
			this.pbInstructionsHowTo.Size = new System.Drawing.Size(81, 104);
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
			this.pbInstructionsBanner.Location = new System.Drawing.Point(8, 8);
			this.pbInstructionsBanner.Name = "pbInstructionsBanner";
			this.pbInstructionsBanner.Size = new System.Drawing.Size(904, 104);
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
			this.rtbHelp.Location = new System.Drawing.Point(4, 120);
			this.rtbHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbHelp.Name = "rtbHelp";
			this.rtbHelp.ReadOnly = true;
			this.rtbHelp.Size = new System.Drawing.Size(912, 425);
			this.rtbHelp.TabIndex = 0;
			this.rtbHelp.Text = "";
			this.rtbHelp.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LinkClicked);
			this.rtbHelp.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
			// 
			// tpAbout
			// 
			this.tpAbout.BackColor = System.Drawing.SystemColors.Control;
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
			this.tpAbout.Location = new System.Drawing.Point(4, 35);
			this.tpAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpAbout.Name = "tpAbout";
			this.tpAbout.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpAbout.Size = new System.Drawing.Size(920, 550);
			this.tpAbout.TabIndex = 3;
			this.tpAbout.Text = "About";
			// 
			// pbAboutUserManual
			// 
			this.pbAboutUserManual.Image = ((System.Drawing.Image)(resources.GetObject("pbAboutUserManual.Image")));
			this.pbAboutUserManual.Location = new System.Drawing.Point(7, 8);
			this.pbAboutUserManual.Name = "pbAboutUserManual";
			this.pbAboutUserManual.Size = new System.Drawing.Size(81, 104);
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
			this.pbAboutHowTo.Location = new System.Drawing.Point(831, 8);
			this.pbAboutHowTo.Name = "pbAboutHowTo";
			this.pbAboutHowTo.Size = new System.Drawing.Size(81, 104);
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
			this.lblLastChecked.Location = new System.Drawing.Point(259, 158);
			this.lblLastChecked.Name = "lblLastChecked";
			this.lblLastChecked.Size = new System.Drawing.Size(404, 40);
			this.lblLastChecked.TabIndex = 9;
			this.lblLastChecked.Text = "Last Checked: Never";
			this.lblLastChecked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cobCheckForUpdates
			// 
			this.cobCheckForUpdates.FormattingEnabled = true;
			this.cobCheckForUpdates.Items.AddRange(new object[] {
			"Check for updates daily.",
			"Check for updates weekly.",
			"Check for updates monthly."});
			this.cobCheckForUpdates.Location = new System.Drawing.Point(9, 162);
			this.cobCheckForUpdates.Name = "cobCheckForUpdates";
			this.cobCheckForUpdates.Size = new System.Drawing.Size(243, 28);
			this.cobCheckForUpdates.TabIndex = 2;
			this.cobCheckForUpdates.Text = "Check for updates daily.";
			// 
			// btnCheckNow
			// 
			this.btnCheckNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCheckNow.Location = new System.Drawing.Point(669, 154);
			this.btnCheckNow.Name = "btnCheckNow";
			this.btnCheckNow.Size = new System.Drawing.Size(243, 40);
			this.btnCheckNow.TabIndex = 3;
			this.btnCheckNow.Text = "Check for updates now!";
			this.btnCheckNow.UseVisualStyleBackColor = true;
			this.btnCheckNow.Click += new System.EventHandler(this.BtnCheckNowClick);
			// 
			// pbAboutBanner
			// 
			this.pbAboutBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pbAboutBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbAboutBanner.Image")));
			this.pbAboutBanner.Location = new System.Drawing.Point(7, 8);
			this.pbAboutBanner.Name = "pbAboutBanner";
			this.pbAboutBanner.Size = new System.Drawing.Size(905, 104);
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
			this.lblCopyLeft.Location = new System.Drawing.Point(713, 127);
			this.lblCopyLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCopyLeft.Name = "lblCopyLeft";
			this.lblCopyLeft.Size = new System.Drawing.Size(200, 23);
			this.lblCopyLeft.TabIndex = 2;
			this.lblCopyLeft.Text = "© 2016 Modi";
			this.lblCopyLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rtbCopyright
			// 
			this.rtbCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbCopyright.Location = new System.Drawing.Point(0, 204);
			this.rtbCopyright.Name = "rtbCopyright";
			this.rtbCopyright.ReadOnly = true;
			this.rtbCopyright.Size = new System.Drawing.Size(912, 372);
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
			this.lblVersion.Location = new System.Drawing.Point(9, 127);
			this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(99, 23);
			this.lblVersion.TabIndex = 1;
			this.lblVersion.Text = "x.x.x";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// llMovieFileMergerOrg
			// 
			this.llMovieFileMergerOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.llMovieFileMergerOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llMovieFileMergerOrg.Location = new System.Drawing.Point(8, 112);
			this.llMovieFileMergerOrg.Name = "llMovieFileMergerOrg";
			this.llMovieFileMergerOrg.Size = new System.Drawing.Size(904, 43);
			this.llMovieFileMergerOrg.TabIndex = 1;
			this.llMovieFileMergerOrg.TabStop = true;
			this.llMovieFileMergerOrg.Text = "www.Movie-File-Merger.org";
			this.llMovieFileMergerOrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.llMovieFileMergerOrg.Click += new System.EventHandler(this.LlMovieFileMergerOrgClick);
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
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(928, 589);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(928, 644);
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
			this.ssMFM.Size = new System.Drawing.Size(928, 30);
			this.ssMFM.TabIndex = 0;
			// 
			// tsslMFM
			// 
			this.tsslMFM.Name = "tsslMFM";
			this.tsslMFM.Size = new System.Drawing.Size(611, 25);
			this.tsslMFM.Spring = true;
			this.tsslMFM.Text = "Welcome to MFM";
			this.tsslMFM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tspbMFM
			// 
			this.tspbMFM.Name = "tspbMFM";
			this.tspbMFM.Size = new System.Drawing.Size(300, 24);
			// 
			// ttMovieFileMerger
			// 
			this.ttMovieFileMerger.AutoPopDelay = 10000;
			this.ttMovieFileMerger.InitialDelay = 500;
			this.ttMovieFileMerger.IsBalloon = true;
			this.ttMovieFileMerger.ReshowDelay = 100;
			this.ttMovieFileMerger.ShowAlways = true;
			// 
			// ofdTeraCopy
			// 
			this.ofdTeraCopy.FileName = "C:\\Program Files\\TeraCopy\\TeraCopy.exe";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(928, 644);
			this.Controls.Add(this.toolStripContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(950, 700);
			this.Name = "MainForm";
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
			((System.ComponentModel.ISupportInitialize)(this.pbMaintenanceUserManual)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMFM)).EndInit();
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
		private System.Windows.Forms.PictureBox pbMFM;
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
		private System.Windows.Forms.DomainUpDown dudMinimumResolution;
		private System.Windows.Forms.ComboBox cobSearchDownload;
		private System.Windows.Forms.ComboBox cobSearchInfo;
		private System.Windows.Forms.OpenFileDialog ofdTeraCopy;
		private System.Windows.Forms.Button btnResetSettings;
		private System.Windows.Forms.ComboBox cobDoubleClickDefault;
	}
}
