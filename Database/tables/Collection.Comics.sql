CREATE TABLE [Collection].[Comics] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Owner] [nvarchar](25) NULL,
   [Title] [nvarchar](255) NULL,
   [Chapter] [int] NULL,
   [Writer] [nvarchar](255) NULL,
   [Illustrator] [nvarchar](255) NULL,
   [Language] [nvarchar](255) NULL,
   [GoodreadsID] [int] NOT NULL,
   [Date] [datetime] NULL,
   [Price] [float] NULL,
   [PriceInRSD] [float] NULL

   ,CONSTRAINT [PK_Comics_1] PRIMARY KEY CLUSTERED ([ID])
)


GO
