using Newtonsoft.Json;
using System;
using System.IO;
using task2.Models;

namespace task2
{
    class RecipeHelper : ModelRecipe
    {
        public void Add(ModelRecipe recipe)
        {
            File.WriteAllText($"{Environment.CurrentDirectory}\\{recipe.Name}.json", JsonConvert.SerializeObject(recipe));       
        }
    }
}
