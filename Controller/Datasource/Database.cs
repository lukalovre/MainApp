using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Controller
{
	internal class Database : IDatasource
	{
		public void Add<T>(T item) where T : class
		{
			using (var sqlConnection = new SqlConnection(Settings.Instance.DatabaseConnectionString))
			{
				sqlConnection.Open();
				sqlConnection.Insert(item);
			}
		}

		public List<T> GetList<T>()
		{
			var list = new List<T>();

			using (var sqlConnection = new SqlConnection(Settings.Instance.DatabaseConnectionString))
			{
				sqlConnection.Open();

				var tAttribute = (TableAttribute)typeof(T).GetCustomAttributes(typeof(TableAttribute), true).FirstOrDefault();
				var tableName = tAttribute?.Name;

				list = sqlConnection.Query<T>($"SELECT * FROM {tableName}").ToList();
			}

			return list;
		}

		public void MakeBackup(string path)
		{
			var commandText = $@"
                BACKUP DATABASE [Main] TO  DISK = N'{path}' WITH NOFORMAT, INIT,  NAME = N'Main-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10

                declare @backupSetId as int
                select @backupSetId = position from msdb..backupset where database_name=N'Main' and backup_set_id=(select max(backup_set_id) from msdb..backupset where database_name=N'Main' )
                if @backupSetId is null begin raiserror(N'Verify failed. Backup information for database ''Main'' not found.', 16, 1) end
                RESTORE VERIFYONLY FROM  DISK = N'{path}' WITH  FILE = @backupSetId,  NOUNLOAD,  NOREWIND";

			using (var sqlConnection = new SqlConnection(Settings.Instance.DatabaseConnectionString))
			{
				sqlConnection.Open();
				sqlConnection.Execute(commandText);
			}
		}

		public void Update<T>(T item) where T : class
		{
			using (var sqlConnection = new SqlConnection(Settings.Instance.DatabaseConnectionString))
			{
				sqlConnection.Open();
				sqlConnection.Update(item);
			}
		}
	}
}