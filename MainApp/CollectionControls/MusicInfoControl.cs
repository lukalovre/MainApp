using Controller;
using Controller.Extensions;
using Model.Collection;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.Collection
{
	public partial class MusicInfoControl : UserControl
	{
		public MusicInfoControl()
		{
			InitializeComponent();
		}

		internal void Fill(Music item)
		{
			if (item == null)
			{
				return;
			}

			textBoxArtist.Text = item.Artist;
			textBoxPrice.Text = item.Price.ToString();
			textBoxPriceInRSD.Text = item.PriceInRSD.ToString();
			comboBoxFormat.Text = item.Format;
			comboBoxOwner.Text = item.Owner;
			textBoxTitle.Text = item.Title;
			numericUpDownYear.Value = item.Year;
		}

		internal Music GetItem()
		{
			return new Music
			{
				Artist = textBoxArtist.Text,
				Format = comboBoxFormat.Text,
				Owner = comboBoxOwner.Text,
				Price = textBoxPrice.Text.ToNullableFloat(),
				PriceInRSD = textBoxPriceInRSD.Text.ToNullableFloat(),
				Title = textBoxTitle.Text,
				Year = (int)numericUpDownYear.Value
			};
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (DesignMode)
			{
				return;
			}

			FillOwners();
			FillFormats();

			numericUpDownYear.Value = DateTime.Now.Year;
		}

		private void FillFormats()
		{
			comboBoxFormat.Items.AddRange(Datasource.GetList<Music>().Select(o => o.Format).Distinct().ToArray());
		}

		private void FillOwners()
		{
			comboBoxOwner.Items.AddRange(Datasource.GetList<Music>().Where(o => o.Owner != null).Select(o => o.Owner).Distinct().ToArray());
		}
	}
}