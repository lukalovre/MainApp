CREATE TABLE [dbo].[GameEvents] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Rating] [int] NULL,
   [Comment] [nvarchar](max) NULL,
   [Completed] [bit] NULL,
   [Time] [int] NULL,
   [Date] [datetime] NULL,
   [Igdb] [int] NOT NULL,
   [People] [nvarchar](max) NULL

   ,CONSTRAINT [PK_GameEvents] PRIMARY KEY CLUSTERED ([ID])
)


GO
