using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	public class MyWorkProgres
	{
		[Key]
		public int ID { get; set; }

		public int ItemID { get; set; }

		public string Title { get; set; }

		public string Type { get; set; }
	}
}