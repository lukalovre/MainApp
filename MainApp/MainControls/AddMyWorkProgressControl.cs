﻿using System;
using System.Windows.Forms;

namespace MainApp.My_work_progress
{
	public partial class AddMyWorkProgressControl : UserControl
	{
		public AddMyWorkProgressControl()
		{
			InitializeComponent();
		}

		private void Add()
		{
			var title = SQLHelper.GetText(textBoxTitle.Text);
			var type = SQLHelper.GetText(textBoxType.Text);
			var time = textBoxTime.Text;

			var query = $@"
EXECUTE [dbo].[AddMyWorkProgress]
   {title}
  ,{type}
  ,{time}";

			SqlConnectionExtension.ExecuteNonQuery(query);
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			Add();
			MyWorkProgressControl.Instance.ShowDataInGrid();
		}
	}
}