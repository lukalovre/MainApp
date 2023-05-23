using Model.dbo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Books
{
	public partial class BooksControl : UserControl
	{
		internal static BooksControl Instance;
		private BindingList<Book> m_bindingList;
		private List<BookEvent> m_bookEvents;
		private List<Book> m_books;

		public BooksControl()
		{
			InitializeComponent();
		}

		public void FillBook(Model.Collection.Book bookCollection)
		{
			var book = new Book
			{
				Author = bookCollection.Author,
				GoodreadsID = bookCollection.GoodreadsID.Value,
				Title = bookCollection.Title,
				Year = bookCollection.Year.Value,
				_1001 = bookCollection._1001
			};

			bookInfo1.Fill(book, null);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			Instance = this;

			m_books = Controller.Datasource.GetList<Book>();
			m_bookEvents = Controller.Datasource.GetList<BookEvent>();

			yearFilter1.SetValueChangedEvent(NumericUpDownYearFilter_ValueChanged);

			SetGrid();

			dataGridViewAll.SelectLastRow();
		}

		private void ButtonUpdate_Click(object sender, EventArgs e)
		{
			var book = bookInfo1.GetItem();

			if (!m_books.Any(o => o.GoodreadsID == book.GoodreadsID))
			{
				Controller.Datasource.Add(book);
				m_books.Add(book);
			}

			var bookEvent = bookInfo1.GetEvent();

			Controller.Datasource.Add(bookEvent);
			m_bookEvents.Add(bookEvent);

			bookInfo1.Fill(book, m_bookEvents.Where(o => o.GoodreadsID == book.GoodreadsID).ToList());
		}

		private void DataGridViewAll_SelectionChanged(object sender, EventArgs e)
		{
			var book = (sender as DataGridView).GetRowObject<Book>();

			if (book == null)
			{
				return;
			}

			bookInfo1.Fill(book, m_bookEvents.Where(o => o.GoodreadsID == book.GoodreadsID).ToList());
		}

		private void NumericUpDownYearFilter_ValueChanged(object sender, EventArgs e)
		{
			var thisYear = m_bookEvents.Where(m => m.Date.HasValue && m.Date.Value.Year == (sender as NumericUpDown).Value).ToList();

			var bind = new List<Book>();

			foreach (var me in thisYear)
			{
				var m = m_books.FirstOrDefault(o => o.GoodreadsID == me.GoodreadsID);
				bind.Add(m);
			}

			m_bindingList = new BindingList<Book>(bind.Distinct().ToList());

			dataGridViewAll.DataSource = new BindingSource(m_bindingList, null);
		}

		private void SetGrid()
		{
			dataGridViewAll.SetGrid();

			dataGridViewAll.SetColumns(new string[]{
			nameof(Book.Title),
			nameof(Book.Author),
			nameof(Book.Year),
			nameof(Book._1001)});

			dataGridViewAll.Columns[nameof(Book._1001)].HeaderText = "1001";
			dataGridViewAll.Columns[nameof(Book._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewAll.Columns[nameof(Book.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewAll.Columns[nameof(Book.Author)].Width = 130;
			dataGridViewAll.Columns[nameof(Book.Year)].CenterColumn();
		}
	}
}