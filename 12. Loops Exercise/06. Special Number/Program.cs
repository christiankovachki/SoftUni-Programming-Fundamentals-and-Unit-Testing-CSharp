using System;

namespace _06._Special_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = n;
            bool isNumberSpecial = true;

            while (n > 0)
            {
                int digit = n % 10;

                if (number % digit != 0)
                {
                    isNumberSpecial = false;
                    break;
                }

                n /= 10;
            }

            if (isNumberSpecial)
            {
                Console.WriteLine($"{number} is special");
            }
            else
            {
                Console.WriteLine($"{number} is not special");
            }
        }
    }
}