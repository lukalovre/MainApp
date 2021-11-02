CREATE TABLE [dbo].[MyWorkProgressEvents] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [ItemID] [int] NOT NULL,
   [Date] [datetime] NOT NULL,
   [Time] [int] NULL,
   [Comment] [nvarchar](max) NULL,
   [Rating] [int] NULL

   ,CONSTRAINT [PK_MyWorkProgressEvents] PRIMARY KEY CLUSTERED ([ID])
)


GO
