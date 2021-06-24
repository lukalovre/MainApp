update Movies
set Movies.Title= i.primaryTitle
  ,Movies.[Original title]=i.originalTitle
from [Main].[dbo].[Movies] m
inner join 
Imdb.dbo.[title basics] i
on
m.Imdb = i.tconst


update Movies
set [Original title]=NULL
where [Original title] = Title
