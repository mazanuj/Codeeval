//https://www.codeeval.com/open_challenges/25/
//Print the odd numbers from 1 to 99.
//INPUT SAMPLE:
//There is no input for this program.
//OUTPUT SAMPLE:
//Print the odd numbers from 1 to 99, one number per line. 

using System;

namespace ODD_NUMBERS
{
    public static class Program
    {
        public static int Main()
        {
            for (var i = 1; i < 100; i++)
                if (i%2 != 0)
                    Console.WriteLine(i);

            return 0;
        }
    }
}