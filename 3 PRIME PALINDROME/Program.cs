//https://www.codeeval.com/open_challenges/3/
//Write a program which determines the largest prime palindrome less than 1000.
//INPUT SAMPLE:
//There is no input for this program.
//OUTPUT SAMPLE:
//Print to stdout the largest prime palindrome less than 1000.
//929

using System;

namespace _3_PRIME_PALINDROME
{
    public static class Program
    {
        public static int Main()
        {
            for (var i = 999; i > 0; i--)
                if (IsPrime(i) && IsPalindrome(i))
                {
                    Console.WriteLine(i);
                    break;
                }

            return 0;
        }

        private static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int) Math.Floor(Math.Sqrt(number));

            for (var i = 2; i <= boundary; ++i)
                if (number%i == 0) return false;

            return true;
        }

        private static bool IsPalindrome(int ss)
        {
            var s = ss.ToString();
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray) == s;
        }
    }
}