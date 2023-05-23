using System.ComponentModel;

namespace Model.Grid
{
	public class UniversalItem
	{
		[Browsable(false)]
		public int ID { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public int? Year { get; set; }
		public string Type { get; set; }
	}
}