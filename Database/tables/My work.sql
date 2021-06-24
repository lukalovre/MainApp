CREATE TABLE [dbo].[My work] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [Title] [nvarchar](255) NULL,
   [Collaborators] [nvarchar](255) NULL,
   [Date] [datetime] NULL,
   [Public] [bit] NULL,
   [Type] [nvarchar](25) NULL,
   [Location] [nvarchar](255) NULL,
   [Public location] [nvarchar](255) NULL,
   [Finished] [bit] NULL

   ,CONSTRAINT [PK_My work] PRIMARY KEY CLUSTERED ([ID])
)


GO
