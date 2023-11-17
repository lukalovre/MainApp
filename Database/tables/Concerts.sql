CREATE TABLE [dbo].[Concerts] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Title] [nvarchar](255) NULL,
   [Festival] [nvarchar](255) NULL,
   [Venue] [nvarchar](255) NULL,
   [City] [nvarchar](255) NULL,
   [Country] [nvarchar](255) NULL,
   [Price] [int] NULL,
   [Date] [date] NULL,
   [People] [nvarchar](max) NULL,
   [Comment] [nvarchar](max) NULL,
   [Rating] [int] NOT NULL

   ,CONSTRAINT [PK__Concerts__3BD018485B7F5AE0] PRIMARY KEY CLUSTERED ([ID])
)


GO
