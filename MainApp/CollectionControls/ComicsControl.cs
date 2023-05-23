using Controller;
using Model.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Collection
{
	public partial class ComicsControl : UserControl
	{
		private SortableBindingList<Comic> m_bindable;
		private List<Comic> m_comics;

		public ComicsControl()
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

			m_comics = Datasource.GetList<Comic>();

			m_bindable = new SortableBindingList<Comic>(m_comics
				.OrderBy(o => o.Date)
				.ToList());

			dataGridViewAll.DataSource = m_bindable;

			dataGridViewToRead.DataSource = new SortableBindingList<Comic>(m_comics
				.OrderBy(o => o.Date)
				.Where(o => Following.FollowingModel.ComicsCollection.Contains(o.GoodreadsID.ToString()))
				.ToList());

			SetGrid(dataGridViewAll);
			SetGrid(dataGridViewToRead);

			dataGridViewAll.SelectLastRow();
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var comic = comicInfo.GetItem();

			comic.Date = DateTime.Now;

			Datasource.Add(comic);
			m_bindable.Add(comic);
			dataGridViewAll.SelectLastRow();
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var comic = (sender as DataGridView).GetRowObject<Comic>();

			if (comic == null)
			{
				return;
			}

			comicInfo.Fill(comic);
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[]{
			nameof(Comic.Title),
			nameof(Comic.Writer),
			nameof(Comic.Chapter)});

			dataGridView.Columns[nameof(Comic.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Comic.Chapter)].CenterColumn();
		}

		private void TextBoxUrl_TextChanged(object sender, EventArgs e)
		{
			var url = textBoxUrl.Text;

			var comic = Links.GetGoodreadsDataComicCollection(url);

			comicInfo.Fill(comic);

			textBoxUrl.TextChanged -= new EventHandler(TextBoxUrl_TextChanged);
			textBoxUrl.Clear();
			textBoxUrl.TextChanged += new EventHandler(TextBoxUrl_TextChanged);
		}
	}
}