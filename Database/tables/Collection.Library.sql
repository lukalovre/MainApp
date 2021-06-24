CREATE TABLE [Collection].[Library] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [ItemID] [int] NOT NULL,
   [Title] [nvarchar](255) NOT NULL,
   [Type] [nvarchar](25) NOT NULL,
   [Lent to] [nvarchar](255) NOT NULL,
   [Lent date] [datetime] NOT NULL,
   [Returned date] [datetime] NULL

   ,CONSTRAINT [PK_Library] PRIMARY KEY CLUSTERED ([ID])
)


GO
