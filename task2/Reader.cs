using Newtonsoft.Json;
using System;
using System.IO;

namespace task2
{
    public class Reader<T>
    {
        private readonly string _path;
        public Reader(string path)
        {
            _path = $"{Environment.CurrentDirectory}\\{path}.json";
        }
        public T Read()
        {
            try
            {

                return JsonConvert.DeserializeObject<T>(File.ReadAllText(_path));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }
    }
}
