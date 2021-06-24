SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE view [dbo].[Comics expanded] as

SELECT 
*,
(Pages * (select dbo.MinutesPerPage_Comics())) [Minutes read],
(Pages * (select dbo.MinutesPerPage_Comics()))/60.0		[Hours read]

FROM [Main].[dbo].[Comics]
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
