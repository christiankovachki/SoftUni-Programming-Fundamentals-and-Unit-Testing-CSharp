namespace _07._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firtArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firtArray[i] = numbers[0];
                    secondArray[i] = numbers[1];
                }
                else
                {
                    secondArray[i] = numbers[0];
                    firtArray[i] = numbers[1];
                }
            }

            Console.WriteLine(string.Join(" ", firtArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}