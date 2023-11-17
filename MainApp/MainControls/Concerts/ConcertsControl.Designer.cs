namespace MainApp.MainControls.Concerts
{
	partial class ConcertsControl
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
			this.concertInfoControl1 = new MainApp.MainControls.Concerts.ConcertInfoControl();
			this.addButton1 = new MainApp.CommonControls.AddButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAll
			// 
			this.dataGridViewAll.AllowUserToAddRows = false;
			this.dataGridViewAll.AllowUserToDeleteRows = false;
			this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAll.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewAll.Name = "dataGridViewAll";
			this.dataGridViewAll.ReadOnly = true;
			this.dataGridViewAll.RowHeadersWidth = 62;
			this.dataGridViewAll.RowTemplate.Height = 28;
			this.dataGridViewAll.Size = new System.Drawing.Size(785, 874);
			this.dataGridViewAll.TabIndex = 0;
			// 
			// concertInfoControl1
			// 
			this.concertInfoControl1.Location = new System.Drawing.Point(794, 3);
			this.concertInfoControl1.Name = "concertInfoControl1";
			this.concertInfoControl1.Size = new System.Drawing.Size(599, 605);
			this.concertInfoControl1.TabIndex = 1;
			// 
			// addButton1
			// 
			this.addButton1.Location = new System.Drawing.Point(794, 614);
			this.addButton1.Name = "addButton1";
			this.addButton1.Size = new System.Drawing.Size(315, 43);
			this.addButton1.TabIndex = 2;
			// 
			// ConcertsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.addButton1);
			this.Controls.Add(this.concertInfoControl1);
			this.Controls.Add(this.dataGridViewAll);
			this.Name = "ConcertsControl";
			this.Size = new System.Drawing.Size(1520, 984);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewAll;
		private ConcertInfoControl concertInfoControl1;
		private CommonControls.AddButton addButton1;
	}
}
