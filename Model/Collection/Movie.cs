using Dapper.Contrib.Extensions;
using System;

namespace Model.Collection
{
	[Table("Collection.Movies")]
	public class Movie : ICollection
	{
		public DateTime? Date { get; set; }

		public string Director { get; set; }

		public string Format { get; set; }

		[Key]
		public int ID { get; set; }

		public string Imdb { get; set; }
		public string Owner { get; set; }
		public float? Price { get; set; }
		public float? PriceInRSD { get; set; }
		public int? Region { get; set; }
		public string Title { get; set; }
		public int? Year { get; set; }
	}
}