namespace Model.Grid
{
	public class TVShowWatchingGrid : IImdb
	{
		public string Imdb { get; set; }

		public string Title { get; set; }
		public string Writer { get; set; }
		public int Year { get; set; }

		public int DaysAgo { get; set; }
		public string Time { get; set; }
	}
}