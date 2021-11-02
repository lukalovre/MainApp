using System.Drawing;

namespace MainApp
{
	internal static class Helper
	{
		internal static Image SetPoster(string filePath)
		{
			if (string.IsNullOrWhiteSpace(filePath))
			{
				return null;
			}

			return Image.FromFile(filePath);
		}
	}
}