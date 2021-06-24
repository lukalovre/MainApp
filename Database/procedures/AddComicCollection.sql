SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [dbo].[AddComicCollection] 
	         @Owner nvarchar(25)
           ,@Title nvarchar(255)
           ,@Chapter int
           ,@Writer nvarchar(255)
		   ,@Illustrator nvarchar(255)
           ,@Language nvarchar(255)
           ,@GoodreadsID int
           ,@Price float
           ,@PriceInRSD float
	
	AS
BEGIN
	
	INSERT INTO [Collection].[Comics]
           ([Owner]
           ,[Title]
           ,[Chapter]
           ,[Writer]
		   ,[Illustrator]
           ,[Language]
           ,[GoodreadsID]
           ,[Date buy]
           ,[Price]
           ,[Price in RSD])
     VALUES
           (@Owner
           ,@Title
           ,@Chapter
           ,@Writer
		   ,@Illustrator
           ,@Language
           ,@GoodreadsID
           ,getdate()
           ,@Price
           ,@PriceInRSD)

END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
