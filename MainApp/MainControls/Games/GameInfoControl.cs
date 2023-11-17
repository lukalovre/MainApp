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
		private Game m_game;

		public GameInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(Game game, List<GameEvent> gameEvents)
		{
			m_game = game;

			var gameInfo = Controller.Games.GetInfo(game, gameEvents);

			textBoxTitle.Text = gameInfo.Title;
			numericUpDownYear.Value = gameInfo.Year;
			checkBox1001.Checked = gameInfo._1001;
			comboBoxPlatform.Text = gameInfo.Platform;
			pictureBox1.Image = Helper.SetPoster(gameInfo.PosterPath);
			checkBoxCompleted.Checked = gameInfo.Completed;
			labelLastPlayed.Text = gameInfo.LastDaysAgo;

			checkBoxPlaying.CheckedChanged -= new EventHandler(CheckBoxPlaying_CheckedChanged);
			checkBoxPlaying.Checked = gameInfo.Playing;
			checkBoxPlaying.CheckedChanged += new EventHandler(CheckBoxPlaying_CheckedChanged);

			labelHours.Text = TimeHelper.GetFormatedTime(gameInfo.Time);

			if (gameEvents == null)
			{
				evenControl1.Clear();
				return;
			}

			var events = gameEvents.Select(o => new Model.EventListItem
			{
				ID = o.ID,
				CountValue = o.Time,
				Date = o.Date
			}).ToList();

			var lastEvent = gameEvents.LastOrDefault();
			evenControl1.Fill(lastEvent, events);
		}

		internal GameEvent GetEvent()
		{
			return new GameEvent
			{
				Completed = checkBoxCompleted.Checked,
				Igdb = m_game.Igdb,
				Rating = evenControl1.Rating,
				Comment = evenControl1.GetComment(),
				People = evenControl1.GetPeople(),
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

			if (Helper.IsInDesignMode)
			{
				return;
			}

			comboBoxPlatform.Items.AddRange(Controller.Games.GetPlatforms());
		}

		private void CheckBoxPlaying_CheckedChanged(object sender, EventArgs e)
		{
			Following.Update(checkBoxPlaying.Checked, Following.FollowingModel.Games, m_game.Igdb.ToString());
			GamesControl.Instance.UpdatePlaying();
		}
	}
}