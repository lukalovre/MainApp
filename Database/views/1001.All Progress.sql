SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW [1001].[All Progress]
AS
SELECT        
  [1001].[Books].Books
, [1001].[TV Shows].[TV Shows] TVShows
, [1001].[Comics].Comics
, [1001].[Albums].Albums
, [1001].[Songs].Songs
FROM            [1001].[Books] CROSS JOIN
                         [1001].[Comics] CROSS JOIN
                         [1001].[TV Shows] CROSS JOIN                       
                         [1001].[Albums] CROSS JOIN
                         [1001].[Songs]
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
