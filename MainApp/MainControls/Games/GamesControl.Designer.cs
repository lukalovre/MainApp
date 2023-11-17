using System.Windows.Forms;

namespace MainApp.Games
{
	partial class GamesControl
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPagePlaying = new System.Windows.Forms.TabPage();
			this.dataGridViewPlaying = new System.Windows.Forms.DataGridView();
			this.tabPageAll = new System.Windows.Forms.TabPage();
			this.dataGridViewGames = new System.Windows.Forms.DataGridView();
			this.textBoxIgdb = new System.Windows.Forms.TextBox();
			this.checkBoxTotalTime = new System.Windows.Forms.CheckBox();
			this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
			this.labelAddingTime = new System.Windows.Forms.Label();
			this.yearFilter1 = new MainApp.YearFilterControl();
			this.gameInfo = new MainApp.Games.GameInfoControl();
			this.addButton1 = new MainApp.CommonControls.AddButton();
			this.tabControl1.SuspendLayout();
			this.tabPagePlaying.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaying)).BeginInit();
			this.tabPageAll.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPagePlaying);
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(773, 997);
			this.tabControl1.TabIndex = 7;
			// 
			// tabPagePlaying
			// 
			this.tabPagePlaying.Controls.Add(this.dataGridViewPlaying);
			this.tabPagePlaying.Location = new System.Drawing.Point(4, 29);
			this.tabPagePlaying.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPagePlaying.Name = "tabPagePlaying";
			this.tabPagePlaying.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPagePlaying.Size = new System.Drawing.Size(765, 964);
			this.tabPagePlaying.TabIndex = 1;
			this.tabPagePlaying.Text = "Playing";
			this.tabPagePlaying.UseVisualStyleBackColor = true;
			// 
			// dataGridViewPlaying
			// 
			this.dataGridViewPlaying.ColumnHeadersHeight = 34;
			this.dataGridViewPlaying.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewPlaying.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewPlaying.Name = "dataGridViewPlaying";
			this.dataGridViewPlaying.RowHeadersWidth = 62;
			this.dataGridViewPlaying.Size = new System.Drawing.Size(591, 651);
			this.dataGridViewPlaying.TabIndex = 0;
			this.dataGridViewPlaying.SelectionChanged += new System.EventHandler(this.DataGridViewGames_SelectionChanged);
			// 
			// tabPageAll
			// 
			this.tabPageAll.Controls.Add(this.dataGridViewGames);
			this.tabPageAll.Location = new System.Drawing.Point(4, 29);
			this.tabPageAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Name = "tabPageAll";
			this.tabPageAll.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Size = new System.Drawing.Size(765, 964);
			this.tabPageAll.TabIndex = 0;
			this.tabPageAll.Text = "All";
			this.tabPageAll.UseVisualStyleBackColor = true;
			// 
			// dataGridViewGames
			// 
			this.dataGridViewGames.ColumnHeadersHeight = 34;
			this.dataGridViewGames.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewGames.Name = "dataGridViewGames";
			this.dataGridViewGames.RowHeadersWidth = 62;
			this.dataGridViewGames.Size = new System.Drawing.Size(686, 947);
			this.dataGridViewGames.TabIndex = 1;
			this.dataGridViewGames.SelectionChanged += new System.EventHandler(this.DataGridViewGames_SelectionChanged);
			// 
			// textBoxIgdb
			// 
			this.textBoxIgdb.Location = new System.Drawing.Point(907, 34);
			this.textBoxIgdb.Name = "textBoxIgdb";
			this.textBoxIgdb.Size = new System.Drawing.Size(111, 26);
			this.textBoxIgdb.TabIndex = 14;
			this.textBoxIgdb.TextChanged += new System.EventHandler(this.TextBoxIgdb_TextChanged);
			// 
			// checkBoxTotalTime
			// 
			this.checkBoxTotalTime.AutoSize = true;
			this.checkBoxTotalTime.Checked = true;
			this.checkBoxTotalTime.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxTotalTime.Location = new System.Drawing.Point(1368, 27);
			this.checkBoxTotalTime.Name = "checkBoxTotalTime";
			this.checkBoxTotalTime.Size = new System.Drawing.Size(104, 24);
			this.checkBoxTotalTime.TabIndex = 24;
			this.checkBoxTotalTime.Text = "Total time";
			this.checkBoxTotalTime.UseVisualStyleBackColor = true;
			this.checkBoxTotalTime.CheckedChanged += new System.EventHandler(this.CheckBoxTotalTime_CheckedChanged);
			// 
			// numericUpDownHours
			// 
			this.numericUpDownHours.Location = new System.Drawing.Point(1368, 57);
			this.numericUpDownHours.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numericUpDownHours.Name = "numericUpDownHours";
			this.numericUpDownHours.Size = new System.Drawing.Size(54, 26);
			this.numericUpDownHours.TabIndex = 23;
			this.numericUpDownHours.ValueChanged += new System.EventHandler(this.NumericUpDownTime_ValueChanged);
			// 
			// numericUpDownMinutes
			// 
			this.numericUpDownMinutes.Location = new System.Drawing.Point(1425, 57);
			this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numericUpDownMinutes.Name = "numericUpDownMinutes";
			this.numericUpDownMinutes.Size = new System.Drawing.Size(54, 26);
			this.numericUpDownMinutes.TabIndex = 22;
			this.numericUpDownMinutes.ValueChanged += new System.EventHandler(this.NumericUpDownTime_ValueChanged);
			// 
			// labelAddingTime
			// 
			this.labelAddingTime.AutoSize = true;
			this.labelAddingTime.Location = new System.Drawing.Point(1195, 69);
			this.labelAddingTime.Name = "labelAddingTime";
			this.labelAddingTime.Size = new System.Drawing.Size(144, 20);
			this.labelAddingTime.TabIndex = 21;
			this.labelAddingTime.Text = "Adding 15 min time";
			// 
			// yearFilter1
			// 
			this.yearFilter1.Location = new System.Drawing.Point(776, 29);
			this.yearFilter1.Name = "yearFilter1";
			this.yearFilter1.Size = new System.Drawing.Size(125, 37);
			this.yearFilter1.TabIndex = 12;
			// 
			// gameInfo
			// 
			this.gameInfo.Location = new System.Drawing.Point(781, 98);
			this.gameInfo.Name = "gameInfo";
			this.gameInfo.Size = new System.Drawing.Size(750, 896);
			this.gameInfo.TabIndex = 10;
			// 
			// addButton1
			// 
			this.addButton1.Location = new System.Drawing.Point(1024, 23);
			this.addButton1.Name = "addButton1";
			this.addButton1.Size = new System.Drawing.Size(315, 43);
			this.addButton1.TabIndex = 25;
			// 
			// GamesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.addButton1);
			this.Controls.Add(this.checkBoxTotalTime);
			this.Controls.Add(this.numericUpDownHours);
			this.Controls.Add(this.numericUpDownMinutes);
			this.Controls.Add(this.labelAddingTime);
			this.Controls.Add(this.textBoxIgdb);
			this.Controls.Add(this.yearFilter1);
			this.Controls.Add(this.gameInfo);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "GamesControl";
			this.Size = new System.Drawing.Size(1534, 997);
			this.tabControl1.ResumeLayout(false);
			this.tabPagePlaying.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaying)).EndInit();
			this.tabPageAll.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal DataGridView dataGridViewGames;
		internal System.Windows.Forms.TabControl tabControl1;
		internal System.Windows.Forms.TabPage tabPageAll;
		private System.Windows.Forms.TabPage tabPagePlaying;
		internal DataGridView dataGridViewPlaying;
		private GameInfoControl gameInfo;
		private YearFilterControl yearFilter1;
		private TextBox textBoxIgdb;
        private CheckBox checkBoxTotalTime;
        private NumericUpDown numericUpDownHours;
        private NumericUpDown numericUpDownMinutes;
        private Label labelAddingTime;
		private CommonControls.AddButton addButton1;
	}
}
