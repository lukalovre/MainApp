using Controller;
using Model;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.MainControls
{
	public partial class PeopleControl : UserControl
	{
		private SortableBindingList<PeopleGrid> m_bindable;
		private List<Person> m_people;

		public PeopleControl()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			LoadGridData();

			SetGrid(dataGridViewAll);
			dataGridViewAll.SelectLastRow();
		}

		private void CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == -1)
			{
				LoadGridData();
			}
		}

		private void LoadGridData()
		{
			m_people = Datasource.GetList<Person>();
			m_bindable = new SortableBindingList<PeopleGrid>(m_people
				.OrderBy(o => o.LastName)
				.Select(o => Converter.ToPeopleGrid(o))
				.ToList());

			dataGridViewAll.DataSource = m_bindable;
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var item = personInfoControl1.GetItem();

			Datasource.Add(item);
			m_people.Add(item);
			m_bindable.Add(Converter.ToPeopleGrid(item));

			dataGridViewAll.SelectLastRow();
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<PeopleGrid>();

			if (item == null)
			{
				return;
			}

			personInfoControl1.Fill(m_people.FirstOrDefault(o => o.ID == item.ID));
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();
			dataGridView.CellClick += CellClick;
		}
	}
}