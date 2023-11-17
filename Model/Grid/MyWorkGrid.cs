using System;
using System.ComponentModel;

namespace Model.Grid
{
	public class MyWorkGrid
	{
		[Browsable(false)]
		public int ID { get; set; }

		[Browsable(false)]
		public DateTime Date { get; set; }

		public string Title { get; set; }

		public int? Year { get; set; }
		public string Type { get; set; }
	}
}