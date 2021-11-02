using Controller;
using Model;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Following = Controller.Following;

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

		public void UpdatePlaying()
		{
			dataGridViewPlaying.DataSource = new SortableBindingList<GameDaysAgo>
				(m_games
				.Where(o => Following.FollowingModel.Games.Contains(o.Igdb.ToString()))
				.Select(o => Igdb.ConvertToGameDaysAgo(o, m_gameEvents.Where(i => i.Igdb == o.Igdb)))
				.OrderByDescending(o => o.DaysAgo)
				.ToList());
		}

		protected override async void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			m_games = Database.GetList<Game>();
			m_gameEvents = Database.GetList<GameEvent>();

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
			UpdateIgdbLists();

			SetGrid(dataGridViewGames);
			SetGridPlaying(dataGridViewPlaying);
			SetGridIgdbList(dataGridView1001);
			SetGridIgdbList(dataGridViewCanon);
			SetGridIgdbList(dataGridViewWiki);
			SetGridIgdbList(dataGridViewMetacritic);
			SetGridIgdbList(dataGridViewZP);
			SetGridIgdbList(dataGridViewBlow);
			SetGridIgdbList(dataGridViewMcNelly);
			SetGridIgdbListGOTY(dataGridViewGOTY);

			dataGridViewGames.SelectLastRow();
		}

		private void ButtonUpdate_Click(object sender, EventArgs e)
		{
			var game = gameInfo.GetItem();

			bool isAdd = false;

			if (!m_games.Any(o => o.Igdb == game.Igdb && o.Platform == game.Platform))
			{
				Database.Add(game);
				m_games.Add(game);
				m_bindingList.Add(game);
				isAdd = true;
			}

			var gameEvent = gameInfo.GetEvent();
			gameEvent.Igdb = game.Igdb;
			gameEvent.Date = DateTime.Now;

			Database.Add(gameEvent);
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
		}

		private void DataGridViewGames_SelectionChanged(object sender, EventArgs e)
		{
			var game = (sender as DataGridView).GetRowObject<Game>();

			if (game == null)
			{
				return;
			}

			gameInfo.Fill(game, m_gameEvents.Where(o => o.Igdb == game.Igdb).ToList());
		}

		private SortableBindingList<Game1001> GetGamesFromCsv(string listFolderPath, string listName)
		{
			return new SortableBindingList<Game1001>(
				CsvHelper.GetFromList<IgdbListItem>(listFolderPath, listName)
				.Where(o => !m_games.Any(g => g.Igdb == o.id) && !Igdb.AlternativeVersions.Keys.Contains(o.id))
				.Select(o => Igdb.ConvertToGame1001(o))
				.ToList());
		}

		private SortableBindingList<GameGOTY> GetGamesFromCsvMerged(string listsFolder)
		{
			return new SortableBindingList<GameGOTY>(
				Igdb.GetFromListsMerged(listsFolder)
				.Where(o => !m_games.Any(g => g.Igdb == o.id))
				.Select(o => Igdb.ConvertToGameGOTY(Igdb.ConvertToGame1001(o)))
				.ToList());
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

		private void SetGridIgdbList(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[] {
			nameof(Game1001.Title),
			nameof(Game1001.Year),
			nameof(Game1001._1001)});

			dataGridView.Columns[nameof(Game1001._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(Game1001._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(Game1001.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Game1001.Year)].CenterColumn();
		}

		private void SetGridIgdbListGOTY(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[] {
			nameof(GameGOTY.Title),
			nameof(GameGOTY.Year),
			nameof(GameGOTY._1001),
			nameof(GameGOTY.GOTY)});

			dataGridView.Columns[nameof(GameGOTY._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(GameGOTY._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(GameGOTY.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(GameGOTY.Year)].CenterColumn();
			dataGridView.Columns[nameof(GameGOTY.GOTY)].CenterColumn();
		}

		private void SetGridPlaying(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[] {
			nameof(GameDaysAgo.Title),
			nameof(GameDaysAgo.Year),
			nameof(GameDaysAgo.Platform),
			nameof(GameDaysAgo.DaysAgo)});

			dataGridView.Columns[nameof(GameDaysAgo.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(GameDaysAgo.Platform)].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			dataGridView.Columns[nameof(GameDaysAgo.Year)].CenterColumn();
			dataGridView.Columns[nameof(GameDaysAgo.DaysAgo)].CenterColumn();
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

		private void UpdateIgdbLists()
		{
			dataGridView1001.DataSource = GetGamesFromCsv(Paths.Igdb, "1001-video-games-you-must-play-before-you-die");
			dataGridViewCanon.DataSource = GetGamesFromCsv(Paths.Igdb, "the-video-game-canon-the-top-100");
			dataGridViewWiki.DataSource = GetGamesFromCsv(Paths.Igdb, "list-of-video-games-considered-the-best");
			dataGridViewMetacritic.DataSource = GetGamesFromCsv(Paths.Igdb, "metacritic-top-100-2021");
			dataGridViewZP.DataSource = GetGamesFromCsv(Paths.Igdb, "zero-punctuation-goty");
			dataGridViewBlow.DataSource = GetGamesFromCsv(Paths.Igdb, "johnathan-blows-steam-curation");
			dataGridViewMcNelly.DataSource = GetGamesFromCsv(Paths.Igdb, "seumas-mcnally-grand-prize");
			dataGridViewGOTY.DataSource = GetGamesFromCsvMerged("GOTY");
		}
	}
}