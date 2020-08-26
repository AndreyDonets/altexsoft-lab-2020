using System;
using System.IO;

namespace altexsoft_lab_2020
{
    class Text
    {
        public static string Get()
        {
            Console.WriteLine("Введите путь к файлу");

            while (true)
            {
                string path = Console.ReadLine();
                Console.Clear();
                try
                {
                    string text = File.ReadAllText(path);
                    if (!string.IsNullOrWhiteSpace(text))
                        return text;
                }
                catch
                {
                    Console.WriteLine("По данному пути файла нет, попробуйте еще раз");
                }
            }
        }
    }
}
