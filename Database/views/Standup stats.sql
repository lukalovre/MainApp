SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
create view dbo.[Standup stats] as
select top 100 percent
max(Year(Date)) Year,
count(ID) Items, 
sum(Runtime)/60 Hours
from Standup
where Date is not NULL
group by Year(Date)
order by Year(Date)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
