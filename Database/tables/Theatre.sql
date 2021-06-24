CREATE TABLE [dbo].[Theatre] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Title] [nvarchar](255) NULL,
   [Writer] [nvarchar](255) NULL,
   [Director] [nvarchar](255) NULL,
   [Runtime] [int] NULL,
   [Rating] [int] NULL,
   [Location] [nvarchar](255) NULL,
   [City] [nvarchar](255) NULL,
   [Date] [datetime] NULL

   ,CONSTRAINT [PK__Theatre__3BD01848293BF6A1] PRIMARY KEY CLUSTERED ([ID])
)


GO
