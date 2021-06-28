using Controller;
using Model.dbo;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Musics
{
	public partial class MusicInfoControl : UserControl
	{
		private Music m_music;

		public MusicInfoControl()
		{
			InitializeComponent();
		}

		public void Fill(Music music, List<MusicEvent> musicEvents)
		{
			m_music = music;

			textBoxArtist.Text = music.Artist;
			textBoxTitle.Text = music.Title;
			numericUpDownYear.Value = music.Year;
			numericUpDownRuntime.Value = music.Runtime;

			labelListenedTimes.Text = $"Listened to {musicEvents?.Count} times";

			string filePath;

			if(music.ItemID == 0)
			{
				checkBoxIsIn.Checked = false;
				filePath = Path.Combine(Paths.Albums, "_temp.png");
			}
			else
			{
				checkBoxIsIn.Checked = musicEvents.LastOrDefault().In;
				filePath = Path.Combine(Paths.Albums, $"{music.ItemID}.png");
			}

			if(!File.Exists(filePath))
			{
				pictureBoxAlbum.Image = null;
				return;
			}

			pictureBoxAlbum.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxAlbum.Image = GetCopyImage(filePath);
		}

		internal MusicEvent GetEvent()
		{
			return new MusicEvent
			{
				In = checkBoxIsIn.Checked,
				ItemID = m_music.ItemID,
				Comment = null,
				Rating = null
			};
		}

		internal Music GetInfo()
		{
			if(m_music.ItemID == 0)
			{
				m_music.ItemID = MusicControl.Instance.GetEvents().Max(o => o.ItemID) + 1;
			}

			pictureBoxAlbum.Image = null;

			return new Music
			{
				Artist = textBoxArtist.Text,
				ItemID = m_music.ItemID,
				Runtime = (int)numericUpDownRuntime.Value,
				Title = textBoxTitle.Text,
				Year = (int)numericUpDownYear.Value,
				_1001 = false
			};
		}

		private void ButtonSpotify_Click(object sender, System.EventArgs e)
		{
			var hyperlink = $"https://open.spotify.com/album/{m_music.SpotifyID}";

			System.Diagnostics.Process.Start(hyperlink);
		}

		private Image GetCopyImage(string path)
		{
			using(var image = Image.FromFile(path))
			{
				return new Bitmap(image);
			}
		}
	}
}