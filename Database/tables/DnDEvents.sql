CREATE TABLE [dbo].[DnDEvents] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [ItemID] [int] NOT NULL,
   [Date] [datetime] NULL,
   [Hours] [int] NULL,
   [Location] [nvarchar](255) NULL,
   [Level] [int] NULL,
   [Summary] [nvarchar](max) NULL,
   [People] [nvarchar](255) NULL

   ,CONSTRAINT [DnDEvents_PK] PRIMARY KEY CLUSTERED ([ID])
)


GO
