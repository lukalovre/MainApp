using System;
using System.Windows.Forms;

namespace MainApp
{
	public partial class MissingInfo : Form
	{
		public MissingInfo()
		{
			InitializeComponent();
		}

		private void Button1Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}