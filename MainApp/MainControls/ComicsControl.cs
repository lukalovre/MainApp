using Controller;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Comics
{
	public partial class ComicsControl : UserControl
	{
		internal static ComicsControl Instance;
		private SortableBindingList<Comic> m_bindingList;
		private List<ComicEvent> m_comicEvents;
		private List<Comic> m_comics;

		public ComicsControl()
		{
			InitializeComponent();
			Instance = this;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			m_comics = Database.GetList<Comic>();
			m_comicEvents = Database.GetList<ComicEvent>();

			numericUpDownYear.Value = DateTime.Now.Year;

			dataGridViewReading.DataSource =
			new BindingSource(m_comics.Where(o => Following.FollowingModel.Comics.Contains(o.GoodreadsID.ToString())), null);

			dataGridViewOngoing.DataSource =
			new BindingSource(m_comics.Where(o => Following.FollowingModel.ComicsOngoing.Contains(o.GoodreadsID.ToString())), null);

			SetGrid(dataGridViewAll);
			SetGrid(dataGridViewReading);
			SetGrid(dataGridViewOngoing);

			dataGridViewAll.SelectLastRow();
		}

		private void ButtonUpdate_Click(object sender, EventArgs e)
		{
			var comic = comicInfo1.GetItem();

			if (!m_comics.Any(o => o.GoodreadsID == comic.GoodreadsID))
			{
				Database.Add(comic);
				m_comics.Add(comic);
				m_bindingList.Add(comic);
			}

			var comicEvent = comicInfo1.GetEvent();
			comicEvent.Date = DateTime.Now;

			Database.Add(comicEvent);
			m_comicEvents.Add(comicEvent);

			comicInfo1.Fill(comic, m_comicEvents.Where(o => o.GoodreadsID == comic.GoodreadsID).ToList());
			dataGridViewAll.SelectLastRow();
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var comic = (sender as DataGridView).GetRowObject<Comic>();

			if (comic == null)
			{
				return;
			}

			comicInfo1.Fill(comic, m_comicEvents.Where(o => o.GoodreadsID == comic.GoodreadsID).ToList());
		}

		private void NumericUpDownYear_ValueChanged(object sender, EventArgs e)
		{
			var thisYear = m_comicEvents.Where(m => m.Date.HasValue && m.Date.Value.Year == numericUpDownYear.Value).ToList();

			var bind = new List<Comic>();

			foreach (var me in thisYear)
			{
				var m = m_comics.FirstOrDefault(o => o.GoodreadsID == me.GoodreadsID);
				bind.Add(m);
			}

			m_bindingList = new SortableBindingList<Comic>(bind.Distinct().ToList());

			dataGridViewAll.DataSource = new BindingSource(m_bindingList, null);
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[] {
			nameof(Comic.Title),
			nameof(Comic.Writer),
			nameof(Comic.Year),
			nameof(Comic._1001)});

			dataGridView.Columns[nameof(Comic._1001)].HeaderText = "1001";
			dataGridView.Columns[nameof(Comic._1001)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView.Columns[nameof(Comic.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Comic.Writer)].Width = 130;
			dataGridView.Columns[nameof(Comic.Year)].CenterColumn();
		}
	}
}