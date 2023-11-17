using Model;
using Model.dbo;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainApp.MainControls.Concerts
{
	public partial class ConcertInfoControl : UserControl
	{
		private Concert m_item;

		public ConcertInfoControl()
		{
			InitializeComponent();

			if (Helper.IsInDesignMode)
			{
				return;
			}
		}

		public void Fill(Concert item)
		{
			m_item = item;

			textBoxName.Text = item.Title;
			textBoxCity.Text = item.City;
			textBoxCountry.Text = item.Country;
			textBoxVenue.Text = item.Venue;
			labelDate.Text = item.Date.Value.ToString("yyyy-MM-dd");
			textBoxFestival.Text = item.Festival;
			numericUpDownPrice.Value = item.Price;

			var eventListItems = new List<EventListItem>
			{
				new EventListItem
				{
					CountValue = 1,
					Date = item.Date,
					ID = item.ID
				}
			};

			evenControl1.Fill(item, eventListItems);
		}

		internal Concert GetItem()
		{
			return new Concert
			{
				ID = m_item.ID,
				Title = textBoxName.Text,
				City = textBoxCity.Text,
				Country = textBoxCountry.Text,
				Comment = evenControl1.GetComment(),
				Venue = textBoxVenue.Text,
				Rating = evenControl1.Rating,
				People = evenControl1.GetPeople(),
				Price = (int)numericUpDownPrice.Value,
				Festival = textBoxFestival.Text
			};
		}
	}
}