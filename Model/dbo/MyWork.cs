using Dapper.Contrib.Extensions;
using System;

namespace Model.dbo
{
	public class MyWork
	{
		public string Collaborators { get; set; }

		public DateTime? Date { get; set; }

		public bool Finished { get; set; }

		[Key]
		public int ID { get; set; }

		public string Location { get; set; }
		public bool Public { get; set; }
		public string PublicLocation { get; set; }
		public string Title { get; set; }

		public string Type { get; set; }
	}
}