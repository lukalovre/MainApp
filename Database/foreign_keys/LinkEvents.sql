ALTER TABLE [dbo].[LinkEvents] WITH CHECK ADD 
   FOREIGN KEY([ItemID]) REFERENCES [dbo].[Links] ([ID])

GO
