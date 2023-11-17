using Controller;
using Model;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.CommonControls
{
	public partial class PeopleListControl : UserControl
	{
		private List<Person> _people;

		public PeopleListControl()
		{
			InitializeComponent();
		}

		internal string GetCheckedCSV()
		{
			var checkedIndices = new List<int>();

			foreach (string value in checkedListBox1.CheckedItems)
			{
				var person = _people.FirstOrDefault(o => GetDisplayName(o) == value);
				checkedIndices.Add(person.ID);
			}

			return checkedIndices.Any()
				? CsvHelper.Create(checkedIndices)
				: null;
		}

		internal void SelectPeople(IEnumerable<int> peopleIDList)
		{
			if (peopleIDList == null)
			{
				LoadPeople();
				return;
			}

			_people = Datasource.GetList<Person>();
			_people = _people.OrderByDescending(o => peopleIDList.Contains(o.ID)).ThenBy(o => o.ID).ToList();

			checkedListBox1.Items.Clear();
			checkedListBox1.Items.AddRange(_people.Select(o => GetDisplayName(o)).ToArray());

			foreach (var personID in peopleIDList)
			{
				var person = _people.FirstOrDefault(o => o.ID == personID);
				var index = checkedListBox1.Items.IndexOf(GetDisplayName(person));
				checkedListBox1.SetItemChecked(index, true);
			}
		}

		internal void FillPeople(Event eventItem)
		{
			var people = Datasource.GetList<Person>();
			var lastPeople = eventItem?.People;

			if (lastPeople != null)
			{
				var peopleList = CsvHelper.Get(lastPeople).Select(o => people.FirstOrDefault(p => p.ID == int.Parse(o)).ID);
				SelectPeople(peopleList);
			}
			else
			{
				SelectPeople(null);
			}
		}

		internal void FillPeople(IEnumerable<Event> eventList)
		{
			FillPeople(eventList.LastOrDefault());
		}

		private void LoadPeople()
		{
			_people = Datasource.GetList<Person>();
			_people = _people.OrderBy(o => o.ID).ToList();

			checkedListBox1.Items.Clear();
			checkedListBox1.Items.AddRange(_people.Select(o => GetDisplayName(o)).ToArray());
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			checkedListBox1.CheckOnClick = true;

			LoadPeople();
		}

		private string GetDisplayName(Person person)
		{
			if (!string.IsNullOrWhiteSpace(person.Nickname))
			{
				return person.Nickname;
			}

			return $"{person.FirstName} {person.LastName}";
		}
	}
}