CREATE TABLE [dbo].[ComicEvents] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [GoodreadsID] [int] NULL,
   [Read] [bit] NOT NULL,
   [Chapter] [int] NULL,
   [Pages] [int] NULL,
   [Rating] [int] NULL,
   [Date] [datetime] NULL,
   [Comment] [nvarchar](max) NULL,
   [People] [nvarchar](max) NULL

   ,CONSTRAINT [PK_ComicEvents] PRIMARY KEY CLUSTERED ([ID])
)


GO
