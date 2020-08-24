using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using task2.Models;

namespace task2.Reader
{
    class SubdirectoryReed
    {
        public static List<modelSubdirectory> Read(string PATH)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<modelSubdirectory>>(File.ReadAllText($"{Environment.CurrentDirectory}\\{PATH}.json"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
