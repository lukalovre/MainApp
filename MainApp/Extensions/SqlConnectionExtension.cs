using MainApp.Properties;
using System;
using System.Data.SqlClient;

namespace MainApp
{
	public static class SqlConnectionExtension
	{
		public static void ExecuteNonQuery(string commandText)
		{
			try
			{
				using(var sqlConnection = new SqlConnection(Resources.MainConnectionString))
				{
					var cmd = new SqlCommand
					{
						CommandText = commandText,
						Connection = sqlConnection
					};

					sqlConnection.Open();

					cmd.ExecuteNonQuery();
				}
			}
			catch(Exception)
			{
			}
		}
	}
}