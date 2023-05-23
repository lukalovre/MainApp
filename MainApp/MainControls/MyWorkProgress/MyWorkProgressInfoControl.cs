using Controller;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.My_work_progress
{
	public partial class MyWorkProgressInfoControl : UserControl
	{
		private MyWorkProgres m_progress;

		public MyWorkProgressInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(MyWorkProgres progress, List<MyWorkProgressEvent> myWorkProgressEvents)
		{
			m_progress = progress;

			textBoxTitle.Text = progress.Title;
			textBoxType.Text = progress.Type;
			labelTime.Text = Helper.GetFormatedTime(myWorkProgressEvents.Sum(o => o.Time));
			checkBoxOngoing.Checked = Following.FollowingModel.MyWorkProgress.Contains(progress.ItemID.ToString());

			if (myWorkProgressEvents == null)
			{
				eventControl1.Clear();
				return;
			}

			var events = myWorkProgressEvents.Select(o => new Model.EventListItem
			{
				ID = o.ID,
				Time = o.Time,
				Date = o.Date
			}).ToList();

			eventControl1.FIll(events);
		}

		internal MyWorkProgres GetItem()
		{
			return new MyWorkProgres
			{
				ID = m_progress.ID,
				Title = textBoxTitle.Text,
				Type = textBoxType.Text,
				ItemID = m_progress.ItemID
			};
		}

		private void CheckBoxOngoing_CheckedChanged(object sender, EventArgs e)
		{
			Following.Update(checkBoxOngoing.Checked, Following.FollowingModel.MyWorkProgress, m_progress.ItemID.ToString());
		}
	}
}