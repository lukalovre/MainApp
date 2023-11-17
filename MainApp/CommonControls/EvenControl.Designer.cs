namespace MainApp.CommonControls
{
	partial class EvenControl
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
			this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
			this.eventListControl1 = new MainApp.EventListControl();
			this.peopleListControl1 = new MainApp.CommonControls.PeopleListControl();
			this.starRatingControl1 = new MainApp.StarRatingControl();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBoxComment.Location = new System.Drawing.Point(3, 112);
			this.richTextBoxComment.Name = "richTextBox1";
			this.richTextBoxComment.Size = new System.Drawing.Size(247, 284);
			this.richTextBoxComment.TabIndex = 3;
			this.richTextBoxComment.Text = "";
			// 
			// eventListControl1
			// 
			this.eventListControl1.Location = new System.Drawing.Point(256, 208);
			this.eventListControl1.Name = "eventListControl1";
			this.eventListControl1.Size = new System.Drawing.Size(153, 188);
			this.eventListControl1.TabIndex = 2;
			// 
			// peopleListControl1
			// 
			this.peopleListControl1.Location = new System.Drawing.Point(256, 3);
			this.peopleListControl1.Name = "peopleListControl1";
			this.peopleListControl1.Size = new System.Drawing.Size(153, 199);
			this.peopleListControl1.TabIndex = 1;
			// 
			// starRatingControl1
			// 
			this.starRatingControl1.Location = new System.Drawing.Point(3, 3);
			this.starRatingControl1.Name = "starRatingControl1";
			this.starRatingControl1.SelectedStar = 1;
			this.starRatingControl1.Size = new System.Drawing.Size(247, 103);
			this.starRatingControl1.TabIndex = 0;
			// 
			// EvenControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.richTextBoxComment);
			this.Controls.Add(this.eventListControl1);
			this.Controls.Add(this.peopleListControl1);
			this.Controls.Add(this.starRatingControl1);
			this.Name = "EvenControl";
			this.Size = new System.Drawing.Size(440, 425);
			this.ResumeLayout(false);

		}

		#endregion

		private StarRatingControl starRatingControl1;
		private PeopleListControl peopleListControl1;
		private EventListControl eventListControl1;
		private System.Windows.Forms.RichTextBox richTextBoxComment;
	}
}
