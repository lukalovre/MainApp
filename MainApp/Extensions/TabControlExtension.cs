using System.Linq;
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

		public static T GetSelected<T>(this TabControl tabControl) where T : class
		{
			return tabControl.GetSelectedGrid().GetSelected<T>();
		}

		public static DataGridView GetSelectedGrid(this TabControl tabControl)
		{
			var tabControls = tabControl.SelectedTab.Controls.Cast<Control>();

			var dataGrid = tabControls.FirstOrDefault(o => o is DataGridView);

			if (dataGrid == null)
			{
				var tabControl1 = (tabControls.FirstOrDefault(o => o is TabControl) as TabControl);
				var tabControls1 = tabControl1.SelectedTab.Controls.Cast<Control>();
				dataGrid = tabControls1.FirstOrDefault(o => o is DataGridView);
			}

			return dataGrid as DataGridView;
		}
	}
}