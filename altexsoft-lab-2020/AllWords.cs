using System.Text.RegularExpressions;

namespace altexsoft_lab_2020
{
    class AllWords
    {
        public static MatchCollection Get()
        {
            string text = Text.Get();
            string pattern = @"\w+'*\w*";
            Regex rgx = new Regex(pattern);
            return rgx.Matches(text);
        }
    }
}
