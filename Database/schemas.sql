
if not exists(select s.schema_id from sys.schemas s where s.name = 'Collection') 
	and exists(select p.principal_id from sys.database_principals p where p.name = 'dbo') begin
	exec sp_executesql N'create schema [Collection] authorization [dbo]'
end
GO

