using Dapper.Contrib.Extensions;
using System;

namespace Model.Collection
{
	[Table("Collection.Comics")]
	public class Comic : ICollection
	{
		public int Chapter { get; set; }

		public DateTime? Date { get; set; }

		public int GoodreadsID { get; set; }

		[Key]
		public int ID { get; set; }

		public string Illustrator { get; set; }
		public string Language { get; set; }
		public string Owner { get; set; }
		public float? Price { get; set; }
		public float? PriceInRSD { get; set; }
		public string Title { get; set; }
		public string Writer { get; set; }
	}
}