using Dapper.Contrib.Extensions;
using System;

namespace Model.dbo
{
	[Table("dbo.LinkEvents")]
	public class LinkEvent
	{
		public DateTime Date { get; set; }

		[Key]
		public int ID { get; set; }

		public int ItemID { get; set; }
	}
}