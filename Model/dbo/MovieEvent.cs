using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.MovieEvents")]
	public class MovieEvent : Event, IImdb
	{
		public string Imdb { get; set; }
		public string Platform { get; set; }
	}
}