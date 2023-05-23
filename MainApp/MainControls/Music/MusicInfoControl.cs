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
			eventControl1.DefaultInterval = EventControl.Interval.Years;
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
				filePath = $"{Paths.TempAlbumCover}.png";
			}
			else
			{
				checkBoxIsIn.Checked = musicEvents.LastOrDefault().In;
				filePath = Path.Combine(Paths.Albums, $"{music.ItemID}.png");
			}

			if (File.Exists(filePath))
			{
				pictureBoxAlbum.SizeMode = PictureBoxSizeMode.Zoom;
				pictureBoxAlbum.Image = GetCopyImage(filePath);
			}
			else
			{
				pictureBoxAlbum.Image = null;
			}

			var events = musicEvents.Select(o => new Model.EventListItem
			{
				ID = o.ID,
				Time = 1,
				Date = o.Date
			}).ToList();

			eventControl1.FIll(events);
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

		private void ButtonOpenLink_Click(object sender, System.EventArgs e)
		{
			var hyperlink = string.Empty;

			if (string.IsNullOrWhiteSpace(m_music.SpotifyID))
			{
				var artist = m_music.Artist.Split(' ').ToList();
				var title = m_music.Title.Split(' ').ToList();
				var year = m_music.Year.ToString();

				var pars = new List<string>();

				pars.AddRange(artist);
				pars.AddRange(title);
				pars.Add(year);

				hyperlink = $"https://duckduckgo.com/?q={string.Join("+", pars)}";
			}
			else
			{
				if (m_music.SpotifyID.Contains(".bandcamp.com"))
				{
					hyperlink = m_music.SpotifyID;
				}
				else
				{
					hyperlink = $"https://open.spotify.com/album/{m_music.SpotifyID}";
				}
			}

			Web.OpenLink(hyperlink);
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