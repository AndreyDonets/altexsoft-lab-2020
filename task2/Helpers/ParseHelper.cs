namespace task2.Helpers
{
    class ParseHelper
    {
        public static int Parse(string number)
        {
            if (int.TryParse(number, out int n))
            {
                return n;
            }
            return -1;
        }
    }
}
