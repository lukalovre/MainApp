using Model;
using Model.Collection;
using Model.Grid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
	public class Converter
	{
		public static CollectionGames ToCollectionGames(Game game)
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

		public static DnDEventGrid ToDnDEventGrid(Model.dbo.DnDEvent o)
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

		public static PeopleGrid ToPeopleGrid(Model.dbo.Person o)
		{
			return new PeopleGrid
			{
				ID = o.ID,
				FirstName = o.FirstName,
				LastName = o.LastName
			};
		}

		public static ZooGrid ToZooGrid(Model.dbo.Zoo item, IEnumerable<Model.dbo.ZooEvents> events)
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
	}
}