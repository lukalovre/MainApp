CREATE TABLE [dbo].[BookEvents] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [GoodreadsID] [int] NULL,
   [Rating] [int] NULL,
   [Date] [datetime] NULL,
   [Pages] [int] NULL,
   [Read] [bit] NULL,
   [Comment] [nvarchar](max) NULL,
   [People] [nvarchar](max) NULL

   ,CONSTRAINT [PK__BookEvents] PRIMARY KEY CLUSTERED ([ID])
)


GO
