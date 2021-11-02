using System;

namespace Controller.Extensions
{
	public static class StringExtensions
	{
		public static bool Contains(this string source, string toCheck, StringComparison comp)
		{
			return source?.IndexOf(toCheck, comp) >= 0;
		}

		public static float? ToNullableFloat(this string source)
		{
			return string.IsNullOrEmpty(source)
				? (float?)null
				: float.Parse(source);
		}
	}
}