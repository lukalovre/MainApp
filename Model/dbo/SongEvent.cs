using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.SongEvents")]
	public class SongEvent : Event
	{
		public int ItemID { get; set; }
		public bool In { get; set; }
	}
}