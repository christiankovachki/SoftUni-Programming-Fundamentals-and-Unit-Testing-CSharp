namespace _01._Number_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string output = String.Empty;

            if (number > 0)
            {
                output = "positive";
            }
            else if (number < 0)
            {
                output = "negative";
            }
            else if (number == 0)
            {
                output = "zero";
            }

            Console.WriteLine(output);
        }
    }
}