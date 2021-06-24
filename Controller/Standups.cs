using Model.dbo;
using System.Linq;

namespace Controller
{
	public class Standups
	{
		public static Standup GetStandup(string imdbText)
		{
			string inputImdb = Imdb.GetImdbIDFromUrl(imdbText);

			var imdbData = Imdb.GetDataFromAPI(inputImdb);

			var split = imdbData.Title.Split(':');

			return new Standup
			{
				Performer = split[0].Trim(),
				Title = split[1].Trim(),
				Runtime = imdbData.Runtime == @"\N" || imdbData.Runtime == @"N/A" ? 0 : int.Parse(imdbData.Runtime.TrimEnd(" min".ToArray())),
				Year = int.Parse(imdbData.Year.Split('–').FirstOrDefault()),
				Imdb = imdbData.imdbID
			};
		}
	}
}