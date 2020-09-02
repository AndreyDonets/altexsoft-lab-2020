using System;

namespace altexsoft_lab_2020
{
    class BackThirdSentence
    {
        public static void Get()
        {
            string text = Text.Get();
            string sentence = ThirdSentences.Get(text);
            string sentenceBack = SentenceBack.ReverseSentence(sentence);
            Console.WriteLine(sentenceBack ?? "result is null");
            Console.WriteLine("Наэмите чтобы продолжить");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
