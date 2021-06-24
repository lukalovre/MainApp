using Dapper.Contrib.Extensions;
using System;

namespace Model.dbo
{
	public class MusicEvent : IEvent
	{
		public string Comment { get; set; }
		public DateTime? Date { get; set; }

		[Key]
		public int ID { get; set; }

		public bool In { get; set; }
		public int ItemID { get; set; }
		public int? Rating { get; set; }
	}
}