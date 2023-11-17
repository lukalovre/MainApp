using Controller;
using Model;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Movies
{
	public partial class MovieInfoControl : UserControl
	{
		private Movie m_movie;

		public MovieInfoControl()
		{
			InitializeComponent();
		}

		internal void FillData(Movie movie, List<MovieEvent> movieEventList)
		{
			if (movie == null)
			{
				return;
			}

			m_movie = movie;

			labelTitle.Text = movie.Title;
			labelYear.Text = movie.Year.ToString();
			labelDirector.Text = movie.Director;
			labelWriters.Text = movie.Writer.Replace(", ", ",").Replace(',', '\n');
			labelStars.Text = movie.Actors.Replace(", ", ",").Replace(',', '\n');
			richTextBoxPlot.Text = movie.Plot;

			labelRuntime.Text = TimeHelper.GetFormatedTime(movie.Runtime);
			SetPoster(movie);

			if (!movieEventList.Any())
			{
				labelWatchedTimes.Text = $"First time watching";
				comboBoxPlatform.Text = string.Empty;
				evenControl1.Clear();
				return;
			}

			var lastEvent = movieEventList.LastOrDefault();

			labelWatchedTimes.Text = $"Watched {movieEventList.Count} times";
			comboBoxPlatform.Text = lastEvent.Platform;

			var eventItemList = movieEventList.Select(o =>
			new EventListItem
			{
				ID = o.ID,
				Date = o.Date,
				CountValue = 1
			}).ToList();

			evenControl1.Fill(lastEvent, eventItemList);
		}

		internal Movie GetMovie()
		{
			return m_movie;
		}

		internal MovieEvent GetMovieEvent()
		{
			return new MovieEvent
			{
				Imdb = m_movie.Imdb,
				Rating = evenControl1.Rating,
				People = evenControl1.GetPeople(),
				Platform = string.IsNullOrWhiteSpace(comboBoxPlatform.Text) ? null : comboBoxPlatform.Text,
				Comment = evenControl1.GetComment()
			};
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			comboBoxPlatform.Items.AddRange(Datasource.GetList<MovieEvent>().Where(o => o.Platform != null).Select(o => o.Platform).Distinct().ToArray());
		}

		private void ButtonGoToImdb_Click(object sender, EventArgs e)
		{
			Imdb.OpenLink(m_movie);
		}

		private void SetPoster(Movie movie)
		{
			var filePath = Path.Combine(Paths.Posters, $"{movie.Imdb}.png");

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