namespace MainApp.MainControls.Zoo
{
	partial class ZooControl
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
			this.buttonAdd = new System.Windows.Forms.Button();
			this.zooInfoControl1 = new MainApp.MainControls.Zoo.ZooInfoControl();
			this.checkBoxDateTimePicker = new System.Windows.Forms.CheckBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(794, 614);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(103, 35);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// zooInfoControl1
			// 
			this.zooInfoControl1.Location = new System.Drawing.Point(794, 3);
			this.zooInfoControl1.Name = "zooInfoControl1";
			this.zooInfoControl1.Size = new System.Drawing.Size(599, 605);
			this.zooInfoControl1.TabIndex = 1;
			// 
			// checkBoxDateTimePicker
			// 
			this.checkBoxDateTimePicker.AutoSize = true;
			this.checkBoxDateTimePicker.Location = new System.Drawing.Point(1092, 619);
			this.checkBoxDateTimePicker.Name = "checkBoxDateTimePicker";
			this.checkBoxDateTimePicker.Size = new System.Drawing.Size(22, 21);
			this.checkBoxDateTimePicker.TabIndex = 35;
			this.checkBoxDateTimePicker.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(903, 616);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(183, 26);
			this.dateTimePicker1.TabIndex = 34;
			// 
			// ZooControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkBoxDateTimePicker);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.zooInfoControl1);
			this.Controls.Add(this.dataGridViewAll);
			this.Name = "ZooControl";
			this.Size = new System.Drawing.Size(1520, 984);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewAll;
		private ZooInfoControl zooInfoControl1;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.CheckBox checkBoxDateTimePicker;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}
