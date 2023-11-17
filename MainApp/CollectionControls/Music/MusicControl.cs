using Controller;
using Model.Collection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainApp.Collection
{
	public partial class MusicControl : UserControl
	{
		private SortableBindingList<Music> m_bindingList;
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

			m_bindingList = new SortableBindingList<Music>(m_musics);

			dataGridViewAll.DataSource = new BindingSource(m_bindingList, null);

			SetGridAll(dataGridViewAll);

			dataGridViewAll.SelectLastRow();
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var item = musicInfo.GetItem();
			item.Date = DateTime.Now;

			Datasource.Add(item);
			m_bindingList.Add(item);
			dataGridViewAll.SelectLastRow();
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<Music>();
			musicInfo.Fill(item);
		}

		private void SetGridAll(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[]{
			nameof(Music.Artist),
			nameof(Music.Title),
			nameof(Music.Year),
			nameof(Music.Format)});

			dataGridView.Columns[nameof(Music.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Music.Year)].CenterColumn();
			dataGridView.Columns[nameof(Music.Format)].CenterColumn();
		}
	}
}