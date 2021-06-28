namespace MainApp.Collection.Library
{
	partial class LibraryControl
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
			this.dataGridCustom1 = new MainApp.DataGridCustom();
			this.buttonReturned = new System.Windows.Forms.Button();
			this.addLibrary1 = new MainApp.Collection.Library.AddLibraryControl();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustom1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridCustom1
			// 
			this.dataGridCustom1.AllowUserToAddRows = false;
			this.dataGridCustom1.AllowUserToDeleteRows = false;
			this.dataGridCustom1.AllowUserToResizeRows = false;
			this.dataGridCustom1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCustom1.CurrentRowIndex = 0;
			this.dataGridCustom1.DataSourceCustom = null;
			this.dataGridCustom1.Dock = System.Windows.Forms.DockStyle.Left;
			this.dataGridCustom1.Location = new System.Drawing.Point(0, 0);
			this.dataGridCustom1.Name = "dataGridCustom1";
			this.dataGridCustom1.ReadOnly = true;
			this.dataGridCustom1.RowHeadersWidth = 51;
			this.dataGridCustom1.RowTemplate.Height = 24;
			this.dataGridCustom1.Size = new System.Drawing.Size(693, 786);
			this.dataGridCustom1.TabIndex = 0;
			// 
			// buttonReturned
			// 
			this.buttonReturned.Location = new System.Drawing.Point(700, 242);
			this.buttonReturned.Name = "buttonReturned";
			this.buttonReturned.Size = new System.Drawing.Size(75, 23);
			this.buttonReturned.TabIndex = 1;
			this.buttonReturned.Text = "Returned";
			this.buttonReturned.UseVisualStyleBackColor = true;
			this.buttonReturned.Click += new System.EventHandler(this.buttonReturned_Click);
			// 
			// addLibrary1
			// 
			this.addLibrary1.Location = new System.Drawing.Point(700, 4);
			this.addLibrary1.Name = "addLibrary1";
			this.addLibrary1.Size = new System.Drawing.Size(180, 168);
			this.addLibrary1.TabIndex = 2;
			// 
			// Library
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.addLibrary1);
			this.Controls.Add(this.buttonReturned);
			this.Controls.Add(this.dataGridCustom1);
			this.Name = "Library";
			this.Size = new System.Drawing.Size(1071, 786);
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustom1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridCustom dataGridCustom1;
		private System.Windows.Forms.Button buttonReturned;
		private AddLibraryControl addLibrary1;
	}
}
