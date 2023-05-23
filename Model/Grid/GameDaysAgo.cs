using System;

namespace Model.Grid
{
	public class GameDaysAgo : dbo.Game
	{
		public int DaysAgo { get; set; }
		public string Time { get; set; }
		public DateTime LastPlayedDate { get; set; }
	}
}