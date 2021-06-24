using System.Windows.Forms;

namespace MainApp.Musics
{
	partial class MusicControl
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
			this.tabPageToDo = new System.Windows.Forms.TabPage();
			this.dataGridViewTodo = new System.Windows.Forms.DataGridView();
			this.tabPageYearList = new System.Windows.Forms.TabPage();
			this.dataGridViewYearList = new System.Windows.Forms.DataGridView();
			this.tabPageIn = new System.Windows.Forms.TabPage();
			this.dataGridViewIn = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxAutofill = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.yearFilter1 = new MainApp.YearFilter();
			this.musicInfo1 = new MainApp.Musics.MusicInfo();
			this.buttonListenAgain = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPageAll.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.tabPageToDo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodo)).BeginInit();
			this.tabPageYearList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewYearList)).BeginInit();
			this.tabPageIn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Controls.Add(this.tabPageToDo);
			this.tabControl1.Controls.Add(this.tabPageYearList);
			this.tabControl1.Controls.Add(this.tabPageIn);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(810, 1165);
			this.tabControl1.TabIndex = 29;
			// 
			// tabPageAll
			// 
			this.tabPageAll.Controls.Add(this.dataGridViewAll);
			this.tabPageAll.Location = new System.Drawing.Point(4, 29);
			this.tabPageAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Name = "tabPageAll";
			this.tabPageAll.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Size = new System.Drawing.Size(802, 1132);
			this.tabPageAll.TabIndex = 0;
			this.tabPageAll.Text = "All";
			this.tabPageAll.UseVisualStyleBackColor = true;
			// 
			// dataGridCustomMusic
			// 
			this.dataGridViewAll.ColumnHeadersHeight = 34;
			this.dataGridViewAll.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewAll.Name = "dataGridCustomMusic";
			this.dataGridViewAll.RowHeadersWidth = 62;
			this.dataGridViewAll.Size = new System.Drawing.Size(714, 926);
			this.dataGridViewAll.TabIndex = 22;
			this.dataGridViewAll.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageToDo
			// 
			this.tabPageToDo.Controls.Add(this.dataGridViewTodo);
			this.tabPageToDo.Location = new System.Drawing.Point(4, 29);
			this.tabPageToDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageToDo.Name = "tabPageToDo";
			this.tabPageToDo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageToDo.Size = new System.Drawing.Size(802, 1132);
			this.tabPageToDo.TabIndex = 1;
			this.tabPageToDo.Text = "To do";
			this.tabPageToDo.UseVisualStyleBackColor = true;
			// 
			// dataGridCustomTodo
			// 
			this.dataGridViewTodo.ColumnHeadersHeight = 34;
			this.dataGridViewTodo.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewTodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewTodo.Name = "dataGridCustomTodo";
			this.dataGridViewTodo.RowHeadersWidth = 62;
			this.dataGridViewTodo.Size = new System.Drawing.Size(1014, 803);
			this.dataGridViewTodo.TabIndex = 0;
			this.dataGridViewTodo.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageYearList
			// 
			this.tabPageYearList.Controls.Add(this.dataGridViewYearList);
			this.tabPageYearList.Location = new System.Drawing.Point(4, 29);
			this.tabPageYearList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageYearList.Name = "tabPageYearList";
			this.tabPageYearList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageYearList.Size = new System.Drawing.Size(802, 1132);
			this.tabPageYearList.TabIndex = 2;
			this.tabPageYearList.Text = "Year list";
			this.tabPageYearList.UseVisualStyleBackColor = true;
			// 
			// dataGridCustomYearList
			// 
			this.dataGridViewYearList.ColumnHeadersHeight = 34;
			this.dataGridViewYearList.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewYearList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewYearList.Name = "dataGridCustomYearList";
			this.dataGridViewYearList.RowHeadersWidth = 62;
			this.dataGridViewYearList.Size = new System.Drawing.Size(1014, 803);
			this.dataGridViewYearList.TabIndex = 0;
			this.dataGridViewYearList.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageIn
			// 
			this.tabPageIn.Controls.Add(this.dataGridViewIn);
			this.tabPageIn.Location = new System.Drawing.Point(4, 29);
			this.tabPageIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPageIn.Name = "tabPageIn";
			this.tabPageIn.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPageIn.Size = new System.Drawing.Size(802, 1132);
			this.tabPageIn.TabIndex = 3;
			this.tabPageIn.Text = "In";
			this.tabPageIn.UseVisualStyleBackColor = true;
			// 
			// dataGridCustomIn
			// 
			this.dataGridViewIn.ColumnHeadersHeight = 34;
			this.dataGridViewIn.Location = new System.Drawing.Point(3, 4);
			this.dataGridViewIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridViewIn.Name = "dataGridCustomIn";
			this.dataGridViewIn.RowHeadersWidth = 62;
			this.dataGridViewIn.Size = new System.Drawing.Size(786, 1052);
			this.dataGridViewIn.TabIndex = 0;
			this.dataGridViewIn.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(948, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 20);
			this.label5.TabIndex = 32;
			this.label5.Text = "Autofill";
			// 
			// textBoxAutofill
			// 
			this.textBoxAutofill.AllowDrop = true;
			this.textBoxAutofill.Location = new System.Drawing.Point(830, 50);
			this.textBoxAutofill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxAutofill.Name = "textBoxAutofill";
			this.textBoxAutofill.Size = new System.Drawing.Size(112, 26);
			this.textBoxAutofill.TabIndex = 31;
			this.textBoxAutofill.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxAutofill_DragDrop);
			this.textBoxAutofill.DragOver += new System.Windows.Forms.DragEventHandler(this.TextBoxAutofill_DragOver);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(1247, 9);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(86, 34);
			this.buttonAdd.TabIndex = 33;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// yearFilter1
			// 
			this.yearFilter1.Location = new System.Drawing.Point(817, 6);
			this.yearFilter1.Name = "yearFilter1";
			this.yearFilter1.Size = new System.Drawing.Size(125, 37);
			this.yearFilter1.TabIndex = 30;
			// 
			// musicInfo1
			// 
			this.musicInfo1.Location = new System.Drawing.Point(816, 86);
			this.musicInfo1.Margin = new System.Windows.Forms.Padding(6);
			this.musicInfo1.Name = "musicInfo1";
			this.musicInfo1.Size = new System.Drawing.Size(764, 962);
			this.musicInfo1.TabIndex = 26;
			// 
			// buttonListenAgain
			// 
			this.buttonListenAgain.Location = new System.Drawing.Point(1029, 28);
			this.buttonListenAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonListenAgain.Name = "buttonListenAgain";
			this.buttonListenAgain.Size = new System.Drawing.Size(112, 35);
			this.buttonListenAgain.TabIndex = 34;
			this.buttonListenAgain.Text = "Listen again";
			this.buttonListenAgain.UseVisualStyleBackColor = true;
			this.buttonListenAgain.Click += new System.EventHandler(this.ButtonListenAgain_Click);
			// 
			// MusicControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonListenAgain);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxAutofill);
			this.Controls.Add(this.yearFilter1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.musicInfo1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MusicControl";
			this.Size = new System.Drawing.Size(1607, 1165);
			this.tabControl1.ResumeLayout(false);
			this.tabPageAll.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.tabPageToDo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodo)).EndInit();
			this.tabPageYearList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewYearList)).EndInit();
			this.tabPageIn.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataGridView dataGridViewAll;
		private MusicInfo musicInfo1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAll;
        private System.Windows.Forms.TabPage tabPageToDo;
        private DataGridView dataGridViewTodo;
		private System.Windows.Forms.TabPage tabPageYearList;
		private DataGridView dataGridViewYearList;
		private System.Windows.Forms.TabPage tabPageIn;
		private DataGridView dataGridViewIn;
		private YearFilter yearFilter1;
		private Label label5;
		private TextBox textBoxAutofill;
		private Button buttonAdd;
		private Button buttonListenAgain;
	}
}
