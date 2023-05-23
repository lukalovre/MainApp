using Controller;
using Model.Collection;
using System;
using System.Linq;
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

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			comboBoxLentTo.Items.AddRange(Datasource.GetList<Library>().Select(o => o.LentTo).Distinct().ToArray());
		}

		internal void Fill(Library item)
		{
			m_item = item;

			textBoxType.Text = item.Type;
			textBoxItemID.Text = item.ItemID.ToString();
			comboBoxLentTo.Text = item.LentTo;
			textBoxTitle.Text = item.Title;
		}

		internal Library GetItem()
		{
			return new Library
			{
				ItemID = int.Parse(textBoxItemID.Text),
				LentTo = comboBoxLentTo.Text,
				Title = textBoxTitle.Text,
				Type = textBoxType.Text,
				LentDate = m_item.LentDate,
				ReturnDate = m_item.ReturnDate,
				ID = m_item.ID
			};
		}
	}
}