using Newtonsoft.Json;
using System.Collections.Generic;

namespace task2.Model
{
	public class Recipe 
		: BaseEntity
	{
		public int CategoryId { get; set; }

		public string Description { get; set; }

		public List<RecipeIngredients> Ingredients { get; set; }

		public List<string> CookingSteps { get; set; }
    }
}
