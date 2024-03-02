namespace _03._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            integers.RemoveAll(num => num < 0);

            if (integers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                integers.Reverse();
                Console.WriteLine(string.Join(" ", integers));
            }
        }
    }
}