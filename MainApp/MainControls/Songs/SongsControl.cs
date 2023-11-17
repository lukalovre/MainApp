using Controller;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.MainControls.Zoo
{
	public partial class SongsControl : UserControl
	{
		private List<Song> m_songs;
		private List<SongEvent> m_songEvents;

		public SongsControl()
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

			LoadGridData();
			SetGrid(dataGridViewAll);
			dataGridViewAll.SelectLastRow();
			addButton1.SetAddButton(ButtonAdd_Click);
		}

		private void LoadGridData()
		{
			m_songs = Datasource.GetList<Song>();
			m_songEvents = Datasource.GetList<SongEvent>();

			dataGridViewAll.DataSource = new SortableBindingList<SongGrid>(m_songs
				.Select(o => Converter.ToSongGrid(o, m_songEvents.Where(item => o.ID == item.ItemID)))
				.OrderBy(o => o.LastHeard)
				.ToList());
		}

		private void CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == -1)
			{
				LoadGridData();
			}
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetGrid();

			dataGridView.Columns[nameof(SongGrid.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(SongGrid.Artist)].Width = 130;
			dataGridView.Columns[nameof(SongGrid.Year)].CenterColumn();

			dataGridView.CellClick -= CellClick;
			dataGridView.CellClick += CellClick;
			dataGridView.SelectionChanged -= DataGridView_SelectionChanged;
			dataGridView.SelectionChanged += DataGridView_SelectionChanged;
			dataGridView.DoubleClick -= new EventHandler(DataGridView_DoubleClick);
			dataGridView.DoubleClick += new EventHandler(DataGridView_DoubleClick);
		}

		private void DataGridView_DoubleClick(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<SongGrid>();

			if (item == null)
			{
				return;
			}

			var link = m_songs.FirstOrDefault(o => o.ID == item.ID).Link;

			Web.OpenLink(link);
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<SongGrid>();

			if (item == null)
			{
				return;
			}

			songInfoControl.Fill(m_songs.FirstOrDefault(o => o.ID == item.ID), m_songEvents.Where(o => o.ItemID == item.ID));
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var item = songInfoControl.GetItem();

			if (!m_songs.Any(o => o.Artist.Trim() == item.Artist.Trim() && o.Title.Trim() == item.Title.Trim()))
			{
				item.ID = 0;
				Datasource.Add(item);
				m_songs.Add(item);
			}

			var @event = songInfoControl.GetEvent();
			@event.ItemID = item.ID;
			@event.Date = addButton1.GetDate().Value;

			Datasource.Add(@event);
			m_songEvents.Add(@event);

			LoadGridData();
			songInfoControl.Fill(item, m_songEvents.Where(o => o.ItemID == item.ID));
			dataGridViewAll.SelectLastRow();
		}

		private void TextBoxInput_TextChanged(object sender, EventArgs e)
		{
			var urlText = textBoxInput.Text;

			if (string.IsNullOrWhiteSpace(urlText))
			{
				return;
			}

			var youtubeSongData = Links.GetYouTubeSongData(urlText);

			var item = new Song
			{
				Artist = youtubeSongData.Artist,
				Title = youtubeSongData.Title,
				Link = youtubeSongData.Link,
				Year = youtubeSongData.Year,
				Runtime = youtubeSongData.Runtime
			};

			songInfoControl.Fill(item, null);

			textBoxInput.Clear();
		}
	}
}