using Dapper.Contrib.Extensions;

namespace Model
{
	public class Item
	{
		[Key]
		public int ID { get; set; }

		public string Title { get; set; }
		public int Year { get; set; }
	}
}