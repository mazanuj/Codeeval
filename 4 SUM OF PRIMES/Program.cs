//https://www.codeeval.com/open_challenges/4/
//Write a program which determines the sum of the first 1000 prime numbers.
//INPUT SAMPLE:
//There is no input for this program.
//OUTPUT SAMPLE:
//Print to stdout the sum of the first 1000 prime numbers.

using System;

namespace _4_SUM_OF_PRIMES
{
    public static class Program
    {
        public static int Main()
        {
            var sum = 0;
            for (int i = 1, j = 0; j < 1000; i++)
            {
                if (!IsPrime(i))
                    continue;

                sum += i;
                j++;
            }
            Console.WriteLine(sum);
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
    }
}