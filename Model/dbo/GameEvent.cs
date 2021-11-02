namespace Model.dbo
{
	public class GameEvent : Event
	{
		public bool Completed { get; set; }

		public int Igdb { get; set; }
		public float Time { get; set; }
	}
}