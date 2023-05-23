using System;

namespace Model.Grid
{
	public class ComicsGrid
	{
		public string Title { get; set; }
		public string Writer { get; set; }
		public int Year { get; set; }
		public bool _1001 { get; set; }
		public int GoodreadsID { get; set; }
		public DateTime? LastReadDate { get; set; }
	}
}