using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	public class Movie : IImdb
	{
		public bool _1001 { get; set; }

		public string Actors { get; set; }

		public string Country { get; set; }

		public string Director { get; set; }

		public string Ganre { get; set; }

		[Key]
		public int ID { get; set; }

		public string Imdb { get; set; }

		public string Language { get; set; }

		public string OriginalTitle { get; set; }

		public string Plot { get; set; }

		public int Runtime { get; set; }

		public string Title { get; set; }

		public string Type { get; set; }

		public string Writer { get; set; }

		public int Year { get; set; }
	}
}