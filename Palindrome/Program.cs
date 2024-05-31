using System;

namespace Palindrome
{
    class Program
    {
        static bool CheckIfPalindrome(string word)
        {
            bool isPalindrome()
            {
                word = word.ToLower();
                char[] chars = word.ToCharArray();

                string newString = "";

                foreach (char c in chars)
                {
                    newString = $"{c}{newString}";
                }

                if (newString == word) return true;
                else return false;
            }
            if (word == null)
            {
                throw new ArgumentNullException("Empty String.");
            }
            else if (word.Length < 2)
            {
                return true;
            }
            else
            {
                return isPalindrome();
            }
        }
        
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine($"{arg} -> {CheckIfPalindrome(arg)}");
            }
        }
    }
}
