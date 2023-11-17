using Dapper.Contrib.Extensions;
using System;

namespace Model
{
	public class Event
	{
		[Key]
		public int ID { get; set; }

		public DateTime? Date { get; set; }
		public int? Rating { get; set; }
		public string Comment { get; set; }
		public string People { get; set; }
	}
}