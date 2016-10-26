//https://www.codeeval.com/open_challenges/12/
//Write a program which finds the first non-repeated character in a string.
//INPUT SAMPLE:
//The first argument is a path to a file.The file contains strings.
//For example:
//yellow
//tooth
//OUTPUT SAMPLE:
//Print to stdout the first non-repeated character, one per line.
//For example:
//y
//h

using System;
using System.IO;
using System.Linq;

namespace _012_FIRST_NON_REPEATED_CHARACTER
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var arr = File.ReadAllLines(args[0]);
            foreach (var firstChar in arr.Select(list => list.GroupBy(x => x).First(x => x.Count() == 1).Key))
                Console.WriteLine(firstChar);

            return 0;
        }
    }
}