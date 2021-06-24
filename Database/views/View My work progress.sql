SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW [dbo].[View My work progress]
AS
SELECT        
MAX(ItemID) ItemID,
MAX(Title) Title,
MAX(Type) Type,
SUM(Time) Time,
MAX(Date) Last
FROM            dbo.[My work progress]
GROUP BY ItemID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
