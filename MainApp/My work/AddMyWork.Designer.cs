﻿namespace MainApp.My_work
{
	partial class AddMyWork
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
			this.buttonAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxPublic = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.checkBoxFinished = new System.Windows.Forms.CheckBox();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxCollaborators = new System.Windows.Forms.TextBox();
			this.textBoxType = new System.Windows.Forms.TextBox();
			this.textBoxLocation = new System.Windows.Forms.TextBox();
			this.textBoxPublicLocation = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(110, 216);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(109, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Title";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(109, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Collaborators";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(109, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Type";
			// 
			// checkBoxPublic
			// 
			this.checkBoxPublic.AutoSize = true;
			this.checkBoxPublic.Location = new System.Drawing.Point(3, 55);
			this.checkBoxPublic.Name = "checkBoxPublic";
			this.checkBoxPublic.Size = new System.Drawing.Size(55, 17);
			this.checkBoxPublic.TabIndex = 4;
			this.checkBoxPublic.Text = "Public";
			this.checkBoxPublic.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(109, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Location";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(109, 133);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Public location";
			// 
			// checkBoxFinished
			// 
			this.checkBoxFinished.AutoSize = true;
			this.checkBoxFinished.Location = new System.Drawing.Point(3, 156);
			this.checkBoxFinished.Name = "checkBoxFinished";
			this.checkBoxFinished.Size = new System.Drawing.Size(65, 17);
			this.checkBoxFinished.TabIndex = 7;
			this.checkBoxFinished.Text = "Finished";
			this.checkBoxFinished.UseVisualStyleBackColor = true;
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(3, 3);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
			this.textBoxTitle.TabIndex = 8;
			// 
			// textBoxCollaborators
			// 
			this.textBoxCollaborators.Location = new System.Drawing.Point(3, 29);
			this.textBoxCollaborators.Name = "textBoxCollaborators";
			this.textBoxCollaborators.Size = new System.Drawing.Size(100, 20);
			this.textBoxCollaborators.TabIndex = 9;
			// 
			// textBoxType
			// 
			this.textBoxType.Location = new System.Drawing.Point(3, 78);
			this.textBoxType.Name = "textBoxType";
			this.textBoxType.Size = new System.Drawing.Size(100, 20);
			this.textBoxType.TabIndex = 10;
			// 
			// textBoxLocation
			// 
			this.textBoxLocation.Location = new System.Drawing.Point(3, 104);
			this.textBoxLocation.Name = "textBoxLocation";
			this.textBoxLocation.Size = new System.Drawing.Size(100, 20);
			this.textBoxLocation.TabIndex = 11;
			// 
			// textBoxPublicLocation
			// 
			this.textBoxPublicLocation.Location = new System.Drawing.Point(3, 130);
			this.textBoxPublicLocation.Name = "textBoxPublicLocation";
			this.textBoxPublicLocation.Size = new System.Drawing.Size(100, 20);
			this.textBoxPublicLocation.TabIndex = 12;
			// 
			// AddMyWork
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxPublicLocation);
			this.Controls.Add(this.textBoxLocation);
			this.Controls.Add(this.textBoxType);
			this.Controls.Add(this.textBoxCollaborators);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.checkBoxFinished);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.checkBoxPublic);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAdd);
			this.Name = "AddMyWork";
			this.Size = new System.Drawing.Size(190, 242);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBoxPublic;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox checkBoxFinished;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.TextBox textBoxCollaborators;
		private System.Windows.Forms.TextBox textBoxType;
		private System.Windows.Forms.TextBox textBoxLocation;
		private System.Windows.Forms.TextBox textBoxPublicLocation;
	}
}
