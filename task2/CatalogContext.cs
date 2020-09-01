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
			FileReader fileReader = new FileReader();
			fileReader.Read(Categories);
			fileReader.Read(Recipes);
			fileReader.Read(Ingredients);
		}

		public List<Category> Categories { get; }
		public List<Recipe> Recipes { get; }
		public List<Ingredient> Ingredients { get; }

		public void SaveChanges()
		{
			FileSaver fileSaver = new FileSaver();
			fileSaver.Save(Recipes);
			fileSaver.Save(Ingredients);
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}