using Controller;
using Model;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Following = Controller.Following;

namespace MainApp.TV_Shows
{
	public partial class TVShowsControl : UserControl
	{
		internal static TVShowsControl Instance;
		internal List<TVShowEvent> m_tvShowEvents;
		private BindingList<TVShow> m_bindingList;
		private List<TVShow> m_tvShows;

		public TVShowsControl()
		{
			InitializeComponent();

			dataGridViewWatching.CellFormatting += DataGridView1OnCellFormatting;
		}

		private const int MAX_TV_SHOWS_WATCHING = 5;

		private void DataGridView1OnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var playingCount = (dataGridViewWatching.DataSource as SortableBindingList<TVShowWatchingGrid>).Count;

			if (playingCount > MAX_TV_SHOWS_WATCHING)
			{
				dataGridViewWatching.Rows[e.RowIndex].Cells[nameof(TVShowWatchingGrid.Title)].Style.BackColor = e.RowIndex < (playingCount - MAX_TV_SHOWS_WATCHING)
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

			LoadGridData();

			SetGrid(dataGridViewTVShows);
			SetGridWatching(dataGridViewWatching);
			SetGridWatching(dataGridViewOngoing);
			SetGridWatching(dataGridViewYouTube);
			SetGridWatching(dataGridViewWaiting);

			dataGridViewTVShows.SelectLastRow();
		}

		private void CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == -1)
			{
				LoadGridData();
				NumericUpDownYear_ValueChanged(null, null);
			}
		}

		private void LoadGridData()
		{
			m_tvShows = Datasource.GetList<TVShow>();
			m_tvShowEvents = Datasource.GetList<TVShowEvent>();

			numericUpDownYear.Value = DateTime.Now.Year;

			dataGridViewWatching.DataSource =
				new SortableBindingList<TVShowWatchingGrid>(m_tvShows
				.Where(o => Following.FollowingModel.TVShows.Contains(o.Imdb))
				.Select(o => Convert(o))
				.OrderByDescending(o => o.DaysAgo).ToList());

			dataGridViewOngoing.DataSource =
				new SortableBindingList<TVShowWatchingGrid>(m_tvShows
				.Where(o => Following.FollowingModel.TVShowsOngoing.Contains(o.Imdb))
				.Select(o => Convert(o))
				.OrderByDescending(o => o.DaysAgo).ToList());

			dataGridViewYouTube.DataSource =
				new SortableBindingList<TVShowWatchingGrid>(m_tvShows
				.Where(o => Following.FollowingModel.YouTube.Contains(o.Imdb))
				.Select(o => Convert(o))
				.OrderByDescending(o => o.DaysAgo).ToList());

			dataGridViewWaiting.DataSource =
				new SortableBindingList<TVShowWatchingGrid>(m_tvShows
				.Where(o => Following.FollowingModel.TVShowsWaiting.Contains(o.Imdb))
				.Select(o => Convert(o))
				.OrderByDescending(o => o.DaysAgo).ToList());
		}

		private TVShowWatchingGrid Convert(TVShow item)
		{
			var events = m_tvShowEvents.Where(o => o.Imdb == item.Imdb);

			var lastDate = events.Any()
				? events.Max(o => o.Date).Value
				: DateTime.Now;

			return new TVShowWatchingGrid
			{
				Imdb = item.Imdb,
				Title = item.Title,
				Writer = item.Writer,
				Year = item.Year,
				Time = Helper.GetFormatedTime(events.Sum(o => o.Runtime)),
				DaysAgo = (int)(DateTime.Now - lastDate).TotalDays
			};
		}

		private void ButtonUpdate_Click(object sender, EventArgs e)
		{
			var tvShow = tvShowInfo1.GetTVShow();
			var tvShowEvent = tvShowInfo1.GetEvent();

			var events = m_tvShowEvents.Where(i => i.Imdb == tvShow.Imdb);

			if (!events.Any())
			{
				Datasource.Add(tvShow);
				m_tvShows.Add(tvShow);
			}

			if (checkBoxUpdateSeason.Checked)
			{
				tvShowEvent.Season++;
			}

			Datasource.Add(tvShowEvent);
			m_tvShowEvents.Add(tvShowEvent);
			m_bindingList.Add(tvShow);

			checkBoxUpdateSeason.Checked = false;
			tvShowInfo1.FillData(tvShow, m_tvShowEvents.Where(i => i.Imdb == tvShow.Imdb).ToList());

			dataGridViewTVShows.SelectLastRow();
			textBoxImdb.Clear();
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var imdbItem = (sender as DataGridView).GetRowObject<IImdb>();

			if (imdbItem == null)
			{
				return;
			}

			tvShowInfo1.FillData(m_tvShows.FirstOrDefault(i => i.Imdb == imdbItem.Imdb), m_tvShowEvents.Where(i => i.Imdb == imdbItem.Imdb).ToList());
		}

		private void NumericUpDownYear_ValueChanged(object sender, EventArgs e)
		{
			var thisYear = m_tvShowEvents.Where(m => m.Date.HasValue && m.Date.Value.Year == numericUpDownYear.Value).ToList();

			var bind = new List<TVShow>();

			foreach (var me in thisYear)
			{
				var m = m_tvShows.FirstOrDefault(o => o.Imdb == me.Imdb);
				bind.Add(m);
			}

			m_bindingList = new BindingList<TVShow>(bind.Distinct().ToList());

			dataGridViewTVShows.DataSource = new BindingSource(m_bindingList, null);
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[] {
			nameof(TVShow.Title),
			nameof(TVShow.Writer),
			nameof(TVShow.Year)});

			dataGridView.Columns[nameof(TVShow.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(TVShow.Writer)].Width = 130;
			dataGridView.Columns[nameof(TVShow.Year)].CenterColumn();
			dataGridView.CellClick -= CellClick;
			dataGridView.CellClick += CellClick;
		}

		private void SetGridWatching(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.Columns[nameof(TVShowWatchingGrid.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(TVShowWatchingGrid.Writer)].Width = 130;
			dataGridView.Columns[nameof(TVShowWatchingGrid.Year)].CenterColumn();
			dataGridView.Columns[nameof(TVShowWatchingGrid.DaysAgo)].CenterColumn();
			dataGridView.Columns[nameof(TVShowWatchingGrid.Time)].CenterColumn();
			dataGridView.Columns[nameof(TVShowWatchingGrid.Imdb)].Visible = false;
			dataGridView.CellClick -= CellClick;
			dataGridView.CellClick += CellClick;
		}

		private void TextBoxImdb_TextChanged(object sender, EventArgs e)
		{
			var text = (sender as TextBox).Text;

			var tvShow = Controller.TVShows.GetTVShow(text);

			tvShowInfo1.FillData(tvShow, null);
		}
	}
}