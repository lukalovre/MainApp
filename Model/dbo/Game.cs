using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	public class Game
	{
		public bool _1001 { get; set; }

		[Key]
		public int ID { get; set; }

		public int ItemID { get; set; }
		public string Platform { get; set; }

		public string Title { get; set; }

		public int Year { get; set; }
	}
}