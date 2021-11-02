using Model.Collection;
using System.Windows.Forms;

namespace MainApp.Collection
{
	public partial class LibraryInfoControl : UserControl
	{
		private Library m_item;

		public LibraryInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(Library item)
		{
			m_item = item;

			textBoxType.Text = item.Type;
			textBoxItemID.Text = item.ItemID;
			textBoxLentTo.Text = item.LentTo;
			textBoxTitle.Text = item.Title;
		}

		internal Library GetItem()
		{
			return new Library
			{
				ItemID = textBoxItemID.Text,
				LentTo = textBoxLentTo.Text,
				Title = textBoxTitle.Text,
				Type = textBoxType.Text,
				LentDate = m_item.LentDate,
				ReturnDate = m_item.ReturnDate,
				ID = m_item.ID
			};
		}
	}
}