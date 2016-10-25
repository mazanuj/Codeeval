//https://www.codeeval.com/open_challenges/5/
//Given a sequence, write a program to detect cycles within it.
//INPUT SAMPLE:
//Your program should accept as its first argument a path to a filename containing a sequence of numbers(space delimited). The file can have multiple such lines.E.g
//2 0 6 3 1 6 3 1 6 3 1
//3 4 8 0 11 9 7 2 5 6 10 1 49 49 49 49
//1 2 3 1 2 3 1 2 3
//OUTPUT SAMPLE:
//Print to stdout the first cycle you find in each sequence.Ensure that there are no trailing empty spaces on each line you print. E.g.
//6 3 1
//49
//1 2 3
//The cycle detection problem is explained more widely on wiki
//Constrains: 
//The elements of the sequence are integers in range[0, 99]
//The length of the sequence is in range[0, 50]

using System;
using System.IO;
using System.Linq;

namespace _5_DETECTING_CYCLES
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var arr = File.ReadAllLines(args[0]).Select(x => x.Split(' '));

            foreach (var duplicateKeys in arr.Select(list => list.GroupBy(x => x)
                .Where(group => @group.Count() > 1)
                .Select(group => @group.Key)))
                Console.WriteLine(string.Join(" ", duplicateKeys));

            return 0;
        }
    }
}