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
			using (var sqlConnection = new SqlConnection(Resources.MainConnectionString))
			{
				sqlConnection.Open();
				sqlConnection.Insert(item);
			}
		}

		public static void Execute(string executeCommand)
		{
			using (var sqlConnection = new SqlConnection(Resources.MainConnectionString))
			{
				sqlConnection.Open();
				sqlConnection.Execute(executeCommand);
			}
		}

		public static T ExecuteScalar<T>(string query)
		{
			using (var sqlConnection = new SqlConnection(Resources.MainConnectionString))
			{
				return sqlConnection.ExecuteScalar<T>(query);
			}
		}

		public static string[] GetDropdownValues(string query)
		{
			var result = new List<string>();

			using (var db = new SqlConnection(Resources.MainConnectionString))
			{
				result = db.Query<string>(query).ToList();
			}

			result.RemoveAll(s => string.IsNullOrWhiteSpace(s));
			result.Sort();
			return result.ToArray();
		}

		public static List<T> GetList<T>()
		{
			var list = new List<T>();

			using (var sqlConnection = new SqlConnection(Resources.MainConnectionString))
			{
				sqlConnection.Open();

				var type = typeof(T);
				var nameSpace = type.Namespace.Split('.').LastOrDefault();

				list = sqlConnection.Query<T>($"SELECT * FROM {nameSpace}.{type.Name}s").ToList();
			}

			return list;
		}

		public static List<T> Query<T>(string query)
		{
			var list = new List<T>();

			using (var sqlConnection = new SqlConnection(Resources.MainConnectionString))
			{
				list = sqlConnection.Query<T>(query).ToList();
			}

			return list;
		}

		public static void Update<T>(T item) where T : class
		{
			using (var sqlConnection = new SqlConnection(Resources.MainConnectionString))
			{
				sqlConnection.Open();
				sqlConnection.Update(item);
			}
		}
	}
}