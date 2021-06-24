using System;
using System.Linq;
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
			if(args.Any() && args[0] == "backup")
			{
				Backup.MakeBackup();
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormMain());
		}
	}
}