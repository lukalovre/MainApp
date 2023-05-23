using HtmlAgilityPack;
using Model.dbo;
using Model.Grid;
using Newtonsoft.Json;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Controller
{
	public class Musics
	{
		public static MusicIn ConvertToMusicIn(Music music, List<MusicEvent> musicEvents)
		{
			return new MusicIn
			{
				ItemID = music.ItemID,
				Artist = music.Artist,
				Title = music.Title,
				Year = music.Year,
				Runtime = music.Runtime,
				Count = musicEvents.Count(o => o.ItemID == music.ItemID),
				In = musicEvents.LastOrDefault(o => o.ItemID == music.ItemID).In
			};
		}

		//public static void FindAlbum(Music music)
		//{
		//    var destinationFile = Path.Combine(Paths.Albums, $"{music.ItemID}.png");

		//    if (File.Exists(destinationFile) && music.SpotifyID != null)
		//    {
		//        return;
		//    }

		//    var spotify = GetSpotifyClient();

		//    var albumSearchList = spotify.Search.Item(new SearchRequest(SearchRequest.Types.Album, music.Title)).Result;

		//    SimpleAlbum foundAlbum = null;

		//    foreach (var albumInfo in albumSearchList.Albums.Items)
		//    {
		//        DateTime.TryParse(albumInfo.ReleaseDate, out var date);

		//        if (albumInfo.Artists.Any(o => o.Name == music.Artist)
		//            &&
		//            (albumInfo.ReleaseDate == music.Year.ToString()
		//            || date.Year == music.Year))
		//        {
		//            foundAlbum = albumInfo;
		//            break;
		//        }
		//    }

		//    if (foundAlbum != null)
		//    {
		//        Web.Download(foundAlbum.Images.FirstOrDefault().Url, destinationFile);

		//        music.SpotifyID = foundAlbum.Id;

		//        using (var sqlConnection = new SqlConnection(Resources.MainConnectionString))
		//        {
		//            sqlConnection.Open();
		//            sqlConnection.Update(music);
		//        }
		//    }
		//    else
		//    {
		//    }
		//}

		public static Music GetAlbumInfoBandcamp(string url)
		{
			using (var client = new WebClient())
			{
				var content = client.DownloadData(url);

				using (var stream = new MemoryStream(content))
				{
					var text = System.Text.Encoding.UTF8.GetString(stream.ToArray());
					var htmlDocument = new HtmlDocument();
					htmlDocument.LoadHtml(text);

					var title = htmlDocument.DocumentNode.SelectSingleNode("//meta[@property='og:title']").Attributes["content"].Value.Split(new string[] { ", by" }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault().Trim();
					var artist = htmlDocument.DocumentNode.SelectSingleNode("//meta[@property='og:title']").Attributes["content"].Value.Split(new string[] { ", by" }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault().Trim();

					var year = Convert.ToInt32(Igdb.GetYear(htmlDocument.DocumentNode.SelectSingleNode("//div[@class='tralbumData tralbum-credits']").InnerText.Trim()));
					var bandcampLink = htmlDocument.DocumentNode.SelectSingleNode("//meta[@property='og:url']").Attributes["content"].Value.Trim();

					var totalMinutes = 0;
					var totalSeconds = 0;

					foreach (var item in htmlDocument.DocumentNode.SelectNodes("//span[contains(@class, 'time secondaryText')]"))
					{
						var timeString = item.InnerText.Trim();
						var split = timeString.Split(':');

						if (split.Count() != 2)
						{
							continue;
						}

						var minutes = Convert.ToInt32(split[0]);
						var seconds = Convert.ToInt32(split[1]);

						totalMinutes += minutes;
						totalSeconds += seconds;
					}

					var runtime = totalMinutes + (int)Math.Round(totalSeconds / 60f, MidpointRounding.AwayFromZero);

					var destinationFile = Paths.TempAlbumCover;
					File.Delete($"{destinationFile}.png");
					Web.DownloadPNG(htmlDocument.DocumentNode.SelectSingleNode("//a[@class='popupImage']").Attributes["href"].Value.Trim(), destinationFile);

					return new Music
					{
						Artist = artist,
						Title = title,
						Year = year,
						_1001 = false,
						Runtime = runtime,
						SpotifyID = bandcampLink
					};
				}
			}
		}

		public static Music GetAlbumInfoSpotify(string albumID)
		{
			albumID = albumID.Split('/').LastOrDefault();

			var spotify = GetSpotifyClient();

			var album = spotify.Albums.Get(albumID).Result;

			var destinationFile = Paths.TempAlbumCover;

			File.Delete($"{destinationFile}.png");

			Web.DownloadPNG(album.Images.FirstOrDefault().Url, destinationFile);

			return new Music
			{
				Artist = string.Join(" and ", album.Artists.Select(x => x.Name).ToArray()),
				Title = album.Name,
				Year = album.ReleaseDate.Length == "1996".Length
				? int.Parse(album.ReleaseDate)
				: DateTime.Parse(album.ReleaseDate).Year,
				_1001 = false,
				Runtime = album.Tracks.Items.Sum(o => o.DurationMs) / 1000 / 60,
				SpotifyID = album.Id
			};
		}

		public static Music LoadLocal()
		{
			var json = File.ReadAllText(Paths.TempMusic);
			return JsonConvert.DeserializeObject<Music>(json);
		}

		public static void SaveLocal(Music music)
		{
			string json = JsonConvert.SerializeObject(music, Formatting.Indented);
			File.WriteAllText(Paths.TempMusic, json);
		}

		private static SpotifyClient GetSpotifyClient()
		{
			var config = SpotifyClientConfig.CreateDefault();

			var lines = File.ReadAllLines(@"..\..\..\Keys\spotify_key.txt");

			var clientId = lines[0];
			var clientSecret = lines[1];

			var request = new ClientCredentialsRequest(clientId, clientSecret);
			var response = new OAuthClient(config).RequestToken(request).Result;

			return new SpotifyClient(config.WithToken(response.AccessToken));
		}
	}
}