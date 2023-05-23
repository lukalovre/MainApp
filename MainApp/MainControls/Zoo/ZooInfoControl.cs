using Controller;
using Model.dbo;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.MainControls.Zoo
{
	public partial class ZooInfoControl : UserControl
	{
		private string m_oldComment;
		private Model.dbo.Zoo m_zoo;

		public ZooInfoControl()
		{
			InitializeComponent();

			if (DesignMode)
			{
				return;
			}
		}

		public void Fill(Model.dbo.Zoo zoo, IEnumerable<ZooEvents> zooEvents)
		{
			m_zoo = zoo;

			textBoxName.Text = zoo.Name;
			textBoxCity.Text = zoo.City;
			textBoxCountry.Text = zoo.Country;

			var lastEvent = zooEvents?.OrderBy(o => o.Date)?.LastOrDefault();

			m_oldComment = lastEvent?.Comment ?? string.Empty;
			starRatingControl1.SelectedStar = lastEvent.Rating ?? 1;

			var people = Datasource.GetList<Person>();
			var lastPeople = lastEvent.People;

			if (lastPeople != null)
			{
				var peopleList = CsvHelper.Get(lastPeople).Select(o => people.FirstOrDefault(p => p.ID == int.Parse(o)).ID);

				peopleListControl1.SelectPeople(peopleList);
			}
			else
			{
				peopleListControl1.SelectPeople(null);
			}

			if (zooEvents == null)
			{
				eventControl1.Clear();
				return;
			}

			var events = zooEvents.Select(o => new Model.EventListItem
			{
				ID = o.ID,
				Time = 1,
				Date = o.Date
			}).ToList();

			eventControl1.FIll(events);
		}

		internal ZooEvents GetEvent()
		{
			var comment = m_oldComment.Trim() == richTextBox1.Text.Trim()
				? null
				: richTextBox1.Text;
			comment = string.IsNullOrWhiteSpace(comment) ? null : comment;

			return new ZooEvents
			{
				Rating = starRatingControl1.SelectedStar,
				Comment = comment,
				People = peopleListControl1.GetCheckedCSV()
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