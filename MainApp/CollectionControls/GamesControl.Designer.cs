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
			this.dataGridViewUnplayed = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageUnplayed = new System.Windows.Forms.TabPage();
			this.tabPageAll = new System.Windows.Forms.TabPage();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxIgdbUrl = new System.Windows.Forms.TextBox();
			this.gameInfo = new MainApp.Collection.Games.GameInfoControl();
			this.buttonOpenLink = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnplayed)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPageUnplayed.SuspendLayout();
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
			// dataGridViewUnplayed
			// 
			this.dataGridViewUnplayed.ColumnHeadersHeight = 34;
			this.dataGridViewUnplayed.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewUnplayed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewUnplayed.Name = "dataGridViewUnplayed";
			this.dataGridViewUnplayed.RowHeadersWidth = 62;
			this.dataGridViewUnplayed.Size = new System.Drawing.Size(866, 1146);
			this.dataGridViewUnplayed.TabIndex = 8;
			this.dataGridViewUnplayed.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageUnplayed);
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(882, 1189);
			this.tabControl1.TabIndex = 37;
			// 
			// tabPageUnplayed
			// 
			this.tabPageUnplayed.Controls.Add(this.dataGridViewUnplayed);
			this.tabPageUnplayed.Location = new System.Drawing.Point(4, 29);
			this.tabPageUnplayed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageUnplayed.Name = "tabPageUnplayed";
			this.tabPageUnplayed.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageUnplayed.Size = new System.Drawing.Size(874, 1156);
			this.tabPageUnplayed.TabIndex = 0;
			this.tabPageUnplayed.Text = "Unplayed";
			this.tabPageUnplayed.UseVisualStyleBackColor = true;
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
			// textBoxIgdbUrl
			// 
			this.textBoxIgdbUrl.Location = new System.Drawing.Point(895, 803);
			this.textBoxIgdbUrl.Name = "textBoxIgdbUrl";
			this.textBoxIgdbUrl.Size = new System.Drawing.Size(274, 26);
			this.textBoxIgdbUrl.TabIndex = 39;
			this.textBoxIgdbUrl.TextChanged += new System.EventHandler(this.TextBoxIgdbUrl_TextChanged);
			// 
			// gameInfo
			// 
			this.gameInfo.Location = new System.Drawing.Point(885, 104);
			this.gameInfo.Margin = new System.Windows.Forms.Padding(6);
			this.gameInfo.Name = "gameInfo";
			this.gameInfo.Size = new System.Drawing.Size(439, 549);
			this.gameInfo.TabIndex = 36;
			// 
			// buttonOpenLink
			// 
			this.buttonOpenLink.Location = new System.Drawing.Point(1071, 677);
			this.buttonOpenLink.Name = "buttonOpenLink";
			this.buttonOpenLink.Size = new System.Drawing.Size(98, 32);
			this.buttonOpenLink.TabIndex = 40;
			this.buttonOpenLink.Text = "Open Link";
			this.buttonOpenLink.UseVisualStyleBackColor = true;
			this.buttonOpenLink.Click += new System.EventHandler(this.ButtonOpenLink_Click);
			// 
			// GamesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonOpenLink);
			this.Controls.Add(this.textBoxIgdbUrl);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.gameInfo);
			this.Controls.Add(this.labelHLTBtime);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "GamesControl";
			this.Size = new System.Drawing.Size(1408, 1189);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnplayed)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPageUnplayed.ResumeLayout(false);
			this.tabPageAll.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }


        #endregion

        internal DataGridView dataGridViewAll;
        private DataGridView dataGridViewUnplayed;
        private System.Windows.Forms.Label labelHLTBtime;
        private GameInfoControl gameInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUnplayed;
		private System.Windows.Forms.TabPage tabPageAll;
		private Button buttonAdd;
		private TextBox textBoxIgdbUrl;
        private Button buttonOpenLink;
    }
}
