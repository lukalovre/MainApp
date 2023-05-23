using Dapper.Contrib.Extensions;
using System;

namespace Model.Collection
{
	[Table("Collection.Musics")]
	public class Music : ICollection
	{
		public string Artist { get; set; }

		public DateTime? Date { get; set; }

		public string Format { get; set; }

		[Key]
		public int ID { get; set; }

		public string Owner { get; set; }
		public float? Price { get; set; }
		public float? PriceInRSD { get; set; }
		public string Title { get; set; }
		public int Year { get; set; }
	}
}