using Dapper;
using MainApp.Properties;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MainApp
{
	public static class SQLHelper
	{
		public static string EscapeSpecialCharacters(string title)
		{
			if(title == null)
			{
				return null;
			}

			if(title.Length >= 254)
			{
				title = title.Substring(0, 254);
			}

			return title.Replace(@"'", @"''");
		}

		public static string[] GetDropdownValues(string query)
		{
			var result = new List<string>();

			using(IDbConnection db = new SqlConnection(Resources.MainConnectionString))
			{
				result = db.Query<string>(query).ToList();
			}

			result.RemoveAll(s => string.IsNullOrWhiteSpace(s));
			result.Sort();
			return result.ToArray();
		}

		public static string GetText(string text)
		{
			text = EscapeSpecialCharacters(text);
			return string.IsNullOrEmpty(text) ? "NULL" : $"N'{text}'";
		}
	}
}