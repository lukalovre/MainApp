using Dapper;
using MainApp.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp.Reports
{
	public partial class MontlyReports : UserControl
	{
		public MontlyReports()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			numericUpDownYear.Value = DateTime.Now.Year;
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
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

			using(IDbConnection db = new SqlConnection(Resources.MainConnectionString))
			{
				monthlyReport = db.Query<MonthlyReport>($"EXEC Reports.[Monthly {category}] @Year = {numericUpDownYear.Value}").ToList();
			}

			List<int> monthNumbers = Enumerable.Range(1, 12).ToList();

			foreach(var monthNumber in monthNumbers)
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
				new ChartData("Games",chartGames.GetLastValue(),Color.LimeGreen),
				new ChartData("Music", chartMusic.GetLastValue(), Color.HotPink),
				new ChartData("Books", chartBooks.GetLastValue(), Color.IndianRed),
				new ChartData("Movies", chartMovies.GetLastValue(), Color.Silver),
				new ChartData("TV Shows", chartTVShows.GetLastValue(), Color.MediumTurquoise),
				new ChartData("Comics", chartComics.GetLastValue(), Color.SteelBlue),
				new ChartData("My work progress", chartMyWorkProgress.GetLastValue(), Color.DarkKhaki)
			};

			for(int i = 0; i < chartData.Count; i++)
			{
				ChartData data = chartData[i];
				var time = data.Value;
				var index = series.Points.AddXY(i, time);
				series.Points[index].AxisLabel = data.Name;
				series.Points[index].Color = data.Color;
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
			FillData("TV Shows", chartTVShows, Color.MediumTurquoise);
			FillData("Comics", chartComics, Color.SteelBlue);
			FillData("My work progress", chartMyWorkProgress, Color.DarkKhaki);
			FillDataAll();
		}

		private void NumericUpDownYear_ValueChanged(object sender, EventArgs e)
		{
			MonthlyReports_Load(null, null);
		}
	}
}