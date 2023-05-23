using IGDB.Models;
using Model.dbo;
using Model.Info;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Game = Model.dbo.Game;

namespace Controller
{
	public class Games
	{
		public static string GetFreshMeter(DateTime? dateBuy)
		{
			string freshMeter;

			if (!dateBuy.HasValue)
			{
				freshMeter = "∞";
			}
			else
			{
				var date = Convert.ToDateTime(dateBuy.Value);

				DateTime now = DateTime.Today;
				int age = now.Year - date.Year;

				if (date > now.AddYears(-age) && age != 0)
				{
					age--;
				}

				freshMeter = age.ToString();
			}

			if (freshMeter == "0")
			{
				freshMeter = "*Fresh*";
			}

			return freshMeter;
		}

		public static GameInfo GetInfo(Game game, List<GameEvent> gameEvents)
		{
			var gameInfo = new GameInfo
			{
				Title = game.Title,
				Year = game.Year,
				Platform = game.Platform,
				_1001 = Igdb.Is1001(game.Igdb),
				Playing = Following.FollowingModel.Games.Contains(game.Igdb.ToString()),
				PosterPath = GetPosterPath(game)
			};

			if (gameEvents == null || !gameEvents.Any())
			{
				gameInfo.Time = 0;
				gameInfo.Comment = string.Empty;
				gameInfo.Completed = false;
				gameInfo.Stars = 1;

				return gameInfo;
			}

			gameInfo.Time = gameEvents.Sum(o => o.Time);
			gameInfo.Comment = gameEvents.LastOrDefault().Comment;
			gameInfo.Completed = gameEvents.Any(o => o.Completed);
			gameInfo.Stars = gameEvents.LastOrDefault().Rating.Value;

			var lastDays = (int)(DateTime.Now - gameEvents.LastOrDefault().Date.Value).TotalDays;
			gameInfo.LastDaysAgo = $"Last played {lastDays} days ago";

			return gameInfo;
		}

		public static string[] GetPlatforms()
		{
			return Datasource.GetList<Game>().Select(o => o.Platform).Distinct().ToList().ToArray();
		}

		public static string[] GetClients()
		{
			return Datasource.GetList<Model.Collection.Game>().Where(o => !string.IsNullOrEmpty(o.Client)).Select(o => o.Client).Distinct().ToArray();
		}

		private static string GetPosterPath(Game game)
		{
			var filePath = Path.Combine(Paths.GameCovers, $"{game.Igdb}.png");

			if (!File.Exists(filePath))
			{
				return string.Empty;
			}

			return filePath;
		}
	}
}