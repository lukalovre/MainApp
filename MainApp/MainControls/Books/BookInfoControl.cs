using Model.dbo;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Books
{
	public partial class BookInfoControl : UserControl
	{
		private int m_addedPages;
		private Book m_book;
		private List<BookEvent> m_bookEvents;

		public BookInfoControl()
		{
			InitializeComponent();
		}

		public void Fill(Book book, List<BookEvent> bookEvents)
		{
			m_book = book;
			m_bookEvents = bookEvents;

			textBoxTitle.Text = book.Title;
			textBoxAutor.Text = book.Author;
			numericUpDownYear.Value = book.Year;
			checkBox1001.Checked = book._1001;

			if (!bookEvents.Any())
			{
				numericUpDownPages.Value = 0;
				checkBoxRead.Checked = false;
				evenControl1.Clear();
				return;
			}

			var lastEvent = bookEvents.LastOrDefault();

			numericUpDownPages.Value = bookEvents.Where(o => !o.Read).Sum(o => o.Pages);
			checkBoxRead.Checked = bookEvents.Any(o => o.Read);

			// Duplicate
			var minuterPerPageBooks = 2;

			var events = bookEvents.Select(o => new Model.EventListItem
			{
				ID = o.ID,
				CountValue = o.Pages * minuterPerPageBooks,
				Date = o.Date
			}).ToList();

			evenControl1.Fill(lastEvent, events, EventListControl.CountValue.Pages);
		}

		public Book GetItem()
		{
			return new Book
			{
				Author = textBoxAutor.Text,
				Title = textBoxTitle.Text,
				GoodreadsID = m_book.GoodreadsID,
				Year = (int)numericUpDownYear.Value,
				_1001 = checkBox1001.Checked
			};
		}

		internal BookEvent GetEvent()
		{
			return new BookEvent
			{
				GoodreadsID = m_book.GoodreadsID,
				Rating = evenControl1.Rating,
				Pages = m_addedPages,
				Read = checkBoxRead.Checked,
				Comment = evenControl1.GetComment()
			};
		}

		private void NumericUpDownPages_ValueChanged(object sender, EventArgs e)
		{
			var chapter = (int)numericUpDownPages.Value;
			var beforePages = m_bookEvents == null
				? 0
				: m_bookEvents.Where(o => !o.Read).Sum(o => o.Pages);
			var nowPages = (int)(sender as NumericUpDown).Value;

			m_addedPages = nowPages - beforePages;

			labelAddingPages.Text = m_addedPages == 0
				? string.Empty
				: $"Adding {m_addedPages} pages";
		}
	}
}