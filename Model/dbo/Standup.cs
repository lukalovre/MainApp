using Dapper.Contrib.Extensions;
using System;

namespace Model.dbo
{
	public class Standup : IImdb
	{
		public DateTime? Date { get; set; }

		[Key]
		public int ID { get; set; }

		public string Imdb { get; set; }
		public string Performer { get; set; }
		public int Rating { get; set; }
		public int Runtime { get; set; }
		public string Title { get; set; }
		public int Year { get; set; }
	}
}