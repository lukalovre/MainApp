﻿// <Auto-Generated>
// This is here so CodeMaid doesn't reorganize this document
// </Auto-Generated>

using System.ComponentModel;

namespace Model.Grid
{
	public class MusicIn: IItemID
	{
		[Browsable(false)]
		public int ItemID { get; set; }
		public string Artist { get; set; }
		public string Title { get; set; }
		public int Year { get; set; }
		public int Runtime { get; set; }
		public int Count { get; set; }
		public bool In { get; set; }
	}
}