using Model.dbo;
using System.Linq;

namespace Controller
{
	public class Movies
	{
		public static Movie GetMovie(string imdbText)
		{
			string inputImdb = Imdb.GetImdbIDFromUrl(imdbText);

			if(inputImdb == null)
			{
				return null;
			}

			var imdbData = Imdb.GetDataFromAPI(inputImdb);

			return new Movie
			{
				Title = imdbData.Title,
				Runtime = imdbData.Runtime == @"\N" ? 0 : int.Parse(imdbData.Runtime.TrimEnd(" min".ToArray())),
				Year = int.Parse(imdbData.Year),
				Imdb = imdbData.imdbID,
				_1001 = _1001.Is1001Movie(imdbData.imdbID),
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