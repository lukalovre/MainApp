using Model;
using Model.dbo;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
	public static class _1001
	{
		private static List<string> s_1001MoviesList;

		private static List<string> s_1001TVShowsList;

		private static List<string> Movies1001List
		{
			get
			{
				if (s_1001MoviesList != null)
				{
					return s_1001MoviesList;
				}

				return s_1001MoviesList = Fill1001List(Paths.Imdb, "1001 Movies You Must See Before You Die");
			}
		}

		private static List<string> TVShows1001List
		{
			get
			{
				if (s_1001TVShowsList != null)
				{
					return s_1001TVShowsList;
				}

				return s_1001TVShowsList = Fill1001List(Paths.Imdb, "1001 TV Shows You Must Watch Before you Die");
			}
		}

		public static int GetAlbumsCount()
		{
			return 1001;
		}

		public static int GetBooksCount()
		{
			return Datasource.GetList<Book>()
				.Count(o => o._1001)
				+ 1; // Watchmen;
		}

		public static int GetComicsCount()
		{
			return Datasource.GetList<Comic>().Count(o => o._1001);
		}

		public static int GetMoviesCount()
		{
			return Datasource.GetList<Movie>()
				.Select(o => o.Imdb)
				.Count(o => Is1001(o))
				+ 2; // Riget, Dekalog
		}

		public static int GetPaintingCount()
		{
			return 1001;
		}

		public static int GetPhotographsCount()
		{
			return 1001;
		}

		public static int GetSongsCount()
		{
			return 1001;
		}

		public static int GetTVShowsCount()
		{
			return Datasource.GetList<TVShow>()
				.Select(o => o.Imdb)
				.Count(o => Is1001(o));
		}

		public static bool Is1001(string imdbSource)
		{
			return Movies1001List.Any(i => i == imdbSource)
				|| TVShows1001List.Any(i => i == imdbSource);
		}

		private static List<string> Fill1001List(string listFolderPath, string listName)
		{
			var result = CsvHelper.GetFromList<ImdbListItem>(listFolderPath, listName, out _);

			return result.Select(o => o.Const).ToList();
		}
	}
}