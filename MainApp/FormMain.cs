using System.Windows.Forms;

namespace MainApp
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
			Instace = this;
			StartPosition = FormStartPosition.Manual;
			Location = new System.Drawing.Point(-1032, 1371);
			Size = new System.Drawing.Size(1040, 744);
		}

		public static FormMain Instace { get; set; }

		public void ChangeTabToBooks()
		{
			tabControlAll.SelectedIndex = 0;
			tabControlMain.SelectedIndex = 5;
		}
	}
}