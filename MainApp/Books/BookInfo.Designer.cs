namespace MainApp.Books
{
	partial class BookInfo
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
			this.numericUpDownPages = new System.Windows.Forms.NumericUpDown();
			this.checkBoxRead = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxAutor = new System.Windows.Forms.TextBox();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.checkBox1001 = new System.Windows.Forms.CheckBox();
			this.labelAddingPages = new System.Windows.Forms.Label();
			this.starRating1 = new MainApp.StarRating();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDownPages
			// 
			this.numericUpDownPages.Location = new System.Drawing.Point(4, 208);
			this.numericUpDownPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numericUpDownPages.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericUpDownPages.Name = "numericUpDownPages";
			this.numericUpDownPages.Size = new System.Drawing.Size(66, 26);
			this.numericUpDownPages.TabIndex = 3;
			this.numericUpDownPages.ValueChanged += new System.EventHandler(this.NumericUpDownPages_ValueChanged);
			// 
			// checkBoxRead
			// 
			this.checkBoxRead.AutoSize = true;
			this.checkBoxRead.Location = new System.Drawing.Point(3, 244);
			this.checkBoxRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxRead.Name = "checkBoxRead";
			this.checkBoxRead.Size = new System.Drawing.Size(74, 24);
			this.checkBoxRead.TabIndex = 4;
			this.checkBoxRead.Text = "Read";
			this.checkBoxRead.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(78, 210);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Pages";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTitle.Location = new System.Drawing.Point(4, 4);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(539, 44);
			this.textBoxTitle.TabIndex = 9;
			this.textBoxTitle.Text = "The Book of Laughter and Forgetting";
			// 
			// textBoxAutor
			// 
			this.textBoxAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAutor.Location = new System.Drawing.Point(4, 55);
			this.textBoxAutor.Name = "textBoxAutor";
			this.textBoxAutor.Size = new System.Drawing.Size(174, 35);
			this.textBoxAutor.TabIndex = 10;
			this.textBoxAutor.Text = "Milan Kundera";
			// 
			// numericUpDownYear
			// 
			this.numericUpDownYear.Location = new System.Drawing.Point(175, 208);
			this.numericUpDownYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.numericUpDownYear.Name = "numericUpDownYear";
			this.numericUpDownYear.Size = new System.Drawing.Size(120, 26);
			this.numericUpDownYear.TabIndex = 11;
			// 
			// checkBox1001
			// 
			this.checkBox1001.AutoSize = true;
			this.checkBox1001.Location = new System.Drawing.Point(175, 244);
			this.checkBox1001.Name = "checkBox1001";
			this.checkBox1001.Size = new System.Drawing.Size(71, 24);
			this.checkBox1001.TabIndex = 12;
			this.checkBox1001.Text = "1001";
			this.checkBox1001.UseVisualStyleBackColor = true;
			// 
			// labelAddingPages
			// 
			this.labelAddingPages.AutoSize = true;
			this.labelAddingPages.Location = new System.Drawing.Point(349, 208);
			this.labelAddingPages.Name = "labelAddingPages";
			this.labelAddingPages.Size = new System.Drawing.Size(126, 20);
			this.labelAddingPages.TabIndex = 13;
			this.labelAddingPages.Text = "Added 15 pages";
			// 
			// starRating1
			// 
			this.starRating1.Location = new System.Drawing.Point(4, 96);
			this.starRating1.Name = "starRating1";
			this.starRating1.Size = new System.Drawing.Size(249, 92);
			this.starRating1.TabIndex = 14;
			// 
			// BookInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.starRating1);
			this.Controls.Add(this.labelAddingPages);
			this.Controls.Add(this.checkBox1001);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.textBoxAutor);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.checkBoxRead);
			this.Controls.Add(this.numericUpDownPages);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "BookInfo";
			this.Size = new System.Drawing.Size(549, 278);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.NumericUpDown numericUpDownPages;
		private System.Windows.Forms.CheckBox checkBoxRead;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.TextBox textBoxAutor;
		private System.Windows.Forms.NumericUpDown numericUpDownYear;
		private System.Windows.Forms.CheckBox checkBox1001;
		private System.Windows.Forms.Label labelAddingPages;
		private StarRating starRating1;
	}
}
