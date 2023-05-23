using Controller;
using MainApp.Extensions;
using MainApp.StatsControls;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp._1001
{
	public partial class _1001Control : UserControl
	{
		private const string NAME = "1001";
		private readonly string m_path = Path.Combine(Paths.Stats, $"{NAME}.json");

		public _1001Control()
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

			var chartData = new List<ChartData>
			{
				new ChartData{
					Name = "Games",
					Value = Igdb.Get1001Count()},
				new ChartData{
					Name = "Albums",
					Value = Controller._1001.GetAlbumsCount()},
				new ChartData{
					Name = "Songs",
					Value = Controller._1001.GetSongsCount()},
				new ChartData{
					Name = "Books",
					Value = Controller._1001.GetBooksCount()},
				new ChartData{
					Name = "Movies",
					Value = Controller._1001.GetMoviesCount()},
				new ChartData{
					Name = "TV Shows",
					Value = Controller._1001.GetTVShowsCount()},
				new ChartData{
					Name = "Comics",
					Value = Controller._1001.GetComicsCount()},
				new ChartData{
					Name = "Paintings",
					Value = Controller._1001.GetPaintingCount()},
				new ChartData{
					Name = "Photographs",
					Value = Controller._1001.GetPhotographsCount()}
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
				var point = chart1001.Series[0].Points[i];

				var oldDataItem = oldData.FirstOrDefault(o => o.Name == newDataItem.Name);
				var change = newDataItem.Value - oldDataItem.Value;

				if (change != 0)
				{
					point.AxisLabel += $"\n+{change}";
				}
			}
		}

		private List<ChartData> LoadChart()
		{
			chart1001.Series.Clear();

			var chartArea = chart1001.ChartAreas.FirstOrDefault();

			chartArea.AxisX.MajorGrid.LineWidth = 0;
			chartArea.AxisY.MajorGrid.LineWidth = 0;
			chartArea.AxisY.Maximum = 1100;

			var series = new Series
			{
				IsValueShownAsLabel = true
			};

			chart1001.Series.Add(series);

			var chartData = LoadChartData();

			chartData = chartData.SortByValue();

			for (int i = 0; i < chartData.Count; i++)
			{
				ChartData data = chartData[i];
				var time = data.Value;
				var index = series.Points.AddXY(i, time);
				series.Points[index].AxisLabel = data.Name;
				series.Points[index].Color = ChartColors.GetColor(data.Name);
			}

			chartArea.RecalculateAxesScale();

			return chartData;
		}
	}
}