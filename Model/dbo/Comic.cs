namespace Model.dbo
{
	public class Comic : Item, IGoodreads
	{
		public bool _1001 { get; set; }
		public int GoodreadsID { get; set; }

		public string Illustrator { get; set; }

		public string Writer { get; set; }
	}
}