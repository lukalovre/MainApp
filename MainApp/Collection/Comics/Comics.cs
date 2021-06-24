using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static MainApp.DataGridCustom;

namespace MainApp.Collection.Comics
{
	public partial class Comics : UserControl
	{
		internal static Comics Instance;

		public Comics()
		{
			InitializeComponent();
			Instance = this;
			ShowComicsCollectionInGrid();
		}

		public void ShowComicsCollectionInGrid()
		{
			var query = @"SELECT * FROM [Main].[Collection].[Comics]";

			var gridColumnList = new List<GridColumn>
			{
			new GridColumn("Owner"),
			new GridColumn("Title"),
			new GridColumn("Chapter"),
			new GridColumn("Writer"),
			new GridColumn("Illustrator"),
			new GridColumn("Language"),
			new GridColumn("Price",typeof(float)),
			new GridColumn("Price in RSD",typeof(float)),
			new GridColumn("Date buy",typeof(DateTime)),
			new GridColumn("GoodreadsID")
			};

			dataGridView1.FillGrid(query, gridColumnList);
		}
	}
}