namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 0; i < countOfNumbers; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}