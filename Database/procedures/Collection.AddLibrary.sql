SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [Collection].[AddLibrary]
	@ItemID int,
	@Title nvarchar(255),
	@Type nvarchar(50),
	@LentTo nvarchar(50)
AS
BEGIN
INSERT INTO Collection.Library
	   ([ItemID]
      ,[Title]
      ,[Type]
      ,[Lent to]
      ,[Lent date])
     VALUES
           (@ItemID
           ,@Title
           ,@Type
           ,@LentTo
           ,getdate())

END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
