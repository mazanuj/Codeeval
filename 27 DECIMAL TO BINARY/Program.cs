//https://www.codeeval.com/open_challenges/27/
//You are given a decimal (base 10) number, print its binary representation.
//INPUT SAMPLE:
//Your program should accept as its first argument a path to a filename containing decimal numbers greater or equal to 0, one per line.
//Ignore all empty lines.
//For example:
//1
//2
//3
//2
//10
//67
//OUTPUT SAMPLE:
//Print the binary representation, one per line.
//For example:
//10
//1010
//1000011


using System;
using System.IO;
using System.Linq;

namespace DECIMAL_TO_BINARY
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var arr = File.ReadAllLines(args[0]);
            foreach (
                var binary in
                    arr.Where(x => !string.IsNullOrEmpty(x))
                        .Select(int.Parse)
                        .Select(value => Convert.ToString(value, 2)))
                Console.WriteLine(binary);

            return 0;
        }
    }
}