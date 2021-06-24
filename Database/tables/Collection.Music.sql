CREATE TABLE [Collection].[Music] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Owner] [nvarchar](25) NULL,
   [Artist] [nvarchar](255) NULL,
   [Title] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [Format] [nvarchar](25) NULL,
   [Price] [float] NULL,
   [Price in RSD] [float] NULL,
   [Date buy] [datetime] NULL

   ,CONSTRAINT [PK_Music] PRIMARY KEY CLUSTERED ([ID])
)


GO
