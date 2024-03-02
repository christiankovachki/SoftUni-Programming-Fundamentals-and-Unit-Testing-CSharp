namespace _05._Division_to_2__3_and_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int divisibleByTwoCounter = 0;
            int divisibleByThreeCounter = 0;
            int divisibleByFourCounter = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    divisibleByTwoCounter++;
                }

                if (number % 3 == 0)
                {
                    divisibleByThreeCounter++;
                }

                if (number % 4 == 0)
                {
                    divisibleByFourCounter++;
                }
            }

            double divisibleByTwoInPercentage = (divisibleByTwoCounter * 1.0 / n) * 100;
            double divisibleByThreeInPercentage = (divisibleByThreeCounter * 1.0 / n) * 100;
            double divisibleByFourInPercentage = (divisibleByFourCounter * 1.0 / n) * 100;

            Console.WriteLine($"{divisibleByTwoInPercentage:F2}%");
            Console.WriteLine($"{divisibleByThreeInPercentage:F2}%");
            Console.WriteLine($"{divisibleByFourInPercentage:F2}%");
        }
    }
}