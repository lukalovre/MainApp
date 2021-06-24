SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [Reports].[Monthly Comics]	
	@Year int	
AS
BEGIN

select
COALESCE(sum(Pages)*dbo.MinutesPerPage_Comics()/60, 0) Time,
DATEPART(month, max(Date)) Month
from ComicEvents
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
