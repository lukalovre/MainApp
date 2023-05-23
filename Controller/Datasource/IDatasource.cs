using System.Collections.Generic;

namespace Controller
{
	public interface IDatasource
	{
		void Add<T>(T item) where T : class;

		List<T> GetList<T>();

		void MakeBackup(string path);

		void Update<T>(T item) where T : class;
	}
}