DECLARE @DB VARCHAR(255)
SET @DB = DB_NAME()
EXEC dbo.sp_dbcmptlevel @DB, 140
EXEC('ALTER DATABASE [' + @DB + '] COLLATE Latin1_General_CI_AS')
EXEC('ALTER DATABASE [' + @DB + '] SET AUTO_CLOSE OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET AUTO_SHRINK OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET ALLOW_SNAPSHOT_ISOLATION OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET READ_COMMITTED_SNAPSHOT OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET RECOVERY FULL')
EXEC('ALTER DATABASE [' + @DB + '] SET PAGE_VERIFY CHECKSUM')
EXEC('ALTER DATABASE [' + @DB + '] SET AUTO_CREATE_STATISTICS ON')
EXEC('ALTER DATABASE [' + @DB + '] SET AUTO_UPDATE_STATISTICS ON')
EXEC('ALTER DATABASE [' + @DB + '] SET AUTO_UPDATE_STATISTICS_ASYNC OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET ANSI_NULL_DEFAULT OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET ANSI_NULLS OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET ANSI_PADDING OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET ANSI_WARNINGS OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET ARITHABORT OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET CONCAT_NULL_YIELDS_NULL OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET NUMERIC_ROUNDABORT OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET QUOTED_IDENTIFIER OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET RECURSIVE_TRIGGERS OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET CURSOR_CLOSE_ON_COMMIT OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET CURSOR_DEFAULT GLOBAL')
EXEC('ALTER DATABASE [' + @DB + '] SET TRUSTWORTHY OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET DB_CHAINING OFF')
EXEC('ALTER DATABASE [' + @DB + '] SET PARAMETERIZATION SIMPLE')
EXEC('ALTER DATABASE [' + @DB + '] SET DATE_CORRELATION_OPTIMIZATION OFF')
GO

