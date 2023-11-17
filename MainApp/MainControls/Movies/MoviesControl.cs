using Controller;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Movies
{
	public partial class MoviesControl : UserControl
	{
		internal List<MovieEvent> m_movieEvents;
		private BindingList<Movie> m_bindingList;
		private List<Movie> m_movies;

		public MoviesControl()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			m_movies = Datasource.GetList<Movie>();
			m_movieEvents = Datasource.GetList<MovieEvent>();

			numericUpDownYearWatched.Value = DateTime.Now.Year;

			SetGrid(dataGridMovies);
			dataGridMovies.SelectLastRow();
			addButton1.SetAddButton(ButtonAdd_Click);
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var movie = movieInfo1.GetMovie();

			if (!m_movieEvents.Any(m => m.Imdb == movie.Imdb))
			{
				Datasource.Add(movie);
				m_movies.Add(movie);
			}

			var movieEvent = movieInfo1.GetMovieEvent();

			movieEvent.Date = addButton1.GetDate();		

			Datasource.Add(movieEvent);
			m_movieEvents.Add(movieEvent);
			m_bindingList.Add(movie);

			textBoxImdb.Clear();
			dataGridMovies.SelectLastRow();
		}

		private void DataGridMovies_SelectionChanged(object sender, EventArgs e)
		{
			var movie = (sender as DataGridView).GetRowObject<Movie>();
			movieInfo1.FillData(movie, m_movieEvents.Where(m => m.Imdb == movie?.Imdb).ToList());
		}

		private void NumericUpDownYearWatched_ValueChanged(object sender, EventArgs e)
		{
			var thisYear = m_movieEvents
				.Where(m => m.Date.HasValue && m.Date.Value.Year == numericUpDownYearWatched.Value)
				.OrderBy(o => o.Date).ToList();

			var bind = new List<Movie>();

			foreach (var me in thisYear)
			{
				var m = m_movies.FirstOrDefault(o => o.Imdb == me.Imdb);
				bind.Add(m);
			}

			m_bindingList = new BindingList<Movie>(bind);

			dataGridMovies.DataSource = new BindingSource(m_bindingList, null);
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[] {
			nameof(Movie.Title),
			nameof(Movie.Director),
			nameof(Movie.Year)});

			dataGridView.Columns[nameof(Movie.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Movie.Director)].Width = 130;
			dataGridView.Columns[nameof(Movie.Year)].CenterColumn();
		}

		private void TextBoxImdb_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxImdb.Text))
			{
				return;
			}

			textBoxImdb.TextChanged -= TextBoxImdb_TextChanged;

			var movie = Controller.Movies.GetMovie(textBoxImdb.Text);

			if (movie != null)
			{
				textBoxImdb.Text = movie.Imdb;
				movieInfo1.FillData(movie, m_movieEvents.Where(m => m.Imdb == movie.Imdb).ToList());
			}

			textBoxImdb.TextChanged += TextBoxImdb_TextChanged;
		}
	}
}