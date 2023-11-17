using Controller;
using Controller.Extensions;
using Model.Collection;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Collection.Games
{
	public partial class GameInfoControl : UserControl
	{
		private Game m_game;

		public GameInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(Game game)
		{
			m_game = game;

			textBoxTitle.Text = game.Title;
			numericUpDownYear.Value = game.Year;
			comboBoxPlatform.Text = game.Platform;
			comboBoxClient.Text = game.Client;
			checkBoxGotFree.Checked = game.GotFree;
			textBoxPrice.Text = game.Price.ToString();
			textBoxPriceInRSD.Text = game.PriceInRSD.ToString();
			checkBoxPhysicalCopy.Checked = game.PhysicalCopy;
			numericUpDownHLTBTime.Value = game.HLTB;
			checkBox1001.Checked = Igdb.Is1001(game.Igdb);
			textBoxEdition.Text = game.Edition;
			checkBoxExpansion.Checked = game.Expansion;
			checkBoxNew.Checked = game.New;
		}

		internal Game GetItem()
		{
			return new Game
			{
				Client = comboBoxClient.Text,
				Edition = textBoxEdition.Text,
				Expansion = checkBoxExpansion.Checked,
				GotFree = checkBoxGotFree.Checked,
				HLTB = (int)numericUpDownHLTBTime.Value,
				New = checkBoxNew.Checked,
				Owner = comboBoxOwner.Text,
				PhysicalCopy = checkBoxPhysicalCopy.Checked,
				Platform = comboBoxPlatform.Text,
				Price = textBoxPrice.Text.ToNullableFloat(),
				PriceInRSD = textBoxPriceInRSD.Text.ToNullableFloat(),
				Title = textBoxTitle.Text,
				Year = (int)numericUpDownYear.Value,
				Igdb = m_game.Igdb
			};
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Helper.IsInDesignMode)
			{
				return;
			}

			numericUpDownYear.Value = DateTime.Today.Year;

			comboBoxPlatform.Items.AddRange(Controller.Games.GetPlatforms());
			comboBoxClient.Items.AddRange(Controller.Games.GetClients());
			comboBoxOwner.Items.AddRange(Datasource.GetList<Game>().Where(o => o.Owner != null).Select(o => o.Owner).Distinct().ToArray());
		}
	}
}