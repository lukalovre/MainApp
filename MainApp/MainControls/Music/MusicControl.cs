using Controller;
using Controller.Extensions;
using Model;
using Model.dbo;
using Model.Grid;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Musics
{
	public partial class MusicControl : UserControl
	{
		private SortableBindingList<MusicIn> m_bindingList;
		private List<MusicEvent> m_musicEvents;
		private SortableBindingList<MusicIn> m_musicIn;
		private List<Music> m_musics;

		public MusicControl()
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

			m_musics = Datasource.GetList<Music>();

			////////////////////////

			//foreach(var item in m_musics)
			//{
			//	try
			//	{
			//		Controller.Musics.FindAlbum(item);
			//	}
			//	catch
			//	{
			//		Thread.Sleep(5000);
			//	}
			//}

			///////////////////

			LoadGridData();

			SetGrid(dataGridViewAll);
			SetGrid(dataGridViewIn);
			SetGrid(dataGridViewTodo2);
			SetGrid(dataGridViewTodo1);
			SetGrid(dataGridViewYearList);

			dataGridViewAll.SelectLastRow();

			musicInfo1.ArtistTextChanged += new MusicInfoControl.ArtistTextChangedDelegate(ArtistTextChanged);
			musicInfo1.TitleTextChanged += new MusicInfoControl.TitleTextChangedDelegate(TitleTextChanged);

			addButton1.SetAddButton(ButtonAdd_Click);
		}

		private void LoadGridData()
		{
			m_musicEvents = Datasource.GetList<MusicEvent>();

			m_musicIn = new SortableBindingList<MusicIn>(m_musics.Where(o => m_musicEvents.Where(ev => ev.ItemID == o.ItemID).MaxBy(i => i.Date).FirstOrDefault().In)
				.Select(o => Controller.Musics.ConvertToMusicIn(o, m_musicEvents))
				.ToList());

			var thisDay = m_musicEvents.Where(m => m.Date.HasValue && m.Date.Value.Date >= DateTime.Today.AddDays(-5)).ToList();

			var bind = new List<Music>();

			foreach (var me in thisDay)
			{
				var m = m_musics.FirstOrDefault(o => o.ItemID == me.ItemID);
				bind.Add(m);
			}

			dataGridViewAll.DataSource = m_bindingList = new SortableBindingList<MusicIn>(bind.Distinct()
				.Select(o => Controller.Musics.ConvertToMusicIn(o, m_musicEvents))
				.ToList());

			dataGridViewYearList.DataSource = new SortableBindingList<MusicIn>(m_musicIn.Where(o => o.Year == DateTime.Today.Year).ToList());

			dataGridViewIn.DataSource = new SortableBindingList<MusicIn>(m_musicIn.ToList().OrderBy(o => o.Count).ToList());
			dataGridViewTodo2.DataSource = new SortableBindingList<MusicIn>(m_musicIn.Where(o => m_musicEvents.Where(ev => ev.ItemID == o.ItemID).Max(i => i.Date).Value <= DateTime.Now.AddYears(-2)).ToList());
			dataGridViewTodo1.DataSource = new SortableBindingList<MusicIn>(m_musicIn.Where(o => m_musicEvents.Where(ev => ev.ItemID == o.ItemID).Max(i => i.Date).Value <= DateTime.Now.AddYears(-1)).ToList());
		}

		private void ArtistTextChanged(string artist)
		{
			dataGridViewAll.SelectionChanged -= DataGridView_SelectionChanged;
			dataGridViewAll.DataSource = new SortableBindingList<MusicIn>(m_musics.Where(o => o.Artist.Contains(artist, StringComparison.OrdinalIgnoreCase))
				.Select(o => Controller.Musics.ConvertToMusicIn(o, m_musicEvents))
				.ToList());
			dataGridViewAll.SelectionChanged += DataGridView_SelectionChanged;

			checkBoxNew.Checked = true;
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var music = musicInfo1.GetInfo();

			if (music.ItemID == 0 || checkBoxNew.Checked)
			{
				music.ItemID = m_musicEvents.Max(o => o.ItemID) + 1;
			}

			if (checkBoxNew.Checked)
			{
				music.SpotifyID = null;
			}

			if (!m_musicEvents.Any(o => o.ItemID == music.ItemID))
			{
				Datasource.Add(music);
				m_musics.Add(music);
			}

			var musicEvent = musicInfo1.GetEvent();
			musicEvent.ItemID = music.ItemID;
			musicEvent.Date = addButton1.GetDate();

			Datasource.Add(musicEvent);
			m_musicEvents.Add(musicEvent);
			m_bindingList.Add(Controller.Musics.ConvertToMusicIn(music, m_musicEvents));

			if (!string.IsNullOrWhiteSpace(music.SpotifyID))
			{
				var sourceFile = $"{Paths.TempAlbumCover}.png";
				var destinationFile = Path.Combine(Paths.Albums, $"{music.ItemID}.png");
				File.Copy(sourceFile, destinationFile);
				File.Delete(sourceFile);
			}

			musicInfo1.Fill(music, m_musicEvents.Where(o => o.ItemID == music.ItemID).ToList());
			ArtistTextChanged(music.Artist);
		}

		private void ButtonListenAgain_Click(object sender, EventArgs e)
		{
			var musicEvent = musicInfo1.GetEvent();
			musicEvent.Date = addButton1.GetDate();

			m_musicEvents.Add(musicEvent);
			Datasource.Add(musicEvent);

			var musicIn = m_musicIn.FirstOrDefault(o => o.ItemID == musicEvent.ItemID);

			if (!musicEvent.In)
			{
				m_musicIn.Remove(musicIn);

				(dataGridViewIn.DataSource as SortableBindingList<MusicIn>).Remove(musicIn);
				(dataGridViewYearList.DataSource as SortableBindingList<MusicIn>).Remove(musicIn);
				(dataGridViewTodo2.DataSource as SortableBindingList<MusicIn>).Remove(musicIn);
			}
			else
			{
				var item = m_musicIn.FirstOrDefault(o => o.ItemID == musicEvent.ItemID);
				if (item != null)
				{
					item.Count++;
					dataGridViewIn.Refresh();
				}
			}

			musicInfo1.Fill(m_musics.FirstOrDefault(o => o.ItemID == musicEvent.ItemID), m_musicEvents.Where(o => o.ItemID == musicEvent.ItemID).ToList());
		}

		private void ButtonLoad_Click(object sender, EventArgs e)
		{
			var music = Controller.Musics.LoadLocal();

			musicInfo1.Fill(music, m_musicEvents.Where(o => o.ItemID == music.ItemID).ToList());
			ArtistTextChanged(music.Artist);
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			var music = musicInfo1.GetInfo();
			Controller.Musics.SaveLocal(music);
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<IItemID>();

			if (item == null)
			{
				return;
			}

			musicInfo1.Fill(m_musics.FirstOrDefault(o => o.ItemID == item.ItemID), m_musicEvents.Where(o => o.ItemID == item.ItemID).ToList());

			checkBoxNew.Checked = false;
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

			dataGridView.Columns[nameof(MusicIn.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(MusicIn.Artist)].Width = 130;
			dataGridView.Columns[nameof(MusicIn.Count)].Width = 30;
			dataGridView.Columns[nameof(MusicIn.Count)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
			dataGridView.Columns[nameof(MusicIn.Year)].CenterColumn();
			dataGridView.Columns[nameof(MusicIn.Runtime)].CenterColumn();
			dataGridView.Columns[nameof(MusicIn.In)].CenterColumn();

			dataGridView.CellClick += CellClick;
		}

		private void TextBoxAutofill_DragDrop(object sender, DragEventArgs e)
		{
			var dropedText = e.Data.GetData(DataFormats.Text).ToString();

			var music = Controller.Musics.GetAlbumInfoSpotify(dropedText);

			musicInfo1.Fill(music, m_musicEvents.Where(o => o.ItemID == music.ItemID).ToList());

			ArtistTextChanged(music.Artist);

			checkBoxNew.Checked = false;
		}

		private void TextBoxAutofill_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private void TextBoxAutofill_TextChanged(object sender, EventArgs e)
		{
			var text = Clipboard.GetText(TextDataFormat.UnicodeText);

			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}

			var music = Controller.Musics.GetAlbumInfoBandcamp(text);

			musicInfo1.Fill(music, m_musicEvents.Where(o => o.ItemID == music.ItemID).ToList());

			textBoxAutofill.Text = string.Empty;

			ArtistTextChanged(music.Artist);

			checkBoxNew.Checked = false;
		}

		private void TitleTextChanged(string title)
		{
			dataGridViewAll.SelectionChanged -= DataGridView_SelectionChanged;
			dataGridViewAll.DataSource = new SortableBindingList<MusicIn>(m_musics.Where(o => o.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
				.Select(o => Controller.Musics.ConvertToMusicIn(o, m_musicEvents))
				.ToList());
			dataGridViewAll.SelectionChanged += DataGridView_SelectionChanged;

			checkBoxNew.Checked = true;
		}
	}
}