SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW [Music].[Music to do]
AS
SELECT        ItemID, Artist, Title, Year, Runtime, Rating, [On LP], First, Last
FROM            dbo.[View Music]
WHERE        (Last < DATEADD(year,-1,GETDATE())) AND ([In] = 1)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
