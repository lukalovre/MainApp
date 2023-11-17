using Controller;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.My_work
{
	public partial class MyWorkControl : UserControl
	{
		public static MyWorkControl Instance;
		private List<MyWork> m_myWork;

		public MyWorkControl()
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

			Instance = this;

			LoadGridData();
			SetGrid(dataGridMyWork);
			dataGridMyWork.SelectLastRow();
			addButton1.SetAddButton(ButtonAdd_Click);
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();
			dataGridView.CellClick -= CellClick;
			dataGridView.CellClick += CellClick;
			dataGridView.SelectionChanged -= DataGridView_SelectionChanged;
			dataGridView.SelectionChanged += DataGridView_SelectionChanged;

			dataGridView.Columns[nameof(MyWorkGrid.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(MyWorkGrid.Year)].CenterColumn();
			dataGridView.Columns[nameof(MyWorkGrid.Type)].Width = 80;
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<MyWorkGrid>();

			if (item == null)
			{
				return;
			}

			myWorkInfoControl.Fill(m_myWork.FirstOrDefault(o => o.ID == item.ID));
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
			m_myWork = Datasource.GetList<MyWork>();

			dataGridMyWork.DataSource = new SortableBindingList<MyWorkGrid>(
				m_myWork
				.Where(o => o.Main)
				.Select(o => Converter.ToMyWorkGrid(o))
				.OrderBy(o => o.Date)
				.ToList());
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var item = myWorkInfoControl.GetItem();

			if (m_myWork.Any(o => o.Title.Trim() == item.Title.Trim()))
			{
				return;
			}

			item.ID = 0;
			item.Date = addButton1.GetDate();
			Datasource.Add(item);
			LoadGridData();
			dataGridMyWork.SelectLastRow();
		}
	}
}