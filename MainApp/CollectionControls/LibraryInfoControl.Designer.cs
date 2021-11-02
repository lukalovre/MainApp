namespace MainApp.Collection
{
	partial class LibraryInfoControl
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
			this.textBoxItemID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxType = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxLentTo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxItemID
			// 
			this.textBoxItemID.Location = new System.Drawing.Point(4, 5);
			this.textBoxItemID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxItemID.Name = "textBoxItemID";
			this.textBoxItemID.Size = new System.Drawing.Size(112, 26);
			this.textBoxItemID.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(125, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "ItemID";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(4, 41);
			this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(112, 26);
			this.textBoxTitle.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(125, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Title";
			// 
			// textBoxType
			// 
			this.textBoxType.Location = new System.Drawing.Point(4, 78);
			this.textBoxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxType.Name = "textBoxType";
			this.textBoxType.Size = new System.Drawing.Size(112, 26);
			this.textBoxType.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(125, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Type";
			// 
			// textBoxLentTo
			// 
			this.textBoxLentTo.Location = new System.Drawing.Point(4, 114);
			this.textBoxLentTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxLentTo.Name = "textBoxLentTo";
			this.textBoxLentTo.Size = new System.Drawing.Size(112, 26);
			this.textBoxLentTo.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(125, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Lent to";
			// 
			// LibraryInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxLentTo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxItemID);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "LibraryInfoControl";
			this.Size = new System.Drawing.Size(202, 159);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxItemID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxLentTo;
		private System.Windows.Forms.Label label4;
	}
}
