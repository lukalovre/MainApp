using System;
using System.Windows.Forms;

namespace MainApp.Movies
{
	partial class MoviesControl
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
			this.dataGridMovies = new System.Windows.Forms.DataGridView();
			this.numericUpDownYearWatched = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxImdb = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.movieInfo1 = new MainApp.Movies.MovieInfoControl();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.checkBoxDateTimePicker = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMovies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearWatched)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridMovies
			// 
			this.dataGridMovies.AllowUserToAddRows = false;
			this.dataGridMovies.AllowUserToDeleteRows = false;
			this.dataGridMovies.AllowUserToResizeRows = false;
			this.dataGridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridMovies.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridMovies.Location = new System.Drawing.Point(3, 3);
			this.dataGridMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridMovies.Name = "dataGridMovies";
			this.dataGridMovies.ReadOnly = true;
			this.dataGridMovies.RowHeadersWidth = 62;
			this.dataGridMovies.Size = new System.Drawing.Size(765, 985);
			this.dataGridMovies.TabIndex = 12;
			this.dataGridMovies.SelectionChanged += new System.EventHandler(this.DataGridMovies_SelectionChanged);
			// 
			// numericUpDownYearWatched
			// 
			this.numericUpDownYearWatched.Location = new System.Drawing.Point(797, 950);
			this.numericUpDownYearWatched.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
			this.numericUpDownYearWatched.Name = "numericUpDownYearWatched";
			this.numericUpDownYearWatched.Size = new System.Drawing.Size(80, 26);
			this.numericUpDownYearWatched.TabIndex = 26;
			this.numericUpDownYearWatched.ValueChanged += new System.EventHandler(this.NumericUpDownYearWatched_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(883, 952);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 20);
			this.label1.TabIndex = 27;
			this.label1.Text = "Year watched";
			// 
			// textBoxImdb
			// 
			this.textBoxImdb.Location = new System.Drawing.Point(797, 918);
			this.textBoxImdb.Name = "textBoxImdb";
			this.textBoxImdb.Size = new System.Drawing.Size(133, 26);
			this.textBoxImdb.TabIndex = 29;
			this.textBoxImdb.TextChanged += new System.EventHandler(this.TextBoxImdb_TextChanged);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(936, 912);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(88, 37);
			this.buttonAdd.TabIndex = 30;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(4, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(779, 1024);
			this.tabControl1.TabIndex = 31;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridMovies);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(771, 991);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Watched";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// movieInfo1
			// 
			this.movieInfo1.Location = new System.Drawing.Point(806, 3);
			this.movieInfo1.Name = "movieInfo1";
			this.movieInfo1.Size = new System.Drawing.Size(728, 903);
			this.movieInfo1.TabIndex = 28;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(1043, 917);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(183, 26);
			this.dateTimePicker1.TabIndex = 32;
			// 
			// checkBoxDateTimePicker
			// 
			this.checkBoxDateTimePicker.AutoSize = true;
			this.checkBoxDateTimePicker.Location = new System.Drawing.Point(1233, 918);
			this.checkBoxDateTimePicker.Name = "checkBoxDateTimePicker";
			this.checkBoxDateTimePicker.Size = new System.Drawing.Size(22, 21);
			this.checkBoxDateTimePicker.TabIndex = 33;
			this.checkBoxDateTimePicker.UseVisualStyleBackColor = true;
			// 
			// MoviesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkBoxDateTimePicker);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxImdb);
			this.Controls.Add(this.movieInfo1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDownYearWatched);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MoviesControl";
			this.Size = new System.Drawing.Size(1558, 1037);
			((System.ComponentModel.ISupportInitialize)(this.dataGridMovies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearWatched)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataGridView dataGridMovies;
		private NumericUpDown numericUpDownYearWatched;
		private Label label1;
		internal MovieInfoControl movieInfo1;
		private TextBox textBoxImdb;
		private Button buttonAdd;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private DateTimePicker dateTimePicker1;
		private CheckBox checkBoxDateTimePicker;
	}
}
