using IGDB;
using IGDB.Models;
using Model;
using Model.Grid;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controller
{
	public class Igdb
	{
		/// <summary>
		/// Key is the original 1001 entry value
		/// Value is the alternative value
		/// </summary>
		public static Dictionary<int, int> AlternativeVersions = new Dictionary<int, int>
			{
				// 1001:https://www.igdb.com/games/pac-man-championship-edition
				// alt: https://www.igdb.com/games/pac-man-championship-edition-dx
				{ 20900, 21737 },

				// 1001:https://www.igdb.com/games/cave-story
				// alt: https://www.igdb.com/games/cave-story-plus--1
				{ 6189, 8214 },

				// 1001:https://www.igdb.com/games/resident-evil-code-veronica
				// alt: https://www.igdb.com/games/resident-evil-code-veronica-x
				{ 968, 24369 },

				// 1001:https://www.igdb.com/games/shadow-complex
				// alt: https://www.igdb.com/games/shadow-complex-remastered
				{ 11328, 19009 },

				// 1001:https://www.igdb.com/games/sonic-adventure
				// alt: https://www.igdb.com/games/sonic-adventure-dx-directors-cut
				{ 7860, 23695 }
			};

		private static List<int> m_1001Igdb;
		private static IGDBClient m_api;
		private static Dictionary<IgdbListItem, int> m_gotyGames;

		public static Game1001 ConvertToGame1001(IgdbListItem igdb)
		{
			var year = JsonConvert.DeserializeObject<List<string>>(igdb.release_date)
				.Select(o => GetYear(o))
				.Where(o => !string.IsNullOrWhiteSpace(o))
				.Min();

			return new Game1001
			{
				Igdb = igdb.id,
				Title = igdb.game,
				Year = Convert.ToInt32(year),
				_1001 = Is1001(igdb.id)
			};
		}

		public static GameDaysAgo ConvertToGameDaysAgo(Model.dbo.Game game, IEnumerable<Model.dbo.GameEvent> gameEvents)
		{
			var daysAgo = (int)(DateTime.Now - gameEvents.Max(o => o.Date).Value).TotalDays;

			return new GameDaysAgo
			{
				ID = game.ID,
				Igdb = game.Igdb,
				Platform = game.Platform,
				Title = game.Title,
				Year = game.Year,
				DaysAgo = daysAgo
			};
		}

		public static GameGOTY ConvertToGameGOTY(Game1001 game1001)
		{
			var goty = m_gotyGames.FirstOrDefault(o => o.Key.id == game1001.Igdb).Value;

			return new GameGOTY
			{
				Igdb = game1001.Igdb,
				Title = game1001.Title,
				Year = game1001.Year,
				_1001 = game1001._1001,
				GOTY = goty
			};
		}

		public static int Get1001Count()
		{
			var allGames = Database.GetList<Model.dbo.Game>();
			return allGames
				.Select(o => o.Igdb)
				.Distinct() // This is needed for 1001 games played on different platforms (Fallout 3 on PC and PS3)
				.Count(o => Is1001(o));
		}

		public static async Task<Model.dbo.Game> GetDataFromAPIAsync(string igdbUrl)
		{
			m_api = GetApiClient();

			var games = await m_api.QueryAsync<Game>(IGDBClient.Endpoints.Games, $"fields name, url, summary, first_release_date, id, involved_companies, cover.image_id; where url = \"{igdbUrl.Trim()}\";");
			var game = games.FirstOrDefault();

			var imageId = game.Cover.Value.ImageId;

			var coverUrl = $"https://images.igdb.com/igdb/image/upload/t_cover_big/{imageId}.jpg";
			var destinationFile = Path.Combine(Paths.GameCovers, $"{game.Id.Value}.png");

			Web.Download(coverUrl, destinationFile);
			return new Model.dbo.Game
			{
				Igdb = (int)game.Id.Value,
				Title = game.Name,
				Year = game.FirstReleaseDate.Value.Year
			};
		}

		public static async Task<Model.dbo.Game> GetDataFromAPIAsync(int igdb)
		{
			m_api = GetApiClient();

			var games = await m_api.QueryAsync<Game>(IGDBClient.Endpoints.Games, $"fields name, url, summary, first_release_date, id, involved_companies, cover.image_id; where id = {igdb};");
			var game = games.FirstOrDefault();

			if (game.Cover == null)
			{
				return null;
			}

			var imageId = game.Cover.Value.ImageId;

			var coverUrl = $"https://images.igdb.com/igdb/image/upload/t_cover_big/{imageId}.jpg";
			var destinationFile = Path.Combine(Paths.GameCovers, $"{game.Id.Value}.png");

			Web.Download(coverUrl, destinationFile);
			return new Model.dbo.Game
			{
				Igdb = (int)game.Id.Value,
				Title = game.Name
			};
		}

		public static List<IgdbListItem> GetFromListsMerged(string listsFolder)
		{
			var dictionary = new Dictionary<IgdbListItem, int>();

			var folderPath = Path.Combine(Paths.Igdb, listsFolder);

			var filesCount = Directory.GetFiles(folderPath, "*.csv", SearchOption.TopDirectoryOnly).Length;

			foreach (string file in Directory.EnumerateFiles(folderPath, "*.csv"))
			{
				var listName = Path.GetFileNameWithoutExtension(file);

				var listItems = CsvHelper.GetFromList<IgdbListItem>(folderPath, listName);

				foreach (var item in listItems)
				{
					var found = dictionary.FirstOrDefault(o => o.Key.id == item.id);

					if (found.Key != null)
					{
						dictionary[found.Key]++;
					}
					else
					{
						dictionary.Add(item, 1);
					}
				}
			}

			var ordered = dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

			var minPercentAppearances = 0.1;
			var minNumberOfAppearances = (int)Math.Round(filesCount * minPercentAppearances);

			ordered = ordered.Where(o => o.Value >= minNumberOfAppearances).ToDictionary(x => x.Key, x => x.Value);

			m_gotyGames = ordered;

			return ordered.Keys.ToList();
		}

		public static string GetYear(string str)
		{
			return Regex.Match(str, @"\d{4}").Value;
		}

		public static bool Is1001(int igdb)
		{
			return Get1001().Contains(igdb) || AlternativeVersions.Values.Contains(igdb);
		}

		private static List<int> Get1001()
		{
			if (m_1001Igdb == null)
			{
				m_1001Igdb = CsvHelper.GetFromList<IgdbListItem>(Paths.Igdb, "1001-video-games-you-must-play-before-you-die")
				.Select(o => o.id)
				.ToList();
			}

			return m_1001Igdb;
		}

		private static IGDBClient GetApiClient()
		{
			if (m_api != null)
			{
				return m_api;
			}

			var lines = File.ReadAllLines(@"..\..\..\Keys\igdb_keys.txt");

			var clientId = lines[0];
			var clientSecret = lines[1];

			return new IGDBClient(clientId, clientSecret);
		}
	}
}