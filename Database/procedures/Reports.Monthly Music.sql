SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [Reports].[Monthly Music]	
	@Year int	
AS
BEGIN

select
COALESCE(sum(m.Runtime)/60.0, 0) Time,
DATEPART(month, max(Date)) Month
from dbo.MusicEvents e
JOIN dbo.Musics m ON m.ItemID = e.ItemID
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
