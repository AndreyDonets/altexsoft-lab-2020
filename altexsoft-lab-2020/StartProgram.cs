using System;

namespace altexsoft_lab_2020
{
    class StartProgram
    {
        public static void Go()
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
                        CutCharOrWorld.Cut();
                        break;
                    case "2":
                        Words.WordsCount();
                        break;
                    case "3":
                        BackThirdSentence.GetBackThirdSentence();
                        break;
                    case "4":
                        FindFile.Find();
                        break;
                }
            }
        
        }
    }
}
