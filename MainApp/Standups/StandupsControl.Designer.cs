using System.Windows.Forms;

namespace MainApp.Standups
{
	partial class StandupsControl
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
			this.dataGridViewStandup = new System.Windows.Forms.DataGridView();
			this.standupInfo1 = new MainApp.Standups.StandupInfo();
			this.textBoxImdb = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStandup)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewStandup
			// 
			this.dataGridViewStandup.AllowUserToAddRows = false;
			this.dataGridViewStandup.AllowUserToDeleteRows = false;
			this.dataGridViewStandup.AllowUserToResizeRows = false;
			this.dataGridViewStandup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStandup.Dock = System.Windows.Forms.DockStyle.Left;
			this.dataGridViewStandup.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewStandup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewStandup.Name = "dataGridViewStandup";
			this.dataGridViewStandup.ReadOnly = true;
			this.dataGridViewStandup.RowHeadersWidth = 62;
			this.dataGridViewStandup.Size = new System.Drawing.Size(885, 1037);
			this.dataGridViewStandup.TabIndex = 0;
			this.dataGridViewStandup.SelectionChanged += new System.EventHandler(this.DataGridViewStandup_SelectionChanged);
			// 
			// standupInfo1
			// 
			this.standupInfo1.Location = new System.Drawing.Point(892, 0);
			this.standupInfo1.Name = "standupInfo1";
			this.standupInfo1.Size = new System.Drawing.Size(756, 665);
			this.standupInfo1.TabIndex = 1;
			// 
			// textBoxImdb
			// 
			this.textBoxImdb.Location = new System.Drawing.Point(893, 729);
			this.textBoxImdb.Name = "textBoxImdb";
			this.textBoxImdb.Size = new System.Drawing.Size(100, 26);
			this.textBoxImdb.TabIndex = 2;
			this.textBoxImdb.TextChanged += new System.EventHandler(this.TextBoxImdb_TextChanged);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(893, 762);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(80, 35);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// StandupsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxImdb);
			this.Controls.Add(this.standupInfo1);
			this.Controls.Add(this.dataGridViewStandup);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "StandupsControl";
			this.Size = new System.Drawing.Size(1669, 1037);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStandup)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dataGridViewStandup;
		private StandupInfo standupInfo1;
		private TextBox textBoxImdb;
		private Button buttonAdd;
	}
}
