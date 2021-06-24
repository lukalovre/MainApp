CREATE TABLE [dbo].[TVShowEvents] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Imdb] [nvarchar](255) NULL,
   [Season] [int] NULL,
   [Episodes] [int] NULL,
   [Rating] [int] NULL,
   [Date] [datetime] NULL,
   [Comment] [nvarchar](max) NULL

   ,CONSTRAINT [PK_TV ShowEvents] PRIMARY KEY CLUSTERED ([ID])
)


GO
