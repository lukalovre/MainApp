namespace Model.dbo
{
	public class Music : Item, IItemID
	{
		public bool _1001 { get; set; }
		public string Artist { get; set; }
		public int ItemID { get; set; }
		public int Runtime { get; set; }
		public string SpotifyID { get; set; }
	}
}