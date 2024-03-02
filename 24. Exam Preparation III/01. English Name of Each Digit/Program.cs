
namespace _01._English_Name_of_Each_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                int digit = number % 10;

                string name = GetEnglishNameOfDigit(digit);

                Console.WriteLine(name);

                number /= 10;
            }
        }

        private static string GetEnglishNameOfDigit(int digit)
        {

            string name = string.Empty;

            if (digit == 1)
            {
                name = "one";
            }
            else if (digit == 2)
            {
                name = "two";
            }
            else if (digit == 3)
            {
                name = "three";
            }
            else if (digit == 4)
            {
                name = "four";
            }
            else if (digit == 5)
            {
                name = "five";
            }
            else if (digit == 6)
            {
                name = "six";
            }
            else if (digit == 7)
            {
                name = "seven";
            }
            else if (digit == 8)
            {
                name = "eight";
            }
            else if (digit == 9)
            {
                name = "nine";
            }

            return name;
        }
    }
}