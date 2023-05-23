using System;
using System.Windows.Forms;

namespace MainApp
{
	public partial class PasswordForm : Form
	{
		public PasswordForm()
		{
			InitializeComponent();
		}

		private void ButtonOk_Click(object sender, EventArgs e)
		{
			Controller.JsonData.SetPassword(textBoxPassword.Text);
			Close();
		}

		private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				buttonOk.PerformClick();

				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}
	}
}