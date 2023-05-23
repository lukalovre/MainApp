using Controller;
using Model.dbo;
using Model.Grid;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Comics
{
	public partial class ComicsControl : UserControl
	{
		internal static ComicsControl Instance;
		private SortableBindingList<ComicsGrid> m_bindingList;
		private List<ComicEvent> m_comicEvents;
		private List<Comic> m_comics;

		public ComicsControl()
		{
			InitializeComponent();

			dataGridViewReading.CellFormatting += DataGridView1OnCellFormatting;
		}

		private const int MAX_COMICS_READING = 5;

		private void DataGridView1OnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var playingCount = (dataGridViewReading.DataSource as SortableBindingList<ComicsGridReading>).Count;

			if (playingCount > MAX_COMICS_READING)
			{
				dataGridViewReading.Rows[e.RowIndex].Cells[nameof(ComicsGridReading.Title)].Style.BackColor = e.RowIndex < (playingCount - MAX_COMICS_READING)
					? Color.Red
					: Color.Empty;
			}
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			Instance = this;

			m_comics = Datasource.GetList<Comic>();
			m_comicEvents = Datasource.GetList<ComicEvent>();

			numericUpDownYear.Value = DateTime.Now.Year;

			LoadGridDataReading();
			LoadGridDataOngoing();

			SetGrid(dataGridViewAll);
			SetGrid(dataGridViewReading);
			SetGrid(dataGridViewOngoing);

			SetGridReading(dataGridViewReading);
			SetGridReading(dataGridViewOngoing);

			dataGridViewAll.SelectLastRow();
		}

		private void CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == -1)
			{
				m_comics = Datasource.GetList<Comic>();
				m_comicEvents = Datasource.GetList<ComicEvent>();

				if (dataGridViewReading == (sender as DataGridView))
				{
					LoadGridDataReading();
				}

				if (dataGridViewOngoing == (sender as DataGridView))
				{
					LoadGridDataOngoing();
				}

				if (dataGridViewAll == (sender as DataGridView))
				{
					LoadGridDataAll();
				}
			}
		}

		private ComicsGrid Convert(Comic comic)
		{
			var events = m_comicEvents.Where(o => o.GoodreadsID == comic.GoodreadsID);

			var lastDate = events.Any()
				? events.Max(o => o.Date).Value
				: DateTime.Now;

			return new ComicsGrid
			{
				GoodreadsID = comic.GoodreadsID,
				Title = comic.Title,
				Writer = comic.Writer,
				Year = comic.Year,
				_1001 = comic._1001,
				LastReadDate = lastDate
			};
		}

		private ComicsGridReading ConvertReading(Comic comic)
		{
			var events = m_comicEvents.Where(o => o.GoodreadsID == comic.GoodreadsID);
			var lastDate = events?.Max(o => o.Date).Value ?? DateTime.Now;
			var daysAgo = (int)(DateTime.Now - lastDate).TotalDays;
			var timeMinutes = events.Sum(o => o.Pages) * 0.3f;

			return new ComicsGridReading
			{
				GoodreadsID = comic.GoodreadsID,
				Title = comic.Title,
				Writer = comic.Writer,
				Year = comic.Year,
				_1001 = comic._1001,
				LastReadDate = lastDate,
				DaysAgo = daysAgo,
				Time = Helper.GetFormatedTime((int)timeMinutes)
			};
		}

		private void LoadGridDataReading()
		{
			dataGridViewReading.DataSource = new SortableBindingList<ComicsGridReading>(
				m_comics
				.Where(o => Following.FollowingModel.Comics.Contains(o.GoodreadsID.ToString()))
				.Select(o => ConvertReading(o))
				.OrderBy(o => o.LastReadDate)
				.ToList());
		}

		private void LoadGridDataOngoing()
		{
			dataGridViewOngoing.DataSource = new SortableBindingList<ComicsGridReading>(
				m_comics
				.Where(o => Following.FollowingModel.ComicsOngoing.Contains(o.GoodreadsID.ToString()))
				.Select(o => ConvertReading(o))
				.OrderBy(o => o.LastReadDate)
				.ToList());
		}

		private void LoadGridDataAll()
		{
			var thisYear = m_comicEvents.Where(m => m.Date.HasValue && m.Date.Value.Year == numericUpDownYear.Value).ToList();

			var bind = new List<Comic>();

			foreach (var me in thisYear)
			{
				var m = m_comics.FirstOrDefault(o => o.GoodreadsID == me.GoodreadsID);
				bind.Add(m);
			}

			m_bindingList = new SortableBindingList<ComicsGrid>(bind.Distinct().Select(o => Convert(o)).ToList());

			dataGridViewAll.DataSource = new BindingSource(m_bindingList, null);
		}

		private void ButtonUpdate_Click(object sender, EventArgs e)
		{
			var comic = comicInfo1.GetItem();

			if (!m_comics.Any(o => o.GoodreadsID == comic.GoodreadsID))
			{
				Datasource.Add(comic);
				m_comics.Add(comic);

				dataGridViewAll.SelectionChanged -= DataGridView_SelectionChanged;
				m_bindingList.Add(Convert(comic));
				dataGridViewAll.SelectionChanged += DataGridView_SelectionChanged;
			}

			var comicEvent = comicInfo1.GetEvent();
			comicEvent.Date = DateTime.Now;

			Datasource.Add(comicEvent);
			m_comicEvents.Add(comicEvent);

			comicInfo1.Fill(comic, m_comicEvents.Where(o => o.GoodreadsID == comic.GoodreadsID).ToList());
			dataGridViewAll.SelectLastRow();
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var comic = (sender as DataGridView).GetRowObject<ComicsGrid>();

			if (comic == null)
			{
				return;
			}

			comicInfo1.Fill(m_comics.FirstOrDefault(o => o.GoodreadsID == comic.GoodreadsID), m_comicEvents.Where(o => o.GoodreadsID == comic.GoodreadsID).ToList());
		}

		private void NumericUpDownYear_ValueChanged(object sender, EventArgs e)
		{
			LoadGridDataAll();
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.CellClick -= CellClick;
			dataGridView.CellClick += CellClick;

			dataGridView.Columns[nameof(ComicsGrid._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(ComicsGrid._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(ComicsGrid.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(ComicsGrid.Writer)].Width = 130;
			dataGridView.Columns[nameof(ComicsGrid.Year)].CenterColumn();
			dataGridView.Columns[nameof(ComicsGrid.GoodreadsID)].Visible = false;
			dataGridView.Columns[nameof(ComicsGrid.LastReadDate)].Visible = false;
		}

		private void SetGridReading(DataGridView dataGridView)
		{
			dataGridView.Columns[nameof(ComicsGridReading.DaysAgo)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
			dataGridView.Columns[nameof(ComicsGridReading.DaysAgo)].Width = 40;
			dataGridView.Columns[nameof(ComicsGridReading.Time)].CenterColumn();
		}

		private void TextBoxUrl_TextChanged(object sender, EventArgs e)
		{
			var url = textBoxUrl.Text;

			var comic = Links.GetGoodreadsDataComic(url);

			comicInfo1.Fill(comic);

			textBoxUrl.TextChanged -= new EventHandler(TextBoxUrl_TextChanged);
			textBoxUrl.Clear();
			textBoxUrl.TextChanged += new EventHandler(TextBoxUrl_TextChanged);
		}
	}
}