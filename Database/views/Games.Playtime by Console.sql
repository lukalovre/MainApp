SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
/****** Script for SelectTopNRows command from SSMS  ******/
create view Games.[Playtime by Console]

as
SELECT 
sum([Time]) Time,
max([Platform]) Platform
FROM [Main].[dbo].[View Games]
group by Platform
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
