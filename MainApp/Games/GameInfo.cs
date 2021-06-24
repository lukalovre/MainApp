using Controller;
using Model.dbo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Games
{
	public partial class GameInfo : UserControl
	{
		private Game m_game;

		public GameInfo()
		{
			InitializeComponent();
		}

		internal void Fill(Game game, List<GameEvent> gameEvent)
		{
			m_game = game;

			labelTitle.Text = game.Title;
			numericUpDownRating.Value = gameEvent.LastOrDefault().Rating.Value;
			textBoxTime.Text = gameEvent.Sum(o => o.Time).ToString();
			checkBoxPlaying.Checked = FormMain.Following.Games.Contains(game.ItemID.ToString());
			checkBoxCompleted.Checked = gameEvent.Any(o => o.Completed);
			richTextBoxReview.Text = gameEvent.LastOrDefault().Comment;
		}

		internal GameEvent GetGameEvent()
		{
			return new GameEvent
			{
				Completed = checkBoxCompleted.Checked,
				ItemID = m_game.ItemID,
				Rating = (int)numericUpDownRating.Value,
				Comment = richTextBoxReview.Text,
				Time = float.Parse(textBoxTime.Text)
			};
		}

		private void CheckBoxPlaying_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxPlaying.Checked)
			{
				if(!FormMain.Following.Games.Contains(m_game.ItemID.ToString()))
				{
					FormMain.Following.Games.Add(m_game.ItemID.ToString());
				}
			}
			else
			{
				FormMain.Following.Games.Remove(m_game.ItemID.ToString());
			}

			string json = JsonConvert.SerializeObject(FormMain.Following, Formatting.Indented);
			File.WriteAllText(Paths.Following, json);
		}
	}
}