namespace MainApp.Musics
{
	partial class MusicInfoControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.numericUpDownRuntime = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxArtist = new System.Windows.Forms.TextBox();
			this.checkBoxIsIn = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
			this.buttonSpotify = new System.Windows.Forms.Button();
			this.labelListenedTimes = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRuntime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDownRuntime
			// 
			this.numericUpDownRuntime.Location = new System.Drawing.Point(3, 118);
			this.numericUpDownRuntime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numericUpDownRuntime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownRuntime.Name = "numericUpDownRuntime";
			this.numericUpDownRuntime.Size = new System.Drawing.Size(68, 26);
			this.numericUpDownRuntime.TabIndex = 24;
			// 
			// numericUpDownYear
			// 
			this.numericUpDownYear.Location = new System.Drawing.Point(4, 80);
			this.numericUpDownYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numericUpDownYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.numericUpDownYear.Name = "numericUpDownYear";
			this.numericUpDownYear.Size = new System.Drawing.Size(66, 26);
			this.numericUpDownYear.TabIndex = 23;
			this.numericUpDownYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(3, 43);
			this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(273, 26);
			this.textBoxTitle.TabIndex = 22;
			this.textBoxTitle.TextChanged += new System.EventHandler(this.TextBoxTitle_TextChanged);
			// 
			// textBoxArtist
			// 
			this.textBoxArtist.Location = new System.Drawing.Point(4, 5);
			this.textBoxArtist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxArtist.Name = "textBoxArtist";
			this.textBoxArtist.Size = new System.Drawing.Size(272, 26);
			this.textBoxArtist.TabIndex = 21;
			this.textBoxArtist.TextChanged += new System.EventHandler(this.TextBoxArtist_TextChanged);
			// 
			// checkBoxIsIn
			// 
			this.checkBoxIsIn.AutoSize = true;
			this.checkBoxIsIn.Location = new System.Drawing.Point(175, 83);
			this.checkBoxIsIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxIsIn.Name = "checkBoxIsIn";
			this.checkBoxIsIn.Size = new System.Drawing.Size(49, 24);
			this.checkBoxIsIn.TabIndex = 20;
			this.checkBoxIsIn.Text = "In";
			this.checkBoxIsIn.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(79, 120);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 20);
			this.label4.TabIndex = 19;
			this.label4.Text = "Runtime";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(79, 83);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 20);
			this.label3.TabIndex = 18;
			this.label3.Text = "Year";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(286, 46);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 20);
			this.label2.TabIndex = 17;
			this.label2.Text = "Title";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(286, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 20);
			this.label1.TabIndex = 16;
			this.label1.Text = "Artist";
			// 
			// pictureBoxAlbum
			// 
			this.pictureBoxAlbum.Location = new System.Drawing.Point(4, 152);
			this.pictureBoxAlbum.Name = "pictureBoxAlbum";
			this.pictureBoxAlbum.Size = new System.Drawing.Size(640, 640);
			this.pictureBoxAlbum.TabIndex = 25;
			this.pictureBoxAlbum.TabStop = false;
			// 
			// buttonSpotify
			// 
			this.buttonSpotify.Location = new System.Drawing.Point(367, 42);
			this.buttonSpotify.Name = "buttonSpotify";
			this.buttonSpotify.Size = new System.Drawing.Size(103, 45);
			this.buttonSpotify.TabIndex = 26;
			this.buttonSpotify.Text = "Spotify";
			this.buttonSpotify.UseVisualStyleBackColor = true;
			this.buttonSpotify.Click += new System.EventHandler(this.ButtonSpotify_Click);
			// 
			// labelListenedTimes
			// 
			this.labelListenedTimes.AutoSize = true;
			this.labelListenedTimes.Location = new System.Drawing.Point(175, 123);
			this.labelListenedTimes.Name = "labelListenedTimes";
			this.labelListenedTimes.Size = new System.Drawing.Size(143, 20);
			this.labelListenedTimes.TabIndex = 27;
			this.labelListenedTimes.Text = "Listened to 5 times";
			// 
			// MusicInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelListenedTimes);
			this.Controls.Add(this.buttonSpotify);
			this.Controls.Add(this.pictureBoxAlbum);
			this.Controls.Add(this.numericUpDownRuntime);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.textBoxArtist);
			this.Controls.Add(this.checkBoxIsIn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MusicInfoControl";
			this.Size = new System.Drawing.Size(661, 806);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRuntime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.NumericUpDown numericUpDownRuntime;
		private System.Windows.Forms.NumericUpDown numericUpDownYear;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.TextBox textBoxArtist;
		private System.Windows.Forms.CheckBox checkBoxIsIn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBoxAlbum;
		private System.Windows.Forms.Button buttonSpotify;
		private System.Windows.Forms.Label labelListenedTimes;
	}
}
