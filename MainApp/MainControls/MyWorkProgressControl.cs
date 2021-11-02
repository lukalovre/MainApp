using Controller;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.My_work_progress
{
	public partial class MyWorkProgressControl : UserControl
	{
		private SortableBindingList<MyWorkProgres> m_progress;
		private List<MyWorkProgressEvent> m_progressEvents;

		public MyWorkProgressControl()
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

			m_progressEvents = Database.GetList<MyWorkProgressEvent>();
			m_progress = new SortableBindingList<MyWorkProgres>(Database.GetList<MyWorkProgres>());

			dataGridViewAll.DataSource = m_progress;
			dataGridViewOngoing.DataSource = m_progress
				.Where(o => Following.FollowingModel.MyWorkProgress.Contains(o.ItemID.ToString()))
				.ToList();

			SetGridAll(dataGridViewAll);
			SetGridAll(dataGridViewOngoing);
		}

		private void ButtonAddMinutes_Click(object sender, EventArgs e)
		{
			var progress = myWorkProgressInfo.GetItem();

			var progressEvent = new MyWorkProgressEvent
			{
				Date = DateTime.Now,
				ItemID = progress.ItemID,
				Time = (int)numericUpDownAddTime.Value
			};

			Database.Add(progressEvent);

			m_progressEvents.Add(progressEvent);

			myWorkProgressInfo.Fill(progress, m_progressEvents.Where(o => o.ItemID == progress.ItemID).ToList());
			numericUpDownAddTime.Value = 0;
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var progress = (sender as DataGridView).GetRowObject<MyWorkProgres>();

			if (progress == null)
			{
				return;
			}

			myWorkProgressInfo.Fill(progress, m_progressEvents.Where(o => o.ItemID == progress.ItemID).ToList());
		}

		private void SetGridAll(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[] {
			nameof(MyWorkProgres.Title),
			nameof(MyWorkProgres.Type)});

			dataGridView.Columns[nameof(MyWorkProgres.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(MyWorkProgres.Type)].CenterColumn();
		}
	}
}