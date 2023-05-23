using System;

namespace MainApp.StatsControls.SummaryControls
{
    partial class GameSummaryControl
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
			this.label1 = new System.Windows.Forms.Label();
			this.labelGamesPlayed = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelHoursPlayed = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelGamesUnder1h = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelNewGames = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelOldGames = new System.Windows.Forms.Label();
			this.numericUpDownStartYear = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownEndYear = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.trackBarStars = new System.Windows.Forms.TrackBar();
			this.trackBarTime = new System.Windows.Forms.TrackBar();
			this.checkBoxLock = new System.Windows.Forms.CheckBox();
			this.labelRating = new System.Windows.Forms.Label();
			this.labelPlaytime = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarStars)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Games played";
			// 
			// labelGamesPlayed
			// 
			this.labelGamesPlayed.AutoSize = true;
			this.labelGamesPlayed.Location = new System.Drawing.Point(121, 42);
			this.labelGamesPlayed.Name = "labelGamesPlayed";
			this.labelGamesPlayed.Size = new System.Drawing.Size(27, 20);
			this.labelGamesPlayed.TabIndex = 2;
			this.labelGamesPlayed.Text = "32";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Hours played";
			// 
			// labelHoursPlayed
			// 
			this.labelHoursPlayed.AutoSize = true;
			this.labelHoursPlayed.Location = new System.Drawing.Point(116, 72);
			this.labelHoursPlayed.Name = "labelHoursPlayed";
			this.labelHoursPlayed.Size = new System.Drawing.Size(27, 20);
			this.labelHoursPlayed.TabIndex = 4;
			this.labelHoursPlayed.Text = "52";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Games under 1h";
			// 
			// labelGamesUnder1h
			// 
			this.labelGamesUnder1h.AutoSize = true;
			this.labelGamesUnder1h.Location = new System.Drawing.Point(138, 103);
			this.labelGamesUnder1h.Name = "labelGamesUnder1h";
			this.labelGamesUnder1h.Size = new System.Drawing.Size(27, 20);
			this.labelGamesUnder1h.TabIndex = 6;
			this.labelGamesUnder1h.Text = "58";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "New games";
			// 
			// labelNewGames
			// 
			this.labelNewGames.AutoSize = true;
			this.labelNewGames.Location = new System.Drawing.Point(111, 140);
			this.labelNewGames.Name = "labelNewGames";
			this.labelNewGames.Size = new System.Drawing.Size(27, 20);
			this.labelNewGames.TabIndex = 8;
			this.labelNewGames.Text = "32";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Old games";
			// 
			// labelOldGames
			// 
			this.labelOldGames.AutoSize = true;
			this.labelOldGames.Location = new System.Drawing.Point(102, 176);
			this.labelOldGames.Name = "labelOldGames";
			this.labelOldGames.Size = new System.Drawing.Size(27, 20);
			this.labelOldGames.TabIndex = 10;
			this.labelOldGames.Text = "35";
			// 
			// numericUpDownStartYear
			// 
			this.numericUpDownStartYear.Location = new System.Drawing.Point(8, 3);
			this.numericUpDownStartYear.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
			this.numericUpDownStartYear.Name = "numericUpDownStartYear";
			this.numericUpDownStartYear.Size = new System.Drawing.Size(68, 26);
			this.numericUpDownStartYear.TabIndex = 11;
			this.numericUpDownStartYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
			this.numericUpDownStartYear.ValueChanged += new System.EventHandler(this.NumericUpDownYear_ValueChanged);
			// 
			// numericUpDownEndYear
			// 
			this.numericUpDownEndYear.Location = new System.Drawing.Point(109, 3);
			this.numericUpDownEndYear.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
			this.numericUpDownEndYear.Name = "numericUpDownEndYear";
			this.numericUpDownEndYear.Size = new System.Drawing.Size(68, 26);
			this.numericUpDownEndYear.TabIndex = 12;
			this.numericUpDownEndYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
			this.numericUpDownEndYear.ValueChanged += new System.EventHandler(this.NumericUpDownYear_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(80, 5);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 20);
			this.label6.TabIndex = 13;
			this.label6.Text = "to";
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(306, 5);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.Size = new System.Drawing.Size(1179, 957);
			this.dataGridView.TabIndex = 14;
			// 
			// trackBarStars
			// 
			this.trackBarStars.Location = new System.Drawing.Point(8, 267);
			this.trackBarStars.Maximum = 5;
			this.trackBarStars.Minimum = 1;
			this.trackBarStars.Name = "trackBarStars";
			this.trackBarStars.Size = new System.Drawing.Size(239, 69);
			this.trackBarStars.TabIndex = 15;
			this.trackBarStars.Value = 1;
			this.trackBarStars.Scroll += new System.EventHandler(this.TrackBarStars_Scroll);
			this.trackBarStars.ValueChanged += new System.EventHandler(this.TrackBarStars_ValueChanged);
			// 
			// trackBarTime
			// 
			this.trackBarTime.Location = new System.Drawing.Point(8, 462);
			this.trackBarTime.Name = "trackBarTime";
			this.trackBarTime.Size = new System.Drawing.Size(239, 69);
			this.trackBarTime.TabIndex = 16;
			this.trackBarTime.Scroll += new System.EventHandler(this.TrackBarTime_Scroll);
			this.trackBarTime.ValueChanged += new System.EventHandler(this.TrackBarTime_ValueChanged);
			// 
			// checkBoxLock
			// 
			this.checkBoxLock.AutoSize = true;
			this.checkBoxLock.Checked = true;
			this.checkBoxLock.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxLock.Location = new System.Drawing.Point(184, 3);
			this.checkBoxLock.Name = "checkBoxLock";
			this.checkBoxLock.Size = new System.Drawing.Size(103, 24);
			this.checkBoxLock.TabIndex = 17;
			this.checkBoxLock.Text = "Lock year";
			this.checkBoxLock.UseVisualStyleBackColor = true;
			// 
			// labelRating
			// 
			this.labelRating.AutoSize = true;
			this.labelRating.Location = new System.Drawing.Point(17, 233);
			this.labelRating.Name = "labelRating";
			this.labelRating.Size = new System.Drawing.Size(91, 20);
			this.labelRating.TabIndex = 18;
			this.labelRating.Text = "Rating >= 3";
			// 
			// labelPlaytime
			// 
			this.labelPlaytime.AutoSize = true;
			this.labelPlaytime.Location = new System.Drawing.Point(17, 439);
			this.labelPlaytime.Name = "labelPlaytime";
			this.labelPlaytime.Size = new System.Drawing.Size(103, 20);
			this.labelPlaytime.TabIndex = 19;
			this.labelPlaytime.Text = "Playtime >= 2";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 592);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(113, 24);
			this.checkBox1.TabIndex = 20;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
			// 
			// GameSummaryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.labelPlaytime);
			this.Controls.Add(this.labelRating);
			this.Controls.Add(this.checkBoxLock);
			this.Controls.Add(this.trackBarTime);
			this.Controls.Add(this.trackBarStars);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.numericUpDownEndYear);
			this.Controls.Add(this.numericUpDownStartYear);
			this.Controls.Add(this.labelOldGames);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelNewGames);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelGamesUnder1h);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelHoursPlayed);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelGamesPlayed);
			this.Controls.Add(this.label1);
			this.Name = "GameSummaryControl";
			this.Size = new System.Drawing.Size(1513, 981);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarStars)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGamesPlayed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHoursPlayed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGamesUnder1h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNewGames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOldGames;
        private System.Windows.Forms.NumericUpDown numericUpDownStartYear;
        private System.Windows.Forms.NumericUpDown numericUpDownEndYear;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.TrackBar trackBarStars;
		private System.Windows.Forms.TrackBar trackBarTime;
		private System.Windows.Forms.CheckBox checkBoxLock;
		private System.Windows.Forms.Label labelRating;
		private System.Windows.Forms.Label labelPlaytime;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}
