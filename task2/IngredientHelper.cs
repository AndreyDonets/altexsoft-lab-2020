using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using task2.Models;

namespace task2
{
    class IngredientHelper : Models.Ingredient
    {
        public void Add(List<Models.Ingredient> ingredients)
        {
            ingredients.Add(new Models.Ingredient { Name = Name });
            File.WriteAllText($"{Environment.CurrentDirectory}\\ingredients.json", JsonConvert.SerializeObject(ingredients));
        }
    }
}
