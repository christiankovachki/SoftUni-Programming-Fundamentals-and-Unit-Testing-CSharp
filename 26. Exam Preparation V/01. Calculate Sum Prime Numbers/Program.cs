namespace _01._Calculate_Sum_Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < countOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (IsPrime(number))
                {
                    sum += number;
                }
            }

            Console.WriteLine(sum);
        }

        static bool IsPrime(int number) 
        {
            if (number <= 1) 
            {
                return false;
            }
            
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}