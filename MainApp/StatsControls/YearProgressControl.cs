using Controller;
using MainApp.Extensions;
using Model;
using Model.dbo;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp.Reports
{
	public partial class YearProgressControl : UserControl
	{
		public YearProgressControl()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			LoadValues();
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			LoadValues();
		}

		private void LoadValues()
		{
			var movieEvents = Database.GetList<MovieEvent>();

			var movies = movieEvents.DistinctBy(o => o.Imdb)
				.Count(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year);

			var movies1001 = movieEvents.DistinctBy(o => o.Imdb)
				.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year)
				.Count(o => Controller._1001.Is1001(o.Imdb));

			var gameEvents = Database.GetList<GameEvent>();

			var games = gameEvents.DistinctBy(o => o.Igdb)
				.Count(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year);

			var games1001 = gameEvents.DistinctBy(o => o.Igdb)
				.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year)
				.Count(o => Igdb.Is1001(o.Igdb));

			var comicsEvents = Database.GetList<ComicEvent>();
			var comics = Database.GetList<Comic>();

			var comics1001 = comicsEvents.DistinctBy(o => o.GoodreadsID)
				.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year)
				.Count(o => comics.FirstOrDefault(c => c.GoodreadsID == o.GoodreadsID)._1001);

			var bookEvents = Database.GetList<BookEvent>();
			var booksDB = Database.GetList<Book>();

			var books = bookEvents.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year && o.Read)
				.DistinctBy(o => o.GoodreadsID)
				.Count();

			var books1001 = bookEvents.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year && o.Read)
				.DistinctBy(o => o.GoodreadsID)
				.Count(o => booksDB.FirstOrDefault(c => c.GoodreadsID == o.GoodreadsID)._1001);

			var booksPages = bookEvents.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year)
				.Sum(o => o.Pages);

			var myWorkProgressEvent = Database.GetList<MyWorkProgressEvent>();

			var myWork = myWorkProgressEvent.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year)
				.Sum(o => o.Time) / 60;

			var tvShows1001 = Database.ExecuteScalar<int>(@"select count(distinct e.Imdb)
															from TVShowEvents e
															join TVShows m on m.Imdb = e.Imdb
															where year(
															(
															select min([Date])
															from TVShowEvents
															where Imdb = e.imdb
															)
															) = year(getdate())
															and m._1001 = 1");

			chartYearProgress.Series.Clear();

			chartYearProgress.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chartYearProgress.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
			chartYearProgress.ChartAreas[0].AxisY.Maximum = 100;

			var series = new Series
			{
				IsValueShownAsLabel = true,
				LabelFormat = "0.0"
			};

			chartYearProgress.Series.Add(series);

			var chartData = new List<ChartData>
				{
				new ChartData{
					Name = "Games (40)",
					Value = (float)  games/40*100,
					Value2 = games },
				new ChartData{
					Name = "Games 1001 (30)",
					Value = (float)games1001 / 30 * 100,
					Value2 = games1001 },
				new ChartData{
					Name = "Books (15)",
					Value = (float)books / 15 * 100,
					Value2 = books},
				new ChartData {
					Name = "Books 1001 (12)",
					Value = (float)books1001 / 12 * 100,
					Value2 = books1001},
				new ChartData{
					Name = "Books pages (4000)",
					Value = (float) booksPages / 4000 * 100,
					Value2 =  booksPages },
				new ChartData{
					Name = "Movies (40)",
					Value = (float)movies / 40 * 100,
					Value2 = movies },
				new ChartData{
					Name = "Movies 1001 (30)",
					Value = (float)movies1001 / 30 * 100,
					Value2 = movies1001},
				new ChartData{
					Name = "TV Shows 1001 (15)",
					Value = (float)tvShows1001 / 15 * 100,
					Value2 = tvShows1001},
				new ChartData{
					Name = "Comics 1001 (30)",
					Value = (float)comics1001 / 30 * 100,
					Value2 = comics1001},
				new ChartData{
					Name = "My work (200)",
					Value = (float)myWork / 200 * 100,
					Value2 = myWork },
				new ChartData{
					Name = "Year progress",
					Value = (float)DateTime.Now.DayOfYear / 365 * 100}
				};

			chartData = chartData.SortByValue();

			for (int i = 0; i < chartData.Count; i++)
			{
				ChartData data = chartData[i];
				var index = series.Points.AddXY(i, data.Value);
				series.Points[index].AxisLabel = data.Name;
				series.Points[index].Color = ChartColors.GetColor(data.Name);
				series.Points[index].ToolTip = data.Value2.ToString();
			}

			chartYearProgress.ChartAreas.FirstOrDefault().RecalculateAxesScale();
		}
	}
}