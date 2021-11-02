CREATE TABLE [Collection].[Games] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Title] [nvarchar](255) NULL,
   [Edition] [nvarchar](255) NULL,
   [Expansion] [bit] NULL,
   [Year] [int] NULL,
   [Platform] [nvarchar](25) NOT NULL,
   [Client] [nvarchar](25) NULL,
   [New] [bit] NULL,
   [GotFree] [bit] NULL,
   [Date] [datetime] NULL,
   [Price] [float] NULL,
   [PriceInRSD] [float] NULL,
   [PhysicalCopy] [bit] NULL,
   [HLTB] [int] NULL,
   [Owner] [nvarchar](25) NULL,
   [Igdb] [int] NOT NULL

   ,CONSTRAINT [PK_Collection Games] PRIMARY KEY CLUSTERED ([ID])
)


GO
