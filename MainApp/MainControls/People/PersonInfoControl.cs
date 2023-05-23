using Controller;
using Model.dbo;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MainApp.MainControls
{
	public partial class PersonInfoControl : UserControl
	{
		private Person m_item;

		public PersonInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(Person item)
		{
			m_item = item;

			textBoxFirstName.Text = item.FirstName;
			textBoxLastName.Text = item.LastName;
			textBoxAddress.Text = item.Address;
			textBoxCity.Text = item.City;
			textBoxPostcode.Text = item.Postcode.ToString();
			textBoxBirthday.Text = item.Birthday.ToString();
			textBoxNickname.Text = item.Nickname;

			SetPicture(item.ID);
		}

		private void SetPicture(int perosnID)
		{
			var filePath = Path.Combine(Paths.People, $"{perosnID}.png");

			if (!File.Exists(filePath))
			{
				pictureBox1.Image = null;
				return;
			}

			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.Image = Image.FromFile(filePath);
		}

		internal Person GetItem()
		{
			return new Person
			{
				ID = m_item.ID,
				FirstName = textBoxFirstName.Text,
				LastName = textBoxLastName.Text
			};
		}

		private void ButtonAddPhoto_Click(object sender, EventArgs e)
		{
			var openFileDialog1 = new OpenFileDialog();
			DialogResult result = openFileDialog1.ShowDialog();

			if (result == DialogResult.OK)
			{
				var file = openFileDialog1.FileName;

				using (var bmpTemp = new Bitmap(file))
				{
					var imagesTemp = new Bitmap(bmpTemp);
					imagesTemp.Save(Path.Combine(Paths.People, $"{m_item.ID}.png"), ImageFormat.Png);
				}

				SetPicture(m_item.ID);
			}
		}
	}
}