declare @index int  = 2
WHILE @index <= 6
BEGIN
INSERT INTO [dbo].[Comics]  ([Title],[Writer],[Illustrator],[Year],[Read],[Chapters],[Pages],[Rating],[1001],[GoodreadsID],Date)
select top 1 Title,Writer,Illustrator,Year,[Read],@index,Pages,Rating,[1001],GoodreadsID,Date
from Comics
where ID = 202

set @index= @index + 1;
END

update Comics
set Chapters = 1
where ID = 202
