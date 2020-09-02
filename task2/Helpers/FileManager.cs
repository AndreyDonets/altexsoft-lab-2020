using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace task2.Helpers
{
    class FileManager
    {
        public string Read(string name)
        {
            return File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\{name}.json");
        }
        public void Save(string text, string name)
        {
            File.WriteAllText($"{Environment.CurrentDirectory}\\Data\\{name}.json", text);
        }
    }
}
