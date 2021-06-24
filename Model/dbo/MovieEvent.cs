using Dapper.Contrib.Extensions;
using System;

namespace Model.dbo
{
	public class MovieEvent : IImdb, IEvent
	{
		public string Comment { get; set; }
		public DateTime? Date { get; set; }

		public bool EminaWatched { get; set; }

		[Key]
		public int ID { get; set; }

		public string Imdb { get; set; }

		public int? Rating { get; set; }

		public bool WatchedInCinema { get; set; }
	}
}