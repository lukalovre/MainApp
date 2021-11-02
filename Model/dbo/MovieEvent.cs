namespace Model.dbo
{
	public class MovieEvent : Event, IImdb
	{
		public bool EminaWatched { get; set; }

		public string Imdb { get; set; }

		public bool WatchedInCinema { get; set; }
	}
}