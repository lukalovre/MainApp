using Controller;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.MainControls
{
	public partial class LinkInfoControl : UserControl
	{
		private Link m_item;

		public LinkInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(Link item, List<LinkEvent> linkEvents)
		{
			m_item = item;

			var createdAt = linkEvents.FirstOrDefault()?.Date ?? DateTime.Now;

			comboBoxCategory.Text = item.Category;
			comboBoxSubCategory.Text = item.SubCategory;
			textBoxTitle.Text = item.Title;

			textBoxUrl.TextChanged -= new EventHandler(TextBoxUrl_TextChanged);
			textBoxUrl.Text = item.Url;
			textBoxUrl.TextChanged += new EventHandler(TextBoxUrl_TextChanged);

			labelCreatedAt.Text = $"Created at: {createdAt:Y}";

			var events = linkEvents.Select(o => new Model.EventListItem
			{
				ID = o.ID,
				CountValue = 1,
				Date = o.Date
			}).ToList();

			eventControl1.Fill(events, EventListControl.CountValue.None);
		}

		internal Link GetItem()
		{
			return new Link
			{
				Category = comboBoxCategory.Text,
				SubCategory = comboBoxSubCategory.Text,
				Title = textBoxTitle.Text.Trim(),
				Url = textBoxUrl.Text,
				ID = m_item.ID
			};
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			var categories = new List<string>
			  { "ReadingList",
				"Ducani",
				"Music",
				"Tools",
				"YouTube"
			};

			comboBoxCategory.Items.AddRange(categories.OrderBy(o => o).ToArray());

			var subCategories = new List<string>
			{
				"ToRead",
				"Weekly",
				"Future",
				"Watchlist",
				"Tools",
				"Daily",
				"Music"
			};

			comboBoxSubCategory.Items.AddRange(subCategories.OrderBy(o => o).ToArray());

			textBoxUrl.TextChanged -= new EventHandler(TextBoxUrl_TextChanged);
			textBoxUrl.TextChanged += new EventHandler(TextBoxUrl_TextChanged);
		}

		private void TextBoxUrl_TextChanged(object sender, EventArgs e)
		{
			var url = textBoxUrl.Text;
			var title = Links.GetTitle(url);
			textBoxTitle.Text = title.Trim();
		}
	}
}