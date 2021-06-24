SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [dbo].[UpdateMyWorkProgress]
 @ItemID int  
,@Time float
AS
BEGIN

INSERT INTO [dbo].[My work progress] 
           ([ItemID]
           ,[Title]
		   ,[Type]
           ,[Time]
           ,[Date])
select top 1
            ItemID
           ,Title
           ,Type
           ,@Time
           ,getdate()
from [My work progress]
where ItemID = @ItemID
	
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
