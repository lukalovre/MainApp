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
			this.dataGridMyWork = new DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMyWork)).BeginInit();
			this.SuspendLayout();
			// 
			// addMyWork1
			// 
			this.addMyWork1.Location = new System.Drawing.Point(699, 3);
			this.addMyWork1.Name = "addMyWork1";
			this.addMyWork1.Size = new System.Drawing.Size(190, 242);
			this.addMyWork1.TabIndex = 1;
			// 
			// dataGridMyWork
			// 
			this.dataGridMyWork.Location = new System.Drawing.Point(0, 0);
			this.dataGridMyWork.Name = "dataGridMyWork";
			this.dataGridMyWork.Size = new System.Drawing.Size(693, 596);
			this.dataGridMyWork.TabIndex = 0;
			// 
			// MyWork
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.addMyWork1);
			this.Controls.Add(this.dataGridMyWork);
			this.Name = "MyWork";
			this.Size = new System.Drawing.Size(930, 596);
			((System.ComponentModel.ISupportInitialize)(this.dataGridMyWork)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dataGridMyWork;
		private AddMyWorkControl addMyWork1;
	}
}
