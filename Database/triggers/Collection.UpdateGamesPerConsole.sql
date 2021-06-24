SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE TRIGGER [Collection].[UpdateGamesPerConsole]
 ON  Collection.Games  
AFTER INSERT,UPDATE,DELETE
AS  
BEGIN 

declare @Inserted nvarchar(255) = (select top 1 Platform from Inserted)

declare @Deleted nvarchar(255) = (select top 1 Platform from Deleted)

declare @Platform nvarchar(255);

if @Inserted is not null 
set @Platform = @Inserted
else
set @Platform = @Deleted


DECLARE @Games int = (SELECT top 1 [Main].[Games].[Games per console].[Number of games]
  FROM [Main].[Games].[Games per console]
  where Title = @Platform);

UPDATE Collection.Consoles
 SET Collection.Consoles.[Games] = @Games 
 where Collection.Consoles.Title = @Platform

 END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

ENABLE TRIGGER [Collection].[UpdateGamesPerConsole] ON [Collection].[Games]
GO

GO
