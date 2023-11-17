using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.DnDEvents")]
	public class DnDEvent : Event
	{
		public int? Hours { get; set; }

		public int ItemID { get; set; }
		public int? Level { get; set; }
		public string Location { get; set; }
		public string Summary { get; set; }
	}
}