using Model.dbo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

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
			Instance = this;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if(DesignMode)
			{
				return;
			}

			m_tvShows = Controller.Database.GetList<TVShow>();
			m_tvShowEvents = Controller.Database.GetList<TVShowEvent>();

			numericUpDownYear.Value = DateTime.Now.Year;

			dataGridViewWatching.DataSource =
				new BindingSource(m_tvShows.Where(o => FormMain.Following.TVShows.Contains(o.Imdb)), null);

			dataGridViewOngoing.DataSource =
				new BindingSource(m_tvShows.Where(o => FormMain.Following.TVShowsOngoing.Contains(o.Imdb)), null);

			SetGrid(dataGridViewTVShows);
			SetGrid(dataGridViewWatching);
			SetGrid(dataGridViewOngoing);

			dataGridViewTVShows.SelectLastRow();
			dataGridViewWatching.SelectLastRow();
			dataGridViewOngoing.SelectLastRow();
		}

		private void ButtonUpdate_Click(object sender, EventArgs e)
		{
			var tvShow = tvShowInfo1.GetTVShow();

			var events = m_tvShowEvents.Where(i => i.Imdb == tvShow.Imdb);

			if(!events.Any())
			{
				Controller.Database.Add(tvShow);
			}

			var maxSeason = events.Any()
				? events.Max(i => i.Season)
				: 1;

			var season = checkBoxUpdateSeason.Checked
				? maxSeason + 1
				: maxSeason;

			var tvShowEvent = new TVShowEvent
			{
				Date = DateTime.Now,
				Episodes = 1,
				Imdb = tvShow.Imdb,
				Rating = tvShowInfo1.GetStarRating(),
				Season = season
			};

			Controller.Database.Add(tvShowEvent);
			m_tvShowEvents.Add(tvShowEvent);

			checkBoxUpdateSeason.Checked = false;
			tvShowInfo1.FillData(tvShow, m_tvShowEvents.Where(i => i.Imdb == tvShow.Imdb).ToList());
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var tvShow = (sender as DataGridView).GetRowObject<TVShow>();

			if(tvShow == null)
			{
				return;
			}

			tvShowInfo1.FillData(tvShow, m_tvShowEvents.Where(i => i.Imdb == tvShow.Imdb).ToList());
		}

		private void NumericUpDownYear_ValueChanged(object sender, EventArgs e)
		{
			var thisYear = m_tvShowEvents.Where(m => m.Date.HasValue && m.Date.Value.Year == numericUpDownYear.Value).ToList();

			var bind = new List<TVShow>();

			foreach(var me in thisYear)
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
			nameof(TVShow.Year),
			nameof(TVShow._1001)});

			dataGridView.Columns[nameof(TVShow._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(TVShow._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(TVShow.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(TVShow.Writer)].Width = 130;
			dataGridView.Columns[nameof(TVShow.Year)].CenterColumn();
		}

		private void TextBoxImdb_TextChanged(object sender, EventArgs e)
		{
			var text = (sender as TextBox).Text;

			var tvShow = Controller.TVShows.GetTVShow(text);

			tvShowInfo1.FillData(tvShow, null);
		}
	}
}