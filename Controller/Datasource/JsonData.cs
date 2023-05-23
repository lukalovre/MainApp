using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Controller
{
	public class JsonData : IDatasource
	{
		private static string s_password;
		private bool m_databaseOffline;

		public static void SetPassword(string password)
		{
			s_password = password;
		}

		public void Add<T>(T item) where T : class
		{
			var list = GetList<T>();
			list.Add(item);
			Save<T>(list);
		}

		public List<T> GetList<T>()
		{
			//SyncWithDatabase<T>();

			var type = typeof(T);
			var nameSpace = type.Namespace.Split('.').LastOrDefault();

			var listPath = Path.Combine(Settings.Instance.JsonDataPath, $"{nameSpace}.{type.Name}s.json");

			if (!Directory.Exists(Settings.Instance.JsonDataPath))
			{
				Directory.CreateDirectory(Settings.Instance.JsonDataPath);
			}

			if (!File.Exists(listPath))
			{
				File.Create(listPath);
				return new List<T>();
			}

			var json = File.ReadAllText(listPath);

			if (string.IsNullOrWhiteSpace(s_password))
			{
			}

			string decryptedstring = StringCipher.Decrypt(json, s_password);

			return JsonConvert.DeserializeObject<List<T>>(decryptedstring);
		}

		public void MakeBackup(string path)
		{
		}

		public void SyncWithDatabase<T>()
		{
			try
			{
				if (!m_databaseOffline)
				{
					var database = new Database();
					Save<T>(database.GetList<T>());
				}
			}
			catch
			{
				m_databaseOffline = true;
			}
		}

		public void Update<T>(T item) where T : class
		{
			var list = GetList<T>();
			var index = list.IndexOf(item);
			list[index] = item;
			Save<T>(list);
		}

		private void Save<T>(object o)
		{
			// readonly for now
			return;

			var type = typeof(T);
			var nameSpace = type.Namespace.Split('.').LastOrDefault();

			var listPath = Path.Combine(Settings.Instance.JsonDataPath, $"{nameSpace}.{type.Name}s.json");

			var jsonText = JsonConvert.SerializeObject(o, Formatting.Indented);

			var password = "<pass>";
			string encryptedstring = StringCipher.Encrypt(jsonText, password);

			File.WriteAllText(listPath, encryptedstring);
		}
	}
}