using Controller;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.CommonControls
{
	public partial class PeopleListControl : UserControl
	{
		public PeopleListControl()
		{
			InitializeComponent();
		}

		internal string GetCheckedCSV()
		{
			var checkedIndices = new List<int>();

			foreach (int index in checkedListBox1.CheckedIndices)
			{
				// Adding +1 since the index goes from 0 and the db index from 1
				checkedIndices.Add(index + 1);
			}

			return checkedIndices.Any()
				? CsvHelper.Create(checkedIndices)
				: null;
		}

		internal void SelectPeople(IEnumerable<int> peopleList)
		{
			for (int i = 0; i < checkedListBox1.Items.Count; i++)
			{
				checkedListBox1.SetItemChecked(i, false);
			}

			if (peopleList == null)
			{
				return;
			}

			foreach (var person in peopleList)
			{
				// Adding +1 since the index goes from 0 and the db index from 1
				checkedListBox1.SetItemChecked(person - 1, true);
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			checkedListBox1.CheckOnClick = true;

			checkedListBox1.Items.Clear();

			var people = Datasource.GetList<Person>();

			checkedListBox1.Items.AddRange(people.Select(o => o.FirstName).ToArray());
		}
	}
}