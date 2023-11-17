using Model.dbo;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.MainControls.Zoo
{
	public partial class ZooInfoControl : UserControl
	{
		private Model.dbo.Zoo m_zoo;

		public ZooInfoControl()
		{
			InitializeComponent();
		}

		public void Fill(Model.dbo.Zoo zoo, IEnumerable<ZooEvents> zooEvents)
		{
			m_zoo = zoo;

			textBoxName.Text = zoo.Name;
			textBoxCity.Text = zoo.City;
			textBoxCountry.Text = zoo.Country;

			if (zooEvents == null)
			{
				evenControl1.Clear();
				return;
			}

			var events = zooEvents.Select(o => new Model.EventListItem
			{
				ID = o.ID,
				CountValue = 1,
				Date = o.Date
			}).ToList();

			var lastEvent = zooEvents?.OrderBy(o => o.Date)?.LastOrDefault();
			evenControl1.Fill(lastEvent, events, EventListControl.CountValue.None);
		}

		internal ZooEvents GetEvent()
		{
			return new ZooEvents
			{
				Rating = evenControl1.Rating,
				Comment = evenControl1.GetComment(),
				People = evenControl1.GetPeople()
			};
		}

		internal Model.dbo.Zoo GetItem()
		{
			return new Model.dbo.Zoo
			{
				ID = m_zoo.ID,
				City = textBoxCity.Text,
				Country = textBoxCountry.Text,
				Name = textBoxName.Text
			};
		}
	}
}