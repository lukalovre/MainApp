CREATE TABLE [Collection].[Librarys] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [ItemID] [int] NOT NULL,
   [Title] [nvarchar](255) NOT NULL,
   [Type] [nvarchar](25) NOT NULL,
   [LentTo] [nvarchar](255) NOT NULL,
   [LentDate] [datetime] NOT NULL,
   [ReturnDate] [datetime] NULL

   ,CONSTRAINT [PK_Library] PRIMARY KEY CLUSTERED ([ID])
)


GO
