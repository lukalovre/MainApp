CREATE TABLE [dbo].[Musics] (
   [ID] [int] NOT NULL
      IDENTITY (1,1),
   [ItemID] [int] NOT NULL,
   [Artist] [nvarchar](255) NULL,
   [Title] [nvarchar](255) NULL,
   [Year] [int] NULL,
   [Runtime] [int] NULL,
   [_1001] [bit] NULL,
   [SpotifyID] [nvarchar](255) NULL

   ,CONSTRAINT [PK_Musics] PRIMARY KEY CLUSTERED ([ID])
   ,CONSTRAINT [UQ__Musics__727E83EA1233E70F] UNIQUE NONCLUSTERED ([ItemID])
)


GO
