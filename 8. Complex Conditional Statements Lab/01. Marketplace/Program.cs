﻿namespace _01._Marketplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            if (product == "Banana")
            {
                if (day == "Weekday")
                {
                    price = 2.5;
                }
                else if (day == "Weekend")
                {
                    price = 2.7;
                }
            }
            else if (product == "Apple")
            {
                if (day == "Weekday")
                {
                    price = 1.3;
                }
                else if (day == "Weekend")
                {
                    price = 1.6;
                }
            }
            else if (product == "Kiwi")
            {
                if (day == "Weekday")
                {
                    price = 2.2;
                }
                else if (day == "Weekend")
                {
                    price = 3;
                }
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}