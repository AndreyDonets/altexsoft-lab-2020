using Newtonsoft.Json;
using System;
using System.IO;
using task2.Models;

namespace task2
{
    class RecipeHelper : modelRecipe
    {
        public void Add(modelRecipe recipe)
        {
            File.WriteAllText($"{Environment.CurrentDirectory}\\{recipe.Name}.json", JsonConvert.SerializeObject(recipe));       
        }
    }
}
