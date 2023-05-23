
namespace MainApp.Reports
{
	partial class YearStatsCollectionControl
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
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.radioButtonPrice = new System.Windows.Forms.RadioButton();
			this.radioButtonAmount = new System.Windows.Forms.RadioButton();
			this.radioButtonPriceAmount = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(3, 3);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(102, 38);
			this.buttonRefresh.TabIndex = 33;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
			// 
			// radioButtonPrice
			// 
			this.radioButtonPrice.AutoSize = true;
			this.radioButtonPrice.Checked = true;
			this.radioButtonPrice.Location = new System.Drawing.Point(13, 56);
			this.radioButtonPrice.Name = "radioButtonPrice";
			this.radioButtonPrice.Size = new System.Drawing.Size(69, 24);
			this.radioButtonPrice.TabIndex = 34;
			this.radioButtonPrice.TabStop = true;
			this.radioButtonPrice.Text = "Price";
			this.radioButtonPrice.UseVisualStyleBackColor = true;
			this.radioButtonPrice.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
			// 
			// radioButtonAmount
			// 
			this.radioButtonAmount.AutoSize = true;
			this.radioButtonAmount.Location = new System.Drawing.Point(13, 86);
			this.radioButtonAmount.Name = "radioButtonAmount";
			this.radioButtonAmount.Size = new System.Drawing.Size(90, 24);
			this.radioButtonAmount.TabIndex = 35;
			this.radioButtonAmount.Text = "Amount";
			this.radioButtonAmount.UseVisualStyleBackColor = true;
			this.radioButtonAmount.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
			// 
			// radioButtonPriceAmount
			// 
			this.radioButtonPriceAmount.AutoSize = true;
			this.radioButtonPriceAmount.Location = new System.Drawing.Point(13, 116);
			this.radioButtonPriceAmount.Name = "radioButtonPriceAmount";
			this.radioButtonPriceAmount.Size = new System.Drawing.Size(129, 24);
			this.radioButtonPriceAmount.TabIndex = 36;
			this.radioButtonPriceAmount.Text = "Price/Amount";
			this.radioButtonPriceAmount.UseVisualStyleBackColor = true;
			this.radioButtonPriceAmount.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
			// 
			// YearStatsCollectionControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.radioButtonPriceAmount);
			this.Controls.Add(this.radioButtonAmount);
			this.Controls.Add(this.radioButtonPrice);
			this.Controls.Add(this.buttonRefresh);
			this.Name = "YearStatsCollectionControl";
			this.Size = new System.Drawing.Size(1311, 1018);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.RadioButton radioButtonPrice;
		private System.Windows.Forms.RadioButton radioButtonAmount;
		private System.Windows.Forms.RadioButton radioButtonPriceAmount;
	}
}
