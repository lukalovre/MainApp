using Controller;
using Model.Collection;
using Model.Grid;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Collection.Games
{
	public partial class GamesControl : UserControl
	{
		private SortableBindingList<CollectionGames> m_bindable;
		private List<Game> m_games;
		private List<Model.dbo.Game> m_gamesPlayed;

		public GamesControl()
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

			dataGridViewUnplayed.CellFormatting += DataGridCustomToPlayOnCellFormatting;

			LoadGridData();

			SetGrid(dataGridViewAll);
			SetGrid(dataGridViewUnplayed);

			dataGridViewAll.SelectLastRow();
		}

		private void LoadGridData()
		{
			m_games = Datasource.GetList<Game>();

			m_bindable = new SortableBindingList<CollectionGames>(m_games
				.OrderBy(o => o.Date)
				.Select(o => Converter.ToCollectionGames(o))
				.ToList());
			dataGridViewAll.DataSource = m_bindable;

			m_gamesPlayed = Datasource.GetList<Model.dbo.Game>();

			dataGridViewUnplayed.DataSource = new SortableBindingList<CollectionGames>(m_games
				.Where(o => !m_gamesPlayed.Any(p => p.Igdb == o.Igdb))
				.DistinctBy(o => o.Igdb)
				.OrderBy(o => o.Year)
				.Select(o => Converter.ToCollectionGames(o))
				.ToList());
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var item = gameInfo.GetItem();
			item.Date = DateTime.Now;

			Datasource.Add(item);
			m_bindable.Add(Converter.ToCollectionGames(item));
			m_games.Add(item);
			dataGridViewAll.SelectLastRow();

			textBoxIgdbUrl.TextChanged -= TextBoxIgdbUrl_TextChanged;
			textBoxIgdbUrl.Clear();
			textBoxIgdbUrl.TextChanged += TextBoxIgdbUrl_TextChanged;
		}

		private void ButtonOpenLink_Click(object sender, EventArgs e)
		{
			var game = gameInfo.GetItem();

			if (game == null)
			{
				return;
			}

			var titleForSearch = game.Title.Replace(' ', '+');
			var searchTerm = $"https://www.igdb.com/search?type=1&q={titleForSearch}";

			Web.OpenLink(searchTerm);
		}

		private void DataGridCustomToPlayOnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			(sender as DataGridView).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var game = (sender as DataGridView).GetRowObject<CollectionGames>();

			if (game == null)
			{
				return;
			}

			gameInfo.Fill(m_games.FirstOrDefault(o => o.ID == game.ID));
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.Columns[nameof(CollectionGames.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(CollectionGames.Year)].CenterColumn();
			dataGridView.Columns[nameof(CollectionGames.Platform)].CenterColumn();
			dataGridView.Columns[nameof(CollectionGames.HLTB)].CenterColumn();
			dataGridView.Columns[nameof(CollectionGames.Freshnes)].CenterColumn();

			dataGridView.CellClick += CellClick;
		}

		private void CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == -1)
			{
				LoadGridData();
			}
		}

		private async void TextBoxIgdbUrl_TextChanged(object sender, EventArgs e)
		{
			var url = textBoxIgdbUrl.Text;

			var igdbData = await Igdb.GetDataFromAPIAsync(url, downloadPoster: false);

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