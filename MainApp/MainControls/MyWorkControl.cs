using Model.dbo;
using System;
using System.Windows.Forms;

namespace MainApp.My_work
{
	public partial class MyWorkControl : UserControl
	{
		public static MyWorkControl Instance;

		public MyWorkControl()
		{
			InitializeComponent();
			Instance = this;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if(DesignMode)
			{
				return;
			}

			dataGridMyWork.DataSource = Controller.Database.GetList<MyWork>();
		}
	}
}