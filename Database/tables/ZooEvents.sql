CREATE TABLE [dbo].[ZooEvents] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [ItemID] [int] NOT NULL,
   [Date] [datetime] NOT NULL,
   [People] [nvarchar](max) NULL,
   [Comment] [nvarchar](max) NULL,
   [Rating] [int] NULL

   ,CONSTRAINT [PK_ZooEvents] PRIMARY KEY CLUSTERED ([ID])
)


GO
