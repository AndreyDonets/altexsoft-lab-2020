using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using task2.Model;

namespace task2.Helpers
{
    class JsonConverter
    {
		public List<Category> DeserializeCategories(string text)
		{
			return JsonConvert.DeserializeObject<List<Category>>(text);
		}
		public List<Recipe> DeserializeRecipes(string text)
		{
			return JsonConvert.DeserializeObject<List<Recipe>>(text);
		}
		public List<Ingredient> DeserializeIngredients(string text)
		{
			return JsonConvert.DeserializeObject<List<Ingredient>>(text);
		}
		public string Save(List<Recipe> file)
		{
			return JsonConvert.SerializeObject(file, Formatting.Indented, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
		}
		public string Save(List<Ingredient> file)
		{
			return JsonConvert.SerializeObject(file, Formatting.Indented, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
		}
	}
}
