using Model;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Controller
{
	public class Imdb
	{
		public static ImdbData GetDataFromAPI(string imdb, bool savePoster = true)
		{
			HttpClient client = new HttpClient
			{
				BaseAddress = new Uri("http://www.omdbapi.com/")
			};

			client.DefaultRequestHeaders.Accept.Add(
			new MediaTypeWithQualityHeaderValue("application/json"));

			var apiKey = File.ReadAllText(@"..\..\..\Keys\omdbapi_key.txt");

			var response = client.GetAsync($"?i={imdb}&apikey={apiKey}").Result;
			var imdbData = response.Content.ReadAsAsync<ImdbData>().Result;

			client.Dispose();

			if (savePoster)
			{
				SavePoster(imdbData);
			}

			return imdbData;
		}

		public static string GetImdbIDFromUrl(string url)
		{
			return url.Split('/').FirstOrDefault(i => i.StartsWith("tt"));
		}

		public static void OpenLink(IImdb imdb)
		{
			var hyperlink = $"https://www.imdb.com/title/{imdb.Imdb}/";
			Web.OpenLink(hyperlink);
		}

		private static void SavePoster(ImdbData imdbData)
		{
			var destinationFile = Path.Combine(Paths.Posters, $"{imdbData.imdbID}");
			Web.DownloadPNG(imdbData.Poster, destinationFile);
		}
	}
}