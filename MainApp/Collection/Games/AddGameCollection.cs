using System;
using System.Windows.Forms;

namespace MainApp.Collection.Games
{
	public partial class AddGameCollection : UserControl
	{
		public AddGameCollection()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			numericUpDownYear.Value = DateTime.Today.Year;

			comboBoxPlatform.Items.AddRange(GetPlatforms());
			comboBoxClient.Items.AddRange(GetClients());
		}

		private void Add()
		{
			var title = SQLHelper.GetText(textBoxTitle.Text);
			var year = numericUpDownYear.Value;
			var platform = SQLHelper.GetText(comboBoxPlatform.Text);
			var client = SQLHelper.GetText(comboBoxClient.Text);
			var gotFree = checkBoxGotFree.Checked ? 1 : 0;
			var price = string.IsNullOrEmpty(textBoxPrice.Text) ? "0" : textBoxPrice.Text;
			var priceInRSD = string.IsNullOrEmpty(textBoxPriceInRSD.Text) ? "0" : textBoxPriceInRSD.Text;
			var physicalCopy = checkBoxPhysicalCopy.Checked ? 1 : 0;
			var hltbTime = numericUpDownHLTBTime.Value == 0 ? "NULL" : numericUpDownHLTBTime.Value.ToString();
			var planToPlay = checkBoxPlanToPlay.Checked ? 1 : 0;
			var _1001 = checkBox1001.Checked ? 1 : 0;
			var edition = SQLHelper.GetText(textBoxEdition.Text);
			var expansion = checkBoxExpansion.Checked ? 1 : 0;
			var _new = checkBoxNew.Checked ? 1 : 0;

			var commandText = $@"EXECUTE [dbo].[AddGameCollection]
   {title}
  ,{edition}
  ,{expansion}
  ,{year}
  ,{platform}
  ,{client}
  ,{_new}
  ,{gotFree}
  ,{price}
  ,{priceInRSD}
  ,{physicalCopy}
  ,{hltbTime}
  ,{planToPlay}
  ,{_1001}";

			SqlConnectionExtension.ExecuteNonQuery(commandText);
		}

		private void ButtonAddClick(object sender, EventArgs e)
		{
			Add();

			Games.Instance.ShowGamesInGridAll();
			Games.Instance.ShowGamesInGridToPlay();
			Games.Instance.ShowGamesInGrid1001ToPlay();
		}

		private string[] GetClients()
		{
			return SQLHelper.GetDropdownValues(@"SELECT Client FROM [Main].[Games].[Clients]");
		}

		private string[] GetPlatforms()
		{
			return SQLHelper.GetDropdownValues(@"SELECT Platform FROM [Main].[Games].[Platforms]");
		}

		private void TextBoxTitleTextChanged(object sender, EventArgs e)
		{
			Games.Instance.dgAll.RowFilter = $"Title LIKE '%{SQLHelper.EscapeSpecialCharacters(textBoxTitle.Text)}%'";
		}
	}
}