using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace task2
{
    class IngredientHelper : Models.Json
    {
        public void Add(List<Models.Json> ingredients)
        {
            ingredients.Add(new Models.Json { Name = Name });
            File.WriteAllText($"{Environment.CurrentDirectory}\\ingredients.json", JsonConvert.SerializeObject(ingredients));
        }
    }
}
