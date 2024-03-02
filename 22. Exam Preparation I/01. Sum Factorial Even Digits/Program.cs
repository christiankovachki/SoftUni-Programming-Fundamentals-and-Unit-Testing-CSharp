namespace _01._Sum_Factorial_Even_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;

                if (digit % 2 == 0)
                {
                    int factorial = 1;

                    for (int i = digit; i >= 2 ; i--)
                    {
                        factorial *= i;
                    }

                    sum += factorial;
                }

                n /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}