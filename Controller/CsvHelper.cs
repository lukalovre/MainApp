using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Controller
{
	public static class CsvHelper
	{
		public static string Create(List<int> people)
		{
			return string.Join(",", people);
		}

		public static List<string> Get(string csv)
		{
			return csv.Split(',').ToList();
		}

		public static List<T> GetFromList<T>(string listFolderPath, string listName, out DateTime updatedDate)
		{
			var listPath = Path.Combine(listFolderPath, $"{listName}.csv");
			updatedDate = File.GetLastWriteTime(listPath);

			var text = File.ReadAllText(listPath);
			var reader = new StringReader(text);

			var config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				HeaderValidated = null,
				MissingFieldFound = null
			};

			using (var csv = new CsvReader(reader, config))
			{
				return csv.GetRecords<T>().ToList();
			}
		}
	}
}