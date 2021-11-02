namespace Model.dbo
{
	public class TVShowEvent : Event, IImdb
	{
		public int Episodes { get; set; }

		public string Imdb { get; set; }

		public int Season { get; set; }
	}
}