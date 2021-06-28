using Controller;
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
			if(movie == null)
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

			var span = TimeSpan.FromMinutes(movie.Runtime);
			labelRuntime.Text = $"{span.Hours}h {span.Minutes}min";

			labelWatchedTimes.Text = $"Watched {movieEventList.Count} times";

			starRatingControl1.SelectedStar = movieEventList.LastOrDefault() == null ? 0 : movieEventList.LastOrDefault().Rating.Value;

			checkBoxEminaWatched.Checked = movieEventList.Any(m => m.EminaWatched);
			checkBoxWatchedInCinema.Checked = movieEventList.Any(m => m.WatchedInCinema);

			SetPoster(movie);
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
				WatchedInCinema = checkBoxWatchedInCinema.Checked,
				EminaWatched = checkBoxEminaWatched.Checked,
				Rating = starRatingControl1.SelectedStar
			};
		}

		private void ButtonGoToImdb_Click(object sender, EventArgs e)
		{
			Imdb.OpenLink(m_movie);
		}

		private void SetPoster(Movie movie)
		{
			var filePath = Path.Combine(Paths.Posters, $"{movie.Imdb}.png");

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