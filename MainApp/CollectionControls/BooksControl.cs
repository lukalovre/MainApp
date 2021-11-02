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
		private List<Book> m_books;

		public BooksControl()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			m_books = Database.GetList<Book>();

			dataGridViewAll.DataSource = m_books;
			LoadData();

			SetGridAll(dataGridViewAll);
			SetGridPlanToRead(dataGridViewPlanToRead);
			SetGridPlanToRead(dataGridViewShort);

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
			Database.Add(book);

			m_books = Database.GetList<Book>();
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

			if (book == null)
			{
				return;
			}

			bookInfo1.Fill(book);
		}

		//private int GetAveragePerYearValue()
		//{
		//			SqlConnection sqlConnection1 = new SqlConnection(Resources.MainConnectionString);
		//			SqlCommand cmd = new SqlCommand();

		//			cmd.CommandText = @"select
		//cast(sum([Hours read])/3 as int) Hours
		//from [View Books]
		//where Last >= getdate()-(3*365)  -- Last 3 years";

		//			cmd.Connection = sqlConnection1;

		//			sqlConnection1.Open();

		//			using(SqlDataReader reader = cmd.ExecuteReader())
		//			{
		//				while(reader.Read())
		//				{
		//					return int.Parse(reader["Hours"].ToString());
		//				}
		//			}

		//			sqlConnection1.Close();

		//			return 0;
		//}

		private void LoadData()
		{
			var toRead = m_books
				.Where(o => Following.FollowingModel.BooksCollection.Contains(o.GoodreadsID.ToString()))
				.DistinctBy(o => o.GoodreadsID)
				.OrderBy(o => o.Pages)
				.ToList();

			dataGridViewPlanToRead.DataSource = new SortableBindingList<Book>(toRead);

			dataGridViewShort.DataSource = toRead
				.Where(o => o.Pages < 300)
				.ToList();
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
			nameof(Book._1001),
			nameof(Book.EminaRating)});

			dataGridView.Columns[nameof(Book._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(Book._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(Book.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Book.Author)].Width = 130;
			dataGridView.Columns[nameof(Book.EminaRating)].Width = 30;
			dataGridView.Columns[nameof(Book.Year)].CenterColumn();

			SetZeroValuesToEmpty(dataGridView);
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