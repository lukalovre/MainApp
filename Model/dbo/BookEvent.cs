using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.BookEvents")]
	public class BookEvent : Event, IGoodreads
	{
		public int GoodreadsID { get; set; }

		public int Pages { get; set; }

		public bool Read { get; set; }
	}
}