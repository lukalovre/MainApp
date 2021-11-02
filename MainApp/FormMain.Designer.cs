using System.Windows.Forms;

using MainApp.Collection.Books;
using MainApp.Collection;
using MainApp.Collection.Games;

namespace MainApp
{
	partial class FormMain
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabPageCollectionMusic = new System.Windows.Forms.TabPage();
			this.tabPageCollectionComics = new System.Windows.Forms.TabPage();
			this.tabPageCollectionGames = new System.Windows.Forms.TabPage();
			this.tabPageCollectionBooks = new System.Windows.Forms.TabPage();
			this.tabPageBooks = new System.Windows.Forms.TabPage();
			this.tabPageTVShows = new System.Windows.Forms.TabPage();
			this.tabPageGames = new System.Windows.Forms.TabPage();
			this.tabPageComics = new System.Windows.Forms.TabPage();
			this.tabPageMovies = new System.Windows.Forms.TabPage();
			this.tabPageMusic = new System.Windows.Forms.TabPage();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageStandup = new System.Windows.Forms.TabPage();
			this.tabPageMyWork = new System.Windows.Forms.TabPage();
			this.tabPageMyWorkProgress = new System.Windows.Forms.TabPage();
			this.tabPageMonthyReports = new System.Windows.Forms.TabPage();
			this.tabPageYearProgress = new System.Windows.Forms.TabPage();
			this.tabPage1001 = new System.Windows.Forms.TabPage();
			this.tabPageLibrary = new System.Windows.Forms.TabPage();
			this.tabControlAll = new System.Windows.Forms.TabControl();
			this.tabPageMain = new System.Windows.Forms.TabPage();
			this.tabPageCollection = new System.Windows.Forms.TabPage();
			this.tabControlCollection = new System.Windows.Forms.TabControl();
			this.Stats = new System.Windows.Forms.TabPage();
			this.tabControlStats = new System.Windows.Forms.TabControl();
			this.tabPageYearStats = new System.Windows.Forms.TabPage();
			this.tabPageTotal = new System.Windows.Forms.TabPage();
			this.musicControl1 = new MainApp.Musics.MusicControl();
			this.moviesControl1 = new MainApp.Movies.MoviesControl();
			this.comicsControl1 = new MainApp.Comics.ComicsControl();
			this.game1 = new MainApp.Games.GamesControl();
			this.tvShowsControl1 = new MainApp.TV_Shows.TVShowsControl();
			this.booksControl1 = new MainApp.Books.BooksControl();
			this.standup1 = new MainApp.Standups.StandupsControl();
			this.myWork1 = new MainApp.My_work.MyWorkControl();
			this.myWorkProgress1 = new MainApp.My_work_progress.MyWorkProgressControl();
			this.collectionBooks1 = new MainApp.Collection.Books.BooksControl();
			this.collectionGamesControl1 = new MainApp.Collection.Games.GamesControl();
			this.collectionComics1 = new MainApp.Collection.ComicsControl();
			this.music1 = new MainApp.Collection.MusicControl();
			this.library1 = new MainApp.Collection.LibraryControl();
			this.weeklyReports1 = new MainApp.Reports.MontlyReportsControl();
			this.yearProgress1 = new MainApp.Reports.YearProgressControl();
			this._10011 = new MainApp._1001._1001Control();
			this.yearStatsControl1 = new MainApp.Reports.YearStatsControl();
			this.total1 = new MainApp.StatsControls.Total();
			this.tabPageCollectionMusic.SuspendLayout();
			this.tabPageCollectionComics.SuspendLayout();
			this.tabPageCollectionGames.SuspendLayout();
			this.tabPageCollectionBooks.SuspendLayout();
			this.tabPageBooks.SuspendLayout();
			this.tabPageTVShows.SuspendLayout();
			this.tabPageGames.SuspendLayout();
			this.tabPageComics.SuspendLayout();
			this.tabPageMovies.SuspendLayout();
			this.tabPageMusic.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabPageStandup.SuspendLayout();
			this.tabPageMyWork.SuspendLayout();
			this.tabPageMyWorkProgress.SuspendLayout();
			this.tabPageMonthyReports.SuspendLayout();
			this.tabPageYearProgress.SuspendLayout();
			this.tabPage1001.SuspendLayout();
			this.tabPageLibrary.SuspendLayout();
			this.tabControlAll.SuspendLayout();
			this.tabPageMain.SuspendLayout();
			this.tabPageCollection.SuspendLayout();
			this.tabControlCollection.SuspendLayout();
			this.Stats.SuspendLayout();
			this.tabControlStats.SuspendLayout();
			this.tabPageYearStats.SuspendLayout();
			this.tabPageTotal.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPageCollectionMusic
			// 
			this.tabPageCollectionMusic.Controls.Add(this.music1);
			this.tabPageCollectionMusic.Location = new System.Drawing.Point(4, 29);
			this.tabPageCollectionMusic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionMusic.Name = "tabPageCollectionMusic";
			this.tabPageCollectionMusic.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionMusic.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageCollectionMusic.TabIndex = 9;
			this.tabPageCollectionMusic.Text = "Music";
			this.tabPageCollectionMusic.UseVisualStyleBackColor = true;
			// 
			// tabPageCollectionComics
			// 
			this.tabPageCollectionComics.Controls.Add(this.collectionComics1);
			this.tabPageCollectionComics.Location = new System.Drawing.Point(4, 29);
			this.tabPageCollectionComics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionComics.Name = "tabPageCollectionComics";
			this.tabPageCollectionComics.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionComics.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageCollectionComics.TabIndex = 8;
			this.tabPageCollectionComics.Text = "Comics";
			this.tabPageCollectionComics.UseVisualStyleBackColor = true;
			// 
			// tabPageCollectionGames
			// 
			this.tabPageCollectionGames.Controls.Add(this.collectionGamesControl1);
			this.tabPageCollectionGames.Location = new System.Drawing.Point(4, 29);
			this.tabPageCollectionGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionGames.Name = "tabPageCollectionGames";
			this.tabPageCollectionGames.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionGames.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageCollectionGames.TabIndex = 7;
			this.tabPageCollectionGames.Text = "Games";
			this.tabPageCollectionGames.UseVisualStyleBackColor = true;
			// 
			// tabPageCollectionBooks
			// 
			this.tabPageCollectionBooks.Controls.Add(this.collectionBooks1);
			this.tabPageCollectionBooks.Location = new System.Drawing.Point(4, 29);
			this.tabPageCollectionBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionBooks.Name = "tabPageCollectionBooks";
			this.tabPageCollectionBooks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionBooks.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageCollectionBooks.TabIndex = 6;
			this.tabPageCollectionBooks.Text = "Books";
			this.tabPageCollectionBooks.UseVisualStyleBackColor = true;
			// 
			// tabPageBooks
			// 
			this.tabPageBooks.Controls.Add(this.booksControl1);
			this.tabPageBooks.Location = new System.Drawing.Point(4, 29);
			this.tabPageBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageBooks.Name = "tabPageBooks";
			this.tabPageBooks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageBooks.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageBooks.TabIndex = 5;
			this.tabPageBooks.Text = "Books";
			this.tabPageBooks.UseVisualStyleBackColor = true;
			// 
			// tabPageTVShows
			// 
			this.tabPageTVShows.Controls.Add(this.tvShowsControl1);
			this.tabPageTVShows.Location = new System.Drawing.Point(4, 29);
			this.tabPageTVShows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageTVShows.Name = "tabPageTVShows";
			this.tabPageTVShows.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageTVShows.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageTVShows.TabIndex = 3;
			this.tabPageTVShows.Text = "TV Shows";
			this.tabPageTVShows.UseVisualStyleBackColor = true;
			// 
			// tabPageGames
			// 
			this.tabPageGames.Controls.Add(this.game1);
			this.tabPageGames.Location = new System.Drawing.Point(4, 29);
			this.tabPageGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageGames.Name = "tabPageGames";
			this.tabPageGames.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageGames.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageGames.TabIndex = 2;
			this.tabPageGames.Text = "Games";
			this.tabPageGames.UseVisualStyleBackColor = true;
			// 
			// tabPageComics
			// 
			this.tabPageComics.Controls.Add(this.comicsControl1);
			this.tabPageComics.Location = new System.Drawing.Point(4, 29);
			this.tabPageComics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageComics.Name = "tabPageComics";
			this.tabPageComics.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageComics.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageComics.TabIndex = 1;
			this.tabPageComics.Text = "Comics";
			this.tabPageComics.UseVisualStyleBackColor = true;
			// 
			// tabPageMovies
			// 
			this.tabPageMovies.Controls.Add(this.moviesControl1);
			this.tabPageMovies.Location = new System.Drawing.Point(4, 29);
			this.tabPageMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageMovies.Name = "tabPageMovies";
			this.tabPageMovies.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageMovies.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageMovies.TabIndex = 0;
			this.tabPageMovies.Text = "Movies";
			this.tabPageMovies.UseVisualStyleBackColor = true;
			// 
			// tabPageMusic
			// 
			this.tabPageMusic.Controls.Add(this.musicControl1);
			this.tabPageMusic.Location = new System.Drawing.Point(4, 29);
			this.tabPageMusic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageMusic.Name = "tabPageMusic";
			this.tabPageMusic.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageMusic.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageMusic.TabIndex = 4;
			this.tabPageMusic.Text = "Music";
			this.tabPageMusic.UseVisualStyleBackColor = true;
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageMusic);
			this.tabControlMain.Controls.Add(this.tabPageMovies);
			this.tabControlMain.Controls.Add(this.tabPageComics);
			this.tabControlMain.Controls.Add(this.tabPageGames);
			this.tabControlMain.Controls.Add(this.tabPageTVShows);
			this.tabControlMain.Controls.Add(this.tabPageBooks);
			this.tabControlMain.Controls.Add(this.tabPageStandup);
			this.tabControlMain.Controls.Add(this.tabPageMyWork);
			this.tabControlMain.Controls.Add(this.tabPageMyWorkProgress);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Location = new System.Drawing.Point(3, 3);
			this.tabControlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControlMain.Multiline = true;
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(1402, 1501);
			this.tabControlMain.TabIndex = 28;
			// 
			// tabPageStandup
			// 
			this.tabPageStandup.Controls.Add(this.standup1);
			this.tabPageStandup.Location = new System.Drawing.Point(4, 29);
			this.tabPageStandup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageStandup.Name = "tabPageStandup";
			this.tabPageStandup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageStandup.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageStandup.TabIndex = 10;
			this.tabPageStandup.Text = "Standup";
			this.tabPageStandup.UseVisualStyleBackColor = true;
			// 
			// tabPageMyWork
			// 
			this.tabPageMyWork.Controls.Add(this.myWork1);
			this.tabPageMyWork.Location = new System.Drawing.Point(4, 29);
			this.tabPageMyWork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageMyWork.Name = "tabPageMyWork";
			this.tabPageMyWork.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageMyWork.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageMyWork.TabIndex = 11;
			this.tabPageMyWork.Text = "My work";
			this.tabPageMyWork.UseVisualStyleBackColor = true;
			// 
			// tabPageMyWorkProgress
			// 
			this.tabPageMyWorkProgress.Controls.Add(this.myWorkProgress1);
			this.tabPageMyWorkProgress.Location = new System.Drawing.Point(4, 29);
			this.tabPageMyWorkProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPageMyWorkProgress.Name = "tabPageMyWorkProgress";
			this.tabPageMyWorkProgress.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPageMyWorkProgress.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageMyWorkProgress.TabIndex = 13;
			this.tabPageMyWorkProgress.Text = "My work progress";
			this.tabPageMyWorkProgress.UseVisualStyleBackColor = true;
			// 
			// tabPageMonthyReports
			// 
			this.tabPageMonthyReports.Controls.Add(this.weeklyReports1);
			this.tabPageMonthyReports.Location = new System.Drawing.Point(4, 29);
			this.tabPageMonthyReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPageMonthyReports.Name = "tabPageMonthyReports";
			this.tabPageMonthyReports.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPageMonthyReports.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageMonthyReports.TabIndex = 12;
			this.tabPageMonthyReports.Text = "Monthly reports";
			this.tabPageMonthyReports.UseVisualStyleBackColor = true;
			// 
			// tabPageYearProgress
			// 
			this.tabPageYearProgress.Controls.Add(this.yearProgress1);
			this.tabPageYearProgress.Location = new System.Drawing.Point(4, 29);
			this.tabPageYearProgress.Name = "tabPageYearProgress";
			this.tabPageYearProgress.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageYearProgress.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageYearProgress.TabIndex = 15;
			this.tabPageYearProgress.Text = "Year progress";
			this.tabPageYearProgress.UseVisualStyleBackColor = true;
			// 
			// tabPage1001
			// 
			this.tabPage1001.Controls.Add(this._10011);
			this.tabPage1001.Location = new System.Drawing.Point(4, 29);
			this.tabPage1001.Name = "tabPage1001";
			this.tabPage1001.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1001.Size = new System.Drawing.Size(1394, 1468);
			this.tabPage1001.TabIndex = 16;
			this.tabPage1001.Text = "1001";
			this.tabPage1001.UseVisualStyleBackColor = true;
			// 
			// tabPageLibrary
			// 
			this.tabPageLibrary.Controls.Add(this.library1);
			this.tabPageLibrary.Location = new System.Drawing.Point(4, 29);
			this.tabPageLibrary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPageLibrary.Name = "tabPageLibrary";
			this.tabPageLibrary.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPageLibrary.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageLibrary.TabIndex = 14;
			this.tabPageLibrary.Text = "Library";
			this.tabPageLibrary.UseVisualStyleBackColor = true;
			// 
			// tabControlAll
			// 
			this.tabControlAll.Controls.Add(this.tabPageMain);
			this.tabControlAll.Controls.Add(this.tabPageCollection);
			this.tabControlAll.Controls.Add(this.Stats);
			this.tabControlAll.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlAll.Location = new System.Drawing.Point(0, 0);
			this.tabControlAll.Name = "tabControlAll";
			this.tabControlAll.SelectedIndex = 0;
			this.tabControlAll.Size = new System.Drawing.Size(1416, 1540);
			this.tabControlAll.TabIndex = 20;
			// 
			// tabPageMain
			// 
			this.tabPageMain.Controls.Add(this.tabControlMain);
			this.tabPageMain.Location = new System.Drawing.Point(4, 29);
			this.tabPageMain.Name = "tabPageMain";
			this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMain.Size = new System.Drawing.Size(1408, 1507);
			this.tabPageMain.TabIndex = 0;
			this.tabPageMain.Text = "Main";
			this.tabPageMain.UseVisualStyleBackColor = true;
			// 
			// tabPageCollection
			// 
			this.tabPageCollection.Controls.Add(this.tabControlCollection);
			this.tabPageCollection.Location = new System.Drawing.Point(4, 29);
			this.tabPageCollection.Name = "tabPageCollection";
			this.tabPageCollection.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCollection.Size = new System.Drawing.Size(1408, 1507);
			this.tabPageCollection.TabIndex = 1;
			this.tabPageCollection.Text = "Collection";
			this.tabPageCollection.UseVisualStyleBackColor = true;
			// 
			// tabControlCollection
			// 
			this.tabControlCollection.Controls.Add(this.tabPageCollectionBooks);
			this.tabControlCollection.Controls.Add(this.tabPageCollectionGames);
			this.tabControlCollection.Controls.Add(this.tabPageCollectionComics);
			this.tabControlCollection.Controls.Add(this.tabPageCollectionMusic);
			this.tabControlCollection.Controls.Add(this.tabPageLibrary);
			this.tabControlCollection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlCollection.Location = new System.Drawing.Point(3, 3);
			this.tabControlCollection.Name = "tabControlCollection";
			this.tabControlCollection.SelectedIndex = 0;
			this.tabControlCollection.Size = new System.Drawing.Size(1402, 1501);
			this.tabControlCollection.TabIndex = 0;
			// 
			// Stats
			// 
			this.Stats.Controls.Add(this.tabControlStats);
			this.Stats.Location = new System.Drawing.Point(4, 29);
			this.Stats.Name = "Stats";
			this.Stats.Padding = new System.Windows.Forms.Padding(3);
			this.Stats.Size = new System.Drawing.Size(1408, 1507);
			this.Stats.TabIndex = 2;
			this.Stats.Text = "Stats";
			this.Stats.UseVisualStyleBackColor = true;
			// 
			// tabControlStats
			// 
			this.tabControlStats.Controls.Add(this.tabPageMonthyReports);
			this.tabControlStats.Controls.Add(this.tabPageYearProgress);
			this.tabControlStats.Controls.Add(this.tabPage1001);
			this.tabControlStats.Controls.Add(this.tabPageYearStats);
			this.tabControlStats.Controls.Add(this.tabPageTotal);
			this.tabControlStats.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlStats.Location = new System.Drawing.Point(3, 3);
			this.tabControlStats.Name = "tabControlStats";
			this.tabControlStats.SelectedIndex = 0;
			this.tabControlStats.Size = new System.Drawing.Size(1402, 1501);
			this.tabControlStats.TabIndex = 0;
			// 
			// tabPageYearStats
			// 
			this.tabPageYearStats.Controls.Add(this.yearStatsControl1);
			this.tabPageYearStats.Location = new System.Drawing.Point(4, 29);
			this.tabPageYearStats.Name = "tabPageYearStats";
			this.tabPageYearStats.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageYearStats.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageYearStats.TabIndex = 17;
			this.tabPageYearStats.Text = "Year stats";
			this.tabPageYearStats.UseVisualStyleBackColor = true;
			// 
			// tabPageTotal
			// 
			this.tabPageTotal.Controls.Add(this.total1);
			this.tabPageTotal.Location = new System.Drawing.Point(4, 29);
			this.tabPageTotal.Name = "tabPageTotal";
			this.tabPageTotal.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTotal.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageTotal.TabIndex = 18;
			this.tabPageTotal.Text = "Total";
			this.tabPageTotal.UseVisualStyleBackColor = true;
			// 
			// musicControl1
			// 
			this.musicControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.musicControl1.Location = new System.Drawing.Point(4, 5);
			this.musicControl1.Margin = new System.Windows.Forms.Padding(6);
			this.musicControl1.Name = "musicControl1";
			this.musicControl1.Size = new System.Drawing.Size(1386, 1458);
			this.musicControl1.TabIndex = 19;
			// 
			// moviesControl1
			// 
			this.moviesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.moviesControl1.Location = new System.Drawing.Point(4, 5);
			this.moviesControl1.Margin = new System.Windows.Forms.Padding(6);
			this.moviesControl1.Name = "moviesControl1";
			this.moviesControl1.Size = new System.Drawing.Size(1386, 1458);
			this.moviesControl1.TabIndex = 9;
			// 
			// comicsControl1
			// 
			this.comicsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comicsControl1.Location = new System.Drawing.Point(4, 5);
			this.comicsControl1.Margin = new System.Windows.Forms.Padding(6);
			this.comicsControl1.Name = "comicsControl1";
			this.comicsControl1.Size = new System.Drawing.Size(1386, 1458);
			this.comicsControl1.TabIndex = 20;
			// 
			// game1
			// 
			this.game1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.game1.Location = new System.Drawing.Point(4, 5);
			this.game1.Margin = new System.Windows.Forms.Padding(6);
			this.game1.Name = "game1";
			this.game1.Size = new System.Drawing.Size(1386, 1458);
			this.game1.TabIndex = 27;
			// 
			// tvShowsControl1
			// 
			this.tvShowsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvShowsControl1.Location = new System.Drawing.Point(4, 5);
			this.tvShowsControl1.Margin = new System.Windows.Forms.Padding(6);
			this.tvShowsControl1.Name = "tvShowsControl1";
			this.tvShowsControl1.Size = new System.Drawing.Size(1386, 1458);
			this.tvShowsControl1.TabIndex = 16;
			// 
			// booksControl1
			// 
			this.booksControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.booksControl1.Location = new System.Drawing.Point(4, 5);
			this.booksControl1.Margin = new System.Windows.Forms.Padding(6);
			this.booksControl1.Name = "booksControl1";
			this.booksControl1.Size = new System.Drawing.Size(1386, 1458);
			this.booksControl1.TabIndex = 22;
			// 
			// standup1
			// 
			this.standup1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.standup1.Location = new System.Drawing.Point(4, 5);
			this.standup1.Margin = new System.Windows.Forms.Padding(6);
			this.standup1.Name = "standup1";
			this.standup1.Size = new System.Drawing.Size(1386, 1458);
			this.standup1.TabIndex = 0;
			// 
			// myWork1
			// 
			this.myWork1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myWork1.Location = new System.Drawing.Point(4, 5);
			this.myWork1.Margin = new System.Windows.Forms.Padding(6);
			this.myWork1.Name = "myWork1";
			this.myWork1.Size = new System.Drawing.Size(1386, 1458);
			this.myWork1.TabIndex = 0;
			// 
			// myWorkProgress1
			// 
			this.myWorkProgress1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myWorkProgress1.Location = new System.Drawing.Point(3, 4);
			this.myWorkProgress1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.myWorkProgress1.Name = "myWorkProgress1";
			this.myWorkProgress1.Size = new System.Drawing.Size(1388, 1460);
			this.myWorkProgress1.TabIndex = 0;
			// 
			// collectionBooks1
			// 
			this.collectionBooks1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collectionBooks1.Location = new System.Drawing.Point(4, 5);
			this.collectionBooks1.Margin = new System.Windows.Forms.Padding(6);
			this.collectionBooks1.Name = "collectionBooks1";
			this.collectionBooks1.Size = new System.Drawing.Size(1386, 1458);
			this.collectionBooks1.TabIndex = 26;
			// 
			// collectionGamesControl1
			// 
			this.collectionGamesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collectionGamesControl1.Location = new System.Drawing.Point(4, 5);
			this.collectionGamesControl1.Margin = new System.Windows.Forms.Padding(6);
			this.collectionGamesControl1.Name = "collectionGamesControl1";
			this.collectionGamesControl1.Size = new System.Drawing.Size(1386, 1458);
			this.collectionGamesControl1.TabIndex = 12;
			// 
			// collectionComics1
			// 
			this.collectionComics1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collectionComics1.Location = new System.Drawing.Point(4, 5);
			this.collectionComics1.Margin = new System.Windows.Forms.Padding(6);
			this.collectionComics1.Name = "collectionComics1";
			this.collectionComics1.Size = new System.Drawing.Size(1386, 1458);
			this.collectionComics1.TabIndex = 14;
			// 
			// music1
			// 
			this.music1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.music1.Location = new System.Drawing.Point(4, 5);
			this.music1.Margin = new System.Windows.Forms.Padding(6);
			this.music1.Name = "music1";
			this.music1.Size = new System.Drawing.Size(1386, 1458);
			this.music1.TabIndex = 0;
			// 
			// library1
			// 
			this.library1.Location = new System.Drawing.Point(4, 9);
			this.library1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.library1.Name = "library1";
			this.library1.Size = new System.Drawing.Size(1068, 1488);
			this.library1.TabIndex = 0;
			// 
			// weeklyReports1
			// 
			this.weeklyReports1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.weeklyReports1.Location = new System.Drawing.Point(3, 4);
			this.weeklyReports1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.weeklyReports1.Name = "weeklyReports1";
			this.weeklyReports1.Size = new System.Drawing.Size(1388, 1460);
			this.weeklyReports1.TabIndex = 0;
			// 
			// yearProgress1
			// 
			this.yearProgress1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.yearProgress1.Location = new System.Drawing.Point(3, 3);
			this.yearProgress1.Name = "yearProgress1";
			this.yearProgress1.Size = new System.Drawing.Size(1388, 1462);
			this.yearProgress1.TabIndex = 0;
			// 
			// _10011
			// 
			this._10011.Dock = System.Windows.Forms.DockStyle.Fill;
			this._10011.Location = new System.Drawing.Point(3, 3);
			this._10011.Name = "_10011";
			this._10011.Size = new System.Drawing.Size(1388, 1462);
			this._10011.TabIndex = 0;
			// 
			// yearStatsControl1
			// 
			this.yearStatsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.yearStatsControl1.Location = new System.Drawing.Point(3, 3);
			this.yearStatsControl1.Name = "yearStatsControl1";
			this.yearStatsControl1.Size = new System.Drawing.Size(1388, 1462);
			this.yearStatsControl1.TabIndex = 0;
			// 
			// total1
			// 
			this.total1.Location = new System.Drawing.Point(4, 7);
			this.total1.Name = "total1";
			this.total1.Size = new System.Drawing.Size(1209, 883);
			this.total1.TabIndex = 0;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1416, 1540);
			this.Controls.Add(this.tabControlAll);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormMain";
			this.Text = "Main";
			this.tabPageCollectionMusic.ResumeLayout(false);
			this.tabPageCollectionComics.ResumeLayout(false);
			this.tabPageCollectionGames.ResumeLayout(false);
			this.tabPageCollectionBooks.ResumeLayout(false);
			this.tabPageBooks.ResumeLayout(false);
			this.tabPageTVShows.ResumeLayout(false);
			this.tabPageGames.ResumeLayout(false);
			this.tabPageComics.ResumeLayout(false);
			this.tabPageMovies.ResumeLayout(false);
			this.tabPageMusic.ResumeLayout(false);
			this.tabControlMain.ResumeLayout(false);
			this.tabPageStandup.ResumeLayout(false);
			this.tabPageMyWork.ResumeLayout(false);
			this.tabPageMyWorkProgress.ResumeLayout(false);
			this.tabPageMonthyReports.ResumeLayout(false);
			this.tabPageYearProgress.ResumeLayout(false);
			this.tabPage1001.ResumeLayout(false);
			this.tabPageLibrary.ResumeLayout(false);
			this.tabControlAll.ResumeLayout(false);
			this.tabPageMain.ResumeLayout(false);
			this.tabPageCollection.ResumeLayout(false);
			this.tabControlCollection.ResumeLayout(false);
			this.Stats.ResumeLayout(false);
			this.tabControlStats.ResumeLayout(false);
			this.tabPageYearStats.ResumeLayout(false);
			this.tabPageTotal.ResumeLayout(false);
			this.ResumeLayout(false);

		}

        #endregion

        private TabPage tabPageCollectionMusic;
        private Collection.MusicControl music1;
        private TabPage tabPageCollectionComics;
        private Collection.ComicsControl collectionComics1;
        private TabPage tabPageCollectionGames;
        private Collection.Games.GamesControl collectionGamesControl1;
        private TabPage tabPageCollectionBooks;
        private Collection.Books.BooksControl collectionBooks1;
        private TabPage tabPageBooks;
        private Books.BooksControl booksControl1;
        private TabPage tabPageTVShows;
        private TV_Shows.TVShowsControl tvShowsControl1;
        private TabPage tabPageGames;
        private Games.GamesControl game1;
        private TabPage tabPageComics;
        private Comics.ComicsControl comicsControl1;
        private TabPage tabPageMovies;
        private Movies.MoviesControl moviesControl1;
        private TabPage tabPageMusic;
        private Musics.MusicControl musicControl1;
        private TabControl tabControlMain;
		private TabPage tabPageStandup;
		private Standups.StandupsControl standup1;
		private TabPage tabPageMyWork;
		private My_work.MyWorkControl myWork1;
		private TabPage tabPageMonthyReports;
		private Reports.MontlyReportsControl weeklyReports1;
		private TabPage tabPageMyWorkProgress;
		private My_work_progress.MyWorkProgressControl myWorkProgress1;
		private TabPage tabPageLibrary;
		private Collection.LibraryControl library1;
		private TabPage tabPageYearProgress;
		private Reports.YearProgressControl yearProgress1;
		private TabPage tabPage1001;
		private _1001._1001Control _10011;
		private TabControl tabControlAll;
		private TabPage tabPageMain;
		private TabPage tabPageCollection;
		private TabPage Stats;
		private TabControl tabControlCollection;
		private TabControl tabControlStats;
		private TabPage tabPageYearStats;
		private Reports.YearStatsControl yearStatsControl1;
		private TabPage tabPageTotal;
		private StatsControls.Total total1;
	}
}

