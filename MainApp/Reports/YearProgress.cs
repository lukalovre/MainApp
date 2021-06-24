﻿using Dapper;
using MainApp.Extensions;
using MainApp.Properties;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp.Reports
{
	public partial class YearProgress : UserControl
	{
		public YearProgress()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			LoadValues();
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			LoadValues();
		}

		private void LoadValues()
		{
			using(var db = new SqlConnection(Resources.MainConnectionString))
			{
				var movies = db.ExecuteScalar<int>(@"	select count(ID)
														from MovieEvents
														where year(Date) = year(getdate())");

				var movies1001 = db.ExecuteScalar<int>(@"	select count(me.ID)
															from MovieEvents me
															join Movies m on m.Imdb = me.Imdb
															where year(
                                                            (
															select min([Date])
															from MovieEvents
															where Imdb = me.imdb
															)
                                                            ) = year(getdate())
															and m._1001 = 1");

				var tvShows1001 = db.ExecuteScalar<int>(@"	select count(distinct e.Imdb)
															from TVShowEvents e
															join TVShows m on m.Imdb = e.Imdb
															where year(
															(
															select min([Date])
															from TVShowEvents
															where Imdb = e.imdb
															)
															) = year(getdate())
															and m._1001 = 1");

				var games = db.ExecuteScalar<int>($@"	select count(distinct e.ItemID)
														from GameEvents e
														join Games m on m.ItemID = e.ItemID
														where year(
														(
														select min([Date])
														from GameEvents
														where ItemID = e.ItemID
														)
														) = year(getdate())");

				var games1001 = db.ExecuteScalar<int>($@"	select count(distinct e.ItemID)
															from GameEvents e
															join Games m on m.ItemID = e.ItemID
															where year(
															(
															select min([Date])
															from GameEvents
															where ItemID = e.ItemID
															)
															) = year(getdate())
															and m._1001 = 1");

				var comics1001 = db.ExecuteScalar<int>($@"	select count(distinct e.GoodreadsID)
															from ComicEvents e
															join Comics m on m.GoodreadsID = e.GoodreadsID
															where year(
															(
															select min([Date])
															from ComicEvents
															where GoodreadsID = e.GoodreadsID
															)
															) = year(getdate())
															and m._1001 = 1");

				var books = db.ExecuteScalar<int>($@"	select count(distinct e.GoodreadsID)
															from BookEvents e
															join Books m on m.GoodreadsID = e.GoodreadsID
															where year(
															(
															select min([Date])
															from BookEvents
															where GoodreadsID = e.GoodreadsID
															)
															) = year(getdate())
															and e.[Read] = 1");

				var books1001 = db.ExecuteScalar<int>($@"select count(distinct e.GoodreadsID)
															from BookEvents e
															join Books m on m.GoodreadsID = e.GoodreadsID
															where year(
															(
															select min([Date])
															from BookEvents
															where GoodreadsID = e.GoodreadsID
															)
															) = year(getdate())
															and m._1001 = 1
															and e.[Read] = 1");

				var booksPages = db.ExecuteScalar<int>($@"	select sum( e.Pages)
															from BookEvents e
															join Books m on m.GoodreadsID = e.GoodreadsID
															where year(
															(
															select min([Date])
															from BookEvents
															where GoodreadsID = e.GoodreadsID
															)
															) = year(getdate())");

				var myWork = db.Query<float>($@"	select sum(Time)/ 60
													from[My work progress]
													where year(Date) = {DateTime.Now.Year}").FirstOrDefault();

				chartYearProgress.Series.Clear();

				chartYearProgress.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
				chartYearProgress.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
				chartYearProgress.ChartAreas[0].AxisY.Maximum = 100;

				var series = new Series
				{
					IsValueShownAsLabel = true,
					LabelFormat = "0.0"
				};

				chartYearProgress.Series.Add(series);

				var chartData = new List<ChartData>
				{
				new ChartData("Games (40)",(float)  games/40*100, Color.LimeGreen,games),
				new ChartData("Games 1001 (30)", (float) games1001/30*100, Color.LimeGreen,games1001),
				new ChartData("Books (15)", (float) books/15*100, Color.IndianRed,(int)books),
				new ChartData("Books 1001 (12)", (float) books1001/12*100, Color.IndianRed,(int)books1001),
				new ChartData("Books pages (4000)", (float) booksPages/4000*100, Color.IndianRed,(int)booksPages),
				new ChartData("Movies (40)", (float) movies/40*100, Color.Silver,movies),
				new ChartData("Movies 1001 (30)", (float) movies1001/30*100, Color.Silver, movies1001),
				new ChartData("TV Shows 1001 (15)",(float) tvShows1001/15*100, Color.MediumTurquoise, tvShows1001),
				new ChartData("Comics 1001 (30)", (float) comics1001/30*100, Color.SteelBlue, comics1001),
				new ChartData("My work (200)", myWork/200*100, Color.DarkKhaki,(int)myWork),
				new ChartData("Year progress", (float)DateTime.Now.DayOfYear/365*100, Color.DimGray)
				};

				chartData = chartData.SortByValue();

				for(int i = 0; i < chartData.Count; i++)
				{
					ChartData data = chartData[i];
					var index = series.Points.AddXY(i, data.Value);
					series.Points[index].AxisLabel = data.Name;
					series.Points[index].Color = data.Color;
					series.Points[index].ToolTip = data.Value2.ToString();
				}

				chartYearProgress.ChartAreas.FirstOrDefault().RecalculateAxesScale();
			}
		}
	}
}