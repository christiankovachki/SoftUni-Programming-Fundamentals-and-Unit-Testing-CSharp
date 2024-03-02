namespace _02._Rotations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int countOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfRotations; i++)
            {
                int lastElement = numbers[numbers.Count - 1];
                numbers.Insert(0, lastElement);
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}