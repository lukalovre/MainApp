using MainApp.Extensions;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainApp.ListControls
{
	public partial class TVShowListControl : UserControl
	{
		public TVShowListControl()
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

			tabControl1.AddControlToNewTab(ImdbListControl.Init(
				"1001 TV Shows You Must Watch Before you Die",
				typeof(TVShow),
				"https://www.imdb.com/list/ls031718903/export?ref_=ttls_otexp",
				hiddenColumns: new List<string> { nameof(ImdbList.Metascore), nameof(ImdbList.Director), nameof(ImdbList._1001) }), "1001");

			tabControl1.AddControlToNewTab(ImdbListControl.Init(
				"IMDb Top 250 TV - IMDb",
				typeof(TVShow),
				"https://www.imdb.com/chart/toptv/?ref_=nv_tvv_250",
				ImdbListControl.FileType.HTM,
				hiddenColumns: new List<string> { nameof(ImdbList.Metascore), nameof(ImdbList.Director) }), "Top 250");
		}
	}
}