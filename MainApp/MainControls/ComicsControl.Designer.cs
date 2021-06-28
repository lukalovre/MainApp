using System.Windows.Forms;

namespace MainApp.Comics
{
	partial class ComicsControl
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
			this.dataGridViewAll = new System.Windows.Forms.DataGridView();
			this.tabPageReading = new System.Windows.Forms.TabPage();
			this.dataGridViewReading = new System.Windows.Forms.DataGridView();
			this.tabPageOngoing = new System.Windows.Forms.TabPage();
			this.dataGridViewOngoing = new System.Windows.Forms.DataGridView();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.comicInfo1 = new MainApp.Comics.ComicInfoControl();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPageAll.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.tabPageReading.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReading)).BeginInit();
			this.tabPageOngoing.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOngoing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Controls.Add(this.tabPageReading);
			this.tabControl1.Controls.Add(this.tabPageOngoing);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(856, 1369);
			this.tabControl1.TabIndex = 19;
			// 
			// tabPageAll
			// 
			this.tabPageAll.Controls.Add(this.dataGridViewAll);
			this.tabPageAll.Location = new System.Drawing.Point(4, 29);
			this.tabPageAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Name = "tabPageAll";
			this.tabPageAll.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Size = new System.Drawing.Size(848, 1336);
			this.tabPageAll.TabIndex = 0;
			this.tabPageAll.Text = "All";
			this.tabPageAll.UseVisualStyleBackColor = true;
			// 
			// dataGridViewAll
			// 
			this.dataGridViewAll.ColumnHeadersHeight = 34;
			this.dataGridViewAll.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewAll.Name = "dataGridViewAll";
			this.dataGridViewAll.RowHeadersWidth = 62;
			this.dataGridViewAll.Size = new System.Drawing.Size(833, 927);
			this.dataGridViewAll.TabIndex = 0;
			this.dataGridViewAll.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageReading
			// 
			this.tabPageReading.Controls.Add(this.dataGridViewReading);
			this.tabPageReading.Location = new System.Drawing.Point(4, 29);
			this.tabPageReading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageReading.Name = "tabPageReading";
			this.tabPageReading.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageReading.Size = new System.Drawing.Size(848, 1336);
			this.tabPageReading.TabIndex = 1;
			this.tabPageReading.Text = "Reading";
			this.tabPageReading.UseVisualStyleBackColor = true;
			// 
			// dataGridViewReading
			// 
			this.dataGridViewReading.ColumnHeadersHeight = 34;
			this.dataGridViewReading.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewReading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewReading.Name = "dataGridViewReading";
			this.dataGridViewReading.RowHeadersWidth = 62;
			this.dataGridViewReading.Size = new System.Drawing.Size(978, 1326);
			this.dataGridViewReading.TabIndex = 0;
			this.dataGridViewReading.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageOngoing
			// 
			this.tabPageOngoing.Controls.Add(this.dataGridViewOngoing);
			this.tabPageOngoing.Location = new System.Drawing.Point(4, 29);
			this.tabPageOngoing.Name = "tabPageOngoing";
			this.tabPageOngoing.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOngoing.Size = new System.Drawing.Size(848, 1336);
			this.tabPageOngoing.TabIndex = 2;
			this.tabPageOngoing.Text = "Ongoing";
			this.tabPageOngoing.UseVisualStyleBackColor = true;
			// 
			// dataGridViewOngoing
			// 
			this.dataGridViewOngoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOngoing.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewOngoing.Name = "dataGridViewOngoing";
			this.dataGridViewOngoing.RowHeadersWidth = 62;
			this.dataGridViewOngoing.RowTemplate.Height = 28;
			this.dataGridViewOngoing.Size = new System.Drawing.Size(980, 1330);
			this.dataGridViewOngoing.TabIndex = 0;
			this.dataGridViewOngoing.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// numericUpDownYear
			// 
			this.numericUpDownYear.Location = new System.Drawing.Point(863, 29);
			this.numericUpDownYear.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
			this.numericUpDownYear.Name = "numericUpDownYear";
			this.numericUpDownYear.Size = new System.Drawing.Size(73, 26);
			this.numericUpDownYear.TabIndex = 20;
			this.numericUpDownYear.ValueChanged += new System.EventHandler(this.NumericUpDownYear_ValueChanged);
			// 
			// comicInfo1
			// 
			this.comicInfo1.Location = new System.Drawing.Point(862, 64);
			this.comicInfo1.Margin = new System.Windows.Forms.Padding(6);
			this.comicInfo1.Name = "comicInfo1";
			this.comicInfo1.Size = new System.Drawing.Size(266, 444);
			this.comicInfo1.TabIndex = 16;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(863, 517);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(93, 32);
			this.buttonUpdate.TabIndex = 21;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
			// 
			// ComicsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.comicInfo1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ComicsControl";
			this.Size = new System.Drawing.Size(1346, 1369);
			this.tabControl1.ResumeLayout(false);
			this.tabPageAll.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.tabPageReading.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReading)).EndInit();
			this.tabPageOngoing.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOngoing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		internal DataGridView dataGridViewAll;
		private ComicInfoControl comicInfo1;
		public System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageAll;
		private System.Windows.Forms.TabPage tabPageReading;
		private DataGridView dataGridViewReading;
		private NumericUpDown numericUpDownYear;
		private TabPage tabPageOngoing;
		private DataGridView dataGridViewOngoing;
		private Button buttonUpdate;
	}
}
