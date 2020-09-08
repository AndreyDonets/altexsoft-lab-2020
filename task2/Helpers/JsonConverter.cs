using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using task2.Model;

namespace task2.Helpers
{
    class JsonConverter<T>
    {
        public List<T> Load(string text)
        {
            return JsonConvert.DeserializeObject<List<T>>(text);
        }
        public string Save(List<T> file)
        {
        	return JsonConvert.SerializeObject(file, Formatting.Indented, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
        }
    }
}