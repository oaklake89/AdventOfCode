using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day01
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../input.txt");
            int sum = 0;
            List<int> listSummation = new();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length < 1)
                {
                    listSummation.Add(sum);
                    sum = 0;
                }
                else
                {
                    sum += int.Parse(input[i]);
                }
            }

            Console.WriteLine(listSummation.Max()
                + "\r\n"
                + listSummation.OrderByDescending(x => x).ToList().Take(3).Sum());
            Console.ReadKey();
        }
    }
}