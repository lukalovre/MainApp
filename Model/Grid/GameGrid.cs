using System;
using System.ComponentModel;

namespace Model.Grid
{
	public class GameGrid
	{
		[Browsable(false)]
		public int ID { get; set; }

		[Browsable(false)]
		public int Igdb { get; set; }

		public string Title { get; set; }
		public int Year { get; set; }
		public string Platform { get; set; }
		public string Time { get; set; }

		public int TimeMinutes { get; set; }

		[Browsable(false)]
		public DateTime LastPlayedDate { get; set; }

		public bool Completed { get; set; }

		public int Rating { get; set; }
	}
}