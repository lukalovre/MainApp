using Controller;
using MainApp.Extensions;
using MainApp.StatsControls;
using Model;
using Model.dbo;
using MoreLinq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp.Reports
{
	public partial class YearProgressControl : UserControl
	{
		private const string NAME = "YearProgress";
		private readonly string m_path = Path.Combine(Paths.Stats, $"{NAME}.json");

		public YearProgressControl()
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

			LoadChart();
		}

		private List<ChartData> LoadChartData()
		{
			if (File.Exists(m_path))
			{
				return HelperStats.ReadFile(m_path);
			}

			var movieEvents = Datasource.GetList<MovieEvent>();

			var movies1001 = movieEvents.DistinctBy(o => o.Imdb)
				.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year)
				.Count(o => Controller._1001.Is1001(o.Imdb));

			var gameEvents = Datasource.GetList<GameEvent>();

			var games1001 = gameEvents.DistinctBy(o => o.Igdb)
				.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year)
				.Count(o => Igdb.Is1001(o.Igdb));

			var comicsEvents = Datasource.GetList<ComicEvent>();
			var comics = Datasource.GetList<Comic>();

			var comics1001 = comicsEvents.DistinctBy(o => o.GoodreadsID)
				.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year)
				.Count(o => comics.FirstOrDefault(c => c.GoodreadsID == o.GoodreadsID)._1001);

			var bookEvents = Datasource.GetList<BookEvent>();
			var booksDB = Datasource.GetList<Book>();

			var books = bookEvents.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year && o.Read)
				.DistinctBy(o => o.GoodreadsID)
				.Count();

			var books1001 = bookEvents.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year && o.Read)
				.DistinctBy(o => o.GoodreadsID)
				.Count(o => booksDB.FirstOrDefault(c => c.GoodreadsID == o.GoodreadsID)._1001);

			var booksPages = bookEvents.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year)
				.Sum(o => o.Pages);

			var myWorkProgressEvent = Datasource.GetList<MyWorkProgressEvent>();

			var myWork = myWorkProgressEvent.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year)
				.Sum(o => o.Time) / 60;

			var tvShowEvents = Datasource.GetList<TVShowEvent>();

			var tvShows1001 = tvShowEvents.DistinctBy(o => o.Imdb)
				.Where(o => o.Date.HasValue && o.Date.Value.Year == DateTime.Now.Year)
				.Count(o => Controller._1001.Is1001(o.Imdb));

			var chartData = new List<ChartData>
				{
				new ChartData{
					Name = "Games 1001",
					Value = (float)games1001 / 50 * 100,
					Tooltip = $"{games1001}/50",
					Value2 = games1001},
				new ChartData {
					Name = "Books 1001",
					Value = (float)books1001 / 12 * 100,
					Tooltip = $"{books1001}/12",
					Value2 = books1001},
				new ChartData{
					Name = "Books pages",
					Value = (float) booksPages / 5000 * 100,
					Tooltip =  $"{booksPages}/5000",
					Value2 = booksPages},
				new ChartData{
					Name = "Movies 1001",
					Value = (float)movies1001 / 50 * 100,
					Tooltip = $"{movies1001}/50",
					Value2 = movies1001},
				new ChartData{
					Name = "TV Shows 1001",
					Value = (float)tvShows1001 / 15 * 100,
					Tooltip = $"{tvShows1001}/15",
					Value2 = tvShows1001},
				new ChartData{
					Name = "Comics 1001",
					Value = (float)comics1001 / 30 * 100,
					Tooltip = $"{comics1001}/30",
					Value2 = comics1001},
				new ChartData{
					Name = "My work",
					Value = (float)myWork / 100 * 100,
					Tooltip = $"{myWork}/100",
					Value2 = myWork},
				new ChartData{
					Name = "Year progress",
					Value = (float)DateTime.Now.DayOfYear / 365 * 100,
					Tooltip = ((float)DateTime.Now.DayOfYear / 365 * 100).ToString(),
					Value2 = DateTime.Now.DayOfYear / 365 * 100 }
				};

			var jsonText = JsonConvert.SerializeObject(chartData, Formatting.Indented);

			File.WriteAllText(m_path, jsonText);

			return chartData;
		}

		private void ButtonRefresh_Click(object sender, EventArgs e)
		{
			var oldData = new List<ChartData>();

			if (File.Exists(m_path))
			{
				oldData = HelperStats.ReadFile(m_path);
				File.Delete(m_path);
			}

			var newData = LoadChart();

			for (int i = 0; i < newData.Count; i++)
			{
				ChartData newDataItem = newData[i];
				var point = chartYearProgress.Series[0].Points[i];

				var oldDataItem = oldData.FirstOrDefault(o => o.Name == newDataItem.Name);
				var change = newDataItem.Value2 - oldDataItem.Value2;

				if (change != 0)
				{
					point.AxisLabel += $"\n+{change}";
				}
			}
		}

		private List<ChartData> LoadChart()
		{
			chartYearProgress.Series.Clear();

			var chartArea = chartYearProgress.ChartAreas.FirstOrDefault();

			chartArea.AxisX.MajorGrid.LineWidth = 0;
			chartArea.AxisY.MajorGrid.LineWidth = 0;
			chartArea.AxisY.Maximum = 100;

			var series = new Series
			{
				IsValueShownAsLabel = true,
				LabelFormat = "0.0"
			};

			chartYearProgress.Series.Add(series);

			var chartData = LoadChartData();

			chartData = chartData.SortByValue();

			for (int i = 0; i < chartData.Count; i++)
			{
				ChartData data = chartData[i];
				var index = series.Points.AddXY(i, data.Value);
				series.Points[index].AxisLabel = data.Name;
				series.Points[index].Color = ChartColors.GetColor(data.Name);
				series.Points[index].ToolTip = data.Tooltip;
			}

			chartArea.RecalculateAxesScale();

			return chartData;
		}
	}
}