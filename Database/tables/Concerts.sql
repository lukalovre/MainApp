CREATE TABLE [dbo].[Concerts] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Concert] [nvarchar](255) NULL,
   [Festival] [nvarchar](255) NULL,
   [Venue] [nvarchar](255) NULL,
   [City] [nvarchar](255) NULL,
   [Country] [nvarchar](255) NULL,
   [Ticket price] [int] NULL,
   [Date] [date] NULL

   ,CONSTRAINT [PK__Concerts__3BD018485B7F5AE0] PRIMARY KEY CLUSTERED ([ID])
)


GO
