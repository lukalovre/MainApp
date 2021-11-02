using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Controller
{
	public static class CsvHelper
	{
		public static List<T> GetFromList<T>(string listFolderPath, string listName)
		{
			var result = new List<T>();

			var listPath = Path.Combine(listFolderPath, $"{listName}.csv");
			var text = File.ReadAllText(listPath);
			var reader = new StringReader(text);

			var config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				HeaderValidated = null,
				MissingFieldFound = null
			};

			using (var csv = new CsvReader(reader, config))
			{
				result.AddRange(csv.GetRecords<T>());
			}

			return result;
		}
	}
}