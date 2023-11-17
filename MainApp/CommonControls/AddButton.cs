using System;
using System.Windows.Forms;

namespace MainApp.CommonControls
{
	public partial class AddButton : UserControl
	{
		public AddButton()
		{
			InitializeComponent();
		}

		internal DateTime? GetDate()
		{
			return checkBoxDateTimePicker.Checked
				? dateTimePicker1.Value
				: DateTime.Now;
		}

		internal void SetAddButton(EventHandler click)
		{
			buttonAdd.Click -= click;
			buttonAdd.Click += click;

			buttonAdd.Click -= new EventHandler(ButtonAdd_Click);
			buttonAdd.Click += new EventHandler(ButtonAdd_Click);
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			checkBoxDateTimePicker.Checked = false;
		}
	}
}