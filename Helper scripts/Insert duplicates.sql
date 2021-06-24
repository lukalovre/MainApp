DECLARE @intFlag INT
SET @intFlag = 2

WHILE (@intFlag <=4)
BEGIN    

	insert into Books(
       [Title]
      ,[Author]
      ,[Year]
      ,[Pages]
      ,[Rating]
      ,[1001]
      ,[GoodreadsID]
      ,[First])
select 
       [Title]
      ,[Author]
      ,[Year]
      ,[Pages]
      ,[Rating]
      ,[1001]
      ,[GoodreadsID]
      ,[Last]
from Books
where [Read] >= @intFlag

SET @intFlag = @intFlag + 1

END


