using System;
using System.IO;

namespace Day02
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../input.txt");
            int totalScore = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char opponentShape = input[i][0];
                char myShape = input[i][2];
                int score = 0;

                // Rock strategy
                if (myShape == 'X')
                {
                    if (opponentShape == 'A')
                    {
                        score = 3;
                    }
                    else if (opponentShape == 'B')
                    {
                        score = 0;
                    }
                    else if (opponentShape == 'C')
                    {
                        score = 6;
                    }
                    score += 1;
                }
                // Paper strategy
                else if (myShape == 'Y')
                {
                    if (opponentShape == 'A')
                    {
                        score = 6;
                    }
                    else if (opponentShape == 'B')
                    {
                        score = 3;
                    }
                    else if (opponentShape == 'C')
                    {
                        score = 0;
                    }
                    score += 2;
                }
                // Scissors strategy
                else if (myShape == 'Z')
                {
                    if (opponentShape == 'A')
                    {
                        score = 0;
                    }
                    else if (opponentShape == 'B')
                    {
                        score = 6;
                    }
                    else if (opponentShape == 'C')
                    {
                        score = 3;
                    }
                    score += 3;
                }
                totalScore += score;
            }

            Console.WriteLine(totalScore);

            totalScore = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char opponentShape = input[i][0];
                char strategy = input[i][2];
                int score = 0;

                // Win strategy
                if (strategy == 'Z')
                {
                    if (opponentShape == 'A')
                    {
                        score = 2;
                    }
                    else if (opponentShape == 'B')
                    {
                        score = 3;
                    }
                    else if (opponentShape == 'C')
                    {
                        score = 1;
                    }
                    score += 6;
                }
                // Draw strategy
                else if (strategy == 'Y')
                {
                    if (opponentShape == 'A')
                    {
                        score = 1;
                    }
                    else if (opponentShape == 'B')
                    {
                        score = 2;
                    }
                    else if (opponentShape == 'C')
                    {
                        score = 3;
                    }
                    score += 3;
                }
                // Lose strategy
                else if (strategy == 'X')
                {
                    if (opponentShape == 'A')
                    {
                        score = 3;
                    }
                    else if (opponentShape == 'B')
                    {
                        score = 1;
                    }
                    else if (opponentShape == 'C')
                    {
                        score = 2;
                    }
                    score += 0;
                }
                totalScore += score;
            }

            Console.WriteLine(totalScore);
            Console.ReadKey();
        }
    }
}