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
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			Instance = this;

			dataGridMyWork.DataSource = Controller.Datasource.GetList<MyWork>();
		}
	}
}