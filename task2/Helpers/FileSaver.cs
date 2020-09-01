using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using task2.Model;

namespace task2.Helpers
{
    class FileSaver
    {
        public void Save(List<Recipe> file)
        {
            File.WriteAllText($"{Environment.CurrentDirectory}\\Data\\recipes.json", JsonConvert.SerializeObject(file,
        Formatting.Indented, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));
        }
        public void Save(List<Ingredient> file)
        {
            File.WriteAllText($"{Environment.CurrentDirectory}\\Data\\ingredients.json", JsonConvert.SerializeObject(file,
        Formatting.Indented, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));
        }
    }
}
