SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW Collection.[Vinyl count]
AS
SELECT        COUNT(Format) AS [Vinyl count]
FROM            Collection.Music
WHERE        (Format = 'Vinyl')
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
