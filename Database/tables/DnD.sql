CREATE TABLE [dbo].[DnD] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Title] [nvarchar](255) NOT NULL,
   [Role] [nvarchar](25) NULL

   ,CONSTRAINT [DnD_PK] PRIMARY KEY CLUSTERED ([ID])
)


GO
