using Dapper.Contrib.Extensions;
using System;

namespace Model.dbo
{
	[Table("dbo.DnDEvents")]
	public class DnDEvent
	{
		public DateTime? Date { get; set; }

		public int? Hours { get; set; }

		[Key]
		public int ID { get; set; }

		public int ItemID { get; set; }
		public int? Level { get; set; }
		public string Location { get; set; }
		public string Summary { get; set; }
	}
}