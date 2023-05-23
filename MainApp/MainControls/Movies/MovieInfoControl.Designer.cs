
namespace MainApp.Movies
{
	partial class MovieInfoControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieInfoControl));
			this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelYear = new System.Windows.Forms.Label();
			this.labelRuntime = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelDirector = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelWriters = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelStars = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBoxPlot = new System.Windows.Forms.RichTextBox();
			this.labelWatchedTimes = new System.Windows.Forms.Label();
			this.starRatingControl1 = new MainApp.StarRatingControl();
			this.buttonGoToImdb = new System.Windows.Forms.Button();
			this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.peopleListControl1 = new MainApp.CommonControls.PeopleListControl();
			this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxPoster
			// 
			this.pictureBoxPoster.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBoxPoster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPoster.Image")));
			this.pictureBoxPoster.Location = new System.Drawing.Point(13, 108);
			this.pictureBoxPoster.Name = "pictureBoxPoster";
			this.pictureBoxPoster.Size = new System.Drawing.Size(300, 440);
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
			// labelRuntime
			// 
			this.labelRuntime.AutoSize = true;
			this.labelRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRuntime.Location = new System.Drawing.Point(94, 69);
			this.labelRuntime.Name = "labelRuntime";
			this.labelRuntime.Size = new System.Drawing.Size(138, 36);
			this.labelRuntime.TabIndex = 3;
			this.labelRuntime.Text = "1h 53min";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(320, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Director";
			// 
			// labelDirector
			// 
			this.labelDirector.AutoSize = true;
			this.labelDirector.Location = new System.Drawing.Point(399, 108);
			this.labelDirector.Name = "labelDirector";
			this.labelDirector.Size = new System.Drawing.Size(136, 20);
			this.labelDirector.TabIndex = 5;
			this.labelDirector.Text = "Christopher Nolan";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(320, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Writers";
			// 
			// labelWriters
			// 
			this.labelWriters.AutoSize = true;
			this.labelWriters.Location = new System.Drawing.Point(399, 173);
			this.labelWriters.Name = "labelWriters";
			this.labelWriters.Size = new System.Drawing.Size(326, 40);
			this.labelWriters.TabIndex = 7;
			this.labelWriters.Text = "Christopher Nolan (screenplay)\r\nJonathan Nolan (short story \"Memento Mori\")";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(320, 260);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Stars";
			// 
			// labelStars
			// 
			this.labelStars.AutoSize = true;
			this.labelStars.Location = new System.Drawing.Point(399, 260);
			this.labelStars.Name = "labelStars";
			this.labelStars.Size = new System.Drawing.Size(136, 60);
			this.labelStars.TabIndex = 9;
			this.labelStars.Text = "Guy Pearce\r\nCarrie-Anne Moss\r\nJoe Pantoliano";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(319, 371);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "Plot";
			// 
			// richTextBoxPlot
			// 
			this.richTextBoxPlot.Location = new System.Drawing.Point(403, 371);
			this.richTextBoxPlot.Name = "richTextBoxPlot";
			this.richTextBoxPlot.ReadOnly = true;
			this.richTextBoxPlot.Size = new System.Drawing.Size(290, 115);
			this.richTextBoxPlot.TabIndex = 12;
			this.richTextBoxPlot.Text = "A man with short-term memory loss attempts to track down his wife\'s murderer.";
			// 
			// labelWatchedTimes
			// 
			this.labelWatchedTimes.AutoSize = true;
			this.labelWatchedTimes.Location = new System.Drawing.Point(9, 729);
			this.labelWatchedTimes.Name = "labelWatchedTimes";
			this.labelWatchedTimes.Size = new System.Drawing.Size(128, 20);
			this.labelWatchedTimes.TabIndex = 13;
			this.labelWatchedTimes.Text = "Watched 3 times";
			// 
			// starRatingControl1
			// 
			this.starRatingControl1.Location = new System.Drawing.Point(13, 554);
			this.starRatingControl1.Name = "starRatingControl1";
			this.starRatingControl1.SelectedStar = 1;
			this.starRatingControl1.Size = new System.Drawing.Size(250, 92);
			this.starRatingControl1.TabIndex = 14;
			// 
			// buttonGoToImdb
			// 
			this.buttonGoToImdb.Location = new System.Drawing.Point(13, 765);
			this.buttonGoToImdb.Name = "buttonGoToImdb";
			this.buttonGoToImdb.Size = new System.Drawing.Size(100, 32);
			this.buttonGoToImdb.TabIndex = 18;
			this.buttonGoToImdb.Text = "Go to imdb";
			this.buttonGoToImdb.UseVisualStyleBackColor = true;
			this.buttonGoToImdb.Click += new System.EventHandler(this.ButtonGoToImdb_Click);
			// 
			// comboBoxPlatform
			// 
			this.comboBoxPlatform.FormattingEnabled = true;
			this.comboBoxPlatform.Location = new System.Drawing.Point(13, 657);
			this.comboBoxPlatform.Name = "comboBoxPlatform";
			this.comboBoxPlatform.Size = new System.Drawing.Size(121, 28);
			this.comboBoxPlatform.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(140, 660);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 20);
			this.label5.TabIndex = 22;
			this.label5.Text = "Platform";
			// 
			// peopleListControl1
			// 
			this.peopleListControl1.Location = new System.Drawing.Point(269, 567);
			this.peopleListControl1.Name = "peopleListControl1";
			this.peopleListControl1.Size = new System.Drawing.Size(128, 194);
			this.peopleListControl1.TabIndex = 23;
			// 
			// richTextBoxComment
			// 
			this.richTextBoxComment.Location = new System.Drawing.Point(403, 503);
			this.richTextBoxComment.Name = "richTextBoxComment";
			this.richTextBoxComment.Size = new System.Drawing.Size(290, 258);
			this.richTextBoxComment.TabIndex = 24;
			this.richTextBoxComment.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(312, 503);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 20);
			this.label6.TabIndex = 25;
			this.label6.Text = "Comment";
			// 
			// MovieInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label6);
			this.Controls.Add(this.richTextBoxComment);
			this.Controls.Add(this.peopleListControl1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBoxPlatform);
			this.Controls.Add(this.buttonGoToImdb);
			this.Controls.Add(this.starRatingControl1);
			this.Controls.Add(this.labelWatchedTimes);
			this.Controls.Add(this.richTextBoxPlot);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelStars);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelWriters);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelDirector);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelRuntime);
			this.Controls.Add(this.labelYear);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureBoxPoster);
			this.Name = "MovieInfoControl";
			this.Size = new System.Drawing.Size(726, 837);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxPoster;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelYear;
		private System.Windows.Forms.Label labelRuntime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelDirector;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelWriters;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelStars;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBoxPlot;
		private System.Windows.Forms.Label labelWatchedTimes;
		private StarRatingControl starRatingControl1;
		private System.Windows.Forms.Button buttonGoToImdb;
        private System.Windows.Forms.ComboBox comboBoxPlatform;
        private System.Windows.Forms.Label label5;
        private CommonControls.PeopleListControl peopleListControl1;
		private System.Windows.Forms.RichTextBox richTextBoxComment;
		private System.Windows.Forms.Label label6;
	}
}
