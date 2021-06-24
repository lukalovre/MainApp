using System;
using System.IO;
using System.Net;

namespace Controller
{
	internal class Web
	{
		internal static void Download(string webFile, string destinationFile)
		{
			if(File.Exists(destinationFile))
			{
				return;
			}

			if(webFile == null || webFile == "N/A")
			{
				return;
			}

			using(WebClient client = new WebClient())
			{
				client.DownloadFile(new Uri(webFile), destinationFile);
			}
		}
	}
}