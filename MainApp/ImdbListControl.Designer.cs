
namespace MainApp
{
	partial class ImdbListControl
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.buttonOpenLink = new System.Windows.Forms.Button();
			this.textBoxFilter = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeight = 34;
			this.dataGridView.Location = new System.Drawing.Point(3, 50);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.Size = new System.Drawing.Size(726, 580);
			this.dataGridView.TabIndex = 0;
			// 
			// buttonOpenLink
			// 
			this.buttonOpenLink.Location = new System.Drawing.Point(190, 4);
			this.buttonOpenLink.Name = "buttonOpenLink";
			this.buttonOpenLink.Size = new System.Drawing.Size(118, 40);
			this.buttonOpenLink.TabIndex = 1;
			this.buttonOpenLink.Text = "Open link";
			this.buttonOpenLink.UseVisualStyleBackColor = true;
			this.buttonOpenLink.Click += new System.EventHandler(this.ButtonOpenLink_Click);
			// 
			// textBoxFilter
			// 
			this.textBoxFilter.Location = new System.Drawing.Point(3, 11);
			this.textBoxFilter.Name = "textBoxFilter";
			this.textBoxFilter.Size = new System.Drawing.Size(181, 26);
			this.textBoxFilter.TabIndex = 2;
			this.textBoxFilter.TextChanged += new System.EventHandler(this.TextBoxFilter_TextChanged);
			// 
			// ImdbListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.textBoxFilter);
			this.Controls.Add(this.buttonOpenLink);
			this.Name = "ImdbListControl";
			this.Size = new System.Drawing.Size(878, 1076);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button buttonOpenLink;
		private System.Windows.Forms.TextBox textBoxFilter;
	}
}
