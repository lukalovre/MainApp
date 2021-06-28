using MainApp.Properties;
using Model.Collection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Collection.Books
{
	public partial class BooksControl : UserControl
	{
		public static BooksControl Instance;
		private List<Book> m_books;

		public BooksControl()
		{
			InitializeComponent();
			Instance = this;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if(DesignMode)
			{
				return;
			}

			m_books = Controller.Database.GetList<Book>();

			dataGridViewAll.DataSource = m_books;
			dataGridViewPlanToRead.DataSource = m_books.Where(o => o.PlanToRead).ToList();

			SetGridAll(dataGridViewAll);
			SetGridPlanToRead(dataGridViewPlanToRead);

			dataGridViewAll.SelectLastRow();
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var book = bookInfo1.GetItem();
			Controller.Database.Add(book);

			m_books = Controller.Database.GetList<Book>();
			dataGridViewAll.DataSource = m_books;
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

			if(book == null)
			{
				return;
			}

			bookInfo1.Fill(book);
		}

		private void DataGridView1CellDoubleClick(object sender, DataGridViewCellEventArgs dataGridViewCellEventArgs)
		{
			//var dataGrid = sender as DataGridCustom;

			//string goodreadsID = dataGrid.Rows[dataGridViewCellEventArgs.RowIndex].Cells[Table.GoodreadsID].Value.ToString();

			//if(dataGridViewCellEventArgs.ColumnIndex == -1)
			//{
			//	var hyperlink = $@"https://www.goodreads.com/book/show/{goodreadsID}";
			//	System.Diagnostics.Process.Start(hyperlink);
			//	return;
			//}

			//string title = dataGrid.Rows[dataGridViewCellEventArgs.RowIndex].Cells[Table.Title].Value.ToString();
			//string author = dataGrid.Rows[dataGridViewCellEventArgs.RowIndex].Cells[Table.Author].Value.ToString();
			//int year = (int)dataGrid.Rows[dataGridViewCellEventArgs.RowIndex].Cells[Table.Year].Value;
			//var _1001 = (bool)dataGrid.Rows[dataGridViewCellEventArgs.RowIndex].Cells[Table._1001].Value;

			//addBook2.SetBookData(title, author, year, _1001, goodreadsID);
		}

		private int GetAveragePerYearValue()
		{
			SqlConnection sqlConnection1 = new SqlConnection(Resources.MainConnectionString);
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = @"select
cast(sum([Hours read])/3 as int) Hours
from [View Books]
where Last >= getdate()-(3*365)  -- Last 3 years";

			cmd.Connection = sqlConnection1;

			sqlConnection1.Open();

			using(SqlDataReader reader = cmd.ExecuteReader())
			{
				while(reader.Read())
				{
					return int.Parse(reader["Hours"].ToString());
				}
			}

			sqlConnection1.Close();

			return 0;
		}

		private void SetGridAll(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[]{
			nameof(Book.Title),
			nameof(Book.Author),
			nameof(Book.Year),
			nameof(Book._1001),
			nameof(Book.Type),
			nameof(Book.PriceInRSD)});

			dataGridView.Columns[nameof(Book._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(Book._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(Book.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Book.Author)].Width = 130;
			dataGridView.Columns[nameof(Book.Year)].CenterColumn();
			dataGridView.Columns[nameof(Book.Type)].CenterColumn();
			dataGridView.Columns[nameof(Book.PriceInRSD)].HeaderText = "Price";
			dataGridView.Columns[nameof(Book.PriceInRSD)].Width = 50;
		}

		private void SetGridPlanToRead(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[]{
			nameof(Book.Title),
			nameof(Book.Author),
			nameof(Book.Year),
			nameof(Book._1001),
			nameof(Book.EminaRating)});

			dataGridView.Columns[nameof(Book._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(Book._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(Book.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Book.Author)].Width = 130;
			dataGridView.Columns[nameof(Book.EminaRating)].Width = 30;
			dataGridView.Columns[nameof(Book.Year)].CenterColumn();
		}

		private void SetHLTBSum()
		{
			//int hltbTimeSum = 0;

			//for(int i = 0; i < dataGridCustomPlanToRead.Rows.Count; ++i)
			//{
			//	hltbTimeSum += Convert.ToInt32(dataGridCustomPlanToRead.Rows[i].Cells[Table.HLTB].Value);
			//}

			//var averagePerYear = GetAveragePerYearValue();
			//float yearsToCompletion = hltbTimeSum / (float)averagePerYear;

			//labelHLTBtime.Text = $@"HLTB: {hltbTimeSum}h / {hltbTimeSum / 24} days
			//						Average per year: {averagePerYear}h
			//						Years to compeltion: {yearsToCompletion.ToString("0.00")}";
		}

		private void TextBoxTitleTextChanged(object sender, EventArgs e)
		{
			//dataGridCustomAll.RowFilter = $"{Table.Title} LIKE '%{textBoxTitle.Text}%'";
		}
	}
}