using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using task2.Models;

namespace task2
{
    class SubdirectoryHelper
    {
        public void Add(List<modelSubdirectory> recipes, string name, string path)
        {
            recipes.Add(new modelSubdirectory { Name = name });
            File.WriteAllText($"{Environment.CurrentDirectory}\\{path}.json", JsonConvert.SerializeObject(recipes));
        }
    }
}
