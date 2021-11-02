using System.Windows.Forms;

namespace MainApp.Extensions
{
	public static class TabControlExtension
	{
		public static void AddControlToNewTab(this TabControl tabControl, UserControl userControl, string tabName)
		{
			var tabPage = new TabPage
			{
				Name = "tabPage",
				Size = new System.Drawing.Size(771, 991),
				TabIndex = 1,
				Text = tabName,
				Location = new System.Drawing.Point(4, 29),
				UseVisualStyleBackColor = true
			};

			tabPage.Controls.Add(userControl);
			tabControl.Controls.Add(tabPage);
		}
	}
}