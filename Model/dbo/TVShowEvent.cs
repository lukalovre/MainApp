using Dapper.Contrib.Extensions;
using System;

namespace Model.dbo
{
	public class TVShowEvent : IImdb, IEvent
	{
		public string Comment { get; set; }
		public DateTime? Date { get; set; }

		public int Episodes { get; set; }

		[Key]
		public int ID { get; set; }

		public string Imdb { get; set; }

		public int? Rating { get; set; }

		public int Season { get; set; }
	}
}