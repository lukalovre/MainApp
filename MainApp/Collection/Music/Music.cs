using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static MainApp.DataGridCustom;

namespace MainApp.Collection.Music
{
	public partial class Music : UserControl
	{
		public static Music Instance;

		public Music()
		{
			InitializeComponent();
			Instance = this;

			ShowComicsCollectionInGrid();
		}

		public void ShowComicsCollectionInGrid()
		{
			var query = @"	SELECT *
							FROM [Main].[Collection].[Music]
							ORDER BY [Date buy]";

			var gridColumnList = new List<GridColumn>
			{
				new GridColumn(Table.Artist),
				new GridColumn(Table.Title),
				new GridColumn(Table.Year, typeof(int)),
				new GridColumn(Table.Format),
				new GridColumn(Table.DateBuy, typeof(DateTime))
			};

			dataGridCustom1.FillGrid(query, gridColumnList);

			dataGridCustom1.Columns[Table.Format].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridCustom1.Columns[Table.Format].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
		}
	}
}