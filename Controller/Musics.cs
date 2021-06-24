using Controller.Properties;
using Dapper.Contrib.Extensions;
using Model.dbo;
using SpotifyAPI.Web;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace Controller
{
	public class Musics
	{
		public static void FindAlbum(Music music)
		{
			var destinationFile = Path.Combine(Paths.Albums, $"{music.ItemID}.png");

			if(File.Exists(destinationFile) && music.SpotifyID != null)
			{
				return;
			}

			var spotify = GetSpotifyClient();

			var albumSearchList = spotify.Search.Item(new SearchRequest(SearchRequest.Types.Album, music.Title)).Result;

			SimpleAlbum foundAlbum = null;

			foreach(var albumInfo in albumSearchList.Albums.Items)
			{
				DateTime.TryParse(albumInfo.ReleaseDate, out var date);

				if(albumInfo.Artists.Any(o => o.Name == music.Artist)
					&&
					(albumInfo.ReleaseDate == music.Year.ToString()
					|| date.Year == music.Year))
				{
					foundAlbum = albumInfo;
					break;
				}
			}

			if(foundAlbum != null)
			{
				Web.Download(foundAlbum.Images.FirstOrDefault().Url, destinationFile);

				music.SpotifyID = foundAlbum.Id;

				using(var sqlConnection = new SqlConnection(Resources.MainConnectionString))
				{
					sqlConnection.Open();
					sqlConnection.Update(music);
				}
			}
			else
			{
			}
		}

		public static Music GetAlbumInfo(string albumID)
		{
			albumID = albumID.Split('/').LastOrDefault();

			var spotify = GetSpotifyClient();

			var album = spotify.Albums.Get(albumID).Result;

			var destinationFile = Path.Combine(Paths.Albums, $"_temp.png");

			File.Delete(destinationFile);

			Web.Download(album.Images.FirstOrDefault().Url, destinationFile);

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