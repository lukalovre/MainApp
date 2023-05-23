using Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace MainApp.StatsControls
{
	internal static class HelperStats
	{
		internal static List<ChartData> ReadFile(string path)
		{
			var json = File.ReadAllText(path);
			return JsonConvert.DeserializeObject<List<ChartData>>(json);
		}
	}
}