using Model;
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
		internal static MoviesControl Instance;

		internal List<MovieEvent> m_movieEvents;
		private List<ImdbListItem> m_1001ToWatch;
		private BindingList<Movie> m_bindingList;
		private List<Movie> m_movies;

		public MoviesControl()
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

			//Controller.Movies1001.Update1001MoviesFromBeginning();

			m_movies = Controller.Database.GetList<Movie>();
			m_movieEvents = Controller.Database.GetList<MovieEvent>();

			numericUpDownYearWatched.Value = DateTime.Now.Year;

			SetGrid();

			dataGridMovies.SelectLastRow();

			m_1001ToWatch = Controller._1001.Get1001Movies().Where(o => !m_movies.Any(m => m.Imdb == o.Const)).ToList();
			dataGridView1001.DataSource = m_1001ToWatch;

			SetGrid1001();
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var movie = movieInfo1.GetMovie();

			if(!m_movieEvents.Any(m => m.Imdb == movie.Imdb))
			{
				Controller.Database.Add(movie);
				m_movies.Add(movie);
				m_bindingList.Add(movie);
			}

			var movieEvent = movieInfo1.GetMovieEvent();
			movieEvent.Date = DateTime.Now;

			Controller.Database.Add(movieEvent);
			m_movieEvents.Add(movieEvent);

			textBoxImdb.Clear();
			dataGridMovies.SelectLastRow();
		}

		private void ButtonOpenLink_Click(object sender, EventArgs e)
		{
			var imdbListItem = dataGridView1001.GetRowObject<ImdbListItem>();

			Controller.Imdb.OpenLink(imdbListItem);
		}

		private void DataGridMovies_SelectionChanged(object sender, EventArgs e)
		{
			var movie = (sender as DataGridView).GetRowObject<Movie>();
			movieInfo1.FillData(movie, m_movieEvents.Where(m => m.Imdb == movie?.Imdb).ToList());
		}

		private void NumericUpDownYearWatched_ValueChanged(object sender, EventArgs e)
		{
			var thisYear = m_movieEvents.Where(m => m.Date.HasValue && m.Date.Value.Year == numericUpDownYearWatched.Value).ToList();

			var bind = new List<Movie>();

			foreach(var me in thisYear)
			{
				var m = m_movies.FirstOrDefault(o => o.Imdb == me.Imdb);
				bind.Add(m);
			}

			m_bindingList = new BindingList<Movie>(bind);

			dataGridMovies.DataSource = new BindingSource(m_bindingList, null);
		}

		private void SetGrid()
		{
			dataGridMovies.SetGrid();

			dataGridMovies.SetColumns(new string[] {
			nameof(Movie.Title),
			nameof(Movie.Director),
			nameof(Movie.Year),
			nameof(Movie._1001)});

			dataGridMovies.Columns[nameof(Movie._1001)].HeaderText = "1001";
			dataGridMovies.Columns[nameof(Movie._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridMovies.Columns[nameof(Movie.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridMovies.Columns[nameof(Movie.Director)].Width = 130;
			dataGridMovies.Columns[nameof(Movie.Year)].CenterColumn();
		}

		private void SetGrid1001()
		{
			dataGridView1001.SetGrid();

			dataGridView1001.SetColumns(new string[] {
			nameof(ImdbListItem.Title),
			nameof(ImdbListItem.Directors),
			nameof(ImdbListItem.Year)});

			dataGridView1001.Columns[nameof(ImdbListItem.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1001.Columns[nameof(ImdbListItem.Directors)].Width = 130;
			dataGridView1001.Columns[nameof(ImdbListItem.Year)].CenterColumn();
		}

		private void TextBoxFilter_TextChanged(object sender, EventArgs e)
		{
			var filter = textBoxFilter.Text;

			dataGridView1001.DataSource = m_1001ToWatch.Where(o => o.Const == filter
										  || o.Directors.Contains(filter, StringComparison.OrdinalIgnoreCase)
										  || o.Title.Contains(filter, StringComparison.OrdinalIgnoreCase)
										  || o.Year.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList();
		}

		private void TextBoxImdb_TextChanged(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBoxImdb.Text))
			{
				return;
			}

			textBoxImdb.TextChanged -= TextBoxImdb_TextChanged;

			var movie = Controller.Movies.GetMovie(textBoxImdb.Text);

			if(movie != null)
			{
				textBoxImdb.Text = movie.Imdb;
				movieInfo1.FillData(movie, m_movieEvents.Where(m => m.Imdb == movie.Imdb).ToList());
			}

			textBoxImdb.TextChanged += TextBoxImdb_TextChanged;
		}
	}
}