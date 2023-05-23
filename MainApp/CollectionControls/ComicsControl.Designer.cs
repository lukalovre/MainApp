using System.Windows.Forms;

namespace MainApp.Collection
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
			this.dataGridViewAll = new System.Windows.Forms.DataGridView();
			this.comicInfo = new MainApp.Collection.ComicInfoControl();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageAll = new System.Windows.Forms.TabPage();
			this.tabPageToRead = new System.Windows.Forms.TabPage();
			this.dataGridViewToRead = new System.Windows.Forms.DataGridView();
			this.textBoxUrl = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPageAll.SuspendLayout();
			this.tabPageToRead.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewToRead)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAll
			// 
			this.dataGridViewAll.ColumnHeadersHeight = 34;
			this.dataGridViewAll.Location = new System.Drawing.Point(25, 126);
			this.dataGridViewAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewAll.Name = "dataGridViewAll";
			this.dataGridViewAll.RowHeadersWidth = 62;
			this.dataGridViewAll.Size = new System.Drawing.Size(553, 448);
			this.dataGridViewAll.TabIndex = 0;
			this.dataGridViewAll.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// comicInfo
			// 
			this.comicInfo.Location = new System.Drawing.Point(860, 8);
			this.comicInfo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.comicInfo.Name = "comicInfo";
			this.comicInfo.Size = new System.Drawing.Size(315, 352);
			this.comicInfo.TabIndex = 2;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(860, 371);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(99, 42);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Controls.Add(this.tabPageToRead);
			this.tabControl1.Location = new System.Drawing.Point(3, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(848, 1052);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPageAll
			// 
			this.tabPageAll.Controls.Add(this.dataGridViewAll);
			this.tabPageAll.Location = new System.Drawing.Point(4, 29);
			this.tabPageAll.Name = "tabPageAll";
			this.tabPageAll.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAll.Size = new System.Drawing.Size(840, 1019);
			this.tabPageAll.TabIndex = 0;
			this.tabPageAll.Text = "All";
			this.tabPageAll.UseVisualStyleBackColor = true;
			// 
			// tabPageToRead
			// 
			this.tabPageToRead.Controls.Add(this.dataGridViewToRead);
			this.tabPageToRead.Location = new System.Drawing.Point(4, 29);
			this.tabPageToRead.Name = "tabPageToRead";
			this.tabPageToRead.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageToRead.Size = new System.Drawing.Size(840, 1019);
			this.tabPageToRead.TabIndex = 1;
			this.tabPageToRead.Text = "ToRead";
			this.tabPageToRead.UseVisualStyleBackColor = true;
			// 
			// dataGridViewToRead
			// 
			this.dataGridViewToRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewToRead.Location = new System.Drawing.Point(238, 238);
			this.dataGridViewToRead.Name = "dataGridViewToRead";
			this.dataGridViewToRead.RowHeadersWidth = 62;
			this.dataGridViewToRead.RowTemplate.Height = 28;
			this.dataGridViewToRead.Size = new System.Drawing.Size(240, 150);
			this.dataGridViewToRead.TabIndex = 0;
			this.dataGridViewToRead.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// textBoxUrl
			// 
			this.textBoxUrl.Location = new System.Drawing.Point(860, 468);
			this.textBoxUrl.Name = "textBoxUrl";
			this.textBoxUrl.Size = new System.Drawing.Size(177, 26);
			this.textBoxUrl.TabIndex = 5;
			this.textBoxUrl.TextChanged += new System.EventHandler(this.TextBoxUrl_TextChanged);
			// 
			// ComicsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxUrl);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.comicInfo);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ComicsControl";
			this.Size = new System.Drawing.Size(1682, 1102);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPageAll.ResumeLayout(false);
			this.tabPageToRead.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewToRead)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dataGridViewAll;
		private ComicInfoControl comicInfo;
		private Button buttonAdd;
        private TabControl tabControl1;
        private TabPage tabPageAll;
        private TabPage tabPageToRead;
        private DataGridView dataGridViewToRead;
        private TextBox textBoxUrl;
    }
}
