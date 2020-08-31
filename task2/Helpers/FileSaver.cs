using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Helpers
{
    class FileSaver<T>
    {
        public static void Save(T file, string name)
        {
            File.WriteAllText($"{Environment.CurrentDirectory}\\Data\\{name}.json", JsonConvert.SerializeObject(file));
        }
    }
}
