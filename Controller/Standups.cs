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

			string performer;
			string title;

			if (split.Count() > 1)
			{
				performer = split[0].Trim();
				title = split[1].Trim();
			}
			else
			{
				performer = imdbData.Writer;
				title = imdbData.Title;
			}

			return new Standup
			{
				Performer = performer,
				Title = title,
				Runtime = imdbData.Runtime == @"\N" || imdbData.Runtime == @"N/A" ? 0 : int.Parse(imdbData.Runtime.TrimEnd(" min".ToArray())),
				Year = int.Parse(imdbData.Year.Split('–').FirstOrDefault()),
				Imdb = imdbData.imdbID
			};
		}
	}
}