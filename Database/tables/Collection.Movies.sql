CREATE TABLE [Collection].[Movies] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Owner] [nvarchar](25) NULL,
   [Director] [nvarchar](255) NULL,
   [Title] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [Format] [nvarchar](25) NULL,
   [Region] [int] NULL,
   [Price] [float] NULL,
   [Price in RSD] [float] NULL,
   [Date buy] [datetime] NULL

   ,CONSTRAINT [PK_Movies_1] PRIMARY KEY CLUSTERED ([ID])
)


GO
