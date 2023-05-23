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

		public static string TrimEndLegit(this string source, string trim)
		{
			return source.EndsWith(trim)
				? source.Substring(0, source.Length - trim.Length)
				: source;
		}

		public static string TrimStartLegit(this string source, string trim)
		{
			return source.StartsWith(trim)
				? source.Substring(trim.Length, source.Length - trim.Length)
				: source;
		}
	}
}