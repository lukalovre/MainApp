using System.ComponentModel;

namespace Model.Grid
{
	public class ConcertsGrid
	{
		[Browsable(false)]
		public int ID { get; set; }

		public string Title { get; set; }
		public string Festival { get; set; }
		public string City { get; set; }
		public int Year { get; set; }
	}
}