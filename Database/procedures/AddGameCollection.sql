SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE AddGameCollection
			@Title nvarchar(255)
           ,@Edition nvarchar(255)
           ,@Expansion bit
           ,@Year int
           ,@Platform nvarchar(25)
           ,@Client nvarchar(25)
           ,@New bit
           ,@GotFree bit
           ,@Price float
           ,@PriceInRSD float
           ,@PhysicalCopy bit
           ,@HLTBTime int
           ,@PlanToPlay bit
           ,@1001 bit

AS
BEGIN

INSERT INTO [Collection].[Games]
           ([Title]
           ,[Edition]
           ,[Expansion]
           ,[Year]
           ,[Platform]
           ,[Client]
           ,[New]
           ,[Got free]
           ,[Date buy]
           ,[Price]
           ,[Price in RSD]
           ,[Physical copy]
           ,[HLTB time]
           ,[Plan to play]
           ,[1001])
     VALUES
           (@Title
           ,@Edition
           ,@Expansion
           ,@Year
           ,@Platform
           ,@Client
           ,@New
           ,@GotFree
           ,getdate()
           ,@Price
           ,@PriceInRSD
           ,@PhysicalCopy
           ,@HLTBTime
           ,@PlanToPlay
           ,@1001)

END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
