using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.ZooEvents")]
	public class ZooEvents : Event
	{
		public int ItemID { get; set; }
		public string People { get; set; }
	}
}