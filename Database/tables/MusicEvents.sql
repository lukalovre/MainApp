CREATE TABLE [dbo].[MusicEvents] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [ItemID] [int] NOT NULL,
   [In] [bit] NULL,
   [Date] [datetime] NOT NULL,
   [Comment] [nvarchar](max) NULL,
   [Rating] [int] NULL,
   [People] [nvarchar](max) NULL

   ,CONSTRAINT [PK_MusicEvents] PRIMARY KEY CLUSTERED ([ID])
)


GO
