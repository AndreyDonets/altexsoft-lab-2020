using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using task2.Models;

namespace task2.Reader
{
    class IngredientReeder
    {
        private static readonly string INGREDIENTS_PATH = $"{Environment.CurrentDirectory}\\ingredients.json";
        public static List<modelIngredient> Read()
        {
            try
            {
                
                return JsonConvert.DeserializeObject<List<modelIngredient>>(File.ReadAllText(INGREDIENTS_PATH));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
