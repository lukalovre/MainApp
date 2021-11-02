using Controller;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Games
{
	public partial class GameInfoControl : UserControl
	{
		private float m_addingTime;
		private Game m_game;
		private List<GameEvent> m_gameEvents;

		public GameInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(Game game, List<GameEvent> gameEvents)
		{
			m_game = game;
			m_gameEvents = gameEvents;

			var gameInfo = Controller.Games.GetInfo(game, gameEvents);

			textBoxTitle.Text = gameInfo.Title;
			numericUpDownYear.Value = gameInfo.Year;
			checkBox1001.Checked = gameInfo._1001;
			comboBoxPlatform.Text = gameInfo.Platform;
			pictureBox1.Image = Helper.SetPoster(gameInfo.PosterPath);
			textBoxTime.Text = gameInfo.Time;
			richTextBoxReview.Text = gameInfo.Review;
			checkBoxCompleted.Checked = gameInfo.Completed;
			starRatingControl1.SelectedStar = gameInfo.Stars;
			labelLastPlayed.Text = gameInfo.LastDaysAgo;

			checkBoxPlaying.CheckedChanged -= new EventHandler(CheckBoxPlaying_CheckedChanged);
			checkBoxPlaying.Checked = gameInfo.Playing;
			checkBoxPlaying.CheckedChanged += new EventHandler(CheckBoxPlaying_CheckedChanged);
		}

		internal GameEvent GetEvent()
		{
			return new GameEvent
			{
				Completed = checkBoxCompleted.Checked,
				Igdb = m_game.Igdb,
				Rating = starRatingControl1.SelectedStar,
				Comment = richTextBoxReview.Text,
				Time = m_addingTime
			};
		}

		internal Game GetItem()
		{
			return new Game
			{
				Platform = comboBoxPlatform.Text,
				Title = textBoxTitle.Text,
				Year = (int)numericUpDownYear.Value,
				Igdb = m_game.Igdb
			};
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			comboBoxPlatform.Items.AddRange(Controller.Games.GetPlatforms());
		}

		private void CheckBoxPlaying_CheckedChanged(object sender, EventArgs e)
		{
			Following.Update(checkBoxPlaying.Checked, Following.FollowingModel.Games, m_game.Igdb.ToString());
			GamesControl.Instance.UpdatePlaying();
		}

		private void TextBoxTime_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxTime.Text))
			{
				return;
			}

			var beforeTime = 0f;

			if (m_gameEvents != null && m_gameEvents.Any())
			{
				beforeTime = m_gameEvents.Sum(o => o.Time);
			}

			m_addingTime = float.Parse(textBoxTime.Text) - beforeTime;
			labelAddingTime.Text = $"Adding {m_addingTime} time";
		}
	}
}