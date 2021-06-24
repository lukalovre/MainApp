using Model.dbo;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Standups
{
	public partial class StandupsControl : UserControl
	{
		private BindingList<Standup> m_bindingList;

		public StandupsControl()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if(DesignMode)
			{
				return;
			}

			m_bindingList = new BindingList<Standup>(Controller.Database.GetList<Standup>());
			dataGridViewStandup.DataSource = new BindingSource(m_bindingList, null);

			SetGrid();

			dataGridViewStandup.SelectLastRow();
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var standup = standupInfo1.GetStandup();

			standup.Date = DateTime.Now;

			Controller.Database.Add(standup);
			m_bindingList.Add(standup);

			dataGridViewStandup.SelectLastRow();
			textBoxImdb.Clear();
		}

		private void DataGridViewStandup_SelectionChanged(object sender, EventArgs e)
		{
			var standup = (sender as DataGridView).GetRowObject<Standup>();
			standupInfo1.FillData(standup);
		}

		private void SetGrid()
		{
			dataGridViewStandup.SetGrid();

			dataGridViewStandup.SetColumns(new string[] {
			nameof(Standup.Performer),
			nameof(Standup.Title),
			nameof(Standup.Year)});

			dataGridViewStandup.Columns[nameof(Standup.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewStandup.Columns[nameof(Standup.Performer)].Width = 130;
			dataGridViewStandup.Columns[nameof(Standup.Year)].CenterColumn();
		}

		private void TextBoxImdb_TextChanged(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBoxImdb.Text))
			{
				return;
			}

			textBoxImdb.TextChanged -= TextBoxImdb_TextChanged;

			var standup = Controller.Standups.GetStandup(textBoxImdb.Text);

			if(standup != null)
			{
				textBoxImdb.Text = standup.Imdb;
				standupInfo1.FillData(standup);
			}

			textBoxImdb.TextChanged += TextBoxImdb_TextChanged;
		}
	}
}