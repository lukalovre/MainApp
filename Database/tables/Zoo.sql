CREATE TABLE [dbo].[Zoo] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Name] [nvarchar](255) NULL,
   [City] [nvarchar](255) NULL,
   [Country] [nvarchar](255) NULL,
   [With Emina] [bit] NULL,
   [Date] [datetime] NOT NULL,
   [With Vukasin] [bit] NULL

   ,CONSTRAINT [PK__Zoo__3BD01848A5FFA129] PRIMARY KEY CLUSTERED ([ID])
)


GO
