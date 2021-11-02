SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [Reports].[Monthly TV Shows]	
	@Year int	
AS
BEGIN

select
COALESCE(sum(e.Episodes * tv.Runtime)/60.0, 0) Time,
DATEPART(month, max(Date)) Month
from dbo.TVShowEvents e
join TVShows tv on tv.Imdb = e.Imdb
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
