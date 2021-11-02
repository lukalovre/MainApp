CREATE TABLE [dbo].[Games] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Title] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [Platform] [nvarchar](25) NULL,
   [Igdb] [int] NOT NULL

   ,CONSTRAINT [Games_tempds] PRIMARY KEY CLUSTERED ([ID])
)


GO
