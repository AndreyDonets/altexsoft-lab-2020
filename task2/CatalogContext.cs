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
		JsonConverter<Category> jsonConvertCategory = new JsonConverter<Category>();
		JsonConverter<Recipe> jsonConvertRecipe = new JsonConverter<Recipe>();
		JsonConverter<Ingredient> jsonConvertIngredient = new JsonConverter<Ingredient>();
		public CatalogContext()
		{
			Categories = jsonConvertCategory.Load(fileManager.Read("categories"));
            Recipes = jsonConvertRecipe.Load(fileManager.Read("recipes"));
			Ingredients = jsonConvertIngredient.Load(fileManager.Read("ingredients"));
		}

		public List<Category> Categories { get; }
		public List<Recipe> Recipes { get; }
		public List<Ingredient> Ingredients { get; }

		public void SaveChanges()
		{
			fileManager.Write(jsonConvertRecipe.Save(Recipes), "recipes");
			fileManager.Write(jsonConvertIngredient.Save(Ingredients), "ingredients");
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}