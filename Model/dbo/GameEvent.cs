using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.GameEvents")]
	public class GameEvent : Event
	{
		public bool Completed { get; set; }

		public int Igdb { get; set; }
		public string People { get; set; }
		public int Time { get; set; }
	}
}