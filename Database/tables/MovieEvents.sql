CREATE TABLE [dbo].[MovieEvents] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Imdb] [nvarchar](255) NULL,
   [Date] [datetime] NULL,
   [Rating] [int] NULL,
   [Comment] [nvarchar](max) NULL,
   [WatchedInCinema] [bit] NOT NULL,
   [EminaWatched] [bit] NULL

   ,CONSTRAINT [PK_MovieEvents] PRIMARY KEY CLUSTERED ([ID])
)


GO
