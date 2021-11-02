using Controller.Extensions;
using System.Collections.Generic;
using System.Drawing;

namespace Controller
{
	public class ChartColors
	{
		private static Dictionary<string, Color> m_colorDictionary => new Dictionary<string, Color>
		{
			{ "Photographs", Color.DarkSlateGray },
			{ "Paintings", Color.DarkKhaki },
			{ "Comics", Color.SteelBlue },
			{ "TV Shows", Color.MediumTurquoise },
			{ "Movies",  Color.Silver },
			{ "Books", Color.IndianRed },
			{ "Songs", Color.Purple },
			{ "Albums", Color.HotPink },
			{ "Games", Color.LimeGreen },
			{ "Music", Color.HotPink },
			{ "My work progress", Color.DarkKhaki },
			{ "My work", Color.DarkKhaki },
			{ "Year progress", Color.DimGray }
		};

		public static Color GetColor(string name)
		{
			if (m_colorDictionary.ContainsKey(name))
			{
				return m_colorDictionary[name];
			}

			foreach (var key in m_colorDictionary.Keys)
			{
				if (name.Contains(key, System.StringComparison.OrdinalIgnoreCase))
				{
					return m_colorDictionary[key];
				}
			}

			return Color.LightYellow;
		}
	}
}