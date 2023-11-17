using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.Concerts")]
	public class Concert : Event
	{
		public string Title { get; set; }
		public string Festival { get; set; }
		public string Venue { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public int Price { get; set; }
	}
}