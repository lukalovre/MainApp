using System;
using System.ComponentModel;

namespace Model.Grid
{
	public class ZooGrid
	{
		[Browsable(false)]
		public int ID { get; set; }

		public string Name { get; set; }
		public string City { get; set; }
		public string Country { get; set; }

		public DateTime LastVisit { get; set; }
	}
}