namespace _02._Middle_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstIndex = (ints.Length / 2) - 1;
            int secondIndex = ints.Length / 2;

            double averageValue = (ints[firstIndex] + ints[secondIndex]) / 2.0;
            Console.WriteLine($"{averageValue:F2}");
        }
    }
}