namespace _05._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArrayOfInts = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] secondArrayOfInts = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            bool areIdentical = true;

            for (int i = 0; i < firstArrayOfInts.Length; i++)
            {
                if (firstArrayOfInts[i] != secondArrayOfInts[i])
                { 
                    areIdentical = false;
                    break;
                }
            }

            if (areIdentical)
            {
                Console.WriteLine("Arrays are identical.");
            }
            else
            {
                Console.WriteLine("Arrays are not identical.");
            }
        }
    }
}