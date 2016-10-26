//https://www.codeeval.com/open_challenges/10/
//Write a program which determines the Mth to the last element in a list.
//INPUT SAMPLE:
//The first argument is a path to a file.The file contains the series of space delimited characters followed by an integer.The integer represents an index in the list(1-based), one per line.
//For example:
//a b c d 4
//e f g h 2
//OUTPUT SAMPLE:
//Print to stdout the Mth element from the end of the list, one per line.If the index is larger than the number of elements in the list, ignore that input.
//For example:
//a
//g

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _010_MTH_TO_LAST_ELEMENT
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var arr = File.ReadAllLines(args[0]).Select(x => x.Split(' '));
            foreach (var list in arr.Select(x => new List<string>(x.Reverse())))
            {
                var m = int.Parse(list[0]);
                list.Remove(list[0]);
                if (m <= list.Count)
                    Console.WriteLine(list[m - 1]);
            }

            return 0;
        }
    }
}