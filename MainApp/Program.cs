using Controller;
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
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (Settings.Instance.Datasource == Settings.eDatasource.Json)
			{
				Application.Run(new PasswordForm());
			}

			try
			{
				Backup.MakeBackup();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}\n\n{ex.StackTrace}");
			}

			Application.Run(new FormMain());
		}
	}
}