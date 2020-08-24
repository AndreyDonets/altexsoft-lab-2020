namespace altexsoft_lab_2020
{
    class ThirdSentences
    {
        public static string ThirdSentence(string text)
        {
            string sentence = null;
            if (text != null)
            {
                for (int i = 0; i < 3; i++)
                {
                    int openingPosition = text.IndexOf('.');
                    if (openingPosition == -1)
                        break;
                    openingPosition += 1;
                    if (i == 2)
                        sentence = text.Substring(0, openingPosition);
                    else
                        sentence = null;
                    text = text.Substring(openingPosition + 1);
                }
            }
            return sentence;
        }
    }
}
