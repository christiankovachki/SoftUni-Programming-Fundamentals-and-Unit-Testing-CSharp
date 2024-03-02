namespace _01._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int sum = numbers[i] + numbers[numbers.Length - 1 - i];
                result.Add(sum);
            }

            if (numbers.Length % 2 == 1)
            {
                result.Add(numbers[numbers.Length / 2]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}