namespace _02._Sum_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int sum = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                sum += integers[i];
            }

            Console.WriteLine(sum);
        }
    }
}