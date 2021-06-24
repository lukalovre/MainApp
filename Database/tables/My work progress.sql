CREATE TABLE [dbo].[My work progress] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [ItemID] [int] NOT NULL,
   [Title] [nvarchar](max) NULL,
   [Type] [nvarchar](50) NULL,
   [Date] [datetime] NOT NULL,
   [Time] [int] NULL

   ,CONSTRAINT [PK_My work progress] PRIMARY KEY CLUSTERED ([ID])
)


GO
