
SELECT top (100) percent

MAX(Title) Title,
MAX(Year) Year,
(
SELECT
  top 1 g.[Rating]
FROM
  (SELECT
     ItemID, MAX(Date) AS created_at
   FROM
     Games
   GROUP BY
     ItemID) AS latest_orders
INNER JOIN
  Games g
ON
  g.ItemID= latest_orders.ItemID AND
  g.Date= latest_orders.created_at

  where g.ItemID = games.ItemID
) Rating,
max(Review) Review, 
cast(MAX(CAST(Completed AS INT)) as bit) Completed,
SUM(Time) Time,
MAX(Platform) Platform,
CAST(MAX(CAST([1001] AS INT)) as bit) [1001],
CAST(MAX(CAST([Playing] AS INT)) as bit) [Playing],
MAX(Date) Last

FROM dbo.Games games
where year(date)=2019
GROUP BY ItemID
order by Last



