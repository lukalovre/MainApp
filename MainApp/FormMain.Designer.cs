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
			this.music1 = new MainApp.Collection.MusicControl();
			this.tabPageCollectionComics = new System.Windows.Forms.TabPage();
			this.collectionComics1 = new MainApp.Collection.ComicsControl();
			this.tabPageCollectionGames = new System.Windows.Forms.TabPage();
			this.collectionGamesControl1 = new MainApp.Collection.Games.GamesControl();
			this.tabPageCollectionBooks = new System.Windows.Forms.TabPage();
			this.collectionBooks1 = new MainApp.Collection.Books.BooksControl();
			this.tabPageBooks = new System.Windows.Forms.TabPage();
			this.booksControl1 = new MainApp.Books.BooksControl();
			this.tabPageTVShows = new System.Windows.Forms.TabPage();
			this.tvShowsControl1 = new MainApp.TV_Shows.TVShowsControl();
			this.tabPageGames = new System.Windows.Forms.TabPage();
			this.game1 = new MainApp.Games.GamesControl();
			this.tabPageComics = new System.Windows.Forms.TabPage();
			this.comicsControl1 = new MainApp.Comics.ComicsControl();
			this.tabPageMovies = new System.Windows.Forms.TabPage();
			this.moviesControl1 = new MainApp.Movies.MoviesControl();
			this.tabPageMusic = new System.Windows.Forms.TabPage();
			this.musicControl1 = new MainApp.Musics.MusicControl();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageStandup = new System.Windows.Forms.TabPage();
			this.standup1 = new MainApp.Standups.StandupsControl();
			this.tabPageDnD = new System.Windows.Forms.TabPage();
			this.dnDControl1 = new MainApp.MainControls.DnDControl();
			this.tabPagePeople = new System.Windows.Forms.TabPage();
			this.peopleControl1 = new MainApp.MainControls.PeopleControl();
			this.tabPageMyWork = new System.Windows.Forms.TabPage();
			this.myWork1 = new MainApp.My_work.MyWorkControl();
			this.tabPageMyWorkProgress = new System.Windows.Forms.TabPage();
			this.myWorkProgress1 = new MainApp.My_work_progress.MyWorkProgressControl();
			this.tabPageZoo = new System.Windows.Forms.TabPage();
			this.zooControl1 = new MainApp.MainControls.Zoo.ZooControl();
			this.tabPageMonthyReports = new System.Windows.Forms.TabPage();
			this.weeklyReports1 = new MainApp.Reports.MontlyReportsControl();
			this.tabPageYearProgress = new System.Windows.Forms.TabPage();
			this.yearProgress1 = new MainApp.Reports.YearProgressControl();
			this.tabPage1001 = new System.Windows.Forms.TabPage();
			this._10011 = new MainApp._1001._1001Control();
			this.tabPageLibrary = new System.Windows.Forms.TabPage();
			this.library1 = new MainApp.Collection.LibraryControl();
			this.tabControlAll = new System.Windows.Forms.TabControl();
			this.tabPageMain = new System.Windows.Forms.TabPage();
			this.tabPageCollection = new System.Windows.Forms.TabPage();
			this.tabControlCollection = new System.Windows.Forms.TabControl();
			this.tabPageCollectionMovies = new System.Windows.Forms.TabPage();
			this.moviesControl2 = new MainApp.CollectionControls.MoviesControl();
			this.tabPageStats = new System.Windows.Forms.TabPage();
			this.tabControlStats = new System.Windows.Forms.TabControl();
			this.tabPageYearStats = new System.Windows.Forms.TabPage();
			this.yearStatsControl1 = new MainApp.Reports.YearStatsControl();
			this.tabPageTotal = new System.Windows.Forms.TabPage();
			this.total1 = new MainApp.StatsControls.Total();
			this.tabPageYearCollectionStats = new System.Windows.Forms.TabPage();
			this.yearStatsCollectionControl1 = new MainApp.Reports.YearStatsCollectionControl();
			this.tabPageYearSummary = new System.Windows.Forms.TabPage();
			this.yearSummary1 = new MainApp.StatsControls.YearSummary();
			this.tabPageLists = new System.Windows.Forms.TabPage();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageMovieLists = new System.Windows.Forms.TabPage();
			this.movieListsControl1 = new MainApp.ListControls.MovieListsControl();
			this.tabPageTVShowLists = new System.Windows.Forms.TabPage();
			this.tvShowListControl1 = new MainApp.ListControls.TVShowListControl();
			this.tabPageGameLists = new System.Windows.Forms.TabPage();
			this.gameListsControl1 = new MainApp.ListControls.GameListsControl();
			this.tabPageWeb = new System.Windows.Forms.TabPage();
			this.linksControl1 = new MainApp.MainControls.LinksControl();
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
			this.tabPageDnD.SuspendLayout();
			this.tabPagePeople.SuspendLayout();
			this.tabPageMyWork.SuspendLayout();
			this.tabPageMyWorkProgress.SuspendLayout();
			this.tabPageZoo.SuspendLayout();
			this.tabPageMonthyReports.SuspendLayout();
			this.tabPageYearProgress.SuspendLayout();
			this.tabPage1001.SuspendLayout();
			this.tabPageLibrary.SuspendLayout();
			this.tabControlAll.SuspendLayout();
			this.tabPageMain.SuspendLayout();
			this.tabPageCollection.SuspendLayout();
			this.tabControlCollection.SuspendLayout();
			this.tabPageCollectionMovies.SuspendLayout();
			this.tabPageStats.SuspendLayout();
			this.tabControlStats.SuspendLayout();
			this.tabPageYearStats.SuspendLayout();
			this.tabPageTotal.SuspendLayout();
			this.tabPageYearCollectionStats.SuspendLayout();
			this.tabPageYearSummary.SuspendLayout();
			this.tabPageLists.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageMovieLists.SuspendLayout();
			this.tabPageTVShowLists.SuspendLayout();
			this.tabPageGameLists.SuspendLayout();
			this.tabPageWeb.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPageCollectionMusic
			// 
			this.tabPageCollectionMusic.Controls.Add(this.music1);
			this.tabPageCollectionMusic.Location = new System.Drawing.Point(4, 29);
			this.tabPageCollectionMusic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionMusic.Name = "tabPageCollectionMusic";
			this.tabPageCollectionMusic.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionMusic.Size = new System.Drawing.Size(178, 28);
			this.tabPageCollectionMusic.TabIndex = 9;
			this.tabPageCollectionMusic.Text = "Music";
			this.tabPageCollectionMusic.UseVisualStyleBackColor = true;
			// 
			// music1
			// 
			this.music1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.music1.Location = new System.Drawing.Point(4, 5);
			this.music1.Margin = new System.Windows.Forms.Padding(6);
			this.music1.Name = "music1";
			this.music1.Size = new System.Drawing.Size(170, 18);
			this.music1.TabIndex = 0;
			// 
			// tabPageCollectionComics
			// 
			this.tabPageCollectionComics.Controls.Add(this.collectionComics1);
			this.tabPageCollectionComics.Location = new System.Drawing.Point(4, 29);
			this.tabPageCollectionComics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionComics.Name = "tabPageCollectionComics";
			this.tabPageCollectionComics.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionComics.Size = new System.Drawing.Size(178, 28);
			this.tabPageCollectionComics.TabIndex = 8;
			this.tabPageCollectionComics.Text = "Comics";
			this.tabPageCollectionComics.UseVisualStyleBackColor = true;
			// 
			// collectionComics1
			// 
			this.collectionComics1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collectionComics1.Location = new System.Drawing.Point(4, 5);
			this.collectionComics1.Margin = new System.Windows.Forms.Padding(6);
			this.collectionComics1.Name = "collectionComics1";
			this.collectionComics1.Size = new System.Drawing.Size(170, 18);
			this.collectionComics1.TabIndex = 14;
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
			// collectionGamesControl1
			// 
			this.collectionGamesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collectionGamesControl1.Location = new System.Drawing.Point(4, 5);
			this.collectionGamesControl1.Margin = new System.Windows.Forms.Padding(6);
			this.collectionGamesControl1.Name = "collectionGamesControl1";
			this.collectionGamesControl1.Size = new System.Drawing.Size(1386, 1458);
			this.collectionGamesControl1.TabIndex = 12;
			// 
			// tabPageCollectionBooks
			// 
			this.tabPageCollectionBooks.Controls.Add(this.collectionBooks1);
			this.tabPageCollectionBooks.Location = new System.Drawing.Point(4, 29);
			this.tabPageCollectionBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionBooks.Name = "tabPageCollectionBooks";
			this.tabPageCollectionBooks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageCollectionBooks.Size = new System.Drawing.Size(178, 28);
			this.tabPageCollectionBooks.TabIndex = 6;
			this.tabPageCollectionBooks.Text = "Books";
			this.tabPageCollectionBooks.UseVisualStyleBackColor = true;
			// 
			// collectionBooks1
			// 
			this.collectionBooks1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collectionBooks1.Location = new System.Drawing.Point(4, 5);
			this.collectionBooks1.Margin = new System.Windows.Forms.Padding(6);
			this.collectionBooks1.Name = "collectionBooks1";
			this.collectionBooks1.Size = new System.Drawing.Size(170, 18);
			this.collectionBooks1.TabIndex = 26;
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
			// booksControl1
			// 
			this.booksControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.booksControl1.Location = new System.Drawing.Point(4, 5);
			this.booksControl1.Margin = new System.Windows.Forms.Padding(6);
			this.booksControl1.Name = "booksControl1";
			this.booksControl1.Size = new System.Drawing.Size(1386, 1458);
			this.booksControl1.TabIndex = 22;
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
			// tvShowsControl1
			// 
			this.tvShowsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvShowsControl1.Location = new System.Drawing.Point(4, 5);
			this.tvShowsControl1.Margin = new System.Windows.Forms.Padding(6);
			this.tvShowsControl1.Name = "tvShowsControl1";
			this.tvShowsControl1.Size = new System.Drawing.Size(1386, 1458);
			this.tvShowsControl1.TabIndex = 16;
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
			// game1
			// 
			this.game1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.game1.Location = new System.Drawing.Point(4, 5);
			this.game1.Margin = new System.Windows.Forms.Padding(6);
			this.game1.Name = "game1";
			this.game1.Size = new System.Drawing.Size(1386, 1458);
			this.game1.TabIndex = 27;
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
			// comicsControl1
			// 
			this.comicsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comicsControl1.Location = new System.Drawing.Point(4, 5);
			this.comicsControl1.Margin = new System.Windows.Forms.Padding(6);
			this.comicsControl1.Name = "comicsControl1";
			this.comicsControl1.Size = new System.Drawing.Size(1386, 1458);
			this.comicsControl1.TabIndex = 20;
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
			// moviesControl1
			// 
			this.moviesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.moviesControl1.Location = new System.Drawing.Point(4, 5);
			this.moviesControl1.Margin = new System.Windows.Forms.Padding(6);
			this.moviesControl1.Name = "moviesControl1";
			this.moviesControl1.Size = new System.Drawing.Size(1386, 1458);
			this.moviesControl1.TabIndex = 9;
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
			// musicControl1
			// 
			this.musicControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.musicControl1.Location = new System.Drawing.Point(4, 5);
			this.musicControl1.Margin = new System.Windows.Forms.Padding(6);
			this.musicControl1.Name = "musicControl1";
			this.musicControl1.Size = new System.Drawing.Size(1386, 1458);
			this.musicControl1.TabIndex = 19;
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageMusic);
			this.tabControlMain.Controls.Add(this.tabPageGames);
			this.tabControlMain.Controls.Add(this.tabPageTVShows);
			this.tabControlMain.Controls.Add(this.tabPageMovies);
			this.tabControlMain.Controls.Add(this.tabPageComics);
			this.tabControlMain.Controls.Add(this.tabPageBooks);
			this.tabControlMain.Controls.Add(this.tabPageStandup);
			this.tabControlMain.Controls.Add(this.tabPageDnD);
			this.tabControlMain.Controls.Add(this.tabPagePeople);
			this.tabControlMain.Controls.Add(this.tabPageZoo);
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
			// standup1
			// 
			this.standup1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.standup1.Location = new System.Drawing.Point(4, 5);
			this.standup1.Margin = new System.Windows.Forms.Padding(6);
			this.standup1.Name = "standup1";
			this.standup1.Size = new System.Drawing.Size(1386, 1458);
			this.standup1.TabIndex = 0;
			// 
			// tabPageDnD
			// 
			this.tabPageDnD.Controls.Add(this.dnDControl1);
			this.tabPageDnD.Location = new System.Drawing.Point(4, 29);
			this.tabPageDnD.Name = "tabPageDnD";
			this.tabPageDnD.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageDnD.TabIndex = 14;
			this.tabPageDnD.Text = "D&D";
			this.tabPageDnD.UseVisualStyleBackColor = true;
			// 
			// dnDControl1
			// 
			this.dnDControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dnDControl1.Location = new System.Drawing.Point(0, 0);
			this.dnDControl1.Name = "dnDControl1";
			this.dnDControl1.Size = new System.Drawing.Size(1394, 1468);
			this.dnDControl1.TabIndex = 0;
			// 
			// tabPagePeople
			// 
			this.tabPagePeople.Controls.Add(this.peopleControl1);
			this.tabPagePeople.Location = new System.Drawing.Point(4, 29);
			this.tabPagePeople.Name = "tabPagePeople";
			this.tabPagePeople.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePeople.Size = new System.Drawing.Size(1394, 1468);
			this.tabPagePeople.TabIndex = 15;
			this.tabPagePeople.Text = "People";
			this.tabPagePeople.UseVisualStyleBackColor = true;
			// 
			// peopleControl1
			// 
			this.peopleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.peopleControl1.Location = new System.Drawing.Point(3, 3);
			this.peopleControl1.Name = "peopleControl1";
			this.peopleControl1.Size = new System.Drawing.Size(1388, 1462);
			this.peopleControl1.TabIndex = 0;
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
			// myWork1
			// 
			this.myWork1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myWork1.Location = new System.Drawing.Point(4, 5);
			this.myWork1.Margin = new System.Windows.Forms.Padding(6);
			this.myWork1.Name = "myWork1";
			this.myWork1.Size = new System.Drawing.Size(1386, 1458);
			this.myWork1.TabIndex = 0;
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
			// myWorkProgress1
			// 
			this.myWorkProgress1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myWorkProgress1.Location = new System.Drawing.Point(3, 4);
			this.myWorkProgress1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.myWorkProgress1.Name = "myWorkProgress1";
			this.myWorkProgress1.Size = new System.Drawing.Size(1388, 1460);
			this.myWorkProgress1.TabIndex = 0;
			// 
			// tabPageZoo
			// 
			this.tabPageZoo.Controls.Add(this.zooControl1);
			this.tabPageZoo.Location = new System.Drawing.Point(4, 29);
			this.tabPageZoo.Name = "tabPageZoo";
			this.tabPageZoo.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageZoo.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageZoo.TabIndex = 16;
			this.tabPageZoo.Text = "Zoo";
			this.tabPageZoo.UseVisualStyleBackColor = true;
			// 
			// zooControl1
			// 
			this.zooControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.zooControl1.Location = new System.Drawing.Point(3, 3);
			this.zooControl1.Name = "zooControl1";
			this.zooControl1.Size = new System.Drawing.Size(1388, 1462);
			this.zooControl1.TabIndex = 0;
			// 
			// tabPageMonthyReports
			// 
			this.tabPageMonthyReports.Controls.Add(this.weeklyReports1);
			this.tabPageMonthyReports.Location = new System.Drawing.Point(4, 29);
			this.tabPageMonthyReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPageMonthyReports.Name = "tabPageMonthyReports";
			this.tabPageMonthyReports.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPageMonthyReports.Size = new System.Drawing.Size(178, 28);
			this.tabPageMonthyReports.TabIndex = 12;
			this.tabPageMonthyReports.Text = "Monthly reports";
			this.tabPageMonthyReports.UseVisualStyleBackColor = true;
			// 
			// weeklyReports1
			// 
			this.weeklyReports1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.weeklyReports1.Location = new System.Drawing.Point(3, 4);
			this.weeklyReports1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.weeklyReports1.Name = "weeklyReports1";
			this.weeklyReports1.Size = new System.Drawing.Size(172, 20);
			this.weeklyReports1.TabIndex = 0;
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
			// yearProgress1
			// 
			this.yearProgress1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.yearProgress1.Location = new System.Drawing.Point(3, 3);
			this.yearProgress1.Name = "yearProgress1";
			this.yearProgress1.Size = new System.Drawing.Size(1388, 1462);
			this.yearProgress1.TabIndex = 0;
			// 
			// tabPage1001
			// 
			this.tabPage1001.Controls.Add(this._10011);
			this.tabPage1001.Location = new System.Drawing.Point(4, 29);
			this.tabPage1001.Name = "tabPage1001";
			this.tabPage1001.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1001.Size = new System.Drawing.Size(178, 28);
			this.tabPage1001.TabIndex = 16;
			this.tabPage1001.Text = "1001";
			this.tabPage1001.UseVisualStyleBackColor = true;
			// 
			// _10011
			// 
			this._10011.Dock = System.Windows.Forms.DockStyle.Fill;
			this._10011.Location = new System.Drawing.Point(3, 3);
			this._10011.Name = "_10011";
			this._10011.Size = new System.Drawing.Size(172, 22);
			this._10011.TabIndex = 0;
			// 
			// tabPageLibrary
			// 
			this.tabPageLibrary.Controls.Add(this.library1);
			this.tabPageLibrary.Location = new System.Drawing.Point(4, 29);
			this.tabPageLibrary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPageLibrary.Name = "tabPageLibrary";
			this.tabPageLibrary.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPageLibrary.Size = new System.Drawing.Size(178, 28);
			this.tabPageLibrary.TabIndex = 14;
			this.tabPageLibrary.Text = "Library";
			this.tabPageLibrary.UseVisualStyleBackColor = true;
			// 
			// library1
			// 
			this.library1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.library1.Location = new System.Drawing.Point(3, 4);
			this.library1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.library1.Name = "library1";
			this.library1.Size = new System.Drawing.Size(1388, 1460);
			this.library1.TabIndex = 0;
			// 
			// tabControlAll
			// 
			this.tabControlAll.Controls.Add(this.tabPageMain);
			this.tabControlAll.Controls.Add(this.tabPageCollection);
			this.tabControlAll.Controls.Add(this.tabPageStats);
			this.tabControlAll.Controls.Add(this.tabPageLists);
			this.tabControlAll.Controls.Add(this.tabPageWeb);
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
			this.tabControlCollection.Controls.Add(this.tabPageCollectionGames);
			this.tabControlCollection.Controls.Add(this.tabPageCollectionBooks);
			this.tabControlCollection.Controls.Add(this.tabPageCollectionComics);
			this.tabControlCollection.Controls.Add(this.tabPageCollectionMusic);
			this.tabControlCollection.Controls.Add(this.tabPageCollectionMovies);
			this.tabControlCollection.Controls.Add(this.tabPageLibrary);
			this.tabControlCollection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlCollection.Location = new System.Drawing.Point(3, 3);
			this.tabControlCollection.Name = "tabControlCollection";
			this.tabControlCollection.SelectedIndex = 0;
			this.tabControlCollection.Size = new System.Drawing.Size(1402, 1501);
			this.tabControlCollection.TabIndex = 0;
			// 
			// tabPageCollectionMovies
			// 
			this.tabPageCollectionMovies.Controls.Add(this.moviesControl2);
			this.tabPageCollectionMovies.Location = new System.Drawing.Point(4, 29);
			this.tabPageCollectionMovies.Name = "tabPageCollectionMovies";
			this.tabPageCollectionMovies.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCollectionMovies.Size = new System.Drawing.Size(178, 28);
			this.tabPageCollectionMovies.TabIndex = 15;
			this.tabPageCollectionMovies.Text = "Movies";
			this.tabPageCollectionMovies.UseVisualStyleBackColor = true;
			// 
			// moviesControl2
			// 
			this.moviesControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.moviesControl2.Location = new System.Drawing.Point(3, 3);
			this.moviesControl2.Name = "moviesControl2";
			this.moviesControl2.Size = new System.Drawing.Size(1388, 1462);
			this.moviesControl2.TabIndex = 0;
			// 
			// tabPageStats
			// 
			this.tabPageStats.Controls.Add(this.tabControlStats);
			this.tabPageStats.Location = new System.Drawing.Point(4, 29);
			this.tabPageStats.Name = "tabPageStats";
			this.tabPageStats.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStats.Size = new System.Drawing.Size(1408, 1507);
			this.tabPageStats.TabIndex = 2;
			this.tabPageStats.Text = "Stats";
			this.tabPageStats.UseVisualStyleBackColor = true;
			// 
			// tabControlStats
			// 
			this.tabControlStats.Controls.Add(this.tabPageYearProgress);
			this.tabControlStats.Controls.Add(this.tabPage1001);
			this.tabControlStats.Controls.Add(this.tabPageMonthyReports);
			this.tabControlStats.Controls.Add(this.tabPageYearStats);
			this.tabControlStats.Controls.Add(this.tabPageTotal);
			this.tabControlStats.Controls.Add(this.tabPageYearCollectionStats);
			this.tabControlStats.Controls.Add(this.tabPageYearSummary);
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
			this.tabPageYearStats.Size = new System.Drawing.Size(178, 28);
			this.tabPageYearStats.TabIndex = 17;
			this.tabPageYearStats.Text = "Year stats";
			this.tabPageYearStats.UseVisualStyleBackColor = true;
			// 
			// yearStatsControl1
			// 
			this.yearStatsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.yearStatsControl1.Location = new System.Drawing.Point(3, 3);
			this.yearStatsControl1.Name = "yearStatsControl1";
			this.yearStatsControl1.Size = new System.Drawing.Size(172, 22);
			this.yearStatsControl1.TabIndex = 0;
			// 
			// tabPageTotal
			// 
			this.tabPageTotal.Controls.Add(this.total1);
			this.tabPageTotal.Location = new System.Drawing.Point(4, 29);
			this.tabPageTotal.Name = "tabPageTotal";
			this.tabPageTotal.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTotal.Size = new System.Drawing.Size(178, 28);
			this.tabPageTotal.TabIndex = 18;
			this.tabPageTotal.Text = "Total";
			this.tabPageTotal.UseVisualStyleBackColor = true;
			// 
			// total1
			// 
			this.total1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.total1.Location = new System.Drawing.Point(3, 3);
			this.total1.Name = "total1";
			this.total1.Size = new System.Drawing.Size(172, 22);
			this.total1.TabIndex = 0;
			// 
			// tabPageYearCollectionStats
			// 
			this.tabPageYearCollectionStats.Controls.Add(this.yearStatsCollectionControl1);
			this.tabPageYearCollectionStats.Location = new System.Drawing.Point(4, 29);
			this.tabPageYearCollectionStats.Name = "tabPageYearCollectionStats";
			this.tabPageYearCollectionStats.Size = new System.Drawing.Size(178, 28);
			this.tabPageYearCollectionStats.TabIndex = 19;
			this.tabPageYearCollectionStats.Text = "Year collection";
			this.tabPageYearCollectionStats.UseVisualStyleBackColor = true;
			// 
			// yearStatsCollectionControl1
			// 
			this.yearStatsCollectionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.yearStatsCollectionControl1.Location = new System.Drawing.Point(0, 0);
			this.yearStatsCollectionControl1.Name = "yearStatsCollectionControl1";
			this.yearStatsCollectionControl1.Size = new System.Drawing.Size(178, 28);
			this.yearStatsCollectionControl1.TabIndex = 0;
			// 
			// tabPageYearSummary
			// 
			this.tabPageYearSummary.Controls.Add(this.yearSummary1);
			this.tabPageYearSummary.Location = new System.Drawing.Point(4, 29);
			this.tabPageYearSummary.Name = "tabPageYearSummary";
			this.tabPageYearSummary.Size = new System.Drawing.Size(178, 28);
			this.tabPageYearSummary.TabIndex = 20;
			this.tabPageYearSummary.Text = "Year summary";
			this.tabPageYearSummary.UseVisualStyleBackColor = true;
			// 
			// yearSummary1
			// 
			this.yearSummary1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.yearSummary1.Location = new System.Drawing.Point(0, 0);
			this.yearSummary1.Name = "yearSummary1";
			this.yearSummary1.Size = new System.Drawing.Size(178, 28);
			this.yearSummary1.TabIndex = 0;
			// 
			// tabPageLists
			// 
			this.tabPageLists.Controls.Add(this.tabControl1);
			this.tabPageLists.Location = new System.Drawing.Point(4, 29);
			this.tabPageLists.Name = "tabPageLists";
			this.tabPageLists.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLists.Size = new System.Drawing.Size(1408, 1507);
			this.tabPageLists.TabIndex = 4;
			this.tabPageLists.Text = "Lists";
			this.tabPageLists.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageMovieLists);
			this.tabControl1.Controls.Add(this.tabPageTVShowLists);
			this.tabControl1.Controls.Add(this.tabPageGameLists);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1402, 1501);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageMovieLists
			// 
			this.tabPageMovieLists.Controls.Add(this.movieListsControl1);
			this.tabPageMovieLists.Location = new System.Drawing.Point(4, 29);
			this.tabPageMovieLists.Name = "tabPageMovieLists";
			this.tabPageMovieLists.Size = new System.Drawing.Size(1394, 1468);
			this.tabPageMovieLists.TabIndex = 2;
			this.tabPageMovieLists.Text = "Movies";
			this.tabPageMovieLists.UseVisualStyleBackColor = true;
			// 
			// movieListsControl1
			// 
			this.movieListsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.movieListsControl1.Location = new System.Drawing.Point(0, 0);
			this.movieListsControl1.Name = "movieListsControl1";
			this.movieListsControl1.Size = new System.Drawing.Size(1394, 1468);
			this.movieListsControl1.TabIndex = 0;
			// 
			// tabPageTVShowLists
			// 
			this.tabPageTVShowLists.Controls.Add(this.tvShowListControl1);
			this.tabPageTVShowLists.Location = new System.Drawing.Point(4, 29);
			this.tabPageTVShowLists.Name = "tabPageTVShowLists";
			this.tabPageTVShowLists.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTVShowLists.Size = new System.Drawing.Size(178, 28);
			this.tabPageTVShowLists.TabIndex = 1;
			this.tabPageTVShowLists.Text = "TV Shows";
			this.tabPageTVShowLists.UseVisualStyleBackColor = true;
			// 
			// tvShowListControl1
			// 
			this.tvShowListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvShowListControl1.Location = new System.Drawing.Point(3, 3);
			this.tvShowListControl1.Name = "tvShowListControl1";
			this.tvShowListControl1.Size = new System.Drawing.Size(172, 22);
			this.tvShowListControl1.TabIndex = 0;
			// 
			// tabPageGameLists
			// 
			this.tabPageGameLists.Controls.Add(this.gameListsControl1);
			this.tabPageGameLists.Location = new System.Drawing.Point(4, 29);
			this.tabPageGameLists.Name = "tabPageGameLists";
			this.tabPageGameLists.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGameLists.Size = new System.Drawing.Size(178, 28);
			this.tabPageGameLists.TabIndex = 0;
			this.tabPageGameLists.Text = "Games";
			this.tabPageGameLists.UseVisualStyleBackColor = true;
			// 
			// gameListsControl1
			// 
			this.gameListsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gameListsControl1.Location = new System.Drawing.Point(3, 3);
			this.gameListsControl1.Name = "gameListsControl1";
			this.gameListsControl1.Size = new System.Drawing.Size(172, 22);
			this.gameListsControl1.TabIndex = 0;
			// 
			// tabPageWeb
			// 
			this.tabPageWeb.Controls.Add(this.linksControl1);
			this.tabPageWeb.Location = new System.Drawing.Point(4, 29);
			this.tabPageWeb.Name = "tabPageWeb";
			this.tabPageWeb.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageWeb.Size = new System.Drawing.Size(1408, 1507);
			this.tabPageWeb.TabIndex = 3;
			this.tabPageWeb.Text = "Web";
			this.tabPageWeb.UseVisualStyleBackColor = true;
			// 
			// linksControl1
			// 
			this.linksControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linksControl1.Location = new System.Drawing.Point(3, 3);
			this.linksControl1.Name = "linksControl1";
			this.linksControl1.Size = new System.Drawing.Size(1402, 1501);
			this.linksControl1.TabIndex = 0;
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
			this.tabPageDnD.ResumeLayout(false);
			this.tabPagePeople.ResumeLayout(false);
			this.tabPageMyWork.ResumeLayout(false);
			this.tabPageMyWorkProgress.ResumeLayout(false);
			this.tabPageZoo.ResumeLayout(false);
			this.tabPageMonthyReports.ResumeLayout(false);
			this.tabPageYearProgress.ResumeLayout(false);
			this.tabPage1001.ResumeLayout(false);
			this.tabPageLibrary.ResumeLayout(false);
			this.tabControlAll.ResumeLayout(false);
			this.tabPageMain.ResumeLayout(false);
			this.tabPageCollection.ResumeLayout(false);
			this.tabControlCollection.ResumeLayout(false);
			this.tabPageCollectionMovies.ResumeLayout(false);
			this.tabPageStats.ResumeLayout(false);
			this.tabControlStats.ResumeLayout(false);
			this.tabPageYearStats.ResumeLayout(false);
			this.tabPageTotal.ResumeLayout(false);
			this.tabPageYearCollectionStats.ResumeLayout(false);
			this.tabPageYearSummary.ResumeLayout(false);
			this.tabPageLists.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPageMovieLists.ResumeLayout(false);
			this.tabPageTVShowLists.ResumeLayout(false);
			this.tabPageGameLists.ResumeLayout(false);
			this.tabPageWeb.ResumeLayout(false);
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
		private TabPage tabPageStats;
		private TabControl tabControlCollection;
		private TabControl tabControlStats;
		private TabPage tabPageYearStats;
		private Reports.YearStatsControl yearStatsControl1;
		private TabPage tabPageTotal;
		private StatsControls.Total total1;
        private TabPage tabPageCollectionMovies;
        private CollectionControls.MoviesControl moviesControl2;
        private TabPage tabPageWeb;
        private MainControls.LinksControl linksControl1;
        private TabPage tabPageYearCollectionStats;
        private Reports.YearStatsCollectionControl yearStatsCollectionControl1;
        private TabPage tabPageDnD;
        private TabPage tabPagePeople;
        private MainControls.PeopleControl peopleControl1;
        private MainControls.DnDControl dnDControl1;
        private TabPage tabPageLists;
        private TabControl tabControl1;
        private TabPage tabPageGameLists;
        private TabPage tabPageTVShowLists;
        private TabPage tabPageMovieLists;
        private ListControls.GameListsControl gameListsControl1;
        private ListControls.MovieListsControl movieListsControl1;
        private ListControls.TVShowListControl tvShowListControl1;
        private TabPage tabPageYearSummary;
        private StatsControls.YearSummary yearSummary1;
		private TabPage tabPageZoo;
		private MainControls.Zoo.ZooControl zooControl1;
	}
}

