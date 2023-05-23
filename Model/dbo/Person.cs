using Dapper.Contrib.Extensions;
using System;

namespace Model.dbo
{
	[Table("dbo.People")]
	public class Person
	{
		public string FirstName { get; set; }

		[Key]
		public int ID { get; set; }

		public string LastName { get; set; }

		public string Address { get; set; }
		public string City { get; set; }
		public int? Postcode { get; set; }
		public DateTime Birthday { get; set; }
		public string Nickname { get; set; }
	}
}