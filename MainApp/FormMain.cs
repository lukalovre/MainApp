using Controller;
using System;
using System.Windows.Forms;

namespace MainApp
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		public static FormMain Instace { get; set; }

		public void ChangeTabToBooks()
		{
			tabControlAll.SelectedIndex = 0;
			tabControlMain.SelectedIndex = 5;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			Instace = this;
			StartPosition = FormStartPosition.Manual;
			Location = Settings.Instance.Location;
			Size = Settings.Instance.Size;
		}
	}
}