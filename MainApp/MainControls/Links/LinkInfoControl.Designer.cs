namespace MainApp.MainControls
{
    partial class LinkInfoControl
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
			this.textBoxUrl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.comboBoxSubCategory = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelCreatedAt = new System.Windows.Forms.Label();
			this.eventControl1 = new MainApp.EventListControl();
			this.SuspendLayout();
			// 
			// textBoxUrl
			// 
			this.textBoxUrl.Location = new System.Drawing.Point(3, 46);
			this.textBoxUrl.Name = "textBoxUrl";
			this.textBoxUrl.Size = new System.Drawing.Size(413, 26);
			this.textBoxUrl.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(422, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Url";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(3, 3);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(230, 26);
			this.textBoxTitle.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(240, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Title";
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Location = new System.Drawing.Point(4, 103);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(229, 28);
			this.comboBoxCategory.TabIndex = 4;
			// 
			// comboBoxSubCategory
			// 
			this.comboBoxSubCategory.FormattingEnabled = true;
			this.comboBoxSubCategory.Location = new System.Drawing.Point(4, 137);
			this.comboBoxSubCategory.Name = "comboBoxSubCategory";
			this.comboBoxSubCategory.Size = new System.Drawing.Size(229, 28);
			this.comboBoxSubCategory.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(244, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Category";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(240, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Sub category";
			// 
			// labelCreatedAt
			// 
			this.labelCreatedAt.AutoSize = true;
			this.labelCreatedAt.Location = new System.Drawing.Point(3, 189);
			this.labelCreatedAt.Name = "labelCreatedAt";
			this.labelCreatedAt.Size = new System.Drawing.Size(92, 20);
			this.labelCreatedAt.TabIndex = 8;
			this.labelCreatedAt.Text = "Created at: ";
			// 
			// eventControl1
			// 
			this.eventControl1.Location = new System.Drawing.Point(7, 241);
			this.eventControl1.Name = "eventControl1";
			this.eventControl1.Size = new System.Drawing.Size(257, 233);
			this.eventControl1.TabIndex = 9;
			// 
			// LinkInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.eventControl1);
			this.Controls.Add(this.labelCreatedAt);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxSubCategory);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxUrl);
			this.Name = "LinkInfoControl";
			this.Size = new System.Drawing.Size(485, 509);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxSubCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCreatedAt;
		private EventListControl eventControl1;
	}
}
