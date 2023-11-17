using Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainApp.CommonControls
{
	public partial class EvenControl : UserControl
	{
		private string m_oldComment;

		public EvenControl()
		{
			InitializeComponent();
		}

		public int? Rating => starRatingControl1.SelectedStar;

		public void Fill(
			Event eventItem,
			List<EventListItem> eventList,
			EventListControl.CountValue countValue = EventListControl.CountValue.Minutes)
		{
			if (eventItem == null)
			{
				Clear();
				return;
			}

			eventListControl1.Fill(eventList, countValue);
			starRatingControl1.SelectedStar = eventItem.Rating ?? 1;
			richTextBoxComment.Text = eventItem.Comment;
			peopleListControl1.FillPeople(eventItem);
			m_oldComment = eventItem.Comment ?? string.Empty;
		}

		public void SetEventListDefaultInterval(EventListControl.Interval interval)
		{
			eventListControl1.DefaultInterval = interval;
		}

		internal void Clear()
		{
			starRatingControl1.SelectedStar = 1;
			m_oldComment = string.Empty;
			eventListControl1.Clear();
		}

		internal string GetComment()
		{
			var comment = m_oldComment.Trim() == richTextBoxComment.Text.Trim()
				? null
				: richTextBoxComment.Text;

			return string.IsNullOrWhiteSpace(comment)
				? null
				: comment.Trim();
		}

		internal string GetPeople()
		{
			return peopleListControl1.GetCheckedCSV();
		}
	}
}