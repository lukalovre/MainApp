CREATE TABLE [dbo].[Games] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [ItemID] [int] NULL,
   [Title] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [Platform] [nvarchar](25) NULL,
   [_1001] [bit] NOT NULL

   ,CONSTRAINT [Games_tempds] PRIMARY KEY CLUSTERED ([ID])
   ,CONSTRAINT [UQ__Games_te__727E83EAD6490DC6] UNIQUE NONCLUSTERED ([ItemID])
)


GO
