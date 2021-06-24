SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW Collection.[Finance games]
AS

SELECT	

year([Date buy])	[Year],
count(ID) Games,
cast(SUM([Price in RSD])/(select dbo.EuroValue()) as INT)	Price,
cast(SUM([Price in RSD])/(select dbo.EuroValue()) as INT)/count(ID) [Price per game]

FROM Collection.Games
where 
[Date buy] is not null AND
year([Date buy]) >= 2014
group by year([Date buy])
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
