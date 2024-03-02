namespace _05._Square_of_7_By_7_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
