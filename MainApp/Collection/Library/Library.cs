using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static MainApp.DataGridCustom;

namespace MainApp.Collection.Library
{
	public partial class Library : UserControl
	{
		public static Library Instance;

		public Library()
		{
			InitializeComponent();
			Instance = this;
		}

		public void ShowComicsCollectionInGrid()
		{
			var query = @"SELECT * FROM [Main].[Collection].[Library rented]";

			var gridColumnList = new List<GridColumn>
			{
				new GridColumn("ID"),
				new GridColumn("Title"),
				new GridColumn("ItemID"),
				new GridColumn("Type"),
				new GridColumn("Lent to"),
				new GridColumn("Lent before days"),
			};

			dataGridCustom1.FillGrid(query, gridColumnList);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			ShowComicsCollectionInGrid();
		}

		private void buttonReturned_Click(object sender, EventArgs e)
		{
			string id = dataGridCustom1.SelectedID;

			var commandText = $@"
			EXECUTE[dbo].[UpdateLibrary]
            {id}";

			SqlConnectionExtension.ExecuteNonQuery(commandText);

			ShowComicsCollectionInGrid();
		}
	}
}