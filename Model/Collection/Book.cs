using Dapper.Contrib.Extensions;
using System;

namespace Model.Collection
{
	[Table("Collection.Books")]
	public class Book : ICollection
	{
		public bool _1001 { get; set; }
		public string Author { get; set; }
		public DateTime? Date { get; set; }
		public int? EminaRating { get; set; }
		public bool EminaRead { get; set; }
		public int? GoodreadsID { get; set; }

		[Key]
		public int ID { get; set; }

		public bool LukaRead { get; set; }
		public int? Pages { get; set; }
		public float? Price { get; set; }
		public float? PriceInRSD { get; set; }
		public string Title { get; set; }
		public string Type { get; set; }
		public int? Year { get; set; }
	}
}