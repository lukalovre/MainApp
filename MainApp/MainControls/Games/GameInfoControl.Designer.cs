
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
			this.labelHours = new System.Windows.Forms.Label();
			this.checkBoxCompleted = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.checkBox1001 = new System.Windows.Forms.CheckBox();
			this.labelLastPlayed = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.eventControl1 = new MainApp.EventControl();
			this.starRatingControl1 = new MainApp.StarRatingControl();
			this.peopleListControl1 = new MainApp.CommonControls.PeopleListControl();
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
			// labelHours
			// 
			this.labelHours.AutoSize = true;
			this.labelHours.Location = new System.Drawing.Point(4, 93);
			this.labelHours.Name = "labelHours";
			this.labelHours.Size = new System.Drawing.Size(83, 20);
			this.labelHours.TabIndex = 4;
			this.labelHours.Text = "15h 30min";
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
			this.label3.Size = new System.Drawing.Size(78, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Comment";
			// 
			// richTextBoxReview
			// 
			this.richTextBoxComment.Location = new System.Drawing.Point(4, 349);
			this.richTextBoxComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBoxComment.Name = "richTextBoxReview";
			this.richTextBoxComment.Size = new System.Drawing.Size(310, 186);
			this.richTextBoxComment.TabIndex = 8;
			this.richTextBoxComment.Text = "";
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
			this.comboBoxPlatform.Location = new System.Drawing.Point(134, 53);
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
			this.checkBox1001.Location = new System.Drawing.Point(516, 570);
			this.checkBox1001.Name = "checkBox1001";
			this.checkBox1001.Size = new System.Drawing.Size(71, 24);
			this.checkBox1001.TabIndex = 15;
			this.checkBox1001.Text = "1001";
			this.checkBox1001.UseVisualStyleBackColor = true;
			// 
			// labelLastPlayed
			// 
			this.labelLastPlayed.AutoSize = true;
			this.labelLastPlayed.Location = new System.Drawing.Point(334, 570);
			this.labelLastPlayed.Name = "labelLastPlayed";
			this.labelLastPlayed.Size = new System.Drawing.Size(171, 20);
			this.labelLastPlayed.TabIndex = 16;
			this.labelLastPlayed.Text = "Last played 5 days ago";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(338, 103);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(328, 432);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// eventControl1
			// 
			this.eventControl1.Location = new System.Drawing.Point(8, 544);
			this.eventControl1.Name = "eventControl1";
			this.eventControl1.Size = new System.Drawing.Size(306, 361);
			this.eventControl1.TabIndex = 19;
			// 
			// starRatingControl1
			// 
			this.starRatingControl1.Location = new System.Drawing.Point(8, 195);
			this.starRatingControl1.Name = "starRatingControl1";
			this.starRatingControl1.SelectedStar = 1;
			this.starRatingControl1.Size = new System.Drawing.Size(247, 103);
			this.starRatingControl1.TabIndex = 10;
			// 
			// peopleListControl1
			// 
			this.peopleListControl1.Location = new System.Drawing.Point(338, 627);
			this.peopleListControl1.Name = "peopleListControl1";
			this.peopleListControl1.Size = new System.Drawing.Size(195, 238);
			this.peopleListControl1.TabIndex = 20;
			// 
			// GameInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.peopleListControl1);
			this.Controls.Add(this.eventControl1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelLastPlayed);
			this.Controls.Add(this.checkBox1001);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.comboBoxPlatform);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.starRatingControl1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBoxComment);
			this.Controls.Add(this.checkBoxCompleted);
			this.Controls.Add(this.labelHours);
			this.Controls.Add(this.checkBoxPlaying);
			this.Name = "GameInfoControl";
			this.Size = new System.Drawing.Size(726, 997);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.CheckBox checkBoxPlaying;
		private System.Windows.Forms.Label labelHours;
		private System.Windows.Forms.CheckBox checkBoxCompleted;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextBoxComment;
		private StarRatingControl starRatingControl1;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.ComboBox comboBoxPlatform;
		private System.Windows.Forms.NumericUpDown numericUpDownYear;
		private System.Windows.Forms.CheckBox checkBox1001;
		private System.Windows.Forms.Label labelLastPlayed;
		private System.Windows.Forms.PictureBox pictureBox1;
        private EventControl eventControl1;
        private CommonControls.PeopleListControl peopleListControl1;
    }
}
