namespace Model.dbo
{
	public class Book : Item, IGoodreads
	{
		public bool _1001 { get; set; }

		public string Author { get; set; }

		public int GoodreadsID { get; set; }
	}
}