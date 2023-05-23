CREATE TABLE [dbo].[MovieEvents] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Imdb] [nvarchar](255) NULL,
   [Date] [datetime] NULL,
   [Rating] [int] NULL,
   [Comment] [nvarchar](max) NULL,
   [People] [nvarchar](max) NULL,
   [Platform] [nvarchar](25) NULL

   ,CONSTRAINT [PK_MovieEvents] PRIMARY KEY CLUSTERED ([ID])
)


GO
