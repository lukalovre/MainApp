using Controller;
using MainApp.Extensions;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.MainControls
{
	public partial class LinksControl : UserControl
	{
		private readonly Dictionary<string, SortableBindingList<LinkGrid>> m_gridBindings = new Dictionary<string, SortableBindingList<LinkGrid>>();
		private List<LinkEvent> m_linkEvents;
		private List<Link> m_links;

		public LinksControl()
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

			m_links = Datasource.GetList<Link>()
				.Where(o => Following.FollowingModel.Links.Contains(o.ID.ToString()))
				.ToList();
			m_linkEvents = Datasource.GetList<LinkEvent>()
				.Where(o => Following.FollowingModel.Links.Contains(o.ItemID.ToString()))
				.ToList();

			var dictGrids = new Dictionary<DataGridView, IEnumerable<Link>>
			{
				{ dataGridViewTwitter, m_links.Where(o => o.Category == "Twitter") },
				{ dataGridViewYouTube, m_links.Where(o => o.Category == "YouTube" && o.SubCategory != "Music") },
				{ dataGridViewYouTubeMusic, m_links.Where(o => o.Category == "YouTube" && o.SubCategory == "Music") },
				{ dataGridViewToRead, m_links.Where(o => o.Category == "ReadingList" && o.SubCategory == "ToRead") },
				{ dataGridViewPaper, m_links.Where(o => o.Category == "ReadingList" && o.SubCategory == "Weekly") },
				{ dataGridViewFuture, m_links.Where(o => o.Category == "ReadingList" && o.SubCategory == "Future") },
				{ dataGridViewWatchlist, m_links.Where(o => o.Category == "ReadingList" && o.SubCategory == "Watchlist") },
				{ dataGridViewDirectors, m_links.Where(o => o.Category == "ReadingList" && o.SubCategory == "Directors") },
				{ dataGridViewAwards, m_links.Where(o => o.Category == "ReadingList" && o.SubCategory == "Awards") },
				{ dataGridViewDucani, m_links.Where(o => o.Category == "Ducani") },
				{ dataGridViewMusicToRead, m_links.Where(o => o.Category == "Music" && o.SubCategory == "ToRead") },
				{ dataGridViewMusicWeekly, m_links.Where(o => o.Category == "Music" && o.SubCategory == "Weekly") },
				{ dataGridViewToolsDaily, m_links.Where(o => o.Category == "Tools" && o.SubCategory == "Daily") },
				{ dataGridViewToolsOther, m_links.Where(o => o.Category == "Tools" && o.SubCategory == string.Empty) }
			};

			var categorisedLinks = new List<Link>();

			foreach (var linkList in dictGrids.Values)
			{
				categorisedLinks.AddRange(linkList);
			}

			dictGrids.Add(dataGridViewOther, m_links.Where(o => !categorisedLinks.Contains(o)));

			foreach (var keyValue in dictGrids)
			{
				var dataGridView = keyValue.Key;
				var linkList = keyValue.Value;

				var bindable = new SortableBindingList<LinkGrid>(
					linkList
					.Select(o => Links.Convert(o, m_linkEvents.Where(l => l.ItemID == o.ID).ToList()))
					.OrderBy(o => o.Title)
					.ToList());

				m_gridBindings.Add(dataGridView.Name, bindable);

				dataGridView.DataSource = bindable;
				SetGrid(dataGridView);
				dataGridView.SelectionChanged += new EventHandler(DataGridView_SelectionChanged);
				dataGridView.DoubleClick += new EventHandler(DataGridView_DoubleClick);
			}
		}

		private void DataGridView_DoubleClick(object sender, EventArgs e)
		{
			var item = linkInfoControl1.GetItem();

			if (item == null)
			{
				return;
			}

			Web.OpenLink(item.Url);

			AddLink(item);
		}

		private void AddLink(Link item)
		{
			if (item == null)
			{
				return;
			}

			var linkEvent = new LinkEvent
			{
				Date = DateTime.Now,
				ItemID = item.ID
			};

			Datasource.Add(linkEvent);
			m_linkEvents.Add(linkEvent);

			var dataGridView = tabControl1.GetSelectedGrid();
			m_gridBindings[dataGridView.Name].FirstOrDefault(o => o.ID == item.ID).Count++;

			dataGridView.Refresh();
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var item = linkInfoControl1.GetItem();

			Datasource.Add(item);
			m_links.Add(item);

			var dataGridView = tabControl1.GetSelectedGrid();
			m_gridBindings[dataGridView.Name].Add(Links.Convert(item, m_linkEvents.Where(l => l.ItemID == item.ID).ToList()));

			Following.Update(true, Following.FollowingModel.Links, item.ID.ToString());

			dataGridView.SelectLastRow();

			AddLink(item);
		}

		private void ButtonUnfollow_Click(object sender, EventArgs e)
		{
			var item = linkInfoControl1.GetItem();
			Following.Update(false, Following.FollowingModel.Links, item.ID.ToString());

			var dataGridView = tabControl1.GetSelectedGrid();
			var gridItem = m_gridBindings[dataGridView.Name].FirstOrDefault(o => o.ID == item.ID);
			m_gridBindings[dataGridView.Name].Remove(gridItem);

			dataGridView.Refresh();
		}

		private void ButtonUpdate_Click(object sender, EventArgs e)
		{
			var item = linkInfoControl1.GetItem();

			Datasource.Update(item);

			var link = m_links.FirstOrDefault(o => o.ID == item.ID);
			link = item;

			var dataGridView = tabControl1.GetSelectedGrid();
			var linkGrid = m_gridBindings[dataGridView.Name].FirstOrDefault(o => o.ID == item.ID);
			linkGrid = Links.Convert(item, m_linkEvents.Where(l => l.ItemID == item.ID).ToList());

			linkInfoControl1.Fill(m_links.FirstOrDefault(o => o.ID == item.ID), m_linkEvents.Where(o => o.ItemID == item.ID).ToList());

			dataGridView.Refresh();
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			var item = (sender as DataGridView).GetRowObject<LinkGrid>();

			if (item == null)
			{
				return;
			}

			linkInfoControl1.Fill(m_links.FirstOrDefault(o => o.ID == item.ID), m_linkEvents.Where(o => o.ItemID == item.ID).ToList());
		}

		private void SetGrid(DataGridView dataGridView)
		{
			dataGridView.SetGrid();

			dataGridView.Columns[nameof(LinkGrid.Title)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns[nameof(LinkGrid.Count)].CenterColumn();
		}
	}
}