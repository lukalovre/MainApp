CREATE TABLE [dbo].[Songs] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Artist] [nvarchar](255) NULL,
   [Title] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [Runtime] [int] NULL,
   [Link] [nvarchar](max) NULL

   ,CONSTRAINT [PK_Songs] PRIMARY KEY CLUSTERED ([ID])
)


GO
