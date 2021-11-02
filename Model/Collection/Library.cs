using Dapper.Contrib.Extensions;
using System;

namespace Model.Collection
{
	[Table("Collection.Librarys")]
	public class Library
	{
		[Key]
		public int ID { get; set; }

		public string ItemID { get; set; }

		public DateTime LentDate { get; set; }
		public string LentTo { get; set; }
		public DateTime? ReturnDate { get; set; }
		public string Title { get; set; }

		public string Type { get; set; }
	}
}