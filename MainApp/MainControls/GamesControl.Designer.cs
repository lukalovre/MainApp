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
			this.yearFilter1 = new YearFilterControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridViewGames = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridViewPlaying = new System.Windows.Forms.DataGridView();
			this.gameInfo1 = new MainApp.Games.GameInfoControl();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaying)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(773, 1048);
			this.tabControl1.TabIndex = 7;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridViewGames);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Size = new System.Drawing.Size(765, 1015);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "All";
			this.tabPage1.UseVisualStyleBackColor = true;
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
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridViewPlaying);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Size = new System.Drawing.Size(765, 1015);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Playing";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridViewPlaying
			// 
			this.dataGridViewPlaying.ColumnHeadersHeight = 34;
			this.dataGridViewPlaying.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewPlaying.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewPlaying.Name = "dataGridViewPlaying";
			this.dataGridViewPlaying.RowHeadersWidth = 62;
			this.dataGridViewPlaying.Size = new System.Drawing.Size(1040, 1124);
			this.dataGridViewPlaying.TabIndex = 0;
			this.dataGridViewPlaying.SelectionChanged += new System.EventHandler(this.DataGridViewGames_SelectionChanged);
			// 
			// gameInfo1
			// 
			this.gameInfo1.Location = new System.Drawing.Point(781, 98);
			this.gameInfo1.Name = "gameInfo1";
			this.gameInfo1.Size = new System.Drawing.Size(391, 439);
			this.gameInfo1.TabIndex = 10;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(805, 639);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(81, 36);
			this.buttonUpdate.TabIndex = 11;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
			// 
			// yearFilter1
			// 
			this.yearFilter1.Location = new System.Drawing.Point(781, 34);
			this.yearFilter1.Name = "yearFilter1";
			this.yearFilter1.Size = new System.Drawing.Size(125, 37);
			this.yearFilter1.TabIndex = 12;
			// 
			// GamesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.yearFilter1);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.gameInfo1);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "GamesControl";
			this.Size = new System.Drawing.Size(1534, 1048);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaying)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		internal DataGridView dataGridViewGames;
		internal System.Windows.Forms.TabControl tabControl1;
		internal System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		internal DataGridView dataGridViewPlaying;
		private GameInfoControl gameInfo1;
		private Button buttonUpdate;
		private YearFilterControl yearFilter1;
	}
}
