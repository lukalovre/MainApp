using Controller;
using Model.dbo;
using Model.Grid;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.StatsControls.SummaryControls
{
	public partial class GameSummaryControl : UserControl
	{
		private List<ItemCard> m_itemCardList = new List<ItemCard>();

		public GameSummaryControl()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			numericUpDownStartYear.Value = DateTime.Now.Year;
			numericUpDownEndYear.Value = DateTime.Now.Year;

			trackBarStars.Value = 3;
			trackBarTime.Value = 1;

			Load((int)numericUpDownStartYear.Value, (int)numericUpDownEndYear.Value);
		}

		private void Load(int startYear, int endYear)
		{
			var startDate = new DateTime(startYear, 1, 1, 0, 0, 0);
			var endDate = new DateTime(endYear, 12, 31, 23, 59, 59);

			var gameList = Datasource.GetList<Game>();
			var gameEventList = Datasource.GetList<GameEvent>();

			var gameEventListDateRange = gameEventList.Where(o => o.Date >= startDate && o.Date <= endDate);
			var gameEventListBefore = gameEventList.Where(o => o.Date < startDate);

			labelGamesPlayed.Text = gameEventListDateRange.DistinctBy(o => o.Igdb).Count().ToString();
			labelHoursPlayed.Text = TimeHelper.GetFormatedTime(gameEventListDateRange.Sum(o => o.Time));

			var newGamesList = gameEventListDateRange.DistinctBy(o => o.Igdb).Where(o => !gameEventListBefore.Any(b => b.Igdb == o.Igdb));
			var oldGamesList = gameEventListDateRange.DistinctBy(o => o.Igdb).Where(o => gameEventListBefore.Any(b => b.Igdb == o.Igdb));

			labelNewGames.Text = newGamesList.Count().ToString();
			labelOldGames.Text = oldGamesList.Count().ToString();

			var newGamesUnder1h = new List<int>();

			foreach (var newGame in newGamesList)
			{
				var newGameTime = gameEventListDateRange.Where(o => o.Igdb == newGame.Igdb).Sum(o => o.Time);

				if (newGameTime < 60)
				{
					newGamesUnder1h.Add(newGame.Igdb);
				}
			}

			labelGamesUnder1h.Text = newGamesUnder1h.Count().ToString();

			LoadGamesGrid(gameEventListDateRange.ToList());

			dataGridView.SetGrid(setLocation: false);
			dataGridView.CellClick -= CellClick;
			dataGridView.CellClick += CellClick;

			dataGridView.Columns[nameof(GameGrid.Rating)].CenterColumn();
			dataGridView.Columns[nameof(GameGrid.Completed)].CenterColumn();
			dataGridView.Columns[nameof(GameGrid.TimeMinutes)].Visible = false;
			dataGridView.Columns[nameof(GameGrid.Platform)].CenterColumn();
			dataGridView.Columns[nameof(GameGrid.Time)].CenterColumn();
			dataGridView.Columns[nameof(GameGrid.Time)].SortMode = DataGridViewColumnSortMode.Programmatic;
		}

		private void LoadGamesGrid(List<GameEvent> gameEventListDateRange)
		{
			var events = Datasource.GetList<GameEvent>();

			dataGridView.DataSource = new SortableBindingList<GameGrid>(
				Datasource.GetList<Game>()
				.Select(o => Convert(o, gameEventListDateRange))
				.Where(o => o != null)
				.Where(o => o != null && o.Rating >= trackBarStars.Value && o.TimeMinutes >= trackBarTime.Value * 60)
				.OrderBy(o => o.LastPlayedDate)
				.ToList());
		}

		private void CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == -1)
			{
				var startYear = (int)numericUpDownStartYear.Value;
				var endYear = (int)numericUpDownEndYear.Value;
				var startDate = new DateTime(startYear, 1, 1, 0, 0, 0);
				var endDate = new DateTime(endYear, 12, 31, 23, 59, 59);
				var gameEventList = Datasource.GetList<GameEvent>();
				var gameEventListDateRange = gameEventList.Where(o => o.Date >= startDate && o.Date <= endDate);
				LoadGamesGrid(gameEventListDateRange.ToList());
			}

			if (e.RowIndex == -1 && e.ColumnIndex == dataGridView.Columns[nameof(GameGrid.Time)].Index)
			{
				var columntTimesMinutes = dataGridView.Columns[nameof(GameGrid.TimeMinutes)];

				var direction = columntTimesMinutes.HeaderCell.SortGlyphDirection == SortOrder.Ascending
					? ListSortDirection.Descending
					: ListSortDirection.Ascending;

				dataGridView.Sort(columntTimesMinutes, direction);
			}
		}

		private GameGrid Convert(Game game, List<GameEvent> events)
		{
			var gameEvents = events.Where(o => o.Igdb == game.Igdb);

			if (!gameEvents.Any())
			{
				return null;
			}

			var timeMinutes = gameEvents.Sum(o => o.Time);

			return new GameGrid
			{
				ID = game.ID,
				Igdb = game.Igdb,
				Platform = game.Platform,
				Title = game.Title,
				Year = game.Year,
				TimeMinutes = timeMinutes,
				Time = TimeHelper.GetFormatedTime(timeMinutes),
				LastPlayedDate = gameEvents.Max(o => o.Date).Value,
				Completed = gameEvents.Any(o => o.Completed),
				Rating = gameEvents.MaxBy(o => o.Date).FirstOrDefault().Rating.Value
			};
		}

		private void NumericUpDownYear_ValueChanged(object sender, EventArgs e)
		{
			if (checkBoxLock.Checked)
			{
				numericUpDownEndYear.ValueChanged -= NumericUpDownYear_ValueChanged;
				numericUpDownEndYear.Value = (int)numericUpDownStartYear.Value;
				numericUpDownEndYear.ValueChanged += NumericUpDownYear_ValueChanged;
			}

			Load((int)numericUpDownStartYear.Value, (int)numericUpDownEndYear.Value);
			CheckBox1_CheckedChanged(null, null);
		}

		private void TrackBarStars_Scroll(object sender, EventArgs e)
		{
			var startYear = (int)numericUpDownStartYear.Value;
			var endYear = (int)numericUpDownEndYear.Value;
			var startDate = new DateTime(startYear, 1, 1, 0, 0, 0);
			var endDate = new DateTime(endYear, 12, 31, 23, 59, 59);
			var gameEventList = Datasource.GetList<GameEvent>();
			var gameEventListDateRange = gameEventList.Where(o => o.Date >= startDate && o.Date <= endDate);

			dataGridView.DataSource = new SortableBindingList<GameGrid>(
			Datasource.GetList<Game>()
			.Select(o => Convert(o, gameEventListDateRange.ToList()))
			.Where(o => o != null && o.Rating >= trackBarStars.Value && o.TimeMinutes >= trackBarTime.Value * 60)
			.OrderBy(o => o.Rating)
			.ToList());
		}

		private void TrackBarTime_Scroll(object sender, EventArgs e)
		{
			var startYear = (int)numericUpDownStartYear.Value;
			var endYear = (int)numericUpDownEndYear.Value;
			var startDate = new DateTime(startYear, 1, 1, 0, 0, 0);
			var endDate = new DateTime(endYear, 12, 31, 23, 59, 59);
			var gameEventList = Datasource.GetList<GameEvent>();
			var gameEventListDateRange = gameEventList.Where(o => o.Date >= startDate && o.Date <= endDate);

			dataGridView.DataSource = new SortableBindingList<GameGrid>(
			Datasource.GetList<Game>()
			.Select(o => Convert(o, gameEventListDateRange.ToList()))
			.Where(o => o != null && o.Rating >= trackBarStars.Value && o.TimeMinutes >= trackBarTime.Value * 60)
			.OrderBy(o => o.TimeMinutes)
			.ToList());
		}

		private void TrackBarStars_ValueChanged(object sender, EventArgs e)
		{
			labelRating.Text = $"Rating >= {trackBarStars.Value}";
		}

		private void TrackBarTime_ValueChanged(object sender, EventArgs e)
		{
			labelPlaytime.Text = $"Playtime >= {trackBarTime.Value}h";
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			dataGridView.Visible = !checkBox1.Checked;

			var offsetX = 10;
			var offsetY = 10;
			var maxPerRow = 5;

			if (checkBox1.Checked)
			{
				m_itemCardList.ForEach(o => Controls.Remove(o));
				m_itemCardList.Clear();

				SortableBindingList<GameGrid> list = (dataGridView.DataSource as SortableBindingList<GameGrid>);
				for (int i = 0; i < list.Count; i++)
				{
					GameGrid item = list[i];

					var x = i % maxPerRow;
					var y = i / maxPerRow;

					var itemCard = new ItemCard();
					itemCard.ImagePath = Path.Combine(Paths.GameCovers, $"{item.Igdb}.png");
					itemCard.Location = new System.Drawing.Point(
						dataGridView.Location.X + (itemCard.Width + offsetX) * x,
						dataGridView.Location.Y + (itemCard.Height + offsetY) * y);
					Controls.Add(itemCard);
					m_itemCardList.Add(itemCard);
				}
			}
		}
	}
}