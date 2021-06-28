using System.Windows.Forms;

namespace MainApp.Books
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
			this.dataGridViewAll = new System.Windows.Forms.DataGridView();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageAll = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.yearFilter1 = new MainApp.YearFilterControl();
			this.bookInfo1 = new MainApp.Books.BookInfoControl();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPageAll.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewAll
			// 
			this.dataGridViewAll.ColumnHeadersHeight = 34;
			this.dataGridViewAll.Location = new System.Drawing.Point(0, 5);
			this.dataGridViewAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewAll.Name = "dataGridViewAll";
			this.dataGridViewAll.RowHeadersWidth = 62;
			this.dataGridViewAll.Size = new System.Drawing.Size(731, 970);
			this.dataGridViewAll.TabIndex = 1;
			this.dataGridViewAll.SelectionChanged += new System.EventHandler(this.DataGridViewAll_SelectionChanged);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(811, 373);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(99, 46);
			this.buttonUpdate.TabIndex = 5;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(802, 1016);
			this.tabControl1.TabIndex = 7;
			// 
			// tabPageAll
			// 
			this.tabPageAll.Controls.Add(this.dataGridViewAll);
			this.tabPageAll.Location = new System.Drawing.Point(4, 29);
			this.tabPageAll.Name = "tabPageAll";
			this.tabPageAll.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAll.Size = new System.Drawing.Size(794, 983);
			this.tabPageAll.TabIndex = 0;
			this.tabPageAll.Text = "All";
			this.tabPageAll.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(794, 983);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// yearFilter1
			// 
			this.yearFilter1.Location = new System.Drawing.Point(807, 22);
			this.yearFilter1.Name = "yearFilter1";
			this.yearFilter1.Size = new System.Drawing.Size(125, 37);
			this.yearFilter1.TabIndex = 6;
			// 
			// bookInfo1
			// 
			this.bookInfo1.Location = new System.Drawing.Point(810, 79);
			this.bookInfo1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.bookInfo1.Name = "bookInfo1";
			this.bookInfo1.Size = new System.Drawing.Size(553, 283);
			this.bookInfo1.TabIndex = 4;
			// 
			// BooksControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.yearFilter1);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.bookInfo1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "BooksControl";
			this.Size = new System.Drawing.Size(1415, 1022);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPageAll.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dataGridViewAll;
		private BookInfoControl bookInfo1;
		private Button buttonUpdate;
		private YearFilterControl yearFilter1;
		private TabControl tabControl1;
		private TabPage tabPageAll;
		private TabPage tabPage2;
	}
}
