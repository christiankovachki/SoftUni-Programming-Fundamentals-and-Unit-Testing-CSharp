namespace _04._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int sumOfEvenNumbers = 0;
            int sumOfOddNumbers = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    sumOfEvenNumbers += integers[i];
                }
                else
                {
                    sumOfOddNumbers += integers[i];
                }
            }

            Console.WriteLine(sumOfEvenNumbers - sumOfOddNumbers);
        }
    }
}