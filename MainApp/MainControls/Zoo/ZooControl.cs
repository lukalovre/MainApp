using Controller;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.MainControls.Zoo
{
	public partial class ZooControl : UserControl
	{
		private List<Model.dbo.Zoo> m_zoo;
		private List<ZooEvents> m_zooEvents;

		public ZooControl()
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

			LoadGridData();
			SetGrid(dataGridViewAll);
		}

		private void LoadGridData()
		{
			m_zoo = Datasource.GetList<Model.dbo.Zoo>();
			m_zooEvents = Datasource.GetList<ZooEvents>();

			dataGridViewAll.DataSource = new SortableBindingList<ZooGrid>(m_zoo
				.Select(o => Converter.ToZooGrid(o, m_zooEvents.Where(item => o.ID == item.ItemID)))
				.OrderBy(o => o.LastVisit)
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
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<ZooGrid>();

			if (item == null)
			{
				return;
			}

			zooInfoControl1.Fill(m_zoo.FirstOrDefault(o => o.ID == item.ID), m_zooEvents.Where(o => o.ItemID == item.ID));
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var item = zooInfoControl1.GetItem();

			if (!m_zoo.Any(o => o.Name.Trim() == item.Name.Trim()))
			{
				item.ID = 0;
				Datasource.Add(item);
				m_zoo.Add(item);
			}

			var @event = zooInfoControl1.GetEvent();
			@event.ItemID = item.ID;

			@event.Date = checkBoxDateTimePicker.Checked
				? dateTimePicker1.Value
				: DateTime.Now;

			Datasource.Add(@event);
			m_zooEvents.Add(@event);

			zooInfoControl1.Fill(item, m_zooEvents.Where(o => o.ItemID == item.ID));
		}
	}
}