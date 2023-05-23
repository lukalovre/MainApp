using Newtonsoft.Json;
using System.Drawing;
using System.IO;

namespace Controller
{
	public class Settings
	{
		private static readonly JsonSerializerSettings m_jsonSetings = new JsonSerializerSettings
		{
			NullValueHandling = NullValueHandling.Include,
			Formatting = Formatting.Indented,
		};

		private static Settings m_instance;

		public enum eDatasource
		{
			Database = 1,
			Json = 2
		};

		public static Settings Instance
		{
			get
			{
				if (m_instance == null)
				{
					m_instance = Load();
				}

				return m_instance;
			}
		}

		public string DatabaseConnectionString { get; set; } = @"Data Source=<SQLServerInstanceName>;Initial Catalog=Main;Integrated Security=True";

		public eDatasource Datasource { get; set; } = eDatasource.Database;

		public string JsonDataPath { get; set; } = @"../../../Resources/JsonData";

		public Point Location { get; set; } = new Point(-1032, 1371);

		public Size Size { get; set; } = new Size(1040, 744);

		private static Settings Load()
		{
			if (!File.Exists(Paths.Settings))
			{
				File.WriteAllText(Paths.Settings, JsonConvert.SerializeObject(new Settings(), m_jsonSetings));
			}

			var settingsText = File.ReadAllText(Paths.Settings);
			return JsonConvert.DeserializeObject<Settings>(settingsText);
		}
	}
}