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
		private string m_oldComment;

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

			labelRuntime.Text = Helper.GetFormatedTime(movie.Runtime);

			if (!movieEventList.Any())
			{
				labelWatchedTimes.Text = $"First time watching";
				starRatingControl1.SelectedStar = 0;
				comboBoxPlatform.Text = string.Empty;
				richTextBoxComment.Text = string.Empty;
			}
			else
			{
				var lastMovie = movieEventList.LastOrDefault();

				labelWatchedTimes.Text = $"Watched {movieEventList.Count} times";
				starRatingControl1.SelectedStar = lastMovie.Rating.Value;
				comboBoxPlatform.Text = lastMovie.Platform;
				richTextBoxComment.Text = lastMovie.Comment;
				m_oldComment = lastMovie.Comment ?? string.Empty;
			}

			var people = Datasource.GetList<Person>();
			var lastPeople = movieEventList.LastOrDefault()?.People;

			if (lastPeople != null)
			{
				var peopleList = CsvHelper.Get(lastPeople).Select(o => people.FirstOrDefault(p => p.ID == int.Parse(o)).ID);
				peopleListControl1.SelectPeople(peopleList);
			}
			else
			{
				peopleListControl1.SelectPeople(null);
			}

			SetPoster(movie);
		}

		internal Movie GetMovie()
		{
			return m_movie;
		}

		internal MovieEvent GetMovieEvent()
		{
			var comment = m_oldComment.Trim() == richTextBoxComment.Text.Trim()
				? null
				: richTextBoxComment.Text;
			comment = string.IsNullOrWhiteSpace(comment) ? null : comment;

			return new MovieEvent
			{
				Imdb = m_movie.Imdb,
				Rating = starRatingControl1.SelectedStar,
				People = peopleListControl1.GetCheckedCSV(),
				Platform = string.IsNullOrWhiteSpace(comboBoxPlatform.Text) ? null : comboBoxPlatform.Text,
				Comment = comment
			};
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
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