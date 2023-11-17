using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

namespace MainApp
{
	internal static class Helper
	{
		internal static Image SetPoster(string filePath)
		{
			if (string.IsNullOrWhiteSpace(filePath))
			{
				return null;
			}

			return Image.FromFile(filePath);
		}

		public static bool IsInDesignMode
		{
			get
			{
				bool isInDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime;

				if (!isInDesignMode)
				{
					using (var process = Process.GetCurrentProcess())
					{
						return process.ProcessName.ToLowerInvariant().Contains("devenv");
					}
				}

				return isInDesignMode;
			}
		}
	}
}