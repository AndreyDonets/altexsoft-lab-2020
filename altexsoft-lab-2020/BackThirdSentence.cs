using System;

namespace altexsoft_lab_2020
{
    class BackThirdSentence
    {
        public static void GetBackThirdSentence()
        {
            string text = ReadText.GetText();
            string sentence = ThirdSentences.ThirdSentence(text);
            string sentenceBack = SentenceBack.ReverseSentence(sentence);
            Console.WriteLine(sentenceBack ?? "result is null");
            Console.WriteLine("Наэмите чтобы продолжить");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
