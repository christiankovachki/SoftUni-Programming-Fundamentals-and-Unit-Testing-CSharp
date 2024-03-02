using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] numAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = numAndPower[0];
            int power = numAndPower[1];

            while (numbers.Contains(bombNumber))
            {
                int index = numbers.IndexOf(bombNumber);

                int end = Math.Max(0, index - power);
                int start = Math.Min(numbers.Count() - 1, index + power);

                for (int i = start; i >= end; i--)
                {
                    numbers.RemoveAt(i);
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}