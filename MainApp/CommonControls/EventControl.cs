using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp
{
	public partial class EventControl : UserControl
	{
		public Interval DefaultInterval = Interval.Months;

		private List<EventListItem> m_eventList;

		public EventControl()
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

		public void FIll(List<EventListItem> eventList)
		{
			m_eventList = eventList;

			eventList = eventList.Where(o => o.Date.HasValue).ToList();

			listBoxEvents.Items.Clear();

			if (comboBoxIntervals.SelectedIndex == (int)Interval.All)
			{
				foreach (var @event in eventList)
				{
					listBoxEvents.Items.Add($"{@event.Date}: {Helper.GetFormatedTime(@event.Time)}");
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
						.Sum(o => o.Time);

					listBoxEvents.Items.Add($"{year}: {Helper.GetFormatedTime(time)}");
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
							.Sum(o => o.Time);

						listBoxEvents.Items.Add($"{year} {month}: {Helper.GetFormatedTime(time)}");
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
						.Sum(o => o.Time) / 60f;

					listBoxEvents.Items.Add($"{day}: {time:0.00} h");
				}
			}

			listBoxEvents.SelectedIndex = listBoxEvents.Items.Count - 1;
		}

		internal void Clear()
		{
			listBoxEvents.Items.Clear();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
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

			FIll(m_eventList);
		}
	}
}