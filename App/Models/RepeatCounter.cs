using System;

namespace Application.Models
{
    public static class RepeatCounter
    {

        private static char[] letters = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'v'};

        private static bool IsLetter(char c)
        {
            return Array.IndexOf(letters, c) != -1;
        }

        private static string RemoveNonLetters(string input)
        {
            string output = "";
            char[] characters = input.ToCharArray();

            foreach(char c in characters)
            {
                if(IsLetter(c))
                {
                    output += c;
                }
            }

            return output;
        }

        public static bool CheckEqual(string s1, string s2)
        {
            s1 = RemoveNonLetters(s1.ToLower());
            s2 = RemoveNonLetters(s2.ToLower());

            if(s1 == "" || s2 == "")
            {
                return false;
            }

            return s1 == s2;
        }

        public static int GetWordCount(string sentence, string word)
        {
            return -1;
        }

    }
}
