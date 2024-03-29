﻿using Dapper.Contrib.Extensions;

namespace Model.dbo
{
	[Table("dbo.Movies")]
	public class Movie : Item, IImdb
	{
		public string Actors { get; set; }

		public string Country { get; set; }

		public string Director { get; set; }

		public string Ganre { get; set; }

		public string Imdb { get; set; }

		public string Language { get; set; }

		public string OriginalTitle { get; set; }

		public string Plot { get; set; }

		public int Runtime { get; set; }

		public string Type { get; set; }

		public string Writer { get; set; }
	}
}