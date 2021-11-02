using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Controller
{
	public static class Following
	{
		private static Model.Following s_following;

		public static Model.Following FollowingModel
		{
			get
			{
				if(s_following == null)
				{
					s_following = Load();
				}

				return s_following;
			}
		}

		public static void Update(bool @checked, List<string> property, string id)
		{
			if(@checked)
			{
				if(!property.Contains(id))
				{
					property.Add(id);
				}
			}
			else
			{
				property.Remove(id);
			}

			string json = JsonConvert.SerializeObject(FollowingModel, Formatting.Indented);
			File.WriteAllText(Paths.Following, json);
		}

		private static Model.Following Load()
		{
			var json = File.ReadAllText(Paths.Following);
			return JsonConvert.DeserializeObject<Model.Following>(json);
		}
	}
}