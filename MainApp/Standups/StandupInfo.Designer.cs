
namespace MainApp.Standups
{
	partial class StandupInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandupInfo));
			this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelYear = new System.Windows.Forms.Label();
			this.labelRuntime = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelPerformer = new System.Windows.Forms.Label();
			this.starRatingControl1 = new StarRating();
			this.buttonGoToImdb = new System.Windows.Forms.Button();
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
			this.label1.Size = new System.Drawing.Size(94, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Performer";
			// 
			// labelPerformer
			// 
			this.labelPerformer.AutoSize = true;
			this.labelPerformer.Location = new System.Drawing.Point(420, 108);
			this.labelPerformer.Name = "labelPerformer";
			this.labelPerformer.Size = new System.Drawing.Size(136, 20);
			this.labelPerformer.TabIndex = 5;
			this.labelPerformer.Text = "Christopher Nolan";
			// 
			// starRatingControl1
			// 
			this.starRatingControl1.Location = new System.Drawing.Point(13, 554);
			this.starRatingControl1.Name = "starRatingControl1";
			this.starRatingControl1.Size = new System.Drawing.Size(201, 44);
			this.starRatingControl1.TabIndex = 14;
			this.starRatingControl1.Text = "starRatingControl1";
			// 
			// buttonGoToImdb
			// 
			this.buttonGoToImdb.Location = new System.Drawing.Point(13, 613);
			this.buttonGoToImdb.Name = "buttonGoToImdb";
			this.buttonGoToImdb.Size = new System.Drawing.Size(144, 32);
			this.buttonGoToImdb.TabIndex = 18;
			this.buttonGoToImdb.Text = "Go to imdb";
			this.buttonGoToImdb.UseVisualStyleBackColor = true;
			this.buttonGoToImdb.Click += new System.EventHandler(this.ButtonGoToImdb_Click);
			// 
			// StandupInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonGoToImdb);
			this.Controls.Add(this.starRatingControl1);
			this.Controls.Add(this.labelPerformer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelRuntime);
			this.Controls.Add(this.labelYear);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureBoxPoster);
			this.Name = "StandupInfo";
			this.Size = new System.Drawing.Size(756, 665);
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
		private System.Windows.Forms.Label labelPerformer;
		private StarRating starRatingControl1;
		private System.Windows.Forms.Button buttonGoToImdb;
	}
}
