//https://www.codeeval.com/open_challenges/8/
//Write a program which reverses the words in an input sentence.
//INPUT SAMPLE:
//The first argument is a file that contains multiple sentences, one per line.Empty lines are also possible.
//For example:
//Hello World
//Hello CodeEval
//OUTPUT SAMPLE:
//Print to stdout each sentence with the reversed words in it, one per line.Empty lines in the input should be ignored.Ensure that there are no trailing empty spaces in each line you print.
//For example:
//World Hello
//CodeEval Hello

using System;
using System.IO;
using System.Linq;

namespace _008_REVERSE_WORDS
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var arr = File.ReadAllLines(args[0]).Select(x => x.Split(' '));
            foreach (var list in arr)
                Console.WriteLine(string.Join(" ", list.Reverse()));

            return 0;
        }
    }
}