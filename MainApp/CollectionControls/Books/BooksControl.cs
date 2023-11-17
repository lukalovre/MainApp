using Controller;
using Model.Collection;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Collection.Books
{
	public partial class BooksControl : UserControl
	{
		private SortableBindingList<Book> m_bindable;
		private List<Book> m_books;

		public BooksControl()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			m_books = Datasource.GetList<Book>();

			m_bindable = new SortableBindingList<Book>(m_books.OrderBy(o => o.Date).ToList());
			dataGridViewAll.DataSource = m_bindable;

			LoadData();

			SetGridAll(dataGridViewAll);
			SetGridPlanToRead(dataGridViewPlanToRead);

			dataGridViewAll.SelectLastRow();

			bookInfo1.RefreshGrid += new BookInfoControl.RefreshGridDelegate(RefreshGrid);
		}

		private static void SetZeroValuesToEmpty(DataGridView dataGridView)
		{
			var targetColumn = dataGridView.Columns.Cast<DataGridViewColumn>().ToList().FirstOrDefault(c => c.HeaderText == nameof(Book.EminaRating));
			var index = dataGridView.Columns.IndexOf(targetColumn);

			foreach (DataGridViewRow rw in dataGridView.Rows)
			{
				var value = Convert.ToString(rw.Cells[index].Value);

				if (value == "0")
				{
					rw.Cells[index].Value = string.Empty;
				}
			}
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var book = bookInfo1.GetItem();
			Datasource.Add(book);
			m_bindable.Add(book);

			dataGridViewAll.SelectLastRow();
		}

		private void ButtonRead_Click(object sender, EventArgs e)
		{
			var book = bookInfo1.GetItem();

			FormMain.Instace.ChangeTabToBooks();
			MainApp.Books.BooksControl.Instance.FillBook(book);
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var book = (sender as DataGridView).GetRowObject<Book>();

			if (book == null)
			{
				return;
			}

			bookInfo1.Fill(book);
		}


		private void LoadData()
		{
			var toRead = m_books
				.Where(o => Following.FollowingModel.BooksCollection.Contains(o.GoodreadsID.ToString()))
				.DistinctBy(o => o.GoodreadsID)
				.OrderBy(o => o.Pages)
				.ToList();

			dataGridViewPlanToRead.DataSource = new SortableBindingList<Book>(toRead);
		}

		private void RefreshGrid()
		{
			LoadData();
		}

		private void SetGridAll(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[]{
			nameof(Book.Title),
			nameof(Book.Author),
			nameof(Book.Year),
			nameof(Book._1001),
			nameof(Book.Type)});

			dataGridView.Columns[nameof(Book._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(Book._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(Book.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Book.Author)].Width = 130;
			dataGridView.Columns[nameof(Book.Year)].CenterColumn();
			dataGridView.Columns[nameof(Book.Type)].CenterColumn();
		}

		private void SetGridPlanToRead(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[]{
			nameof(Book.Title),
			nameof(Book.Author),
			nameof(Book.Year),
			nameof(Book.Pages),
			nameof(Book._1001),
			nameof(Book.EminaRating)});

			dataGridView.Columns[nameof(Book._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(Book._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(Book.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Book.Author)].Width = 130;
			dataGridView.Columns[nameof(Book.EminaRating)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
			dataGridView.Columns[nameof(Book.EminaRating)].Width = 30;
			dataGridView.Columns[nameof(Book.Year)].CenterColumn();
			dataGridView.Columns[nameof(Book.Pages)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
			dataGridView.Columns[nameof(Book.Pages)].Width = 35;

			SetZeroValuesToEmpty(dataGridView);
		}

		private void TextBoxUrl_TextChanged(object sender, EventArgs e)
		{
			var url = textBoxUrl.Text;

			var book = Links.GetGoodreadsDataBook(url);

			bookInfo1.Fill(book);

			textBoxUrl.TextChanged -= new EventHandler(TextBoxUrl_TextChanged);
			textBoxUrl.Clear();
			textBoxUrl.TextChanged += new EventHandler(TextBoxUrl_TextChanged);
		}
	}
}