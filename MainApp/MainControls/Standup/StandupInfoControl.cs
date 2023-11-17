using Controller;
using Model;
using Model.dbo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MainApp.Standups
{
	public partial class StandupInfoControl : UserControl
	{
		private Standup m_standup;

		public StandupInfoControl()
		{
			InitializeComponent();
		}

		internal void FillData(Standup standup)
		{
			if (standup == null)
			{
				return;
			}

			m_standup = standup;

			labelTitle.Text = standup.Title;
			labelYear.Text = standup.Year.ToString();
			labelPerformer.Text = standup.Performer;
			labelRuntime.Text = TimeHelper.GetFormatedTime(standup.Runtime);

			SetPoster(standup);

			var eventItemList = new List<EventListItem>
			{
				new EventListItem
				{
					ID = standup.ID,
					Date = standup.Date,
					CountValue = 1
				}
			};

			evenControl1.Fill(standup, eventItemList);
		}

		internal Standup GetStandup()
		{
			m_standup.Rating = evenControl1.Rating;
			m_standup.Comment = evenControl1.GetComment();
			m_standup.People = evenControl1.GetPeople(); 
			return m_standup;
		}

		private void ButtonGoToImdb_Click(object sender, EventArgs e)
		{
			//Controller.Movies.OpenHyperlink(m_standup);
		}

		private void SetPoster(Standup standup)
		{
			var filePath = Path.Combine(Paths.Posters, $"{standup.Imdb}.png");

			if (!File.Exists(filePath))
			{
				pictureBoxPoster.Image = null;
				return;
			}

			pictureBoxPoster.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxPoster.Image = Image.FromFile(filePath);
		}
	}
}