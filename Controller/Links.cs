using Controller.Extensions;
using HtmlAgilityPack;
using Model;
using Model.dbo;
using Model.Grid;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace Controller
{
	public class Links
	{
		public static LinkGrid Convert(Link link, List<LinkEvent> linkEvent)
		{
			return new LinkGrid
			{
				ID = link.ID,
				Title = link.Title,
				Count = linkEvent.Count
			};
		}

		public static Comic GetGoodreadsDataComic(string url)
		{
			Comic result = null;

			using (var client = new WebClient())
			{
				var content = client.DownloadData(url);
				using (var stream = new MemoryStream(content))
				{
					var text = System.Text.Encoding.UTF8.GetString(stream.ToArray());
					var htmlDocument = new HtmlDocument();
					htmlDocument.LoadHtml(text);

					var title = GetTitle(htmlDocument);
					var writer = GetWriter(htmlDocument);
					var year = GetYear(htmlDocument);
					var goodreadsID = GetGoogreadsID(url);
					var illustrator = htmlDocument.DocumentNode.SelectNodes("//span[contains(@class, 'ContributorLink__name')]").LastOrDefault().InnerText.Trim().TrimEndLegit("(Illustrator)").Trim();

					result = new Comic
					{
						Title = title,
						Writer = writer,
						Illustrator = illustrator,
						Year = year,
						GoodreadsID = goodreadsID
					};
				}
			}

			return result;
		}

		private static int GetGoogreadsID(string url)
		{
			return System.Convert.ToInt32(url
									.TrimStartLegit("https://www.goodreads.com/book/show/")
									.TrimStartLegit("https://www.goodreads.com/en/book/show/")
									.Trim().Split('.').First().Split('-').First());
		}

		private static int GetYear(HtmlDocument htmlDocument)
		{
			return System.Convert.ToInt32(Igdb.GetYear(htmlDocument.DocumentNode.SelectNodes("//p[contains(@data-testid, 'publicationInfo')]").FirstOrDefault().InnerText.Trim()));
		}

		private static string GetWriter(HtmlDocument htmlDocument)
		{
			return htmlDocument.DocumentNode.SelectNodes("//span[contains(@class, 'ContributorLink__name')]").FirstOrDefault().InnerText.Replace("(Goodreads Author)", "").Trim().TrimEnd(',');
		}

		private static string GetTitle(HtmlDocument htmlDocument)
		{
			return htmlDocument.DocumentNode.SelectNodes("//h1[contains(@class, 'Text Text__title1')]").FirstOrDefault().InnerText.Trim().TrimEndLegit(", Volume 1").TrimEndLegit(", Vol. 1").Trim();
		}

		public static Model.Collection.Comic GetGoodreadsDataComicCollection(string url)
		{
			var comic = GetGoodreadsDataComic(url);

			return new Model.Collection.Comic
			{
				Title = comic.Title,
				Writer = comic.Writer,
				Illustrator = comic.Illustrator,
				GoodreadsID = comic.GoodreadsID
			};
		}

		public static Model.Collection.Book GetGoodreadsDataBook(string url)
		{
			Model.Collection.Book result = null;

			using (var client = new WebClient())
			{
				var content = client.DownloadData(url);
				using (var stream = new MemoryStream(content))
				{
					var text = System.Text.Encoding.UTF8.GetString(stream.ToArray());
					var htmlDocument = new HtmlDocument();
					htmlDocument.LoadHtml(text);

					var title = GetTitle(htmlDocument);
					var writer = GetWriter(htmlDocument);
					var year = GetYear(htmlDocument);
					var goodreadsID = GetGoogreadsID(url);
					var pages = System.Convert.ToInt32(GetPages(htmlDocument.DocumentNode.SelectNodes("//p[contains(@data-testid, 'pagesFormat')]").FirstOrDefault().InnerText.Trim()));

					result = new Model.Collection.Book
					{
						Title = title,
						Author = writer,
						Year = year,
						GoodreadsID = goodreadsID,
						Pages = pages
					};
				}
			}

			return result;
		}

		public static string GetPages(string str)
		{
			var rows = str.Split('\n');
			var pagesRow = rows.FirstOrDefault(o => o.Contains("pages"));

			if (pagesRow == null)
			{
				return null;
			}

			return Regex.Match(pagesRow, @"\d+").Value;
		}

		public static string GetTitle(string url)
		{
			using (var client = new WebClient())
			{
				var content = client.DownloadData(url);
				using (var stream = new MemoryStream(content))
				{
					string result = System.Text.Encoding.UTF8.GetString(stream.ToArray());

					var htmlDocument = new HtmlDocument();
					htmlDocument.LoadHtml(result);
					var node = htmlDocument.DocumentNode.SelectSingleNode("//head/title");

					if (node == null || string.IsNullOrWhiteSpace(node.InnerText))
					{
						return string.Empty;
					}

					return node.InnerText.Trim();
				}
			}
		}

		public static YoutubeData GetYouTubeChannelNamData(string url)
		{
			using (var client = new WebClient())
			{
				var content = client.DownloadData(url);
				using (var stream = new MemoryStream(content))
				{
					string result = System.Text.Encoding.UTF8.GetString(stream.ToArray());

					var htmlDocument = new HtmlDocument();
					htmlDocument.LoadHtml(result);
					var node = htmlDocument.DocumentNode.SelectSingleNode("//meta[contains(@property, 'og:title')]");
					var title = node.GetAttributeValue("content", string.Empty).Trim();

					if (node == null || string.IsNullOrWhiteSpace(title))
					{
						return null;
					}

					var handle = url.TrimStartLegit("https://www.youtube.com/");

					var posterNode = htmlDocument.DocumentNode.SelectSingleNode("//meta[contains(@property, 'og:image')]");
					var imageLink = posterNode.GetAttributeValue("content", string.Empty).Trim();

					var destinationFile = Path.Combine(Paths.Posters, $"{handle}");
					Web.DownloadPNG(imageLink, destinationFile);

					return new YoutubeData
					{
						Title = title,
						ID = handle
					};
				}
			}
		}
	}
}