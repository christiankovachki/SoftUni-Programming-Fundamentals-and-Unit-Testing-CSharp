namespace _03._Odd_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n % 2 == 0)
            {
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(n);
        }
    }
}