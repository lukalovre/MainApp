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
			this.dataGridViewTVShows = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageAll = new System.Windows.Forms.TabPage();
			this.tabPageWatching = new System.Windows.Forms.TabPage();
			this.dataGridViewWatching = new System.Windows.Forms.DataGridView();
			this.tabPageOngoing = new System.Windows.Forms.TabPage();
			this.dataGridViewOngoing = new System.Windows.Forms.DataGridView();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.checkBoxUpdateSeason = new System.Windows.Forms.CheckBox();
			this.tvShowInfo1 = new MainApp.TVShows.TVShowInfo();
			this.textBoxImdb = new System.Windows.Forms.TextBox();
			this.tabPageYouTube = new System.Windows.Forms.TabPage();
			this.dataGridViewYouTube = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTVShows)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPageAll.SuspendLayout();
			this.tabPageWatching.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewWatching)).BeginInit();
			this.tabPageOngoing.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOngoing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
			this.tabPageYouTube.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewYouTube)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewTVShows
			// 
			this.dataGridViewTVShows.AllowUserToAddRows = false;
			this.dataGridViewTVShows.AllowUserToDeleteRows = false;
			this.dataGridViewTVShows.AllowUserToResizeRows = false;
			this.dataGridViewTVShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTVShows.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewTVShows.Location = new System.Drawing.Point(4, 5);
			this.dataGridViewTVShows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewTVShows.Name = "dataGridViewTVShows";
			this.dataGridViewTVShows.ReadOnly = true;
			this.dataGridViewTVShows.RowHeadersWidth = 51;
			this.dataGridViewTVShows.Size = new System.Drawing.Size(784, 1266);
			this.dataGridViewTVShows.TabIndex = 12;
			this.dataGridViewTVShows.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageAll);
			this.tabControl1.Controls.Add(this.tabPageWatching);
			this.tabControl1.Controls.Add(this.tabPageOngoing);
			this.tabControl1.Controls.Add(this.tabPageYouTube);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 1309);
			this.tabControl1.TabIndex = 17;
			// 
			// tabPageAll
			// 
			this.tabPageAll.Controls.Add(this.dataGridViewTVShows);
			this.tabPageAll.Location = new System.Drawing.Point(4, 29);
			this.tabPageAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Name = "tabPageAll";
			this.tabPageAll.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAll.Size = new System.Drawing.Size(792, 1276);
			this.tabPageAll.TabIndex = 0;
			this.tabPageAll.Text = "All";
			this.tabPageAll.UseVisualStyleBackColor = true;
			// 
			// tabPageWatching
			// 
			this.tabPageWatching.Controls.Add(this.dataGridViewWatching);
			this.tabPageWatching.Location = new System.Drawing.Point(4, 29);
			this.tabPageWatching.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageWatching.Name = "tabPageWatching";
			this.tabPageWatching.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageWatching.Size = new System.Drawing.Size(792, 1276);
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
			this.dataGridViewWatching.Size = new System.Drawing.Size(784, 1266);
			this.dataGridViewWatching.TabIndex = 0;
			this.dataGridViewWatching.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// tabPageOngoing
			// 
			this.tabPageOngoing.Controls.Add(this.dataGridViewOngoing);
			this.tabPageOngoing.Location = new System.Drawing.Point(4, 29);
			this.tabPageOngoing.Name = "tabPageOngoing";
			this.tabPageOngoing.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOngoing.Size = new System.Drawing.Size(792, 1276);
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
			this.dataGridViewOngoing.Size = new System.Drawing.Size(786, 1270);
			this.dataGridViewOngoing.TabIndex = 0;
			this.dataGridViewOngoing.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(807, 785);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(97, 38);
			this.buttonUpdate.TabIndex = 19;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
			// 
			// numericUpDownYear
			// 
			this.numericUpDownYear.Location = new System.Drawing.Point(807, 866);
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
			this.checkBoxUpdateSeason.Location = new System.Drawing.Point(910, 793);
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
			this.tvShowInfo1.Size = new System.Drawing.Size(996, 779);
			this.tvShowInfo1.TabIndex = 20;
			// 
			// textBoxImdb
			// 
			this.textBoxImdb.Location = new System.Drawing.Point(971, 866);
			this.textBoxImdb.Name = "textBoxImdb";
			this.textBoxImdb.Size = new System.Drawing.Size(100, 26);
			this.textBoxImdb.TabIndex = 23;
			this.textBoxImdb.TextChanged += new System.EventHandler(this.TextBoxImdb_TextChanged);
			// 
			// tabPageYouTube
			// 
			this.tabPageYouTube.Controls.Add(this.dataGridViewYouTube);
			this.tabPageYouTube.Location = new System.Drawing.Point(4, 29);
			this.tabPageYouTube.Name = "tabPageYouTube";
			this.tabPageYouTube.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageYouTube.Size = new System.Drawing.Size(792, 1276);
			this.tabPageYouTube.TabIndex = 3;
			this.tabPageYouTube.Text = "YouTube";
			this.tabPageYouTube.UseVisualStyleBackColor = true;
			// 
			// dataGridViewYouTube
			// 
			this.dataGridViewYouTube.Location = new System.Drawing.Point(7, 7);
			this.dataGridViewYouTube.Name = "dataGridViewYouTube";
			this.dataGridViewYouTube.Size = new System.Drawing.Size(760, 1215);
			this.dataGridViewYouTube.TabIndex = 0;
			this.dataGridViewYouTube.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
			// 
			// TVShowsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxImdb);
			this.Controls.Add(this.checkBoxUpdateSeason);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.tvShowInfo1);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "TVShowsControl";
			this.Size = new System.Drawing.Size(1796, 1309);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTVShows)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPageAll.ResumeLayout(false);
			this.tabPageWatching.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewWatching)).EndInit();
			this.tabPageOngoing.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOngoing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			this.tabPageYouTube.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewYouTube)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal DataGridView dataGridViewTVShows;
		public System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageAll;
		private System.Windows.Forms.TabPage tabPageWatching;
		private DataGridView dataGridViewWatching;
		private Button buttonUpdate;
		private MainApp.TVShows.TVShowInfo tvShowInfo1;
		private NumericUpDown numericUpDownYear;
		private CheckBox checkBoxUpdateSeason;
		private TabPage tabPageOngoing;
		private DataGridView dataGridViewOngoing;
		private TextBox textBoxImdb;
		private TabPage tabPageYouTube;
		private DataGridView dataGridViewYouTube;
	}
}
