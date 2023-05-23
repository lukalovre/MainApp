using MainApp.Extensions;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainApp.ListControls
{
	public partial class MovieListsControl : UserControl
	{
		public MovieListsControl()
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
				"1001 Movies You Must See Before You Die",
				typeof(Movie),
				"https://www.imdb.com/list/ls047619963/export?ref_=ttls_otexp",
				 hiddenColumns: new List<string> { nameof(ImdbList.Metascore), nameof(ImdbList._1001) }), "1001");

			tabControl1.AddControlToNewTab(ImdbListControl.Init(
				"TSPDT_ They Shoot Pictures, Don't They_ 1,000 Grea",
				typeof(Movie),
				"https://www.imdb.com/list/ls041826871/export?ref_=ttls_otexp",
				hiddenColumns: new List<string> { nameof(ImdbList.Metascore) }), "TSPDT");

			tabControl1.AddControlToNewTab(ImdbListControl.Init(
				"TSPDT_ They Shoot Pictures 21st Century Top 1000 F",
				typeof(Movie),
				"https://www.imdb.com/list/ls089659319/export?ref_=ttls_otexp",
				hiddenColumns: new List<string> { nameof(ImdbList.Metascore) }), "TSPDT_21");

			tabControl1.AddControlToNewTab(ImdbListControl.Init(
				"Top 250 Movies - IMDb",
				typeof(Movie),
				"https://www.imdb.com/chart/top/?ref_=nv_mv_250",
				ImdbListControl.FileType.HTM), "Top 250");

			tabControl1.AddControlToNewTab(ImdbListControl.Init(
				"IMDb",
				typeof(Movie),
				"https://www.imdb.com/chart/top-english-movies",
				ImdbListControl.FileType.HTM), "Top 250 English");

			tabControl1.AddControlToNewTab(ImdbListControl.Init(
				"Dunkey",
				typeof(Movie),
				"https://www.imdb.com/list/ls531325720/export?ref_=ttls_otexp",
				hiddenColumns: new List<string> { nameof(ImdbList.Metascore) }), "Dunkey 100");
		}
	}
}