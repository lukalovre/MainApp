namespace MainApp.MainControls.Zoo
{
	partial class ZooInfoControl
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
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxCountry = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.evenControl1 = new MainApp.CommonControls.EvenControl();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(4, 4);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(145, 26);
			this.textBoxName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(155, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(4, 36);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(145, 26);
			this.textBoxCity.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(155, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "City";
			// 
			// textBoxCountry
			// 
			this.textBoxCountry.Location = new System.Drawing.Point(4, 68);
			this.textBoxCountry.Name = "textBoxCountry";
			this.textBoxCountry.Size = new System.Drawing.Size(145, 26);
			this.textBoxCountry.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(155, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Country";
			// 
			// evenControl1
			// 
			this.evenControl1.Location = new System.Drawing.Point(4, 100);
			this.evenControl1.Name = "evenControl1";
			this.evenControl1.Size = new System.Drawing.Size(440, 425);
			this.evenControl1.TabIndex = 6;
			// 
			// ZooInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.evenControl1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxCountry);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxName);
			this.Name = "ZooInfoControl";
			this.Size = new System.Drawing.Size(566, 597);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxCountry;
		private System.Windows.Forms.Label label3;
		private CommonControls.EvenControl evenControl1;
	}
}
