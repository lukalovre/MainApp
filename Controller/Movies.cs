using Model.dbo;
using System.Linq;

namespace Controller
{
	public class Movies
	{
		public static Model.Grid.MovieCollection Convert(Model.Collection.Movie o)
		{
			return new Model.Grid.MovieCollection
			{
				Director = o.Director,
				Format = o.Format,
				Title = o.Title,
				Year = o.Year,
				ID = o.ID
			};
		}

		public static Movie GetMovie(string imdbText, bool savePoster = true)
		{
			string inputImdb = Imdb.GetImdbIDFromUrl(imdbText);

			if (inputImdb == null)
			{
				return null;
			}

			var imdbData = Imdb.GetDataFromAPI(inputImdb, savePoster);

			return new Movie
			{
				Title = imdbData.Title,
				Runtime = imdbData.Runtime == @"\N" || imdbData.Runtime == @"N/A" ? 0 : int.Parse(imdbData.Runtime.TrimEnd(" min".ToArray())),
				Year = int.Parse(imdbData.Year.Split('–').FirstOrDefault()),
				Imdb = imdbData.imdbID,
				Actors = imdbData.Actors,
				Country = imdbData.Country,
				Director = imdbData.Director,
				Ganre = imdbData.Genre,
				Language = imdbData.Language,
				Plot = imdbData.Plot,
				Type = imdbData.Type,
				Writer = imdbData.Writer,
				OriginalTitle = null
			};
		}
	}
}