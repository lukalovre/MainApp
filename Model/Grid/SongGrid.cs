using System;
using System.ComponentModel;

namespace Model.Grid
{
	public class SongGrid
	{
		[Browsable(false)]
		public int ID { get; set; }

		public string Artist { get; set; }
		public string Title { get; set; }
		public int Year{ get; set; }

		public DateTime LastHeard { get; set; }
	}
}