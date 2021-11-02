using System;
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

			if(DesignMode)
			{
				return;
			}

			CreateChart("Games", Color.LimeGreen);
			CreateChart("Music", Color.HotPink);
			CreateChart("Books", Color.IndianRed);
			CreateChart("Movies", Color.Silver);
			CreateChart("TVShows", Color.MediumTurquoise);
			CreateChart("Comics", Color.SteelBlue);
			CreateChart("MyWorkProgress", Color.DarkKhaki);
			CreateChart("All", Color.DarkBlue);
			CreateChart("AllM", Color.DarkGreen);
		}

		private void CreateChart(string category, Color color)
		{
			var series = new Series
			{
				ChartArea = "ChartArea",
				Name = category,
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

			foreach(var year in Enumerable.Range(recordsStart, DateTime.Now.Year - recordsStart + 1))
			{
				var yearTime = Controller.Database.Query<float>($"EXEC Reports.[Yearly {category}] @Year = {year}").FirstOrDefault();
				var index = series.Points.AddXY(year, yearTime);

				if(yearTime > chart.ChartAreas[0].AxisY.Maximum)
				{
					chart.ChartAreas[0].AxisY.Maximum = yearTime;
				}

				series.Points[index].AxisLabel = year.ToString().Substring("20".Length);
				series.Points[index].Color = color;
				series.Points[index].ToolTip = string.Format("{0:0}", yearTime);
			}

			chart.ChartAreas.FirstOrDefault().RecalculateAxesScale();
		}
	}
}