//https://www.codeeval.com/open_challenges/2/
//Write a program which reads a file and prints to stdout the specified number of the longest lines that are sorted based on their length in descending order.
//INPUT SAMPLE:
//Your program should accept a path to a file as its first argument.The file contains multiple lines.The first line indicates the number of lines you should output, the other lines are of different length and are presented randomly.You may assume that the input file is formatted correctly and the number in the first line is a valid positive integer.
//For example:
//Hello World
//CodeEval
//Quick Fox
//A
//San Francisco
//OUTPUT SAMPLE:
//Print out the longest lines limited by specified number and sorted by their length in descending order.
//For example:
//San Francisco
//Hello World

using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace LONGEST_LINES
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var arr = File.ReadAllLines(args[0]).ToList();
            if (arr.Any(x => x == null) || !Regex.IsMatch(arr[0], @"^\d+$"))
                return 1;

            var count = int.Parse(arr[0]);
            arr.Remove(arr[0]);
            arr = arr.OrderByDescending(c => c.Length).ToList();

            for (var i = 0; i < count; i++)
                Console.WriteLine(arr[i]);

            return 0;
        }
    }
}