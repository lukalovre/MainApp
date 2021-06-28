using System;
using System.Windows.Forms;

namespace MainApp.Collection.Games
{
	public partial class AddGameControl : UserControl
	{
		public AddGameControl()
		{
			InitializeComponent();
		}

		public void SetGameData(string completedGame, bool _1001, string platform, int year)
		{
			textBoxTitle.Text = completedGame;
			checkBox1001.Checked = _1001;
			textBoxPlatform.Text = platform;
			numericUpDownYear.Value = year;
		}

		private void Add()
		{
			var title = SQLHelper.GetText(textBoxTitle.Text);
			var completed = checkBoxCompleted.Checked ? 1 : 0;
			var time = textBoxTime.Text;
			var _1001 = checkBox1001.Checked ? 1 : 0;
			var rating = numericUpDownRating.Value;
			var platform = SQLHelper.GetText(textBoxPlatform.Text);
			var year = numericUpDownYear.Value;

			var commandText = $@"EXECUTE [dbo].[AddGame]
								{title},
								{year},
								{rating},
								{completed},
								{time},
								{platform},
								{_1001}";

			SqlConnectionExtension.ExecuteNonQuery(commandText);
		}

		private void BtnAddClick(object sender, EventArgs e)
		{
			Add();
			GamesControl.Instance.ShowGamesInGridToPlay();
			GamesControl.Instance.ShowGamesInGrid1001ToPlay();
		}
	}
}