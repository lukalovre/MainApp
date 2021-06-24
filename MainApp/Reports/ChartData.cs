using System.Drawing;

namespace MainApp.Reports
{
	public class ChartData
	{
		internal Color Color;
		internal string Name;
		internal float Value;
		internal int Value2;

		internal ChartData(string name, float value, Color color, int value2 = 0)
		{
			Value = value;
			Color = color;
			Name = name;
			Value2 = value2;
		}
	}
}