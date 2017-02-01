/*
 * Created by Modi
 * Date: 2012-04-09
 * Time: 3:28 PM
 */
using System;
using System.Windows.Forms;

namespace Movie_File_Merger
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	static class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MFMForm());
		}
		
	}
}
