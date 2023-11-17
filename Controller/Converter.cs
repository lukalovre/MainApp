using Model;
using Model.dbo;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
	public class Converter
	{
		public static CollectionGames ToCollectionGames(Model.Collection.Game game)
		{
			return new CollectionGames
			{
				ID = game.ID,
				Title = game.Title,
				Platform = game.Platform,
				Year = game.Year,
				HLTB = game.HLTB,
				Freshnes = Games.GetFreshMeter(game.Date),
			};
		}

		public static DnDEventGrid ToDnDEventGrid(DnDEvent o)
		{
			return new DnDEventGrid
			{
				ID = o.ID,
				ItemID = o.ItemID,
				Hours = o.Hours,
				Level = o.Level,
				Location = o.Location,
				Summary = o.Summary
			};
		}

		public static PeopleGrid ToPeopleGrid(Person o)
		{
			return new PeopleGrid
			{
				ID = o.ID,
				FirstName = o.FirstName,
				LastName = o.LastName
			};
		}

		public static ZooGrid ToZooGrid(Zoo item, IEnumerable<ZooEvents> events)
		{
			return new ZooGrid
			{
				ID = item.ID,
				Name = item.Name,
				City = item.City,
				Country = item.Country,
				LastVisit = events?.Max(o => o.Date).Value ?? DateTime.Now
			};
		}

		public static ConcertsGrid ToConcertGrid(Concert item)
		{
			return new ConcertsGrid
			{
				ID = item.ID,
				Title = item.Title,
				City = item.City,
				Festival = item.Festival,
				Year = item.Date.Value.Year
			};
		}

		public static SongGrid ToSongGrid(Song item, IEnumerable<SongEvent> events)
		{
			return new SongGrid
			{
				ID = item.ID,
				Artist = item.Artist,
				Title = item.Title,
				Year = item.Year,
				LastHeard = events?.Max(o => o.Date) ?? DateTime.Now
			};
		}

		public static MyWorkGrid ToMyWorkGrid(MyWork o)
		{
			return new MyWorkGrid
			{
				ID = o.ID,
				Title = o.Title,
				Type = o.Type,
				Year = o.Date.HasValue ? o.Date.Value.Year : 0,
				Date = o.Date ?? DateTime.MinValue
			};
		}

		public static MyWorkProgresGrid ToMyWorkProgresGrid(MyWorkProgres item, IEnumerable<MyWorkProgressEvent> events)
		{
			var lastDate = events.Max(o => o.Date).Value;
			var daysAgo = (int)(DateTime.Now - lastDate).TotalDays;
			var time = events.Sum(o => o.Time);

			return new MyWorkProgresGrid
			{
				ID = item.ID,
				ItemID = item.ItemID,
				Title = item.Title,
				Type = item.Type,
				Time = TimeHelper.GetFormatedTime(time),
				LastDate = lastDate,
				DaysAgo = daysAgo
			};
		}
	}
}