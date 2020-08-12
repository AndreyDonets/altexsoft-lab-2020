using System;
using System.Collections.Generic;
using System.IO;

namespace altexsoft_lab_2020
{
    class Program
    {
        static void Cut()
        {
            Console.WriteLine("Введите путь к файлу");
            string path = Console.ReadLine();
            Console.Clear();
            string text = _textFormatHelper.GetTextFromFile(path);
            Console.WriteLine("Введите символ/слово для удаления");
            string word = Console.ReadLine();
            Console.Clear();
            var result = _textFormatHelper.Cut(text, word);

            Console.WriteLine(string.IsNullOrEmpty(result) ? (word + " в тексте нет") : result);

            Console.WriteLine("Нажмите чтобы продолжить");
            Console.ReadLine();
            Console.Clear();
        }
        static void Words()
        {
            Console.WriteLine("Введите путь к файлу");
            string path = Console.ReadLine();
            Console.Clear();
            string text = _textFormatHelper.GetTextFromFile(path);
            var allWords = _textFormatHelper.GetEveryWord(text);
            var everyTenString = _textFormatHelper.GetEvery10Word(text);
            Console.Clear();
            Console.WriteLine(everyTenString);
            Console.WriteLine($"Слов в тексте: {allWords}");
            Console.WriteLine("Нажмите чтобы продолжить");
            Console.ReadLine();
            Console.Clear();
        }
        static void Sentence()
        {
            Console.WriteLine("Введите путь к файлу");
            string path = Console.ReadLine();
            Console.Clear();
            string text = _textFormatHelper.GetTextFromFile(path);
            string sentence = null;
            string sentenceBack = null;
            if (text != null)
                sentence = _textFormatHelper.ThirdSentences(text);
            if (text != null && sentence != null)
                sentenceBack = _textFormatHelper.SentenseBack(sentence);
            Console.WriteLine(sentenceBack ?? "result is null");
            Console.WriteLine("Наэмите чтобы продолжить");
            Console.ReadLine();
            Console.Clear();
        }

        static void FindFile()
        {

            Console.WriteLine("Введите путь к файлу");
            string path = Console.ReadLine();
            Console.Clear();
            if (Directory.Exists(path))
            {
                while (true)
                {
                    Console.Clear();
                    Dictionary<int, string> openWith = _textFormatHelper.Value(path);
                    if (path == "exit")
                        break;
                    Console.WriteLine("Выберите директорию или файл по номеру:");
                    foreach (KeyValuePair<int, string> kvp in openWith)
                    {
                        int openIndex = kvp.Value.IndexOf(' ');
                        int closeIndex = kvp.Value.LastIndexOf('\\');
                        string a = kvp.Value.Remove(kvp.Value.IndexOf(' ') + 1, closeIndex - openIndex);
                        Console.WriteLine("{0}\t{1}",
                            kvp.Key, a);
                    }
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        openWith.TryGetValue(number, out string open);
                        path = open.Substring(open.IndexOf(' ') + 1);
                        Console.Clear();
                        if (File.Exists(path))
                        {
                            Console.WriteLine("Поздравляю вы нашли то что искали, нажмите любую клавишу чтобы продолжить");
                            Console.ReadLine();
                            break;
                        }
                        openWith.Clear();
                    }
                }
            }
            
            
            
        }

        private static readonly TextFormatHelper _textFormatHelper = new TextFormatHelper();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - удалить символ/слово с текста." +
                    "\n2 - посчитать количество слов и вывести каждое десятое." +
                    "\n3 - вывести 3-е предложение в тексте. Все буквы слов в обратном порядке." +
                    "\n4 - поиск папок и файлов" +
                    "\nexit - для выхода с программы");
                string number = Console.ReadLine();
                Console.Clear();
                if (number == "exit") break;
                switch (number)
                {
                    case "1":
                        Cut();
                        break;
                    case "2":
                        Words();
                        break;
                    case "3":
                        Sentence();
                        break;
                    case "4":
                        FindFile();
                        break;
                }
            }
        }
    }
}




