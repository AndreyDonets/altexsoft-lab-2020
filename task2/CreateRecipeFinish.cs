using Newtonsoft.Json;
using System;
using System.IO;
using task2.Models;

namespace task2
{
    class CreateRecipeFinish : modelRecipe
    {
        public void Create(modelRecipe recipe)
        {
            File.WriteAllText($"{Environment.CurrentDirectory}\\{recipe.Name}.json", JsonConvert.SerializeObject(recipe));       
        }
    }
}
