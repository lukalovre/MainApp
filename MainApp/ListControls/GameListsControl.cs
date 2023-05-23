using Controller;
using MainApp.Extensions;
using Model.dbo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.ListControls
{
	public partial class GameListsControl : UserControl
	{
		public GameListsControl()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			var filter = Datasource.GetList<Game>().Select(o => o.Igdb).ToList();
			var currentYear = DateTime.Now.Year - 1;

			tabControl1.AddControlToNewTab(IgdbListControl.Init("1001-video-games-you-must-play-before-you-die", filter), "1001");
			tabControl1.AddControlToNewTab(IgdbListControl.Init($"the-video-game-canon-the-top-100-{currentYear}", filter), "Canon");
			tabControl1.AddControlToNewTab(IgdbListControl.Init("list-of-video-games-considered-the-best", filter), "Wiki");
			tabControl1.AddControlToNewTab(IgdbListControl.Init($"igdb-top-100-{currentYear}", filter), "Igdb");
			tabControl1.AddControlToNewTab(IgdbListControl.Init($"metacritic-top-100-{currentYear}", filter), "Metacritic");
			tabControl1.AddControlToNewTab(IgdbListControl.Init("zero-punctuation-goty", filter), "ZP");
			tabControl1.AddControlToNewTab(IgdbListControl.Init("johnathan-blows-steam-curation", filter), "Blow");
			tabControl1.AddControlToNewTab(IgdbListControl.Init("seumas-mcnally-grand-prize", filter), "McNally");
			tabControl1.AddControlToNewTab(IgdbListControl.Init($"top-goty-{currentYear}", filter), "GOTY");

			// Use this when calculating new top GOTY
			//tabControl1.AddControlToNewTab(IgdbListControl.Init("GOTY", filter, true), "GOTY");
		}
	}
}