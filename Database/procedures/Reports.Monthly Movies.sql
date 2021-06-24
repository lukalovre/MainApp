SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [Reports].[Monthly Movies]	
	@Year int	
AS
BEGIN

select
COALESCE(sum(m.Runtime)/60.0, 0) Time,
DATEPART(month, max(Date)) Month
from dbo.MovieEvents e
join Movies m on m.Imdb = e.Imdb
where
year(Date) = @Year
group by datepart(month,Date)

END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
