using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static MainApp.DataGridCustom;

namespace MainApp.My_work
{
	public partial class MyWork : UserControl
	{
		public static MyWork Instance;

		public MyWork()
		{
			InitializeComponent();
			Instance = this;
		}

		internal void LoadData()
		{
			var query = @"SELECT * FROM [Main].[dbo].[View My work]";

			var gridColumnList = new List<GridColumn>
			{
			new GridColumn(Table.ID),
			new GridColumn(Table.Title),
			new GridColumn(Table.Collaborators,visible:false),
			new GridColumn(Table.Date, typeof(DateTime)),
			new GridColumn(Table.Public, typeof(bool),visible:false),
			new GridColumn(Table.Type),
			new GridColumn(Table.Location,visible:false),
			new GridColumn(Table.PublicLocation,visible:false),
			new GridColumn(Table.Finished,typeof(bool)),
			};

			dataGridCustom1.FillGrid(query, gridColumnList);

			dataGridCustom1.Sort(this.dataGridCustom1.Columns[Table.Date], ListSortDirection.Ascending);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			LoadData();
		}
	}
}