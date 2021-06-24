﻿using Controller;
using Model.dbo;
using MoreLinq;
using Newtonsoft.Json;
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

		public TVShowInfo()
		{
			InitializeComponent();
		}

		internal void FillData(TVShow tvShow, List<TVShowEvent> tvShowEvents)
		{
			m_tvShow = tvShow;

			labelTitle.Text = tvShow.Title;
			labelYear.Text = tvShow.Year.ToString();
			labelDirector.Text = tvShow.Director;
			labelWriters.Text = tvShow.Writer?.Replace(", ", ",").Replace(',', '\n');
			labelStars.Text = tvShow.Actors?.Replace(", ", ",").Replace(',', '\n');
			richTextBoxPlot.Text = tvShow.Plot;

			var span = TimeSpan.FromMinutes(tvShow.Runtime);
			labelRuntime.Text = $"{span.Hours}h {span.Minutes}min";

			checkBoxWatching.Checked = FormMain.Following.TVShows.Contains(tvShow.Imdb);
			checkBoxOngoing.Checked = FormMain.Following.TVShowsOngoing.Contains(tvShow.Imdb);

			SetPoster(tvShow);

			if(tvShowEvents == null)
			{
				return;
			}

			starRatingControl1.SelectedStar = tvShowEvents.LastOrDefault().Rating.Value;
			var seasons = tvShowEvents.DistinctBy(o => o.Season).OrderBy(o => o.Season);
			listBoxSeasons.Items.Clear();

			foreach(var season in seasons)
			{
				listBoxSeasons.Items.Add($"Season {season.Season}: {tvShowEvents.Where(o => o.Season == season.Season).Sum(i => i.Episodes)}\n");
			}

			listBoxSeasons.SelectedIndex = listBoxSeasons.Items.Count - 1;
		}

		internal int GetStarRating()
		{
			return starRatingControl1.SelectedStar;
		}

		internal TVShow GetTVShow()
		{
			return m_tvShow;
		}

		private void checkBoxOngoing_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxOngoing.Checked)
			{
				if(!FormMain.Following.TVShowsOngoing.Contains(m_tvShow.Imdb))
				{
					FormMain.Following.TVShowsOngoing.Add(m_tvShow.Imdb);
				}
			}
			else
			{
				FormMain.Following.TVShowsOngoing.Remove(m_tvShow.Imdb);
			}

			string json = JsonConvert.SerializeObject(FormMain.Following, Formatting.Indented);
			File.WriteAllText(Paths.Following, json);
		}

		private void CheckBoxWatching_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxWatching.Checked)
			{
				if(!FormMain.Following.TVShows.Contains(m_tvShow.Imdb))
				{
					FormMain.Following.TVShows.Add(m_tvShow.Imdb);
				}
			}
			else
			{
				FormMain.Following.TVShows.Remove(m_tvShow.Imdb);
			}

			string json = JsonConvert.SerializeObject(FormMain.Following, Formatting.Indented);
			File.WriteAllText(Paths.Following, json);
		}

		private void SetPoster(TVShow tvShow)
		{
			var filePath = Path.Combine(Paths.Posters, $"{tvShow.Imdb}.png");

			if(!File.Exists(filePath))
			{
				pictureBoxPoster.Image = null;
				return;
			}

			pictureBoxPoster.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxPoster.Image = Image.FromFile(filePath);
		}
	}
}