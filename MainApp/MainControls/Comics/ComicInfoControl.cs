using Controller;
using Model.dbo;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Comics
{
	public partial class ComicInfoControl : UserControl
	{
		private int m_addedPages;
		private Comic m_comic;
		private List<ComicEvent> m_comicEvents;

		public ComicInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(Comic comic, List<ComicEvent> comicEvents = null)
		{
			m_comic = comic;
			m_comicEvents = comicEvents;

			textBoxTitle.Text = comic.Title;
			textBoxWriter.Text = comic.Writer;
			textBoxIllustrator.Text = comic.Illustrator;
			numericUpDownYear.Value = comic.Year;
			textBoxGoodreadsID.Text = comic.GoodreadsID.ToString();
			checkBox1001.Checked = comic._1001;

			checkBoxReading.Checked = Following.FollowingModel.Comics.Contains(comic.GoodreadsID.ToString());
			checkBoxOngoing.Checked = Following.FollowingModel.ComicsOngoing.Contains(comic.GoodreadsID.ToString());

			if (comicEvents == null || !comicEvents.Any())
			{
				numericUpDownChapters.Value = 1;
				numericUpDownPages.Value = 1;
				checkBoxRead.Checked = false;
				starRatingControl1.SelectedStar = 1;
				listBoxChapters.Items.Clear();
				eventControl1.Clear();

				return;
			}

			numericUpDownChapters.Value = comicEvents.Max(o => o.Chapter);
			numericUpDownPages.Value = comicEvents
				.Where(o => o.Chapter == numericUpDownChapters.Value)
				.Sum(o => o.Pages);
			checkBoxRead.Checked = comicEvents.Any(o => o.Read);
			starRatingControl1.SelectedStar = comicEvents.LastOrDefault().Rating.Value;

			var chapters = comicEvents.DistinctBy(o => o.Chapter).OrderBy(o => o.Chapter);
			listBoxChapters.Items.Clear();

			foreach (var season in chapters)
			{
				listBoxChapters.Items.Add($"Chapter {season.Chapter}: {comicEvents.Where(o => o.Chapter == season.Chapter).Sum(i => i.Pages)}\n");
			}

			listBoxChapters.SelectedIndex = listBoxChapters.Items.Count - 1;

			//duplicate
			var minuterPerPageBooks = 0.3f;

			var events = comicEvents.Select(o => new Model.EventListItem
			{
				ID = o.ID,
				Time = (int)(o.Pages * minuterPerPageBooks),
				Date = o.Date
			}).ToList();

			eventControl1.FIll(events);
		}

		internal ComicEvent GetEvent()
		{
			return new ComicEvent
			{
				GoodreadsID = int.Parse(textBoxGoodreadsID.Text),
				Chapter = (int)numericUpDownChapters.Value,
				Pages = m_addedPages,
				Rating = starRatingControl1.SelectedStar,
				Read = checkBoxRead.Checked
			};
		}

		internal Comic GetItem()
		{
			return new Comic
			{
				GoodreadsID = int.Parse(textBoxGoodreadsID.Text),
				Illustrator = textBoxIllustrator.Text,
				Title = textBoxTitle.Text,
				Writer = textBoxWriter.Text,
				Year = (int)numericUpDownYear.Value,
				_1001 = checkBox1001.Checked
			};
		}

		private void CheckBoxOngoing_CheckedChanged(object sender, EventArgs e)
		{
			Following.Update(checkBoxOngoing.Checked, Following.FollowingModel.ComicsOngoing, m_comic.GoodreadsID.ToString());
		}

		private void CheckBoxReading_CheckedChanged(object sender, EventArgs e)
		{
			Following.Update(checkBoxReading.Checked, Following.FollowingModel.Comics, m_comic.GoodreadsID.ToString());
		}

		private void NumericUpDownChapters_ValueChanged(object sender, EventArgs e)
		{
			UpdatePages();
		}

		private void NumericUpDownPages_ValueChanged(object sender, EventArgs e)
		{
			UpdatePages();
		}

		private void TextBoxGoodreadsID_TextChanged(object sender, EventArgs e)
		{
			UpdatePages(true);
		}

		private void UpdatePages(bool newID = false)
		{
			var chapter = (int)numericUpDownChapters.Value;

			var beforePages = newID || m_comicEvents == null
				? 0
				: m_comicEvents.Where(o => o.Chapter == chapter).Sum(o => o.Pages);

			var nowPages = (int)numericUpDownPages.Value;

			m_addedPages = nowPages - beforePages;

			labelAddingPages.Text = m_addedPages == 0
				? string.Empty
				: $"Adding {m_addedPages} pages";
		}
	}
}