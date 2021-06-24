using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	public class Book : IGoodreads
	{
		public bool _1001 { get; set; }

		public string Author { get; set; }

		public int GoodreadsID { get; set; }

		[Key]
		public int ID { get; set; }

		public string Title { get; set; }
		public int Year { get; set; }
	}
}