namespace _03._Reverse_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] integers = new int[n];
            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }

            int[] reversedInts = new int[n];
            for (int i = 0; i < reversedInts.Length; i++)
            {
                reversedInts[i] = integers[integers.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", reversedInts));
        }
    }
}