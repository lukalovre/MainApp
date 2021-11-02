ALTER TABLE [Collection].[Librarys] WITH CHECK ADD CONSTRAINT [FK_Library_Library]
   FOREIGN KEY([ID]) REFERENCES [Collection].[Librarys] ([ID])

GO
