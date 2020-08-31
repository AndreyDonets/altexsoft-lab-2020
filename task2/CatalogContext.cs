using task2.Helpers;
using task2.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace task2
{
	public class CatalogContext 
		: IDisposable
	{
		public CatalogContext()
		{
			Categories = new FileReader<List<Category>>("categories").Read();
			Recipes = new FileReader<List<Recipe>>("recipes").Read();
			Ingredients = new FileReader<List<Ingredient>>("ingredients").Read();
		}

		public List<Category> Categories { get; }
		public List<Recipe> Recipes { get; }
		public List<Ingredient> Ingredients { get; }

		public void SaveChanges()
		{

			FileSaver<List<Recipe>>.Save(Recipes, "recipes");
			FileSaver<List<Ingredient>>.Save(Ingredients, "ingredients");

			// Реализовать перезапись файлов в соответствии с нужным листом Категории -  $"{Environment.CurrentDirectory}/category.json";
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}