using Model.dbo;
using System;
using System.Linq;

namespace Controller
{
	public class TVShows
	{
		public static TVShow GetTVShow(string url)
		{
			string inputImdb = Imdb.GetImdbIDFromUrl(url);

			if (!string.IsNullOrWhiteSpace(url) && string.IsNullOrWhiteSpace(inputImdb))
			{
				return GetYoutubeChannel(url);
			}

			var imdbData = Imdb.GetDataFromAPI(inputImdb);

			var runtime = 0;

			try
			{
				runtime = imdbData.Runtime == @"\N" || imdbData.Runtime == @"N/A" ? 0 : int.Parse(imdbData.Runtime.TrimEnd(" min".ToArray()));
			}
			catch
			{
			}

			return new TVShow
			{
				Title = imdbData.Title,
				Runtime = runtime,
				Year = int.Parse(imdbData.Year.Split('–').FirstOrDefault()),
				Imdb = imdbData.imdbID,
				Actors = imdbData.Actors,
				Country = imdbData.Country,
				Director = imdbData.Director,
				Genre = imdbData.Genre,
				Language = imdbData.Language,
				Plot = imdbData.Plot,
				Type = imdbData.Type,
				Writer = imdbData.Writer
			};
		}

		private static TVShow GetYoutubeChannel(string url)
		{
			var youtubeData = Links.GetYouTubeChannelNamData(url);

			return new TVShow
			{
				Title = youtubeData.Title,
				Imdb = youtubeData.ID,
				Year = DateTime.Now.Year,
				Runtime = 10
			};
		}

		public static void OpenHyperlink(Movie movie)
		{
			var hyperlink = $"https://www.imdb.com/title/{movie.Imdb}";
			Web.OpenLink(hyperlink);
		}
	}
}