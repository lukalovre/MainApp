using Controller;
using Model.Collection;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Collection
{
	public partial class LibraryControl : UserControl
	{
		private SortableBindingList<LibraryGrid> m_bindingList;
		private List<UniversalItem> m_filterResult;
		private List<Library> m_library;

		public LibraryControl()
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

			m_library = Datasource.GetList<Library>();
			var lent = m_library
				.Where(o => o.ReturnDate == null)
				.OrderBy(o => o.LentDate)
				.ToList();

			m_bindingList = new SortableBindingList<LibraryGrid>(lent.Select(o => new LibraryGrid
			{
				ID = o.ID,
				LentTo = o.LentTo,
				Title = o.Title,
				LentDate = o.LentDate,
				DaysAgo = (int)(DateTime.Now - o.LentDate).TotalDays
			}).ToList());

			dataGridViewAll.DataSource = m_bindingList;

			SetGridAll(dataGridViewAll);
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var item = libraryInfo.GetItem();
			item.LentDate = DateTime.Now;

			Datasource.Add(item);
			m_bindingList.Add(new LibraryGrid
			{
				ID = item.ID,
				LentTo = item.LentTo,
				Title = item.Title,
				LentDate = item.LentDate,
				DaysAgo = 0
			});

			dataGridViewAll.SelectLastRow();
		}

		private void ButtonReturned_Click(object sender, EventArgs e)
		{
			var item = libraryInfo.GetItem();
			item.ReturnDate = DateTime.Now;

			Datasource.Update(item);
			m_bindingList.Remove(m_bindingList.FirstOrDefault(o => o.ID == item.ID));

			dataGridViewAll.SelectLastRow();
		}

		private void DataGridViewAll_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<LibraryGrid>();

			if (item == null)
			{
				return;
			}

			libraryInfo.Fill(m_library.FirstOrDefault(o => o.ID == item.ID));
		}

		private void SetGridAll(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.Columns[nameof(LibraryGrid.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(LibraryGrid.LentTo)].CenterColumn();
			dataGridView.Columns[nameof(LibraryGrid.DaysAgo)].CenterColumn();
			dataGridView.Columns[nameof(LibraryGrid.LentDate)].Visible = false;
		}

		private void TextBoxFilter_TextChanged(object sender, EventArgs e)
		{
			var filterText = textBoxFilter.Text;

			if (filterText.Length > 3)
			{
				if (m_filterResult == null)
				{
					LoadFilterList();
				}

				dataGridViewFilterResult.DataSource = new SortableBindingList<UniversalItem>(
					m_filterResult.Where(o => (o.Title != null && o.Title.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
											|| (o.Author != null && o.Author.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
											|| (o.Year.HasValue && o.Year.ToString().IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)).ToList());

				dataGridViewFilterResult.SetGrid(setLocation: false);
				dataGridViewFilterResult.Columns[nameof(UniversalItem.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dataGridViewFilterResult.Columns[nameof(UniversalItem.Year)].CenterColumn();
				dataGridViewFilterResult.Columns[nameof(UniversalItem.Type)].Visible = false;
			}
		}

		private void LoadFilterList()
		{
			m_filterResult = new List<UniversalItem>();

			foreach (var book in Datasource.GetList<Book>())
			{
				m_filterResult.Add(new UniversalItem
				{
					ID = book.ID,
					Title = book.Title,
					Author = book.Author,
					Year = book.Year,
					Type = nameof(Book)
				});
			}

			foreach (var comic in Datasource.GetList<Comic>())
			{
				m_filterResult.Add(new UniversalItem
				{
					ID = comic.ID,
					Title = $"{comic.Title} {comic.Chapter}",
					Author = comic.Writer,
					Year = null,
					Type = nameof(Comic)
				});
			}

			foreach (var game in Datasource.GetList<Game>())
			{
				m_filterResult.Add(new UniversalItem
				{
					ID = game.ID,
					Title = game.Title,
					Author = null,
					Year = game.Year,
					Type = nameof(Game)
				});
			}
		}

		private void DataGridViewFilterResult_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<UniversalItem>();

			if (item == null)
			{
				return;
			}

			var libraryItem = new Library
			{
				ItemID = item.ID,
				Title = item.Title,
				Type = item.Type
			};

			libraryInfo.Fill(libraryItem);
		}

		private void DataGridViewAll_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dataGridViewAll.Columns[nameof(LibraryGrid.DaysAgo)].Index)
			{
				//column name
				DataGridViewCell cell = dataGridViewAll.Rows[e.RowIndex].Cells[e.ColumnIndex];

				//column id
				DataGridViewCell cell1 = dataGridViewAll.Rows[e.RowIndex].Cells[nameof(LibraryGrid.LentDate)];

				cell.ToolTipText = ((DateTime)cell1.Value).ToString("MM-dd-yyyy");
			}
		}
	}
}