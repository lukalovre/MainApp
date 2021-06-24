using Model.dbo;
using System.Linq;

namespace Controller
{
	public class TVShows
	{
		public static TVShow GetTVShow(string imdbText)
		{
			string inputImdb = Imdb.GetImdbIDFromUrl(imdbText);

			var imdbData = Imdb.GetDataFromAPI(inputImdb);

			return new TVShow
			{
				Title = imdbData.Title,
				Runtime = imdbData.Runtime == @"\N" || imdbData.Runtime == @"N/A" ? 0 : int.Parse(imdbData.Runtime.TrimEnd(" min".ToArray())),
				Year = int.Parse(imdbData.Year.Split('–').FirstOrDefault()),
				Imdb = imdbData.imdbID,
				_1001 = _1001.Is1001TVShow(imdbData.imdbID),
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

		public static void OpenHyperlink(Movie movie)
		{
			var hyperlink = $"https://www.imdb.com/title/{movie.Imdb}";

			System.Diagnostics.Process.Start(hyperlink);
		}
	}
}