namespace _02._Max_Min_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            int minNumber = numbers[startIndex];
            int maxNumber = numbers[startIndex];
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
                else if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            Console.WriteLine(minNumber + maxNumber);
        }
    }
}