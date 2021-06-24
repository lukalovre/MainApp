using CsvHelper.Configuration.Attributes;

namespace Model
{
	public class ImdbListItem : IImdb
	{
		public string Const { get; set; }
		public string Created { get; set; }
		public string Description { get; set; }
		public string Directors { get; set; }
		public string Genres { get; set; }

		[Ignore]
		public string Imdb
		{
			get => Const;
			set => Const = value;
		}

		[Name("IMDb Rating")]
		public float IMDbRating { get; set; }

		public string Modified { get; set; }

		[Name("Num Votes")]
		public int NumVotes { get; set; }

		public int Position { get; set; }

		[Name("Release Date")]
		public string ReleaseDate { get; set; }

		[Name("Runtime (mins)")]
		public int Runtime { get; set; }

		public string Title { get; set; }

		[Name("Title Type")]
		public string TitleType { get; set; }

		public string URL { get; set; }
		public int Year { get; set; }
	}
}