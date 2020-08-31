using Newtonsoft.Json;

namespace task2.Model
{
	public class BaseEntity
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name
		{
			get; set;
		}
	}
}
