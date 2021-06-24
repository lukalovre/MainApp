namespace MainApp.Collection.Music
{
	partial class Music
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
            this.addMusicCollection1 = new MainApp.Collection.Music.AddMusicCollection();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustom1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCustom1
            // 
            this.dataGridCustom1.AllowUserToAddRows = false;
            this.dataGridCustom1.AllowUserToDeleteRows = false;
            this.dataGridCustom1.AllowUserToResizeRows = false;
            this.dataGridCustom1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustom1.DataSourceCustom = null;
            this.dataGridCustom1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridCustom1.Location = new System.Drawing.Point(0, 0);
            this.dataGridCustom1.Name = "dataGridCustom1";
            this.dataGridCustom1.ReadOnly = true;
            this.dataGridCustom1.Size = new System.Drawing.Size(693, 577);
            this.dataGridCustom1.TabIndex = 0;
            // 
            // addMusicCollection1
            // 
            this.addMusicCollection1.Location = new System.Drawing.Point(699, 3);
            this.addMusicCollection1.Name = "addMusicCollection1";
            this.addMusicCollection1.Size = new System.Drawing.Size(162, 453);
            this.addMusicCollection1.TabIndex = 1;
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addMusicCollection1);
            this.Controls.Add(this.dataGridCustom1);
            this.Name = "Music";
            this.Size = new System.Drawing.Size(890, 577);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustom1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DataGridCustom dataGridCustom1;
		private AddMusicCollection addMusicCollection1;
	}
}
