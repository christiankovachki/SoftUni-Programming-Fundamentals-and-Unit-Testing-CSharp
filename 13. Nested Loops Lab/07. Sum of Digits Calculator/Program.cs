namespace _07._Sum_of_Digits_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (!input.Equals("End"))
            { 
                int number = int.Parse(input);

                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                Console.WriteLine($"Sum of digits = {sum}");
                
                input = Console.ReadLine();
            }

            Console.WriteLine("Goodbye");
        }
    }
}