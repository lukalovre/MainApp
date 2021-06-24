CREATE TABLE [Collection].[Consoles] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Title] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [Condition] [nvarchar](255) NULL,
   [Type] [nvarchar](255) NULL,
   [Generation] [int] NULL,
   [Controllers] [int] NULL,
   [Games] [int] NULL,
   [Date buy] [datetime] NULL,
   [Price] [float] NULL,
   [Price in RSD] [float] NULL

   ,CONSTRAINT [PK_Consoles] PRIMARY KEY CLUSTERED ([ID])
)


GO
