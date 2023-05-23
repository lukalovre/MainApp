using System;
using System.Windows.Forms;

namespace MainApp
{
	public partial class YearFilterControl : UserControl
	{
		public YearFilterControl()
		{
			InitializeComponent();
		}

		public void SetValueChangedEvent(EventHandler eventHandler)
		{
			numericUpDownYear.ValueChanged += eventHandler;
			numericUpDownYear.Value = DateTime.Now.Year;
		}
	}
}