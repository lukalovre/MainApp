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
   [Got free] [bit] NULL,
   [Date buy] [datetime] NULL,
   [Price] [float] NULL,
   [Price in RSD] [float] NULL,
   [Physical copy] [bit] NULL,
   [HLTB time] [int] NULL,
   [Plan to play] [bit] NULL,
   [Played] [bit] NULL,
   [Owner] [nvarchar](25) NULL,
   [1001] [bit] NULL

   ,CONSTRAINT [PK_Collection Games] PRIMARY KEY CLUSTERED ([ID])
)


GO
