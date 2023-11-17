using Controller;
using Controller.Extensions;
using Model;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MainApp
{
	public partial class IgdbListControl : UserControl
	{
		private SortableBindingList<Game1001> m_dataSource;
		private IEnumerable<int> m_filter;
		private string m_listName;
		private bool m_mergeFolder;

		public IgdbListControl()
		{
			InitializeComponent();
		}

		public static IgdbListControl Init(string listName, IEnumerable<int> filter, bool mergeFolder = false)
		{
			return new IgdbListControl
			{
				m_listName = listName,
				m_filter = filter,
				m_mergeFolder = mergeFolder
			};
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			if (m_mergeFolder)
			{
				var imdbFromListMerged = GetGamesFromCsvMerged(m_listName);

				dataGridView.DataSource = new SortableBindingList<GameGOTY>(
				   imdbFromListMerged
				   .Where(o => !m_filter.Contains(o.Igdb))
				   .ToList());

				SetGridIgdbListGOTY(dataGridView);

				return;
			}

			LoadGridData();
			SetGrid(dataGridView);
		}

		private void CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == -1)
			{
				LoadGridData();
			}
		}

		private void LoadGridData()
		{
			var imdbFromList = GetGamesFromCsv(m_listName);

			dataGridView.DataSource = m_dataSource = new SortableBindingList<Game1001>(
				imdbFromList
				.Where(o => !m_filter.Contains(o.Igdb))
				.ToList());
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();
			dataGridView.Location = new System.Drawing.Point(0, 35);
			dataGridView.Height = 580;

			dataGridView.SetColumns(new string[] {
			nameof(Game1001.Title),
			nameof(Game1001.Year),
			nameof(Game1001._1001),
			nameof(Game1001.Owned)});

			dataGridView.Columns[nameof(Game1001._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(Game1001._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(GameGOTY.Owned)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(Game1001.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Game1001.Year)].CenterColumn();

			dataGridView.CellClick -= CellClick;
			dataGridView.CellClick += CellClick;
			dataGridView.DoubleClick -= new EventHandler(DataGridView_DoubleClick);
			dataGridView.DoubleClick += new EventHandler(DataGridView_DoubleClick);
		}

		private void DataGridView_DoubleClick(object sender, EventArgs e)
		{
			var listItem = dataGridView.GetRowObject<Game1001>();
			Igdb.OpenLink(listItem);
		}

		private void ButtonOpenList_Click(object sender, EventArgs e)
		{
			var listLink = $"https://www.igdb.com/users/lukalovre/lists/{m_listName}";
			Web.OpenLink(listLink);
		}

		private SortableBindingList<Game1001> GetGamesFromCsv(string listName)
		{
			return new SortableBindingList<Game1001>(
				CsvHelper.GetFromList<IgdbListItem>(Paths.Igdb, listName, out _)
				.Where(o => !Datasource.GetList<Game>().Any(g => g.Igdb == o.id) && !Igdb.AlternativeVersions.Keys.Contains(o.id))
				.Select(o => Igdb.ConvertToGame1001(o))
				.ToList());
		}

		private SortableBindingList<GameGOTY> GetGamesFromCsvMerged(string listsFolder)
		{
			return new SortableBindingList<GameGOTY>(
				Igdb.GetFromListsMerged(listsFolder)
				.Select(o => Igdb.ConvertToGameGOTY(Igdb.ConvertToGame1001(o)))
				.ToList());
		}

		private void SetGridIgdbListGOTY(DataGridView dataGridView)
		{
			dataGridView.SetGrid();
			dataGridView.Location = new System.Drawing.Point(0, 35);
			dataGridView.Height = 580;

			dataGridView.SetColumns(new string[] {
			nameof(GameGOTY.Title),
			nameof(GameGOTY.Year),
			nameof(GameGOTY._1001),
			nameof(GameGOTY.GOTY),
			nameof(GameGOTY.Owned)});

			dataGridView.Columns[nameof(GameGOTY._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(GameGOTY._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(GameGOTY.Owned)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(GameGOTY.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(GameGOTY.Year)].CenterColumn();
			dataGridView.Columns[nameof(GameGOTY.GOTY)].CenterColumn();
		}

		private void TextBoxFilter_TextChanged(object sender, EventArgs e)
		{
			var filter = (sender as TextBox).Text;

			dataGridView.DataSource = new SortableBindingList<Game1001>(m_dataSource.Where(o => o.Igdb.ToString() == filter
										  || o.Title.Contains(filter, StringComparison.OrdinalIgnoreCase)
										  || o.Year.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList());
		}
	}
}