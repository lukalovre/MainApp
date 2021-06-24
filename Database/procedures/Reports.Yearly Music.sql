SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE PROCEDURE [Reports].[Yearly Music]	
	@Year int	
AS
BEGIN

select
COALESCE(sum(m.Runtime)/60.0, 0) Time
from dbo.MusicEvents e
JOIN dbo.Musics m ON m.ItemID = e.ItemID
where 
year(Date) = @Year

END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
