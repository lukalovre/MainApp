CREATE TABLE [dbo].[Classical] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [ItemID] [int] NOT NULL,
   [Title] [nvarchar](255) NULL,
   [Composser] [nvarchar](255) NULL,
   [Year] [float] NULL,
   [Vote] [float] NULL,
   [Note] [nvarchar](255) NULL,
   [Date] [datetime] NULL

   ,CONSTRAINT [PK_Classical] PRIMARY KEY CLUSTERED ([ID])
)


GO
