using System.Windows.Forms;

namespace MainApp.Collection.Comics
{
	public partial class AddComicCollection : UserControl
	{
		public AddComicCollection()
		{
			InitializeComponent();
		}

		private void BtnAddComicCollection_Click(object sender, System.EventArgs e)
		{
			var owner = SQLHelper.GetText(textBoxOwner.Text);
			var title = SQLHelper.GetText(textBoxTitle.Text);
			var chapter = SQLHelper.GetText(textBoxChapter.Text);
			var author = SQLHelper.GetText(textBoxAuthor.Text);
			var illustrator = SQLHelper.GetText(null);
			var language = SQLHelper.GetText(textBoxLanguage.Text);
			var price = SQLHelper.GetText(textBoxPriceOriginal.Text);
			var priceInRSD = SQLHelper.GetText(textBoxPriceInRSD.Text);
			var goodreadsID = SQLHelper.GetText(textBoxGoodreadsID.Text);

			var commandText = $@"EXECUTE [dbo].[AddComicCollection]
   {owner}
  ,{title}
  ,{chapter}
  ,{author}
  ,{illustrator}
  ,{language}
  ,{goodreadsID}
  ,{price}
  ,{priceInRSD}";

			SqlConnectionExtension.ExecuteNonQuery(commandText);

			Comics.Instance.ShowComicsCollectionInGrid();
		}
	}
}