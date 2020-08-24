using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using task2.Models;

namespace task2
{
    class CreateIngredient : modelIngredient
    {
        public void Create(List<modelIngredient> ingredients)
        {
            ingredients.Add(new modelIngredient { Name = Name });
            File.WriteAllText($"{Environment.CurrentDirectory}\\ingredients.json", JsonConvert.SerializeObject(ingredients));
        }
    }
}
