using Dapper.Contrib.Extensions;
using System;

namespace Model.Collection
{
	[Table("Collection.Games")]
	public class Game : ICollection
	{
		public string Client { get; set; }

		public DateTime? Date { get; set; }

		public string Edition { get; set; }

		public bool Expansion { get; set; }

		public bool GotFree { get; set; }

		public int HLTB { get; set; }

		[Key]
		public int ID { get; set; }

		public int Igdb { get; set; }
		public bool New { get; set; }
		public string Owner { get; set; }
		public bool PhysicalCopy { get; set; }
		public string Platform { get; set; }
		public float? Price { get; set; }
		public float? PriceInRSD { get; set; }
		public string Title { get; set; }
		public int Year { get; set; }
	}
}