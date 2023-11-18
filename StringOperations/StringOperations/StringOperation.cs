using System.Security.Cryptography;

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

        public static bool IsAnagrams(string first, string second)
        {
            first = first.ToLower();
            second = second.ToLower();
            if (first.Length != second.Length)
            {
                return false;
            }

            var dic = new Dictionary<char, int>();
            for (int i = 0; i < first.Length; i++)
            {
                if (!dic.ContainsKey(first[i]))
                {
                    dic.Add(first[i], 1);
                }
                else
                {
                    dic[first[i]]++;
                }
            }

            for (int i = 0; i < second.Length; i++)
            {
                if (!dic.ContainsKey(second[i]))
                {
                    return false;
                }
                else
                {
                    dic[second[i]]--;
                }
            }

            foreach (var key in dic.Keys) 
            {
                if (dic[key] != 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static string ReverseString(string keyString)
        {
            var result = new char[keyString.Length];
            var iteration = keyString.Length - 1;
            foreach (var ch in keyString)
            {
                result[iteration--] = ch;
            }

            return new string(result);
        }

        public static int CountOfWords(string keyString)
        {
            var length = keyString.Length;
            keyString = keyString.Replace(" ", "");
            var newLength = keyString.Length;
            return 1 + length - newLength;
        }

        public static bool IsPalindrome(string keyString)
        {
            var min = 0;
            var max = keyString.Length - 1;
            while (true)
            {
                if (min > max)
                { return true; }
                var frontChar = keyString[min];
                var backChar = keyString[max];
                if (char.ToLower(frontChar) != char.ToLower(backChar))
                { return false; }
                min++;
                max--;
            }
        }

        public static char MostCommonChar(string keyString)
        {
            var charFrequency = new Dictionary<char, int>();
            foreach (var ch in keyString)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    if (charFrequency.ContainsKey(ch))
                    {
                        charFrequency[ch]++;
                    }
                    else 
                    { 
                        charFrequency[ch] = 0; 
                    }
                }
            }

            return charFrequency.OrderByDescending(ch => ch.Value).FirstOrDefault().Key;
        }

        public static bool IsUnique(string keyString)
        {
            var dictionaryWithChars = new Dictionary<char, int>();
            foreach (var ch in keyString)
            {
                if (!dictionaryWithChars.ContainsKey(ch))
                {
                    dictionaryWithChars.Add(ch, 1);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static string Replace(string keyString, string old, string newOne)
        {
            return keyString.Trim().Replace(old, newOne);
        }

        public static void AllSubStrings(string keyString)
        {
            for (int length = 1; length < keyString.Length; length++) 
            {
                for(int start = 0; start <= keyString.Length - length; start++) 
                {
                    var substring = keyString.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
