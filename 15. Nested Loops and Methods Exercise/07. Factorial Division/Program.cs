
namespace _07._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());

            int firstFact = GetFactorialOfNumber(firstN);
            int secondFact = GetFactorialOfNumber(secondN);

            int division = firstFact / secondFact;

            Console.WriteLine(division);
        }

        private static int GetFactorialOfNumber(int number)
        {
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}