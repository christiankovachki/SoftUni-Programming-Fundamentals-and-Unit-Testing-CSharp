namespace _04._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int i = 0;
            while (i < numbers.Count - 1)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    int sum = numbers[i] + numbers[i + 1];

                    numbers.RemoveAt(i);
                    numbers.RemoveAt(i);

                    numbers.Insert(i, sum);

                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}