using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.Games")]
	public class Game : Item
	{
		public int Igdb { get; set; }

		public string Platform { get; set; }
	}
}