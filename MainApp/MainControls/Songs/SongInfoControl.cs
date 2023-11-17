using Controller;
using Controller.Extensions;
using Model.dbo;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.MainControls.Zoo
{
	public partial class SongInfoControl : UserControl
	{
		private Song m_song;

		public SongInfoControl()
		{
			InitializeComponent();
		}

		public void Fill(Song song, IEnumerable<SongEvent> songEvents)
		{
			m_song = song;

			var lastEvent = songEvents?.OrderBy(o => o.Date)?.LastOrDefault();
			checkBoxIn.Checked = lastEvent?.In ?? true;
			textBoxArtist.Text = song.Artist;
			textBoxTitle.Text = song.Title;
			textBoxLink.Text = song.Link;
			numericUpDownRuntime.Value = song.Runtime;
			numericUpDownYear.Value = song.Year;

			string filePath;

			var handle = song.Link.TrimStartLegit("https://www.youtube.com/watch?v=");

			filePath = Path.Combine(Paths.SongCovers, $"{handle}.png");

			if (File.Exists(filePath))
			{
				pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
				pictureBoxImage.Image = GetCopyImage(filePath);
			}
			else
			{
				pictureBoxImage.Image = null;
			}

			if (songEvents == null)
			{
				evenControl1.Clear();
				return;
			}

			var events = songEvents.Select(o => new Model.EventListItem
			{
				ID = o.ID,
				CountValue = 1,
				Date = o.Date
			}).ToList();

			evenControl1.Fill(lastEvent, events, EventListControl.CountValue.None);
		}

		private Image GetCopyImage(string path)
		{
			using (var image = Image.FromFile(path))
			{
				return new Bitmap(image);
			}
		}

		internal SongEvent GetEvent()
		{
			return new SongEvent
			{
				Rating = evenControl1.Rating,
				Comment = evenControl1.GetComment(),
				In = checkBoxIn.Checked,
				People = evenControl1.GetPeople()
			};
		}

		internal Song GetItem()
		{
			return new Song
			{
				ID = m_song.ID,
				Artist = textBoxArtist.Text,
				Title = textBoxTitle.Text,
				Link = textBoxLink.Text,
				Year = (int)numericUpDownYear.Value,
				Runtime = (int)numericUpDownRuntime.Value
			};
		}
	}
}