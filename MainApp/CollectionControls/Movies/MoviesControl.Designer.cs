namespace MainApp.CollectionControls
{
    partial class MoviesControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAll = new System.Windows.Forms.TabPage();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.tabPageUnwatched = new System.Windows.Forms.TabPage();
            this.movieInfoControl1 = new MainApp.CollectionControls.MovieInfoControl();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxImdb = new System.Windows.Forms.TextBox();
            this.dataGridViewUnwatched = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.tabPageUnwatched.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnwatched)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAll);
            this.tabControl1.Controls.Add(this.tabPageUnwatched);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 1202);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAll
            // 
            this.tabPageAll.Controls.Add(this.dataGridViewAll);
            this.tabPageAll.Location = new System.Drawing.Point(4, 29);
            this.tabPageAll.Name = "tabPageAll";
            this.tabPageAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAll.Size = new System.Drawing.Size(835, 1169);
            this.tabPageAll.TabIndex = 0;
            this.tabPageAll.Text = "All";
            this.tabPageAll.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.AllowUserToDeleteRows = false;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(4, 7);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.ReadOnly = true;
            this.dataGridViewAll.RowHeadersWidth = 62;
            this.dataGridViewAll.RowTemplate.Height = 28;
            this.dataGridViewAll.Size = new System.Drawing.Size(585, 835);
            this.dataGridViewAll.TabIndex = 0;
            this.dataGridViewAll.SelectionChanged += new System.EventHandler(this.DataGridViewAll_SelectionChanged);
            // 
            // tabPageUnwatched
            // 
            this.tabPageUnwatched.Controls.Add(this.dataGridViewUnwatched);
            this.tabPageUnwatched.Location = new System.Drawing.Point(4, 29);
            this.tabPageUnwatched.Name = "tabPageUnwatched";
            this.tabPageUnwatched.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUnwatched.Size = new System.Drawing.Size(835, 1169);
            this.tabPageUnwatched.TabIndex = 1;
            this.tabPageUnwatched.Text = "Unwatched";
            this.tabPageUnwatched.UseVisualStyleBackColor = true;
            // 
            // movieInfoControl1
            // 
            this.movieInfoControl1.Location = new System.Drawing.Point(853, 33);
            this.movieInfoControl1.Name = "movieInfoControl1";
            this.movieInfoControl1.Size = new System.Drawing.Size(322, 374);
            this.movieInfoControl1.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(871, 460);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 36);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxImdb
            // 
            this.textBoxImdb.Location = new System.Drawing.Point(871, 416);
            this.textBoxImdb.Name = "textBoxImdb";
            this.textBoxImdb.Size = new System.Drawing.Size(100, 26);
            this.textBoxImdb.TabIndex = 3;
            this.textBoxImdb.TextChanged += new System.EventHandler(this.TextBoxImdb_TextChanged);
            // 
            // dataGridViewUnwatched
            // 
            this.dataGridViewUnwatched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnwatched.Location = new System.Drawing.Point(269, 258);
            this.dataGridViewUnwatched.Name = "dataGridViewUnwatched";
            this.dataGridViewUnwatched.RowHeadersWidth = 62;
            this.dataGridViewUnwatched.RowTemplate.Height = 28;
            this.dataGridViewUnwatched.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewUnwatched.TabIndex = 0;
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxImdb);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.movieInfoControl1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(1256, 1209);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.tabPageUnwatched.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnwatched)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAll;
        private System.Windows.Forms.TabPage tabPageUnwatched;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private MovieInfoControl movieInfoControl1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxImdb;
        private System.Windows.Forms.DataGridView dataGridViewUnwatched;
    }
}
