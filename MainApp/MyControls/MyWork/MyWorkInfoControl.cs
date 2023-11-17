using Model.dbo;
using System.Windows.Forms;

namespace MainApp.My_work
{
	public partial class MyWorkInfoControl : UserControl
	{
		public MyWorkInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(MyWork myWork)
		{
			textBoxTitle.Text = myWork.Title;
			textBoxCollaborators.Text = myWork.Collaborators;
			checkBoxPublic.Checked = myWork.Public;
			textBoxType.Text = myWork.Type;
			textBoxLocation.Text = myWork.Location;
			textBoxPublicLocation.Text = myWork.PublicLocation;
			checkBoxFinished.Checked = myWork.Finished;
			checkBoxMain.Checked = myWork.Main;
			labelDate.Text = myWork.Date.ToString();
		}

		internal MyWork GetItem()
		{
			return new MyWork
			{
				Title = textBoxTitle.Text,
				Collaborators = textBoxCollaborators.Text,
				Public = checkBoxPublic.Checked,
				Type = textBoxType.Text,
				Location = textBoxLocation.Text,
				PublicLocation = textBoxPublicLocation.Text,
				Finished = checkBoxFinished.Checked,
				Main = checkBoxMain.Checked
			};
		}
	}
}