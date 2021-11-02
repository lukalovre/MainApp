using System.Windows.Forms;

namespace MainApp.Collection
{
	partial class LibraryControl
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
			this.buttonReturned = new System.Windows.Forms.Button();
			this.libraryInfo = new MainApp.Collection.LibraryInfoControl();
			this.buttonAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAll
			// 
			this.dataGridViewAll.ColumnHeadersHeight = 34;
			this.dataGridViewAll.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridViewAll.Name = "dataGridViewAll";
			this.dataGridViewAll.RowHeadersWidth = 62;
			this.dataGridViewAll.Size = new System.Drawing.Size(780, 982);
			this.dataGridViewAll.TabIndex = 0;
			this.dataGridViewAll.SelectionChanged += new System.EventHandler(this.DataGridViewAll_SelectionChanged);
			// 
			// buttonReturned
			// 
			this.buttonReturned.Location = new System.Drawing.Point(876, 168);
			this.buttonReturned.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonReturned.Name = "buttonReturned";
			this.buttonReturned.Size = new System.Drawing.Size(94, 34);
			this.buttonReturned.TabIndex = 1;
			this.buttonReturned.Text = "Returned";
			this.buttonReturned.UseVisualStyleBackColor = true;
			this.buttonReturned.Click += new System.EventHandler(this.ButtonReturned_Click);
			// 
			// libraryInfo
			// 
			this.libraryInfo.Location = new System.Drawing.Point(788, 5);
			this.libraryInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.libraryInfo.Name = "libraryInfo";
			this.libraryInfo.Size = new System.Drawing.Size(202, 154);
			this.libraryInfo.TabIndex = 2;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(788, 168);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(82, 34);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// LibraryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.libraryInfo);
			this.Controls.Add(this.buttonReturned);
			this.Controls.Add(this.dataGridViewAll);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "LibraryControl";
			this.Size = new System.Drawing.Size(1205, 982);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dataGridViewAll;
		private System.Windows.Forms.Button buttonReturned;
		private LibraryInfoControl libraryInfo;
		private Button buttonAdd;
	}
}
