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

		public delegate void ArtistTextChangedDelegate(string artist);

		public delegate void TitleTextChangedDelegate(string title);

		public event ArtistTextChangedDelegate ArtistTextChanged;

		public event TitleTextChangedDelegate TitleTextChanged;

		public void Fill(Music music, List<MusicEvent> musicEvents)
		{
			m_music = music;

			textBoxArtist.TextChanged -= new System.EventHandler(TextBoxArtist_TextChanged);
			textBoxArtist.Text = music.Artist;
			textBoxArtist.TextChanged += new System.EventHandler(TextBoxArtist_TextChanged);

			textBoxTitle.TextChanged -= new System.EventHandler(TextBoxTitle_TextChanged);
			textBoxTitle.Text = music.Title;
			textBoxTitle.TextChanged += new System.EventHandler(TextBoxTitle_TextChanged);

			numericUpDownYear.Value = music.Year;
			numericUpDownRuntime.Value = music.Runtime;

			labelListenedTimes.Text = $"Listened to {musicEvents?.Count} times";

			string filePath;

			if (music.ItemID == 0)
			{
				checkBoxIsIn.Checked = false;
				filePath = Paths.TempAlbumCover;
			}
			else
			{
				checkBoxIsIn.Checked = musicEvents.LastOrDefault().In;
				filePath = Path.Combine(Paths.Albums, $"{music.ItemID}.png");
			}

			if (!File.Exists(filePath))
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
				Comment = null,
				Rating = null,
				ItemID = m_music.ItemID
			};
		}

		internal Music GetInfo()
		{
			pictureBoxAlbum.Image = null;

			return new Music
			{
				Artist = textBoxArtist.Text,
				Runtime = (int)numericUpDownRuntime.Value,
				Title = textBoxTitle.Text,
				Year = (int)numericUpDownYear.Value,
				_1001 = false,
				SpotifyID = m_music.SpotifyID,
				ItemID = m_music.ItemID
			};
		}

		private void ButtonSpotify_Click(object sender, System.EventArgs e)
		{
			var hyperlink = $"https://open.spotify.com/album/{m_music.SpotifyID}";

			System.Diagnostics.Process.Start(hyperlink);
		}

		private Image GetCopyImage(string path)
		{
			using (var image = Image.FromFile(path))
			{
				return new Bitmap(image);
			}
		}

		private void TextBoxArtist_TextChanged(object sender, System.EventArgs e)
		{
			ArtistTextChanged((sender as TextBox).Text);
		}

		private void TextBoxTitle_TextChanged(object sender, System.EventArgs e)
		{
			TitleTextChanged((sender as TextBox).Text);
		}
	}
}