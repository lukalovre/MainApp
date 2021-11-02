CREATE TABLE [dbo].[Movies] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Title] [nvarchar](max) NULL,
   [OriginalTitle] [nvarchar](max) NULL,
   [Runtime] [int] NULL,
   [Year] [int] NULL,
   [Director] [nvarchar](max) NULL,
   [Writer] [nvarchar](max) NULL,
   [Imdb] [nvarchar](255) NULL,
   [Actors] [nvarchar](max) NULL,
   [Country] [nvarchar](max) NULL,
   [Ganre] [nvarchar](max) NULL,
   [Language] [nvarchar](max) NULL,
   [Plot] [nvarchar](max) NULL,
   [Type] [nvarchar](max) NULL

   ,CONSTRAINT [PK_Movies_temp] PRIMARY KEY CLUSTERED ([ID])
   ,CONSTRAINT [UQ__Movies_t__46F0AAEEF7A64447] UNIQUE NONCLUSTERED ([Imdb])
)


GO
