SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [dbo].[UpdateMusic]
		 @ItemID int  
        ,@In bit
AS
BEGIN

insert  into [Music](
       [ItemID]
      ,[Artist]
      ,[Title]
      ,[Year]
      ,[Runtime]
      ,[In]
      ,[1001]
      ,[On LP]
      ,[Top 9]
      ,[Date])
select top 1
       [ItemID]
      ,[Artist]
      ,[Title]
      ,[Year]
      ,[Runtime]
      ,@In
      ,[1001]
      ,[On LP]
      ,[Top 9]
      ,GETDATE()
from [Music]
WHERE [ItemID] = @ItemID

END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
