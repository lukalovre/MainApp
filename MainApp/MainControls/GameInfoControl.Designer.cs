
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.textBoxTime = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBoxCompleted = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.richTextBoxReview = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
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
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(4, 17);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(108, 20);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "Wipeout 2097";
			// 
			// textBoxTime
			// 
			this.textBoxTime.Location = new System.Drawing.Point(8, 71);
			this.textBoxTime.Name = "textBoxTime";
			this.textBoxTime.Size = new System.Drawing.Size(51, 26);
			this.textBoxTime.TabIndex = 3;
			this.textBoxTime.Text = "13";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 74);
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
			this.label3.Location = new System.Drawing.Point(8, 221);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Review";
			// 
			// richTextBoxReview
			// 
			this.richTextBoxReview.Location = new System.Drawing.Point(8, 246);
			this.richTextBoxReview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBoxReview.Name = "richTextBoxReview";
			this.richTextBoxReview.Size = new System.Drawing.Size(310, 155);
			this.richTextBoxReview.TabIndex = 8;
			this.richTextBoxReview.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(231, 108);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Rating";
			// 
			// numericUpDownRating
			// 
			this.numericUpDownRating.Location = new System.Drawing.Point(149, 105);
			this.numericUpDownRating.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numericUpDownRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDownRating.Name = "numericUpDownRating";
			this.numericUpDownRating.Size = new System.Drawing.Size(54, 26);
			this.numericUpDownRating.TabIndex = 10;
			this.numericUpDownRating.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// GameInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDownRating);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBoxReview);
			this.Controls.Add(this.checkBoxCompleted);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxTime);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.checkBoxPlaying);
			this.Name = "GameInfo";
			this.Size = new System.Drawing.Size(456, 525);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.CheckBox checkBoxPlaying;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.TextBox textBoxTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxCompleted;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextBoxReview;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDownRating;
	}
}
