using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;

namespace Controller
{
	public class Web
	{
		public static void DownloadFile(string webFile, string destinationFile, string extension)
		{
			if (webFile == null || webFile == "N/A")
			{
				return;
			}

			var tempPath = Path.GetTempFileName();

			using (WebClient client = new WebClient())
			{
				client.DownloadFile(new Uri(webFile), tempPath);
			}

			File.Copy(tempPath, $"{destinationFile}.{extension.ToLower()}", overwrite: true);

			File.Delete(tempPath);
		}

		public static void OpenLink(string link)
		{
			System.Diagnostics.Process.Start(link);
		}

		internal static void DownloadPNG(string webFile, string destinationFile)
		{
			destinationFile = $"{destinationFile}.png";

			if (File.Exists(destinationFile))
			{
				return;
			}

			if (webFile == null || webFile == "N/A")
			{
				return;
			}

			var tempPath = Path.GetTempFileName();

			using (WebClient client = new WebClient())
			{
				client.DownloadFile(new Uri(webFile), tempPath);
			}

			using (var bmpTemp = new Bitmap(tempPath))
			{
				var imagesTemp = new Bitmap(bmpTemp);
				imagesTemp.Save(destinationFile, ImageFormat.Png);
			}

			File.Delete(tempPath);
		}
	}
}