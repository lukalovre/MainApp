
using System.Windows.Forms;

namespace MainApp.Games
{
	partial class GameInfoControl
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
			this.checkBoxPlaying = new System.Windows.Forms.CheckBox();
			this.textBoxTime = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBoxCompleted = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.richTextBoxReview = new System.Windows.Forms.RichTextBox();
			this.labelAddingTime = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.checkBox1001 = new System.Windows.Forms.CheckBox();
			this.starRatingControl1 = new MainApp.StarRatingControl();
			this.labelLastPlayed = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// checkBoxPlaying
			// 
			this.checkBoxPlaying.AutoSize = true;
			this.checkBoxPlaying.Location = new System.Drawing.Point(3, 123);
			this.checkBoxPlaying.Name = "checkBoxPlaying";
			this.checkBoxPlaying.Size = new System.Drawing.Size(85, 24);
			this.checkBoxPlaying.TabIndex = 1;
			this.checkBoxPlaying.Text = "Playing";
			this.checkBoxPlaying.UseVisualStyleBackColor = true;
			this.checkBoxPlaying.CheckedChanged += new System.EventHandler(this.CheckBoxPlaying_CheckedChanged);
			// 
			// textBoxTime
			// 
			this.textBoxTime.Location = new System.Drawing.Point(19, 95);
			this.textBoxTime.Name = "textBoxTime";
			this.textBoxTime.Size = new System.Drawing.Size(51, 26);
			this.textBoxTime.TabIndex = 3;
			this.textBoxTime.Text = "13";
			this.textBoxTime.TextChanged += new System.EventHandler(this.TextBoxTime_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Time";
			// 
			// checkBoxCompleted
			// 
			this.checkBoxCompleted.AutoSize = true;
			this.checkBoxCompleted.Location = new System.Drawing.Point(0, 154);
			this.checkBoxCompleted.Name = "checkBoxCompleted";
			this.checkBoxCompleted.Size = new System.Drawing.Size(112, 24);
			this.checkBoxCompleted.TabIndex = 5;
			this.checkBoxCompleted.Text = "Completed";
			this.checkBoxCompleted.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 324);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Review";
			// 
			// richTextBoxReview
			// 
			this.richTextBoxReview.Location = new System.Drawing.Point(4, 349);
			this.richTextBoxReview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBoxReview.Name = "richTextBoxReview";
			this.richTextBoxReview.Size = new System.Drawing.Size(310, 155);
			this.richTextBoxReview.TabIndex = 8;
			this.richTextBoxReview.Text = "";
			// 
			// labelAddingTime
			// 
			this.labelAddingTime.AutoSize = true;
			this.labelAddingTime.Location = new System.Drawing.Point(126, 100);
			this.labelAddingTime.Name = "labelAddingTime";
			this.labelAddingTime.Size = new System.Drawing.Size(119, 20);
			this.labelAddingTime.TabIndex = 11;
			this.labelAddingTime.Text = "Adding 0.5 time";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTitle.Location = new System.Drawing.Point(8, 3);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(499, 44);
			this.textBoxTitle.TabIndex = 12;
			this.textBoxTitle.Text = "Wipeout 2097";
			// 
			// comboBoxPlatform
			// 
			this.comboBoxPlatform.FormattingEnabled = true;
			this.comboBoxPlatform.Location = new System.Drawing.Point(179, 137);
			this.comboBoxPlatform.Name = "comboBoxPlatform";
			this.comboBoxPlatform.Size = new System.Drawing.Size(121, 28);
			this.comboBoxPlatform.TabIndex = 13;
			this.comboBoxPlatform.Text = "PS1";
			// 
			// numericUpDownYear
			// 
			this.numericUpDownYear.Location = new System.Drawing.Point(8, 54);
			this.numericUpDownYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.numericUpDownYear.Name = "numericUpDownYear";
			this.numericUpDownYear.Size = new System.Drawing.Size(120, 26);
			this.numericUpDownYear.TabIndex = 14;
			// 
			// checkBox1001
			// 
			this.checkBox1001.AutoSize = true;
			this.checkBox1001.Location = new System.Drawing.Point(167, 54);
			this.checkBox1001.Name = "checkBox1001";
			this.checkBox1001.Size = new System.Drawing.Size(71, 24);
			this.checkBox1001.TabIndex = 15;
			this.checkBox1001.Text = "1001";
			this.checkBox1001.UseVisualStyleBackColor = true;
			// 
			// starRatingControl1
			// 
			this.starRatingControl1.Location = new System.Drawing.Point(8, 195);
			this.starRatingControl1.Name = "starRatingControl1";
			this.starRatingControl1.SelectedStar = 1;
			this.starRatingControl1.Size = new System.Drawing.Size(247, 103);
			this.starRatingControl1.TabIndex = 10;
			// 
			// labelLastPlayed
			// 
			this.labelLastPlayed.AutoSize = true;
			this.labelLastPlayed.Location = new System.Drawing.Point(263, 195);
			this.labelLastPlayed.Name = "labelLastPlayed";
			this.labelLastPlayed.Size = new System.Drawing.Size(171, 20);
			this.labelLastPlayed.TabIndex = 16;
			this.labelLastPlayed.Text = "Last played 5 days ago";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(358, 247);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(328, 432);
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			// 
			// GameInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelLastPlayed);
			this.Controls.Add(this.checkBox1001);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.comboBoxPlatform);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.labelAddingTime);
			this.Controls.Add(this.starRatingControl1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBoxReview);
			this.Controls.Add(this.checkBoxCompleted);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxTime);
			this.Controls.Add(this.checkBoxPlaying);
			this.Name = "GameInfoControl";
			this.Size = new System.Drawing.Size(726, 761);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.CheckBox checkBoxPlaying;
		private System.Windows.Forms.TextBox textBoxTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxCompleted;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextBoxReview;
		private StarRatingControl starRatingControl1;
		private System.Windows.Forms.Label labelAddingTime;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.ComboBox comboBoxPlatform;
		private System.Windows.Forms.NumericUpDown numericUpDownYear;
		private System.Windows.Forms.CheckBox checkBox1001;
		private System.Windows.Forms.Label labelLastPlayed;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
