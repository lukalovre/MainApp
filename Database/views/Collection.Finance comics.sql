SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW Collection.[Finance comics]
AS

SELECT	

year([Date buy])	[Year],
count(ID) Comics,
cast(SUM([Price in RSD])/(select dbo.EuroValue()) as INT)	Price,
cast(SUM([Price in RSD])/(select dbo.EuroValue()) as INT)/count(ID) [Price per comic]

FROM Collection.Comics
where 
[Date buy] is not null AND
year([Date buy]) >= 2016
group by year([Date buy])
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
