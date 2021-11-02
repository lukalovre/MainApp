using System.Windows.Forms;

namespace MainApp.My_work_progress
{
	partial class MyWorkProgressControl
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
			this.dataGridViewOngoing = new System.Windows.Forms.DataGridView();
			this.numericUpDownAddTime = new System.Windows.Forms.NumericUpDown();
			this.buttonAddMinutes = new System.Windows.Forms.Button();
			this.myWorkProgressInfo = new MainApp.My_work_progress.MyWorkProgressInfoControl();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageOngoing = new System.Windows.Forms.TabPage();
			this.tabPageAll = new System.Windows.Forms.TabPage();
			this.dataGridViewAll = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOngoing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddTime)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPageOngoing.SuspendLayout();
			this.tabPageAll.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewOngoing
			// 
			this.dataGridViewOngoing.ColumnHeadersHeight = 34;
			this.dataGridViewOngoing.Location = new System.Drawing.Point(6, 7);
			this.dataGridViewOngoing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridViewOngoing.Name = "dataGridViewOngoing";
			this.dataGridViewOngoing.RowHeadersWidth = 62;
			this.dataGridViewOngoing.Size = new System.Drawing.Size(758, 1073);
			this.dataGridViewOngoing.TabIndex = 0;
			this.dataGridViewOngoing.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// numericUpDownAddTime
			// 
			this.numericUpDownAddTime.Location = new System.Drawing.Point(788, 212);
			this.numericUpDownAddTime.Name = "numericUpDownAddTime";
			this.numericUpDownAddTime.Size = new System.Drawing.Size(87, 26);
			this.numericUpDownAddTime.TabIndex = 2;
			// 
			// buttonAddMinutes
			// 
			this.buttonAddMinutes.Location = new System.Drawing.Point(881, 204);
			this.buttonAddMinutes.Name = "buttonAddMinutes";
			this.buttonAddMinutes.Size = new System.Drawing.Size(117, 40);
			this.buttonAddMinutes.TabIndex = 4;
			this.buttonAddMinutes.Text = "Add minutes";
			this.buttonAddMinutes.UseVisualStyleBackColor = true;
			this.buttonAddMinutes.Click += new System.EventHandler(this.ButtonAddMinutes_Click);
			// 
			// myWorkProgressInfo
			// 
			this.myWorkProgressInfo.Location = new System.Drawing.Point(788, 5);
			this.myWorkProgressInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.myWorkProgressInfo.Name = "myWorkProgressInfo";
			this.myWorkProgressInfo.Size = new System.Drawing.Size(218, 172);
			this.myWorkProgressInfo.TabIndex = 1;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageOngoing);
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Location = new System.Drawing.Point(3, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(778, 1117);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPageOngoing
			// 
			this.tabPageOngoing.Controls.Add(this.dataGridViewOngoing);
			this.tabPageOngoing.Location = new System.Drawing.Point(4, 29);
			this.tabPageOngoing.Name = "tabPageOngoing";
			this.tabPageOngoing.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOngoing.Size = new System.Drawing.Size(770, 1084);
			this.tabPageOngoing.TabIndex = 0;
			this.tabPageOngoing.Text = "Ongoing";
			this.tabPageOngoing.UseVisualStyleBackColor = true;
			// 
			// tabPageAll
			// 
			this.tabPageAll.Controls.Add(this.dataGridViewAll);
			this.tabPageAll.Location = new System.Drawing.Point(4, 29);
			this.tabPageAll.Name = "tabPageAll";
			this.tabPageAll.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAll.Size = new System.Drawing.Size(770, 1084);
			this.tabPageAll.TabIndex = 1;
			this.tabPageAll.Text = "All";
			this.tabPageAll.UseVisualStyleBackColor = true;
			// 
			// dataGridViewAll
			// 
			this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAll.Location = new System.Drawing.Point(3, 6);
			this.dataGridViewAll.Name = "dataGridViewAll";
			this.dataGridViewAll.RowHeadersWidth = 62;
			this.dataGridViewAll.RowTemplate.Height = 28;
			this.dataGridViewAll.Size = new System.Drawing.Size(761, 1072);
			this.dataGridViewAll.TabIndex = 0;
			this.dataGridViewAll.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// MyWorkProgressControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.buttonAddMinutes);
			this.Controls.Add(this.numericUpDownAddTime);
			this.Controls.Add(this.myWorkProgressInfo);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MyWorkProgressControl";
			this.Size = new System.Drawing.Size(1150, 1125);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOngoing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddTime)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPageOngoing.ResumeLayout(false);
			this.tabPageAll.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dataGridViewOngoing;
		private MyWorkProgressInfoControl myWorkProgressInfo;
		private NumericUpDown numericUpDownAddTime;
		private Button buttonAddMinutes;
		private TabControl tabControl1;
		private TabPage tabPageOngoing;
		private TabPage tabPageAll;
		private DataGridView dataGridViewAll;
	}
}
