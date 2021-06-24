SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW [Games].[Plan to play games]
AS
SELECT

MAX(ID) AS ID,
CAST(MAX(CAST([Plan to play] AS INT)) AS BIT) [Plan to play],
Title,
MAX(Year) AS Year,
MAX(Platform) AS Platform,
MAX(Client) AS Client,
MAX([HLTB time]) AS [HLTB time],
MIN([Date buy]) AS [Date buy],
CAST(MAX(CAST([1001] AS INT)) AS BIT) AS [1001]

FROM            Collection.Games
WHERE        ([Plan to play] = 1)
GROUP BY Title
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
