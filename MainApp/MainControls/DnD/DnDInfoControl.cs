using Model.dbo;
using System;
using System.Windows.Forms;

namespace MainApp.MainControls
{
	public partial class DnDInfoControl : UserControl
	{
		private DnDEvent m_sesshion;

		public DnDInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(DnDEvent sesshion)
		{
			m_sesshion = sesshion;

			labelDate.Text = sesshion.Date?.ToString() ?? string.Empty;
			numericUpDownHours.Value = sesshion.Hours ?? 0;
			numericUpDownLevel.Value = sesshion.Level ?? 0;
			textBoxLocation.Text = sesshion.Location?.ToString() ?? string.Empty;
			richTextBoxSummary.Text = sesshion.Summary;
		}

		internal DnDEvent GetItem()
		{
			return new DnDEvent
			{
				Location = textBoxLocation.Text,
				Date = DateTime.Now,
				Hours = (int)numericUpDownHours.Value,
				Level = (int)numericUpDownLevel.Value,
				Summary = richTextBoxSummary.Text,
				ItemID = m_sesshion.ItemID
			};
		}
	}
}