namespace _02._Average_Last_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = numbers.Length - 1; i >= numbers.Length - n; i--)
            {
                sum += numbers[i];
            }

            double average = sum * 1.0 / n;
            Console.WriteLine($"{average:F2}");
        }
    }
}