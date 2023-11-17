using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.Standups")]
	public class Standup : Event, IImdb
	{
		public string Title { get; set; }
		public int Year { get; set; }

		public string Imdb { get; set; }
		public string Performer { get; set; }

		public int Runtime { get; set; }
	}
}