using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.Musics")]
	public class Music : Item, IItemID
	{
		public bool _1001 { get; set; }
		public string Artist { get; set; }
		public int ItemID { get; set; }
		public int Runtime { get; set; }
		public string SpotifyID { get; set; }
	}
}