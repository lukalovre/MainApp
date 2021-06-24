
namespace MainApp
{
	partial class StarRating
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
			this.labelRatingDescription = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelText
			// 
			this.labelRatingDescription.AutoSize = true;
			this.labelRatingDescription.Location = new System.Drawing.Point(3, 67);
			this.labelRatingDescription.Name = "labelText";
			this.labelRatingDescription.Size = new System.Drawing.Size(93, 20);
			this.labelRatingDescription.TabIndex = 1;
			this.labelRatingDescription.Text = "Goog Good";
			// 
			// StarRating
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelRatingDescription);
			this.Name = "StarRating";
			this.Size = new System.Drawing.Size(247, 103);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelRatingDescription;
	}
}
