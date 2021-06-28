using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp.Extensions
{
	public static class ChartExtensions
	{
		public static float GetLastValue(this Chart Chart)
		{
			return (float)Chart.Series.FirstOrDefault().Points[DateTime.Now.Month - 1].YValues.FirstOrDefault();
		}

		public static List<ChartData> SortByValue(this List<ChartData> chartDataList)
		{
			return chartDataList.OrderBy(data => data.Value).ToList();
		}
	}
}