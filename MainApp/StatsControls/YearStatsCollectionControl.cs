using Controller;
using Model.Collection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp.Reports
{
	public partial class YearStatsCollectionControl : UserControl
	{
		private List<Control> m_chartList = new List<Control>();

		public YearStatsCollectionControl()
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

			LoadCharts();
		}

		private void LoadCharts()
		{
			m_chartList.ForEach(o => Controls.Remove(o));
			m_chartList.Clear();

			var books = Datasource.GetList<Book>().Select(o => o as ICollection).ToList();
			var comics = Datasource.GetList<Comic>().Select(o => o as ICollection).ToList();
			var games = Datasource.GetList<Game>().Select(o => o as ICollection).ToList();
			var movies = Datasource.GetList<Movie>().Select(o => o as ICollection).ToList();
			var music = Datasource.GetList<Music>().Select(o => o as ICollection).ToList();
			var all = books.Concat(comics).Concat(games).Concat(movies).Concat(music).ToList();

			CreateChart("Books", books);
			CreateChart("Comics", comics);
			CreateChart("Games", games);
			CreateChart("Movies", movies);
			CreateChart("Music", music);
			CreateChart("All", all);
		}

		private void CreateChart(string category, List<ICollection> collectionList)
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

			var width = 430;
			var heigth = 215;
			var offsetX = 100;

			var chart = new Chart
			{
				Location = new Point(m_chartList.Count / 3 * width + offsetX, m_chartList.Count % 3 * heigth),
				Margin = new Padding(0, 0, 0, 0),
				Name = "Chart",
				Size = new Size(width, heigth),
				TabIndex = 1,
				Text = category
			};

			Controls.Add(chart);
			m_chartList.Add(chart);

			chart.Titles.Add(title);
			chart.Series.Add(series);
			chart.ChartAreas.Add(chartArea);

			chart.Series.Clear();

			chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

			chart.Series.Add(series);

			var recordsStart = 2012;
			var maxY = 0d;

			foreach (var year in Enumerable.Range(recordsStart, DateTime.Now.Year - recordsStart + 1))
			{
				var categoryNoSpaces = category.Replace(" ", string.Empty);

				var value = 0d;

				if (radioButtonPrice.Checked)
				{
					chart.ChartAreas[0].AxisY.Maximum = maxY < 1000 ? 1000 : maxY;

					value = (double)collectionList
					.Where(o => o.Date.HasValue && o.Date.Value.Year == year)
					.Sum(x => x.PriceInRSD) / 117f;
				}

				if (radioButtonAmount.Checked)
				{
					chart.ChartAreas[0].AxisY.Maximum = maxY < 200 ? 200 : maxY;

					value = (double)collectionList
					.Where(o => o.Date.HasValue && o.Date.Value.Year == year)
					.Count();
				}

				if (radioButtonPriceAmount.Checked)
				{
					chart.ChartAreas[0].AxisY.Maximum = maxY < 20 ? 20 : maxY;

					var price = (double)collectionList
					.Where(o => o.Date.HasValue && o.Date.Value.Year == year)
					.Sum(x => x.PriceInRSD) / 117f;

					var amount = (double)collectionList
					.Where(o => o.Date.HasValue && o.Date.Value.Year == year)
					.Count();

					value = price / amount;
				}

				var index = series.Points.AddXY(year, value);

				if (value > chart.ChartAreas[0].AxisY.Maximum)
				{
					maxY = value;
					chart.ChartAreas[0].AxisY.Maximum = value;
				}

				series.Points[index].AxisLabel = year.ToString().Substring("20".Length);
				series.Points[index].Color = ChartColors.GetColor(category);
				series.Points[index].ToolTip = string.Format("{0:0}", value);
			}

			chart.ChartAreas.FirstOrDefault().RecalculateAxesScale();
		}

		private void RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			LoadCharts();
		}

		private void ButtonRefresh_Click(object sender, EventArgs e)
		{
			LoadCharts();
		}
	}
}