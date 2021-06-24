SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW [1001].[Collection Progress]
AS

SELECT        [1001].[Collection Books].Books,  [1001].[Collection Games].Games
FROM            [1001].[Collection Books] CROSS JOIN                     
                         [1001].[Collection Games] 
                       
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
