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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridViewPlanToRead = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridViewAll = new System.Windows.Forms.DataGridView();
			this.labelHLTBtime = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonRead = new System.Windows.Forms.Button();
			this.bookInfo1 = new MainApp.Collection.Books.BookInfoControl();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanToRead)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(930, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Title";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(892, 25);
			this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(148, 26);
			this.textBoxTitle.TabIndex = 2;
			this.textBoxTitle.TextChanged += new System.EventHandler(this.TextBoxTitleTextChanged);
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
			this.tabControl1.Size = new System.Drawing.Size(867, 966);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridViewPlanToRead);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Size = new System.Drawing.Size(859, 933);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Plan to read";
			this.tabPage1.UseVisualStyleBackColor = true;
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
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridViewAll);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Size = new System.Drawing.Size(859, 933);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "All";
			this.tabPage2.UseVisualStyleBackColor = true;
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
			// labelHLTBtime
			// 
			this.labelHLTBtime.AutoSize = true;
			this.labelHLTBtime.Location = new System.Drawing.Point(870, 522);
			this.labelHLTBtime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelHLTBtime.Name = "labelHLTBtime";
			this.labelHLTBtime.Size = new System.Drawing.Size(50, 20);
			this.labelHLTBtime.TabIndex = 6;
			this.labelHLTBtime.Text = "HLTB";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(875, 423);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(82, 36);
			this.buttonAdd.TabIndex = 7;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// buttonRead
			// 
			this.buttonRead.Location = new System.Drawing.Point(1038, 423);
			this.buttonRead.Name = "buttonRead";
			this.buttonRead.Size = new System.Drawing.Size(106, 36);
			this.buttonRead.TabIndex = 8;
			this.buttonRead.Text = "Read";
			this.buttonRead.UseVisualStyleBackColor = true;
			this.buttonRead.Click += new System.EventHandler(this.ButtonRead_Click);
			// 
			// bookInfo1
			// 
			this.bookInfo1.Location = new System.Drawing.Point(866, 65);
			this.bookInfo1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.bookInfo1.Name = "bookInfo1";
			this.bookInfo1.Size = new System.Drawing.Size(369, 368);
			this.bookInfo1.TabIndex = 3;
			// 
			// BooksControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonRead);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.labelHLTBtime);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.bookInfo1);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "BooksControl";
			this.Size = new System.Drawing.Size(1239, 966);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanToRead)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private BookInfoControl bookInfo1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DataGridView dataGridViewPlanToRead;
		private System.Windows.Forms.Label labelHLTBtime;
		private Button buttonAdd;
		private Button buttonRead;
	}
}
