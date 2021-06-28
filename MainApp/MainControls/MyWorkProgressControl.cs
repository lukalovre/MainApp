using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static MainApp.DataGridCustom;

namespace MainApp.My_work_progress
{
	public partial class MyWorkProgressControl : UserControl
	{
		public static MyWorkProgressControl Instance;

		public MyWorkProgressControl()
		{
			InitializeComponent();
			Instance = this;
		}

		public void ShowDataInGrid()
		{
			var query = @"SELECT * FROM [Main].[dbo].[View My work progress]";

			var gridColumnList = new List<GridColumn>
			{
			new GridColumn("ItemID"),
			new GridColumn("Title"),
			new GridColumn("Type"),
			new GridColumn("Time"),
			new GridColumn("Last", typeof(DateTime))
			};

			dataGridCustom1.FillGrid(query, gridColumnList);

			if(dataGridCustom1.Columns["Date"] != null)
			{
				dataGridCustom1.Sort(dataGridCustom1.Columns["Date"], ListSortDirection.Ascending);
			}

			for(int i = 0; i < dataGridCustom1.Rows.Count; ++i)
			{
				dataGridCustom1.Rows[i].Cells["Time"].Value = GetTimeFormated(dataGridCustom1.Rows[i].Cells["Time"].Value.ToString());
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if(DesignMode)
			{
				return;
			}

			ShowDataInGrid();
		}

		private string GetTimeFormated(string minutes)
		{
			var hr = Convert.ToInt32(minutes) / 60;
			var min = Convert.ToInt32(minutes) % 60;

			return $"{hr} hr {min} min";
		}
	}
}