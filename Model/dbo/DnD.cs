using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.DnD")]
	public class DnD
	{
		[Key]
		public int ID { get; set; }

		public string Role { get; set; }
		public string Title { get; set; }
	}
}