using Controller;
using Model.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Collection.Games
{
	public partial class GamesControl : UserControl
	{
		private SortableBindingList<Game> m_bindable;
		private List<Game> m_games;

		public GamesControl()
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

			dataGridViewToPlay.CellFormatting += DataGridCustomToPlayOnCellFormatting;
			dataGridView1001ToPlay.CellFormatting += DataGridCustomToPlayOnCellFormatting;

			m_games = Database.GetList<Game>();

			m_bindable = new SortableBindingList<Game>(m_games);
			dataGridViewAll.DataSource = m_bindable;

			dataGridViewToPlay.DataSource = new SortableBindingList<Game>(m_games
				.Where(o => Following.FollowingModel.GamesCollection.Contains(o.ID.ToString())
				&& !Igdb.Is1001(o.Igdb))
				.OrderBy(o => o.HLTB)
				.ToList());

			dataGridView1001ToPlay.DataSource = new SortableBindingList<Game>(m_games
				.Where(o => Following.FollowingModel.GamesCollection.Contains(o.ID.ToString())
				&& Igdb.Is1001(o.Igdb))
				.OrderBy(o => o.HLTB)
				.ToList());

			SetGridAll(dataGridViewAll);
			SetGridToPlay(dataGridViewToPlay);
			SetGridToPlay(dataGridView1001ToPlay);
		}

		private static string GetFreshMeter(string dateBuy)
		{
			string freshMeter;

			if (dateBuy == string.Empty)
			{
				freshMeter = "∞";
			}
			else
			{
				var date = Convert.ToDateTime(dateBuy);

				DateTime now = DateTime.Today;
				int age = now.Year - date.Year;

				if (date > now.AddYears(-age) && age != 0)
				{
					age--;
				}

				freshMeter = age.ToString();
			}

			if (freshMeter == "0")
			{
				freshMeter = "*Fresh*";
			}

			return freshMeter;
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var item = gameInfo.GetItem();
			item.Date = DateTime.Now;

			Database.Add(item);
			m_bindable.Add(item);
			dataGridViewAll.SelectLastRow();

			textBoxIgdbUrl.TextChanged -= TextBoxIgdbUrl_TextChanged;
			textBoxIgdbUrl.Clear();
			textBoxIgdbUrl.TextChanged += TextBoxIgdbUrl_TextChanged;
		}

		private void DataGridCustomToPlayOnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			(sender as DataGridView).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var game = (sender as DataGridView).GetRowObject<Game>();

			if (game == null)
			{
				return;
			}

			gameInfo.Fill(game);
		}

		private int GetAveragePerYearValue()
		{
			return Database.ExecuteScalar<int>(@"	select
												cast(sum(Time)/3 as int) Hours
												from GameEvents
												where Date >= getdate()-(3*365)  -- Last 3 years");
		}

		private void SetGridAll(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[]{
			nameof(Game.Title),
			nameof(Game.Year)});

			dataGridView.Columns[nameof(Game.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Game.Year)].CenterColumn();
		}

		private void SetGridToPlay(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[]{
			nameof(Game.Title),
			nameof(Game.Year),
			nameof(Game.Platform),
			nameof(Game.HLTB)});

			dataGridView.Columns[nameof(Game.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Game.Year)].CenterColumn();
			dataGridView.Columns[nameof(Game.Platform)].CenterColumn();
			dataGridView.Columns[nameof(Game.HLTB)].CenterColumn();
		}

		private void SetHLTBSum()
		{
			//int hltbTimeSum = 0;

			//for(int i = 0; i < dataGridCustomToPlay.Rows.Count; ++i)
			//{
			//	hltbTimeSum += Convert.ToInt32(dataGridCustomToPlay.Rows[i].Cells[Table.HLTBTime].Value);
			//}

			//var averagePerYear = GetAveragePerYearValue();
			//float yearsToCompletion = hltbTimeSum / (float)averagePerYear;

			//labelHLTBtime.Text = $@"HLTB: {hltbTimeSum}h / {hltbTimeSum / 24} days
			//						Average per year: {averagePerYear}h
			//						Years to completion: {yearsToCompletion.ToString("0.00")}";
		}

		private async void TextBoxIgdbUrl_TextChanged(object sender, EventArgs e)
		{
			var url = textBoxIgdbUrl.Text;

			var igdbData = await Igdb.GetDataFromAPIAsync(url);

			var game = new Game
			{
				Platform = "PC",
				Igdb = igdbData.Igdb,
				Title = igdbData.Title,
				Year = igdbData.Year
			};

			gameInfo.Fill(game);
		}
	}
}