using System;

namespace Model.Collection
{
	public interface ICollection
	{
		DateTime? Date { get; set; }
		int ID { get; set; }
		float? Price { get; set; }
		float? PriceInRSD { get; set; }
	}
}