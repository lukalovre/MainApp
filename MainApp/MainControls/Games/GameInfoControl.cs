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
		private string m_oldComment;

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
			richTextBoxComment.Text = gameInfo.Comment;
			m_oldComment = gameInfo.Comment ?? string.Empty;
			checkBoxCompleted.Checked = gameInfo.Completed;
			starRatingControl1.SelectedStar = gameInfo.Stars;
			labelLastPlayed.Text = gameInfo.LastDaysAgo;

			checkBoxPlaying.CheckedChanged -= new EventHandler(CheckBoxPlaying_CheckedChanged);
			checkBoxPlaying.Checked = gameInfo.Playing;
			checkBoxPlaying.CheckedChanged += new EventHandler(CheckBoxPlaying_CheckedChanged);

			labelHours.Text = Helper.GetFormatedTime(gameInfo.Time);

			var people = Datasource.GetList<Person>();
			var lastPeople = gameEvents?.LastOrDefault()?.People;

			if (lastPeople != null)
			{
				var peopleList = CsvHelper.Get(lastPeople).Select(o => people.FirstOrDefault(p => p.ID == int.Parse(o)).ID);

				peopleListControl1.SelectPeople(peopleList);
			}
			else
			{
				peopleListControl1.SelectPeople(null);
			}

			if (gameEvents == null)
			{
				eventControl1.Clear();
				return;
			}

			var events = gameEvents.Select(o => new Model.EventListItem
			{
				ID = o.ID,
				Time = o.Time,
				Date = o.Date
			}).ToList();

			eventControl1.FIll(events);
		}

		internal GameEvent GetEvent()
		{
			var comment = m_oldComment.Trim() == richTextBoxComment.Text.Trim()
				? null
				: richTextBoxComment.Text;
			comment = string.IsNullOrWhiteSpace(comment) ? null : comment;

			return new GameEvent
			{
				Completed = checkBoxCompleted.Checked,
				Igdb = m_game.Igdb,
				Rating = starRatingControl1.SelectedStar,
				Comment = comment,
				People = peopleListControl1.GetCheckedCSV()
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

			if (DesignMode)
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