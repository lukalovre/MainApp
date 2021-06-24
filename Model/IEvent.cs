using System;

namespace Model
{
	public interface IEvent
	{
		string Comment { get; set; }
		DateTime? Date { get; set; }

		int? Rating { get; set; }
	}
}