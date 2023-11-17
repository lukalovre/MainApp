using Controller;
using Model;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.MainControls
{
	public partial class DnDControl : UserControl
	{
		private SortableBindingList<DnDEventGrid> m_bindingList;
		private List<DnD> m_campaigns;
		private List<DnDEvent> m_sesshions;

		public DnDControl()
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

			SetGridCampaigns(dataGridViewCampaigns);
			SetGridSeshions(dataGridViewSeshions);
			addButton1.SetAddButton(ButtonAdd_Click);
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var @event = dnDInfoControl1.GetItem();
			@event.Date = addButton1.GetDate();

			Datasource.Add(@event);
			m_bindingList.Add(Converter.ToDnDEventGrid(@event));
			dataGridViewSeshions.SelectLastRow();
		}

		private void DataGridViewCampaigns_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<DnD>();

			if (item == null)
			{
				return;
			}

			SelectCampaign(item);
		}

		private void CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == -1)
			{
				LoadGridData();
			}
		}

		private void LoadGridData()
		{
			m_campaigns = Datasource.GetList<DnD>();
			m_sesshions = Datasource.GetList<DnDEvent>();

			dataGridViewCampaigns.DataSource = m_campaigns;

			m_bindingList = new SortableBindingList<DnDEventGrid>(m_sesshions.Select(o => Converter.ToDnDEventGrid(o)).ToList());
			dataGridViewSeshions.DataSource = m_bindingList;

			var latestSeshion = m_sesshions.OrderBy(o => o.Date).LastOrDefault();
			var lastCampaign = m_campaigns.FirstOrDefault(o => o.ID == latestSeshion.ItemID);
			SelectCampaign(lastCampaign);
		}

		private void SelectCampaign(DnD item)
		{
			// For '&' chars in text
			labelCampaignTitle.UseMnemonic = false;
			labelCampaignTitle.Text = item.Title;

			dataGridViewSeshions.DataSource = m_bindingList.Where(o => o.ItemID == item.ID).ToList();
		}

		private void DataGridViewSeshions_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<DnDEventGrid>();

			if (item == null)
			{
				return;
			}

			dnDInfoControl1.Fill(m_sesshions.FirstOrDefault(o => o.ID == item.ID));
		}

		private void SetGridCampaigns(DataGridView dataGridView)
		{
			dataGridView.SetGrid();
			dataGridView.CellClick -= CellClick;
			dataGridView.CellClick += CellClick;
		}

		private void SetGridSeshions(DataGridView dataGridView)
		{
			dataGridView.SetGrid();
			dataGridView.CellClick -= CellClick;
			dataGridView.CellClick += CellClick;

			dataGridView.Columns[nameof(DnDEventGrid.Summary)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(DnDEventGrid.Location)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(DnDEventGrid.Level)].CenterColumn();
			dataGridView.Columns[nameof(DnDEventGrid.Hours)].CenterColumn();
		}
	}
}