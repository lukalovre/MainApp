using Dapper.Contrib.Extensions;
using System;

namespace Model.dbo
{
	public class ComicEvent : IGoodreads, IEvent
	{
		public int Chapter { get; set; }
		public string Comment { get; set; }
		public DateTime? Date { get; set; }
		public int GoodreadsID { get; set; }

		[Key]
		public int ID { get; set; }

		public int Pages { get; set; }
		public int? Rating { get; set; }
		public bool Read { get; set; }
	}
}