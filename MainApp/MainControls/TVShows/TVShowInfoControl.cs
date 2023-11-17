using Controller;
using Model.dbo;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.TVShows
{
	public partial class TVShowInfo : UserControl
	{
		private TVShow m_tvShow;
		private List<TVShowEvent> m_tvShowEvents;

		public TVShowInfo()
		{
			InitializeComponent();
			evenControl1.SetEventListDefaultInterval(EventListControl.Interval.Years);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}
		}

		internal void FillData(TVShow tvShow, List<TVShowEvent> tvShowEvents)
		{
			m_tvShow = tvShow;
			m_tvShowEvents = tvShowEvents;

			labelTitle.Text = tvShow.Title;
			labelYear.Text = tvShow.Year.ToString();
			labelDirector.Text = tvShow.Director;
			labelWriters.Text = tvShow.Writer?.Replace(", ", ",").Replace(',', '\n');
			labelStars.Text = tvShow.Actors?.Replace(", ", ",").Replace(',', '\n');
			richTextBoxPlot.Text = tvShow.Plot;
			numericUpDownRuntime.Value = tvShow.Runtime;
			checkBoxWatching.Checked = Following.FollowingModel.TVShows.Contains(tvShow.Imdb);
			checkBoxOngoing.Checked = Following.FollowingModel.TVShowsOngoing.Contains(tvShow.Imdb);
			checkBoxYouTube.Checked = Following.FollowingModel.YouTube.Contains(tvShow.Imdb);
			checkBoxWaiting.Checked = Following.FollowingModel.TVShowsWaiting.Contains(tvShow.Imdb);

			SetPoster(tvShow);

			if (m_tvShowEvents == null)
			{
				evenControl1.Clear();
				return;
			}

			var events = m_tvShowEvents.Select(o => new Model.EventListItem
			{
				ID = o.ID,
				CountValue = o.Runtime,
				Date = o.Date
			}).ToList();

			var seasons = m_tvShowEvents.DistinctBy(o => o.Season).OrderBy(o => o.Season);
			listBoxSeasons.Items.Clear();

			foreach (var season in seasons)
			{
				listBoxSeasons.Items.Add($"Season {season.Season}: {m_tvShowEvents.Count(o => o.Season == season.Season)}\n");
			}

			listBoxSeasons.SelectedIndex = listBoxSeasons.Items.Count - 1;

			var lastEvent = m_tvShowEvents.LastOrDefault();
			evenControl1.Fill(lastEvent, events);
		}

		internal TVShowEvent GetEvent()
		{
			var maxSeason = m_tvShowEvents?.Any() != null
			? m_tvShowEvents.Max(i => i.Season)
			: 1;

			return new TVShowEvent
			{
				Imdb = m_tvShow.Imdb,
				Rating = evenControl1.Rating,
				Season = maxSeason,
				Runtime = (int)numericUpDownRuntime.Value,
				People = evenControl1.GetPeople(),
				Comment = evenControl1.GetComment()
			};
		}

		internal TVShow GetTVShow()
		{
			return m_tvShow;
		}

		private void CheckBoxOngoing_CheckedChanged(object sender, EventArgs e)
		{
			Following.Update(checkBoxOngoing.Checked, Following.FollowingModel.TVShowsOngoing, m_tvShow.Imdb);
		}

		private void CheckBoxWatching_CheckedChanged(object sender, EventArgs e)
		{
			Following.Update(checkBoxWatching.Checked, Following.FollowingModel.TVShows, m_tvShow.Imdb);
		}

		private void CheckBoxYouTube_CheckedChanged(object sender, EventArgs e)
		{
			Following.Update(checkBoxYouTube.Checked, Following.FollowingModel.YouTube, m_tvShow.Imdb);
		}

		private void CheckBoxWaiting_CheckedChanged(object sender, EventArgs e)
		{
			Following.Update(checkBoxWaiting.Checked, Following.FollowingModel.TVShowsWaiting, m_tvShow.Imdb);
		}

		private void SetPoster(TVShow tvShow)
		{
			var filePath = Path.Combine(Paths.Posters, $"{tvShow.Imdb}.png");

			if (!File.Exists(filePath))
			{
				pictureBoxPoster.Image = null;
				return;
			}

			pictureBoxPoster.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxPoster.Image = Image.FromFile(filePath);
		}
	}
}