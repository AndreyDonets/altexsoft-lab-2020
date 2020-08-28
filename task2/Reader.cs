using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace task2
{
    public class Reader<T>
    {
        public string path;
        public void Path(string path)
        {
            path = $"{Environment.CurrentDirectory}\\{path}.json";
        }
        public T Read()
        {
            try
            {

                return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }
    }
}
