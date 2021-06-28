using System;
using System.Windows.Forms;

namespace MainApp.My_work_progress
{
	public partial class UpdateMyWorkProgressControl : UserControl
	{
		public static UpdateMyWorkProgressControl Instance;

		public UpdateMyWorkProgressControl()
		{
			InitializeComponent();
			Instance = this;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			Update();
			MyWorkProgressControl.Instance.ShowDataInGrid();
			textBoxTime.Text = string.Empty;
		}

		private new void Update()
		{
			var itemID = MyWorkProgressControl.Instance.dataGridCustom1.SelectedID;
			var time = textBoxTime.Text;

			var commandText = $@"
            EXECUTE[dbo].[UpdateMyWorkProgress]
                 {itemID}
                ,{time}";

			SqlConnectionExtension.ExecuteNonQuery(commandText);
		}
	}
}