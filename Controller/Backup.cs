using System;
using System.IO;
using System.Linq;

namespace Controller
{
	public static class Backup
	{
		private static string DailyPath => Path.Combine(PathRoot, "_Daily");
		private static string PathRoot => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MainDatabaseBackups");
		private static string WeeklyPath => Path.Combine(PathRoot, DateTime.Now.Year.ToString());

		public static void MakeBackup()
		{
			var name = $"Main_{DateTime.Now:yyyy_MM_dd}.bak";

			if (!Directory.Exists(DailyPath))
			{
				Directory.CreateDirectory(DailyPath);
			}

			if (!Directory.Exists(WeeklyPath))
			{
				Directory.CreateDirectory(WeeklyPath);
			}

			var path = Path.Combine(DailyPath, name);

			if (File.Exists(path))
			{
				return;
			}

			Datasource.MakeBackup(path);

			Verify();
		}

		private static void ChackDaily()
		{
			TimeSpan start = new TimeSpan(8, 0, 0);
			TimeSpan now = DateTime.Now.TimeOfDay;

			if (now < start)
			{
				return;
			}

			var directory = new DirectoryInfo(DailyPath);

			if (!Directory.Exists(DailyPath))
			{
				return;
			}

			var latestFile = directory.GetFiles()
				.OrderByDescending(f => f.LastWriteTime)
				.FirstOrDefault();

			if (latestFile == null || DateTime.Now.Date != latestFile.CreationTime.Date)
			{
				throw new Exception("Daily backup not done");
			}
		}

		private static void CheckWeekly()
		{
			DateTime sundayLastWeek = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek - 0);

			var directory = new DirectoryInfo(WeeklyPath);
			var latestFile = directory.GetFiles()
				.OrderByDescending(f => f.LastWriteTime)
				.FirstOrDefault();

			if (latestFile == null
				|| sundayLastWeek.Date > latestFile.CreationTime.Date)
			{
				WeeklyMove();
			}
		}

		private static void Verify()
		{
			CheckWeekly();
			ChackDaily();
		}

		private static void WeeklyMove()
		{
			try
			{
				DirectoryInfo direcrotyInfo = new DirectoryInfo(DailyPath);
				var file = direcrotyInfo.GetFiles("*.bak").LastOrDefault();

				File.Move(file.FullName, Path.Combine(WeeklyPath, file.Name));

				Directory.Delete(DailyPath, true);
			}
			catch (Exception ex)
			{
				throw new Exception($"Weekly backup not done\n{ex.Message}");
			}
		}
	}
}