namespace _06._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArrayOfInts = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] secondArrayOfInts = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < firstArrayOfInts.Length; i++)
            {
                for (int j = 0; j < secondArrayOfInts.Length; j++)
                {
                    if (firstArrayOfInts[i] == secondArrayOfInts[j])
                    {
                        Console.Write($"{firstArrayOfInts[i]} ");
                        break;
                    }
                }
            }

        }
    }
}