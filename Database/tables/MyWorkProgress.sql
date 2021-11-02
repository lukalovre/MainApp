CREATE TABLE [dbo].[MyWorkProgress] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [ItemID] [int] NOT NULL,
   [Title] [nvarchar](max) NULL,
   [Type] [nvarchar](50) NULL

   ,CONSTRAINT [PK_MyWorkProgress] PRIMARY KEY CLUSTERED ([ID])
   ,CONSTRAINT [UQ__MyWorkPr__727E83EA5E5B907F] UNIQUE NONCLUSTERED ([ItemID])
)


GO
