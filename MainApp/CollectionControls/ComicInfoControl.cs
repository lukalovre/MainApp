using Model.Collection;
using System.Windows.Forms;

namespace MainApp.Collection
{
	public partial class ComicInfoControl : UserControl
	{
		public ComicInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(Comic comic)
		{
			textBoxOwner.Text = comic.Owner;
			textBoxTitle.Text = comic.Title;
			textBoxChapter.Text = comic.Chapter.ToString();
			textBoxAuthor.Text = comic.Writer;
			textBoxLanguage.Text = comic.Language;
			textBoxPriceOriginal.Text = comic.Price.ToString();
			textBoxPriceInRSD.Text = comic.PriceInRSD.ToString();
			textBoxGoodreadsID.Text = comic.GoodreadsID.ToString();
		}

		internal Comic GetItem()
		{
			return new Comic
			{
				GoodreadsID = int.Parse(textBoxGoodreadsID.Text),
				Chapter = int.Parse(textBoxChapter.Text),
				Illustrator = null,
				Language = textBoxLanguage.Text,
				Owner = textBoxOwner.Text,
				Price = float.Parse(textBoxPriceOriginal.Text),
				PriceInRSD = float.Parse(textBoxPriceInRSD.Text),
				Title = textBoxTitle.Text,
				Writer = textBoxAuthor.Text
			};
		}
	}
}