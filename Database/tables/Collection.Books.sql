CREATE TABLE [Collection].[Books] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Title] [nvarchar](255) NULL,
   [Author] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [Pages] [int] NULL,
   [Type] [nvarchar](25) NULL,
   [_1001] [bit] NULL,
   [EminaRating] [int] NULL,
   [EminaRead] [bit] NULL,
   [LukaRead] [bit] NULL,
   [GoodreadsID] [int] NULL,
   [Price] [float] NULL,
   [PriceInRSD] [float] NULL,
   [Date] [datetime] NULL

   ,CONSTRAINT [PK__Collecti__3BD018483F5388E4] PRIMARY KEY CLUSTERED ([ID])
)


GO
