using System;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainApp.Reports
{
	public static class Extensions
	{
		public static float GetLastValue(this Chart Chart)
		{
			return (float)Chart.Series.FirstOrDefault().Points[DateTime.Now.Month-1].YValues.FirstOrDefault();
		}
	}
}