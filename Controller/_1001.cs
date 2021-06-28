using Controller.Properties;
using CsvHelper;
using Model;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
				if(s_1001MoviesList != null)
				{
					return s_1001MoviesList;
				}

				return s_1001MoviesList = Fill1001MoviesList();
			}
		}

		private static List<string> TVShows1001List
		{
			get
			{
				if(s_1001TVShowsList != null)
				{
					return s_1001TVShowsList;
				}

				return s_1001TVShowsList = Fill1001TVShowsList();
			}
		}

		public static IList<ImdbListItem> Get1001Movies()
		{
			var result = new List<ImdbListItem>();

			StringReader reader = new StringReader(Resources._1001_Movies_You_Must_See_Before_You_Die__2020_Edit);

			using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
			{
				result.AddRange(csv.GetRecords<ImdbListItem>());
			}

			result.Remove(result.First(o => o.Title == "Riget"));
			result.Remove(result.First(o => o.Title == "Dekalog"));

			return result;
		}

		public static bool Is1001Movie(string imdbSource)
		{
			return Movies1001List.Any(i => i == imdbSource);
		}

		public static bool Is1001TVShow(string imdbSource)
		{
			return TVShows1001List.Any(i => i == imdbSource);
		}

		public static void Update1001MoviesFromBeginning()
		{
			SetAllMovies1001ToFalse();
			SetAll1001MoviesToTrue();
		}

		private static List<string> Fill1001MoviesList()
		{
			var list = new List<string>();

			StringReader reader = new StringReader(Resources._1001_Movies_You_Must_See_Before_You_Die__2020_Edit);

			string line;

			while((line = reader.ReadLine()) != null)
			{
				var strArray = line.Split(',');
				var imdbSource = strArray[1];

				if(imdbSource.StartsWith("tt"))
				{
					list.Add(imdbSource);
				}
			}

			return list;
		}

		private static List<string> Fill1001TVShowsList()
		{
			var list = new List<string>();

			StringReader reader = new StringReader(Resources._1001_TV_Shows_You_Must_Watch_Before_you_Die);

			string line;

			while((line = reader.ReadLine()) != null)
			{
				var strArray = line.Split(',');
				var imdbSource = strArray[1];

				if(imdbSource.StartsWith("tt"))
				{
					list.Add(imdbSource);
				}
			};

			return list;
		}

		private static void SetAll1001MoviesToTrue()
		{
			foreach(var imdbSource in Movies1001List)
			{
				var commandText = $@"	UPDATE [dbo].[Movies]
										SET [1001] = 1
										WHERE [Imdb] = '{imdbSource}'";

				//SqlConnectionExtension.ExecuteNonQuery(commandText);
			}
		}

		private static void SetAllMovies1001ToFalse()
		{
			var commandText = $@"	UPDATE [dbo].[Movies]
									SET [1001] = 0";

			//SqlConnectionExtension.ExecuteNonQuery(commandText);
		}
	}
}