//https://www.codeeval.com/open_challenges/26/submit/
// Print the size of a file in bytes.
//INPUT:
//The first argument to your program has the path to the file you need to check the size of.
//OUTPUT SAMPLE:
//Print the size of the file in bytes.E.g.
//55

using System;
using System.IO;

namespace FILE_SIZE
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var fi = new FileInfo(args[0]);
            Console.WriteLine(fi.Length);

            return 0;
        }
    }
}