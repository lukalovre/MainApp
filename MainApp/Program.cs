using System;
using System.Windows.Forms;

namespace MainApp
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			try
			{
				Controller.Backup.MakeBackup();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormMain());
		}
	}
}