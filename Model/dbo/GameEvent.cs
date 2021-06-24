using Dapper.Contrib.Extensions;
using System;

namespace Model.dbo
{
	public class GameEvent : IEvent
	{
		public string Comment { get; set; }
		public bool Completed { get; set; }
		public DateTime? Date { get; set; }

		[Key]
		public int ID { get; set; }

		public int ItemID { get; set; }

		public int? Rating { get; set; }

		public float Time { get; set; }
	}
}