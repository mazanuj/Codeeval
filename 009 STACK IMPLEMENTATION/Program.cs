//https://www.codeeval.com/open_challenges/9/
//Write a program which implements a stack interface for integers. The interface should have ‘push’ and ‘pop’ functions. Your task is to ‘push’ a series of integers and then ‘pop’ and print every alternate integer.
//INPUT SAMPLE:
//Your program should accept a file as its first argument.The file contains a series of space delimited integers, one per line.
//For example:
//1 2 3 4
//10 -2 3 4
//OUTPUT SAMPLE:
//Print to stdout every alternate space delimited integer, one per line.
//For example:
//4 2
//4 -2

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _009_STACK_IMPLEMENTATION
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var arr = File.ReadAllLines(args[0]).Select(x => x.Split(' '));
            foreach (var list in arr.Select(listI => new List<string>(listI.Reverse())))
            {
                for (var i = 0; i < list.Count; i++)
                    if (i == 0 || i%2 == 0)
                        Console.Write($"{list[i]} ");
                Console.WriteLine();
            }

            return 0;
        }
    }
}