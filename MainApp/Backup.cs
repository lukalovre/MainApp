using System;

namespace MainApp
{
	public static class Backup
	{
		public static void MakeBackup()
		{
			var name = $"Main_{DateTime.Now:yyyy_MM_dd}.bak";
			var path = @"<removed>" + name;

			var commandText = $@"
BACKUP DATABASE [Main] TO  DISK = N'{path}' WITH NOFORMAT, INIT,  NAME = N'Main-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10

declare @backupSetId as int
select @backupSetId = position from msdb..backupset where database_name=N'Main' and backup_set_id=(select max(backup_set_id) from msdb..backupset where database_name=N'Main' )
if @backupSetId is null begin raiserror(N'Verify failed. Backup information for database ''Main'' not found.', 16, 1) end
RESTORE VERIFYONLY FROM  DISK = N'{path}' WITH  FILE = @backupSetId,  NOUNLOAD,  NOREWIND
";

			SqlConnectionExtension.ExecuteNonQuery(commandText);
		}
	}
}