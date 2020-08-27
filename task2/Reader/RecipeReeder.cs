using Newtonsoft.Json;
using System;
using System.IO;
using task2.Models;

namespace task2.Reader
{
    class RecipeReeder
    {
        public static ModelRecipe Read(string PATH)
        {
            try
            {
                return JsonConvert.DeserializeObject<ModelRecipe>(File.ReadAllText($"{Environment.CurrentDirectory}\\{PATH}.json"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
