using System;
using System.Collections.Generic;
using System.IO;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../input.txt");
            List<int[]> ranges = new();
            int fullyContainedRanges = 0;
            int overlappingRanges = 0;

            foreach (string line in input)
            {
                string[] rangeStrings = line.Split(',');
                string[] range1String = rangeStrings[0].Split('-');
                int[] range1 = new int[int.Parse(range1String[1])
                    - int.Parse(range1String[0])
                    + 1];

                for (int i = 0; i < range1.Length; i++)
                {
                    range1[i] = int.Parse(range1String[0]) + i;
                }

                string[] range2String = rangeStrings[1].Split('-');
                int[] range2 = new int[int.Parse(range2String[1]) - int.Parse(range2String[0]) + 1];

                for (int i = 0; i < range2.Length; i++)
                {
                    range2[i] = int.Parse(range2String[0]) + i;
                }

                ranges.Add(range1);
                ranges.Add(range2);

                if (
                    (range1[0] <= range2[0]
                     && range1[^1] >= range2[^1]) || (range2[0] <= range1[0] && range2[^1] >= range1[^1])
                )
                {
                    fullyContainedRanges++;
                }

                if (
                    range1[0] <= range2[^1] && range1[^1] >= range2[0]
                )
                {
                    overlappingRanges++;
                }
            }

            Console.WriteLine(fullyContainedRanges
                + "\r\n"
                + overlappingRanges);
            Console.ReadKey();
        }
    }
}