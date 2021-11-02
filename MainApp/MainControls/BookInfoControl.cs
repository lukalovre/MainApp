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

			if (bookEvents == null)
			{
				numericUpDownPages.Value = 0;
				starRating1.SelectedStar = 1;
				checkBoxRead.Checked = false;
				return;
			}

			numericUpDownPages.Value = bookEvents.Sum(o => o.Pages);
			starRating1.SelectedStar = bookEvents.MaxBy(o => o.Date).FirstOrDefault().Rating.Value;
			checkBoxRead.Checked = bookEvents.Any(o => o.Read);
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
				Date = DateTime.Now,
				GoodreadsID = m_book.GoodreadsID,
				Rating = starRating1.SelectedStar,
				Pages = m_addedPages,
				Read = checkBoxRead.Checked
			};
		}

		private void NumericUpDownPages_ValueChanged(object sender, EventArgs e)
		{
			var chapter = (int)numericUpDownPages.Value;
			var beforePages = m_bookEvents == null
				? 0
				: m_bookEvents.Sum(o => o.Pages);
			var nowPages = (int)(sender as NumericUpDown).Value;

			m_addedPages = nowPages - beforePages;

			labelAddingPages.Text = m_addedPages == 0
				? string.Empty
				: $"Adding {m_addedPages} pages";
		}
	}
}