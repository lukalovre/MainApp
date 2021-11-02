using Controller;
using Controller.Extensions;
using Model.Collection;
using System;
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
			checkBoxPlanToPlay.Checked = Following.FollowingModel.GamesCollection.Contains(m_game.ID.ToString());
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

			numericUpDownYear.Value = DateTime.Today.Year;

			comboBoxPlatform.Items.AddRange(Database.GetDropdownValues(@"SELECT DISTINCT Platform FROM [Main].[Collection].[Games]"));
			comboBoxClient.Items.AddRange(Database.GetDropdownValues(@"SELECT DISTINCT Client FROM [Main].[Collection].[Games]"));
			comboBoxOwner.Items.AddRange(Database.GetDropdownValues(@"SELECT DISTINCT Owner FROM [Main].[Collection].[Games]"));
		}

		private void CheckBoxPlanToPlay_CheckedChanged(object sender, EventArgs e)
		{
			Following.Update(checkBoxPlanToPlay.Checked, Following.FollowingModel.GamesCollection, m_game.ID.ToString());
		}
	}
}