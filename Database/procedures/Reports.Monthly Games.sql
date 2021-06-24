SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [Reports].[Monthly Games]	
	@Year int	
AS
BEGIN

select
COALESCE(sum(Time), 0) Time,
DATEPART(month, max(Date)) Month
from dbo.GameEvents
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
