namespace MainApp.StatsControls
{
    partial class YearSummary
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
			this.tabPageGames = new System.Windows.Forms.TabPage();
			this.tabPageMovies = new System.Windows.Forms.TabPage();
			this.tabPageComics = new System.Windows.Forms.TabPage();
			this.tabPageTVShows = new System.Windows.Forms.TabPage();
			this.tabPageBooks = new System.Windows.Forms.TabPage();
			this.tabPageMusic = new System.Windows.Forms.TabPage();
			this.gameSummaryControl1 = new MainApp.StatsControls.SummaryControls.GameSummaryControl();
			this.tabControl1.SuspendLayout();
			this.tabPageGames.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageGames);
			this.tabControl1.Controls.Add(this.tabPageMovies);
			this.tabControl1.Controls.Add(this.tabPageComics);
			this.tabControl1.Controls.Add(this.tabPageTVShows);
			this.tabControl1.Controls.Add(this.tabPageBooks);
			this.tabControl1.Controls.Add(this.tabPageMusic);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1405, 1049);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageGames
			// 
			this.tabPageGames.Controls.Add(this.gameSummaryControl1);
			this.tabPageGames.Location = new System.Drawing.Point(4, 29);
			this.tabPageGames.Name = "tabPageGames";
			this.tabPageGames.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGames.Size = new System.Drawing.Size(1397, 1016);
			this.tabPageGames.TabIndex = 0;
			this.tabPageGames.Text = "Games";
			this.tabPageGames.UseVisualStyleBackColor = true;
			// 
			// tabPageMovies
			// 
			this.tabPageMovies.Location = new System.Drawing.Point(4, 29);
			this.tabPageMovies.Name = "tabPageMovies";
			this.tabPageMovies.Size = new System.Drawing.Size(1397, 1016);
			this.tabPageMovies.TabIndex = 3;
			this.tabPageMovies.Text = "Movies";
			this.tabPageMovies.UseVisualStyleBackColor = true;
			// 
			// tabPageComics
			// 
			this.tabPageComics.Location = new System.Drawing.Point(4, 29);
			this.tabPageComics.Name = "tabPageComics";
			this.tabPageComics.Size = new System.Drawing.Size(1397, 1016);
			this.tabPageComics.TabIndex = 4;
			this.tabPageComics.Text = "Comics";
			this.tabPageComics.UseVisualStyleBackColor = true;
			// 
			// tabPageTVShows
			// 
			this.tabPageTVShows.Location = new System.Drawing.Point(4, 29);
			this.tabPageTVShows.Name = "tabPageTVShows";
			this.tabPageTVShows.Size = new System.Drawing.Size(1397, 1016);
			this.tabPageTVShows.TabIndex = 2;
			this.tabPageTVShows.Text = "TV Shows";
			this.tabPageTVShows.UseVisualStyleBackColor = true;
			// 
			// tabPageBooks
			// 
			this.tabPageBooks.Location = new System.Drawing.Point(4, 29);
			this.tabPageBooks.Name = "tabPageBooks";
			this.tabPageBooks.Size = new System.Drawing.Size(1397, 1016);
			this.tabPageBooks.TabIndex = 5;
			this.tabPageBooks.Text = "Books";
			this.tabPageBooks.UseVisualStyleBackColor = true;
			// 
			// tabPageMusic
			// 
			this.tabPageMusic.Location = new System.Drawing.Point(4, 29);
			this.tabPageMusic.Name = "tabPageMusic";
			this.tabPageMusic.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMusic.Size = new System.Drawing.Size(1397, 1016);
			this.tabPageMusic.TabIndex = 1;
			this.tabPageMusic.Text = "Music";
			this.tabPageMusic.UseVisualStyleBackColor = true;
			// 
			// gameSummaryControl1
			// 
			this.gameSummaryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gameSummaryControl1.Location = new System.Drawing.Point(3, 3);
			this.gameSummaryControl1.Name = "gameSummaryControl1";
			this.gameSummaryControl1.Size = new System.Drawing.Size(1391, 1010);
			this.gameSummaryControl1.TabIndex = 0;
			// 
			// YearSummary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.Name = "YearSummary";
			this.Size = new System.Drawing.Size(1405, 1049);
			this.tabControl1.ResumeLayout(false);
			this.tabPageGames.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGames;
        private System.Windows.Forms.TabPage tabPageMusic;
        private System.Windows.Forms.TabPage tabPageMovies;
        private System.Windows.Forms.TabPage tabPageComics;
        private System.Windows.Forms.TabPage tabPageTVShows;
        private System.Windows.Forms.TabPage tabPageBooks;
        private SummaryControls.GameSummaryControl gameSummaryControl1;
	}
}
