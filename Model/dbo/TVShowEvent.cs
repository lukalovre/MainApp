using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.TVShowEvents")]
	public class TVShowEvent : Event, IImdb
	{
		public string Imdb { get; set; }

		public int Runtime { get; set; }
		public int Season { get; set; }
	}
}