SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
create PROCEDURE Reports.[Monthly My work progress]	
	@Year int	
AS
BEGIN

select
COALESCE(sum(Time)/60.0, 0) Time,
DATEPART(month, max(Date)) Month
from dbo.[My work progress]
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
