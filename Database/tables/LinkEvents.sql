CREATE TABLE [dbo].[LinkEvents] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [ItemID] [int] NOT NULL,
   [Date] [datetime] NOT NULL

   ,CONSTRAINT [PK_LinkEvents] PRIMARY KEY CLUSTERED ([ID])
)


GO
