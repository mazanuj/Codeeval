//https://www.codeeval.com/open_challenges/7/
//You are given a prefix expression. Write a program which evaluates it.
//INPUT SAMPLE:
//Your program should accept a file as its first argument.The file contains one prefix expression per line.
//For example:
//* + 2 3 4
//Your program should read this file and insert it into any data structure you like. Traverse this data structure and evaluate the prefix expression.Each token is delimited by a whitespace. You may assume that sum ‘+’, multiplication ‘*’ and division ‘/’ are the only valid operators appearing in the test data.
//OUTPUT SAMPLE:
//Print to stdout the output of the prefix expression, one per line.
//For example:
//20
//CONSTRAINTS:
//The evaluation result will always be an integer ≥ 0.
//The number of the test cases is ≤ 40.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _007_PREFIX_EXPRESSIONS
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var arr = Input.Select(x => x.Split(' ')); //File.ReadAllLines(args[0]).Select(x => x.Split(' ')).ToList();

            foreach (var stringse in arr)
            {

                Console.WriteLine(string.Join(" ", stringse));
            }

            return 0;
        }

        private static readonly List<string> Input = new List<string>
        {
            "+ * * / / + / 1 5 2 3 2 0 9 0",
            "/ * + + * / 0 7 0 1 5 2 6",
            "+ * / * * / + * / * + + 4 6 2 2 5 1 9 8 6 9 4 0 4",
            "* / + * * / + * * * / + + * * 5 1 9 4 2 4 5 0 1 0 7 6 5 3 6 8",
            "* * / + * + / / / / / * + * / 8 1 9 5 4 9 2 3 9 1 0 6 5 4 5 0",
            "/ / / * / / / + / + / * + + / + / * * / * 9 2 9 7 1 5 4 9 1 3 6 2 5 3 1 7 6 4 0 3 8 7",
            "+ / * * + + * * * * * * + * 6 6 2 8 3 9 5 8 8 4 7 1 2 2 5",
            "+ * 9 2 0",
            "* / 5 4 0",
            "* + + * + * * * + + * / 4 5 6 1 3 0 0 7 4 9 2 3 8",
            "/ * * 5 1 6 3",
            "* + * * + + + + * + + * * * * + + + / + 0 2 8 2 6 9 8 5 3 9 4 6 5 1 1 3 4 6 7 8 5",
            "* / * + + * / * * * + + * + / + / * + / * * / / / * / + 5 3 1 0 7 2 4 3 7 1 8 6 6 0 5 5 4 1 9 9 8 3 8 0 4 9 6 2 2",
            "* / * + * + 7 7 3 6 5 4 9",
            "* 9 8",
            "/ / / * + * + + / * + / + * * / + + * * * + + / / / / 4 1 5 6 1 4 0 7 5 7 9 3 9 1 8 8 2 5 3 3 7 8 0 6 0 4 9 2",
            "* + * * * + + / * * / / + + / 4 9 0 1 1 8 4 4 9 3 5 0 3 3 5 8",
            "* * * + * * + 6 6 4 2 6 7 3 5",
            "+ + + + 6 0 1 1 4",
            "/ * * / * / 4 6 5 8 3 0 1",
            "+ * + * + + / + / + + * + * / / * * 8 6 5 6 8 5 9 7 3 6 7 2 4 5 7 2 4 0 1",
            "+ * * * / * + + + 1 4 7 8 6 2 9 3 5 2",
            "/ 8 4",
            "* + 2 3 4",
            "+ 9 3",
            "* 0 0",
            "* * + / 7 1 5 8 9",
            "* + * + / + / / * 0 3 1 9 2 9 3 9 5 4",
            "* * + * * + + 3 2 4 8 0 5 6 3",
            "* / * / 2 5 4 1 5",
            "/ * / * / / + / + + * 6 7 3 9 1 8 1 7 0 7 0 2",
            "/ * * / * / + + / * + * * + * / 9 4 6 7 3 2 5 8 6 1 3 8 5 4 0 2 2",
            "/ * / * * * * * 8 3 1 9 5 7 9 2 6",
            "+ + 0 7 9",
            "* / + + / * * + + + * / + + * 7 5 6 0 1 7 7 9 5 2 3 4 2 8 8 1",
            "/ * * * 3 9 5 7 5",
            "* + + + * + * * * * * * + + + + * * / + + / * / / 7 1 4 5 2 3 6 9 9 1 2 5 7 1 8 3 9 7 5 0 6 8 8 0 0 2",
            "+ + + / + * / + / / + + * + + / * * * + 9 9 4 7 5 4 2 6 2 8 0 3 1 7 6 6 8 1 8 0 5",
            "+ / 0 6 8",
            "* * + * * * * * + / 3 8 1 2 7 7 2 5 8 6 3"
        };
    }
}