SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW [Collection].[Library rented]
AS
SELECT       
ID,
ItemID,
Title,
Type,
[Lent to],
[Lent date],
DATEDIFF(DAY,[Lent date], getdate()) [Lent before days],
[Returned date]
FROM            Collection.Library
WHERE        ([Returned date] IS NULL)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
