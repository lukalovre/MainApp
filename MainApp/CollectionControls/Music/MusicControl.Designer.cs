using System.Windows.Forms;

namespace MainApp.Collection
{
	partial class MusicControl
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
			this.dataGridViewAll = new System.Windows.Forms.DataGridView();
			this.musicInfo = new MainApp.Collection.MusicInfoControl();
			this.buttonAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAll
			// 
			this.dataGridViewAll.ColumnHeadersHeight = 34;
			this.dataGridViewAll.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewAll.Name = "dataGridViewAll";
			this.dataGridViewAll.RowHeadersWidth = 62;
			this.dataGridViewAll.Size = new System.Drawing.Size(1040, 888);
			this.dataGridViewAll.TabIndex = 0;
			this.dataGridViewAll.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// musicInfo
			// 
			this.musicInfo.Location = new System.Drawing.Point(1048, 5);
			this.musicInfo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.musicInfo.Name = "musicInfo";
			this.musicInfo.Size = new System.Drawing.Size(243, 275);
			this.musicInfo.TabIndex = 1;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(1048, 292);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(92, 43);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// MusicControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.musicInfo);
			this.Controls.Add(this.dataGridViewAll);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MusicControl";
			this.Size = new System.Drawing.Size(1335, 888);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dataGridViewAll;
		private MusicInfoControl musicInfo;
		private Button buttonAdd;
	}
}
