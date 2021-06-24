
SELECT *
  FROM [Main].[dbo].[Movies]
  where [Original title] <> ''
  and Imdb = 'tt0073650'

  select * 
  from [Imdb].dbo.[title basics]
  where tconst= 'tt0073650'