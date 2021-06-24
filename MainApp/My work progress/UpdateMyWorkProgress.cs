using System;
using System.Windows.Forms;

namespace MainApp.My_work_progress
{
	public partial class UpdateMyWorkProgress : UserControl
	{
		public static UpdateMyWorkProgress Instance;

		public UpdateMyWorkProgress()
		{
			InitializeComponent();
			Instance = this;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			Update();
			MyWorkProgress.Instance.ShowDataInGrid();
			textBoxTime.Text = string.Empty;
		}

		private new void Update()
		{
			var itemID = MyWorkProgress.Instance.dataGridCustom1.SelectedID;
			var time = textBoxTime.Text;

			var commandText = $@"
            EXECUTE[dbo].[UpdateMyWorkProgress]
                 {itemID}
                ,{time}";

			SqlConnectionExtension.ExecuteNonQuery(commandText);
		}
	}
}