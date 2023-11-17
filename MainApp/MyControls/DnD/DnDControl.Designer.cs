namespace MainApp.MainControls
{
    partial class DnDControl
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
			this.dataGridViewSeshions = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageSessions = new System.Windows.Forms.TabPage();
			this.tabPageCampaigns = new System.Windows.Forms.TabPage();
			this.dataGridViewCampaigns = new System.Windows.Forms.DataGridView();
			this.labelCampaignTitle = new System.Windows.Forms.Label();
			this.dnDInfoControl1 = new MainApp.MainControls.DnDInfoControl();
			this.addButton1 = new MainApp.CommonControls.AddButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeshions)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPageSessions.SuspendLayout();
			this.tabPageCampaigns.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCampaigns)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewSeshions
			// 
			this.dataGridViewSeshions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSeshions.Location = new System.Drawing.Point(100, 120);
			this.dataGridViewSeshions.Name = "dataGridViewSeshions";
			this.dataGridViewSeshions.RowHeadersWidth = 62;
			this.dataGridViewSeshions.RowTemplate.Height = 28;
			this.dataGridViewSeshions.Size = new System.Drawing.Size(357, 343);
			this.dataGridViewSeshions.TabIndex = 2;
			this.dataGridViewSeshions.SelectionChanged += new System.EventHandler(this.DataGridViewSeshions_SelectionChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageSessions);
			this.tabControl1.Controls.Add(this.tabPageCampaigns);
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(744, 915);
			this.tabControl1.TabIndex = 3;
			// 
			// tabPageSessions
			// 
			this.tabPageSessions.Controls.Add(this.dataGridViewSeshions);
			this.tabPageSessions.Location = new System.Drawing.Point(4, 29);
			this.tabPageSessions.Name = "tabPageSessions";
			this.tabPageSessions.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSessions.Size = new System.Drawing.Size(736, 882);
			this.tabPageSessions.TabIndex = 0;
			this.tabPageSessions.Text = "Sessions";
			this.tabPageSessions.UseVisualStyleBackColor = true;
			// 
			// tabPageCampaigns
			// 
			this.tabPageCampaigns.Controls.Add(this.dataGridViewCampaigns);
			this.tabPageCampaigns.Location = new System.Drawing.Point(4, 29);
			this.tabPageCampaigns.Name = "tabPageCampaigns";
			this.tabPageCampaigns.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCampaigns.Size = new System.Drawing.Size(736, 882);
			this.tabPageCampaigns.TabIndex = 1;
			this.tabPageCampaigns.Text = "Campaigns";
			this.tabPageCampaigns.UseVisualStyleBackColor = true;
			// 
			// dataGridViewCampaigns
			// 
			this.dataGridViewCampaigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCampaigns.Location = new System.Drawing.Point(63, 80);
			this.dataGridViewCampaigns.Name = "dataGridViewCampaigns";
			this.dataGridViewCampaigns.RowHeadersWidth = 62;
			this.dataGridViewCampaigns.RowTemplate.Height = 28;
			this.dataGridViewCampaigns.Size = new System.Drawing.Size(240, 150);
			this.dataGridViewCampaigns.TabIndex = 0;
			this.dataGridViewCampaigns.SelectionChanged += new System.EventHandler(this.DataGridViewCampaigns_SelectionChanged);
			// 
			// labelCampaignTitle
			// 
			this.labelCampaignTitle.AutoSize = true;
			this.labelCampaignTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCampaignTitle.Location = new System.Drawing.Point(753, 15);
			this.labelCampaignTitle.Name = "labelCampaignTitle";
			this.labelCampaignTitle.Size = new System.Drawing.Size(355, 40);
			this.labelCampaignTitle.TabIndex = 4;
			this.labelCampaignTitle.Text = "Drunk and Disorderly";
			// 
			// dnDInfoControl1
			// 
			this.dnDInfoControl1.Location = new System.Drawing.Point(760, 84);
			this.dnDInfoControl1.Name = "dnDInfoControl1";
			this.dnDInfoControl1.Size = new System.Drawing.Size(521, 703);
			this.dnDInfoControl1.TabIndex = 0;
			// 
			// addButton1
			// 
			this.addButton1.Location = new System.Drawing.Point(749, 836);
			this.addButton1.Name = "addButton1";
			this.addButton1.Size = new System.Drawing.Size(315, 43);
			this.addButton1.TabIndex = 5;
			// 
			// DnDControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.addButton1);
			this.Controls.Add(this.labelCampaignTitle);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.dnDInfoControl1);
			this.Name = "DnDControl";
			this.Size = new System.Drawing.Size(1343, 921);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeshions)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPageSessions.ResumeLayout(false);
			this.tabPageCampaigns.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCampaigns)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DnDInfoControl dnDInfoControl1;
        private System.Windows.Forms.DataGridView dataGridViewSeshions;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSessions;
        private System.Windows.Forms.TabPage tabPageCampaigns;
        private System.Windows.Forms.DataGridView dataGridViewCampaigns;
        private System.Windows.Forms.Label labelCampaignTitle;
		private CommonControls.AddButton addButton1;
	}
}
