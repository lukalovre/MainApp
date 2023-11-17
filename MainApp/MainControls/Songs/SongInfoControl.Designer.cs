namespace MainApp.MainControls.Zoo
{
	partial class SongInfoControl
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
			if (disposing && (components != null))
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
			this.textBoxArtist = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxLink = new System.Windows.Forms.TextBox();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.numericUpDownRuntime = new System.Windows.Forms.NumericUpDown();
			this.checkBoxIn = new System.Windows.Forms.CheckBox();
			this.evenControl1 = new MainApp.CommonControls.EvenControl();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRuntime)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxArtist
			// 
			this.textBoxArtist.Location = new System.Drawing.Point(4, 4);
			this.textBoxArtist.Name = "textBoxArtist";
			this.textBoxArtist.Size = new System.Drawing.Size(305, 26);
			this.textBoxArtist.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(315, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Artist";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(4, 36);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(305, 26);
			this.textBoxTitle.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(315, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Title";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(130, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Year";
			// 
			// numericUpDownYear
			// 
			this.numericUpDownYear.Location = new System.Drawing.Point(4, 74);
			this.numericUpDownYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericUpDownYear.Name = "numericUpDownYear";
			this.numericUpDownYear.Size = new System.Drawing.Size(120, 26);
			this.numericUpDownYear.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(130, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "Runtime";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(442, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 20);
			this.label5.TabIndex = 14;
			this.label5.Text = "Link";
			// 
			// textBoxLink
			// 
			this.textBoxLink.Location = new System.Drawing.Point(291, 68);
			this.textBoxLink.Name = "textBoxLink";
			this.textBoxLink.Size = new System.Drawing.Size(145, 26);
			this.textBoxLink.TabIndex = 13;
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.Location = new System.Drawing.Point(70, 551);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(324, 317);
			this.pictureBoxImage.TabIndex = 15;
			this.pictureBoxImage.TabStop = false;
			// 
			// numericUpDownRuntime
			// 
			this.numericUpDownRuntime.Location = new System.Drawing.Point(3, 107);
			this.numericUpDownRuntime.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericUpDownRuntime.Name = "numericUpDownRuntime";
			this.numericUpDownRuntime.Size = new System.Drawing.Size(120, 26);
			this.numericUpDownRuntime.TabIndex = 16;
			// 
			// checkBoxIn
			// 
			this.checkBoxIn.AutoSize = true;
			this.checkBoxIn.Location = new System.Drawing.Point(397, 10);
			this.checkBoxIn.Name = "checkBoxIn";
			this.checkBoxIn.Size = new System.Drawing.Size(49, 24);
			this.checkBoxIn.TabIndex = 17;
			this.checkBoxIn.Text = "In";
			this.checkBoxIn.UseVisualStyleBackColor = true;
			// 
			// evenControl1
			// 
			this.evenControl1.Location = new System.Drawing.Point(4, 139);
			this.evenControl1.Name = "evenControl1";
			this.evenControl1.Size = new System.Drawing.Size(458, 406);
			this.evenControl1.TabIndex = 18;
			// 
			// SongInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.evenControl1);
			this.Controls.Add(this.checkBoxIn);
			this.Controls.Add(this.numericUpDownRuntime);
			this.Controls.Add(this.pictureBoxImage);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxLink);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxArtist);
			this.Name = "SongInfoControl";
			this.Size = new System.Drawing.Size(492, 884);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRuntime)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxArtist;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDownYear;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxLink;
		private System.Windows.Forms.PictureBox pictureBoxImage;
		private System.Windows.Forms.NumericUpDown numericUpDownRuntime;
		private System.Windows.Forms.CheckBox checkBoxIn;
		private CommonControls.EvenControl evenControl1;
	}
}
