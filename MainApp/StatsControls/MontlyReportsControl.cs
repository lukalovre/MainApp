using Controller;
using MainApp.Extensions;
using Model;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp.Reports
{
	public partial class MontlyReportsControl : UserControl
	{
		public MontlyReportsControl()
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

			MonthlyReportsLoad();

			numericUpDownYear.Value = DateTime.Now.Year;
		}

		private void ButtonRefresh_Click(object sender, EventArgs e)
		{
			MonthlyReportsLoad();
		}

		private void FillData(string category, Chart chart, List<MonthlyReport> monthlyReports)
		{
			chart.Series.Clear();

			chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
			chart.ChartAreas[0].AxisY.Maximum = 50;

			var series = new Series(category)
			{
				IsValueShownAsLabel = true,
				LabelFormat = "0.0"
			};

			chart.Series.Add(series);

			List<int> monthNumbers = Enumerable.Range(1, 12).ToList();

			var maxY = 0f;

			foreach (var monthNumber in monthNumbers)
			{
				var time = monthlyReports.FirstOrDefault(o => o.Month == monthNumber) == null
					? 0
					: monthlyReports.Where(o => o.Month == monthNumber).Sum(o => o.Time) / 60f;
				maxY = maxY < time ? time : maxY;
				var index = series.Points.AddXY(monthNumber, time);
				series.Points[index].AxisLabel = monthNumber.ToString();
				series.Points[index].Color = ChartColors.GetColor(category);
				series.Points[index].ToolTip = string.Format("{0:0.0}", time);
			}

			if (maxY > 50)
			{
				chart.ChartAreas[0].AxisY.Maximum = 100;
			}

			chart.ChartAreas.FirstOrDefault().RecalculateAxesScale();
		}

		private void FillDataAll()
		{
			chartAllWeekly.Series.Clear();

			chartAllWeekly.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chartAllWeekly.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

			var series = new Series
			{
				IsValueShownAsLabel = true,
				LabelFormat = "0.0"
			};

			chartAllWeekly.Series.Add(series);

			var chartData = new List<ChartData>
			{
				new ChartData{
					Name = "Games",
					Value = chartGames.GetLastValue()},
				new ChartData{
					Name = "Music",
					Value = chartMusic.GetLastValue()},
				new ChartData{
					Name = "Books",
					Value = chartBooks.GetLastValue()},
				new ChartData{
					Name = "Movies",
					Value = chartMovies.GetLastValue()},
				new ChartData{
					Name = "TV Shows",
					Value = chartTVShows.GetLastValue()},
				new ChartData{
					Name = "Comics",
					Value = chartComics.GetLastValue()},
				new ChartData{
					Name = "My work progress",
					Value = chartMyWorkProgress.GetLastValue()}
			};

			for (int i = 0; i < chartData.Count; i++)
			{
				ChartData data = chartData[i];
				var time = data.Value;
				var index = series.Points.AddXY(i, time);
				series.Points[index].AxisLabel = data.Name;
				series.Points[index].Color = ChartColors.GetColor(data.Name);
				series.Points[index].ToolTip = string.Format("{0:0.0}", time);
			}

			chartAllWeekly.ChartAreas.FirstOrDefault().RecalculateAxesScale();
		}

		private void MonthlyReportsLoad()
		{
			var games = Datasource.GetList<GameEvent>()
				.Where(o => o.Date.HasValue && o.Date.Value.Year == numericUpDownYear.Value)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Month,
					Time = o.Time
				}).ToList();

			var musics = Datasource.GetList<Music>();
			var music = Datasource.GetList<MusicEvent>()
				.Where(o => o.Date.HasValue && o.Date.Value.Year == numericUpDownYear.Value)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Month,
					Time = musics.FirstOrDefault(m => m.ItemID == o.ItemID).Runtime
				}).ToList();

			var minuterPerPageBooks = 2;
			var books = Datasource.GetList<BookEvent>()
				.Where(o => o.Date.HasValue && o.Date.Value.Year == numericUpDownYear.Value)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Month,
					Time = o.Pages * minuterPerPageBooks
				}).ToList();

			var movies = Datasource.GetList<Movie>();
			var movieL = Datasource.GetList<MovieEvent>()
				.Where(o => o.Date.HasValue && o.Date.Value.Year == numericUpDownYear.Value)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Month,
					Time = movies.FirstOrDefault(m => m.Imdb == o.Imdb).Runtime
				}).ToList();

			var tvShows = Datasource.GetList<TVShowEvent>()
				.Where(o => o.Date.HasValue && o.Date.Value.Year == numericUpDownYear.Value)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Month,
					Time = o.Runtime
				}).ToList();

			var minuterPerPageComics = 0.3f;
			var comics = Datasource.GetList<ComicEvent>()
				.Where(o => o.Date.HasValue && o.Date.Value.Year == numericUpDownYear.Value)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Month,
					Time = o.Pages * minuterPerPageComics
				}).ToList();

			var myWorkProgress = Datasource.GetList<MyWorkProgressEvent>()
				.Where(o => o.Date.HasValue && o.Date.Value.Year == numericUpDownYear.Value)
				.Select(o => new MonthlyReport
				{
					Month = o.Date.Value.Month,
					Time = o.Time
				}).ToList();

			FillData("Games", chartGames, games);
			FillData("Music", chartMusic, music);
			FillData("Books", chartBooks, books);
			FillData("Movies", chartMovies, movieL);
			FillData("TV Shows", chartTVShows, tvShows);
			FillData("Comics", chartComics, comics);
			FillData("My work progress", chartMyWorkProgress, myWorkProgress);
			FillDataAll();
		}

		private void NumericUpDownYear_ValueChanged(object sender, EventArgs e)
		{
			MonthlyReportsLoad();
		}
	}
}