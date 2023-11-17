
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
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.checkBox1001 = new System.Windows.Forms.CheckBox();
			this.labelLastPlayed = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.evenControl1 = new MainApp.CommonControls.EvenControl();
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
			this.checkBox1001.Location = new System.Drawing.Point(134, 93);
			this.checkBox1001.Name = "checkBox1001";
			this.checkBox1001.Size = new System.Drawing.Size(71, 24);
			this.checkBox1001.TabIndex = 15;
			this.checkBox1001.Text = "1001";
			this.checkBox1001.UseVisualStyleBackColor = true;
			// 
			// labelLastPlayed
			// 
			this.labelLastPlayed.AutoSize = true;
			this.labelLastPlayed.Location = new System.Drawing.Point(427, 491);
			this.labelLastPlayed.Name = "labelLastPlayed";
			this.labelLastPlayed.Size = new System.Drawing.Size(171, 20);
			this.labelLastPlayed.TabIndex = 16;
			this.labelLastPlayed.Text = "Last played 5 days ago";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(427, 54);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(283, 434);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// evenControl1
			// 
			this.evenControl1.Location = new System.Drawing.Point(8, 184);
			this.evenControl1.Name = "evenControl1";
			this.evenControl1.Size = new System.Drawing.Size(413, 425);
			this.evenControl1.TabIndex = 18;
			// 
			// GameInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.evenControl1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelLastPlayed);
			this.Controls.Add(this.checkBox1001);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.comboBoxPlatform);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.checkBoxCompleted);
			this.Controls.Add(this.labelHours);
			this.Controls.Add(this.checkBoxPlaying);
			this.Name = "GameInfoControl";
			this.Size = new System.Drawing.Size(726, 622);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.CheckBox checkBoxPlaying;
		private System.Windows.Forms.Label labelHours;
		private System.Windows.Forms.CheckBox checkBoxCompleted;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.ComboBox comboBoxPlatform;
		private System.Windows.Forms.NumericUpDown numericUpDownYear;
		private System.Windows.Forms.CheckBox checkBox1001;
		private System.Windows.Forms.Label labelLastPlayed;
		private System.Windows.Forms.PictureBox pictureBox1;
		private CommonControls.EvenControl evenControl1;
	}
}
