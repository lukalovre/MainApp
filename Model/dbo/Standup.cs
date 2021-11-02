using System;

namespace Model.dbo
{
	public class Standup : Item, IImdb
	{
		public DateTime? Date { get; set; }

		public string Imdb { get; set; }
		public string Performer { get; set; }
		public int Rating { get; set; }
		public int Runtime { get; set; }
	}
}