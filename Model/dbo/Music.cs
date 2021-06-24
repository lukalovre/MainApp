using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	public class Music
	{
		public bool _1001 { get; set; }
		public string Artist { get; set; }

		[Key]
		public int ID { get; set; }

		public int ItemID { get; set; }
		public int Runtime { get; set; }
		public string SpotifyID { get; set; }
		public string Title { get; set; }
		public int Year { get; set; }
	}
}