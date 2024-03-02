
namespace _08._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            string sign = GetMultiplicationSign(num1, num2, num3);
            Console.WriteLine(sign);
        }

        private static string GetMultiplicationSign(int num1, int num2, int num3)
        {
            string sign = "";

            int product = num1 * num2 * num3;

            if (product == 0)
            {
                sign = "zero";
            }
            else if (product > 0)
            {
                sign = "positive";
            }
            else if (product < 0)
            {
                sign = "negative";
            }

            return sign;
        }
    }
}