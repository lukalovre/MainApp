namespace MainApp.CommonControls
{
	partial class AddButton
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
			this.checkBoxDateTimePicker = new System.Windows.Forms.CheckBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkBoxDateTimePicker
			// 
			this.checkBoxDateTimePicker.AutoSize = true;
			this.checkBoxDateTimePicker.Location = new System.Drawing.Point(286, 11);
			this.checkBoxDateTimePicker.Name = "checkBoxDateTimePicker";
			this.checkBoxDateTimePicker.Size = new System.Drawing.Size(22, 21);
			this.checkBoxDateTimePicker.TabIndex = 36;
			this.checkBoxDateTimePicker.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(97, 6);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(183, 26);
			this.dateTimePicker1.TabIndex = 35;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(3, 3);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(88, 37);
			this.buttonAdd.TabIndex = 34;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;			
			// 
			// AddButton
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkBoxDateTimePicker);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.buttonAdd);
			this.Name = "AddButton";
			this.Size = new System.Drawing.Size(315, 43);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxDateTimePicker;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button buttonAdd;
	}
}
