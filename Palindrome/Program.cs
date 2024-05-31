using System;

namespace Palindrome
{
    class Program
    {
        static bool checkIfPalindrome(string word)
        {
            if (word == null)
            {
                throw ArgumentNullException;
            }
            else if (word.Length < 2)
            {
                return true;
            }
            else
            {
                (checkIfPalindrome(word));
            }
        }
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine($"{arg} -> {checkIfPalindrome(arg)}");
            }
        }
    }
}
