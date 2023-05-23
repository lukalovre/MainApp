using System.Windows.Forms;

namespace MainApp.My_work
{
	partial class MyWorkControl
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
			this.addMyWork1 = new MainApp.My_work.AddMyWorkControl();
			this.dataGridMyWork = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMyWork)).BeginInit();
			this.SuspendLayout();
			// 
			// addMyWork1
			// 
			this.addMyWork1.Location = new System.Drawing.Point(1048, 5);
			this.addMyWork1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.addMyWork1.Name = "addMyWork1";
			this.addMyWork1.Size = new System.Drawing.Size(285, 281);
			this.addMyWork1.TabIndex = 1;
			// 
			// dataGridMyWork
			// 
			this.dataGridMyWork.ColumnHeadersHeight = 34;
			this.dataGridMyWork.Location = new System.Drawing.Point(0, 0);
			this.dataGridMyWork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridMyWork.Name = "dataGridMyWork";
			this.dataGridMyWork.RowHeadersWidth = 62;
			this.dataGridMyWork.Size = new System.Drawing.Size(1040, 917);
			this.dataGridMyWork.TabIndex = 0;
			// 
			// MyWorkControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.addMyWork1);
			this.Controls.Add(this.dataGridMyWork);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MyWorkControl";
			this.Size = new System.Drawing.Size(1395, 917);
			((System.ComponentModel.ISupportInitialize)(this.dataGridMyWork)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dataGridMyWork;
		private AddMyWorkControl addMyWork1;
	}
}
