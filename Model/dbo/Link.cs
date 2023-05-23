using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.Links")]
	public class Link
	{
		public string Category { get; set; }

		[Key]
		public int ID { get; set; }

		public string SubCategory { get; set; }
		public string Title { get; set; }
		public string Url { get; set; }
	}
}