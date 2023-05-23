using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.MusicEvents")]
	public class MusicEvent : Event
	{
		public bool In { get; set; }
		public int ItemID { get; set; }
	}
}