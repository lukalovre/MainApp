
if not exists(select s.schema_id from sys.schemas s where s.name = 'Collection') 
	and exists(select p.principal_id from sys.database_principals p where p.name = 'dbo') begin
	exec sp_executesql N'create schema [Collection] authorization [dbo]'
end

if not exists(select s.schema_id from sys.schemas s where s.name = '1001') 
	and exists(select p.principal_id from sys.database_principals p where p.name = 'dbo') begin
	exec sp_executesql N'create schema [1001] authorization [dbo]'
end

if not exists(select s.schema_id from sys.schemas s where s.name = 'Games') 
	and exists(select p.principal_id from sys.database_principals p where p.name = 'dbo') begin
	exec sp_executesql N'create schema [Games] authorization [dbo]'
end

if not exists(select s.schema_id from sys.schemas s where s.name = 'Movies') 
	and exists(select p.principal_id from sys.database_principals p where p.name = 'dbo') begin
	exec sp_executesql N'create schema [Movies] authorization [dbo]'
end

if not exists(select s.schema_id from sys.schemas s where s.name = 'Music') 
	and exists(select p.principal_id from sys.database_principals p where p.name = 'dbo') begin
	exec sp_executesql N'create schema [Music] authorization [dbo]'
end

if not exists(select s.schema_id from sys.schemas s where s.name = 'TV Shows') 
	and exists(select p.principal_id from sys.database_principals p where p.name = 'dbo') begin
	exec sp_executesql N'create schema [TV Shows] authorization [dbo]'
end

if not exists(select s.schema_id from sys.schemas s where s.name = 'Books') 
	and exists(select p.principal_id from sys.database_principals p where p.name = 'dbo') begin
	exec sp_executesql N'create schema [Books] authorization [dbo]'
end

if not exists(select s.schema_id from sys.schemas s where s.name = 'Reports') 
	and exists(select p.principal_id from sys.database_principals p where p.name = 'dbo') begin
	exec sp_executesql N'create schema [Reports] authorization [dbo]'
end
GO

