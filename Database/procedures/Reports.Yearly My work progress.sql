SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
create PROCEDURE [Reports].[Yearly My work progress]	
	@Year int	
AS
BEGIN

select
COALESCE(sum(Time)/60.0, 0) Time
from dbo.[My work progress]
where 
year(Date) = @Year

END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
