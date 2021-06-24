SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW [Games].[Games per console]
AS

SELECT        TOP (100) PERCENT 
Collection.Consoles.Title,
COUNT(DISTINCT games.Title) [Number of games],

(select 
COUNT([Plan to play])
from Collection.Games
where [Plan to play] = 1
and
Collection.Consoles.Title= Platform
) 
[Plan to play]

FROM Collection.Consoles
INNER JOIN
Collection.Games AS games 
ON Collection.Consoles.Title = games.Platform
GROUP BY Collection.Consoles.Title
ORDER BY [Number of games] DESC
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
