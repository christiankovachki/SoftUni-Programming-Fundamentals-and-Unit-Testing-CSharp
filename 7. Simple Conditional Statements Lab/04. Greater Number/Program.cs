﻿namespace _04._Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Greater number: {firstNumber}");
            }
            else
            {
                Console.WriteLine($"Greater number: {secondNumber}");
            }
        }
    }
}