using System;
using System.ComponentModel;

namespace Model.Grid
{
	public class MyWorkProgresGrid
	{
		[Browsable(false)]
		public int ID { get; set; }

		[Browsable(false)]
		public int ItemID { get; set; }
		public string Title { get; set; }
		public string Type { get; set; }
		public string Time { get; set; }
		public int DaysAgo { get; set; }
		public DateTime LastDate{ get; set; }
	}
}