SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [Reports].[Yearly Games]	
	@Year int	
AS
BEGIN

select
COALESCE(sum(Time), 0) Time
from dbo.GameEvents
where 
year(Date) = @Year

END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
