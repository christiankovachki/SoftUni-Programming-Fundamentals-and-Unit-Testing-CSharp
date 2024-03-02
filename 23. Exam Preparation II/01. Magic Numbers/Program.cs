namespace _01._Magic_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool hasMagicNumber = false;

            for (int i = 2; i <= n; i++)
            {
                int number = i;
                int sum = 0;
                bool isPrime = true;

                while (number > 0)
                {
                    int digit = number % 10;

                    if (digit == 2 || digit == 3 || digit == 5 || digit == 7)
                    {
                        sum += digit;
                    }
                    else
                    {
                        isPrime = false;
                        break;
                    }

                    number /= 10;    
                }

                if (isPrime && sum % 2 == 0)
                {
                    hasMagicNumber = true;
                    Console.Write($"{i} ");
                }
            }

            if (!hasMagicNumber)
            {
                Console.WriteLine("no");
            }
        }

        // Algorithm for finding if a number is PRIME
        static bool IsPrime(int number)
        {
            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            return isPrime;
        }
    }
}