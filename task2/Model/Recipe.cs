using Newtonsoft.Json;
using System.Collections.Generic;

namespace task2.Model
{
	public class Recipe 
		: BaseEntity
	{
		[JsonProperty("categoryId")]
		public int CategoryId { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("ingredients")]
		public List<string> Ingredients { get; set; }

		[JsonProperty("cookingSteps")]
		public List<string> CookingSteps { get; set; }
    }
}
