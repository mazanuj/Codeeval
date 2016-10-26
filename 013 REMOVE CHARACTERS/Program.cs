//https://www.codeeval.com/open_challenges/13/
//Write a program which removes specific characters from a string.
//INPUT SAMPLE:
//The first argument is a path to a file.The file contains the source strings and the characters that need to be scrubbed.Each source string and characters you need to scrub are delimited by comma.
//For example:
//how are you, abc
//hello world, def
//OUTPUT SAMPLE:
//Print to stdout the scrubbed strings, one per line.Ensure that there are no trailing empty spaces on each line you print.
//For example:
//how re you
//hllo worl

using System;
using System.IO;
using System.Linq;

namespace _013_REMOVE_CHARACTERS
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var arr = File.ReadAllLines(args[0]).Select(x => x.Split(new[] {", "}, StringSplitOptions.None));
            foreach (var output in from list in arr
                let output = list.First()
                let scr = list.Last().ToList()
                select scr.Aggregate(output, (current, s) => current.Replace(s.ToString(), "")))
                Console.WriteLine(output);

            return 0;
        }
    }
}