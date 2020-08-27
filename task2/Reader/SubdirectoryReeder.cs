using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using task2.Models;

namespace task2.Reader
{
    class SubdirectoryReeder
    {
        public static List<ModelSubdirectory> Read(string PATH)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<ModelSubdirectory>>(File.ReadAllText($"{Environment.CurrentDirectory}\\{PATH}.json"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
