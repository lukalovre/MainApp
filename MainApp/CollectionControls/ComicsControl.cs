using Controller;
using Model.Collection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainApp.Collection
{
	public partial class ComicsControl : UserControl
	{
		private List<Comic> m_comics;

		public ComicsControl()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if(DesignMode)
			{
				return;
			}

			m_comics = Database.GetList<Comic>();

			dataGridViewAll.DataSource = m_comics;

			SetGridAll(dataGridViewAll);

			dataGridViewAll.SelectLastRow();
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var comic = comicInfo.GetItem();

			comic.Date = DateTime.Now;

			Database.Add(comic);
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var comic = (sender as DataGridView).GetRowObject<Comic>();

			if(comic == null)
			{
				return;
			}

			comicInfo.Fill(comic);
		}

		private void SetGridAll(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[]{
			nameof(Comic.Title),
			nameof(Comic.Writer),
			nameof(Comic.Chapter)});

			dataGridView.Columns[nameof(Comic.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Comic.Chapter)].CenterColumn();
		}
	}
}