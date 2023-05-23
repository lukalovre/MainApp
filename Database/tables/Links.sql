CREATE TABLE [dbo].[Links] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Url] [nvarchar](max) NOT NULL,
   [Title] [nvarchar](255) NOT NULL,
   [Category] [nvarchar](25) NULL,
   [SubCategory] [nvarchar](25) NULL

   ,CONSTRAINT [Links_PK] PRIMARY KEY CLUSTERED ([ID])
)


GO
