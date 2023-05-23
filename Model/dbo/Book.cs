using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.Books")]
	public class Book : Item, IGoodreads
	{
		public bool _1001 { get; set; }

		public string Author { get; set; }

		public int GoodreadsID { get; set; }
	}
}