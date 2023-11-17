using System;
using System.Windows.Forms;

namespace MainApp.StatsControls.SummaryControls
{
	public partial class ItemCard : UserControl
	{
		public ItemCard()
		{
			InitializeComponent();
		}

		public string ImagePath { get; internal set; }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			pictureBox1.Image = Helper.SetPoster(ImagePath);
		}
	}
}