﻿
namespace MainApp.TVShows
{
	partial class TVShowInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TVShowInfo));
			this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelYear = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelDirector = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelWriters = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelStars = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBoxPlot = new System.Windows.Forms.RichTextBox();
			this.checkBoxWatching = new System.Windows.Forms.CheckBox();
			this.listBoxSeasons = new System.Windows.Forms.ListBox();
			this.checkBoxOngoing = new System.Windows.Forms.CheckBox();
			this.checkBoxYouTube = new System.Windows.Forms.CheckBox();
			this.numericUpDownRuntime = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.checkBoxWaiting = new System.Windows.Forms.CheckBox();
			this.evenControl1 = new MainApp.CommonControls.EvenControl();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRuntime)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxPoster
			// 
			this.pictureBoxPoster.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBoxPoster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPoster.Image")));
			this.pictureBoxPoster.Location = new System.Drawing.Point(13, 108);
			this.pictureBoxPoster.Name = "pictureBoxPoster";
			this.pictureBoxPoster.Size = new System.Drawing.Size(260, 398);
			this.pictureBoxPoster.TabIndex = 0;
			this.pictureBoxPoster.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(3, 11);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(242, 58);
			this.labelTitle.TabIndex = 1;
			this.labelTitle.Text = "Memento";
			// 
			// labelYear
			// 
			this.labelYear.AutoSize = true;
			this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelYear.Location = new System.Drawing.Point(5, 69);
			this.labelYear.Name = "labelYear";
			this.labelYear.Size = new System.Drawing.Size(83, 36);
			this.labelYear.TabIndex = 2;
			this.labelYear.Text = "2000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(314, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Director";
			// 
			// labelDirector
			// 
			this.labelDirector.AutoSize = true;
			this.labelDirector.Location = new System.Drawing.Point(393, 22);
			this.labelDirector.Name = "labelDirector";
			this.labelDirector.Size = new System.Drawing.Size(136, 20);
			this.labelDirector.TabIndex = 5;
			this.labelDirector.Text = "Christopher Nolan";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(314, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Writers";
			// 
			// labelWriters
			// 
			this.labelWriters.AutoSize = true;
			this.labelWriters.Location = new System.Drawing.Point(393, 60);
			this.labelWriters.Name = "labelWriters";
			this.labelWriters.Size = new System.Drawing.Size(326, 40);
			this.labelWriters.TabIndex = 7;
			this.labelWriters.Text = "Christopher Nolan (screenplay)\r\nJonathan Nolan (short story \"Memento Mori\")";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(314, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Stars";
			// 
			// labelStars
			// 
			this.labelStars.AutoSize = true;
			this.labelStars.Location = new System.Drawing.Point(393, 131);
			this.labelStars.Name = "labelStars";
			this.labelStars.Size = new System.Drawing.Size(136, 60);
			this.labelStars.TabIndex = 9;
			this.labelStars.Text = "Guy Pearce\r\nCarrie-Anne Moss\r\nJoe Pantoliano";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(314, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "Plot";
			// 
			// richTextBoxPlot
			// 
			this.richTextBoxPlot.Location = new System.Drawing.Point(397, 220);
			this.richTextBoxPlot.Name = "richTextBoxPlot";
			this.richTextBoxPlot.ReadOnly = true;
			this.richTextBoxPlot.Size = new System.Drawing.Size(282, 115);
			this.richTextBoxPlot.TabIndex = 12;
			this.richTextBoxPlot.Text = "A man with short-term memory loss attempts to track down his wife\'s murderer.";
			// 
			// checkBoxWatching
			// 
			this.checkBoxWatching.AutoSize = true;
			this.checkBoxWatching.Location = new System.Drawing.Point(173, 526);
			this.checkBoxWatching.Name = "checkBoxWatching";
			this.checkBoxWatching.Size = new System.Drawing.Size(102, 24);
			this.checkBoxWatching.TabIndex = 15;
			this.checkBoxWatching.Text = "Watching";
			this.checkBoxWatching.UseVisualStyleBackColor = true;
			this.checkBoxWatching.CheckedChanged += new System.EventHandler(this.CheckBoxWatching_CheckedChanged);
			// 
			// listBoxSeasons
			// 
			this.listBoxSeasons.FormattingEnabled = true;
			this.listBoxSeasons.ItemHeight = 20;
			this.listBoxSeasons.Location = new System.Drawing.Point(13, 524);
			this.listBoxSeasons.Name = "listBoxSeasons";
			this.listBoxSeasons.Size = new System.Drawing.Size(154, 104);
			this.listBoxSeasons.TabIndex = 16;
			// 
			// checkBoxOngoing
			// 
			this.checkBoxOngoing.AutoSize = true;
			this.checkBoxOngoing.Location = new System.Drawing.Point(173, 556);
			this.checkBoxOngoing.Name = "checkBoxOngoing";
			this.checkBoxOngoing.Size = new System.Drawing.Size(95, 24);
			this.checkBoxOngoing.TabIndex = 17;
			this.checkBoxOngoing.Text = "Ongoing";
			this.checkBoxOngoing.UseVisualStyleBackColor = true;
			this.checkBoxOngoing.CheckedChanged += new System.EventHandler(this.CheckBoxOngoing_CheckedChanged);
			// 
			// checkBoxYouTube
			// 
			this.checkBoxYouTube.AutoSize = true;
			this.checkBoxYouTube.Location = new System.Drawing.Point(173, 584);
			this.checkBoxYouTube.Name = "checkBoxYouTube";
			this.checkBoxYouTube.Size = new System.Drawing.Size(100, 24);
			this.checkBoxYouTube.TabIndex = 18;
			this.checkBoxYouTube.Text = "YouTube";
			this.checkBoxYouTube.UseVisualStyleBackColor = true;
			this.checkBoxYouTube.CheckedChanged += new System.EventHandler(this.CheckBoxYouTube_CheckedChanged);
			// 
			// numericUpDownRuntime
			// 
			this.numericUpDownRuntime.Location = new System.Drawing.Point(122, 73);
			this.numericUpDownRuntime.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numericUpDownRuntime.Name = "numericUpDownRuntime";
			this.numericUpDownRuntime.Size = new System.Drawing.Size(73, 26);
			this.numericUpDownRuntime.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(199, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 20);
			this.label5.TabIndex = 21;
			this.label5.Text = "minutes";
			// 
			// checkBoxWaiting
			// 
			this.checkBoxWaiting.AutoSize = true;
			this.checkBoxWaiting.Location = new System.Drawing.Point(173, 614);
			this.checkBoxWaiting.Name = "checkBoxWaiting";
			this.checkBoxWaiting.Size = new System.Drawing.Size(88, 24);
			this.checkBoxWaiting.TabIndex = 23;
			this.checkBoxWaiting.Text = "Waiting";
			this.checkBoxWaiting.UseVisualStyleBackColor = true;
			this.checkBoxWaiting.CheckedChanged += new System.EventHandler(this.CheckBoxWaiting_CheckedChanged);
			// 
			// evenControl1
			// 
			this.evenControl1.Location = new System.Drawing.Point(281, 347);
			this.evenControl1.Name = "evenControl1";
			this.evenControl1.Size = new System.Drawing.Size(440, 425);
			this.evenControl1.TabIndex = 24;
			// 
			// TVShowInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.evenControl1);
			this.Controls.Add(this.checkBoxWaiting);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.numericUpDownRuntime);
			this.Controls.Add(this.checkBoxYouTube);
			this.Controls.Add(this.checkBoxOngoing);
			this.Controls.Add(this.listBoxSeasons);
			this.Controls.Add(this.checkBoxWatching);
			this.Controls.Add(this.richTextBoxPlot);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelStars);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelWriters);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelDirector);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelYear);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureBoxPoster);
			this.Name = "TVShowInfo";
			this.Size = new System.Drawing.Size(749, 775);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRuntime)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxPoster;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelYear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelDirector;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelWriters;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelStars;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBoxPlot;
		private System.Windows.Forms.CheckBox checkBoxWatching;
		private System.Windows.Forms.ListBox listBoxSeasons;
		private System.Windows.Forms.CheckBox checkBoxOngoing;
		private System.Windows.Forms.CheckBox checkBoxYouTube;
        private System.Windows.Forms.NumericUpDown numericUpDownRuntime;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox checkBoxWaiting;
		private CommonControls.EvenControl evenControl1;
	}
}
