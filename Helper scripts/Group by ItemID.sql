select
max(ItemID) ItemID
,max(Artist) Artist
,max(Title) Title
,Max(Year) Year
,Max(Runtime) Runtime
,count(ItemID) Rating
,Max(cast([In] as int)) [In]
,CASE WHEN min(CASE WHEN Date IS NULL THEN 1 ELSE 0 END) = 0
        THEN min(Date)
		end First
,max(Date) Last
from dbo.Music
group by ItemID
order by Last

