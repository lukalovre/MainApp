CREATE TABLE [dbo].[TVShows] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Imdb] [nvarchar](255) NULL,
   [Title] [nvarchar](255) NULL,
   [OriginalTitle] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [Runtime] [int] NULL,
   [Actors] [nvarchar](max) NULL,
   [Country] [nvarchar](max) NULL,
   [Genre] [nvarchar](max) NULL,
   [Language] [nvarchar](max) NULL,
   [Plot] [nvarchar](max) NULL,
   [Type] [nvarchar](max) NULL,
   [Director] [nvarchar](max) NULL,
   [Writer] [nvarchar](max) NULL

   ,CONSTRAINT [PK_TV Shows_temp] PRIMARY KEY CLUSTERED ([ID])
   ,CONSTRAINT [UQ__TVShows___46F0AAEEABC9134C] UNIQUE NONCLUSTERED ([Imdb])
)


GO
