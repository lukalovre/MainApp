SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW [Movies].[Movies to watch with Emina]
AS
SELECT        Title, Runtime, Year, [Watched times], Rating, [Emina watched], First, Last, Imdb
FROM            dbo.[View Movies]
WHERE        ([Emina watched] IS NULL OR
                         [Emina watched] <> 1) AND (Rating >= 3)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
