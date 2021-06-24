SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
CREATE VIEW [Books].[Plan to read]
AS
SELECT        ID, [Plan to read], Title, Author, Year, [1001], Pages, Pages * 2 / 60 AS HLTB, [GoodreadsID], [Emina rating]
FROM            Collection.Books
WHERE        ([Plan to read] = 1)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
