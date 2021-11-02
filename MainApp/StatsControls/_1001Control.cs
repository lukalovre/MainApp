using Controller;
using MainApp.Extensions;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp._1001
{
	public partial class _1001Control : UserControl
	{
		public _1001Control()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			LoadData();
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{
			chart1001.Series.Clear();

			chart1001.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chart1001.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
			chart1001.ChartAreas[0].AxisY.Maximum = 1100;

			var series = new Series
			{
				IsValueShownAsLabel = true
			};

			chart1001.Series.Add(series);

			var _1001Data = Database.Query<_1001Data>($@"	SELECT
															 [Books]
															,[TVShows]
															,[Comics]
															,[Albums]
															,[Songs]
															FROM [Main].[1001].[All Progress]").ToList().FirstOrDefault();

			var chartData = new List<ChartData>
			{
				new ChartData{
					Name = "Games",
					Value = Igdb.Get1001Count()},
				new ChartData{
					Name = "Albums",
					Value = _1001Data.Albums},
				new ChartData{
					Name = "Songs",
					Value = _1001Data.Songs},
				new ChartData{
					Name = "Books",
					Value = _1001Data.Books},
				new ChartData{
					Name = "Movies",
					Value = Imdb.Get1001MoviesCount()},
				new ChartData{
					Name = "TV Shows",
					Value = _1001Data.TVShows},
				new ChartData{
					Name = "Comics",
					Value = _1001Data.Comics},
				new ChartData{
					Name = "Paintings",
					Value = 1001},
				new ChartData{
					Name = "Photographs",
					Value = 1001}
			};

			chartData = chartData.SortByValue();

			for (int i = 0; i < chartData.Count; i++)
			{
				ChartData data = chartData[i];
				var time = data.Value;
				var index = series.Points.AddXY(i, time);
				series.Points[index].AxisLabel = data.Name;
				series.Points[index].Color = ChartColors.GetColor(data.Name);
			}

			chart1001.ChartAreas.FirstOrDefault().RecalculateAxesScale();
		}
	}
}