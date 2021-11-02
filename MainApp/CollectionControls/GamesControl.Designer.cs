using System;
using System.Windows.Forms;

namespace MainApp.Collection.Games
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
			this.labelHLTBtime = new System.Windows.Forms.Label();
			this.dataGridViewAll = new System.Windows.Forms.DataGridView();
			this.dataGridViewToPlay = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1001ToPlay = new System.Windows.Forms.TabPage();
			this.dataGridView1001ToPlay = new System.Windows.Forms.DataGridView();
			this.tabPagePlanToPlay = new System.Windows.Forms.TabPage();
			this.tabPageAll = new System.Windows.Forms.TabPage();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.gameInfo = new MainApp.Collection.Games.GameInfoControl();
			this.textBoxIgdbUrl = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewToPlay)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1001ToPlay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1001ToPlay)).BeginInit();
			this.tabPagePlanToPlay.SuspendLayout();
			this.tabPageAll.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelHLTBtime
			// 
			this.labelHLTBtime.AutoSize = true;
			this.labelHLTBtime.Location = new System.Drawing.Point(891, 18);
			this.labelHLTBtime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelHLTBtime.Name = "labelHLTBtime";
			this.labelHLTBtime.Size = new System.Drawing.Size(88, 20);
			this.labelHLTBtime.TabIndex = 34;
			this.labelHLTBtime.Text = "HLTB Time";
			// 
			// dataGridViewAll
			// 
			this.dataGridViewAll.ColumnHeadersHeight = 34;
			this.dataGridViewAll.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewAll.Name = "dataGridViewAll";
			this.dataGridViewAll.RowHeadersWidth = 62;
			this.dataGridViewAll.Size = new System.Drawing.Size(866, 1146);
			this.dataGridViewAll.TabIndex = 5;
			this.dataGridViewAll.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// dataGridViewToPlay
			// 
			this.dataGridViewToPlay.ColumnHeadersHeight = 34;
			this.dataGridViewToPlay.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewToPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewToPlay.Name = "dataGridViewToPlay";
			this.dataGridViewToPlay.RowHeadersWidth = 62;
			this.dataGridViewToPlay.Size = new System.Drawing.Size(866, 1146);
			this.dataGridViewToPlay.TabIndex = 8;
			this.dataGridViewToPlay.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1001ToPlay);
			this.tabControl1.Controls.Add(this.tabPagePlanToPlay);
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(882, 1189);
			this.tabControl1.TabIndex = 37;
			// 
			// tabPage1001ToPlay
			// 
			this.tabPage1001ToPlay.Controls.Add(this.dataGridView1001ToPlay);
			this.tabPage1001ToPlay.Location = new System.Drawing.Point(4, 29);
			this.tabPage1001ToPlay.Name = "tabPage1001ToPlay";
			this.tabPage1001ToPlay.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1001ToPlay.Size = new System.Drawing.Size(874, 1156);
			this.tabPage1001ToPlay.TabIndex = 2;
			this.tabPage1001ToPlay.Text = "1001 to play";
			this.tabPage1001ToPlay.UseVisualStyleBackColor = true;
			// 
			// dataGridView1001ToPlay
			// 
			this.dataGridView1001ToPlay.ColumnHeadersHeight = 34;
			this.dataGridView1001ToPlay.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1001ToPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1001ToPlay.Name = "dataGridView1001ToPlay";
			this.dataGridView1001ToPlay.RowHeadersWidth = 62;
			this.dataGridView1001ToPlay.Size = new System.Drawing.Size(868, 1150);
			this.dataGridView1001ToPlay.TabIndex = 9;
			this.dataGridView1001ToPlay.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPagePlanToPlay
			// 
			this.tabPagePlanToPlay.Controls.Add(this.dataGridViewToPlay);
			this.tabPagePlanToPlay.Location = new System.Drawing.Point(4, 29);
			this.tabPagePlanToPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPagePlanToPlay.Name = "tabPagePlanToPlay";
			this.tabPagePlanToPlay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPagePlanToPlay.Size = new System.Drawing.Size(874, 1156);
			this.tabPagePlanToPlay.TabIndex = 0;
			this.tabPagePlanToPlay.Text = "Other to play";
			this.tabPagePlanToPlay.UseVisualStyleBackColor = true;
			// 
			// tabPageAll
			// 
			this.tabPageAll.Controls.Add(this.dataGridViewAll);
			this.tabPageAll.Location = new System.Drawing.Point(4, 29);
			this.tabPageAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Name = "tabPageAll";
			this.tabPageAll.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Size = new System.Drawing.Size(874, 1156);
			this.tabPageAll.TabIndex = 1;
			this.tabPageAll.Text = "All";
			this.tabPageAll.UseVisualStyleBackColor = true;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(895, 677);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(98, 32);
			this.buttonAdd.TabIndex = 38;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// gameInfo
			// 
			this.gameInfo.Location = new System.Drawing.Point(885, 104);
			this.gameInfo.Margin = new System.Windows.Forms.Padding(6);
			this.gameInfo.Name = "gameInfo";
			this.gameInfo.Size = new System.Drawing.Size(439, 549);
			this.gameInfo.TabIndex = 36;
			// 
			// textBoxIgdbUrl
			// 
			this.textBoxIgdbUrl.Location = new System.Drawing.Point(895, 803);
			this.textBoxIgdbUrl.Name = "textBoxIgdbUrl";
			this.textBoxIgdbUrl.Size = new System.Drawing.Size(274, 26);
			this.textBoxIgdbUrl.TabIndex = 39;
			this.textBoxIgdbUrl.TextChanged += new System.EventHandler(this.TextBoxIgdbUrl_TextChanged);
			// 
			// GamesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxIgdbUrl);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.gameInfo);
			this.Controls.Add(this.labelHLTBtime);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "GamesControl";
			this.Size = new System.Drawing.Size(1408, 1189);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewToPlay)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1001ToPlay.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1001ToPlay)).EndInit();
			this.tabPagePlanToPlay.ResumeLayout(false);
			this.tabPageAll.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }


        #endregion

        internal DataGridView dataGridViewAll;
        private DataGridView dataGridViewToPlay;
        private System.Windows.Forms.Label labelHLTBtime;
        private GameInfoControl gameInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePlanToPlay;
		private System.Windows.Forms.TabPage tabPage1001ToPlay;
		private DataGridView dataGridView1001ToPlay;
		private System.Windows.Forms.TabPage tabPageAll;
		private Button buttonAdd;
		private TextBox textBoxIgdbUrl;
	}
}
