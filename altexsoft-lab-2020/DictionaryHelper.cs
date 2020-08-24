using System;
using System.Collections.Generic;
using System.IO;

namespace altexsoft_lab_2020
{
    public class DictionaryHelper
    {
        public static Dictionary<int, string> Value(string path)
        {

            Dictionary<int, string> openWith = new Dictionary<int, string>();
            
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            Array.Sort(dirs);
            Array.Sort(files);
            for (int i = 0; i < dirs.Length; i++)
            {
                openWith.Add(i + 1, "dir\t " + dirs[i]);
            }
            for (int j = 0, i = dirs.Length; i < dirs.Length + files.Length; i++, j++)
            {
                openWith.Add(i + 1,"file\t " + files[j]);
            }
            openWith.Add(openWith.Count + 1, "exit");
            return openWith;
        }
    }
}
