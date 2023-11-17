namespace MainApp.MainControls.Zoo
{
	partial class SongsControl
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
			if (disposing && (components != null))
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
			this.songInfoControl = new MainApp.MainControls.Zoo.SongInfoControl();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageAll = new System.Windows.Forms.TabPage();
			this.tabPageIn = new System.Windows.Forms.TabPage();
			this.dataGridViewIn = new System.Windows.Forms.DataGridView();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.addButton1 = new MainApp.CommonControls.AddButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPageAll.SuspendLayout();
			this.tabPageIn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAll
			// 
			this.dataGridViewAll.AllowUserToAddRows = false;
			this.dataGridViewAll.AllowUserToDeleteRows = false;
			this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAll.Location = new System.Drawing.Point(37, 113);
			this.dataGridViewAll.Name = "dataGridViewAll";
			this.dataGridViewAll.ReadOnly = true;
			this.dataGridViewAll.RowHeadersWidth = 62;
			this.dataGridViewAll.RowTemplate.Height = 28;
			this.dataGridViewAll.Size = new System.Drawing.Size(516, 467);
			this.dataGridViewAll.TabIndex = 0;
			// 
			// songInfoControl
			// 
			this.songInfoControl.Location = new System.Drawing.Point(874, 32);
			this.songInfoControl.Name = "songInfoControl";
			this.songInfoControl.Size = new System.Drawing.Size(522, 826);
			this.songInfoControl.TabIndex = 1;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Controls.Add(this.tabPageIn);
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(865, 978);
			this.tabControl1.TabIndex = 36;
			// 
			// tabPageAll
			// 
			this.tabPageAll.Controls.Add(this.dataGridViewAll);
			this.tabPageAll.Location = new System.Drawing.Point(4, 29);
			this.tabPageAll.Name = "tabPageAll";
			this.tabPageAll.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAll.Size = new System.Drawing.Size(857, 945);
			this.tabPageAll.TabIndex = 0;
			this.tabPageAll.Text = "All";
			this.tabPageAll.UseVisualStyleBackColor = true;
			// 
			// tabPageIn
			// 
			this.tabPageIn.Controls.Add(this.dataGridViewIn);
			this.tabPageIn.Location = new System.Drawing.Point(4, 29);
			this.tabPageIn.Name = "tabPageIn";
			this.tabPageIn.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageIn.Size = new System.Drawing.Size(857, 945);
			this.tabPageIn.TabIndex = 1;
			this.tabPageIn.Text = "In";
			this.tabPageIn.UseVisualStyleBackColor = true;
			// 
			// dataGridViewIn
			// 
			this.dataGridViewIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewIn.Location = new System.Drawing.Point(182, 294);
			this.dataGridViewIn.Name = "dataGridViewIn";
			this.dataGridViewIn.RowHeadersWidth = 62;
			this.dataGridViewIn.RowTemplate.Height = 28;
			this.dataGridViewIn.Size = new System.Drawing.Size(240, 150);
			this.dataGridViewIn.TabIndex = 0;
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(870, 864);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(100, 26);
			this.textBoxInput.TabIndex = 37;
			this.textBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
			// 
			// addButton1
			// 
			this.addButton1.Location = new System.Drawing.Point(875, 912);
			this.addButton1.Name = "addButton1";
			this.addButton1.Size = new System.Drawing.Size(315, 43);
			this.addButton1.TabIndex = 38;
			// 
			// SongsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.addButton1);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.songInfoControl);
			this.Name = "SongsControl";
			this.Size = new System.Drawing.Size(1520, 984);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPageAll.ResumeLayout(false);
			this.tabPageIn.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewAll;
		private SongInfoControl songInfoControl;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageAll;
		private System.Windows.Forms.TabPage tabPageIn;
		private System.Windows.Forms.DataGridView dataGridViewIn;
		private System.Windows.Forms.TextBox textBoxInput;
		private CommonControls.AddButton addButton1;
	}
}
