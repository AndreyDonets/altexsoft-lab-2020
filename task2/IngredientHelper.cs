using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using task2.Models;

namespace task2
{
    class IngredientHelper : ModelIngredient
    {
        public void Add(List<ModelIngredient> ingredients)
        {
            ingredients.Add(new ModelIngredient { Name = Name });
            File.WriteAllText($"{Environment.CurrentDirectory}\\ingredients.json", JsonConvert.SerializeObject(ingredients));
        }
    }
}
