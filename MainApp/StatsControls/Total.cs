using Controller;
using MainApp.Extensions;
using Model;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp.StatsControls
{
	public partial class Total : UserControl
	{
		public Total()
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

			chart1.Series.Clear();

			chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

			var series = new Series
			{
				IsValueShownAsLabel = true
			};

			chart1.Series.Add(series);

			var chartData = new List<ChartData>
			{
				new ChartData{
					Name = "Games",
					Value = Datasource.GetList<Game>().Count},
				new ChartData{
					Name = "Albums",
					Value = Datasource.GetList<Music>().Count},
				new ChartData{
					Name = "Books",
					Value = Datasource.GetList<Book>().Count},
				new ChartData{
					Name = "Movies",
					Value = Datasource.GetList<Movie>().Count},
				new ChartData{
					Name = "TV Shows",
					Value = Datasource.GetList<TVShow>().Count},
				new ChartData{
					Name = "Comics",
					Value = Datasource.GetList<Comic>().Count}};

			chartData = chartData.SortByValue();

			for (int i = 0; i < chartData.Count; i++)
			{
				ChartData data = chartData[i];
				var time = data.Value;
				var index = series.Points.AddXY(i, time);
				series.Points[index].AxisLabel = data.Name;
				series.Points[index].Color = ChartColors.GetColor(data.Name);
				series.Points[index].ToolTip = string.Format("{0:0}", time);
			}

			chart1.ChartAreas[0].AxisY.Maximum = 2000;
		}
	}
}