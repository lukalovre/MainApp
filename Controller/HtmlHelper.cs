using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Controller
{
	public static class HtmlHelper
	{
		public static List<ImdbListItem> GetFromList(string listFolderPath, string listName, IEnumerable<string> filter, out DateTime updatedDate)
		{
			var result = new List<ImdbListItem>();

			var listPathHtm = Path.Combine(listFolderPath, $"{listName}.htm");
			var listPathJson = Path.Combine(listFolderPath, $"{listName}.json");

			updatedDate = File.GetLastWriteTime(listPathHtm);

			if (!File.Exists(listPathHtm))
			{
				return result;
			}

			if (File.Exists(listPathJson))
			{
				var json = File.ReadAllText(listPathJson);
				return JsonConvert.DeserializeObject<List<ImdbListItem>>(json);
			}

			var lines = File.ReadAllLines(listPathHtm);

			foreach (var line in lines)
			{
				if (line.Contains(@"/title/tt"))
				{
					string pattern = @"tt\d{7}";
					var match = Regex.Match(line, pattern);
					var imdbID = match.Value;

					if (!string.IsNullOrWhiteSpace(match.Value))
					{
						pattern = @"tt\d{8}";
						match = Regex.Match(line, pattern);

						if (!string.IsNullOrWhiteSpace(match.Value))
						{
							imdbID = match.Value;
						}
					}

					if (result.Any(o => o.Imdb == imdbID))
					{
						continue;
					}

					if (filter.Any(o => o == imdbID))
					{
						// To keep the correct positions
						result.Add(new ImdbListItem { Imdb = imdbID });
						continue;
					}

					var imdbData = Imdb.GetDataFromAPI(imdbID, false);

					result.Add(new ImdbListItem
					{
						Imdb = imdbData.imdbID,
						Directors = imdbData.Director,
						Title = imdbData.Title,
						Year = int.Parse(imdbData.Year.Split('–').FirstOrDefault()),
						Runtime = GetMinutes(imdbData),
						NumVotes = imdbData.imdbVotes == "N/A" ? 0 : int.Parse(imdbData.imdbVotes.Replace(",", string.Empty)),
						IMDbRating = imdbData.imdbRating == "N/A" ? 0 : float.Parse(imdbData.imdbRating),
						Position = result.Count + 1,
						Metascore = imdbData.Metascore == "N/A" ? null : (int?)int.Parse(imdbData.Metascore)
					});
				}
			}

			var jsonText = JsonConvert.SerializeObject(result, Formatting.Indented);

			File.WriteAllText(listPathJson, jsonText);

			return result;
		}

		private static int GetMinutes(ImdbData imdbData)
		{
			if (imdbData.Runtime == @"\N" || imdbData.Runtime == @"N/A")
			{
				return 0;
			}

			if (int.TryParse(imdbData.Runtime.TrimEnd(" min".ToArray()), out var result))
			{
				return result;
			}

			return 0;
		}
	}
}