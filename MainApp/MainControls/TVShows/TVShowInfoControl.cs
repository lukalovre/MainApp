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
		private string m_oldComment;

		public TVShowInfo()
		{
			InitializeComponent();
			eventControl1.DefaultInterval = EventControl.Interval.Years;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
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
				richTextBoxComment.Text = string.Empty;
				eventControl1.Clear();
				return;
			}

			var events = m_tvShowEvents.Select(o => new Model.EventListItem
			{
				ID = o.ID,
				Time = o.Runtime,
				Date = o.Date
			}).ToList();

			eventControl1.FIll(events);

			var lastTVShow = m_tvShowEvents.LastOrDefault();

			richTextBoxComment.Text = lastTVShow.Comment;
			m_oldComment = lastTVShow.Comment ?? string.Empty;

			starRatingControl1.SelectedStar = lastTVShow.Rating.Value;

			var seasons = m_tvShowEvents.DistinctBy(o => o.Season).OrderBy(o => o.Season);
			listBoxSeasons.Items.Clear();

			foreach (var season in seasons)
			{
				listBoxSeasons.Items.Add($"Season {season.Season}: {m_tvShowEvents.Count(o => o.Season == season.Season)}\n");
			}

			listBoxSeasons.SelectedIndex = listBoxSeasons.Items.Count - 1;

			var people = Datasource.GetList<Person>();
			var lastPeople = lastTVShow.People;

			if (lastPeople != null)
			{
				var peopleList = CsvHelper.Get(lastPeople).Select(o => people.FirstOrDefault(p => p.ID == int.Parse(o)).ID);

				peopleListControl1.SelectPeople(peopleList);
			}
			else
			{
				peopleListControl1.SelectPeople(null);
			}
		}

		internal TVShowEvent GetEvent()
		{
			var maxSeason = m_tvShowEvents?.Any() != null
			? m_tvShowEvents.Max(i => i.Season)
			: 1;

			var comment = m_oldComment.Trim() == richTextBoxComment.Text.Trim()
				? null
				: richTextBoxComment.Text;
			comment = string.IsNullOrWhiteSpace(comment) ? null : comment;

			return new TVShowEvent
			{
				Date = DateTime.Now,
				Imdb = m_tvShow.Imdb,
				Rating = starRatingControl1.SelectedStar,
				Season = maxSeason,
				Runtime = (int)numericUpDownRuntime.Value,
				People = peopleListControl1.GetCheckedCSV(),
				Comment = comment
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