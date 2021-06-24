using Model.Collection;
using System;
using System.Windows.Forms;

namespace MainApp.Collection.Books
{
	public partial class BookInfo : UserControl
	{
		private Book m_book;

		public BookInfo()
		{
			InitializeComponent();
		}

		internal void Fill(Book book)
		{
			m_book = book;

			textBoxTitle.Text = book.Title;
			textBoxAuthor.Text = book.Author;
			numericUpDownYear.Value = book.Year == null ? 0 : book.Year.Value;
			checkBox1001.Checked = book._1001;
			numericUpDownPages.Value = book.Pages == null ? 0 : book.Pages.Value;
			textBoxType.Text = book.Type;
			textBoxGoodreadsID.Text = book.GoodreadsID.ToString();
			textBoxPrice.Text = book.Price.ToString();
			textBoxPriceInRSD.Text = book.PriceInRSD.ToString();
			checkBoxPlanToRead.Checked = book.PlanToRead;
		}

		internal Book GetItem()
		{
			return new Book
			{
				PlanToRead = checkBoxPlanToRead.Checked,
				Author = textBoxAuthor.Text.Trim(),
				Date = DateTime.Now,
				EminaRating = 0,
				EminaRead = false,
				GoodreadsID = string.IsNullOrEmpty(textBoxGoodreadsID.Text)
	? null
	: (int?)int.Parse(textBoxGoodreadsID.Text),
				LukaRead = false,
				Pages = numericUpDownPages.Value == 0
	? null : (int?)numericUpDownPages.Value,
				Price = string.IsNullOrEmpty(textBoxPrice.Text)
	? null
	: (float?)float.Parse(textBoxPrice.Text),
				PriceInRSD = string.IsNullOrEmpty(textBoxPriceInRSD.Text)
	? null
	: (float?)float.Parse(textBoxPriceInRSD.Text),
				Title = textBoxTitle.Text,
				Type = textBoxType.Text,
				Year = numericUpDownYear.Value == 0
	? null
	: (int?)numericUpDownYear.Value,
				_1001 = checkBox1001.Checked
			};
		}
	}
}