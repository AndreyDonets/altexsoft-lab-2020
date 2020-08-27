using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace task2
{
    class CatalogReeder
    {
        private static readonly string CATALOG_PATH = $"{Environment.CurrentDirectory}\\catalog.json";
        public static List<ModelCatalog> Read()
        {
            try
            {
                return JsonConvert.DeserializeObject<List<ModelCatalog>>(File.ReadAllText(CATALOG_PATH));
                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
