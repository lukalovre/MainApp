using Controller;
using Model.dbo;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MainApp.Standups
{
	public partial class StandupInfo : UserControl
	{
		private Standup m_standup;

		public StandupInfo()
		{
			InitializeComponent();
		}

		internal void FillData(Standup standup)
		{
			if(standup == null)
			{
				return;
			}

			m_standup = standup;

			labelTitle.Text = standup.Title;
			labelYear.Text = standup.Year.ToString();
			labelPerformer.Text = standup.Performer;

			starRatingControl1.SelectedStar = standup.Rating;

			var span = TimeSpan.FromMinutes(standup.Runtime);
			labelRuntime.Text = $"{span.Hours}h {span.Minutes}min";

			SetPoster(standup);
		}

		internal Standup GetStandup()
		{
			m_standup.Rating = starRatingControl1.SelectedStar;
			return m_standup;
		}

		private void ButtonGoToImdb_Click(object sender, EventArgs e)
		{
			//Controller.Movies.OpenHyperlink(m_standup);
		}

		private void SetPoster(Standup standup)
		{
			var filePath = Path.Combine(Paths.Posters, $"{standup.Imdb}.png");

			if(!File.Exists(filePath))
			{
				pictureBoxPoster.Image = null;
				return;
			}

			pictureBoxPoster.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxPoster.Image = Image.FromFile(filePath);
		}
	}
}