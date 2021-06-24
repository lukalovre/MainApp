CREATE TABLE [dbo].[Books] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [GoodreadsID] [int] NULL,
   [Title] [nvarchar](255) NULL,
   [Author] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [_1001] [bit] NOT NULL

   ,CONSTRAINT [PK__Books] PRIMARY KEY CLUSTERED ([ID])
   ,CONSTRAINT [UQ__Books_te__64D34154E2C36764] UNIQUE NONCLUSTERED ([GoodreadsID])
)


GO
