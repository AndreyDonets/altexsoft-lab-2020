using System.Text.RegularExpressions;

namespace altexsoft_lab_2020
{
    class GetEveryWord
    {
        public static MatchCollection GetWords()
        {
            string text = ReadText.GetText();
            string pattern = @"\w+'*\w*";
            Regex rgx = new Regex(pattern);
            return rgx.Matches(text);
        }
    }
}
