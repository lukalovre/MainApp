using Controller;
using Model.dbo;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Musics
{
	public partial class MusicControl : UserControl
	{
		internal static MusicControl Instance;
		private BindingList<Music> m_bindingList;
		private List<MusicEvent> m_musicEvents;
		private List<Music> m_musics;

		public MusicControl()
		{
			InitializeComponent();
			Instance = this;
		}

		internal List<MusicEvent> GetEvents()
		{
			return m_musicEvents;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if(DesignMode)
			{
				return;
			}

			m_musics = Database.GetList<Music>();

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

			m_musicEvents = Database.GetList<MusicEvent>();

			yearFilter1.SetValueChangedEvent(NumericUpDownYearFilter_ValueChanged);

			var musicIn = m_musics.Where(o => m_musicEvents.Where(ev => ev.ItemID == o.ItemID).MaxBy(i => i.Date).FirstOrDefault().In);

			dataGridViewIn.DataSource = musicIn.ToList();
			dataGridViewYearList.DataSource = musicIn.Where(o => o.Year == DateTime.Now.Year).ToList();
			dataGridViewTodo.DataSource = musicIn.Where(o => m_musicEvents.Where(ev => ev.ItemID == o.ItemID).Max(i => i.Date).Value <= DateTime.Now.AddYears(-1)).ToList();

			SetGrid(dataGridViewAll);
			SetGrid(dataGridViewIn);
			SetGrid(dataGridViewYearList);
			SetGrid(dataGridViewTodo);

			dataGridViewIn.SelectLastRow();
			dataGridViewYearList.SelectLastRow();
			dataGridViewTodo.SelectLastRow();
			dataGridViewAll.SelectLastRow();
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var music = musicInfo1.GetInfo();

			if(!m_musicEvents.Any(o => o.ItemID == music.ItemID))
			{
				Database.Add(music);
				m_musics.Add(music);
				m_bindingList.Add(music);
			}

			var musicEvent = musicInfo1.GetEvent();
			musicEvent.Date = DateTime.Now;

			m_musicEvents.Add(musicEvent);
			Database.Add(musicEvent);

			var sourceFile = Path.Combine(Paths.Albums, "_temp.png");
			var destinationFile = Path.Combine(Paths.Albums, $"{music.ItemID}.png");
			File.Copy(sourceFile, destinationFile);
			File.Delete(sourceFile);

			dataGridViewAll.SelectionChanged -= DataGridView_SelectionChanged;
			dataGridViewAll.DataSource = m_musics.Where(o => o.Artist.Contains(music.Artist, StringComparison.OrdinalIgnoreCase)).ToList();
			dataGridViewAll.SelectionChanged += DataGridView_SelectionChanged;

			dataGridViewAll.SelectLastRow();
		}

		private void ButtonListenAgain_Click(object sender, EventArgs e)
		{
			var musicEvent = musicInfo1.GetEvent();
			musicEvent.Date = DateTime.Now;

			m_musicEvents.Add(musicEvent);
			Database.Add(musicEvent);

			dataGridViewAll.SelectLastRow();
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var music = (sender as DataGridView).GetRowObject<Music>();

			if(music == null)
			{
				return;
			}

			musicInfo1.Fill(music, m_musicEvents.Where(o => o.ItemID == music.ItemID).ToList());
		}

		private void NumericUpDownYearFilter_ValueChanged(object sender, EventArgs e)
		{
			var thisYear = m_musicEvents.Where(m => m.Date.HasValue && m.Date.Value.Year == (sender as NumericUpDown).Value).ToList();

			var bind = new List<Music>();

			foreach(var me in thisYear)
			{
				var m = m_musics.FirstOrDefault(o => o.ItemID == me.ItemID);
				bind.Add(m);
			}

			m_bindingList = new BindingList<Music>(bind.Distinct().ToList());

			dataGridViewAll.DataSource = new BindingSource(m_bindingList, null);
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[]{
			nameof(Music.Artist),
			nameof(Music.Title),
			nameof(Music.Year),
			nameof(Music.Runtime)});

			dataGridView.Columns[nameof(Music.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Music.Artist)].Width = 130;
			dataGridView.Columns[nameof(Music.Year)].CenterColumn();
			dataGridView.Columns[nameof(Music.Runtime)].CenterColumn();
		}

		private void TextBoxAutofill_DragDrop(object sender, DragEventArgs e)
		{
			var dropedText = e.Data.GetData(DataFormats.Text).ToString();

			var music = Controller.Musics.GetAlbumInfo(dropedText);

			musicInfo1.Fill(music, m_musicEvents.Where(o => o.ItemID == music.ItemID).ToList());

			dataGridViewAll.SelectionChanged -= DataGridView_SelectionChanged;
			dataGridViewAll.DataSource = m_musics.Where(o => o.Artist.Contains(music.Artist, StringComparison.OrdinalIgnoreCase)).ToList();
			dataGridViewAll.SelectionChanged += DataGridView_SelectionChanged;
		}

		private void TextBoxAutofill_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}
	}
}