using task2.Helpers;
using task2.Model;
using System;
using System.Collections.Generic;

namespace task2
{
	public class CatalogContext 
		: IDisposable
	{
		FileManager fileManager = new FileManager();
		JsonConverter jsonConverter = new JsonConverter();
		public CatalogContext()
		{
			Categories = jsonConverter.DeserializeCategories(fileManager.Read("categories"));
            Recipes = jsonConverter.DeserializeRecipes(fileManager.Read("recipes"));
			Ingredients = jsonConverter.DeserializeIngredients(fileManager.Read("ingredients"));
		}

		public List<Category> Categories { get; }
		public List<Recipe> Recipes { get; }
		public List<Ingredient> Ingredients { get; }

		public void SaveChanges()
		{
			fileManager.Save(jsonConverter.Save(Recipes), "recipes");
			fileManager.Save(jsonConverter.Save(Ingredients), "ingredients");
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}