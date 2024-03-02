namespace _04._Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 7; i <= n; i++)
            {
                if (i % 10 == 7)
                { 
                    Console.WriteLine(i);
                }
            }
        }
    }
}