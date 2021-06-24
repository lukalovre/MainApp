CREATE TABLE [dbo].[Comics] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [GoodreadsID] [int] NULL,
   [Title] [nvarchar](255) NULL,
   [Writer] [nvarchar](255) NULL,
   [Illustrator] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [_1001] [bit] NOT NULL

   ,CONSTRAINT [PK_Comics_temps] PRIMARY KEY CLUSTERED ([ID])
   ,CONSTRAINT [UQ__Comics_t__64D34154405A33F5] UNIQUE NONCLUSTERED ([GoodreadsID])
)


GO
