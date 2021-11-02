using Controller;
using Controller.Extensions;
using Model;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MainApp
{
	public partial class ImdbListControl : UserControl
	{
		private SortableBindingList<ImdbList> m_dataSource;
		private IEnumerable<string> m_filter;
		private string m_listName;

		public ImdbListControl()
		{
			InitializeComponent();
		}

		public static ImdbListControl Init(string listName, IEnumerable<string> filter)
		{
			return new ImdbListControl
			{
				m_listName = listName,
				m_filter = filter
			};
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			dataGridView.DataSource = m_dataSource = new SortableBindingList<ImdbList>(CsvHelper.GetFromList<ImdbListItem>(Paths.Imdb, m_listName)
				.Where(o => !m_filter.Contains(o.Imdb))
				.Select(o => Convert(o))
				.ToList());

			SetGrid(dataGridView);
		}

		private static ImdbList Convert(ImdbListItem o)
		{
			return new ImdbList
			{
				Director = o.Directors,
				Imdb = o.Imdb,
				Rating = o.IMDbRating,
				Runtime = o.Runtime,
				Title = o.Title,
				Votes = o.NumVotes,
				Year = o.Year,
				_1001 = Controller._1001.Is1001(o.Imdb)
			};
		}

		private static void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();
			dataGridView.Height = 580;

			dataGridView.Columns[nameof(ImdbList.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(ImdbList.Director)].Width = 100;
			dataGridView.Columns[nameof(ImdbList.Runtime)].Width = 30;
			dataGridView.Columns[nameof(ImdbList.Votes)].Width = 50;
			dataGridView.Columns[nameof(ImdbList.Rating)].Width = 30;
			dataGridView.Columns[nameof(ImdbList.Year)].CenterColumn();
			dataGridView.Columns[nameof(ImdbList._1001)].CenterColumn();
		}

		private void ButtonOpenLink_Click(object sender, EventArgs e)
		{
			var imdbListItem = dataGridView.GetRowObject<ImdbList>();

			Imdb.OpenLink(imdbListItem);
		}

		private void TextBoxFilter_TextChanged(object sender, EventArgs e)
		{
			var filter = (sender as TextBox).Text;

			dataGridView.DataSource = new SortableBindingList<ImdbList>(m_dataSource.Where(o => o.Imdb == filter
										  || o.Director.Contains(filter, StringComparison.OrdinalIgnoreCase)
										  || o.Title.Contains(filter, StringComparison.OrdinalIgnoreCase)
										  || o.Year.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList());
		}
	}
}