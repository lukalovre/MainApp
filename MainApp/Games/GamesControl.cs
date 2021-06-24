using Dapper;
using MainApp.Properties;
using MainApp.Reports;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp.Games
{
	public partial class GamesControl : UserControl
	{
		internal static GamesControl Instance;
		private BindingList<Game> m_bindingList;
		private List<GameEvent> m_gameEvents;
		private List<Game> m_games;

		public GamesControl()
		{
			InitializeComponent();
			Instance = this;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if(DesignMode)
			{
				return;
			}

			m_games = Controller.Database.GetList<Game>();
			m_gameEvents = Controller.Database.GetList<GameEvent>();

			yearFilter1.SetValueChangedEvent(NumericUpDownYearFilter_ValueChanged);

			dataGridViewPlaying.DataSource =
			new BindingSource(m_games.Where(o => FormMain.Following.Games.Contains(o.ItemID.ToString())), null);

			SetGrid(dataGridViewGames);
			SetGrid(dataGridViewPlaying);

			dataGridViewGames.SelectLastRow();
			dataGridViewPlaying.SelectLastRow();
		}

		private void ButtonUpdate_Click(object sender, EventArgs e)
		{
			var gameEvent = gameInfo1.GetGameEvent();
			gameEvent.Date = DateTime.Now;

			Controller.Database.Add(gameEvent);
		}

		private void DataGridViewGames_SelectionChanged(object sender, EventArgs e)
		{
			var game = (sender as DataGridView).GetRowObject<Game>();

			if(game == null)
			{
				return;
			}

			gameInfo1.Fill(game, m_gameEvents.Where(o => o.ItemID == game.ItemID).ToList());
		}

		//private void FillChart()
		//{
		//	var result = new List<Consoles>();

		//	var query = @"	Select
		//					max(Platform) Platform,
		//					count(Platform) Count,
		//					AVG(CAST(Rating AS FLOAT)) Rating
		//					from [View Games]
		//					group by Platform";

		//	using(IDbConnection db = new SqlConnection(Resources.MainConnectionString))
		//	{
		//		result = db.Query<Consoles>(query).ToList();
		//	}

		//	result = result.OrderByDescending(o => o.Count).ToList();

		//	chartHoursByConsole.Series.Clear();

		//	chartHoursByConsole.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
		//	chartHoursByConsole.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
		//	chartHoursByConsole.ChartAreas[0].AxisY.Maximum = 100;

		//	var series = new Series
		//	{
		//		IsValueShownAsLabel = true,
		//		LabelFormat = "0"
		//	};

		//	chartHoursByConsole.Series.Add(series);

		//	var chartData = new List<ChartData>();

		//	foreach(var item in result)
		//	{
		//		chartData.Add(new ChartData(item.Platform, item.Count, Color.BlueViolet));
		//	}

		//	for(int i = 0; i < chartData.Count; i++)
		//	{
		//		ChartData data = chartData[i];
		//		var time = data.Value;
		//		var index = series.Points.AddXY(i, time);
		//		series.Points[index].AxisLabel = data.Name;
		//		series.Points[index].Color = data.Color;
		//		series.Points[index].ToolTip = string.Format("{0:0}", time);
		//	}

		//	chartHoursByConsole.ChartAreas.FirstOrDefault().RecalculateAxesScale();

		//	query = @"		Select
		//					max(Platform) Platform,
		//					--count(Platform) Count,
		//					AVG(CAST(Rating AS FLOAT)) Rating,

		//					(select Count(Platform)
		//					from [View Games]
		//					where vg.Platform = Platform
		//					and Rating > 2
		//					) Count

		//					from [View Games] vg
		//					group by Platform";

		//	var result2 = new List<Consoles>();

		//	using(IDbConnection db = new SqlConnection(Resources.MainConnectionString))
		//	{
		//		result2 = db.Query<Consoles>(query).ToList();
		//	}

		//	foreach(var item in result2)
		//	{
		//		item.Percent = (float)item.Count / result.FirstOrDefault(c => c.Platform == item.Platform).Count * 100;
		//	}

		//	result2 = result2.OrderByDescending(o => o.Percent).ToList();

		//	chartRatingPerConsole.Series.Clear();

		//	chartRatingPerConsole.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
		//	chartRatingPerConsole.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
		//	chartRatingPerConsole.ChartAreas[0].AxisY.Maximum = 100;

		//	series = new Series
		//	{
		//		IsValueShownAsLabel = true,
		//		LabelFormat = "0"
		//	};

		//	chartRatingPerConsole.Series.Add(series);

		//	chartData = new List<ChartData>();

		//	foreach(var item in result2)
		//	{
		//		chartData.Add(new ChartData(item.Platform, item.Percent, Color.Blue));
		//	}

		//	for(int i = 0; i < chartData.Count; i++)
		//	{
		//		ChartData data = chartData[i];
		//		var time = data.Value;
		//		var index = series.Points.AddXY(i, time);
		//		series.Points[index].AxisLabel = data.Name;
		//		series.Points[index].Color = data.Color;
		//		series.Points[index].ToolTip = string.Format("{0:0}", time);
		//	}

		//	chartRatingPerConsole.ChartAreas.FirstOrDefault().RecalculateAxesScale();
		//}

		private void NumericUpDownYearFilter_ValueChanged(object sender, EventArgs e)
		{
			var thisYear = m_gameEvents.Where(m => m.Date.HasValue && m.Date.Value.Year == (sender as NumericUpDown).Value).ToList();

			var bind = new List<Game>();

			foreach(var me in thisYear)
			{
				var m = m_games.FirstOrDefault(o => o.ItemID == me.ItemID);
				bind.Add(m);
			}

			m_bindingList = new BindingList<Game>(bind.Distinct().ToList());

			dataGridViewGames.DataSource = new BindingSource(m_bindingList, null);
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[] {
			nameof(Game.Title),
			nameof(Game.Year),
			nameof(Game.Platform),
			nameof(Game._1001)});

			dataGridView.Columns[nameof(Game._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(Game._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(Game.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Game.Platform)].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			dataGridView.Columns[nameof(Game.Year)].CenterColumn();
		}
	}
}