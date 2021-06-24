CREATE TABLE [dbo].[1001 Songs] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Title] [nvarchar](255) NULL,
   [Artist] [nvarchar](255) NULL,
   [Year] [float] NULL,
   [First] [datetime] NULL,
   [Last] [datetime] NULL

   ,CONSTRAINT [PK_1001 Songs] PRIMARY KEY CLUSTERED ([ID])
)


GO
