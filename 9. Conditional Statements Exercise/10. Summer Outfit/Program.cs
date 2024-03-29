﻿namespace _10._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();

            string clothing = "";
            string shoes = "";

            switch (timeOfTheDay) 
            {
                case "Morning":
                    if (temperature >= 10 && temperature <= 18)
                    {
                        clothing = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (temperature > 18 && temperature <= 24)
                    {
                        clothing = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature > 24)
                    {
                        clothing = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (temperature >= 10 && temperature <= 18)
                    {
                        clothing = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature > 18 && temperature <= 24)
                    {
                        clothing = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (temperature > 24)
                    {
                        clothing = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    if (temperature >= 10 && temperature <= 18)
                    {
                        clothing = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature > 18 && temperature <= 24)
                    {
                        clothing = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature > 24)
                    {
                        clothing = "Shirt";
                        shoes = "Moccasins";
                    }
                    break;
            }

            Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");

        }
    }
}