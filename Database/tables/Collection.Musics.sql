CREATE TABLE [Collection].[Musics] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Owner] [nvarchar](25) NULL,
   [Artist] [nvarchar](255) NULL,
   [Title] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [Format] [nvarchar](25) NULL,
   [Price] [float] NULL,
   [PriceInRSD] [float] NULL,
   [Date] [datetime] NULL

   ,CONSTRAINT [PK_Music] PRIMARY KEY CLUSTERED ([ID])
)


GO
