using System;

namespace MainApp.Collection.Games
{
    partial class Games
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
			this.completedGame1 = new MainApp.Collection.Games.AddGame();
			this.dgAll = new MainApp.DataGridCustom();
			this.dataGridCustomToPlay = new MainApp.DataGridCustom();
			this.addGame1 = new MainApp.Collection.Games.AddGameCollection();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1001ToPlay = new System.Windows.Forms.TabPage();
			this.dataGridCustom1001ToPlay = new MainApp.DataGridCustom();
			this.tabPagePlanToPlay = new System.Windows.Forms.TabPage();
			this.tabPageAll = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.dgAll)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustomToPlay)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1001ToPlay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustom1001ToPlay)).BeginInit();
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
			// completedGame1
			// 
			this.completedGame1.Location = new System.Drawing.Point(883, 716);
			this.completedGame1.Margin = new System.Windows.Forms.Padding(6);
			this.completedGame1.Name = "completedGame1";
			this.completedGame1.Size = new System.Drawing.Size(327, 242);
			this.completedGame1.TabIndex = 7;
			this.completedGame1.Visible = false;
			// 
			// dgAll
			// 
			this.dgAll.AllowUserToAddRows = false;
			this.dgAll.AllowUserToDeleteRows = false;
			this.dgAll.AllowUserToResizeRows = false;
			this.dgAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAll.CurrentRowIndex = 0;
			this.dgAll.DataSourceCustom = null;
			this.dgAll.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgAll.Location = new System.Drawing.Point(4, 5);
			this.dgAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgAll.Name = "dgAll";
			this.dgAll.ReadOnly = true;
			this.dgAll.RowHeadersWidth = 51;
			this.dgAll.Size = new System.Drawing.Size(866, 1146);
			this.dgAll.TabIndex = 5;
			// 
			// dataGridCustomToPlay
			// 
			this.dataGridCustomToPlay.AllowUserToAddRows = false;
			this.dataGridCustomToPlay.AllowUserToDeleteRows = false;
			this.dataGridCustomToPlay.AllowUserToResizeRows = false;
			this.dataGridCustomToPlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCustomToPlay.CurrentRowIndex = 0;
			this.dataGridCustomToPlay.DataSourceCustom = null;
			this.dataGridCustomToPlay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridCustomToPlay.Location = new System.Drawing.Point(4, 5);
			this.dataGridCustomToPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridCustomToPlay.Name = "dataGridCustomToPlay";
			this.dataGridCustomToPlay.ReadOnly = true;
			this.dataGridCustomToPlay.RowHeadersWidth = 51;
			this.dataGridCustomToPlay.Size = new System.Drawing.Size(866, 1146);
			this.dataGridCustomToPlay.TabIndex = 8;
			this.dataGridCustomToPlay.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCustomToPlayCellContentDoubleClick);
			this.dataGridCustomToPlay.SelectionChanged += new System.EventHandler(this.DataGridCustomToPlaySelectionChanged);
			// 
			// addGame1
			// 
			this.addGame1.Location = new System.Drawing.Point(885, 104);
			this.addGame1.Margin = new System.Windows.Forms.Padding(6);
			this.addGame1.Name = "addGame1";
			this.addGame1.Size = new System.Drawing.Size(386, 600);
			this.addGame1.TabIndex = 36;
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
			this.tabPage1001ToPlay.Controls.Add(this.dataGridCustom1001ToPlay);
			this.tabPage1001ToPlay.Location = new System.Drawing.Point(4, 29);
			this.tabPage1001ToPlay.Name = "tabPage1001ToPlay";
			this.tabPage1001ToPlay.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1001ToPlay.Size = new System.Drawing.Size(874, 1156);
			this.tabPage1001ToPlay.TabIndex = 2;
			this.tabPage1001ToPlay.Text = "1001 to play";
			this.tabPage1001ToPlay.UseVisualStyleBackColor = true;
			// 
			// dataGridCustom1001ToPlay
			// 
			this.dataGridCustom1001ToPlay.AllowUserToAddRows = false;
			this.dataGridCustom1001ToPlay.AllowUserToDeleteRows = false;
			this.dataGridCustom1001ToPlay.AllowUserToResizeRows = false;
			this.dataGridCustom1001ToPlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCustom1001ToPlay.CurrentRowIndex = 0;
			this.dataGridCustom1001ToPlay.DataSourceCustom = null;
			this.dataGridCustom1001ToPlay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridCustom1001ToPlay.Location = new System.Drawing.Point(3, 3);
			this.dataGridCustom1001ToPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridCustom1001ToPlay.Name = "dataGridCustom1001ToPlay";
			this.dataGridCustom1001ToPlay.ReadOnly = true;
			this.dataGridCustom1001ToPlay.RowHeadersWidth = 51;
			this.dataGridCustom1001ToPlay.Size = new System.Drawing.Size(868, 1150);
			this.dataGridCustom1001ToPlay.TabIndex = 9;
			this.dataGridCustom1001ToPlay.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCustomToPlayCellContentDoubleClick);
			// 
			// tabPagePlanToPlay
			// 
			this.tabPagePlanToPlay.Controls.Add(this.dataGridCustomToPlay);
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
			this.tabPageAll.Controls.Add(this.dgAll);
			this.tabPageAll.Location = new System.Drawing.Point(4, 29);
			this.tabPageAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Name = "tabPageAll";
			this.tabPageAll.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Size = new System.Drawing.Size(874, 1156);
			this.tabPageAll.TabIndex = 1;
			this.tabPageAll.Text = "All";
			this.tabPageAll.UseVisualStyleBackColor = true;
			// 
			// Games
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.addGame1);
			this.Controls.Add(this.labelHLTBtime);
			this.Controls.Add(this.completedGame1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Games";
			this.Size = new System.Drawing.Size(1408, 1189);
			((System.ComponentModel.ISupportInitialize)(this.dgAll)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustomToPlay)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1001ToPlay.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustom1001ToPlay)).EndInit();
			this.tabPagePlanToPlay.ResumeLayout(false);
			this.tabPageAll.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }


        #endregion

        internal DataGridCustom dgAll;
        private AddGame completedGame1;
        private DataGridCustom dataGridCustomToPlay;
        private System.Windows.Forms.Label labelHLTBtime;
        private AddGameCollection addGame1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePlanToPlay;
		private System.Windows.Forms.TabPage tabPage1001ToPlay;
		private DataGridCustom dataGridCustom1001ToPlay;
		private System.Windows.Forms.TabPage tabPageAll;
	}
}
