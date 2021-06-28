using Dapper;
using MainApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static MainApp.DataGridCustom;

namespace MainApp.Collection.Games
{
	public partial class GamesControl : UserControl
	{
		public static GamesControl Instance;

		public GamesControl()
		{
			InitializeComponent();
			Instance = this;
		}

		public void ShowGamesInGrid1001ToPlay()
		{
			var query = @"	SELECT *
							FROM [Main].[Games].[Plan to play games]
							WHERE [1001] = 1
							order by [HLTB time]";

			var gridColumnList = new List<GridColumn>
			{
				new GridColumn(Table.Title),
				new GridColumn(Table.Platform),
				new GridColumn(Table.Client),
				new GridColumn(Table.Year, typeof(int)),
				new GridColumn(Table.HLTBTime, typeof(int)),
				new GridColumn(Table.DateBuy),
				new GridColumn(Table.ID, typeof(int))
			};

			dataGridCustom1001ToPlay.FillGrid(query, gridColumnList);

			SetHLTBSum();

			dataGridCustom1001ToPlay.Columns[Table.Platform].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dataGridCustom1001ToPlay.Columns[Table.Platform].Width = 40;

			dataGridCustom1001ToPlay.Columns[Table.Client].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dataGridCustom1001ToPlay.Columns[Table.Client].Width = 50;

			dataGridCustom1001ToPlay.Columns[Table.HLTBTime].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridCustom1001ToPlay.Sort(dataGridCustom1001ToPlay.Columns[Table.HLTBTime], ListSortDirection.Ascending);

			dataGridCustom1001ToPlay.Columns[Table.DateBuy].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridCustom1001ToPlay.Columns[Table.DateBuy].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

			dataGridCustom1001ToPlay.RowHeadersWidth = 50;

			for(int i = 0; i < dataGridCustom1001ToPlay.Rows.Count; ++i)
			{
				dataGridCustom1001ToPlay.Rows[i].Cells[Table.DateBuy].Value = GetFreshMeter(dataGridCustom1001ToPlay.Rows[i].Cells[Table.DateBuy].Value.ToString());
			}
		}

		public void ShowGamesInGridAll()
		{
			var query = @"SELECT *  FROM [Main].[Collection].[Games]";

			var gridColumnList = new List<GridColumn>
			{
				new GridColumn(Table.Title),
				new GridColumn(Table.Platform),
				new GridColumn(Table.Client),
				new GridColumn(Table.Year, typeof(int)),
				new GridColumn(Table.DateBuy, typeof(DateTime)),
				new GridColumn(Table.GotFree, typeof(bool))
			};

			dgAll.FillGrid(query, gridColumnList);
		}

		public void ShowGamesInGridToPlay()
		{
			var query = @"	SELECT *
							FROM [Main].[Games].[Plan to play games]
							WHERE [1001] = 0
							order by [HLTB time]";

			var gridColumnList = new List<GridColumn>
			{
				new GridColumn(Table.Title),
				new GridColumn(Table.Platform),
				new GridColumn(Table.Client),
				new GridColumn(Table.Year, typeof(int)),
				new GridColumn(Table.HLTBTime, typeof(int)),
				new GridColumn(Table.DateBuy),
				new GridColumn(Table.ID, typeof(int))
			};

			dataGridCustomToPlay.FillGrid(query, gridColumnList);

			SetHLTBSum();

			dataGridCustomToPlay.Columns[Table.Platform].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dataGridCustomToPlay.Columns[Table.Platform].Width = 40;

			dataGridCustomToPlay.Columns[Table.Client].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dataGridCustomToPlay.Columns[Table.Client].Width = 50;

			dataGridCustomToPlay.Columns[Table.HLTBTime].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridCustomToPlay.Sort(dataGridCustomToPlay.Columns[Table.HLTBTime], ListSortDirection.Ascending);

			dataGridCustomToPlay.Columns[Table.DateBuy].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridCustomToPlay.Columns[Table.DateBuy].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

			dataGridCustomToPlay.RowHeadersWidth = 50;

			for(int i = 0; i < dataGridCustomToPlay.Rows.Count; ++i)
			{
				dataGridCustomToPlay.Rows[i].Cells[Table.DateBuy].Value = GetFreshMeter(dataGridCustomToPlay.Rows[i].Cells[Table.DateBuy].Value.ToString());
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			dataGridCustomToPlay.CellFormatting += DataGridCustomToPlayOnCellFormatting;
			dataGridCustom1001ToPlay.CellFormatting += DataGridCustomToPlayOnCellFormatting;

			ShowGamesInGridAll();
			ShowGamesInGridToPlay();
			ShowGamesInGrid1001ToPlay();
		}

		private static string GetFreshMeter(string dateBuy)
		{
			string freshMeter;

			if(dateBuy == string.Empty)
			{
				freshMeter = "∞";
			}
			else
			{
				var date = Convert.ToDateTime(dateBuy);

				DateTime now = DateTime.Today;
				int age = now.Year - date.Year;

				if(date > now.AddYears(-age) && age != 0)
				{
					age--;
				}

				freshMeter = age.ToString();
			}

			if(freshMeter == "0")
			{
				freshMeter = "*Fresh*";
			}

			return freshMeter;
		}

		private void DataGridCustomToPlayCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var dataGrid = tabControl1.SelectedTab.Controls.Cast<Control>().FirstOrDefault(x => x is DataGridCustom) as DataGridCustom;

			completedGame1.Visible = true;

			var title = dataGrid.Rows[e.RowIndex].Cells[Table.Title].Value.ToString();
			var platform = dataGrid.Rows[e.RowIndex].Cells[Table.Platform].Value.ToString();
			var year = (int)dataGrid.Rows[e.RowIndex].Cells[Table.Year].Value;

			var _1001 = dataGrid == dataGridCustom1001ToPlay;

			completedGame1.SetGameData(title, _1001, platform, year);
		}

		private void DataGridCustomToPlayOnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			(sender as DataGridCustom).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
		}

		private void DataGridCustomToPlaySelectionChanged(object sender, EventArgs e)
		{
			completedGame1.Visible = false;
		}

		private int GetAveragePerYearValue()
		{
			using(var db = new SqlConnection(Resources.MainConnectionString))
			{
				return db.ExecuteScalar<int>(@"	select
												cast(sum(Time)/3 as int) Hours
												from GameEvents
												where Date >= getdate()-(3*365)  -- Last 3 years");
			}
		}

		private void SetHLTBSum()
		{
			int hltbTimeSum = 0;

			for(int i = 0; i < dataGridCustomToPlay.Rows.Count; ++i)
			{
				hltbTimeSum += Convert.ToInt32(dataGridCustomToPlay.Rows[i].Cells[Table.HLTBTime].Value);
			}

			var averagePerYear = GetAveragePerYearValue();
			float yearsToCompletion = hltbTimeSum / (float)averagePerYear;

			labelHLTBtime.Text = $@"HLTB: {hltbTimeSum}h / {hltbTimeSum / 24} days
									Average per year: {averagePerYear}h
									Years to compeltion: {yearsToCompletion.ToString("0.00")}";
		}
	}
}