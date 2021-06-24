SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW [Music].[Top 50 Music]
AS
SELECT        TOP (50) Artist, SUM(Runtime * Rating) / 60 AS Total
FROM            dbo.[View Music]
WHERE        (Artist <> 'Various artists')
GROUP BY Artist
ORDER BY Total DESC
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
