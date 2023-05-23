namespace MainApp.My_work_progress
{
	partial class MyWorkProgressInfoControl
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
			this.label3 = new System.Windows.Forms.Label();
			this.labelTime = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxType = new System.Windows.Forms.TextBox();
			this.checkBoxOngoing = new System.Windows.Forms.CheckBox();
			this.eventControl1 = new MainApp.EventControl();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(163, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Title";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(163, 46);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Type";
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.Location = new System.Drawing.Point(4, 85);
			this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(43, 20);
			this.labelTime.TabIndex = 6;
			this.labelTime.Text = "Time";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(4, 5);
			this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(148, 26);
			this.textBoxTitle.TabIndex = 8;
			// 
			// textBoxType
			// 
			this.textBoxType.Location = new System.Drawing.Point(4, 42);
			this.textBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxType.Name = "textBoxType";
			this.textBoxType.Size = new System.Drawing.Size(148, 26);
			this.textBoxType.TabIndex = 10;
			// 
			// checkBoxOngoing
			// 
			this.checkBoxOngoing.AutoSize = true;
			this.checkBoxOngoing.Location = new System.Drawing.Point(8, 120);
			this.checkBoxOngoing.Name = "checkBoxOngoing";
			this.checkBoxOngoing.Size = new System.Drawing.Size(95, 24);
			this.checkBoxOngoing.TabIndex = 11;
			this.checkBoxOngoing.Text = "Ongoing";
			this.checkBoxOngoing.UseVisualStyleBackColor = true;
			this.checkBoxOngoing.CheckedChanged += new System.EventHandler(this.CheckBoxOngoing_CheckedChanged);
			// 
			// eventControl1
			// 
			this.eventControl1.Location = new System.Drawing.Point(8, 161);
			this.eventControl1.Name = "eventControl1";
			this.eventControl1.Size = new System.Drawing.Size(193, 291);
			this.eventControl1.TabIndex = 12;
			// 
			// MyWorkProgressInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.eventControl1);
			this.Controls.Add(this.checkBoxOngoing);
			this.Controls.Add(this.textBoxType);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.labelTime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MyWorkProgressInfoControl";
			this.Size = new System.Drawing.Size(222, 450);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.TextBox textBoxType;
		private System.Windows.Forms.CheckBox checkBoxOngoing;
		private EventControl eventControl1;
	}
}
