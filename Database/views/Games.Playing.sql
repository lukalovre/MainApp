SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW [Games].[Playing]
AS
select 
ItemID,
Title,
Year,
Platform,
Rating,
Review,
Time,
[1001],
datediff(day, Last , getdate()) Last,
datediff(day, First , getdate()) [Playing days],
Playing
from [View Games]
where Playing = 1
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
