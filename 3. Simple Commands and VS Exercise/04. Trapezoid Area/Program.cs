﻿using System.Collections.Generic;

namespace _04._Trapezoid_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstBase = int.Parse(Console.ReadLine());
            int secondBase = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = (firstBase + secondBase) / 2 * height;

            Console.WriteLine(area);
        }
    }
}