using Controller;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.MainControls.Concerts
{
	public partial class ConcertsControl : UserControl
	{
		private List<Concert> m_concerts;

		public ConcertsControl()
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
			addButton1.SetAddButton(ButtonAdd_Click);
		}

		private void LoadGridData()
		{
			m_concerts = Datasource.GetList<Concert>();

			dataGridViewAll.DataSource = new SortableBindingList<ConcertsGrid>(m_concerts
				.OrderBy(o => o.Date)
				.Select(o => Converter.ToConcertGrid(o))
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
			dataGridView.CellClick -= CellClick;
			dataGridView.CellClick += CellClick;
			dataGridView.SelectionChanged -= DataGridView_SelectionChanged;
			dataGridView.SelectionChanged += DataGridView_SelectionChanged;

			dataGridView.Columns[nameof(ConcertsGrid.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(ConcertsGrid.City)].CenterColumn();
			dataGridView.Columns[nameof(ConcertsGrid.Year)].CenterColumn();
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<ConcertsGrid>();

			if (item == null)
			{
				return;
			}

			concertInfoControl1.Fill(m_concerts.FirstOrDefault(o => o.ID == item.ID));
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var item = concertInfoControl1.GetItem();

			item.ID = 0;
			item.Date = addButton1.GetDate().Value;
			Datasource.Add(item);
			m_concerts.Add(item);

			concertInfoControl1.Fill(item);
		}
	}
}