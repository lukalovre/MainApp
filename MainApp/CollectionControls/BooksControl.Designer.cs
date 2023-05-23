using System.Windows.Forms;

namespace MainApp.Collection.Books
{
    partial class BooksControl
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
			this.tabPagePlanToRead = new System.Windows.Forms.TabPage();
			this.dataGridViewPlanToRead = new System.Windows.Forms.DataGridView();
			this.tabPageAll = new System.Windows.Forms.TabPage();
			this.dataGridViewAll = new System.Windows.Forms.DataGridView();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonRead = new System.Windows.Forms.Button();
			this.bookInfo1 = new MainApp.Collection.Books.BookInfoControl();
			this.textBoxUrl = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPagePlanToRead.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanToRead)).BeginInit();
			this.tabPageAll.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPagePlanToRead);
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(867, 966);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPagePlanToRead
			// 
			this.tabPagePlanToRead.Controls.Add(this.dataGridViewPlanToRead);
			this.tabPagePlanToRead.Location = new System.Drawing.Point(4, 29);
			this.tabPagePlanToRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPagePlanToRead.Name = "tabPagePlanToRead";
			this.tabPagePlanToRead.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPagePlanToRead.Size = new System.Drawing.Size(859, 933);
			this.tabPagePlanToRead.TabIndex = 0;
			this.tabPagePlanToRead.Text = "Plan to read";
			this.tabPagePlanToRead.UseVisualStyleBackColor = true;
			// 
			// dataGridViewPlanToRead
			// 
			this.dataGridViewPlanToRead.ColumnHeadersHeight = 34;
			this.dataGridViewPlanToRead.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewPlanToRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewPlanToRead.Name = "dataGridViewPlanToRead";
			this.dataGridViewPlanToRead.RowHeadersWidth = 62;
			this.dataGridViewPlanToRead.Size = new System.Drawing.Size(846, 917);
			this.dataGridViewPlanToRead.TabIndex = 0;
			this.dataGridViewPlanToRead.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageAll
			// 
			this.tabPageAll.Controls.Add(this.dataGridViewAll);
			this.tabPageAll.Location = new System.Drawing.Point(4, 29);
			this.tabPageAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Name = "tabPageAll";
			this.tabPageAll.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Size = new System.Drawing.Size(859, 933);
			this.tabPageAll.TabIndex = 1;
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
			this.dataGridViewAll.Size = new System.Drawing.Size(846, 917);
			this.dataGridViewAll.TabIndex = 0;
			this.dataGridViewAll.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(875, 413);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(82, 36);
			this.buttonAdd.TabIndex = 7;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// buttonRead
			// 
			this.buttonRead.Location = new System.Drawing.Point(1030, 413);
			this.buttonRead.Name = "buttonRead";
			this.buttonRead.Size = new System.Drawing.Size(106, 36);
			this.buttonRead.TabIndex = 8;
			this.buttonRead.Text = "Read";
			this.buttonRead.UseVisualStyleBackColor = true;
			this.buttonRead.Click += new System.EventHandler(this.ButtonRead_Click);
			// 
			// bookInfo1
			// 
			this.bookInfo1.Location = new System.Drawing.Point(864, 34);
			this.bookInfo1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.bookInfo1.Name = "bookInfo1";
			this.bookInfo1.Size = new System.Drawing.Size(369, 368);
			this.bookInfo1.TabIndex = 3;
			// 
			// textBoxUrl
			// 
			this.textBoxUrl.Location = new System.Drawing.Point(870, 528);
			this.textBoxUrl.Name = "textBoxUrl";
			this.textBoxUrl.Size = new System.Drawing.Size(224, 26);
			this.textBoxUrl.TabIndex = 9;
			this.textBoxUrl.TextChanged += new System.EventHandler(this.TextBoxUrl_TextChanged);
			// 
			// BooksControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxUrl);
			this.Controls.Add(this.buttonRead);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.bookInfo1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "BooksControl";
			this.Size = new System.Drawing.Size(1239, 966);
			this.tabControl1.ResumeLayout(false);
			this.tabPagePlanToRead.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanToRead)).EndInit();
			this.tabPageAll.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewAll;
        private BookInfoControl bookInfo1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePlanToRead;
        private System.Windows.Forms.TabPage tabPageAll;
        private DataGridView dataGridViewPlanToRead;
		private Button buttonAdd;
		private Button buttonRead;
		private TextBox textBoxUrl;
	}
}
