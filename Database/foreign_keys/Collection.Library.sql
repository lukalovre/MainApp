ALTER TABLE [Collection].[Library] WITH CHECK ADD CONSTRAINT [FK_Library_Library]
   FOREIGN KEY([ID]) REFERENCES [Collection].[Library] ([ID])

GO
