using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using task2.Model;

namespace task2.Helpers
    {
	public class FileReader
	{
		private readonly string _path;
		public void Read(List<Category> categories)
		{
			categories = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\categories.json"));
		}
		public void Read(List<Recipe> recipes)
		{
			recipes = JsonConvert.DeserializeObject<List<Recipe>>(File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\recipes.json"));
		}
		public void Read(List<Ingredient> ingredients)
		{
			ingredients = JsonConvert.DeserializeObject<List<Ingredient>>(File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\ingredients.json"));
		}
	}
}
//{
//	public class FileReader<T>
//	{
//		private readonly string _path;
//		public FileReader(string name)
//		{
//			_path = $"{Environment.CurrentDirectory}\\Data\\{name}.json";
//		}

//		public T Read()
//		{
//			return JsonConvert.DeserializeObject<T>(File.ReadAllText(_path));
//		}
//	}
//}