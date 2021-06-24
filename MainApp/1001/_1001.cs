using Dapper;
using MainApp.Extensions;
using MainApp.Properties;
using MainApp.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp._1001
{
	public partial class _1001 : UserControl
	{
		public _1001()
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

			var _1001Data = new _1001Data();

			using(IDbConnection db = new SqlConnection(Resources.MainConnectionString))
			{
				_1001Data = db.Query<_1001Data>($@"	SELECT [Photographs]
															,[Books]
															,[TVShows]
															,[Games]
															,[Comics]
															,[Movies]
															,[Paintings]
															,[Albums]
															,[Songs]
															FROM[Main].[1001].[All Progress]").ToList().FirstOrDefault();
			}

			var chartData = new List<ChartData>
			{
				new ChartData("Games",_1001Data.Games,Color.LimeGreen),
				new ChartData("Albums", _1001Data.Albums, Color.HotPink),
				new ChartData("Songs", _1001Data.Songs, Color.Purple),
				new ChartData("Books", _1001Data.Books, Color.IndianRed),
				new ChartData("Movies", _1001Data.Movies, Color.Silver),
				new ChartData("TV Shows", _1001Data.TVShows, Color.MediumTurquoise),
				new ChartData("Comics", _1001Data.Comics, Color.SteelBlue),
				new ChartData("Paintings", _1001Data.Paintings, Color.DarkKhaki),
				new ChartData("Photographs", _1001Data.Photographs, Color.DarkSlateGray)
			};

			chartData = chartData.SortByValue();

			for(int i = 0; i < chartData.Count; i++)
			{
				ChartData data = chartData[i];
				var time = data.Value;
				var index = series.Points.AddXY(i, time);
				series.Points[index].AxisLabel = data.Name;
				series.Points[index].Color = data.Color;
			}

			chart1001.ChartAreas.FirstOrDefault().RecalculateAxesScale();
		}
	}
}