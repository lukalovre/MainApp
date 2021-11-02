SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [Reports].[Yearly All]	
	@Year int	
AS
BEGIN

declare @temp table (
    idx int identity(1,1),
    timeHours int)

declare @result int

insert into @temp (timeHours)
exec @result = [Reports].[Yearly Books]  @Year

insert into @temp (timeHours)
exec @result = [Reports].[Yearly Comics]  @Year

insert into @temp (timeHours)
exec @result = [Reports].[Yearly Games]  @Year

insert into @temp (timeHours)
exec @result = [Reports].[Yearly Movies]  @Year

insert into @temp (timeHours)
exec @result = [Reports].[Yearly Music]  @Year

insert into @temp (timeHours)
exec @result = [Reports].[Yearly MyWorkProgress]  @Year

insert into @temp (timeHours)
exec @result = [Reports].[Yearly TVShows]  @Year

select sum(timeHours) 
from  @temp

END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
