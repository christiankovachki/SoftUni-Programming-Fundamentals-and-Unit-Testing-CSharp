namespace _01._Stupid_Passwords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i += 2)
            {
                for (int j = 1; j <= number; j += 2)
                {
                    int product = i * j;
                    Console.Write($"{i}{j}{product} ");
                }
            }
        }
    }
}