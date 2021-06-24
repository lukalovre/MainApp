namespace MainApp.Collection.Library
{
	partial class AddLibrary
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
			this.buttonAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxItemID
			// 
			this.textBoxItemID.Location = new System.Drawing.Point(4, 4);
			this.textBoxItemID.Name = "textBoxItemID";
			this.textBoxItemID.Size = new System.Drawing.Size(100, 22);
			this.textBoxItemID.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(111, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "ItemID";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(4, 33);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(100, 22);
			this.textBoxTitle.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(111, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Title";
			// 
			// textBoxType
			// 
			this.textBoxType.Location = new System.Drawing.Point(4, 62);
			this.textBoxType.Name = "textBoxType";
			this.textBoxType.Size = new System.Drawing.Size(100, 22);
			this.textBoxType.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(111, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Type";
			// 
			// textBoxLentTo
			// 
			this.textBoxLentTo.Location = new System.Drawing.Point(4, 91);
			this.textBoxLentTo.Name = "textBoxLentTo";
			this.textBoxLentTo.Size = new System.Drawing.Size(100, 22);
			this.textBoxLentTo.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(111, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Lent to";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(4, 120);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 8;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// AddLibrary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxLentTo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxItemID);
			this.Name = "AddLibrary";
			this.Size = new System.Drawing.Size(180, 168);
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
		private System.Windows.Forms.Button buttonAdd;
	}
}
