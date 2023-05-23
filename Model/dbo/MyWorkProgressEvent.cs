using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.MyWorkProgressEvents")]
	public class MyWorkProgressEvent : Event
	{
		public int ItemID { get; set; }
		public int Time { get; set; }
	}
}