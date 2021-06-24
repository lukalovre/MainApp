namespace MainApp.My_work_progress
{
	partial class MyWorkProgress
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
			this.updateMyWorkProgress1 = new MainApp.My_work_progress.UpdateMyWorkProgress();
			this.addMyWorkProgress1 = new MainApp.My_work_progress.AddMyWorkProgress();
			this.dataGridCustom1 = new MainApp.DataGridCustom();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustom1)).BeginInit();
			this.SuspendLayout();
			// 
			// updateMyWorkProgress1
			// 
			this.updateMyWorkProgress1.Location = new System.Drawing.Point(700, 220);
			this.updateMyWorkProgress1.Name = "updateMyWorkProgress1";
			this.updateMyWorkProgress1.Size = new System.Drawing.Size(216, 62);
			this.updateMyWorkProgress1.TabIndex = 2;
			// 
			// addMyWorkProgress1
			// 
			this.addMyWorkProgress1.Location = new System.Drawing.Point(700, 4);
			this.addMyWorkProgress1.Margin = new System.Windows.Forms.Padding(4);
			this.addMyWorkProgress1.Name = "addMyWorkProgress1";
			this.addMyWorkProgress1.Size = new System.Drawing.Size(194, 151);
			this.addMyWorkProgress1.TabIndex = 1;
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
			this.dataGridCustom1.Size = new System.Drawing.Size(693, 900);
			this.dataGridCustom1.TabIndex = 0;
			// 
			// MyWorkProgress
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.updateMyWorkProgress1);
			this.Controls.Add(this.addMyWorkProgress1);
			this.Controls.Add(this.dataGridCustom1);
			this.Name = "MyWorkProgress";
			this.Size = new System.Drawing.Size(1022, 900);
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustom1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		internal DataGridCustom dataGridCustom1;
		private AddMyWorkProgress addMyWorkProgress1;
		private UpdateMyWorkProgress updateMyWorkProgress1;
	}
}
