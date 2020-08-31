using Newtonsoft.Json;
using System;
using System.IO;

namespace task2.Helpers
{
	public class FileReader<T>
	{
		private readonly string _path;
		public FileReader(string name)
		{
			_path = $"{Environment.CurrentDirectory}\\Data\\{name}.json";
		}

		public T Read()
		{
			return JsonConvert.DeserializeObject<T>(File.ReadAllText(_path));
		}
	}
}