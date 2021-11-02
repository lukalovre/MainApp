using Model.dbo;
using Model.Info;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Controller
{
	public class Games
	{
		public static GameInfo GetInfo(Game game, List<GameEvent> gameEvents)
		{
			var gameInfo = new GameInfo();

			gameInfo.Title = game.Title;
			gameInfo.Year = game.Year;
			gameInfo.Platform = game.Platform;
			gameInfo._1001 = Igdb.Is1001(game.Igdb);
			gameInfo.Playing = Following.FollowingModel.Games.Contains(game.Igdb.ToString());

			gameInfo.PosterPath = GetPosterPath(game);

			if (gameEvents == null)
			{
				gameInfo.Time = string.Empty;
				gameInfo.Review = string.Empty;
				gameInfo.Completed = false;
				gameInfo.Stars = 1;

				return gameInfo;
			}

			gameInfo.Time = gameEvents.Sum(o => o.Time).ToString();
			gameInfo.Review = gameEvents.LastOrDefault().Comment;
			gameInfo.Completed = gameEvents.Any(o => o.Completed);
			gameInfo.Stars = gameEvents.LastOrDefault().Rating.Value;

			var lastDays = (int)(DateTime.Now - gameEvents.LastOrDefault().Date.Value).TotalDays;
			gameInfo.LastDaysAgo = $"Last played {lastDays} days ago";

			return gameInfo;
		}

		public static string[] GetPlatforms()
		{
			return Database.GetDropdownValues(@"SELECT DISTINCT Platform FROM [Main].[dbo].[Games]");
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