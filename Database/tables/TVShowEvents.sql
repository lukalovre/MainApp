CREATE TABLE [dbo].[TVShowEvents] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Imdb] [nvarchar](255) NULL,
   [Season] [int] NULL,
   [Rating] [int] NULL,
   [Date] [datetime] NULL,
   [Comment] [nvarchar](max) NULL,
   [People] [nvarchar](max) NULL,
   [Runtime] [int] NULL

   ,CONSTRAINT [PK_TV ShowEvents] PRIMARY KEY CLUSTERED ([ID])
)


GO
