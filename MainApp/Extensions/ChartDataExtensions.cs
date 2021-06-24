using MainApp.Reports;
using System.Collections.Generic;
using System.Linq;

namespace MainApp.Extensions
{
	public static class ChartDataExtensions
	{
		public static List<ChartData> SortByValue(this List<ChartData> chartDataList)
		{
			return chartDataList.OrderBy(data => data.Value).ToList();
		}
	}
}