SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
create view WatchWithEmina as

select max(m.Title) Title, max(m.[Year]) Year, max(m.Runtime) Runtime, max(me.Rating) Rating
from Movies m
join MovieEvents me on me.Imdb = m.Imdb
group by m.Imdb
having max(cast(me.EminaWatched as int)) = 0
and max(me.Rating) >= 3
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
