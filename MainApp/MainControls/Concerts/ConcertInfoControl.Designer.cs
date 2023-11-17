namespace MainApp.MainControls.Concerts
{
	partial class ConcertInfoControl
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
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxVenue = new System.Windows.Forms.TextBox();
			this.labelDate = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxFestival = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
			this.evenControl1 = new MainApp.CommonControls.EvenControl();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(155, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Venue";
			// 
			// textBoxVenue
			// 
			this.textBoxVenue.Location = new System.Drawing.Point(4, 100);
			this.textBoxVenue.Name = "textBoxVenue";
			this.textBoxVenue.Size = new System.Drawing.Size(145, 26);
			this.textBoxVenue.TabIndex = 10;
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(227, 10);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(91, 20);
			this.labelDate.TabIndex = 12;
			this.labelDate.Text = "2023-07-19";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(154, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 20);
			this.label5.TabIndex = 14;
			this.label5.Text = "Festival";
			// 
			// textBoxFestival
			// 
			this.textBoxFestival.Location = new System.Drawing.Point(3, 132);
			this.textBoxFestival.Name = "textBoxFestival";
			this.textBoxFestival.Size = new System.Drawing.Size(145, 26);
			this.textBoxFestival.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(156, 171);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 20);
			this.label6.TabIndex = 15;
			this.label6.Text = "Price";
			// 
			// numericUpDownPrice
			// 
			this.numericUpDownPrice.Location = new System.Drawing.Point(4, 165);
			this.numericUpDownPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.numericUpDownPrice.Name = "numericUpDownPrice";
			this.numericUpDownPrice.Size = new System.Drawing.Size(144, 26);
			this.numericUpDownPrice.TabIndex = 16;
			// 
			// evenControl1
			// 
			this.evenControl1.Location = new System.Drawing.Point(4, 197);
			this.evenControl1.Name = "evenControl1";
			this.evenControl1.Size = new System.Drawing.Size(440, 425);
			this.evenControl1.TabIndex = 17;
			// 
			// ConcertInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.evenControl1);
			this.Controls.Add(this.numericUpDownPrice);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxFestival);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxVenue);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxCountry);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxName);
			this.Name = "ConcertInfoControl";
			this.Size = new System.Drawing.Size(506, 639);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxVenue;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxFestival;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDownPrice;
		private CommonControls.EvenControl evenControl1;
	}
}
