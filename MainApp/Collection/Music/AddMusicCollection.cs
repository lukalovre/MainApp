using MainApp.Properties;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainApp.Collection.Music
{
	public partial class AddMusicCollection : UserControl
	{
		public AddMusicCollection()
		{
			InitializeComponent();

			FillOwners();
			FillFormats();

			numericUpDownYear.Value = DateTime.Now.Year;
		}

		private void ButtonAddClick(object sender, EventArgs e)
		{
			var owner = SQLHelper.GetText(comboBoxOwner.Text);
			var artist = SQLHelper.GetText(textBoxArtist.Text);
			var title = SQLHelper.GetText(textBoxTitle.Text);
			var year = numericUpDownYear.Value;
			var format = SQLHelper.GetText(comboBoxFormat.Text);
			var price = string.IsNullOrEmpty(textBoxPrice.Text) ? "NULL" : textBoxPrice.Text;
			var priceInRSD = string.IsNullOrEmpty(textBoxPriceInRSD.Text) ? "NULL" : textBoxPriceInRSD.Text;

			var commandText = $@"EXECUTE [dbo].[AddMusicCollection]
   {owner}
  ,{artist}
  ,{title}
  ,{year}
  ,{format}
  ,{price}
  ,{priceInRSD}";

			SqlConnectionExtension.ExecuteNonQuery(commandText);

			Music.Instance.ShowComicsCollectionInGrid();
		}

		private void FillFormats()
		{
			SqlConnection sqlConnection1 = new SqlConnection(Resources.MainConnectionString);
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = @"SELECT distinct([Format]) as Format
  FROM [Main].[Collection].[Music]";

			cmd.Connection = sqlConnection1;

			sqlConnection1.Open();

			using(SqlDataReader reader = cmd.ExecuteReader())
			{
				while(reader.Read())
				{
					comboBoxFormat.Items.Add(reader["Format"].ToString());
				}
			}

			sqlConnection1.Close();
		}

		private void FillOwners()
		{
			SqlConnection sqlConnection1 = new SqlConnection(Resources.MainConnectionString);
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = @"SELECT distinct([Owner]) as Owner
  FROM [Main].[Collection].[Music]";

			cmd.Connection = sqlConnection1;

			sqlConnection1.Open();

			using(SqlDataReader reader = cmd.ExecuteReader())
			{
				while(reader.Read())
				{
					comboBoxOwner.Items.Add(reader["Owner"].ToString());
				}
			}

			sqlConnection1.Close();
		}
	}
}