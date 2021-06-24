SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE view [dbo].[Book stats] as
select top 100 percent
max(Year(Date)) Year,
count(ID) Items, 
sum([Minutes read])/60.0 Hours
from [Books expanded]
where Date is not NULL
group by Year(Date)
order by Year(Date)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
