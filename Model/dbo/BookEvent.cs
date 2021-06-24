using Dapper.Contrib.Extensions;
using System;

namespace Model.dbo
{
	public class BookEvent : IGoodreads, IEvent
	{
		public string Comment { get; set; }
		public DateTime? Date { get; set; }

		public int GoodreadsID { get; set; }

		[Key]
		public int ID { get; set; }

		public int Pages { get; set; }
		public int? Rating { get; set; }
		public int Read { get; set; }
	}
}