using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using task2.Models;

namespace task2
{
    class SubdirectoryHelper
    {
        public void Add(List<ModelSubdirectory> recipes, string name, string path)
        {
            recipes.Add(new ModelSubdirectory { Name = name });
            File.WriteAllText($"{Environment.CurrentDirectory}\\{path}.json", JsonConvert.SerializeObject(recipes));
        }
    }
}
