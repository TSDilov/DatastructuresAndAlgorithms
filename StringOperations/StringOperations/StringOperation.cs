namespace StringOperations
{
    public static class StringOperation
    {
        public static string WithOutDublicates(string keyString)
        {
            var result = "";
            foreach (var key in keyString.ToLower()) 
            {
                if (result.IndexOf(key) == -1)
                {
                    result += key;
                }
            }

            return result;
        }

        public static bool AreAnagrams(string first, string second)
        {
            var firstChars = first.ToLower().ToCharArray();
            var secondChars = second.ToLower().ToCharArray();

            Array.Sort(firstChars);
            Array.Sort(secondChars);

            var newFirst = new string(firstChars);
            var newSecond = new string(secondChars);
            return newFirst == newSecond;
        }
    }
}
