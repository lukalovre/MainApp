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
			labelTime.Text = GetTimeFormated(myWorkProgressEvents.Sum(o => o.Time).ToString());
			checkBoxOngoing.Checked = Following.FollowingModel.MyWorkProgress.Contains(progress.ItemID.ToString());
		}

		internal MyWorkProgres GetItem()
		{
			return m_progress;
		}

		private void CheckBoxOngoing_CheckedChanged(object sender, EventArgs e)
		{
			Following.Update(checkBoxOngoing.Checked, Following.FollowingModel.MyWorkProgress, m_progress.ItemID.ToString());
		}

		private string GetTimeFormated(string minutes)
		{
			var hr = Convert.ToInt32(minutes) / 60;
			var min = Convert.ToInt32(minutes) % 60;

			return $"{hr} hr {min} min";
		}
	}
}