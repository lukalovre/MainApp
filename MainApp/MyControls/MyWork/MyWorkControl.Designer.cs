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
			this.dataGridMyWork = new System.Windows.Forms.DataGridView();
			this.myWorkInfoControl = new MainApp.My_work.MyWorkInfoControl();
			this.addButton1 = new MainApp.CommonControls.AddButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMyWork)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridMyWork
			// 
			this.dataGridMyWork.ColumnHeadersHeight = 34;
			this.dataGridMyWork.Location = new System.Drawing.Point(0, 0);
			this.dataGridMyWork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridMyWork.Name = "dataGridMyWork";
			this.dataGridMyWork.RowHeadersWidth = 62;
			this.dataGridMyWork.Size = new System.Drawing.Size(719, 917);
			this.dataGridMyWork.TabIndex = 0;
			// 
			// myWorkInfoControl
			// 
			this.myWorkInfoControl.Location = new System.Drawing.Point(756, 8);
			this.myWorkInfoControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.myWorkInfoControl.Name = "myWorkInfoControl";
			this.myWorkInfoControl.Size = new System.Drawing.Size(317, 352);
			this.myWorkInfoControl.TabIndex = 1;
			// 
			// addButton1
			// 
			this.addButton1.Location = new System.Drawing.Point(742, 372);
			this.addButton1.Name = "addButton1";
			this.addButton1.Size = new System.Drawing.Size(315, 43);
			this.addButton1.TabIndex = 2;
			// 
			// MyWorkControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.addButton1);
			this.Controls.Add(this.myWorkInfoControl);
			this.Controls.Add(this.dataGridMyWork);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MyWorkControl";
			this.Size = new System.Drawing.Size(1395, 917);
			((System.ComponentModel.ISupportInitialize)(this.dataGridMyWork)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dataGridMyWork;
		private MyWorkInfoControl myWorkInfoControl;
		private CommonControls.AddButton addButton1;
	}
}
