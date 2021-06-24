SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW Collection.[Finance books]
AS

SELECT	

year([Date buy])	[Year],
count(ID) Books,
cast(SUM([Price in RSD])/(select dbo.EuroValue()) as INT)	Price,
cast(SUM([Price in RSD])/(select dbo.EuroValue()) as INT)/count(ID) [Price per book]

FROM Collection.Books
where 
[Date buy] is not null AND
year([Date buy]) >= 2018
group by year([Date buy])
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
