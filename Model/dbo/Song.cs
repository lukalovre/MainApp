using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.Songs")]
	public class Song
	{
		public int ID { get; set; }
		public string Artist { get; set; }
		public string Title { get; set; }
		public int Year { get; set; }
		public int Runtime { get; set; }
		public string Link { get; set; }
	}
}