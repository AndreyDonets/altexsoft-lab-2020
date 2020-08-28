using Newtonsoft.Json;
using System;
using System.IO;

namespace task2
{
    class RecipeHelper : Models.Recipe
    {
        public void Add(Models.Recipe recipe)
        {
            File.WriteAllText($"{Environment.CurrentDirectory}\\{recipe.Name}.json", JsonConvert.SerializeObject(recipe));       
        }
    }
}