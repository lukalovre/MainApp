namespace Controller
{
	public class TimeHelper
	{
		public static string GetFormatedTime(int minutes)
		{
			var hours = minutes / 60;
			var min = minutes % 60;

			var hText = hours == 0 ? string.Empty : $"{hours}h";
			var mText = min == 0 ? string.Empty : $"{min}min";

			var space = hours == 0 || min == 0 ? string.Empty : " ";

			return hText + space + mText;
		}
	}
}