using Dapper.Contrib.Extensions;
using System;

namespace Model
{
	public class Event
	{
		public string Comment { get; set; }

		public DateTime? Date { get; set; }

		[Key]
		public int ID { get; set; }

		public int? Rating { get; set; }
	}
}