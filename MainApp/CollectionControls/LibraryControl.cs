using Controller;
using Model.Collection;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Collection
{
	public partial class LibraryControl : UserControl
	{
		private SortableBindingList<Library> m_bindingList;

		public LibraryControl()
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

			var library = Database.GetList<Library>();
			var lent = library
				.Where(o => o.ReturnDate == null)
				.OrderBy(o => o.LentDate)
				.ToList();

			m_bindingList = new SortableBindingList<Library>(lent);

			dataGridViewAll.DataSource = m_bindingList;

			SetGridAll(dataGridViewAll);
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var item = libraryInfo.GetItem();
			item.LentDate = DateTime.Now;

			Database.Add(item);
			m_bindingList.Add(item);

			dataGridViewAll.SelectLastRow();
		}

		private void ButtonReturned_Click(object sender, EventArgs e)
		{
			var item = libraryInfo.GetItem();
			item.ReturnDate = DateTime.Now;

			Database.Update(item);
			m_bindingList.Remove(m_bindingList.FirstOrDefault(o => o.ID == item.ID));

			dataGridViewAll.SelectLastRow();
		}

		private void DataGridViewAll_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<Library>();

			if (item == null)
			{
				return;
			}

			libraryInfo.Fill(item);
		}

		private void SetGridAll(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.SetColumns(new string[]{
			nameof(Library.Title),
			nameof(Library.Type),
			nameof(Library.LentTo),
			nameof(Library.LentDate)});

			dataGridView.Columns[nameof(Library.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(Library.Type)].CenterColumn();
			dataGridView.Columns[nameof(Library.LentTo)].CenterColumn();
			dataGridView.Columns[nameof(Library.LentDate)].CenterColumn();
		}
	}
}