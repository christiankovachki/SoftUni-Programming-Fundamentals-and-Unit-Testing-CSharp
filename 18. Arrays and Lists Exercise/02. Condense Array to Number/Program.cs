﻿namespace _02._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                while (numbers.Length != 1)
                {
                    int[] condensed = new int[numbers.Length - 1];

                    for (int i = 0; i < condensed.Length; i++)
                    {
                        condensed[i] = numbers[i] + numbers[i + 1];
                    }

                    numbers = condensed;
                }

                Console.WriteLine(numbers[0]);
            }
        }
    }
}