using Controller;
using Model;
using Model.dbo;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp.Reports
{
	public partial class YearStatsControl : UserControl
	{
		public YearStatsControl()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			var games = Datasource.GetList<GameEvent>()
				.Where(o => o.Date.HasValue)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Year,
					Time = o.Time
				}).ToList();

			var musics = Datasource.GetList<Music>();
			var music = Datasource.GetList<MusicEvent>()
				.Where(o => o.Date.HasValue)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Year,
					Time = musics.FirstOrDefault(m => m.ItemID == o.ItemID).Runtime
				}).ToList();

			var minuterPerPageBooks = 2;
			var book = Datasource.GetList<BookEvent>()
				.Where(o => o.Date.HasValue)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Year,
					Time = o.Pages * minuterPerPageBooks
				}).ToList();

			var movies = Datasource.GetList<Movie>();
			var movie = Datasource.GetList<MovieEvent>()
				.Where(o => o.Date.HasValue)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Year,
					Time = movies.FirstOrDefault(m => m.Imdb == o.Imdb).Runtime
				}).ToList();

			var tvShows = Datasource.GetList<TVShowEvent>()
			  .Where(o => o.Date.HasValue)
			  .Select(o => new MonthlyReport
			  {
				  Month = o.Date.Value.Year,
				  Time = o.Runtime
			  }).ToList();

			var minuterPerPageComics = 0.3f;
			var comics = Datasource.GetList<ComicEvent>()
				.Where(o => o.Date.HasValue)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Year,
					Time = o.Pages * minuterPerPageComics
				}).ToList();

			var myWorkProgress = Datasource.GetList<MyWorkProgressEvent>()
				.Where(o => o.Date.HasValue)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Year,
					Time = o.Time
				}).ToList();

			var allWithoutMusic = games.Concat(book).Concat(movie).Concat(tvShows).Concat(comics).Concat(myWorkProgress).ToList();
			var all = allWithoutMusic.Concat(music).ToList();

			CreateChart("Games", games);
			CreateChart("Music", music);
			CreateChart("Books", book);
			CreateChart("Movies", movie);
			CreateChart("TV Shows", tvShows);
			CreateChart("Comics", comics);
			CreateChart("My work progress", myWorkProgress);
			//CreateChart("All", all);
			CreateChart("All (-musik)", allWithoutMusic);
		}

		private void CreateChart(string category, List<MonthlyReport> monthlyReports)
		{
			var series = new Series
			{
				ChartArea = "ChartArea",
				IsValueShownAsLabel = true,
				LabelFormat = "0"
			};

			var chartArea = new ChartArea
			{
				Name = "ChartArea"
			};

			var title = new Title
			{
				Name = "Title",
				Text = category
			};

			var width = 340;
			var heigth = 200;

			var chart = new Chart
			{
				Location = new Point(Controls.Count / 3 * width, Controls.Count % 3 * heigth),
				Margin = new Padding(0, 0, 0, 0),
				Name = "Chart",
				Size = new Size(width, heigth),
				TabIndex = 1,
				Text = category
			};

			Controls.Add(chart);

			chart.Titles.Add(title);
			chart.Series.Add(series);
			chart.ChartAreas.Add(chartArea);

			chart.Series.Clear();

			chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
			chart.ChartAreas[0].AxisY.Maximum = 1000;

			chart.Series.Add(series);

			var recordsStart = 2010;

			foreach (var year in Enumerable.Range(recordsStart, DateTime.Now.Year - recordsStart + 1))
			{
				var yearTime = monthlyReports.Where(o => o.Month == year).Sum(o => o.Time) / 60f;
				var index = series.Points.AddXY(year, yearTime);

				if (yearTime > chart.ChartAreas[0].AxisY.Maximum)
				{
					chart.ChartAreas[0].AxisY.Maximum = yearTime;
				}

				series.Points[index].AxisLabel = year.ToString().Substring("20".Length);
				series.Points[index].Color = ChartColors.GetColor(category);
				series.Points[index].ToolTip = string.Format("{0:0}", yearTime);
			}

			chart.ChartAreas.FirstOrDefault().RecalculateAxesScale();
		}
	}
}