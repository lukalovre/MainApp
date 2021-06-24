﻿using System;
using System.Windows.Forms;

namespace MainApp.My_work
{
	public partial class AddMyWork : UserControl
	{
		public AddMyWork()
		{
			InitializeComponent();
		}

		private void Add()
		{
			var title = SQLHelper.GetText(textBoxTitle.Text);
			var collaborators = SQLHelper.GetText(textBoxCollaborators.Text);
			var _public = checkBoxPublic.Checked ? 1 : 0;
			var type = SQLHelper.GetText(textBoxType.Text);
			var location = SQLHelper.GetText(textBoxLocation.Text);
			var publicLocation = SQLHelper.GetText(textBoxPublicLocation.Text);
			var finished = checkBoxFinished.Checked ? 1 : 0;

			var query = $@"
EXECUTE [dbo].[AddMyWork]
   {title}
  ,{collaborators}
  ,{_public}
  ,{type}
  ,{location}
  ,{publicLocation}
  ,{finished}";

			SqlConnectionExtension.ExecuteNonQuery(query);
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			Add();
			MyWork.Instance.LoadData();
		}
	}
}