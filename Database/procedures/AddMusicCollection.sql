SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [dbo].[AddMusicCollection]
	@Owner nvarchar(25)
           ,@Artist nvarchar(255)
           ,@Title nvarchar(255)
           ,@Year int
           ,@Format nvarchar(25)
           ,@Price float
           ,@PriceInRSD float


	
	AS
BEGIN
	
INSERT INTO [Collection].[Music]
           ([Owner]
           ,[Artist]
           ,[Title]
           ,[Year]
           ,[Format]
           ,[Price]
           ,[Price in RSD]
           ,[Date buy])
     VALUES
           (@Owner
           ,@Artist
           ,@Title
           ,@Year
           ,@Format
           ,@Price
           ,@PriceInRSD
           ,getdate())

END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
