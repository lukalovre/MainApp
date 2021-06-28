namespace MainApp.Reports
{
	partial class MontlyReportsControl
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title17 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title18 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title19 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title20 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title21 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title22 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title23 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title24 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.chartMusic = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartGames = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartBooks = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartMyWorkProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartComics = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartMovies = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartTVShows = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartAllWeekly = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.chartMusic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartGames)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartBooks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartMyWorkProgress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartComics)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartMovies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartTVShows)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartAllWeekly)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(3, 4);
			this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(84, 29);
			this.buttonRefresh.TabIndex = 2;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
			// 
			// chartMusic
			// 
			chartArea17.Name = "ChartArea1";
			this.chartMusic.ChartAreas.Add(chartArea17);
			this.chartMusic.Location = new System.Drawing.Point(513, 349);
			this.chartMusic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chartMusic.Name = "chartMusic";
			series17.ChartArea = "ChartArea1";
			series17.IsValueShownAsLabel = true;
			series17.Name = "Music";
			this.chartMusic.Series.Add(series17);
			this.chartMusic.Size = new System.Drawing.Size(503, 301);
			this.chartMusic.TabIndex = 3;
			this.chartMusic.Text = "Music";
			title17.Name = "Title1";
			title17.Text = "Music";
			this.chartMusic.Titles.Add(title17);
			// 
			// chartGames
			// 
			chartArea18.Name = "ChartArea1";
			this.chartGames.ChartAreas.Add(chartArea18);
			this.chartGames.Location = new System.Drawing.Point(1023, 349);
			this.chartGames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chartGames.Name = "chartGames";
			series18.ChartArea = "ChartArea1";
			series18.IsValueShownAsLabel = true;
			series18.Name = "Music";
			this.chartGames.Series.Add(series18);
			this.chartGames.Size = new System.Drawing.Size(503, 301);
			this.chartGames.TabIndex = 4;
			this.chartGames.Text = "Games";
			title18.Name = "Title1";
			title18.Text = "Game";
			this.chartGames.Titles.Add(title18);
			// 
			// chartBooks
			// 
			chartArea19.Name = "ChartArea1";
			this.chartBooks.ChartAreas.Add(chartArea19);
			this.chartBooks.Location = new System.Drawing.Point(3, 349);
			this.chartBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chartBooks.Name = "chartBooks";
			series19.ChartArea = "ChartArea1";
			series19.IsValueShownAsLabel = true;
			series19.Name = "Music";
			this.chartBooks.Series.Add(series19);
			this.chartBooks.Size = new System.Drawing.Size(503, 301);
			this.chartBooks.TabIndex = 5;
			this.chartBooks.Text = "Music";
			title19.Name = "Title1";
			title19.Text = "Books";
			this.chartBooks.Titles.Add(title19);
			// 
			// chartMyWorkProgress
			// 
			chartArea20.Name = "ChartArea1";
			this.chartMyWorkProgress.ChartAreas.Add(chartArea20);
			this.chartMyWorkProgress.Location = new System.Drawing.Point(1023, 40);
			this.chartMyWorkProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chartMyWorkProgress.Name = "chartMyWorkProgress";
			series20.ChartArea = "ChartArea1";
			series20.IsValueShownAsLabel = true;
			series20.Name = "Music";
			this.chartMyWorkProgress.Series.Add(series20);
			this.chartMyWorkProgress.Size = new System.Drawing.Size(503, 301);
			this.chartMyWorkProgress.TabIndex = 6;
			this.chartMyWorkProgress.Text = "My work progress";
			title20.Name = "Title1";
			title20.Text = "My work progress";
			this.chartMyWorkProgress.Titles.Add(title20);
			// 
			// chartComics
			// 
			chartArea21.Name = "ChartArea1";
			this.chartComics.ChartAreas.Add(chartArea21);
			this.chartComics.Location = new System.Drawing.Point(3, 658);
			this.chartComics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chartComics.Name = "chartComics";
			series21.ChartArea = "ChartArea1";
			series21.IsValueShownAsLabel = true;
			series21.Name = "Music";
			this.chartComics.Series.Add(series21);
			this.chartComics.Size = new System.Drawing.Size(503, 301);
			this.chartComics.TabIndex = 7;
			this.chartComics.Text = "Comics";
			title21.Name = "Title1";
			title21.Text = "Comics";
			this.chartComics.Titles.Add(title21);
			// 
			// chartMovies
			// 
			chartArea22.Name = "ChartArea1";
			this.chartMovies.ChartAreas.Add(chartArea22);
			this.chartMovies.Location = new System.Drawing.Point(513, 658);
			this.chartMovies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chartMovies.Name = "chartMovies";
			series22.ChartArea = "ChartArea1";
			series22.IsValueShownAsLabel = true;
			series22.Name = "Music";
			this.chartMovies.Series.Add(series22);
			this.chartMovies.Size = new System.Drawing.Size(503, 301);
			this.chartMovies.TabIndex = 8;
			this.chartMovies.Text = "Movies";
			title22.Name = "Title1";
			title22.Text = "Movies";
			this.chartMovies.Titles.Add(title22);
			// 
			// chartTVShows
			// 
			chartArea23.Name = "ChartArea1";
			this.chartTVShows.ChartAreas.Add(chartArea23);
			this.chartTVShows.Location = new System.Drawing.Point(1023, 658);
			this.chartTVShows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chartTVShows.Name = "chartTVShows";
			series23.ChartArea = "ChartArea1";
			series23.IsValueShownAsLabel = true;
			series23.Name = "Music";
			this.chartTVShows.Series.Add(series23);
			this.chartTVShows.Size = new System.Drawing.Size(503, 301);
			this.chartTVShows.TabIndex = 9;
			this.chartTVShows.Text = "TV Shows";
			title23.Name = "Title1";
			title23.Text = "TV Shows";
			this.chartTVShows.Titles.Add(title23);
			// 
			// chartAllWeekly
			// 
			chartArea24.Name = "ChartArea1";
			this.chartAllWeekly.ChartAreas.Add(chartArea24);
			this.chartAllWeekly.Location = new System.Drawing.Point(3, 40);
			this.chartAllWeekly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chartAllWeekly.Name = "chartAllWeekly";
			series24.ChartArea = "ChartArea1";
			series24.IsValueShownAsLabel = true;
			series24.Name = "Music";
			this.chartAllWeekly.Series.Add(series24);
			this.chartAllWeekly.Size = new System.Drawing.Size(503, 301);
			this.chartAllWeekly.TabIndex = 10;
			this.chartAllWeekly.Text = "This month progress";
			title24.Name = "Title1";
			title24.Text = "This month progress";
			this.chartAllWeekly.Titles.Add(title24);
			// 
			// numericUpDownYear
			// 
			this.numericUpDownYear.Location = new System.Drawing.Point(94, 4);
			this.numericUpDownYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericUpDownYear.Name = "numericUpDownYear";
			this.numericUpDownYear.Size = new System.Drawing.Size(67, 26);
			this.numericUpDownYear.TabIndex = 11;
			this.numericUpDownYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
			this.numericUpDownYear.ValueChanged += new System.EventHandler(this.NumericUpDownYear_ValueChanged);
			// 
			// MontlyReports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.chartAllWeekly);
			this.Controls.Add(this.chartTVShows);
			this.Controls.Add(this.chartMovies);
			this.Controls.Add(this.chartComics);
			this.Controls.Add(this.chartMyWorkProgress);
			this.Controls.Add(this.chartBooks);
			this.Controls.Add(this.chartGames);
			this.Controls.Add(this.chartMusic);
			this.Controls.Add(this.buttonRefresh);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MontlyReports";
			this.Size = new System.Drawing.Size(1545, 1038);
			this.Load += new System.EventHandler(this.MonthlyReports_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartMusic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartGames)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartBooks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartMyWorkProgress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartComics)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartMovies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartTVShows)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartAllWeekly)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartMusic;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartGames;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartBooks;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartMyWorkProgress;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartComics;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartMovies;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartTVShows;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartAllWeekly;
		private System.Windows.Forms.NumericUpDown numericUpDownYear;
	}
}
