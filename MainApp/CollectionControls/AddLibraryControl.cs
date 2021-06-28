using System;
using System.Windows.Forms;

namespace MainApp.Collection.Library
{
	public partial class AddLibraryControl : UserControl
	{
		public AddLibraryControl()
		{
			InitializeComponent();
		}

		private void Add()
		{
			var itemID = textBoxItemID.Text;
			var title = SQLHelper.EscapeSpecialCharacters(textBoxTitle.Text);
			var type = textBoxType.Text;
			var lentTo = textBoxLentTo.Text;

			var commandText = $@"
EXECUTE [Collection].[AddLibrary]
   {itemID}
  ,'{title}'
  ,{type}
  ,{lentTo}";

			SqlConnectionExtension.ExecuteNonQuery(commandText);
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			Add();
			LibraryControl.Instance.ShowComicsCollectionInGrid();
		}
	}
}