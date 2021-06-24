using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	public class Comic : IGoodreads
	{
		public bool _1001 { get; set; }
		public int GoodreadsID { get; set; }

		[Key]
		public int ID { get; set; }

		public string Illustrator { get; set; }
		public string Title { get; set; }
		public string Writer { get; set; }
		public int Year { get; set; }
	}
}