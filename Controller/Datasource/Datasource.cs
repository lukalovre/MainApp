using System.Collections.Generic;

namespace Controller
{
	public static class Datasource
	{
		public static void Add<T>(T item) where T : class
		{
			GetDatasource().Add(item);
		}

		public static List<T> GetList<T>()
		{
			return GetDatasource().GetList<T>();
		}

		public static void MakeBackup(string path)
		{
			GetDatasource().MakeBackup(path);
		}

		public static void Update<T>(T item) where T : class
		{
			GetDatasource().Update(item);
		}

		private static IDatasource GetDatasource()
		{
			switch (Settings.Instance.Datasource)
			{
				case Settings.eDatasource.Database:
					return new Database();

				case Settings.eDatasource.Json:
					return new JsonData();

				default: return null;
			}
		}
	}
}