using Controller;
using Model.Collection;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.CollectionControls
{
	public partial class MoviesControl : UserControl
	{
		private SortableBindingList<MovieCollection> m_bindable;
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
			m_bindable = new SortableBindingList<MovieCollection>(m_movies
				.OrderBy(o => o.Date)
				.Select(o => Controller.Movies.Convert(o))
				.ToList());

			dataGridViewAll.DataSource = m_bindable;

			var watchedMovieEvents = Datasource.GetList<Model.dbo.MovieEvent>();

			dataGridViewUnwatched.DataSource = new SortableBindingList<MovieCollection>(m_movies
				.OrderBy(o => o.Date)
				.Where(o => !watchedMovieEvents.Any(m => m.Imdb == o.Imdb && m.Platform == o.Format))
				.Select(o => Controller.Movies.Convert(o))
				.ToList());

			SetGrid(dataGridViewAll);
			SetGrid(dataGridViewUnwatched);

			dataGridViewAll.SelectLastRow();
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var item = movieInfoControl1.GetItem();
			item.Date = DateTime.Now;

			Datasource.Add(item);

			m_movies.Add(item);
			m_bindable.Add(Controller.Movies.Convert(item));
			dataGridViewAll.SelectLastRow();
		}

		private void DataGridViewAll_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<MovieCollection>();

			if (item == null)
			{
				return;
			}

			movieInfoControl1.Fill(m_movies.FirstOrDefault(o => o.ID == item.ID));
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.Columns[nameof(MovieCollection.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(MovieCollection.Director)].Width = 130;
			dataGridView.Columns[nameof(MovieCollection.Year)].CenterColumn();
			dataGridView.Columns[nameof(MovieCollection.Format)].CenterColumn();
		}

		private void TextBoxImdb_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxImdb.Text))
			{
				return;
			}

			textBoxImdb.TextChanged -= TextBoxImdb_TextChanged;

			var movie = Controller.Movies.GetMovie(textBoxImdb.Text, false);

			if (movie != null)
			{
				textBoxImdb.Text = movie.Imdb;
				movieInfoControl1.Fill(movie);
			}

			textBoxImdb.TextChanged += TextBoxImdb_TextChanged;
		}
	}
}