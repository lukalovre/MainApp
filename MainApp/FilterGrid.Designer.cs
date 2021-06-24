namespace MainApp
{
	partial class FilterGrid
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
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDownLastYear = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastYear)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Last year";
			// 
			// numericUpDownLastYear
			// 
			this.numericUpDownLastYear.Location = new System.Drawing.Point(4, 5);
			this.numericUpDownLastYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numericUpDownLastYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericUpDownLastYear.Name = "numericUpDownLastYear";
			this.numericUpDownLastYear.Size = new System.Drawing.Size(75, 26);
			this.numericUpDownLastYear.TabIndex = 5;
			this.numericUpDownLastYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
			this.numericUpDownLastYear.ValueChanged += new System.EventHandler(this.NumericUpDownLastYearValueChanged);
			// 
			// FilterGrid
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDownLastYear);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FilterGrid";
			this.Size = new System.Drawing.Size(169, 39);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastYear)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownLastYear;
	}
}
