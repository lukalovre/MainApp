using Controller;
using Controller.Extensions;
using Model;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MainApp
{
	public partial class ImdbListControl : UserControl
	{
		private SortableBindingList<ImdbList> m_dataSource;
		private string m_downloadUrl;
		private FileType m_fileType;
		private Type m_type;
		private List<string> m_hiddenColumns;
		private string m_listName;
		private DateTime m_updatedDate;

		public ImdbListControl()
		{
			InitializeComponent();

			dataGridView.CellClick += CellClick;
		}

		public enum FileType
		{
			CSV,
			HTM
		}

		public static ImdbListControl Init(
			string listName,
			Type type,
			string downloadUrl,
			FileType fileType = FileType.CSV,
			List<string> hiddenColumns = null)
		{
			return new ImdbListControl
			{
				m_listName = listName,
				m_type = type,
				m_fileType = fileType,
				m_downloadUrl = downloadUrl,
				m_hiddenColumns = hiddenColumns
			};
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			LoadGridData();

			SetGrid(dataGridView);
		}

		private void LoadGridData()
		{
			var filter = new List<string>();

			if (m_type == typeof(TVShow))
			{
				filter = Datasource.GetList<TVShow>().Select(o => o.Imdb).ToList();
			}

			if (m_type == typeof(Movie))
			{
				filter = Datasource.GetList<Movie>().Select(o => o.Imdb).ToList();

				// Because of Dekalog, Riget etc.
				filter.AddRange(Datasource.GetList<TVShow>().Select(o => o.Imdb));
			}

			var imdbFromList = m_fileType == FileType.CSV
				? CsvHelper.GetFromList<ImdbListItem>(Paths.Imdb, m_listName, out m_updatedDate)
				: HtmlHelper.GetFromList(Paths.Imdb, m_listName, filter, out m_updatedDate);

			dataGridView.DataSource = m_dataSource = new SortableBindingList<ImdbList>(
				imdbFromList
				.Where(o => !filter.Contains(o.Imdb))
				.Select(o => Convert(o))
				.ToList());
		}

		private void CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == -1)
			{
				LoadGridData();
			}
		}

		private static ImdbList Convert(ImdbListItem o)
		{
			return new ImdbList
			{
				Director = o.Directors,
				Imdb = o.Imdb,
				Rating = o.IMDbRating,
				Metascore = o.Metascore,
				Runtime = o.Runtime,
				Title = o.Title,
				Votes = o.NumVotes,
				Year = o.Year,
				_1001 = Controller._1001.Is1001(o.Imdb),
				Position = o.Position
			};
		}

		private void ButtonDownload_Click(object sender, EventArgs e)
		{
			Web.DownloadFile(m_downloadUrl, Path.Combine(Paths.Imdb, m_listName), m_fileType.ToString());

			var pathOldJson = Path.Combine(Paths.Imdb, $"{m_listName}.json");

			if (File.Exists(pathOldJson))
			{
				File.Delete(pathOldJson);
			}

			OnLoad(null);
		}

		private void ButtonDownload_MouseHover(object sender, EventArgs e)
		{
			toolTipDownload.SetToolTip(buttonDownload, $"Last download on {m_updatedDate:d}");
		}

		private void ButtonOpenList_Click(object sender, EventArgs e)
		{
			Web.OpenLink(m_downloadUrl.TrimEnd("/export?ref_=ttls_otexp".ToCharArray()));
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();
			dataGridView.Location = new System.Drawing.Point(0, 35);
			dataGridView.Height = 580;

			dataGridView.Columns[nameof(ImdbList.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(ImdbList.Director)].Width = 100;
			dataGridView.Columns[nameof(ImdbList.Runtime)].Width = 30;
			dataGridView.Columns[nameof(ImdbList.Votes)].Width = 50;
			dataGridView.Columns[nameof(ImdbList.Rating)].Width = 30;
			dataGridView.Columns[nameof(ImdbList.Metascore)].Width = 30;
			dataGridView.Columns[nameof(ImdbList.Position)].Width = 30;
			dataGridView.Columns[nameof(ImdbList.Year)].CenterColumn();
			dataGridView.Columns[nameof(ImdbList._1001)].CenterColumn();
			dataGridView.Columns[nameof(ImdbList._1001)].HeaderText = "1001";

			if (m_hiddenColumns != null)
			{
				foreach (var hiddenColumn in m_hiddenColumns)
				{
					dataGridView.Columns[hiddenColumn].Visible = false;
				}
			}

			dataGridView.DoubleClick += new EventHandler(DataGridView_DoubleClick);
		}

		private void DataGridView_DoubleClick(object sender, EventArgs e)
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