SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
create view dbo.[TV Shows best]

as
SELECT AVG([Rating]) as Rating
      ,[Title]
      ,MIN([Year]) as Year
      ,MAX([Season]) as Seasons
      ,SUM([Episodes]) as Episodes
      ,MAX([Episode format]) as [Episode format] 
      FROM [Main].[dbo].[TV Shows]
  where Rating <> 1
  group by Title
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
