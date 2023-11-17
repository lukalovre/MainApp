using Model.Collection;
using System.Windows.Forms;

namespace MainApp.Collection
{
	public partial class ComicInfoControl : UserControl
	{
		private Comic m_comic;

		public ComicInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(Comic comic)
		{
			m_comic = comic;

			textBoxOwner.Text = comic.Owner;
			textBoxTitle.Text = comic.Title;
			numericUpDownChapter.Value = comic.Chapter == 0 ? 1 : comic.Chapter;
			textBoxAuthor.Text = comic.Writer;
			textBoxLanguage.Text = comic.Language;
			textBoxPriceOriginal.Text = comic.Price.ToString();
			textBoxPriceInRSD.Text = comic.PriceInRSD.ToString();
			textBoxGoodreadsID.Text = comic.GoodreadsID.ToString();
		}

		internal Comic GetItem()
		{
			float? price = null;

			if (float.TryParse(textBoxPriceOriginal.Text, out var result))
			{
				price = result;
			}

			float? priceInRSD = null;

			if (float.TryParse(textBoxPriceInRSD.Text, out var resultRSD))
			{
				priceInRSD = resultRSD;
			}

			return new Comic
			{
				GoodreadsID = string.IsNullOrWhiteSpace(textBoxGoodreadsID.Text) ? 0 : int.Parse(textBoxGoodreadsID.Text),
				Chapter = (int)numericUpDownChapter.Value,
				Illustrator = null,
				Language = textBoxLanguage.Text,
				Owner = textBoxOwner.Text,
				Price = price,
				PriceInRSD = priceInRSD,
				Title = textBoxTitle.Text,
				Writer = textBoxAuthor.Text
			};
		}
	}
}