CREATE TABLE [dbo].[Pinball] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Title] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [Ipdb] [nvarchar](255) NOT NULL,
   [Country] [nvarchar](255) NULL,
   [City] [nvarchar](255) NULL,
   [First] [datetime] NULL

   ,CONSTRAINT [PK_Pinball_1] PRIMARY KEY CLUSTERED ([ID])
)


GO
