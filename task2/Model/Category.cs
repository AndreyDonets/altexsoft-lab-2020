using Newtonsoft.Json;
using System.Collections.Generic;

namespace task2.Model
{
	[JsonObject]
	public class Category
		: BaseEntity
	{
		[JsonIgnore]
		public List<Recipe> Recipes { get; set; } = new List<Recipe>();
	}
}
