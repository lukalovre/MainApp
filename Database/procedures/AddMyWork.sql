SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
create PROCEDURE [dbo].[AddMyWork]
	@Title nvarchar(255),
	@Collaborators nvarchar(255),
	@Public bit,
	@Type nvarchar(255),
	@Location nvarchar(255),
	@PublicLocation nvarchar(255),
	@Finished bit
AS
BEGIN


INSERT INTO [dbo].[My work]
			([Title]
			,[Collaborators]
			,[Date]
			,[Public]
			,[Type]
			,[Location]
			,[Public location]
			,[Finished])
     VALUES
           (@Title
           ,@Collaborators
           ,getdate()
           ,@Public
           ,@Type
           ,@Location 
           ,@PublicLocation
           ,@Finished)
		   			 		  
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

GO
