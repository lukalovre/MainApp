using System.Windows.Forms;

namespace MainApp.TV_Shows
{
	partial class TVShowsControl
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageWatching = new System.Windows.Forms.TabPage();
			this.dataGridViewWatching = new System.Windows.Forms.DataGridView();
			this.tabPageOngoing = new System.Windows.Forms.TabPage();
			this.dataGridViewOngoing = new System.Windows.Forms.DataGridView();
			this.tabPageYouTube = new System.Windows.Forms.TabPage();
			this.dataGridViewYouTube = new System.Windows.Forms.DataGridView();
			this.tabPageWaiting = new System.Windows.Forms.TabPage();
			this.dataGridViewWaiting = new System.Windows.Forms.DataGridView();
			this.tabPageAll = new System.Windows.Forms.TabPage();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.checkBoxUpdateSeason = new System.Windows.Forms.CheckBox();
			this.tvShowInfo1 = new MainApp.TVShows.TVShowInfo();
			this.textBoxImdb = new System.Windows.Forms.TextBox();
			this.textBoxFilter = new System.Windows.Forms.TextBox();
			this.addButton1 = new MainApp.CommonControls.AddButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPageWatching.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewWatching)).BeginInit();
			this.tabPageOngoing.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOngoing)).BeginInit();
			this.tabPageYouTube.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewYouTube)).BeginInit();
			this.tabPageWaiting.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaiting)).BeginInit();
			this.tabPageAll.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAll
			// 
			this.dataGridViewAll.AllowUserToAddRows = false;
			this.dataGridViewAll.AllowUserToDeleteRows = false;
			this.dataGridViewAll.AllowUserToResizeRows = false;
			this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAll.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewAll.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewAll.Name = "dataGridViewAll";
			this.dataGridViewAll.ReadOnly = true;
			this.dataGridViewAll.RowHeadersWidth = 51;
			this.dataGridViewAll.Size = new System.Drawing.Size(784, 981);
			this.dataGridViewAll.TabIndex = 12;
			this.dataGridViewAll.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageWatching);
			this.tabControl1.Controls.Add(this.tabPageOngoing);
			this.tabControl1.Controls.Add(this.tabPageYouTube);
			this.tabControl1.Controls.Add(this.tabPageWaiting);
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 1024);
			this.tabControl1.TabIndex = 17;
			// 
			// tabPageWatching
			// 
			this.tabPageWatching.Controls.Add(this.dataGridViewWatching);
			this.tabPageWatching.Location = new System.Drawing.Point(4, 29);
			this.tabPageWatching.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageWatching.Name = "tabPageWatching";
			this.tabPageWatching.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageWatching.Size = new System.Drawing.Size(792, 991);
			this.tabPageWatching.TabIndex = 1;
			this.tabPageWatching.Text = "Watching";
			this.tabPageWatching.UseVisualStyleBackColor = true;
			// 
			// dataGridViewWatching
			// 
			this.dataGridViewWatching.AllowUserToAddRows = false;
			this.dataGridViewWatching.AllowUserToDeleteRows = false;
			this.dataGridViewWatching.AllowUserToResizeRows = false;
			this.dataGridViewWatching.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewWatching.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewWatching.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewWatching.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewWatching.Name = "dataGridViewWatching";
			this.dataGridViewWatching.ReadOnly = true;
			this.dataGridViewWatching.RowHeadersWidth = 51;
			this.dataGridViewWatching.Size = new System.Drawing.Size(784, 981);
			this.dataGridViewWatching.TabIndex = 0;
			this.dataGridViewWatching.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageOngoing
			// 
			this.tabPageOngoing.Controls.Add(this.dataGridViewOngoing);
			this.tabPageOngoing.Location = new System.Drawing.Point(4, 29);
			this.tabPageOngoing.Name = "tabPageOngoing";
			this.tabPageOngoing.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOngoing.Size = new System.Drawing.Size(792, 991);
			this.tabPageOngoing.TabIndex = 2;
			this.tabPageOngoing.Text = "Ongoing";
			this.tabPageOngoing.UseVisualStyleBackColor = true;
			// 
			// dataGridViewOngoing
			// 
			this.dataGridViewOngoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOngoing.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewOngoing.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewOngoing.Name = "dataGridViewOngoing";
			this.dataGridViewOngoing.RowHeadersWidth = 62;
			this.dataGridViewOngoing.RowTemplate.Height = 28;
			this.dataGridViewOngoing.Size = new System.Drawing.Size(786, 985);
			this.dataGridViewOngoing.TabIndex = 0;
			this.dataGridViewOngoing.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageYouTube
			// 
			this.tabPageYouTube.Controls.Add(this.dataGridViewYouTube);
			this.tabPageYouTube.Location = new System.Drawing.Point(4, 29);
			this.tabPageYouTube.Name = "tabPageYouTube";
			this.tabPageYouTube.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageYouTube.Size = new System.Drawing.Size(792, 991);
			this.tabPageYouTube.TabIndex = 3;
			this.tabPageYouTube.Text = "YouTube";
			this.tabPageYouTube.UseVisualStyleBackColor = true;
			// 
			// dataGridViewYouTube
			// 
			this.dataGridViewYouTube.ColumnHeadersHeight = 34;
			this.dataGridViewYouTube.Location = new System.Drawing.Point(7, 7);
			this.dataGridViewYouTube.Name = "dataGridViewYouTube";
			this.dataGridViewYouTube.RowHeadersWidth = 62;
			this.dataGridViewYouTube.Size = new System.Drawing.Size(760, 1215);
			this.dataGridViewYouTube.TabIndex = 0;
			this.dataGridViewYouTube.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageWaiting
			// 
			this.tabPageWaiting.Controls.Add(this.dataGridViewWaiting);
			this.tabPageWaiting.Location = new System.Drawing.Point(4, 29);
			this.tabPageWaiting.Name = "tabPageWaiting";
			this.tabPageWaiting.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageWaiting.Size = new System.Drawing.Size(792, 991);
			this.tabPageWaiting.TabIndex = 4;
			this.tabPageWaiting.Text = "Waiting";
			this.tabPageWaiting.UseVisualStyleBackColor = true;
			// 
			// dataGridViewWaiting
			// 
			this.dataGridViewWaiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewWaiting.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewWaiting.Name = "dataGridViewWaiting";
			this.dataGridViewWaiting.RowHeadersWidth = 62;
			this.dataGridViewWaiting.RowTemplate.Height = 28;
			this.dataGridViewWaiting.Size = new System.Drawing.Size(786, 985);
			this.dataGridViewWaiting.TabIndex = 0;
			this.dataGridViewWaiting.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageAll
			// 
			this.tabPageAll.Controls.Add(this.dataGridViewAll);
			this.tabPageAll.Location = new System.Drawing.Point(4, 29);
			this.tabPageAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Name = "tabPageAll";
			this.tabPageAll.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Size = new System.Drawing.Size(792, 991);
			this.tabPageAll.TabIndex = 0;
			this.tabPageAll.Text = "All";
			this.tabPageAll.UseVisualStyleBackColor = true;
			// 
			// numericUpDownYear
			// 
			this.numericUpDownYear.Location = new System.Drawing.Point(805, 867);
			this.numericUpDownYear.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
			this.numericUpDownYear.Name = "numericUpDownYear";
			this.numericUpDownYear.Size = new System.Drawing.Size(120, 26);
			this.numericUpDownYear.TabIndex = 21;
			this.numericUpDownYear.ValueChanged += new System.EventHandler(this.NumericUpDownYear_ValueChanged);
			// 
			// checkBoxUpdateSeason
			// 
			this.checkBoxUpdateSeason.AutoSize = true;
			this.checkBoxUpdateSeason.Location = new System.Drawing.Point(808, 778);
			this.checkBoxUpdateSeason.Name = "checkBoxUpdateSeason";
			this.checkBoxUpdateSeason.Size = new System.Drawing.Size(144, 24);
			this.checkBoxUpdateSeason.TabIndex = 22;
			this.checkBoxUpdateSeason.Text = "Update season";
			this.checkBoxUpdateSeason.UseVisualStyleBackColor = true;
			// 
			// tvShowInfo1
			// 
			this.tvShowInfo1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tvShowInfo1.Location = new System.Drawing.Point(800, 0);
			this.tvShowInfo1.Name = "tvShowInfo1";
			this.tvShowInfo1.Size = new System.Drawing.Size(735, 788);
			this.tvShowInfo1.TabIndex = 20;
			// 
			// textBoxImdb
			// 
			this.textBoxImdb.Location = new System.Drawing.Point(969, 867);
			this.textBoxImdb.Name = "textBoxImdb";
			this.textBoxImdb.Size = new System.Drawing.Size(100, 26);
			this.textBoxImdb.TabIndex = 23;
			this.textBoxImdb.TextChanged += new System.EventHandler(this.TextBoxImdb_TextChanged);
			// 
			// textBoxFilter
			// 
			this.textBoxFilter.Location = new System.Drawing.Point(808, 928);
			this.textBoxFilter.Name = "textBoxFilter";
			this.textBoxFilter.Size = new System.Drawing.Size(100, 26);
			this.textBoxFilter.TabIndex = 24;
			this.textBoxFilter.TextChanged += new System.EventHandler(this.TextBoxFilter_TextChanged);
			// 
			// addButton1
			// 
			this.addButton1.Location = new System.Drawing.Point(808, 808);
			this.addButton1.Name = "addButton1";
			this.addButton1.Size = new System.Drawing.Size(315, 43);
			this.addButton1.TabIndex = 25;
			// 
			// TVShowsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.addButton1);
			this.Controls.Add(this.textBoxFilter);
			this.Controls.Add(this.textBoxImdb);
			this.Controls.Add(this.checkBoxUpdateSeason);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.tvShowInfo1);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "TVShowsControl";
			this.Size = new System.Drawing.Size(1535, 1024);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPageWatching.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewWatching)).EndInit();
			this.tabPageOngoing.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOngoing)).EndInit();
			this.tabPageYouTube.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewYouTube)).EndInit();
			this.tabPageWaiting.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaiting)).EndInit();
			this.tabPageAll.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal DataGridView dataGridViewAll;
		public System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageAll;
		private System.Windows.Forms.TabPage tabPageWatching;
		private DataGridView dataGridViewWatching;
		private MainApp.TVShows.TVShowInfo tvShowInfo1;
		private NumericUpDown numericUpDownYear;
		private CheckBox checkBoxUpdateSeason;
		private TabPage tabPageOngoing;
		private DataGridView dataGridViewOngoing;
		private TextBox textBoxImdb;
		private TabPage tabPageYouTube;
		private DataGridView dataGridViewYouTube;
		private TabPage tabPageWaiting;
		private DataGridView dataGridViewWaiting;
		private TextBox textBoxFilter;
		private CommonControls.AddButton addButton1;
	}
}
