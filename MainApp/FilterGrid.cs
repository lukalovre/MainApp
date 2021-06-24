using System;
using System.Data;
using System.Windows.Forms;

namespace MainApp
{
	public partial class FilterGrid : UserControl
	{
		public FilterGrid()
		{
			InitializeComponent();
		}

		public DataGridView DataGridCustom { get; set; }

		public void SetYear(int year)
		{
			numericUpDownLastYear.Value = year;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if(DesignMode)
			{
				return;
			}

			numericUpDownLastYear.Value = DateTime.Now.Year;
		}

		private void NumericUpDownLastYearValueChanged(object sender, EventArgs e)
		{
			if(DataGridCustom == null)
			{
				return;
			}

			var year = numericUpDownLastYear.Value;
		}
	}
}