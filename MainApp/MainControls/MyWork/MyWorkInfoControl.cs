using System.Windows.Forms;

namespace MainApp.My_work
{
	public partial class AddMyWorkControl : UserControl
	{
		public AddMyWorkControl()
		{
			InitializeComponent();
		}

		private void Add()
		{
			var title = textBoxTitle.Text;
			var collaborators = textBoxCollaborators.Text;
			var _public = checkBoxPublic.Checked ? 1 : 0;
			var type = textBoxType.Text;
			var location = textBoxLocation.Text;
			var publicLocation = textBoxPublicLocation.Text;
			var finished = checkBoxFinished.Checked ? 1 : 0;
		}
	}
}