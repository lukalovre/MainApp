using Controller;
using Model.dbo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Comics
{
	public partial class ComicInfo : UserControl
	{
		private int m_addedPages;
		private Comic m_comic;
		private List<ComicEvent> m_comicEvents;

		public ComicInfo()
		{
			InitializeComponent();
		}

		internal void Fill(Comic comic, List<ComicEvent> comicEvents)
		{
			m_comic = comic;
			m_comicEvents = comicEvents;

			textBoxTitle.Text = comic.Title;
			textBoxWriter.Text = comic.Writer;
			textBoxIllustrator.Text = comic.Illustrator;
			numericUpDownYear.Value = comic.Year;
			numericUpDownChapters.Value = comicEvents.Max(o => o.Chapter);
			numericUpDownPages.Value = comicEvents
				.Where(o => o.Chapter == numericUpDownChapters.Value)
				.Sum(o => o.Pages);
			textBoxGoodreadsID.Text = comic.GoodreadsID.ToString();
			checkBox1001.Checked = comic._1001;
			checkBoxRead.Checked = comicEvents.Any(o => o.Read);
			starRatingControl1.SelectedStar = comicEvents.LastOrDefault().Rating.Value;

			checkBoxReading.Checked = FormMain.Following.Comics.Contains(comic.GoodreadsID.ToString());
			checkBoxOngoing.Checked = FormMain.Following.ComicsOngoing.Contains(comic.GoodreadsID.ToString());
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
			if(checkBoxOngoing.Checked)
			{
				if(!FormMain.Following.ComicsOngoing.Contains(m_comic.GoodreadsID.ToString()))
				{
					FormMain.Following.ComicsOngoing.Add(m_comic.GoodreadsID.ToString());
				}
			}
			else
			{
				FormMain.Following.ComicsOngoing.Remove(m_comic.GoodreadsID.ToString());
			}

			string json = JsonConvert.SerializeObject(FormMain.Following, Formatting.Indented);
			File.WriteAllText(Paths.Following, json);
		}

		private void CheckBoxReading_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxReading.Checked)
			{
				if(!FormMain.Following.Comics.Contains(m_comic.GoodreadsID.ToString()))
				{
					FormMain.Following.Comics.Add(m_comic.GoodreadsID.ToString());
				}
			}
			else
			{
				FormMain.Following.Comics.Remove(m_comic.GoodreadsID.ToString());
			}

			string json = JsonConvert.SerializeObject(FormMain.Following, Formatting.Indented);
			File.WriteAllText(Paths.Following, json);
		}

		private void NumericUpDownPages_ValueChanged(object sender, EventArgs e)
		{
			var chapter = (int)numericUpDownChapters.Value;
			var beforePages = m_comicEvents.Where(o => o.Chapter == chapter).Sum(o => o.Pages);
			var nowPages = (int)(sender as NumericUpDown).Value;

			m_addedPages = nowPages - beforePages;

			labelAddingPages.Text = m_addedPages == 0
				? string.Empty
				: $"Adding {m_addedPages} pages";
		}
	}
}