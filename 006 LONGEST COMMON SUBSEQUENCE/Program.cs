//https://www.codeeval.com/open_challenges/6/
//You are given two sequences. Write a program to determine the longest common subsequence between the two strings (each string can have a maximum length of 50 characters). NOTE: This subsequence need not be contiguous. The input file may contain empty lines, these need to be ignored.
//INPUT SAMPLE:
//The first argument will be a path to a filename that contains two strings per line, semicolon delimited.You can assume that there is only one unique subsequence per test case. E.g.
//XMJYAUZ;MZJAWXU
//OUTPUT SAMPLE:
//The longest common subsequence.Ensure that there are no trailing empty spaces on each line you print. E.g.
//MJAU

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _6_LONGEST_COMMON_SUBSEQUENCE
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var arr = File.ReadAllLines(args[0]).Select(x => x.Split(';'));
            foreach (var list in arr)
            {
                var subAll = new List<string>();
                for (int k = 0, index = 0; k < list[0].Length; k++)
                {
                    subAll.Add("");
                    for (var i = k; i < list[0].Length && index < list[1].Length; i++)
                    {
                        var position = list[1].IndexOf(list[0][i].ToString(), index);
                        if (position == -1)
                            continue;

                        index = ++position;
                        subAll[k] += list[0][i].ToString();
                    }
                }

                Console.WriteLine(subAll.OrderByDescending(x => x.Length).First());
            }

            return 0;
        }
    }
}