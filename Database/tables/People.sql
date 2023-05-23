CREATE TABLE [dbo].[People] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [FirstName] [nvarchar](25) NOT NULL,
   [LastName] [nvarchar](25) NOT NULL,
   [Address] [nvarchar](255) NULL,
   [City] [nvarchar](50) NULL,
   [Postcode] [int] NULL,
   [Birthday] [date] NULL,
   [Nickname] [nvarchar](100) NULL

   ,CONSTRAINT [People_PK] PRIMARY KEY CLUSTERED ([ID])
)


GO
