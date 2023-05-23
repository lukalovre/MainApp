using System;
using System.ComponentModel;

namespace Model.Grid
{
	public class LibraryGrid
	{
		[Browsable(false)]
		public int ID { get; set; }

		public string Title { get; set; }
		public string LentTo { get; set; }
		public int DaysAgo { get; set; }
		public DateTime LentDate { get; set; }
	}
}