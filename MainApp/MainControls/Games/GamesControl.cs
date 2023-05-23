using Controller;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Following = Controller.Following;

namespace MainApp.Games
{
	public partial class GamesControl : UserControl
	{
		internal static GamesControl Instance;
		private int m_addingTime;
		private BindingList<Game> m_bindingList;
		private List<GameEvent> m_gameEvents;
		private List<Game> m_games;

		public GamesControl()
		{
			InitializeComponent();

			dataGridViewPlaying.CellFormatting += DataGridView1OnCellFormatting;
		}

		private const int MAX_GAMES_PLAYING = 4;

		private void DataGridView1OnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var playingCount = (dataGridViewPlaying.DataSource as SortableBindingList<GameDaysAgo>).Count;

			if (playingCount > MAX_GAMES_PLAYING)
			{
				dataGridViewPlaying.Rows[e.RowIndex].Cells[nameof(GameDaysAgo.Title)].Style.BackColor = e.RowIndex < (playingCount - MAX_GAMES_PLAYING)
					? Color.Red
					: Color.Empty;
			}
		}

		public static GameDaysAgo ConvertToGameDaysAgo(Game game, IEnumerable<GameEvent> gameEvents)
		{
			var lastDate = gameEvents.Max(o => o.Date).Value;
			var daysAgo = (int)(DateTime.Now - lastDate).TotalDays;

			var time = gameEvents.Sum(o => o.Time);

			return new GameDaysAgo
			{
				ID = game.ID,
				Igdb = game.Igdb,
				Platform = game.Platform,
				Title = game.Title,
				Year = game.Year,
				DaysAgo = daysAgo,
				LastPlayedDate = lastDate,
				Time = Helper.GetFormatedTime(time)
			};
		}

		public void UpdatePlaying()
		{
			dataGridViewPlaying.DataSource = new SortableBindingList<GameDaysAgo>
				(m_games
				.Where(o => Following.FollowingModel.Games.Contains(o.Igdb.ToString()))
				.Select(o => ConvertToGameDaysAgo(o, m_gameEvents.Where(i => i.Igdb == o.Igdb)))
				.OrderBy(o => o.LastPlayedDate)
				.ToList());
		}

		protected override async void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			Instance = this;

			m_games = Datasource.GetList<Game>();
			m_gameEvents = Datasource.GetList<GameEvent>();

			//foreach (var game in m_games)
			//{
			//	var filePath = Path.Combine(Paths.GameCovers, $"{game.Igdb}.png");

			//	if (!File.Exists(filePath))
			//	{
			//		var igdbData = await Igdb.GetDataFromAPIAsync(game.Igdb);
			//	}
			//}

			yearFilter1.SetValueChangedEvent(NumericUpDownYearFilter_ValueChanged);

			UpdatePlaying();

			SetGrid(dataGridViewGames);
			SetGridPlaying(dataGridViewPlaying);
			dataGridViewGames.SelectLastRow();
		}

		private void ButtonUpdate_Click(object sender, EventArgs e)
		{
			var game = gameInfo.GetItem();

			bool isAdd = false;

			if (!m_games.Any(o => o.Igdb == game.Igdb && o.Platform == game.Platform))
			{
				Datasource.Add(game);
				m_games.Add(game);
				m_bindingList.Add(game);
				isAdd = true;
			}

			var gameEvent = gameInfo.GetEvent();
			gameEvent.Igdb = game.Igdb;
			gameEvent.Date = DateTime.Now;
			gameEvent.Time = m_addingTime;

			Datasource.Add(gameEvent);
			m_gameEvents.Add(gameEvent);

			if (isAdd)
			{
				dataGridViewGames.SelectLastRow();
			}

			UpdatePlaying();

			gameInfo.Fill(game, m_gameEvents.Where(o => o.Igdb == game.Igdb).ToList());

			textBoxIgdb.TextChanged -= TextBoxIgdb_TextChanged;
			textBoxIgdb.Clear();
			textBoxIgdb.TextChanged += TextBoxIgdb_TextChanged;

			checkBoxTotalTime.Checked = true;
		}

		private void CheckBoxTotalTime_CheckedChanged(object sender, EventArgs e)
		{
			var game = gameInfo.GetItem();

			var game1 = Controller.Games.GetInfo(game, m_gameEvents.Where(o => o.Igdb == game.Igdb).ToList());
			var hours = game1.Time / 60;
			var minutes = game1.Time % 60;

			if (!checkBoxTotalTime.Checked)
			{
				hours = 0;
				minutes = 0;
			}

			numericUpDownMinutes.Value = minutes;
			numericUpDownHours.Value = hours;
		}

		private void DataGridViewGames_SelectionChanged(object sender, EventArgs e)
		{
			var game = (sender as DataGridView).GetRowObject<Game>();

			if (game == null)
			{
				return;
			}

			gameInfo.Fill(game, m_gameEvents.Where(o => o.Igdb == game.Igdb).ToList());

			var game1 = Controller.Games.GetInfo(game, m_gameEvents.Where(o => o.Igdb == game.Igdb).ToList());
			var hours = game1.Time / 60;
			var minutes = game1.Time % 60;

			if (!checkBoxTotalTime.Checked)
			{
				hours = 0;
				minutes = 0;
			}

			numericUpDownMinutes.Value = minutes;
			numericUpDownHours.Value = hours;
		}

		private void NumericUpDownTime_ValueChanged(object sender, EventArgs e)
		{
			var beforeTime = 0;

			var game = gameInfo.GetItem();

			var game1 = Controller.Games.GetInfo(game, m_gameEvents.Where(o => o.Igdb == game.Igdb).ToList());

			beforeTime = game1.Time;

			if (!checkBoxTotalTime.Checked)
			{
				m_addingTime = (int)numericUpDownMinutes.Value + (int)numericUpDownHours.Value * 60;
			}
			else
			{
				m_addingTime = (int)numericUpDownMinutes.Value + (int)numericUpDownHours.Value * 60 - beforeTime;
			}

			var hours = m_addingTime / 60;
			var minutes = m_addingTime % 60;

			var hoursFormat = hours == 0
				 ? string.Empty
				 : $"{hours}h";

			var minutesFormat = minutes == 0
				? string.Empty
				: $"{minutes}min";

			labelAddingTime.Text = m_addingTime == 0
				? string.Empty
				: $"Adding {hoursFormat} {minutesFormat} time";
		}

		private void NumericUpDownYearFilter_ValueChanged(object sender, EventArgs e)
		{
			var thisYear = m_gameEvents.Where(m => m.Date.HasValue && m.Date.Value.Year == (sender as NumericUpDown).Value).ToList();

			var bind = new List<Game>();

			foreach (var me in thisYear)
			{
				var m = m_games.FirstOrDefault(o => o.Igdb == me.Igdb);
				bind.Add(m);
			}

			dataGridViewGames.DataSource = m_bindingList = new SortableBindingList<Game>(bind.Distinct().ToList());
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[] {
			nameof(Game.Title),
			nameof(Game.Year),
			nameof(Game.Platform)});

			dataGridView.Columns[nameof(Game.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Game.Platform)].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			dataGridView.Columns[nameof(Game.Year)].CenterColumn();
		}

		private void SetGridPlaying(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[] {
			nameof(GameDaysAgo.Title),
			nameof(GameDaysAgo.Year),
			nameof(GameDaysAgo.Platform),
			nameof(GameDaysAgo.DaysAgo),
			nameof(GameDaysAgo.Time),
			nameof(GameDaysAgo.LastPlayedDate)});

			dataGridView.Columns[nameof(GameDaysAgo.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(GameDaysAgo.Platform)].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			dataGridView.Columns[nameof(GameDaysAgo.Year)].CenterColumn();
			dataGridView.Columns[nameof(GameDaysAgo.DaysAgo)].CenterColumn();
			dataGridView.Columns[nameof(GameDaysAgo.Time)].CenterColumn();
			dataGridView.Columns[nameof(GameDaysAgo.LastPlayedDate)].Visible = false;
		}

		private async void TextBoxIgdb_TextChanged(object sender, EventArgs e)
		{
			var url = textBoxIgdb.Text;

			var igdbData = await Igdb.GetDataFromAPIAsync(url);

			var game = new Game
			{
				Platform = "PC",
				Igdb = igdbData.Igdb,
				Title = igdbData.Title,
				Year = igdbData.Year
			};

			gameInfo.Fill(game, null);
		}
	}
}