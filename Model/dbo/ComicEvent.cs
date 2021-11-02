namespace Model.dbo
{
	public class ComicEvent : Event, IGoodreads
	{
		public int Chapter { get; set; }

		public int GoodreadsID { get; set; }

		public int Pages { get; set; }

		public bool Read { get; set; }
	}
}