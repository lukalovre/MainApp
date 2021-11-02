using System.Collections.Generic;

namespace Model
{
	public class Following
	{
		public List<string> Books { get; set; } = new List<string>();
		public List<string> BooksCollection { get; set; } = new List<string>();
		public List<string> Comics { get; set; } = new List<string>();
		public List<string> ComicsOngoing { get; set; } = new List<string>();
		public List<string> Games { get; set; } = new List<string>();
		public List<string> GamesCollection { get; set; } = new List<string>();
		public List<string> MyWorkProgress { get; set; } = new List<string>();
		public List<string> TVShows { get; set; } = new List<string>();
		public List<string> TVShowsOngoing { get; set; } = new List<string>();
		public List<string> YouTube { get; set; } = new List<string>();
	}
}