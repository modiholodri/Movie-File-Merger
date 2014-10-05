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
			this.lblToolTipRegex = new System.Windows.Forms.Label();
			this.tbNickName = new System.Windows.Forms.TextBox();
			this.lblNickName = new System.Windows.Forms.Label();
			this.tbToolTipRegex = new System.Windows.Forms.TextBox();
			this.cbMediaInfo = new System.Windows.Forms.CheckBox();
			this.lblTargetFolder = new System.Windows.Forms.Label();
			this.lblImportFolder = new System.Windows.Forms.Label();
			this.btnExportList = new System.Windows.Forms.Button();
			this.btnEraseColor = new System.Windows.Forms.Button();
			this.btnSearchTorrentz = new System.Windows.Forms.Button();
			this.btnMediaInfo = new System.Windows.Forms.Button();
			this.btnEraseSelected = new System.Windows.Forms.Button();
			this.scFolders = new System.Windows.Forms.SplitContainer();
			this.tbTargetFolder = new System.Windows.Forms.TextBox();
			this.tbImportFolder = new System.Windows.Forms.TextBox();
			this.btnSearchIMDb = new System.Windows.Forms.Button();
			this.gbTypeSelection = new System.Windows.Forms.GroupBox();
			this.rbMiscellaneous = new System.Windows.Forms.RadioButton();
			this.rbAdults = new System.Windows.Forms.RadioButton();
			this.rbClips = new System.Windows.Forms.RadioButton();
			this.rbSeries = new System.Windows.Forms.RadioButton();
			this.rbDocumentaries = new System.Windows.Forms.RadioButton();
			this.rbMovies = new System.Windows.Forms.RadioButton();
			this.gbProcessImport = new System.Windows.Forms.GroupBox();
			this.pbProcess = new System.Windows.Forms.ProgressBar();
			this.cbKeepFolders = new System.Windows.Forms.CheckBox();
			this.rbMove = new System.Windows.Forms.RadioButton();
			this.rbCopy = new System.Windows.Forms.RadioButton();
			this.btnPlay = new System.Windows.Forms.Button();
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
			this.tpSettings = new System.Windows.Forms.TabPage();
			this.gbSupportingPrograms = new System.Windows.Forms.GroupBox();
			this.lblTeraCopyPath = new System.Windows.Forms.Label();
			this.tbMediaInfoPath = new System.Windows.Forms.TextBox();
			this.lblMediaInfoPath = new System.Windows.Forms.Label();
			this.tbTeraCopyPath = new System.Windows.Forms.TextBox();
			this.rtbSettings = new System.Windows.Forms.RichTextBox();
			this.gbSettingsNameUnification = new System.Windows.Forms.GroupBox();
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
			this.lblVideoExtensions = new System.Windows.Forms.Label();
			this.tbVideoExtensionsRegex = new System.Windows.Forms.TextBox();
			this.tpLog = new System.Windows.Forms.TabPage();
			this.rtbLog = new System.Windows.Forms.RichTextBox();
			this.tpAbout = new System.Windows.Forms.TabPage();
			this.tbCopyright = new System.Windows.Forms.RichTextBox();
			this.pbAbout = new System.Windows.Forms.PictureBox();
			this.lblCopyLeft = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblMovieFileMerger = new System.Windows.Forms.Label();
			this.tpHelp = new System.Windows.Forms.TabPage();
			this.rtbHelp = new System.Windows.Forms.RichTextBox();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.ttMovieFileMerger = new System.Windows.Forms.ToolTip(this.components);
			this.tcMovieFileMerger.SuspendLayout();
			this.tpSeparateLists.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scFolders)).BeginInit();
			this.scFolders.Panel1.SuspendLayout();
			this.scFolders.Panel2.SuspendLayout();
			this.scFolders.SuspendLayout();
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
			this.tpSettings.SuspendLayout();
			this.gbSupportingPrograms.SuspendLayout();
			this.gbSettingsNameUnification.SuspendLayout();
			this.gbSettingsConsideredFiles.SuspendLayout();
			this.tpLog.SuspendLayout();
			this.tpAbout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
			this.tpHelp.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
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
			this.ilMovieFileMerger.Images.SetKeyName(0, "Apply.gif");
			this.ilMovieFileMerger.Images.SetKeyName(1, "Color.gif");
			this.ilMovieFileMerger.Images.SetKeyName(2, "Copy.gif");
			this.ilMovieFileMerger.Images.SetKeyName(3, "Erase.gif");
			this.ilMovieFileMerger.Images.SetKeyName(4, "Folder.gif");
			this.ilMovieFileMerger.Images.SetKeyName(5, "List.gif");
			this.ilMovieFileMerger.Images.SetKeyName(6, "Log.gif");
			this.ilMovieFileMerger.Images.SetKeyName(7, "Move.gif");
			this.ilMovieFileMerger.Images.SetKeyName(8, "Play.gif");
			this.ilMovieFileMerger.Images.SetKeyName(9, "Save.gif");
			this.ilMovieFileMerger.Images.SetKeyName(10, "Settings.gif");
			this.ilMovieFileMerger.Images.SetKeyName(11, "About.gif");
			this.ilMovieFileMerger.Images.SetKeyName(12, "Help.gif");
			this.ilMovieFileMerger.Images.SetKeyName(13, "Import.gif");
			this.ilMovieFileMerger.Images.SetKeyName(14, "IMDB.gif");
			this.ilMovieFileMerger.Images.SetKeyName(15, "Documentaries.gif");
			this.ilMovieFileMerger.Images.SetKeyName(16, "Series.gif");
			this.ilMovieFileMerger.Images.SetKeyName(17, "Clips.gif");
			this.ilMovieFileMerger.Images.SetKeyName(18, "Movie.gif");
			this.ilMovieFileMerger.Images.SetKeyName(19, "Poster.gif");
			this.ilMovieFileMerger.Images.SetKeyName(20, "Torrenz.gif");
			this.ilMovieFileMerger.Images.SetKeyName(21, "MediaInfo.gif");
			this.ilMovieFileMerger.Images.SetKeyName(22, "torrentzeu3.jpg");
			// 
			// tmrUpdateCounters
			// 
			this.tmrUpdateCounters.Enabled = true;
			this.tmrUpdateCounters.Interval = 500;
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
			this.tcMovieFileMerger.Controls.Add(this.tpSettings);
			this.tcMovieFileMerger.Controls.Add(this.tpLog);
			this.tcMovieFileMerger.Controls.Add(this.tpAbout);
			this.tcMovieFileMerger.Controls.Add(this.tpHelp);
			this.tcMovieFileMerger.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcMovieFileMerger.ImageList = this.ilMovieFileMerger;
			this.tcMovieFileMerger.Location = new System.Drawing.Point(0, 0);
			this.tcMovieFileMerger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tcMovieFileMerger.Name = "tcMovieFileMerger";
			this.tcMovieFileMerger.Padding = new System.Drawing.Point(9, 6);
			this.tcMovieFileMerger.SelectedIndex = 0;
			this.tcMovieFileMerger.Size = new System.Drawing.Size(938, 653);
			this.tcMovieFileMerger.TabIndex = 0;
			// 
			// tpSeparateLists
			// 
			this.tpSeparateLists.BackColor = System.Drawing.SystemColors.Control;
			this.tpSeparateLists.Controls.Add(this.lblToolTipRegex);
			this.tpSeparateLists.Controls.Add(this.tbNickName);
			this.tpSeparateLists.Controls.Add(this.lblNickName);
			this.tpSeparateLists.Controls.Add(this.tbToolTipRegex);
			this.tpSeparateLists.Controls.Add(this.cbMediaInfo);
			this.tpSeparateLists.Controls.Add(this.lblTargetFolder);
			this.tpSeparateLists.Controls.Add(this.lblImportFolder);
			this.tpSeparateLists.Controls.Add(this.btnExportList);
			this.tpSeparateLists.Controls.Add(this.btnEraseColor);
			this.tpSeparateLists.Controls.Add(this.btnSearchTorrentz);
			this.tpSeparateLists.Controls.Add(this.btnMediaInfo);
			this.tpSeparateLists.Controls.Add(this.btnEraseSelected);
			this.tpSeparateLists.Controls.Add(this.scFolders);
			this.tpSeparateLists.Controls.Add(this.btnSearchIMDb);
			this.tpSeparateLists.Controls.Add(this.gbTypeSelection);
			this.tpSeparateLists.Controls.Add(this.gbProcessImport);
			this.tpSeparateLists.Controls.Add(this.btnPlay);
			this.tpSeparateLists.Controls.Add(this.scVertical);
			this.tpSeparateLists.ImageKey = "List.gif";
			this.tpSeparateLists.Location = new System.Drawing.Point(4, 35);
			this.tpSeparateLists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSeparateLists.Name = "tpSeparateLists";
			this.tpSeparateLists.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSeparateLists.Size = new System.Drawing.Size(930, 614);
			this.tpSeparateLists.TabIndex = 0;
			this.tpSeparateLists.Text = "Lists";
			// 
			// lblToolTipRegex
			// 
			this.lblToolTipRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblToolTipRegex.Location = new System.Drawing.Point(329, 169);
			this.lblToolTipRegex.Name = "lblToolTipRegex";
			this.lblToolTipRegex.Size = new System.Drawing.Size(124, 23);
			this.lblToolTipRegex.TabIndex = 40;
			this.lblToolTipRegex.Text = "Tool Tip Regex";
			// 
			// tbNickName
			// 
			this.tbNickName.Location = new System.Drawing.Point(130, 166);
			this.tbNickName.Name = "tbNickName";
			this.tbNickName.Size = new System.Drawing.Size(120, 26);
			this.tbNickName.TabIndex = 39;
			this.tbNickName.Text = "Modi";
			// 
			// lblNickName
			// 
			this.lblNickName.Location = new System.Drawing.Point(12, 169);
			this.lblNickName.Name = "lblNickName";
			this.lblNickName.Size = new System.Drawing.Size(109, 23);
			this.lblNickName.TabIndex = 38;
			this.lblNickName.Text = "Nick Name";
			// 
			// tbToolTipRegex
			// 
			this.tbToolTipRegex.AllowDrop = true;
			this.tbToolTipRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbToolTipRegex.Location = new System.Drawing.Point(458, 166);
			this.tbToolTipRegex.Name = "tbToolTipRegex";
			this.tbToolTipRegex.Size = new System.Drawing.Size(237, 26);
			this.tbToolTipRegex.TabIndex = 36;
			this.tbToolTipRegex.Text = "German";
			this.tbToolTipRegex.DragDrop += new System.Windows.Forms.DragEventHandler(this.TbToolTipRegexDragDrop);
			this.tbToolTipRegex.DragOver += new System.Windows.Forms.DragEventHandler(this.TbToolTipRegexDragOver);
			// 
			// cbMediaInfo
			// 
			this.cbMediaInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbMediaInfo.Location = new System.Drawing.Point(827, 164);
			this.cbMediaInfo.Name = "cbMediaInfo";
			this.cbMediaInfo.Size = new System.Drawing.Size(90, 33);
			this.cbMediaInfo.TabIndex = 37;
			this.cbMediaInfo.Text = "ALL";
			this.cbMediaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ttMovieFileMerger.SetToolTip(this.cbMediaInfo, "Check to get detailed media information (slows down the fetching).");
			this.cbMediaInfo.UseVisualStyleBackColor = true;
			// 
			// lblTargetFolder
			// 
			this.lblTargetFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTargetFolder.ImageKey = "Folder.gif";
			this.lblTargetFolder.ImageList = this.ilMovieFileMerger;
			this.lblTargetFolder.Location = new System.Drawing.Point(12, 17);
			this.lblTargetFolder.Name = "lblTargetFolder";
			this.lblTargetFolder.Size = new System.Drawing.Size(88, 23);
			this.lblTargetFolder.TabIndex = 36;
			this.lblTargetFolder.Text = "Target";
			this.lblTargetFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblImportFolder
			// 
			this.lblImportFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblImportFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblImportFolder.ImageKey = "Folder.gif";
			this.lblImportFolder.ImageList = this.ilMovieFileMerger;
			this.lblImportFolder.Location = new System.Drawing.Point(827, 17);
			this.lblImportFolder.Name = "lblImportFolder";
			this.lblImportFolder.Size = new System.Drawing.Size(90, 23);
			this.lblImportFolder.TabIndex = 35;
			this.lblImportFolder.Text = "Import";
			this.lblImportFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnExportList
			// 
			this.btnExportList.AllowDrop = true;
			this.btnExportList.BackColor = System.Drawing.SystemColors.Control;
			this.btnExportList.ImageKey = "Save.gif";
			this.btnExportList.ImageList = this.ilMovieFileMerger;
			this.btnExportList.Location = new System.Drawing.Point(18, 204);
			this.btnExportList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExportList.Name = "btnExportList";
			this.btnExportList.Size = new System.Drawing.Size(103, 70);
			this.btnExportList.TabIndex = 34;
			this.btnExportList.Text = "Export List...";
			this.btnExportList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExportList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnExportList, "Drop an item of a list here to export the complete list as .CSV file.");
			this.btnExportList.UseVisualStyleBackColor = true;
			this.btnExportList.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnExportListDragDrop);
			this.btnExportList.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// btnEraseColor
			// 
			this.btnEraseColor.AllowDrop = true;
			this.btnEraseColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEraseColor.ImageKey = "Color.gif";
			this.btnEraseColor.ImageList = this.ilMovieFileMerger;
			this.btnEraseColor.Location = new System.Drawing.Point(458, 204);
			this.btnEraseColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEraseColor.Name = "btnEraseColor";
			this.btnEraseColor.Size = new System.Drawing.Size(108, 70);
			this.btnEraseColor.TabIndex = 28;
			this.btnEraseColor.Text = "Erase Color";
			this.btnEraseColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEraseColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnEraseColor, "Drop an item with a color here to erase all items of the same color from a list.");
			this.btnEraseColor.UseVisualStyleBackColor = true;
			this.btnEraseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnEraseColorDragDrop);
			this.btnEraseColor.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// btnSearchTorrentz
			// 
			this.btnSearchTorrentz.AllowDrop = true;
			this.btnSearchTorrentz.ImageKey = "torrentzeu3.jpg";
			this.btnSearchTorrentz.ImageList = this.ilMovieFileMerger;
			this.btnSearchTorrentz.Location = new System.Drawing.Point(130, 204);
			this.btnSearchTorrentz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearchTorrentz.Name = "btnSearchTorrentz";
			this.btnSearchTorrentz.Size = new System.Drawing.Size(120, 70);
			this.btnSearchTorrentz.TabIndex = 33;
			this.btnSearchTorrentz.Text = "Search Torrentz";
			this.btnSearchTorrentz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearchTorrentz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnSearchTorrentz, "Drop items here to search for them on Torrentz.eu.");
			this.btnSearchTorrentz.UseVisualStyleBackColor = true;
			this.btnSearchTorrentz.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnSearchTorrentzDragDrop);
			this.btnSearchTorrentz.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// btnMediaInfo
			// 
			this.btnMediaInfo.AllowDrop = true;
			this.btnMediaInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMediaInfo.ImageKey = "MediaInfo.gif";
			this.btnMediaInfo.ImageList = this.ilMovieFileMerger;
			this.btnMediaInfo.Location = new System.Drawing.Point(816, 204);
			this.btnMediaInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnMediaInfo.Name = "btnMediaInfo";
			this.btnMediaInfo.Size = new System.Drawing.Size(101, 70);
			this.btnMediaInfo.TabIndex = 14;
			this.btnMediaInfo.Text = "Media Info";
			this.btnMediaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnMediaInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnMediaInfo, "Drop items here to show the details with Media Info.");
			this.btnMediaInfo.UseVisualStyleBackColor = true;
			this.btnMediaInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnMediaInfoDragDrop);
			this.btnMediaInfo.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// btnEraseSelected
			// 
			this.btnEraseSelected.AllowDrop = true;
			this.btnEraseSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEraseSelected.ImageKey = "Erase.gif";
			this.btnEraseSelected.ImageList = this.ilMovieFileMerger;
			this.btnEraseSelected.Location = new System.Drawing.Point(329, 204);
			this.btnEraseSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEraseSelected.Name = "btnEraseSelected";
			this.btnEraseSelected.Size = new System.Drawing.Size(120, 70);
			this.btnEraseSelected.TabIndex = 27;
			this.btnEraseSelected.Text = "Erase Selected";
			this.btnEraseSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEraseSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnEraseSelected, "Drop items here to erase them from a list.");
			this.btnEraseSelected.UseVisualStyleBackColor = true;
			this.btnEraseSelected.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnEraseSelectedDragDrop);
			this.btnEraseSelected.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// scFolders
			// 
			this.scFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.scFolders.BackColor = System.Drawing.SystemColors.Control;
			this.scFolders.Location = new System.Drawing.Point(121, 11);
			this.scFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.scFolders.Name = "scFolders";
			// 
			// scFolders.Panel1
			// 
			this.scFolders.Panel1.Controls.Add(this.tbTargetFolder);
			// 
			// scFolders.Panel2
			// 
			this.scFolders.Panel2.Controls.Add(this.tbImportFolder);
			this.scFolders.Size = new System.Drawing.Size(689, 34);
			this.scFolders.SplitterDistance = 261;
			this.scFolders.SplitterWidth = 6;
			this.scFolders.TabIndex = 25;
			// 
			// tbTargetFolder
			// 
			this.tbTargetFolder.AllowDrop = true;
			this.tbTargetFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbTargetFolder.Location = new System.Drawing.Point(0, 8);
			this.tbTargetFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbTargetFolder.Name = "tbTargetFolder";
			this.tbTargetFolder.ReadOnly = true;
			this.tbTargetFolder.Size = new System.Drawing.Size(261, 26);
			this.tbTargetFolder.TabIndex = 5;
			this.ttMovieFileMerger.SetToolTip(this.tbTargetFolder, "Drop a folder here to where the movies should be copied or moved.");
			this.tbTargetFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.TbTargetFolderDragDrop);
			this.tbTargetFolder.DragOver += new System.Windows.Forms.DragEventHandler(this.TbDragOver);
			// 
			// tbImportFolder
			// 
			this.tbImportFolder.AllowDrop = true;
			this.tbImportFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbImportFolder.Location = new System.Drawing.Point(0, 8);
			this.tbImportFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbImportFolder.Name = "tbImportFolder";
			this.tbImportFolder.ReadOnly = true;
			this.tbImportFolder.Size = new System.Drawing.Size(422, 26);
			this.tbImportFolder.TabIndex = 25;
			this.ttMovieFileMerger.SetToolTip(this.tbImportFolder, "Drop a folder with movies to process here.  Automatically set when files or folde" +
						"rs are dropped in the Import list.");
			this.tbImportFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.TbImportFolderDragDrop);
			this.tbImportFolder.DragOver += new System.Windows.Forms.DragEventHandler(this.TbDragOver);
			// 
			// btnSearchIMDb
			// 
			this.btnSearchIMDb.AllowDrop = true;
			this.btnSearchIMDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearchIMDb.ImageKey = "IMDB.gif";
			this.btnSearchIMDb.ImageList = this.ilMovieFileMerger;
			this.btnSearchIMDb.Location = new System.Drawing.Point(575, 204);
			this.btnSearchIMDb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearchIMDb.Name = "btnSearchIMDb";
			this.btnSearchIMDb.Size = new System.Drawing.Size(120, 70);
			this.btnSearchIMDb.TabIndex = 32;
			this.btnSearchIMDb.Text = "Search IMDb";
			this.btnSearchIMDb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearchIMDb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnSearchIMDb, "Drop items here to search for them on IMDb.com.");
			this.btnSearchIMDb.UseVisualStyleBackColor = true;
			this.btnSearchIMDb.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnSearchIMDbDragDrop);
			this.btnSearchIMDb.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
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
			this.gbTypeSelection.Location = new System.Drawing.Point(12, 58);
			this.gbTypeSelection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbTypeSelection.Name = "gbTypeSelection";
			this.gbTypeSelection.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbTypeSelection.Size = new System.Drawing.Size(447, 100);
			this.gbTypeSelection.TabIndex = 23;
			this.gbTypeSelection.TabStop = false;
			this.gbTypeSelection.Text = "Collections";
			// 
			// rbMiscellaneous
			// 
			this.rbMiscellaneous.Checked = true;
			this.rbMiscellaneous.ImageKey = "Movie.gif";
			this.rbMiscellaneous.ImageList = this.ilMovieFileMerger;
			this.rbMiscellaneous.Location = new System.Drawing.Point(146, 59);
			this.rbMiscellaneous.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbMiscellaneous.Name = "rbMiscellaneous";
			this.rbMiscellaneous.Size = new System.Drawing.Size(174, 37);
			this.rbMiscellaneous.TabIndex = 6;
			this.rbMiscellaneous.TabStop = true;
			this.rbMiscellaneous.Tag = "Miscellaneous";
			this.rbMiscellaneous.Text = "Miscellaneous";
			this.rbMiscellaneous.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbMiscellaneous.UseVisualStyleBackColor = true;
			this.rbMiscellaneous.CheckedChanged += new System.EventHandler(this.RbProjectTypeClick);
			// 
			// rbAdults
			// 
			this.rbAdults.ImageKey = "Movie.gif";
			this.rbAdults.ImageList = this.ilMovieFileMerger;
			this.rbAdults.Location = new System.Drawing.Point(18, 59);
			this.rbAdults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbAdults.Name = "rbAdults";
			this.rbAdults.Size = new System.Drawing.Size(120, 37);
			this.rbAdults.TabIndex = 4;
			this.rbAdults.Tag = "Adults";
			this.rbAdults.Text = "Adult";
			this.rbAdults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbAdults.UseVisualStyleBackColor = true;
			this.rbAdults.CheckedChanged += new System.EventHandler(this.RbProjectTypeClick);
			// 
			// rbClips
			// 
			this.rbClips.ImageKey = "Clips.gif";
			this.rbClips.ImageList = this.ilMovieFileMerger;
			this.rbClips.Location = new System.Drawing.Point(328, 59);
			this.rbClips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbClips.Name = "rbClips";
			this.rbClips.Size = new System.Drawing.Size(99, 37);
			this.rbClips.TabIndex = 3;
			this.rbClips.Tag = "Clips";
			this.rbClips.Text = "Clips";
			this.rbClips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbClips.UseVisualStyleBackColor = true;
			this.rbClips.CheckedChanged += new System.EventHandler(this.RbProjectTypeClick);
			// 
			// rbSeries
			// 
			this.rbSeries.ImageKey = "Series.gif";
			this.rbSeries.ImageList = this.ilMovieFileMerger;
			this.rbSeries.Location = new System.Drawing.Point(328, 23);
			this.rbSeries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbSeries.Name = "rbSeries";
			this.rbSeries.Size = new System.Drawing.Size(113, 37);
			this.rbSeries.TabIndex = 2;
			this.rbSeries.Tag = "Series";
			this.rbSeries.Text = "Series";
			this.rbSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbSeries.UseVisualStyleBackColor = true;
			this.rbSeries.CheckedChanged += new System.EventHandler(this.RbProjectTypeClick);
			// 
			// rbDocumentaries
			// 
			this.rbDocumentaries.ImageKey = "Documentaries.gif";
			this.rbDocumentaries.ImageList = this.ilMovieFileMerger;
			this.rbDocumentaries.Location = new System.Drawing.Point(146, 23);
			this.rbDocumentaries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbDocumentaries.Name = "rbDocumentaries";
			this.rbDocumentaries.Size = new System.Drawing.Size(174, 37);
			this.rbDocumentaries.TabIndex = 1;
			this.rbDocumentaries.Tag = "Documentaries";
			this.rbDocumentaries.Text = "Documentaries";
			this.rbDocumentaries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbDocumentaries.UseVisualStyleBackColor = true;
			this.rbDocumentaries.CheckedChanged += new System.EventHandler(this.RbProjectTypeClick);
			// 
			// rbMovies
			// 
			this.rbMovies.ImageKey = "Movie.gif";
			this.rbMovies.ImageList = this.ilMovieFileMerger;
			this.rbMovies.Location = new System.Drawing.Point(18, 23);
			this.rbMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbMovies.Name = "rbMovies";
			this.rbMovies.Size = new System.Drawing.Size(120, 37);
			this.rbMovies.TabIndex = 0;
			this.rbMovies.Tag = "Movies";
			this.rbMovies.Text = "Movies";
			this.rbMovies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbMovies.UseVisualStyleBackColor = true;
			this.rbMovies.CheckedChanged += new System.EventHandler(this.RbProjectTypeClick);
			// 
			// gbProcessImport
			// 
			this.gbProcessImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbProcessImport.Controls.Add(this.pbProcess);
			this.gbProcessImport.Controls.Add(this.cbKeepFolders);
			this.gbProcessImport.Controls.Add(this.rbMove);
			this.gbProcessImport.Controls.Add(this.rbCopy);
			this.gbProcessImport.Location = new System.Drawing.Point(484, 58);
			this.gbProcessImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbProcessImport.Name = "gbProcessImport";
			this.gbProcessImport.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbProcessImport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gbProcessImport.Size = new System.Drawing.Size(433, 100);
			this.gbProcessImport.TabIndex = 22;
			this.gbProcessImport.TabStop = false;
			this.gbProcessImport.Text = "Process Import";
			// 
			// pbProcess
			// 
			this.pbProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pbProcess.Location = new System.Drawing.Point(8, 65);
			this.pbProcess.Name = "pbProcess";
			this.pbProcess.Size = new System.Drawing.Size(407, 23);
			this.pbProcess.Step = 1;
			this.pbProcess.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.pbProcess.TabIndex = 35;
			this.ttMovieFileMerger.SetToolTip(this.pbProcess, "Click to start the processing.");
			this.pbProcess.Click += new System.EventHandler(this.PbProcessClick);
			// 
			// cbKeepFolders
			// 
			this.cbKeepFolders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cbKeepFolders.ImageKey = "Folder.gif";
			this.cbKeepFolders.ImageList = this.ilMovieFileMerger;
			this.cbKeepFolders.Location = new System.Drawing.Point(250, 24);
			this.cbKeepFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbKeepFolders.Name = "cbKeepFolders";
			this.cbKeepFolders.Size = new System.Drawing.Size(165, 37);
			this.cbKeepFolders.TabIndex = 26;
			this.cbKeepFolders.Text = "Keep Folders";
			this.cbKeepFolders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.cbKeepFolders, "Check to keep the import files in thier folder structure.");
			this.cbKeepFolders.UseVisualStyleBackColor = true;
			// 
			// rbMove
			// 
			this.rbMove.ImageKey = "Move.gif";
			this.rbMove.ImageList = this.ilMovieFileMerger;
			this.rbMove.Location = new System.Drawing.Point(130, 24);
			this.rbMove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbMove.Name = "rbMove";
			this.rbMove.Size = new System.Drawing.Size(120, 37);
			this.rbMove.TabIndex = 1;
			this.rbMove.Text = "Move";
			this.rbMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbMove.UseVisualStyleBackColor = true;
			// 
			// rbCopy
			// 
			this.rbCopy.Checked = true;
			this.rbCopy.ImageKey = "Copy.gif";
			this.rbCopy.ImageList = this.ilMovieFileMerger;
			this.rbCopy.Location = new System.Drawing.Point(8, 24);
			this.rbCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbCopy.Name = "rbCopy";
			this.rbCopy.Size = new System.Drawing.Size(120, 37);
			this.rbCopy.TabIndex = 0;
			this.rbCopy.TabStop = true;
			this.rbCopy.Text = "Copy";
			this.rbCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbCopy.UseVisualStyleBackColor = true;
			// 
			// btnPlay
			// 
			this.btnPlay.AllowDrop = true;
			this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPlay.ImageKey = "Play.gif";
			this.btnPlay.ImageList = this.ilMovieFileMerger;
			this.btnPlay.Location = new System.Drawing.Point(704, 204);
			this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(103, 70);
			this.btnPlay.TabIndex = 31;
			this.btnPlay.Text = "Play Video";
			this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnPlay, "Drop an item here to play it with your movie player.");
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnPlayDragDrop);
			this.btnPlay.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// scVertical
			// 
			this.scVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.scVertical.BackColor = System.Drawing.SystemColors.Control;
			this.scVertical.Location = new System.Drawing.Point(8, 284);
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
			this.scVertical.Size = new System.Drawing.Size(913, 325);
			this.scVertical.SplitterDistance = 298;
			this.scVertical.SplitterWidth = 6;
			this.scVertical.TabIndex = 7;
			this.scVertical.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ScVerticalSplitterMoved);
			// 
			// lvExisting
			// 
			this.lvExisting.AllowDrop = true;
			this.lvExisting.BackColor = System.Drawing.SystemColors.Window;
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
			this.lvExisting.Size = new System.Drawing.Size(298, 325);
			this.lvExisting.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvExisting.TabIndex = 0;
			this.lvExisting.Tag = "Existing";
			this.lvExisting.UseCompatibleStateImageBehavior = false;
			this.lvExisting.View = System.Windows.Forms.View.Details;
			this.lvExisting.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemDrag);
			this.lvExisting.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
			this.lvExisting.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
			this.lvExisting.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
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
			this.scVerticalRight.Size = new System.Drawing.Size(609, 325);
			this.scVerticalRight.SplitterDistance = 309;
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
			this.scHorizontal.Size = new System.Drawing.Size(309, 325);
			this.scHorizontal.SplitterDistance = 147;
			this.scHorizontal.SplitterWidth = 6;
			this.scHorizontal.TabIndex = 0;
			// 
			// lvWish
			// 
			this.lvWish.AllowDrop = true;
			this.lvWish.BackColor = System.Drawing.SystemColors.Window;
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
			this.lvWish.Size = new System.Drawing.Size(309, 147);
			this.lvWish.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvWish.TabIndex = 1;
			this.lvWish.Tag = "Wish";
			this.lvWish.UseCompatibleStateImageBehavior = false;
			this.lvWish.View = System.Windows.Forms.View.Details;
			this.lvWish.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemDrag);
			this.lvWish.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
			this.lvWish.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
			this.lvWish.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
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
			this.lvGarbage.Size = new System.Drawing.Size(309, 172);
			this.lvGarbage.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvGarbage.TabIndex = 1;
			this.lvGarbage.Tag = "Garbage";
			this.lvGarbage.UseCompatibleStateImageBehavior = false;
			this.lvGarbage.View = System.Windows.Forms.View.Details;
			this.lvGarbage.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemDrag);
			this.lvGarbage.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
			this.lvGarbage.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
			this.lvGarbage.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
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
			this.lvImport.Size = new System.Drawing.Size(294, 325);
			this.lvImport.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvImport.TabIndex = 0;
			this.lvImport.Tag = "Import";
			this.lvImport.TileSize = new System.Drawing.Size(1, 1);
			this.lvImport.UseCompatibleStateImageBehavior = false;
			this.lvImport.View = System.Windows.Forms.View.Details;
			this.lvImport.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemDrag);
			this.lvImport.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
			this.lvImport.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
			this.lvImport.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
			this.lvImport.DoubleClick += new System.EventHandler(this.LvDoubleClick);
			this.lvImport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKeyDown);
			this.lvImport.MouseEnter += new System.EventHandler(this.LvMouseEnter);
			// 
			// chNameImport
			// 
			this.chNameImport.Text = "Import";
			this.chNameImport.Width = 250;
			// 
			// tpSettings
			// 
			this.tpSettings.BackColor = System.Drawing.SystemColors.Control;
			this.tpSettings.Controls.Add(this.gbSupportingPrograms);
			this.tpSettings.Controls.Add(this.rtbSettings);
			this.tpSettings.Controls.Add(this.gbSettingsNameUnification);
			this.tpSettings.Controls.Add(this.gbSettingsConsideredFiles);
			this.tpSettings.ImageKey = "Settings.gif";
			this.tpSettings.Location = new System.Drawing.Point(4, 35);
			this.tpSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSettings.Name = "tpSettings";
			this.tpSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSettings.Size = new System.Drawing.Size(930, 614);
			this.tpSettings.TabIndex = 1;
			this.tpSettings.Text = "Settings";
			this.tpSettings.Leave += new System.EventHandler(this.TpSettingsLeave);
			// 
			// gbSupportingPrograms
			// 
			this.gbSupportingPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.gbSupportingPrograms.Controls.Add(this.lblTeraCopyPath);
			this.gbSupportingPrograms.Controls.Add(this.tbMediaInfoPath);
			this.gbSupportingPrograms.Controls.Add(this.lblMediaInfoPath);
			this.gbSupportingPrograms.Controls.Add(this.tbTeraCopyPath);
			this.gbSupportingPrograms.Location = new System.Drawing.Point(9, 300);
			this.gbSupportingPrograms.Name = "gbSupportingPrograms";
			this.gbSupportingPrograms.Size = new System.Drawing.Size(913, 101);
			this.gbSupportingPrograms.TabIndex = 8;
			this.gbSupportingPrograms.TabStop = false;
			this.gbSupportingPrograms.Text = "Supporting Programs Installation Paths";
			// 
			// lblTeraCopyPath
			// 
			this.lblTeraCopyPath.Location = new System.Drawing.Point(14, 31);
			this.lblTeraCopyPath.Name = "lblTeraCopyPath";
			this.lblTeraCopyPath.Size = new System.Drawing.Size(134, 23);
			this.lblTeraCopyPath.TabIndex = 6;
			this.lblTeraCopyPath.Text = "TeraCopy Path";
			// 
			// tbMediaInfoPath
			// 
			this.tbMediaInfoPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbMediaInfoPath.Location = new System.Drawing.Point(155, 60);
			this.tbMediaInfoPath.Name = "tbMediaInfoPath";
			this.tbMediaInfoPath.Size = new System.Drawing.Size(746, 26);
			this.tbMediaInfoPath.TabIndex = 7;
			this.tbMediaInfoPath.Text = "C:\\Program Files\\MediaInfo\\MediaInfo.exe";
			// 
			// lblMediaInfoPath
			// 
			this.lblMediaInfoPath.Location = new System.Drawing.Point(14, 63);
			this.lblMediaInfoPath.Name = "lblMediaInfoPath";
			this.lblMediaInfoPath.Size = new System.Drawing.Size(134, 23);
			this.lblMediaInfoPath.TabIndex = 6;
			this.lblMediaInfoPath.Text = "MediaInfo Path";
			// 
			// tbTeraCopyPath
			// 
			this.tbTeraCopyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbTeraCopyPath.Location = new System.Drawing.Point(155, 28);
			this.tbTeraCopyPath.Name = "tbTeraCopyPath";
			this.tbTeraCopyPath.Size = new System.Drawing.Size(746, 26);
			this.tbTeraCopyPath.TabIndex = 7;
			this.tbTeraCopyPath.Text = "C:\\Program Files\\TeraCopy\\TeraCopy.exe";
			// 
			// rtbSettings
			// 
			this.rtbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbSettings.Location = new System.Drawing.Point(9, 409);
			this.rtbSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbSettings.Name = "rtbSettings";
			this.rtbSettings.ReadOnly = true;
			this.rtbSettings.Size = new System.Drawing.Size(913, 195);
			this.rtbSettings.TabIndex = 3;
			this.rtbSettings.Text = "";
			this.rtbSettings.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LinkClicked);
			this.rtbSettings.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
			// 
			// gbSettingsNameUnification
			// 
			this.gbSettingsNameUnification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.gbSettingsNameUnification.Controls.Add(this.lblToLowerRegex);
			this.gbSettingsNameUnification.Controls.Add(this.tbToLowerRegex);
			this.gbSettingsNameUnification.Controls.Add(this.lblOnlyCharacters);
			this.gbSettingsNameUnification.Controls.Add(this.tbOnlyCharactersRegex);
			this.gbSettingsNameUnification.Controls.Add(this.lblEpisodesId);
			this.gbSettingsNameUnification.Controls.Add(this.tbEpisodesIdRegex);
			this.gbSettingsNameUnification.Controls.Add(this.lblCutNameBeforeRegex);
			this.gbSettingsNameUnification.Controls.Add(this.tbCutNameBeforeRegex);
			this.gbSettingsNameUnification.Location = new System.Drawing.Point(9, 119);
			this.gbSettingsNameUnification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbSettingsNameUnification.Name = "gbSettingsNameUnification";
			this.gbSettingsNameUnification.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbSettingsNameUnification.Size = new System.Drawing.Size(913, 173);
			this.gbSettingsNameUnification.TabIndex = 1;
			this.gbSettingsNameUnification.TabStop = false;
			this.gbSettingsNameUnification.Text = "Name Unification";
			// 
			// lblToLowerRegex
			// 
			this.lblToLowerRegex.Location = new System.Drawing.Point(12, 104);
			this.lblToLowerRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblToLowerRegex.Name = "lblToLowerRegex";
			this.lblToLowerRegex.Size = new System.Drawing.Size(198, 32);
			this.lblToLowerRegex.TabIndex = 26;
			this.lblToLowerRegex.Text = "Convert to Lower  Regex";
			// 
			// tbToLowerRegex
			// 
			this.tbToLowerRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbToLowerRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbToLowerRegex.Location = new System.Drawing.Point(261, 101);
			this.tbToLowerRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbToLowerRegex.Multiline = true;
			this.tbToLowerRegex.Name = "tbToLowerRegex";
			this.tbToLowerRegex.Size = new System.Drawing.Size(640, 26);
			this.tbToLowerRegex.TabIndex = 27;
			this.tbToLowerRegex.Text = " On | A | The | Of | And | Or | To | From | For | In | As | At | With";
			// 
			// lblOnlyCharacters
			// 
			this.lblOnlyCharacters.Location = new System.Drawing.Point(12, 68);
			this.lblOnlyCharacters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOnlyCharacters.Name = "lblOnlyCharacters";
			this.lblOnlyCharacters.Size = new System.Drawing.Size(198, 32);
			this.lblOnlyCharacters.TabIndex = 24;
			this.lblOnlyCharacters.Text = "Only Characters Regex";
			// 
			// tbOnlyCharactersRegex
			// 
			this.tbOnlyCharactersRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbOnlyCharactersRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbOnlyCharactersRegex.Location = new System.Drawing.Point(261, 65);
			this.tbOnlyCharactersRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbOnlyCharactersRegex.Name = "tbOnlyCharactersRegex";
			this.tbOnlyCharactersRegex.Size = new System.Drawing.Size(640, 26);
			this.tbOnlyCharactersRegex.TabIndex = 25;
			this.tbOnlyCharactersRegex.Text = "[^a-zA-Z0-9 -\'üöä]";
			// 
			// lblEpisodesId
			// 
			this.lblEpisodesId.Location = new System.Drawing.Point(12, 136);
			this.lblEpisodesId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEpisodesId.Name = "lblEpisodesId";
			this.lblEpisodesId.Size = new System.Drawing.Size(245, 32);
			this.lblEpisodesId.TabIndex = 22;
			this.lblEpisodesId.Text = "Episodes Identification Regex";
			// 
			// tbEpisodesIdRegex
			// 
			this.tbEpisodesIdRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbEpisodesIdRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEpisodesIdRegex.Location = new System.Drawing.Point(261, 133);
			this.tbEpisodesIdRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbEpisodesIdRegex.Name = "tbEpisodesIdRegex";
			this.tbEpisodesIdRegex.Size = new System.Drawing.Size(640, 26);
			this.tbEpisodesIdRegex.TabIndex = 23;
			this.tbEpisodesIdRegex.Text = ".s\\d+e\\d+| \\d+x\\d+| season \\d+ episode \\d+";
			// 
			// lblCutNameBeforeRegex
			// 
			this.lblCutNameBeforeRegex.Location = new System.Drawing.Point(12, 34);
			this.lblCutNameBeforeRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCutNameBeforeRegex.Name = "lblCutNameBeforeRegex";
			this.lblCutNameBeforeRegex.Size = new System.Drawing.Size(198, 32);
			this.lblCutNameBeforeRegex.TabIndex = 16;
			this.lblCutNameBeforeRegex.Text = "Cut Name before Regex";
			// 
			// tbCutNameBeforeRegex
			// 
			this.tbCutNameBeforeRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbCutNameBeforeRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCutNameBeforeRegex.Location = new System.Drawing.Point(261, 29);
			this.tbCutNameBeforeRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbCutNameBeforeRegex.Name = "tbCutNameBeforeRegex";
			this.tbCutNameBeforeRegex.Size = new System.Drawing.Size(640, 26);
			this.tbCutNameBeforeRegex.TabIndex = 17;
			this.tbCutNameBeforeRegex.Text = "(.[12][09]\\d\\d)|(cd[12])|x264|aac|720p|1080p|divx|xvid";
			// 
			// gbSettingsConsideredFiles
			// 
			this.gbSettingsConsideredFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.gbSettingsConsideredFiles.Controls.Add(this.lblAddonExtensions);
			this.gbSettingsConsideredFiles.Controls.Add(this.tbAddonExtensionsRegex);
			this.gbSettingsConsideredFiles.Controls.Add(this.lblVideoExtensions);
			this.gbSettingsConsideredFiles.Controls.Add(this.tbVideoExtensionsRegex);
			this.gbSettingsConsideredFiles.Location = new System.Drawing.Point(9, 10);
			this.gbSettingsConsideredFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbSettingsConsideredFiles.Name = "gbSettingsConsideredFiles";
			this.gbSettingsConsideredFiles.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbSettingsConsideredFiles.Size = new System.Drawing.Size(913, 100);
			this.gbSettingsConsideredFiles.TabIndex = 0;
			this.gbSettingsConsideredFiles.TabStop = false;
			this.gbSettingsConsideredFiles.Text = "Considered Files";
			// 
			// lblAddonExtensions
			// 
			this.lblAddonExtensions.Location = new System.Drawing.Point(8, 66);
			this.lblAddonExtensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAddonExtensions.Name = "lblAddonExtensions";
			this.lblAddonExtensions.Size = new System.Drawing.Size(245, 29);
			this.lblAddonExtensions.TabIndex = 22;
			this.lblAddonExtensions.Text = "Add-on Files Extensions Regex";
			// 
			// tbAddonExtensionsRegex
			// 
			this.tbAddonExtensionsRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbAddonExtensionsRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAddonExtensionsRegex.Location = new System.Drawing.Point(261, 63);
			this.tbAddonExtensionsRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbAddonExtensionsRegex.Name = "tbAddonExtensionsRegex";
			this.tbAddonExtensionsRegex.Size = new System.Drawing.Size(641, 26);
			this.tbAddonExtensionsRegex.TabIndex = 23;
			this.tbAddonExtensionsRegex.Text = "srt|sub";
			// 
			// lblVideoExtensions
			// 
			this.lblVideoExtensions.Location = new System.Drawing.Point(8, 30);
			this.lblVideoExtensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVideoExtensions.Name = "lblVideoExtensions";
			this.lblVideoExtensions.Size = new System.Drawing.Size(245, 29);
			this.lblVideoExtensions.TabIndex = 20;
			this.lblVideoExtensions.Text = "Video Files Extensions Regex";
			// 
			// tbVideoExtensionsRegex
			// 
			this.tbVideoExtensionsRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbVideoExtensionsRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbVideoExtensionsRegex.Location = new System.Drawing.Point(261, 27);
			this.tbVideoExtensionsRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbVideoExtensionsRegex.Name = "tbVideoExtensionsRegex";
			this.tbVideoExtensionsRegex.Size = new System.Drawing.Size(641, 26);
			this.tbVideoExtensionsRegex.TabIndex = 21;
			this.tbVideoExtensionsRegex.Text = "avi|mkv|mp4";
			// 
			// tpLog
			// 
			this.tpLog.Controls.Add(this.rtbLog);
			this.tpLog.ImageKey = "Log.gif";
			this.tpLog.Location = new System.Drawing.Point(4, 35);
			this.tpLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpLog.Name = "tpLog";
			this.tpLog.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpLog.Size = new System.Drawing.Size(930, 614);
			this.tpLog.TabIndex = 2;
			this.tpLog.Text = "Log";
			this.tpLog.UseVisualStyleBackColor = true;
			// 
			// rtbLog
			// 
			this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbLog.Location = new System.Drawing.Point(4, 5);
			this.rtbLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbLog.Name = "rtbLog";
			this.rtbLog.ReadOnly = true;
			this.rtbLog.Size = new System.Drawing.Size(922, 604);
			this.rtbLog.TabIndex = 0;
			this.rtbLog.Text = "";
			this.rtbLog.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
			// 
			// tpAbout
			// 
			this.tpAbout.BackColor = System.Drawing.SystemColors.Control;
			this.tpAbout.Controls.Add(this.tbCopyright);
			this.tpAbout.Controls.Add(this.pbAbout);
			this.tpAbout.Controls.Add(this.lblCopyLeft);
			this.tpAbout.Controls.Add(this.lblVersion);
			this.tpAbout.Controls.Add(this.lblMovieFileMerger);
			this.tpAbout.ImageKey = "About.gif";
			this.tpAbout.Location = new System.Drawing.Point(4, 35);
			this.tpAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpAbout.Name = "tpAbout";
			this.tpAbout.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpAbout.Size = new System.Drawing.Size(930, 614);
			this.tpAbout.TabIndex = 3;
			this.tpAbout.Text = "About";
			// 
			// tbCopyright
			// 
			this.tbCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbCopyright.Location = new System.Drawing.Point(7, 368);
			this.tbCopyright.Name = "tbCopyright";
			this.tbCopyright.Size = new System.Drawing.Size(915, 172);
			this.tbCopyright.TabIndex = 4;
			this.tbCopyright.Text = resources.GetString("tbCopyright.Text");
			// 
			// pbAbout
			// 
			this.pbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pbAbout.ErrorImage = null;
			this.pbAbout.Image = ((System.Drawing.Image)(resources.GetObject("pbAbout.Image")));
			this.pbAbout.ImageLocation = "";
			this.pbAbout.InitialImage = null;
			this.pbAbout.Location = new System.Drawing.Point(12, 10);
			this.pbAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbAbout.Name = "pbAbout";
			this.pbAbout.Size = new System.Drawing.Size(909, 216);
			this.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbAbout.TabIndex = 3;
			this.pbAbout.TabStop = false;
			// 
			// lblCopyLeft
			// 
			this.lblCopyLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblCopyLeft.BackColor = System.Drawing.Color.Transparent;
			this.lblCopyLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCopyLeft.Location = new System.Drawing.Point(13, 327);
			this.lblCopyLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCopyLeft.Name = "lblCopyLeft";
			this.lblCopyLeft.Size = new System.Drawing.Size(909, 35);
			this.lblCopyLeft.TabIndex = 2;
			this.lblCopyLeft.Text = "© 2013 Modi ";
			this.lblCopyLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblVersion
			// 
			this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblVersion.BackColor = System.Drawing.Color.Transparent;
			this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersion.Location = new System.Drawing.Point(12, 297);
			this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(909, 35);
			this.lblVersion.TabIndex = 1;
			this.lblVersion.Text = "2013-06-15";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMovieFileMerger
			// 
			this.lblMovieFileMerger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblMovieFileMerger.BackColor = System.Drawing.Color.Transparent;
			this.lblMovieFileMerger.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMovieFileMerger.Location = new System.Drawing.Point(12, 231);
			this.lblMovieFileMerger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMovieFileMerger.Name = "lblMovieFileMerger";
			this.lblMovieFileMerger.Size = new System.Drawing.Size(909, 66);
			this.lblMovieFileMerger.TabIndex = 0;
			this.lblMovieFileMerger.Text = "Video Collection Organizer";
			this.lblMovieFileMerger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tpHelp
			// 
			this.tpHelp.Controls.Add(this.rtbHelp);
			this.tpHelp.ImageKey = "Help.gif";
			this.tpHelp.Location = new System.Drawing.Point(4, 35);
			this.tpHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpHelp.Name = "tpHelp";
			this.tpHelp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpHelp.Size = new System.Drawing.Size(930, 614);
			this.tpHelp.TabIndex = 4;
			this.tpHelp.Text = "Instructions";
			this.tpHelp.UseVisualStyleBackColor = true;
			// 
			// rtbHelp
			// 
			this.rtbHelp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbHelp.Location = new System.Drawing.Point(4, 5);
			this.rtbHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbHelp.Name = "rtbHelp";
			this.rtbHelp.ReadOnly = true;
			this.rtbHelp.Size = new System.Drawing.Size(922, 604);
			this.rtbHelp.TabIndex = 0;
			this.rtbHelp.Text = "";
			this.rtbHelp.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LinkClicked);
			this.rtbHelp.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.AutoScroll = true;
			this.toolStripContainer1.ContentPanel.Controls.Add(this.tcMovieFileMerger);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(938, 653);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(938, 678);
			this.toolStripContainer1.TabIndex = 2;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(938, 678);
			this.Controls.Add(this.toolStripContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(960, 667);
			this.Name = "MainForm";
			this.Text = "Video Collection Organizer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MfFormClosing);
			this.Shown += new System.EventHandler(this.MfShown);
			this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
			this.tcMovieFileMerger.ResumeLayout(false);
			this.tpSeparateLists.ResumeLayout(false);
			this.tpSeparateLists.PerformLayout();
			this.scFolders.Panel1.ResumeLayout(false);
			this.scFolders.Panel1.PerformLayout();
			this.scFolders.Panel2.ResumeLayout(false);
			this.scFolders.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.scFolders)).EndInit();
			this.scFolders.ResumeLayout(false);
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
			this.tpSettings.ResumeLayout(false);
			this.gbSupportingPrograms.ResumeLayout(false);
			this.gbSupportingPrograms.PerformLayout();
			this.gbSettingsNameUnification.ResumeLayout(false);
			this.gbSettingsNameUnification.PerformLayout();
			this.gbSettingsConsideredFiles.ResumeLayout(false);
			this.gbSettingsConsideredFiles.PerformLayout();
			this.tpLog.ResumeLayout(false);
			this.tpAbout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
			this.tpHelp.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblToolTipRegex;
		private System.Windows.Forms.TextBox tbToolTipRegex;
		private System.Windows.Forms.GroupBox gbSupportingPrograms;
		private System.Windows.Forms.Label lblMediaInfoPath;
		private System.Windows.Forms.TextBox tbMediaInfoPath;
		private System.Windows.Forms.ToolTip ttMovieFileMerger;
		private System.Windows.Forms.CheckBox cbMediaInfo;
		private System.Windows.Forms.RichTextBox tbCopyright;
		private System.Windows.Forms.Label lblTeraCopyPath;
		private System.Windows.Forms.TextBox tbTeraCopyPath;
		private System.Windows.Forms.Label lblNickName;
		private System.Windows.Forms.TextBox tbNickName;
		private System.Windows.Forms.Label lblImportFolder;
		private System.Windows.Forms.Label lblTargetFolder;
		//private System.Diagnostics.PerformanceCounter performanceCounter1;
		private System.Windows.Forms.ProgressBar pbProcess;
		private System.Windows.Forms.Button btnExportList;
		private System.Windows.Forms.Button btnSearchIMDb;
		private System.Windows.Forms.Button btnSearchTorrentz;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnEraseSelected;
		private System.Windows.Forms.Button btnEraseColor;
		private System.Windows.Forms.CheckBox cbKeepFolders;
		private System.Windows.Forms.TabPage tpSeparateLists;
		private System.Windows.Forms.SplitContainer scVerticalRight;
		private System.Windows.Forms.ListView lvWish;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TabControl tcMovieFileMerger;
		private System.Windows.Forms.TextBox tbAddonExtensionsRegex;
		private System.Windows.Forms.Label lblAddonExtensions;
		private System.Windows.Forms.RadioButton rbAdults;
		private System.Windows.Forms.RadioButton rbMiscellaneous;
		private System.Windows.Forms.SplitContainer scFolders;
		private System.Windows.Forms.GroupBox gbTypeSelection;
		private System.Windows.Forms.TextBox tbImportFolder;
		private System.Windows.Forms.PictureBox pbAbout;
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
		private System.Windows.Forms.Label lblMovieFileMerger;
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
		private System.Windows.Forms.Button btnMediaInfo;
		private System.Windows.Forms.Label lblVideoExtensions;
		private System.Windows.Forms.TextBox tbVideoExtensionsRegex;
		private System.Windows.Forms.SaveFileDialog sfdMovieFileMerger;
		private System.Windows.Forms.Timer tmrUpdateCounters;
		private System.Windows.Forms.ListView lvGarbage;
		private System.Windows.Forms.Label lblCutNameBeforeRegex;
		private System.Windows.Forms.TextBox tbCutNameBeforeRegex;
		private System.Windows.Forms.FolderBrowserDialog fbdMovieFileMerger;
		private System.Windows.Forms.TextBox tbTargetFolder;
		private System.Windows.Forms.SplitContainer scVertical;
		private System.Windows.Forms.SplitContainer scHorizontal;
		private System.Windows.Forms.ListView lvExisting;
		private System.Windows.Forms.ListView lvImport;
	}
}
