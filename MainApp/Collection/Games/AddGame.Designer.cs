namespace MainApp.Collection.Games
{
	partial class AddGame
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.checkBox1001 = new System.Windows.Forms.CheckBox();
			this.checkBoxCompleted = new System.Windows.Forms.CheckBox();
			this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPlatform = new System.Windows.Forms.TextBox();
			this.textBoxTime = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(4, 153);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 28);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(4, 4);
			this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(224, 22);
			this.textBoxTitle.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(236, 7);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(35, 17);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "Title";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(144, 96);
			this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(39, 17);
			this.lblTime.TabIndex = 6;
			this.lblTime.Text = "Time";
			// 
			// checkBox1001
			// 
			this.checkBox1001.AutoSize = true;
			this.checkBox1001.Checked = true;
			this.checkBox1001.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1001.Location = new System.Drawing.Point(109, 34);
			this.checkBox1001.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.checkBox1001.Name = "checkBox1001";
			this.checkBox1001.Size = new System.Drawing.Size(62, 21);
			this.checkBox1001.TabIndex = 10;
			this.checkBox1001.Text = "1001";
			this.checkBox1001.UseVisualStyleBackColor = true;
			// 
			// checkBoxCompleted
			// 
			this.checkBoxCompleted.AutoSize = true;
			this.checkBoxCompleted.Location = new System.Drawing.Point(4, 34);
			this.checkBoxCompleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.checkBoxCompleted.Name = "checkBoxCompleted";
			this.checkBoxCompleted.Size = new System.Drawing.Size(97, 21);
			this.checkBoxCompleted.TabIndex = 11;
			this.checkBoxCompleted.Text = "Completed";
			this.checkBoxCompleted.UseVisualStyleBackColor = true;
			// 
			// numericUpDownRating
			// 
			this.numericUpDownRating.Location = new System.Drawing.Point(138, 63);
			this.numericUpDownRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.numericUpDownRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDownRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownRating.Name = "numericUpDownRating";
			this.numericUpDownRating.Size = new System.Drawing.Size(53, 22);
			this.numericUpDownRating.TabIndex = 13;
			this.numericUpDownRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(199, 63);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 14;
			this.label1.Text = "Rating";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(92, 65);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 17);
			this.label2.TabIndex = 15;
			this.label2.Text = "Year";
			// 
			// numericUpDownYear
			// 
			this.numericUpDownYear.Location = new System.Drawing.Point(4, 63);
			this.numericUpDownYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.numericUpDownYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericUpDownYear.Name = "numericUpDownYear";
			this.numericUpDownYear.Size = new System.Drawing.Size(80, 22);
			this.numericUpDownYear.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(117, 126);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 17);
			this.label3.TabIndex = 17;
			this.label3.Text = "Platform";
			// 
			// textBoxPlatform
			// 
			this.textBoxPlatform.Location = new System.Drawing.Point(4, 123);
			this.textBoxPlatform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxPlatform.Name = "textBoxPlatform";
			this.textBoxPlatform.Size = new System.Drawing.Size(105, 22);
			this.textBoxPlatform.TabIndex = 18;
			// 
			// textBoxTime
			// 
			this.textBoxTime.Location = new System.Drawing.Point(4, 93);
			this.textBoxTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxTime.Name = "textBoxTime";
			this.textBoxTime.Size = new System.Drawing.Size(132, 22);
			this.textBoxTime.TabIndex = 19;
			// 
			// AddGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxTime);
			this.Controls.Add(this.textBoxPlatform);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDownRating);
			this.Controls.Add(this.checkBoxCompleted);
			this.Controls.Add(this.checkBox1001);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.btnAdd);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "AddGame";
			this.Size = new System.Drawing.Size(273, 191);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.CheckBox checkBox1001;
		private System.Windows.Forms.CheckBox checkBoxCompleted;
		private System.Windows.Forms.NumericUpDown numericUpDownRating;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPlatform;
        private System.Windows.Forms.TextBox textBoxTime;
    }
}
