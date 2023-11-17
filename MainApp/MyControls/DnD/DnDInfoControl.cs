using Model;
using Model.dbo;
using System.Collections.Generic;
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

			var eventlistItem = new List<EventListItem> {
				new EventListItem{
					ID = sesshion.ID,
					Date = sesshion.Date,
					CountValue = 1
					}
			};

			evenControl1.Fill(sesshion, eventlistItem);
		}

		internal DnDEvent GetItem()
		{
			return new DnDEvent
			{
				Location = textBoxLocation.Text,
				Hours = (int)numericUpDownHours.Value,
				Level = (int)numericUpDownLevel.Value,
				Summary = richTextBoxSummary.Text,
				ItemID = m_sesshion.ItemID,
				People = evenControl1.GetPeople(),
				Comment = evenControl1.GetComment(),
				Rating = evenControl1.Rating
			};
		}
	}
}