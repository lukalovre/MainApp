SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW [1001].[Collection Books]
AS
SELECT        COUNT(Title) AS Books
FROM            Collection.Books
WHERE        ([1001] = 1)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
