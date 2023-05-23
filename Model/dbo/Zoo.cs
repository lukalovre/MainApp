using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.Zoo")]
	public class Zoo
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
	}
}