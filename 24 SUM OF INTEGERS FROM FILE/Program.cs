//https://www.codeeval.com/open_challenges/24/
//Print out the sum of integers read from a file.
//INPUT SAMPLE:
//The first argument to the program will be a path to a filename containing a positive integer, one per line.E.g.
//5
//12
//OUTPUT SAMPLE:
//Print out the sum of all the integers read from the file. E.g.
//17

using System;
using System.IO;
using System.Linq;

namespace SUM_OF_INTEGERS_FROM_FILE
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var arr = File.ReadAllLines(args[0]);
            var total = arr.Sum(Convert.ToInt32);
            Console.WriteLine(total);

            return 0;
        }
    }
}