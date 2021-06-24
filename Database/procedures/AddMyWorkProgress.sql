SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [dbo].[AddMyWorkProgress] 
            @Title nvarchar(MAX)
           ,@Type nvarchar(255)
		   ,@Time float
AS
BEGIN

INSERT INTO [dbo].[My work progress]
           ([ItemID]
           ,[Title]
           ,[Type]
           ,[Time]
           ,[Date])
     VALUES
           ((IDENT_CURRENT('[My work progress]'))
           ,@Title
           ,@Type
           ,@Time
		   ,getdate())


END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
