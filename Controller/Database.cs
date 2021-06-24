using Controller.Properties;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Controller
{
	public static class Database
	{
		public static void Add<T>(T item) where T : class
		{
			using(var sqlConnection = new SqlConnection(Resources.MainConnectionString))
			{
				sqlConnection.Open();
				sqlConnection.Insert(item);
			}
		}

		public static List<T> GetList<T>()
		{
			var list = new List<T>();

			using(var sqlConnection = new SqlConnection(Resources.MainConnectionString))
			{
				sqlConnection.Open();

				var type = typeof(T);
				var nameSpace = type.Namespace.Split('.').LastOrDefault();

				list = sqlConnection.Query<T>($"SELECT * FROM {nameSpace}.{type.Name}s").ToList();
			}

			return list;
		}
	}
}