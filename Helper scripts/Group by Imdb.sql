select  
 max(Imdb) as Imdb
,max(Title) as Title
,Max(Year) as Year
,Max(Runtime) as Runtime
,AVG(Cast(Rating as Float)) as Rating
,Count(ID) as [Watched times]
,MAX([Emina watched]) as [Emina watched]
,Max([Watched in cinema]) as [Watched in cinema]
,CASE WHEN min(CASE WHEN Date IS NULL THEN 1 ELSE 0 END) = 0
        THEN min(Date)
		end as First
,max(Date) as Last
from dbo.Movies m
group by imdb
order by last