//https://www.codeeval.com/open_challenges/14/
//Write a program which prints all the permutations of a string in alphabetical order. We consider that digits < upper case letters < lower case letters. The sorting should be performed in ascending order.
//INPUT SAMPLE:
//Your program should accept a file as its first argument.The file contains input strings, one per line.
//For example:
//hat
//abc
//Zu6
//OUTPUT SAMPLE:
//Print to stdout the permutations of the string separated by comma, in alphabetical order.
//For example:
//aht,ath,hat,hta,tah,tha
//abc,acb,bac,bca,cab,cba
//6Zu,6uZ,Z6u,Zu6,u6Z,uZ6

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _014_STRING_PERMUTATIONS
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var arr = File.ReadAllLines(args[0]);
            foreach (var perm in arr.Select(GetPermutations))
                Console.WriteLine(string.Join(",", perm));

            return 0;
        }

        private static IEnumerable<string> GetPermutations(string word)
        {
            if (word.Length == 2)
            {
                var c = word.ToCharArray();
                var s = new string(new[] {c[1], c[0]});
                return new[] {word, s};
            }
            var result = new List<string>();
            var subsetPermutations = GetPermutations(word.Substring(1));
            var firstChar = word[0];
            foreach (var temp in subsetPermutations.Select(s => firstChar + s))
            {
                result.Add(temp);
                var chars = temp.ToCharArray();
                for (var i = 0; i < temp.Length - 1; i++)
                {
                    var t = chars[i];
                    chars[i] = chars[i + 1];
                    chars[i + 1] = t;
                    var s2 = new string(chars);
                    result.Add(s2);
                }
            }
            return result.OrderBy(x => x, StringComparer.Ordinal);
        }
    }
}