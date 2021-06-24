using Controller;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace MainApp
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
			Instace = this;
			StartPosition = FormStartPosition.Manual;
			Location = new System.Drawing.Point(-1032, 1371);
			Size = new System.Drawing.Size(1040, 744);
		}

		public static Following Following { get; private set; }
		public static FormMain Instace { get; set; }

		public void ChangeTabToBooks()
		{
			tabControlAll.SelectedIndex = 0;
			tabControlMain.SelectedIndex = 5;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			var json = File.ReadAllText(Paths.Following);
			Following = JsonConvert.DeserializeObject<Following>(json);
		}
	}
}