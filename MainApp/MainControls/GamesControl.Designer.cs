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
			this.tabPageAll = new System.Windows.Forms.TabPage();
			this.dataGridViewGames = new System.Windows.Forms.DataGridView();
			this.tabPagePlaying = new System.Windows.Forms.TabPage();
			this.dataGridViewPlaying = new System.Windows.Forms.DataGridView();
			this.tabPage1001 = new System.Windows.Forms.TabPage();
			this.dataGridView1001 = new System.Windows.Forms.DataGridView();
			this.tabPageCanon = new System.Windows.Forms.TabPage();
			this.dataGridViewCanon = new System.Windows.Forms.DataGridView();
			this.tabPageWiki = new System.Windows.Forms.TabPage();
			this.dataGridViewWiki = new System.Windows.Forms.DataGridView();
			this.tabPageGOTY = new System.Windows.Forms.TabPage();
			this.dataGridViewGOTY = new System.Windows.Forms.DataGridView();
			this.tabPageMetacritic = new System.Windows.Forms.TabPage();
			this.dataGridViewMetacritic = new System.Windows.Forms.DataGridView();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.yearFilter1 = new MainApp.YearFilterControl();
			this.gameInfo = new MainApp.Games.GameInfoControl();
			this.textBoxIgdb = new System.Windows.Forms.TextBox();
			this.tabPageZP = new System.Windows.Forms.TabPage();
			this.tabPageBlow = new System.Windows.Forms.TabPage();
			this.tabPageMcNally = new System.Windows.Forms.TabPage();
			this.dataGridViewZP = new System.Windows.Forms.DataGridView();
			this.dataGridViewBlow = new System.Windows.Forms.DataGridView();
			this.dataGridViewMcNelly = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.tabPageAll.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
			this.tabPagePlaying.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaying)).BeginInit();
			this.tabPage1001.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1001)).BeginInit();
			this.tabPageCanon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanon)).BeginInit();
			this.tabPageWiki.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewWiki)).BeginInit();
			this.tabPageGOTY.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGOTY)).BeginInit();
			this.tabPageMetacritic.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetacritic)).BeginInit();
			this.tabPageZP.SuspendLayout();
			this.tabPageBlow.SuspendLayout();
			this.tabPageMcNally.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewZP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMcNelly)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Controls.Add(this.tabPagePlaying);
			this.tabControl1.Controls.Add(this.tabPage1001);
			this.tabControl1.Controls.Add(this.tabPageCanon);
			this.tabControl1.Controls.Add(this.tabPageWiki);
			this.tabControl1.Controls.Add(this.tabPageGOTY);
			this.tabControl1.Controls.Add(this.tabPageMetacritic);
			this.tabControl1.Controls.Add(this.tabPageZP);
			this.tabControl1.Controls.Add(this.tabPageBlow);
			this.tabControl1.Controls.Add(this.tabPageMcNally);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(773, 997);
			this.tabControl1.TabIndex = 7;
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
			this.dataGridViewPlaying.Size = new System.Drawing.Size(1040, 1124);
			this.dataGridViewPlaying.TabIndex = 0;
			this.dataGridViewPlaying.SelectionChanged += new System.EventHandler(this.DataGridViewGames_SelectionChanged);
			// 
			// tabPage1001
			// 
			this.tabPage1001.Controls.Add(this.dataGridView1001);
			this.tabPage1001.Location = new System.Drawing.Point(4, 29);
			this.tabPage1001.Name = "tabPage1001";
			this.tabPage1001.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1001.Size = new System.Drawing.Size(765, 964);
			this.tabPage1001.TabIndex = 2;
			this.tabPage1001.Text = "1001";
			this.tabPage1001.UseVisualStyleBackColor = true;
			// 
			// dataGridView1001
			// 
			this.dataGridView1001.AllowUserToAddRows = false;
			this.dataGridView1001.AllowUserToDeleteRows = false;
			this.dataGridView1001.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1001.Location = new System.Drawing.Point(7, 7);
			this.dataGridView1001.Name = "dataGridView1001";
			this.dataGridView1001.ReadOnly = true;
			this.dataGridView1001.RowHeadersWidth = 62;
			this.dataGridView1001.RowTemplate.Height = 28;
			this.dataGridView1001.Size = new System.Drawing.Size(752, 1005);
			this.dataGridView1001.TabIndex = 0;
			// 
			// tabPageCanon
			// 
			this.tabPageCanon.Controls.Add(this.dataGridViewCanon);
			this.tabPageCanon.Location = new System.Drawing.Point(4, 29);
			this.tabPageCanon.Name = "tabPageCanon";
			this.tabPageCanon.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCanon.Size = new System.Drawing.Size(765, 964);
			this.tabPageCanon.TabIndex = 3;
			this.tabPageCanon.Text = "Canon";
			this.tabPageCanon.UseVisualStyleBackColor = true;
			// 
			// dataGridViewCanon
			// 
			this.dataGridViewCanon.AllowUserToAddRows = false;
			this.dataGridViewCanon.AllowUserToDeleteRows = false;
			this.dataGridViewCanon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCanon.Location = new System.Drawing.Point(7, 5);
			this.dataGridViewCanon.Name = "dataGridViewCanon";
			this.dataGridViewCanon.ReadOnly = true;
			this.dataGridViewCanon.RowHeadersWidth = 62;
			this.dataGridViewCanon.RowTemplate.Height = 28;
			this.dataGridViewCanon.Size = new System.Drawing.Size(752, 1004);
			this.dataGridViewCanon.TabIndex = 0;
			// 
			// tabPageWiki
			// 
			this.tabPageWiki.Controls.Add(this.dataGridViewWiki);
			this.tabPageWiki.Location = new System.Drawing.Point(4, 29);
			this.tabPageWiki.Name = "tabPageWiki";
			this.tabPageWiki.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageWiki.Size = new System.Drawing.Size(765, 964);
			this.tabPageWiki.TabIndex = 4;
			this.tabPageWiki.Text = "Wiki";
			this.tabPageWiki.UseVisualStyleBackColor = true;
			// 
			// dataGridViewWiki
			// 
			this.dataGridViewWiki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewWiki.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewWiki.Name = "dataGridViewWiki";
			this.dataGridViewWiki.RowHeadersWidth = 62;
			this.dataGridViewWiki.RowTemplate.Height = 28;
			this.dataGridViewWiki.Size = new System.Drawing.Size(755, 1007);
			this.dataGridViewWiki.TabIndex = 0;
			// 
			// tabPageGOTY
			// 
			this.tabPageGOTY.Controls.Add(this.dataGridViewGOTY);
			this.tabPageGOTY.Location = new System.Drawing.Point(4, 29);
			this.tabPageGOTY.Name = "tabPageGOTY";
			this.tabPageGOTY.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGOTY.Size = new System.Drawing.Size(765, 964);
			this.tabPageGOTY.TabIndex = 5;
			this.tabPageGOTY.Text = "GOTY";
			this.tabPageGOTY.UseVisualStyleBackColor = true;
			// 
			// dataGridViewGOTY
			// 
			this.dataGridViewGOTY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewGOTY.Location = new System.Drawing.Point(0, 7);
			this.dataGridViewGOTY.Name = "dataGridViewGOTY";
			this.dataGridViewGOTY.RowHeadersWidth = 62;
			this.dataGridViewGOTY.RowTemplate.Height = 28;
			this.dataGridViewGOTY.Size = new System.Drawing.Size(759, 1002);
			this.dataGridViewGOTY.TabIndex = 0;
			// 
			// tabPageMetacritic
			// 
			this.tabPageMetacritic.Controls.Add(this.dataGridViewMetacritic);
			this.tabPageMetacritic.Location = new System.Drawing.Point(4, 29);
			this.tabPageMetacritic.Name = "tabPageMetacritic";
			this.tabPageMetacritic.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMetacritic.Size = new System.Drawing.Size(765, 964);
			this.tabPageMetacritic.TabIndex = 6;
			this.tabPageMetacritic.Text = "Metacritic";
			this.tabPageMetacritic.UseVisualStyleBackColor = true;
			// 
			// dataGridViewMetacritic
			// 
			this.dataGridViewMetacritic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMetacritic.Location = new System.Drawing.Point(7, 7);
			this.dataGridViewMetacritic.Name = "dataGridViewMetacritic";
			this.dataGridViewMetacritic.RowHeadersWidth = 62;
			this.dataGridViewMetacritic.RowTemplate.Height = 28;
			this.dataGridViewMetacritic.Size = new System.Drawing.Size(618, 564);
			this.dataGridViewMetacritic.TabIndex = 0;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(807, 855);
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
			// gameInfo
			// 
			this.gameInfo.Location = new System.Drawing.Point(781, 98);
			this.gameInfo.Name = "gameInfo";
			this.gameInfo.Size = new System.Drawing.Size(735, 742);
			this.gameInfo.TabIndex = 10;
			// 
			// textBoxIgdb
			// 
			this.textBoxIgdb.Location = new System.Drawing.Point(779, 913);
			this.textBoxIgdb.Name = "textBoxIgdb";
			this.textBoxIgdb.Size = new System.Drawing.Size(237, 26);
			this.textBoxIgdb.TabIndex = 14;
			this.textBoxIgdb.TextChanged += new System.EventHandler(this.TextBoxIgdb_TextChanged);
			// 
			// tabPageZP
			// 
			this.tabPageZP.Controls.Add(this.dataGridViewZP);
			this.tabPageZP.Location = new System.Drawing.Point(4, 29);
			this.tabPageZP.Name = "tabPageZP";
			this.tabPageZP.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageZP.Size = new System.Drawing.Size(765, 964);
			this.tabPageZP.TabIndex = 7;
			this.tabPageZP.Text = "ZP";
			this.tabPageZP.UseVisualStyleBackColor = true;
			// 
			// tabPageBlow
			// 
			this.tabPageBlow.Controls.Add(this.dataGridViewBlow);
			this.tabPageBlow.Location = new System.Drawing.Point(4, 29);
			this.tabPageBlow.Name = "tabPageBlow";
			this.tabPageBlow.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageBlow.Size = new System.Drawing.Size(765, 964);
			this.tabPageBlow.TabIndex = 8;
			this.tabPageBlow.Text = "Blow";
			this.tabPageBlow.UseVisualStyleBackColor = true;
			// 
			// tabPageMcNally
			// 
			this.tabPageMcNally.Controls.Add(this.dataGridViewMcNelly);
			this.tabPageMcNally.Location = new System.Drawing.Point(4, 29);
			this.tabPageMcNally.Name = "tabPageMcNally";
			this.tabPageMcNally.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMcNally.Size = new System.Drawing.Size(765, 964);
			this.tabPageMcNally.TabIndex = 9;
			this.tabPageMcNally.Text = "McNally";
			this.tabPageMcNally.UseVisualStyleBackColor = true;
			// 
			// dataGridViewZP
			// 
			this.dataGridViewZP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewZP.Location = new System.Drawing.Point(7, 7);
			this.dataGridViewZP.Name = "dataGridViewZP";
			this.dataGridViewZP.RowHeadersWidth = 62;
			this.dataGridViewZP.RowTemplate.Height = 28;
			this.dataGridViewZP.Size = new System.Drawing.Size(739, 869);
			this.dataGridViewZP.TabIndex = 0;
			// 
			// dataGridViewBlow
			// 
			this.dataGridViewBlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewBlow.Location = new System.Drawing.Point(7, 0);
			this.dataGridViewBlow.Name = "dataGridViewBlow";
			this.dataGridViewBlow.RowHeadersWidth = 62;
			this.dataGridViewBlow.RowTemplate.Height = 28;
			this.dataGridViewBlow.Size = new System.Drawing.Size(672, 527);
			this.dataGridViewBlow.TabIndex = 0;
			// 
			// dataGridViewMcNelly
			// 
			this.dataGridViewMcNelly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMcNelly.Location = new System.Drawing.Point(7, 7);
			this.dataGridViewMcNelly.Name = "dataGridViewMcNelly";
			this.dataGridViewMcNelly.RowHeadersWidth = 62;
			this.dataGridViewMcNelly.RowTemplate.Height = 28;
			this.dataGridViewMcNelly.Size = new System.Drawing.Size(555, 506);
			this.dataGridViewMcNelly.TabIndex = 0;
			// 
			// GamesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxIgdb);
			this.Controls.Add(this.yearFilter1);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.gameInfo);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "GamesControl";
			this.Size = new System.Drawing.Size(1534, 997);
			this.tabControl1.ResumeLayout(false);
			this.tabPageAll.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
			this.tabPagePlaying.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaying)).EndInit();
			this.tabPage1001.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1001)).EndInit();
			this.tabPageCanon.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanon)).EndInit();
			this.tabPageWiki.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewWiki)).EndInit();
			this.tabPageGOTY.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGOTY)).EndInit();
			this.tabPageMetacritic.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetacritic)).EndInit();
			this.tabPageZP.ResumeLayout(false);
			this.tabPageBlow.ResumeLayout(false);
			this.tabPageMcNally.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewZP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMcNelly)).EndInit();
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
		private Button buttonUpdate;
		private YearFilterControl yearFilter1;
		private TabPage tabPage1001;
		private DataGridView dataGridView1001;
		private TabPage tabPageCanon;
		private DataGridView dataGridViewCanon;
		private TabPage tabPageWiki;
		private DataGridView dataGridViewWiki;
		private TabPage tabPageGOTY;
		private DataGridView dataGridViewGOTY;
		private TextBox textBoxIgdb;
		private TabPage tabPageMetacritic;
		private DataGridView dataGridViewMetacritic;
		private TabPage tabPageZP;
		private DataGridView dataGridViewZP;
		private TabPage tabPageBlow;
		private TabPage tabPageMcNally;
		private DataGridView dataGridViewBlow;
		private DataGridView dataGridViewMcNelly;
	}
}
