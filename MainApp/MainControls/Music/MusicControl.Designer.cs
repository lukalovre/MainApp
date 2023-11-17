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
			this.tabPageToDo2 = new System.Windows.Forms.TabPage();
			this.dataGridViewTodo2 = new System.Windows.Forms.DataGridView();
			this.tabPageToDo1 = new System.Windows.Forms.TabPage();
			this.dataGridViewTodo1 = new System.Windows.Forms.DataGridView();
			this.tabPageYearList = new System.Windows.Forms.TabPage();
			this.dataGridViewYearList = new System.Windows.Forms.DataGridView();
			this.tabPageIn = new System.Windows.Forms.TabPage();
			this.dataGridViewIn = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxAutofill = new System.Windows.Forms.TextBox();
			this.buttonListenAgain = new System.Windows.Forms.Button();
			this.checkBoxNew = new System.Windows.Forms.CheckBox();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.addButton1 = new MainApp.CommonControls.AddButton();
			this.musicInfo1 = new MainApp.Musics.MusicInfoControl();
			this.tabControl1.SuspendLayout();
			this.tabPageAll.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.tabPageToDo2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodo2)).BeginInit();
			this.tabPageToDo1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodo1)).BeginInit();
			this.tabPageYearList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewYearList)).BeginInit();
			this.tabPageIn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Controls.Add(this.tabPageToDo2);
			this.tabControl1.Controls.Add(this.tabPageToDo1);
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
			// dataGridViewAll
			// 
			this.dataGridViewAll.ColumnHeadersHeight = 34;
			this.dataGridViewAll.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewAll.Name = "dataGridViewAll";
			this.dataGridViewAll.RowHeadersWidth = 62;
			this.dataGridViewAll.Size = new System.Drawing.Size(714, 926);
			this.dataGridViewAll.TabIndex = 22;
			this.dataGridViewAll.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageToDo2
			// 
			this.tabPageToDo2.Controls.Add(this.dataGridViewTodo2);
			this.tabPageToDo2.Location = new System.Drawing.Point(4, 29);
			this.tabPageToDo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageToDo2.Name = "tabPageToDo2";
			this.tabPageToDo2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageToDo2.Size = new System.Drawing.Size(802, 1132);
			this.tabPageToDo2.TabIndex = 1;
			this.tabPageToDo2.Text = "To do (2)";
			this.tabPageToDo2.UseVisualStyleBackColor = true;
			// 
			// dataGridViewTodo2
			// 
			this.dataGridViewTodo2.ColumnHeadersHeight = 34;
			this.dataGridViewTodo2.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewTodo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewTodo2.Name = "dataGridViewTodo2";
			this.dataGridViewTodo2.RowHeadersWidth = 62;
			this.dataGridViewTodo2.Size = new System.Drawing.Size(1014, 803);
			this.dataGridViewTodo2.TabIndex = 0;
			this.dataGridViewTodo2.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageToDo1
			// 
			this.tabPageToDo1.Controls.Add(this.dataGridViewTodo1);
			this.tabPageToDo1.Location = new System.Drawing.Point(4, 29);
			this.tabPageToDo1.Name = "tabPageToDo1";
			this.tabPageToDo1.Size = new System.Drawing.Size(802, 1132);
			this.tabPageToDo1.TabIndex = 4;
			this.tabPageToDo1.Text = "To do (1)";
			this.tabPageToDo1.UseVisualStyleBackColor = true;
			// 
			// dataGridViewTodo1
			// 
			this.dataGridViewTodo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTodo1.Location = new System.Drawing.Point(287, 303);
			this.dataGridViewTodo1.Name = "dataGridViewTodo1";
			this.dataGridViewTodo1.RowHeadersWidth = 62;
			this.dataGridViewTodo1.RowTemplate.Height = 28;
			this.dataGridViewTodo1.Size = new System.Drawing.Size(240, 150);
			this.dataGridViewTodo1.TabIndex = 0;
			this.dataGridViewTodo1.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
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
			// dataGridViewYearList
			// 
			this.dataGridViewYearList.ColumnHeadersHeight = 34;
			this.dataGridViewYearList.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewYearList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewYearList.Name = "dataGridViewYearList";
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
			// dataGridViewIn
			// 
			this.dataGridViewIn.ColumnHeadersHeight = 34;
			this.dataGridViewIn.Location = new System.Drawing.Point(3, 4);
			this.dataGridViewIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridViewIn.Name = "dataGridViewIn";
			this.dataGridViewIn.RowHeadersWidth = 62;
			this.dataGridViewIn.Size = new System.Drawing.Size(786, 1052);
			this.dataGridViewIn.TabIndex = 0;
			this.dataGridViewIn.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(931, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 20);
			this.label5.TabIndex = 32;
			this.label5.Text = "Autofill";
			// 
			// textBoxAutofill
			// 
			this.textBoxAutofill.AllowDrop = true;
			this.textBoxAutofill.Location = new System.Drawing.Point(813, 60);
			this.textBoxAutofill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxAutofill.Name = "textBoxAutofill";
			this.textBoxAutofill.Size = new System.Drawing.Size(112, 26);
			this.textBoxAutofill.TabIndex = 31;
			this.textBoxAutofill.TextChanged += new System.EventHandler(this.TextBoxAutofill_TextChanged);
			this.textBoxAutofill.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxAutofill_DragDrop);
			this.textBoxAutofill.DragOver += new System.Windows.Forms.DragEventHandler(this.TextBoxAutofill_DragOver);
			// 
			// buttonListenAgain
			// 
			this.buttonListenAgain.Location = new System.Drawing.Point(1126, 10);
			this.buttonListenAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonListenAgain.Name = "buttonListenAgain";
			this.buttonListenAgain.Size = new System.Drawing.Size(112, 35);
			this.buttonListenAgain.TabIndex = 34;
			this.buttonListenAgain.Text = "Listen again";
			this.buttonListenAgain.UseVisualStyleBackColor = true;
			this.buttonListenAgain.Click += new System.EventHandler(this.ButtonListenAgain_Click);
			// 
			// checkBoxNew
			// 
			this.checkBoxNew.AutoSize = true;
			this.checkBoxNew.Location = new System.Drawing.Point(1024, 58);
			this.checkBoxNew.Name = "checkBoxNew";
			this.checkBoxNew.Size = new System.Drawing.Size(66, 24);
			this.checkBoxNew.TabIndex = 35;
			this.checkBoxNew.Text = "New";
			this.checkBoxNew.UseVisualStyleBackColor = true;
			// 
			// buttonLoad
			// 
			this.buttonLoad.Location = new System.Drawing.Point(1267, 7);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(96, 41);
			this.buttonLoad.TabIndex = 36;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(1369, 8);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(101, 40);
			this.buttonSave.TabIndex = 37;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// addButton1
			// 
			this.addButton1.Location = new System.Drawing.Point(813, 10);
			this.addButton1.Name = "addButton1";
			this.addButton1.Size = new System.Drawing.Size(315, 43);
			this.addButton1.TabIndex = 38;
			// 
			// musicInfo1
			// 
			this.musicInfo1.Location = new System.Drawing.Point(813, 103);
			this.musicInfo1.Margin = new System.Windows.Forms.Padding(6);
			this.musicInfo1.Name = "musicInfo1";
			this.musicInfo1.Size = new System.Drawing.Size(764, 962);
			this.musicInfo1.TabIndex = 26;
			// 
			// MusicControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.addButton1);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.checkBoxNew);
			this.Controls.Add(this.buttonListenAgain);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxAutofill);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.musicInfo1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MusicControl";
			this.Size = new System.Drawing.Size(1607, 1165);
			this.tabControl1.ResumeLayout(false);
			this.tabPageAll.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.tabPageToDo2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodo2)).EndInit();
			this.tabPageToDo1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodo1)).EndInit();
			this.tabPageYearList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewYearList)).EndInit();
			this.tabPageIn.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataGridView dataGridViewAll;
		private MusicInfoControl musicInfo1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAll;
        private System.Windows.Forms.TabPage tabPageToDo2;
        private DataGridView dataGridViewTodo2;
		private System.Windows.Forms.TabPage tabPageYearList;
		private DataGridView dataGridViewYearList;
		private System.Windows.Forms.TabPage tabPageIn;
		private DataGridView dataGridViewIn;
		private Label label5;
		private TextBox textBoxAutofill;
		private Button buttonListenAgain;
		private CheckBox checkBoxNew;
		private Button buttonLoad;
		private Button buttonSave;
		private TabPage tabPageToDo1;
		private DataGridView dataGridViewTodo1;
		private CommonControls.AddButton addButton1;
	}
}
