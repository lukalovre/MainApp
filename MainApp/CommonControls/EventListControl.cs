using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp
{
	public partial class EventListControl : UserControl
	{
		public Interval DefaultInterval = Interval.Months;

		private List<EventListItem> m_eventList;
		private CountValue m_countValue;

		public EventListControl()
		{
			InitializeComponent();
		}

		public enum Interval
		{
			All = 0,
			Days = 1,
			Months = 2,
			Years = 3
		}

		public enum CountValue
		{
			None = 0,
			Minutes = 1,
			Pages = 2,
		}

		public void Fill(List<EventListItem> eventList, CountValue countValue = CountValue.Minutes)
		{
			m_eventList = eventList;
			m_countValue = countValue;

			eventList = eventList.Where(o => o.Date.HasValue).ToList();

			listBoxEvents.Items.Clear();

			if (comboBoxIntervals.SelectedIndex == (int)Interval.All)
			{
				foreach (var @event in eventList)
				{
					string countValueFormat = GetCountValueFormat(countValue, @event.CountValue);
					listBoxEvents.Items.Add($"{@event.Date}: {countValueFormat}");
				}
			}

			if (comboBoxIntervals.SelectedIndex == (int)Interval.Years)
			{
				var yearList = eventList
					.Select(o => o.Date.Value.Year)
					.Distinct();

				foreach (var year in yearList)
				{
					var time = eventList
						.Where(o => o.Date.Value.Year == year)
						.Sum(o => o.CountValue);

					string countValueFormat = GetCountValueFormat(countValue, time);
					listBoxEvents.Items.Add($"{year}: {countValueFormat}");
				}
			}

			if (comboBoxIntervals.SelectedIndex == (int)Interval.Months)
			{
				var yearList = eventList.Select(o => o.Date.Value.Year).Distinct();

				foreach (var year in yearList)
				{
					var monthList = eventList
						.Where(o => o.Date.Value.Year == year)
						.Select(o => o.Date.Value.Month)
						.Distinct();

					foreach (var month in monthList)
					{
						var time = eventList
							.Where(o => o.Date.Value.Year == year && o.Date.Value.Month == month)
							.Sum(o => o.CountValue);

						string countValueFormat = GetCountValueFormat(countValue, time);
						listBoxEvents.Items.Add($"{year} {month}: {countValueFormat}");
					}
				}
			}

			if (comboBoxIntervals.SelectedIndex == (int)Interval.Days)
			{
				var dayList = eventList
					.Select(o => o.Date.Value.Date)
					.Distinct();

				foreach (var day in dayList)
				{
					var time = eventList
						.Where(o => o.Date.Value.Date == day)
						.Sum(o => o.CountValue);

					string countValueFormat = GetCountValueFormat(countValue, time);
					listBoxEvents.Items.Add($"{day}: {countValueFormat}");
				}
			}

			listBoxEvents.SelectedIndex = listBoxEvents.Items.Count - 1;
		}

		private static string GetCountValueFormat(CountValue countValue, int count)
		{
			var countValueFormat = $"{count} times";

			if (countValue == CountValue.Minutes)
			{
				countValueFormat = TimeHelper.GetFormatedTime(count);
			}

			if (countValue == CountValue.Pages)
			{
				countValueFormat = $"{count} pages";
			}

			return countValueFormat;
		}

		internal void Clear()
		{
			listBoxEvents.Items.Clear();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			comboBoxIntervals.Items.AddRange(Enum.GetNames(typeof(Interval)));
			comboBoxIntervals.SelectedIndex = (int)DefaultInterval;
		}

		private void ComboBoxIntervals_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (m_eventList == null)
			{
				return;
			}

			Fill(m_eventList, m_countValue);
		}
	}
}