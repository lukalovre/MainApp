using System;
using System.Windows.Forms;

namespace MainApp
{
	public partial class YearFilter : UserControl
	{
		public YearFilter()
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