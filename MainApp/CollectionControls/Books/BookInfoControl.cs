using Controller;
using Model.Collection;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Collection.Books
{
	public partial class BookInfoControl : UserControl
	{
		private Book m_book;

		public BookInfoControl()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			comboBoxType.Items.AddRange(Datasource.GetList<Book>().Where(o => o.Type != null).Select(o => o.Type).Distinct().ToArray());
		}

		public delegate void RefreshGridDelegate();

		public event RefreshGridDelegate RefreshGrid;

		internal void Fill(Book book)
		{
			m_book = book;

			textBoxTitle.Text = book.Title;
			textBoxAuthor.Text = book.Author;
			numericUpDownYear.Value = book.Year == null ? 0 : book.Year.Value;
			checkBox1001.Checked = book._1001;
			numericUpDownPages.Value = book.Pages == null ? 0 : book.Pages.Value;
			comboBoxType.Text = book.Type;
			textBoxGoodreadsID.Text = book.GoodreadsID.ToString();
			textBoxPrice.Text = book.Price.ToString();
			textBoxPriceInRSD.Text = book.PriceInRSD.ToString();

			checkBoxPlanToRead.CheckedChanged -= new EventHandler(CheckBoxPlanToRead_CheckedChanged);
			checkBoxPlanToRead.Checked = Following.FollowingModel.BooksCollection.Contains(book.GoodreadsID.ToString());
			checkBoxPlanToRead.CheckedChanged += new EventHandler(CheckBoxPlanToRead_CheckedChanged);
		}

		internal Book GetItem()
		{
			return new Book
			{
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
				Type = comboBoxType.Text,
				Year = numericUpDownYear.Value == 0
	? null
	: (int?)numericUpDownYear.Value,
				_1001 = checkBox1001.Checked
			};
		}

		private void CheckBoxPlanToRead_CheckedChanged(object sender, EventArgs e)
		{
			Following.Update(checkBoxPlanToRead.Checked, Following.FollowingModel.BooksCollection, m_book.GoodreadsID.ToString());
			RefreshGrid();
		}
	}
}