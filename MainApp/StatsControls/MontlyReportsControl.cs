using Controller;
using MainApp.Extensions;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
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

			numericUpDownYear.Value = DateTime.Now.Year;
		}

		private void ButtonRefresh_Click(object sender, EventArgs e)
		{
			MonthlyReports_Load(null, null);
		}

		private void FillData(string category, Chart chart, Color color)
		{
			chart.Series.Clear();

			chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
			chart.ChartAreas[0].AxisY.Maximum = 100;

			var series = new Series(category)
			{
				IsValueShownAsLabel = true,
				LabelFormat = "0.0"
			};

			chart.Series.Add(series);
			var monthlyReport = new List<MonthlyReport>();

			monthlyReport = Database.Query<MonthlyReport>($"EXEC Reports.[Monthly {category}] @Year = {numericUpDownYear.Value}").ToList();

			List<int> monthNumbers = Enumerable.Range(1, 12).ToList();

			foreach (var monthNumber in monthNumbers)
			{
				var time = monthlyReport.FirstOrDefault(o => o.Month == monthNumber) == null ? 0 : monthlyReport.FirstOrDefault(o => o.Month == monthNumber).Time;
				var index = series.Points.AddXY(monthNumber, time);
				series.Points[index].AxisLabel = monthNumber.ToString();
				series.Points[index].Color = color;
				series.Points[index].ToolTip = string.Format("{0:0.0}", time);
			}

			chart.ChartAreas.FirstOrDefault().RecalculateAxesScale();
		}

		private void FillDataAll()
		{
			chartAllWeekly.Series.Clear();

			chartAllWeekly.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chartAllWeekly.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
			chartAllWeekly.ChartAreas[0].AxisY.Maximum = 100;

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

		private void MonthlyReports_Load(object sender, EventArgs e)
		{
			FillData("Games", chartGames, Color.LimeGreen);
			FillData("Music", chartMusic, Color.HotPink);
			FillData("Books", chartBooks, Color.IndianRed);
			FillData("Movies", chartMovies, Color.Silver);
			FillData("TVShows", chartTVShows, Color.MediumTurquoise);
			FillData("Comics", chartComics, Color.SteelBlue);
			FillData("MyWorkProgress", chartMyWorkProgress, Color.DarkKhaki);
			FillDataAll();
		}

		private void NumericUpDownYear_ValueChanged(object sender, EventArgs e)
		{
			MonthlyReports_Load(null, null);
		}
	}
}