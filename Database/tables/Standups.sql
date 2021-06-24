CREATE TABLE [dbo].[Standups] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Title] [nvarchar](255) NOT NULL,
   [Performer] [nvarchar](255) NOT NULL,
   [Year] [int] NOT NULL,
   [Runtime] [int] NULL,
   [Rating] [int] NULL,
   [Imdb] [nvarchar](255) NOT NULL,
   [Date] [datetime] NULL

   ,CONSTRAINT [PK__Stand-up__3BD01848B6FED30C] PRIMARY KEY CLUSTERED ([ID])
)


GO
