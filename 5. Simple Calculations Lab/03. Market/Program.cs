﻿using System.Diagnostics;

namespace _03._Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tomatoPrice = double.Parse(Console.ReadLine());
            double tomatoQuantity = double.Parse(Console.ReadLine());
            double cucumberPrice = double.Parse(Console.ReadLine());
            double cucumberQuantity = double.Parse(Console.ReadLine());

            double totalCost = (tomatoPrice * tomatoQuantity) + (cucumberPrice * cucumberQuantity);

            Console.WriteLine($"{totalCost:F2}");
        }
    }
}