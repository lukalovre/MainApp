using Controller;
using Controller.Extensions;
using Model.Collection;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.CollectionControls
{
	public partial class MovieInfoControl : UserControl
	{
		public MovieInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(Movie movie)
		{
			textBoxDirector.Text = movie.Director;
			comboBoxFormat.Text = movie.Format;
			textBoxImdb.Text = movie.Imdb;
			comboBoxOwner.Text = movie.Owner;
			textBoxPrice.Text = movie.Price.ToString();
			textBoxPriceInRSD.Text = movie.PriceInRSD.ToString();
			textBoxTitle.Text = movie.Title;
			labelDate.Text = movie.Date.ToString();
			numericUpDownRegion.Value = movie.Region ?? 0;
			numericUpDownYear.Value = movie.Year ?? 0;
		}

		internal void Fill(Model.dbo.Movie movie)
		{
			var movieCollection = new Movie
			{
				Director = movie.Director,
				Imdb = movie.Imdb,
				Title = movie.Title,
				Year = movie.Year
			};

			Fill(movieCollection);
		}

		internal Movie GetItem()
		{
			return new Movie
			{
				Director = textBoxDirector.Text,
				Format = comboBoxFormat.Text,
				Imdb = textBoxImdb.Text,
				Owner = comboBoxOwner.Text,
				Price = textBoxPrice.Text.ToNullableFloat(),
				PriceInRSD = textBoxPriceInRSD.Text.ToNullableFloat(),
				Region = (int)numericUpDownRegion.Value,
				Title = textBoxTitle.Text,
				Year = (int)numericUpDownYear.Value
			};
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			var movies = Datasource.GetList<Movie>();
			var owners = movies.Select(o => o.Owner).Distinct();
			var format = movies.Select(o => o.Format).Distinct();

			comboBoxOwner.Items.AddRange(owners.ToArray());
			comboBoxFormat.Items.AddRange(format.ToArray());
		}
	}
}