using Controller;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.My_work_progress
{
	public partial class MyWorkProgressControl : UserControl
	{
		private List<MyWorkProgres> m_progress;
		private List<MyWorkProgressEvent> m_progressEvents;

		public MyWorkProgressControl()
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

			SetGridAll(dataGridViewAll);
			SetGridAll(dataGridViewOngoing);
			addButton1.SetAddButton(ButtonAdd_Click);
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var progress = myWorkProgressInfo.GetItem();

			var itemID = progress.ItemID;

			if (!m_progress.Any(o => o.Title == progress.Title))
			{
				var newProgress = new MyWorkProgres
				{
					Title = progress.Title,
					Type = progress.Type,
					ItemID = m_progressEvents.Max(o => o.ItemID) + 1
				};

				itemID = newProgress.ItemID;
				Datasource.Add(newProgress);
			}

			var progressEvent = myWorkProgressInfo.GetEvent();
			progressEvent.Date = addButton1.GetDate();
			progressEvent.ItemID = itemID;
			progressEvent.Time = (int)numericUpDownAddTime.Value;

			Datasource.Add(progressEvent);

			m_progressEvents.Add(progressEvent);

			myWorkProgressInfo.Fill(progress, m_progressEvents.Where(o => o.ItemID == progress.ItemID).ToList());
			numericUpDownAddTime.Value = 0;
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var progress = (sender as DataGridView).GetRowObject<MyWorkProgresGrid>();

			if (progress == null)
			{
				return;
			}

			myWorkProgressInfo.Fill(m_progress.FirstOrDefault(o => o.ItemID == progress.ItemID), m_progressEvents.Where(o => o.ItemID == progress.ItemID).ToList());
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
			m_progressEvents = Datasource.GetList<MyWorkProgressEvent>();
			m_progress = Datasource.GetList<MyWorkProgres>();

			var data = m_progress
				.Select(o => Converter.ToMyWorkProgresGrid(o, m_progressEvents.Where(x => x.ItemID == o.ItemID)))
				.OrderBy(o => o.LastDate)
				.ToList();

			dataGridViewAll.DataSource = new SortableBindingList<MyWorkProgresGrid>(data);
			dataGridViewOngoing.DataSource = new SortableBindingList<MyWorkProgresGrid>(data.Where(o => Following.FollowingModel.MyWorkProgress.Contains(o.ItemID.ToString())).ToList());
		}

		private void SetGridAll(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.CellClick -= CellClick;
			dataGridView.CellClick += CellClick;

			dataGridView.Columns[nameof(MyWorkProgresGrid.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(MyWorkProgresGrid.Type)].CenterColumn();
			dataGridView.Columns[nameof(MyWorkProgresGrid.DaysAgo)].CenterColumn();
			dataGridView.Columns[nameof(MyWorkProgresGrid.Time)].CenterColumn();
			dataGridView.Columns[nameof(MyWorkProgresGrid.LastDate)].Visible = false;
		}
	}
}