/*
 * Created by SharpDevelop.
 * User: Reinhold Lauer
 * Date: 2012-04-09
 */
using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using MediaInfoLib;

namespace Movie_File_Merger
{
	/// <summary>
	/// Specialized application to copy movies.
	/// </summary>
	public partial class MainForm : Form
	{
		Color GarbageColor = Color.Red;
		Color ExistingColor = Color.YellowGreen;
		Color WishColor = Color.LawnGreen;
		Color NeutralColor = Color.White;
		string strCollectionType = "Miscellaneous";
		string strIMDbSearchType = "&s=tt";
		bool bExistingChanged = false;
		bool bGarbageChanged = false;
		bool bWishChanged = false;
		ListView lvDragSource = null;
		Color DragColor = Color.Red;
		string sPrivatePath = Path.Combine(Path.GetDirectoryName(Application.StartupPath), @"MFM Private\");
		string sCollectionsPath = Path.Combine(Path.GetDirectoryName(Application.StartupPath), @"MFM Collections\");
		string sTeraCopyListsPath = "";
		string sIniFilePath = "";

		Regex rgxVideoExtensions;
		Regex rgxAddonExtensions;
		Regex rgxEpisodesId;
		Regex rgxTrimBefore;
		Regex rgxAphanumeric;
		Regex rgxToLower;
		Regex rgxMultiSpace = new Regex(@"[ ]{2,}");
		Regex rgxNumber = new Regex(@"\d+");
		MediaInfo miThis = new MediaInfo();
		
		public MainForm()
		{
			InitializeComponent();
			if (!Directory.Exists(sPrivatePath)) Directory.CreateDirectory(sPrivatePath);
			if (!Directory.Exists(sCollectionsPath)) Directory.CreateDirectory(sCollectionsPath);
			sTeraCopyListsPath = Path.Combine(sPrivatePath, @"TeraCopy Lists\");
			if (!Directory.Exists(sTeraCopyListsPath)) Directory.CreateDirectory(sTeraCopyListsPath);
			sfdMovieFileMerger.InitialDirectory = sCollectionsPath;
			sIniFilePath = Path.Combine(sPrivatePath, "Movie File Merger.ini");
			if (!File.Exists(sIniFilePath)) File.Copy(Path.Combine(Application.StartupPath, "Movie File Merger.ini"), sIniFilePath);
			LoadSettings();
			this.Text = tbNickName.Text + " - Movie File Merger";

			try
			{
				rtbHelp.LoadFile(Path.Combine(Application.StartupPath, "Movie File Merger Instructions.rtf"), RichTextBoxStreamType.RichText);
			}
			catch (IOException e) { ShowInfo(e.Message); }
			try
			{
				rtbSettings.LoadFile(Path.Combine(Application.StartupPath, "Movie File Merger Settings.rtf"), RichTextBoxStreamType.RichText);
			}
			catch (IOException e) { ShowInfo(e.Message); }
			SetColumnWidth();
			AssignRegexes();
		}

		void AssignRegexes()
		{
			rgxVideoExtensions = new Regex(tbVideoExtensionsRegex.Text);
			rgxAddonExtensions = new Regex(tbAddonExtensionsRegex.Text);
			rgxEpisodesId = new Regex(tbEpisodesIdRegex.Text);
			rgxTrimBefore = new Regex(tbCutNameBeforeRegex.Text);
			rgxAphanumeric = new Regex(tbOnlyCharactersRegex.Text);
			rgxToLower = new Regex(tbToLowerRegex.Text);
		}
		
		void LoadSettings()
		{
			try
			{
				StreamReader srSettings = new StreamReader(sIniFilePath);
				tbVideoExtensionsRegex.Text = srSettings.ReadLine();
				tbAddonExtensionsRegex.Text = srSettings.ReadLine();
				tbEpisodesIdRegex.Text = srSettings.ReadLine();
				tbCutNameBeforeRegex.Text = srSettings.ReadLine();
				tbOnlyCharactersRegex.Text = srSettings.ReadLine();
				tbToLowerRegex.Text = srSettings.ReadLine();
				tbNickName.Text = srSettings.ReadLine();
				srSettings.Close();
			}
			catch (IOException e) { ShowInfo(e.Message + "\nUsing default settings..."); }
			if (tbNickName.Text == "Anonym") ShowInfo("Please enter your nick name in the Settings...");
			AssignRegexes();
		}
		
		void SaveSettings()
		{
			try
			{
				StreamWriter swSettings = new StreamWriter(sIniFilePath);
				swSettings.WriteLine(tbVideoExtensionsRegex.Text);
				swSettings.WriteLine(tbAddonExtensionsRegex.Text);
				swSettings.WriteLine(tbEpisodesIdRegex.Text);
				swSettings.WriteLine(tbCutNameBeforeRegex.Text);
				swSettings.WriteLine(tbOnlyCharactersRegex.Text);
				swSettings.WriteLine(tbToLowerRegex.Text);
				swSettings.WriteLine(tbNickName.Text);
				swSettings.Close();
			}
			catch (IOException e) { ShowInfo(e.Message); }
			AssignRegexes();
		}
		
		void InitListViewFromFile(ListView lvListView)
		{
			string strSerializationFileName = Path.Combine(sPrivatePath, lvListView.Tag + " " + strCollectionType + ".slv");
			lvListView.Items.Clear();

			if ( File.Exists(strSerializationFileName) )
			{
				DeserializeListView(lvListView, strSerializationFileName);
			}
			SetListViewChanged(lvListView, false);
		}
		
		string CleanName(string strMessyName)
		{
			string strCleanName = strMessyName.ToLower();
			
			if (rbSeries.Checked)
			{
				Match matchEpisodeId = rgxEpisodesId.Match(strCleanName);
				if ( matchEpisodeId.Success )
				{
					MatchCollection mcNumbers = rgxNumber.Matches(matchEpisodeId.Value);
					string strUnifiedEpisodeId = " s" + mcNumbers[0].Value.PadLeft(2, '0') +
						"e" + mcNumbers[1].Value.PadLeft(2, '0');
					strCleanName = strCleanName.Substring(0, matchEpisodeId.Index) + strUnifiedEpisodeId;
				}
			}
			else
			{
				Match matchTrimBefore = rgxTrimBefore.Match(strCleanName);
				if ( matchTrimBefore.Success )
				{
					strCleanName = strCleanName.Substring(0, matchTrimBefore.Index);
				}
			}
			
			strCleanName = rgxAphanumeric.Replace(strCleanName, @" ");
			strCleanName = rgxMultiSpace.Replace(strCleanName, @" ");
			strCleanName = strCleanName.Trim(' ');
			strCleanName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(strCleanName);
			
			MatchCollection mcToLower = rgxToLower.Matches(strCleanName);
			foreach (Match mToLower in mcToLower)
			{
				strCleanName = strCleanName.Replace(mToLower.Value, mToLower.Value.ToLower());
			}

			return strCleanName;
		}
		
		void SetListViewChanged(ListView lvThis, bool bChanged)
		{
			if ((string)lvThis.Tag == "Existing") bExistingChanged = bChanged;
			if ((string)lvThis.Tag == "Garbage") bGarbageChanged = bChanged;
			if ((string)lvThis.Tag == "Wish") bWishChanged = bChanged;
		}
		
		ListViewItem AddItemToListView(ListView lvThis, string strCleanName)
		{
			ListViewItem lviThis = FindItem(lvThis, strCleanName);
			if (lviThis == null)
			{
				lviThis = new ListViewItem(strCleanName);
				lvThis.Items.Add(lviThis);
				ColorAll(strCleanName);
				SetListViewChanged(lvThis, true);
			}
			return lviThis;
		}
		
		ListViewItem AddItemToListView(ListView lvThis, ListViewItem lviToAdd)
		{
			ListViewItem lviThis = FindItem(lvThis, lviToAdd.Text);
			if (lviThis == null)
			{
				lviThis = new ListViewItem(lviToAdd.Text);
				lviThis.ToolTipText = lviToAdd.ToolTipText;
				lvThis.Items.Add(lviThis);
				ColorAll(lviToAdd.Text);
				SetListViewChanged(lvThis, true);
			}
			return lviThis;
		}
		
		void AddCsvToListView(ListView lvThis, string strFileName)
		{
			string line;
			StreamReader srMovies = new StreamReader(strFileName);
			lvThis.BeginUpdate();
			lvThis.Sorting = SortOrder.None;
			SetStatus("Loading " + Path.GetFileNameWithoutExtension(strFileName) + " to " + lvThis.Tag + " " + strCollectionType + "...");
			while ((line = srMovies.ReadLine()) != null)
			{
				string[] saParts = line.Split('\t');
				ListViewItem lviThis = new ListViewItem(CleanName(saParts[0]));
				if (saParts.Length > 1) lviThis.ToolTipText = saParts[1].Replace('*', '\n');
				AddItemToListView(lvThis, lviThis);
			}
			if (rbSeries.Checked)
			{
				if ((string)lvThis.Tag == "Garbage") ColorExistingAndUp();
				if ((string)lvThis.Tag == "Wish") ColorWishAndUp();
			}
			lvThis.Sorting = SortOrder.Ascending;
			lvThis.EndUpdate();
			srMovies.Close();
			ClearStatus();
		}
		
		void AddTxtToListView(ListView lvThis, string strFileName)
		{
			string line;
			StreamReader srMovies = new StreamReader(strFileName);
			lvThis.BeginUpdate();
			lvThis.Sorting = SortOrder.None;
			SetStatus("Loading " + Path.GetFileNameWithoutExtension(strFileName) + " to " + lvThis.Tag + " " + strCollectionType + "...");

			string[] saTitles = new string[20];
			string[] saParts = new string[20];
			line = srMovies.ReadLine();
			if (line.StartsWith("Title\t")) 
			{
				saTitles = line.Split('\t');
				for (int i = 1; i < saTitles.Length; i++)
				{
					if (saTitles[i].Length > 1)  saTitles[i] += ":  ";
				}
				line = srMovies.ReadLine();
			}
			while (line != null)
			{
				saParts = line.Split('\t');
				ListViewItem lviThis = new ListViewItem( CleanName(saParts[0].Trim('"')));
				lviThis.ToolTipText = saParts[0] + "\n";
				for (int i = 1; i < saParts.Length; i++)
				{
					lviThis.ToolTipText += saTitles[i] + saParts[i] + "\n";
				}
				AddItemToListView(lvThis, lviThis);
				line = srMovies.ReadLine();
			} 

			if (rbSeries.Checked)
			{
				if ((string)lvThis.Tag == "Garbage") ColorExistingAndUp();
				if ((string)lvThis.Tag == "Wish") ColorWishAndUp();
			}
			lvThis.Sorting = SortOrder.Ascending;
			lvThis.EndUpdate();
			srMovies.Close();
			ClearStatus();
		}
		
		void AddFolderToListView(ListView lvThis, string strFolderName)
		{
			DirectoryInfo diFolder = new DirectoryInfo(strFolderName);
			SearchOption soMovieFileMerger = SearchOption.AllDirectories;

			SetStatus("Loading folder " + strFolderName + " to " + lvThis.Tag + "...");

			lvThis.BeginUpdate();
			lvThis.Sorting = SortOrder.None;
			pbProcess.Maximum = 1;
			pbProcess.Value = 0;
			foreach( FileInfo fiFile in diFolder.GetFiles("*", soMovieFileMerger))
			{
				if(rgxVideoExtensions.IsMatch(fiFile.Extension)) pbProcess.Maximum++;
			}
			foreach( FileInfo fiFile in diFolder.GetFiles("*", soMovieFileMerger))
			{
				if(!rgxVideoExtensions.IsMatch(fiFile.Extension))
				{
					continue;
				}
				string strJustName = fiFile.Name;
				if (strJustName.LastIndexOf('.') != -1)
				{
					strJustName = strJustName.Substring(0, strJustName.LastIndexOf('.'));
				}
				ListViewItem lviThis = new ListViewItem (CleanName(strJustName));
				lviThis.ToolTipText = ExtractVideoInfo(fiFile, FindItem(lvThis, lviThis.Text) == null);
				AddItemToListView(lvThis, lviThis);
				pbProcess.Value++;
			}
			if (rbSeries.Checked)
			{
				if ((string)lvThis.Tag == "Garbage") ColorExistingAndUp();
				if ((string)lvThis.Tag == "Wish") ColorWishAndUp();
			}
			lvThis.Sorting = SortOrder.Ascending;
			lvThis.EndUpdate();
			pbProcess.Value = 0;
			ClearStatus();
		}
		
		void SaveListViewToCsvFile(ListView lvListView, string strFileName)
		{
			StreamWriter swFile = new StreamWriter(strFileName);
			
			foreach (ListViewItem lviItem in lvListView.Items)
			{
				swFile.WriteLine(lviItem.Text + "\t" + lviItem.ToolTipText.Replace('\n', '*'));
			}
			swFile.Close();
		}

		void ColorExistingAndUp()
		{
			ColorExisting();
			ColorWish();
			ColorImport();
		}
		
		void ColorExistingItem(ListViewItem lviExisting)
		{
			if (lviExisting == null) return;
			lviExisting.Selected = false;
			ListViewItem lviGarbage = FindItem(lvGarbage, RemoveEpisodeInfo(lviExisting.Text));
			if (lviGarbage != null)
			{
				lviExisting.BackColor = GarbageColor;
			}
			else
			{
				lviExisting.BackColor = ExistingColor;
			}
		}
		
		void ColorExisting()
		{
			SetStatus("Coloring " + strCollectionType + " in Existing list...");
			foreach (ListViewItem lviExisting in lvExisting.Items)
			{
				ColorExistingItem(lviExisting);
			}
			ClearStatus();
		}
		
		void ColorWishAndUp()
		{
			ColorWish();
			ColorImport();
		}
		
		void ColorWishItem(ListViewItem lviWish)
		{
			if (lviWish == null) return;
			lviWish.Selected = false;
			ListViewItem lviGarbage = FindItem(lvGarbage, RemoveEpisodeInfo(lviWish.Text));
			if (lviGarbage != null)
			{
				lviWish.BackColor = GarbageColor;
			}
			else
			{
				ListViewItem lviExisting;
				if (rbSeries.Checked) lviExisting = FindItemStart(lvExisting, lviWish.Text);
				else lviExisting = FindItem(lvExisting, lviWish.Text);
				if (lviExisting != null)
				{
					lviWish.BackColor = ExistingColor;
				}
				else
				{
					lviWish.BackColor = WishColor;
				}
			}
		}

		void ColorWish()
		{
			SetStatus("Coloring " + strCollectionType + " in Wish list...");
			foreach (ListViewItem lviWish in lvWish.Items)
			{
				ColorWishItem(lviWish);
			}
			ClearStatus();
		}

		void ColorImportItem(ListViewItem lviImport)
		{
			if (lviImport == null) return;
			lviImport.Selected = false;
			ListViewItem lviGarbage = FindItem(lvGarbage, RemoveEpisodeInfo(lviImport.Text));
			if (lviGarbage != null)
			{
				lviImport.BackColor = GarbageColor;
			}
			else
			{
				ListViewItem lviExisting = FindItem(lvExisting, lviImport.Text);
				if (lviExisting != null)
				{
					lviImport.BackColor = ExistingColor;
				}
				else
				{
					ListViewItem lviWish = FindItem(lvWish, RemoveEpisodeInfo(lviImport.Text));
					if (lviWish != null)
					{
						lviImport.BackColor = WishColor;
					}
					else
					{
						lviImport.BackColor = NeutralColor;
					}
				}
			}
		}

		void ColorAll(string strItemName)
		{
			ListViewItem lviGarbage = FindItem(lvGarbage, RemoveEpisodeInfo(strItemName));
			ListViewItem lviExisting;
			if (rbSeries.Checked) lviExisting = FindItemStart(lvExisting, strItemName);
			else lviExisting = FindItem(lvExisting, strItemName);
			ListViewItem lviWish = FindItem(lvWish, RemoveEpisodeInfo(strItemName));
			ListViewItem lviImport = FindItem(lvImport, strItemName);
			
			if (lviGarbage != null)
			{
				lviGarbage.BackColor = GarbageColor;
				if (lviExisting != null) lviExisting.BackColor = GarbageColor;
				if (lviWish != null) lviWish.BackColor = GarbageColor;
				if (lviImport != null) lviImport.BackColor = GarbageColor;
			}
			else if (lviExisting != null)
			{
				lviExisting.BackColor = ExistingColor;
				if (lviWish != null) lviWish.BackColor = ExistingColor;
				if (lviImport != null) lviImport.BackColor = ExistingColor;
			}
			else if (lviWish != null)
			{
				if (rbSeries.Checked) lviExisting = FindItemStart(lvExisting, RemoveEpisodeInfo(strItemName));
				lviExisting = FindItem(lvExisting, strItemName);
				if (lviExisting == null)	lviWish.BackColor = WishColor;
				if (lviImport != null) lviImport.BackColor = WishColor;
			}
			else if (lviImport != null)
			{
				lviImport.BackColor = NeutralColor;
			}
		}

		void ColorImport()
		{
			SetStatus("Coloring " + strCollectionType + " in Import list...");
			foreach (ListViewItem lviImport in lvImport.Items)
			{
				ColorImportItem(lviImport);
			}
			ClearStatus();
		}
		
		string MakeTargetPath(FileInfo fiImportFile)
		{
			string strTargetPath = "";
			if (!cbKeepFolders.Checked)
			{
				strTargetPath = tbTargetFolder.Text;
			}
			else
			{
				string sSubPath = fiImportFile.DirectoryName.Substring(fiImportFile.DirectoryName.IndexOf('\\')+1);
				strTargetPath = Path.Combine(tbTargetFolder.Text, sSubPath);
			}
			if(!Directory.Exists(strTargetPath))
			{
				Directory.CreateDirectory(strTargetPath);
			}
			return strTargetPath;
		}
		
		void ProcessImport()
		{
			if(!Directory.Exists(tbImportFolder.Text))
			{
				ShowInfo("Select a folder with the " + strCollectionType + " to import...");
				return;
			}
			if(!Directory.Exists(tbTargetFolder.Text))
			{
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
			
			foreach (ListViewItem lviThis in lvImport.Items)
			{
				if (lviThis.BackColor == WishColor) lviThis.Tag = true;
				else lviThis.Tag = false;
			}

			DirectoryInfo diImportFolder = new DirectoryInfo(tbImportFolder.Text);
			SearchOption soMovieFileMerger = SearchOption.AllDirectories;

			foreach( FileInfo fiImportFile in diImportFolder.GetFiles("*", soMovieFileMerger))
			{
				string strImportName = fiImportFile.Name;
				if (!rgxVideoExtensions.IsMatch(fiImportFile.Extension) &&
				    !rgxAddonExtensions.IsMatch(fiImportFile.Extension)) continue;
				
				if (strImportName.LastIndexOf('.') != -1)
				{
					strImportName = strImportName.Substring(0, strImportName.LastIndexOf('.'));
				}
				strImportName = CleanName(RemoveEpisodeInfo(strImportName));
				ListViewItem lviImport = FindItem(lvImport, strImportName);
				if (lviImport != null)
				{
					if((bool)lviImport.Tag == true)
					{
						sTargetPath = MakeTargetPath(fiImportFile);
						sSourceFile = fiImportFile.FullName; //" \"" +  + "\" ";
						
						if (sOldTargetPath != sTargetPath)
						{
							if(bSourceListOpen)
							{
								swSourceListFile.Close();
								bSourceListOpen = false;
								DoTeraCopy(sSourceListFileName, sOldTargetPath);
							}
							sOldTargetPath = sTargetPath;
						}
						if (!bSourceListOpen)
						{
							sSourceListFileName = "TeraCopy List - " + tbNickName.Text + " " +
								StandardizeDate(DateTime.Now) +  " " +
								StandardizeTime(DateTime.Now) + " " +
								sTargetPath.Replace("\\", " - ").Replace(':', ' ') +
								".tcl";
							sSourceListFileName = Path.Combine(sTeraCopyListsPath, sSourceListFileName);
							swSourceListFile = new StreamWriter(sSourceListFileName);
							bSourceListOpen = true;
							sOldTargetPath = sTargetPath;
						}

						if (rbCopy.Checked) LogMessage("Add to Source List", Color.Blue, "Copy " + sSourceFile + " -> " + sTargetPath);
						else LogMessage("Add to Source List", Color.Blue,  "Move " + sSourceFile + " -> " + sTargetPath);
						
						swSourceListFile.WriteLine(sSourceFile);
						AddItemToListView(lvExisting, lviImport);
					}
				}
			}
			if (bSourceListOpen)
			{
				swSourceListFile.Close();
				DoTeraCopy(sSourceListFileName, sOldTargetPath);
			}
			ShowInfo("Finished processing...");
			ClearStatus();
		}

		void DoTeraCopy(string sSourceListFile, string sTargetPath)
		{
			string sTeraCopy = tbTeraCopyPath.Text;
			string sOptions = " /SkipAll /Close ";
			
			try
			{
				if (rbCopy.Checked)
				{
					System.Diagnostics.Process.Start(sTeraCopy, "Copy *\"" + sSourceListFile + "\" \"" + sTargetPath + "\" " + sOptions);
					LogMessage("Add Source List", Color.Purple,  "TeraCopy " + sSourceListFile + " -> " + sTargetPath + sOptions);
				}
				else
				{
					System.Diagnostics.Process.Start(sTeraCopy, "Move *\"" + sSourceListFile + "\" \"" + sTargetPath + "\" "  + sOptions);
					LogMessage("Add Source List", Color.Purple,  "TeraMove " + sSourceListFile + " -> " + sTargetPath + sOptions);
				}
				System.Threading.Thread.Sleep(1000);
			}
			catch (IOException e)
			{
				ShowInfo(e.Message);
			}
		}

		ListViewItem FindItem(ListView lvListView, string strText)
		{
			if (lvListView.Items.Count < 1) return null;
			return lvListView.FindItemWithText(strText, false, 0, false);
		}

		ListViewItem FindItemStart(ListView lvListView, string strText)
		{
			if (lvListView.Items.Count < 1) return null;
			ListViewItem lviThis = lvListView.FindItemWithText(strText);
			if (lviThis != null)
			{
				if (lviThis.Text.Length >= strText.Length)
				{
					if (lviThis.Text.Substring(0,strText.Length) == strText) return lviThis;
				}
			}
			return null;
		}

		void Play()
		{
			if(!Directory.Exists(tbImportFolder.Text))
			{
				ShowInfo("Select a folder with the " + strCollectionType + " to import...");
				return;
			}

			DirectoryInfo diImportFolder = new DirectoryInfo(tbImportFolder.Text);
			SearchOption soMovieFileMerger = SearchOption.AllDirectories;

			foreach( FileInfo fiImportFile in diImportFolder.GetFiles("*", soMovieFileMerger))
			{
				if (!rgxVideoExtensions.IsMatch(fiImportFile.Extension)) continue;
				
				string strImportName = fiImportFile.Name;
				if (fiImportFile.Name.LastIndexOf('.') != -1)
				{
					strImportName = strImportName.Substring(0, fiImportFile.Name.LastIndexOf('.'));
				}
				strImportName = CleanName(strImportName);
				ListViewItem lviImport = FindItem(lvImport, strImportName);
				if (lviImport != null)
				{
					if(lviImport.Selected)
					{
						SetStatus("Playing " + fiImportFile.Name + "...");
						try
						{
							System.Diagnostics.Process.Start(fiImportFile.FullName);
						}
						catch (Exception e) { ShowInfo(e.Message); }
					}
				}
				ClearStatus();
			}
		}
		
		void GetMediaInfo()
		{
			if(!Directory.Exists(tbImportFolder.Text))
			{
				ShowInfo("Select a folder with the " + strCollectionType + " to import...");
				return;
			}

			DirectoryInfo diImportFolder = new DirectoryInfo(tbImportFolder.Text);
			SearchOption soMovieFileMerger = SearchOption.AllDirectories;

			foreach( FileInfo fiImportFile in diImportFolder.GetFiles("*", soMovieFileMerger))
			{
				if (!rgxVideoExtensions.IsMatch(fiImportFile.Extension)) continue;
				
				string strImportName = fiImportFile.Name;
				if (fiImportFile.Name.LastIndexOf('.') != -1)
				{
					strImportName = strImportName.Substring(0, fiImportFile.Name.LastIndexOf('.'));
				}
				strImportName = CleanName(strImportName);
				ListViewItem lviImport = FindItem(lvImport, strImportName);
				if (lviImport != null)
				{
					if(lviImport.Selected)
					{
						SetStatus("Getting MediaInfo for " + fiImportFile.Name + "...");
						try
						{
							System.Diagnostics.Process.Start(tbMediaInfoPath.Text, " \"" + fiImportFile.FullName + "\"");
						}
						catch (Exception e) { ShowInfo(e.Message); }
					}
				}
				ClearStatus();
			}
		}
		
		void LogMessage(string strType, Color cColor, string strMessage)
		{
			rtbLog.SelectionColor = cColor;
			rtbLog.AppendText(DateTime.Now + ": " + strType + " - " + strMessage + "\n");
		}
		
		void SetStatus(string strStatus)
		{
			LogMessage("Status", Color.Black, strStatus);
			Cursor.Current = Cursors.WaitCursor;
		}
		
		void ClearStatus()
		{
			Cursor.Current = Cursors.Default;
		}
		
		DialogResult ShowInfo(string strMessage)
		{
			LogMessage("Info", Color.Blue, strMessage);
			return MessageBox.Show(strMessage, "Movie File Merger - Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		
		DialogResult ShowError(string strMessage)
		{
			LogMessage("Error", Color.Red, strMessage);
			return MessageBox.Show(strMessage, "Movie File Merger - Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
		}
		
		DialogResult ShowYesNoQuestion(string strMessage)
		{
			return MessageBox.Show(strMessage, "Movie File Merger - Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		void SetColumnWidth()
		{
			if (this.WindowState == FormWindowState.Minimized)	// Not if minimized
			{
				return;
			}
			int iColumnWidth = (this.Size.Width - 37) / 3;
			scVertical.SplitterDistance = iColumnWidth;
			scVerticalRight.Width = iColumnWidth * 2;
			scVerticalRight.SplitterDistance = iColumnWidth + 3;
			scVerticalRight.SplitterWidth = 3;
			lvExisting.Columns[0].Width = lvExisting.Width - 35;
			lvGarbage.Columns[0].Width = lvGarbage.Width - 35;
			lvImport.Columns[0].Width = lvImport.Width - 35;
			lvWish.Columns[0].Width = lvWish.Width - 35;
		}

		void EraseSelected(ListView lvThis)
		{
			SetListViewChanged(lvThis, true);
			foreach (ListViewItem lviItem in lvThis.SelectedItems)
			{
				lvThis.Items.Remove(lviItem);
				ColorAll(lviItem.Text);
			}
			if (rbSeries.Checked)
			{
				if ((string)lvThis.Tag == "Garbage") ColorExistingAndUp();
				if ((string)lvThis.Tag == "Existing") ColorWishAndUp();
				if ((string)lvThis.Tag == "Wish") ColorImport();
			}
		}
		
		/******************/
		/* user interface */
		/******************/
		void BtnBrowseTargetFolderClick(object sender, EventArgs e)
		{
		}
		
		void PbProcessClick(object sender, EventArgs e)
		{
			ProcessImport();
		}

		void TmrUpdateCountersTick(object sender, EventArgs e)
		{
			lvExisting.Columns[0].Text = lvExisting.Items.Count + " Existing " + strCollectionType;
			lvGarbage.Columns[0].Text = lvGarbage.Items.Count + " Garbage " + strCollectionType;
			lvImport.Columns[0].Text = lvImport.Items.Count + " Import " + strCollectionType;
			lvWish.Columns[0].Text = lvWish.Items.Count + " Wish " + strCollectionType;
		}

		void ScVerticalSplitterMoved(object sender, SplitterEventArgs e)
		{
			SetColumnWidth();
		}

		void SaveChangedListView(ListView lvListView)
		{
			string strName = lvListView.Tag + " " +  strCollectionType;
			
			if ((lvListView.Tag.ToString() == "Existing" && bExistingChanged) ||
			    (lvListView.Tag.ToString() == "Wish" && bWishChanged) ||
			    (lvListView.Tag.ToString() == "Garbage" && bGarbageChanged))
			{
				if (ShowYesNoQuestion("Save " + strName + "?") == DialogResult.Yes)
				{
					SerializeListView(lvListView, Path.Combine(sPrivatePath, strName + ".slv"));
				}
			}
		}

		void RbProjectTypeClick(object sender, EventArgs e)
		{
			RadioButton rbRadioButton = (RadioButton)sender;
			if (rbRadioButton.Checked)
			{
				strCollectionType = rbRadioButton.Tag.ToString();
				lvImport.Items.Clear();
				InitListViewFromFile(lvGarbage);
				InitListViewFromFile(lvExisting);
				InitListViewFromFile(lvWish);
			}
			else
			{
				SaveChangedListView(lvGarbage);
				SaveChangedListView(lvExisting);
				SaveChangedListView(lvWish);
			}
		}
		
		void MfFormClosing(object sender, FormClosingEventArgs e)
		{
			SaveChangedListView(lvExisting);
			SaveChangedListView(lvGarbage);
			SaveChangedListView(lvWish);
			SaveSettings();
		}
		
		void LvMouseEnter(object sender, EventArgs e)
		{
			((ListView)sender).Select();
		}
		
		void RtbMouseEnter(object sender, System.EventArgs e)
		{
			((RichTextBox)sender).Focus();
		}
		
		void LinkClicked(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}
		
		string RemoveEpisodeInfo(string strCleanName)
		{
			if (rbSeries.Checked) return Regex.Replace(strCleanName, @" S\d+e\d+$", "");
			else return strCleanName;
		}
		
		void SearchIMDb(ListView lvListView)
		{
			foreach (ListViewItem lviItem in lvListView.SelectedItems)
			{
				string strCleanName = RemoveEpisodeInfo(lviItem.Text);
				System.Diagnostics.Process.Start("http://www.imdb.com/find?q=" + strCleanName.Replace(' ', '+') + strIMDbSearchType);
				LogMessage("Info", Color.Blue, "Searching IMDb for " + strCleanName );
			}
		}

		void SearchTorrenz(ListView lvListView)
		{
			foreach (ListViewItem lviItem in lvListView.SelectedItems)
			{
				string strCleanName = RemoveEpisodeInfo(lviItem.Text);
				System.Diagnostics.Process.Start("http://torrentz.eu/search?f=" + strCleanName.Replace(' ', '+'));
				LogMessage("Info", Color.Blue, "Searching Torrenz for " + strCleanName );
			}
		}

		void LvDoubleClick(object sender, EventArgs e)
		{
			SearchIMDb((ListView)sender);
		}

		void ShowClosestItem(ListView lvListView, string strItemName)
		{
			if (lvListView.Items.Count > 0 && !lvListView.Focused)
			{
				ListViewItem lviItem;
				ListViewItem lviClosest = lvListView.Items[lvListView.Items.Count-1];
				int iLength = 1;
				
				while ((iLength < strItemName.Length) && (lviItem = lvListView.FindItemWithText(strItemName.Substring(0,iLength))) != null)
				{
					lviClosest = lviItem;
					iLength++;
				}
				lviClosest.EnsureVisible();
				lviClosest.Focused = true;
			}
		}
		
		bool OneItemSelected()
		{
			if(lvGarbage.Focused) return lvGarbage.SelectedItems.Count<2;
			if(lvExisting.Focused) return lvExisting.SelectedItems.Count<2;
			if(lvWish.Focused) return lvWish.SelectedItems.Count<2;
			if(lvImport.Focused) return lvImport.SelectedItems.Count<2;
			return false;
		}
		
		void LvItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.Item.Selected && OneItemSelected())
			{
				ShowClosestItem(lvExisting, e.Item.Text);
				ShowClosestItem(lvGarbage, e.Item.Text);
				ShowClosestItem(lvWish, e.Item.Text);
				ShowClosestItem(lvImport, e.Item.Text);
			}
		}

		void SerializeListView(ListView lvListView, string strFileName)
		{
			SetStatus("Serializing " + lvListView.Tag + " " + strCollectionType + "...");
			FileStream fsListView = new FileStream(strFileName, FileMode.Create);
			BinaryFormatter bf = new BinaryFormatter();
			StringCollection strcolItems = new StringCollection();
			foreach (ListViewItem lviItem in lvListView.Items)
			{
				strcolItems.Add(lviItem.Text + "\t" + lviItem.ToolTipText);
			}
			try
			{
				bf.Serialize(fsListView, strcolItems);
			}
			catch  (System.Runtime.Serialization.SerializationException e)
			{
				ShowInfo(e.Message);
			}
			fsListView.Close();
			ClearStatus();
			SetListViewChanged(lvListView, false);
		}

		void DeserializeListView(ListView lvListView, string strFileName)
		{
			StringCollection strcolStr = new StringCollection();
			SetStatus("Adding " + lvListView.Tag + " " + strCollectionType + "...");
			try
			{
				FileStream fsItems = new FileStream(strFileName, FileMode.Open);
				BinaryFormatter bf = new BinaryFormatter();
				strcolStr = (StringCollection)bf.Deserialize(fsItems);
				fsItems.Close();
			}
			catch (IOException e) { ShowInfo(e.Message); }
			
			lvListView.BeginUpdate();
			lvListView.Items.Clear();
			lvListView.Sorting = SortOrder.None;
			foreach(string strListViewItemName in strcolStr)
			{
				string[] saParts = strListViewItemName.Split('\t');
				ListViewItem lviThis = new ListViewItem(saParts[0]);
				if (saParts.Length > 1) lviThis.ToolTipText = saParts[1];
				lvListView.Items.Add(lviThis);
				ColorAll(saParts[0]);
			}
			lvListView.Sorting = SortOrder.Ascending;
			SetStatus("Added " + lvListView.Items.Count + " items.");
			lvListView.EndUpdate();
			ClearStatus();
		}

		void MfShown(object sender, EventArgs e)
		{
			InitListViewFromFile(lvGarbage);
			InitListViewFromFile(lvExisting);
			InitListViewFromFile(lvWish);
		}

		void LvItemDrag(object sender, ItemDragEventArgs e)
		{
			lvDragSource = (ListView)sender;
			lvDragSource.DoDragDrop( lvDragSource.SelectedItems, DragDropEffects.Copy);
		}
		
		void LvDragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection))) e.Effect = e.AllowedEffect;
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = e.AllowedEffect;
		}
		
		void LvDragDrop(object sender, DragEventArgs e)
		{
			ListView lvThis = (ListView)sender;
			
			if( e.AllowedEffect == DragDropEffects.None) return;
			Cursor.Current = Cursors.WaitCursor;
			// from another list view
			if(e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)))
			{
				foreach (ListViewItem lviThis in (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection)))
				{
					if (rbSeries.Checked &&
					    ((string)lvThis.Tag == "Garbage" ||
					     (string)lvThis.Tag == "Wish"))
					{
						ListViewItem lviToAdd = new ListViewItem(RemoveEpisodeInfo(lviThis.Text));
						AddItemToListView(lvThis, lviToAdd);
					}
					else AddItemToListView(lvThis, lviThis);
				}
				if (rbSeries.Checked)
				{
					if ((string)lvThis.Tag == "Garbage") ColorExistingAndUp();
					if ((string)lvThis.Tag == "Wish") ColorWishAndUp();
				}
			}
			// from folders or files
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				int iFolderCount = 0;
				foreach (string strPath in (string[])e.Data.GetData(DataFormats.FileDrop))
				{
					FileAttributes attr = File.GetAttributes(strPath);
					bool isFolder = (attr & FileAttributes.Directory) == FileAttributes.Directory;
					// from folder
					if (isFolder)
					{
						if ((string)lvThis.Tag == "Import")
						{
							iFolderCount++;
							if (iFolderCount == 1) tbImportFolder.Text = strPath;
							else tbImportFolder.Text = Path.GetDirectoryName(strPath);
						}
						AddFolderToListView(lvThis, strPath);
					}
					// from video file
					else if (rgxVideoExtensions.IsMatch(Path.GetExtension(strPath)))
					{
						string strJustName = Path.GetFileNameWithoutExtension(strPath);
						if ((string)lvThis.Tag == "Import") tbImportFolder.Text = Path.GetDirectoryName(strPath);
						FileInfo fiFile = new FileInfo(strPath);
						ListViewItem lviThis = new ListViewItem(CleanName(strJustName));
						lviThis.ToolTipText = ExtractVideoInfo(fiFile, FindItem(lvThis, lviThis.Text) == null);
						AddItemToListView(lvThis, lviThis);
					}
					// from txt file
					else if (Path.GetExtension(strPath) == ".txt") 
						AddTxtToListView(lvThis, strPath);
					// from csv file
					else if (Path.GetExtension(strPath) == ".csv") 
						AddCsvToListView(lvThis, strPath);
					// from listview stream
					else if (Path.GetExtension(strPath) == ".slv") 
						DeserializeListView(lvThis, strPath);
				}
			}
			Cursor.Current = Cursors.Default;
		}

		string ExtractVideoInfo(FileInfo fiFile, bool bFullDetails)
		{
			string sMediaInfo = fiFile.Name + "\n" +
				"[" + tbNickName.Text + " " + StandardizeDate(DateTime.Today) + "]  " +
				fiFile.DirectoryName;
				sMediaInfo += "\nLast Written " + StandardizeDate(fiFile.LastWriteTime);
			if (bFullDetails && cbMediaInfo.Checked)
			{
				miThis.Open(fiFile.FullName);
				miThis.Option("Inform", "General;%Duration/String%,  %FileSize/String%  %Format%"); // file size
				sMediaInfo += "\n" + miThis.Inform();
				miThis.Option("Inform", "Video;Video:  %Width% x%Height% (%DisplayAspectRatio/String%) at %FrameRate/String%,  %BitRate/String%");
				sMediaInfo += "\n\n" + miThis.Inform();
				miThis.Option("Inform", "Audio;Audio:  %Channel(s)/String%  %Language/String%,  %SamplingRate/String%  %Format%\n");
				sMediaInfo += "\n" + miThis.Inform().Replace("Audio: ", "\nAudio: ").Replace("Audio:  ,", "Audio:");
				miThis.Close();
			}
			else
			{
				sMediaInfo += "\n" + 
					fiFile.Length/1024/1024 + " MiB,  " +
					fiFile.Extension.ToUpper().Substring(1);;
			}
			return sMediaInfo;
		}
		
		void EraseColorFromListView(ListView lvThis, Color clrToErase)
		{
			lvThis.BeginUpdate();
			foreach (ListViewItem lviThis in lvThis.Items)
			{
				if (lviThis.BackColor == clrToErase)
				{
					lvThis.Items.Remove(lviThis);
					ColorAll(lviThis.Text);
					SetListViewChanged(lvThis, true);
				}
			}
			lvThis.EndUpdate();
		}
		
		void TpSettingsLeave(object sender, EventArgs e)
		{
			SaveSettings();
		}
		
		void BtnDragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection))) e.Effect = e.AllowedEffect;
		}
		
		void BtnEraseSelectedDragDrop(object sender, DragEventArgs e)
		{
			EraseSelected(lvDragSource);
		}
		
		void BtnEraseColorDragDrop(object sender, DragEventArgs e)
		{
			foreach (ListViewItem lviThis in lvDragSource.SelectedItems)
			{
				DragColor = lviThis.BackColor;
				break;
			}
			EraseColorFromListView(lvDragSource, DragColor);
		}
		
		void BtnPlayDragDrop(object sender, DragEventArgs e)
		{
			Play();
		}
		
		void BtnSearchIMDbDragDrop(object sender, DragEventArgs e)
		{
			SearchIMDb(lvDragSource);
		}
		
		void BtnSearchTorrentzDragDrop(object sender, DragEventArgs e)
		{
			SearchTorrenz(lvDragSource);
		}
		
		string StandardizeDate(DateTime dtToSStandardize)
		{
			return 	dtToSStandardize.Year.ToString("D4") + "-" +
				dtToSStandardize.Month.ToString("D2") + "-" +
				dtToSStandardize.Day.ToString("D2");
		}
		
		string StandardizeTime(DateTime dtToSStandardize)
		{
			return 	dtToSStandardize.Hour.ToString("D2") + "-" +
				dtToSStandardize.Minute.ToString("D2") + "-" +
				dtToSStandardize.Second.ToString("D2");
		}
		
		void BtnExportListDragDrop(object sender, DragEventArgs e)
		{
			sfdMovieFileMerger.FileName =
				tbNickName.Text + " " +
				(string)lvDragSource.Tag + " " +
				strCollectionType + " " +
				StandardizeDate(DateTime.Today) +
				".csv";
			if (sfdMovieFileMerger.ShowDialog() == DialogResult.OK)
			{
				sfdMovieFileMerger.InitialDirectory = "";  // take the same folder next time
				SaveListViewToCsvFile(lvDragSource, sfdMovieFileMerger.FileName);
			}
		}
		
		void MainFormSizeChanged(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)	// Not if minimized
			{
				return;
			}
			scFolders.SplitterDistance = scFolders.Size.Width / 2;
			scHorizontal.SplitterDistance = scHorizontal.Size.Height / 2;
		}
		
		void TbTargetFolderDragDrop(object sender, DragEventArgs e)
		{
			if( e.AllowedEffect == DragDropEffects.None) return;
			Cursor.Current = Cursors.WaitCursor;
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string strPath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
				FileAttributes attr = File.GetAttributes(strPath);
				bool isFolder = (attr & FileAttributes.Directory) == FileAttributes.Directory;

				if (isFolder)
				{
					tbTargetFolder.Text = strPath;
					AddFolderToListView(lvExisting, tbTargetFolder.Text);
				}
			}
			Cursor.Current = Cursors.Default;
		}
		
		void TbImportFolderDragDrop(object sender, DragEventArgs e)
		{
			if( e.AllowedEffect == DragDropEffects.None) return;
			Cursor.Current = Cursors.WaitCursor;
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string strPath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
				FileAttributes attr = File.GetAttributes(strPath);
				bool isFolder = (attr & FileAttributes.Directory) == FileAttributes.Directory;

				if (isFolder)
				{
					lvImport.Items.Clear();
					tbImportFolder.Text = strPath;
					AddFolderToListView(lvImport, tbImportFolder.Text);
				}
			}
			Cursor.Current = Cursors.Default;
		}
		
		void TbDragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = e.AllowedEffect;
		}
		
		void lvKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete) EraseSelected((ListView)sender);
		}

		void BtnMediaInfoDragDrop(object sender, DragEventArgs e)
		{
			GetMediaInfo();
		}
		
		void TbToolTipRegexDragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection))) e.Effect = e.AllowedEffect;
		}
		
		void TbToolTipRegexDragDrop(object sender, DragEventArgs e)
		{
			Regex rgxToolTip = new Regex(tbToolTipRegex.Text);
			
			if( e.AllowedEffect == DragDropEffects.None) return;
			Cursor.Current = Cursors.WaitCursor;
			// from a list view
			if(e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)))
			{
				foreach (ListViewItem lviThis in lvDragSource.Items)
				{
					if(rgxToolTip.IsMatch(lviThis.ToolTipText)) lviThis.Selected = true;
					else lviThis.Selected = false;
				}
			}
			Cursor.Current = Cursors.Default;
		}
	}
}
